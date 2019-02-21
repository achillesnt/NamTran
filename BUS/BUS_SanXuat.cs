using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class BUS_SanXuat
    {
        public static DataTable GetInout(string ad_ord_id, string startDate, string endDate)
        {
            return DAO_SanXuat.GetInout(ad_ord_id, startDate, endDate);
        }
        public static DataTable GetInoutbydocumentno(string documentno)
        {
            return DAO_SanXuat.GetInoutbydocumentno(documentno);
        }
        public static DataTable GetInoutLine(string m_inout_id)
        {
            return DAO_SanXuat.GetInoutLine(m_inout_id);
        }
        public static DataTable GetTargetActualLine(string deptID, string fromDate, string toDate)
        {
            return DAO_SanXuat.GetTargetActualLine(deptID, fromDate, toDate);
        }
        public static DataTable LoadInputPeriod(string ad_org_id)
        {
            return DAO_SanXuat.LoadInputPeriod(ad_org_id);
        }

        public static DataTable LoadTypename()
        {
            return DAO_SanXuat.LoadTypename();
        }
        public static DataTable LoadPartname()
        {
            return DAO_SanXuat.LoadPartname();
        }
        public static DataTable LoadRecentTypePart(string ad_org_id)
        {
            return DAO_SanXuat.LoadRecentTypePart(ad_org_id);
        }
        public static DataTable LoadDocumenttype()
        {
            return DAO_SanXuat.LoadDocumenttype();
        }
        public static bool InputLine(string m_inout_id, string inputcode, string headcount, string outputqty, string note)
        {
            return DAO_SanXuat.InputLine(m_inout_id, inputcode, headcount, outputqty, note);
        }

        public static bool InputInout(string ad_org_id, string typename, string partCode, string documenttype, string documentstatus)
        {
            return DAO_SanXuat.InputInout(ad_org_id, typename, partCode, documenttype, documentstatus);
        }
        public static bool RemoveLine(string _inoutline_id)
        {
            return DAO_SanXuat.RemoveLine(_inoutline_id);
        }

        public static bool RemoveInout(string sochungtu)
        {
            return DAO_SanXuat.RemoveInout(sochungtu);
        }
        public static DataTable ChartQtyDaily(string date, string boPhan)
        {
            return DAO_SanXuat.ChartQtyDaily(date, boPhan);
        }
        public static DataTable ChartQtyMonthly(string fromDate, string toDate, string boPhan)
        {
            return DAO_SanXuat.ChartQtyMonthly(fromDate, toDate, boPhan);
        }
        public static string ChartQtyTotal(string fromDate, string toDate, string boPhan)
        {
            return DAO_SanXuat.ChartQtyTotal(fromDate, toDate, boPhan);
        }
    }
}
