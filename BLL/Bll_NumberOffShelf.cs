﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Bll_NumberOffShelf
    {
         public Model.GeneralReturns NumberOffShelf(Model.M_NumberOffShelf.Request S)
         {
             Model.GeneralReturns genRet = new Model.GeneralReturns();
             if (string.IsNullOrEmpty(S.kd_billcode) || string.IsNullOrEmpty(S.scan_emp)||string.IsNullOrEmpty(S.out_barcode))
             {
                 genRet.MsgText = "参数不全，请核实快递单号拣货";
                 return genRet;
             }
             if (new DAL.Dal_NumberOffShelf().IsThereTask(S.kd_billcode, S.out_barcode))
             {
                 if (new DAL.Dal_NumberOffShelf().IsBillcodeOut(S.kd_billcode))
                 {
                     genRet.MsgText = "已下架";
                 }
                 else
                 {

                     genRet.MsgText = (genRet.State = new DAL.Dal_NumberOffShelf().ExecuteBillCodeOut(S.kd_billcode, S.scan_emp)) ? "" : "下架失败";
                 }
             }
             else 
             {
                 genRet.MsgText = "请输入对应的快递单号";
             }
             return genRet;
         }
        
    }
}
