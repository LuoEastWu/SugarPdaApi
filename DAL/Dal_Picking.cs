using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EJETable;
using SqlSugar;

namespace DAL
{
    public class Dal_Picking
    {
        /// <summary>
        /// 订单已经下架
        /// </summary>
        /// <param name="out_barcode"></param>
        /// <returns></returns>
        public bool AlreadyOutOrder(string out_barcode)
        {
            return Common.Config.StartSqlSugar<bool>((db) =>
            {
                return db.Queryable<pmw_order>()
                         .Any(a => a.order_code == out_barcode && SqlFunc.IsNullToInt(a.is_outplace) == 1);
                         
            });

        }
        /// <summary>
        /// 订单里的快递单未完全下架
        /// </summary>
        /// <param name="out_barcode"></param>
        /// <returns></returns>
        public bool OrderNotOutBillcode(string out_barcode)
        {
            return Common.Config.StartSqlSugar<bool>((db)=>
            {
                return db.Queryable<pmw_billcode>()
                         .Any(a => a.order_code == out_barcode && SqlFunc.IsNullToInt(a.is_outplace) == 0);
                               
            });
                                
        }
        /// <summary>
        /// 下架订单
        /// </summary>
        /// <param name="out_barcode"></param>
        /// <param name="scan_emp"></param>
        /// <returns></returns>
        public bool OutOrder(string out_barcode, string scan_emp)
        {
            return Common.Config.StartSqlSugar<bool>((db)=>
            {
                return db.Updateable<pmw_order>(new pmw_order
                {
                    Abnormal = false,//异常拣货时完成时改变状态
                    is_outplace = 1,
                    outplace_time = DateTime.Now,
                    outplace_emp = scan_emp,
                    Is_Operator = false,
                    is_task = 0,//释放拣货任务
                    taskName = string.Empty
                })
                                .Where(a => a.order_code == out_barcode).ExecuteCommand() > 0;
            });
                               
        }
        /// <summary>
        /// 订单下架失败后
        /// </summary>
        /// <param name="out_barcode"></param>
        public void OutOrderLoser(string out_barcode)
        {
            Common.Config.StartSqlSugar((db) => 
            {
                db.Ado.UseTran(() =>
                {
                    db.Updateable<pmw_order>(new pmw_order
                    {
                        is_task = 0,
                        taskName = string.Empty
                    })
                    .Where(a => a.order_code == out_barcode);
                    db.Updateable<pmw_billcode>(new pmw_billcode
                    {
                        is_outplace = 0,
                        outplace_emp = string.Empty,
                        outplace_time = null,

                    })
                    .Where(a => a.order_code == out_barcode);
                    throw new Exception(new Exception().Message);
                });
            });
           
        }

    }
}
