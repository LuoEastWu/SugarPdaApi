using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EJETable;
using SqlSugar;

namespace DAL
{
    public class DalGet_order_detail
    {

        /// <summary>
        /// 检验国家ID是否存在
        /// </summary>
        /// <param name="countryID"></param>
        /// <returns></returns>
        public bool NationalInspection(int countryID)
        {
            return Common.Config.StartSqlSugar<bool>((db) =>
            {
                return db.Queryable<pmw_country>()
                                              .Where(a => SqlFunc.IIF(a.country_id == countryID, countryID, 0) == countryID)
                                              .Any();
            });
        }




        /// <summary>
        /// 获取未完成拣货的任务
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public pmw_order IsPicking(Model.M_OffShelf.OffShelfRequest S)
        {

            return Common.Config.StartSqlSugar<pmw_order>((db) =>
            {
                return db.Queryable<pmw_order>()
                                              .Where(a => SqlFunc.IIF(a.is_task == 1, 1, 0) == 1 && a.taskName == S.Operator)
                                              .First();
            });
        }

        /// <summary>
        /// 按区域拣货
        /// </summary>
        /// <param name="S"></param>
        /// <param name="areaCode"></param>
        /// <returns></returns>
        public pmw_order RegionalPicking(int country_id, string site, string areaCode)
        {
            return Common.Config.StartSqlSugar<pmw_order>((db) =>
            {
                return db.Queryable<pmw_order, pmw_billcode, pmw_wavehouse, pmw_member>((a, b, c, d) => new object[]
                                                        {
                                                            JoinType.Left,
                                                            a.order_code==b.order_code,
                                                            b.stock_area==c.wavehouse_place_name,
                                                            a.member_id==d.id
                                                        })
                                              .Where((a, b, c, d) => SqlFunc.IIF(a.DoubleCheck == 1, 1, 0) == 1 && SqlFunc.IIF(a.is_outplace == 1, 1, 0) == 0 && SqlFunc.IIF(a.Abnormal == true, 1, 0) == 0 && SqlFunc.IIF(a.is_task == 1, 1, 0) == 0 && SqlFunc.IIF(a.country_id == country_id, country_id, 0) == country_id)
                                              .Where((a, b, c, d) => SqlFunc.IIF(b.is_outplace == 1, 1, 0) == 0 && b.wavehouse == site)
                                              .Where((a, b, c, d) => c.wavehouse_bigarea_name == areaCode)
                                              .First();
            });

        }



        /// <summary>
        /// 订单已下架，商品未完全下架
        /// </summary>
        /// <param name="orderID"></param>
        /// <returns></returns>
        public bool OrderOutBillCodeNotOut(long orderID)
        {
            return Common.Config.StartSqlSugar<bool>((db) =>
            {
                return db.Queryable<pmw_order, pmw_billcode>((a, b) => new object[]
                                          {
                                              JoinType.Left,
                                              a.order_code==b.order_code
                                          })
                               .Where((a, b) => a.id == orderID && SqlFunc.IIF(a.DoubleCheck == 1, 1, 0) == 1 && SqlFunc.IIF(a.is_outplace == 1, 1, 0) == 1)
                               .Where((a, b) => SqlFunc.IIF(b.is_outplace == 1, 1, 0) == 0)
                               .Any();
            });


        }

        /// <summary>
        /// 修改订单下架状态
        /// </summary>
        public void UpdateOrderNotOut(long orderID, int outState)
        {
            Common.Config.StartSqlSugar((db) =>
            {
                db.Updateable<pmw_order>(new pmw_order
                {
                    is_outplace = outState
                })
                        .Where(a => a.id == orderID);
            });

        }
        /// <summary>
        /// 快递没有下架
        /// </summary>
        /// <param name="orderID"></param>
        /// <returns></returns>
        public bool IsOutBillCode(long orderID)
        {
            return Common.Config.StartSqlSugar<bool>((db) =>
            {
                return db.Queryable<pmw_billcode, pmw_order>((a, b) => new object[]
                                                                   {
                                                                       JoinType.Left,
                                                                       a.order_code==b.order_code
                                                                   })
                                .Where((a, b) => SqlFunc.IIF(a.is_outplace == 1, 1, 0) == 0)
                                .Where((a, b) => b.id == orderID)
                                .Any();
            });

        }



        /// <summary>
        /// 根订单ID拣货
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="site"></param>
        /// <returns></returns>
        public pmw_order OrderIDGetTask(long orderID, string site)
        {
            return Common.Config.StartSqlSugar<pmw_order>((db) =>
            {
                return db.Queryable<pmw_order, pmw_billcode>((a, b) => new object[]
                                                            {
                                                                JoinType.Left,
                                                                a.order_code==b.order_code
                                                            })
                         .Where((a, b) => SqlFunc.IIF(a.is_outplace == 1, 1, 0) == 0 && SqlFunc.IIF(a.DoubleCheck == 1, 1, 0) == 1 && a.id == orderID)
                         .Where((a, b) => SqlFunc.IIF(b.is_outplace == 1, 1, 0) == 0 && b.wavehouse == site)
                         .OrderBy(a => a.order_time, OrderByType.Asc)
                         .First();
            });

        }




        /// <summary>
        /// 获取拣货任务
        /// </summary>
        /// <param name="S"></param>
        /// <param name="O"></param>
        /// <returns></returns>
        public DbResult<List<Model.M_OffShelf.OffShelfRuturn>> PickingTask(string operatorName, string site, EJETable.pmw_order O)
        {

            return Common.Config.StartSqlSugar<DbResult<List<Model.M_OffShelf.OffShelfRuturn>>>((db) => 
            {
                return db.Ado.UseTran<List<Model.M_OffShelf.OffShelfRuturn>>(() =>
                {
                    db.Updateable<pmw_order>(new pmw_order
                    {
                        is_task = 1,
                        taskName = operatorName
                    })
                      .Where(a => a.id == O.id && a.order_code == O.order_code);

                    return db.Queryable<pmw_order, pmw_billcode>((a, b) => new object[]
                            {
                                JoinType.Left,
                                a.order_code==b.order_code
                            })
                             .Where((a, b) => a.order_code == O.order_code && SqlFunc.IIF(a.is_task == 1, 1, 0) == 0 && SqlFunc.IIF(a.is_outplace == 1, 1, 0) == 0 && b.wavehouse == site && SqlFunc.IIF(b.is_outplace == 1, 1, 0) == 0)
                             .OrderBy((a, b) => b.stock_area)
                             .Select((a, b) => new Model.M_OffShelf.OffShelfRuturn
                             {
                                 OrderId = a.id,
                                 out_barcode = a.order_code,
                                 username = a.cus,
                                 kd_billcode = b.kd_billcode,
                                 stock_area = b.stock_area,
                                 dd_weight2 = b.dd_weight.ToString(),
                                 guige = b.dd_size,
                                 is_inplace = b.is_inplace.ToString(),
                                 number = b.number.ToString()
                             }).ToList();
                    throw new Exception("获取拣货任务失败");

                });
            });
           
        }



    }
}
