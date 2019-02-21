using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SanXuat
    {
        public string m_inout_id { get; set; } 
        public string documentno { get; set; } 
        public string dept_id { get; set; } 
        public string deptname { get; set; } 
        public string typecode { get; set; } 
        public string typename { get; set; } 
        public string document_type_code { get; set; }
        public string document_type_description { get; set; } 
        public string documentdate { get; set; }
        public string document_status_code { get; set; } 
        public string document_status_description { get; set; }
        public string inout_createtime { get; set; }

        //Inout line DTO
        public string m_inoutline_id { get; set; }
        public string headcount { get; set; }
        public string output { get; set; }
        public string effeciency { get; set; }
        public string inoutline_createtime { get; set; }
        public string inputname { get; set; }
        public string inputcode { get; set; }
        public string from { get; set; }
        public string to { get; set; }

        //Target Output line DTO
        public string headcount_target { get; set; }
        public string headcount_actual { get; set; }
        public string output_target { get; set; }
        public string output_actual { get; set; }
        public string effeciency_target { get; set; }
        public string effeciency_actual { get; set; }
        public string reason { get; set; }
    }
}
