using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK
{
    public class SV
    {
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public string LopSH { get; set; }
        public bool Gender { get; set; }
        public DateTime NgaySinh { get; set; }
        public double DTB { get; set; }
        public bool Anh { get; set; }
        public bool Hocba { get; set; }
        public bool CMND { get; set; }
        public SV(string id, string name, string lop, bool gender, DateTime ns, double dtb, bool anh, bool hb, bool cmnd)
        {
            this.MSSV = id;
            this.NameSV = name;
            this.LopSH = lop;
            this.Gender = gender;
            this.NgaySinh = ns;
            this.DTB = dtb;
            this.Anh = anh;
            this.Hocba = hb;
            this.CMND = cmnd;
        }
        public SV() { }
    }
}