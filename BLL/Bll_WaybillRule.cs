using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Model.EJETable;

namespace BLL
{
    public class Bll_WaybillRule
    {
        public Model.GeneralReturns WaybillRule()
        {
            Model.GeneralReturns gr = new Model.GeneralReturns();
            List<WaybillRule> wRule = new DAL.Dal_WaybillRule().WaybillRule();
            return gr;
        }
    }
}
