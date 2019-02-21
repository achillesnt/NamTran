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
    public class BUS_Ca
    {
        public static DataTable LoadCa()
        {
            return DAO_Ca.LoadCa();
        }

        public static DataTable LoadCaShift(DateTime date, string dept_id)
        {
            return DAO_Ca.LoadCaShift(date, dept_id);
        }
    }
}
