using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace GK
{
    public class QLSV
    {
        public List<SV> GetAllSV()
        {
            List<SV> data = new List<SV>();
            foreach (DataRow i in DBSV.Instance.DTSV.Rows)
            {
                data.Add(GetSVByDataRow(i));
            }
            return data;
        }

        public SV GetSVByDataRow(DataRow i)
        {
            return new SV
            {
                MSSV = i["MSSV"].ToString(),
                NameSV = i["NameSV"].ToString(),
                LopSH = i["LopSH"].ToString(),
                Gender = Convert.ToBoolean(i["Gender"].ToString()),
                NgaySinh = Convert.ToDateTime(i["NS"].ToString()),
                DTB = Convert.ToDouble(i["DTB"].ToString()),
                Anh = Convert.ToBoolean(i["Anh"].ToString()),
                Hocba = Convert.ToBoolean(i["HB"].ToString()),
                CCNN = Convert.ToBoolean(i["CCNN"].ToString())
            };
        }
        public List<SV> GetSVByLSH(string LSH, string txt = "")
        {
            /*List<SV> data = new List<SV>();
            if (LSH == "All")
            {
                data = GetAllSV();
            }
            else
            {
                foreach (SV sv in GetAllSV())
                {
                    if (LSH == sv._LopSH)
                    {
                        data.Add(sv);
                    }
                }
            }
            return data;*/
            List<SV> data = new List<SV>();
            if (LSH == "All")
            {
                foreach (SV i in GetAllSV())
                {
                    if (i.NameSV.Contains(txt))
                    {
                        data.Add(i);
                    }
                }
            }
            else
            {
                foreach (SV i in GetAllSV())
                {
                    if (i.LopSH == LSH && i.NameSV.Contains(txt))
                    {
                        data.Add(i);
                    }
                }
            }
                return data;
            
        }
        public List<string> GetAllLSH()
        {
            List<string> data = new List<string>();
            foreach (SV sv in GetAllSV())
            {
                data.Add(sv.LopSH);
            }
            return data;
        }
        public SV GetSVByMSSV(string mssv)
        {
            SV sv = new SV();
            foreach (SV sv2 in GetAllSV())
            {
                if (sv2.MSSV == mssv)
                {
                    sv = sv2;
                    break;
                }
            }
            return sv;
        }
        public bool AddUpdate(string MSSV)
        {
            bool add = true;
            foreach (SV sv in GetAllSV())
            {
                if (sv.MSSV == MSSV)
                {
                    add = false;
                }
            }
            return add;
        }
        public void ExecuteDB(SV s)
        {
            if (AddUpdate(s.MSSV))
            {
                DBSV.Instance.AddRow(s);
            }
            else
            {
                DBSV.Instance.UpdateRow(s);
            }
        }
    }
}