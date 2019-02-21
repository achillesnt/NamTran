using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BUS_TinhTrang
    {
        public static List<DTO_TinhTrang> LoadTinhTrang()
        {
            return DAO_TinhTrang.LoadTinhTrang();
        }
    }
}
