using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GK
{
    public class DBSV
    {

        private static DBSV _Instance;
        public static DBSV Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DBSV();
                return _Instance;
            }
            private set { }
        }

        public DataTable DTSV { get; set; }
        public DBSV()
        {
            DTSV = new DataTable();
            DTSV.Columns.AddRange(new DataColumn[] {
                new DataColumn {ColumnName = "MSSV", DataType = typeof(String)},
                new DataColumn {ColumnName ="NameSV", DataType = typeof(string)},
                new DataColumn {ColumnName ="LopSH", DataType=typeof(string)},
                new DataColumn {ColumnName = "Gender", DataType = typeof(bool)},
                new DataColumn {ColumnName ="NS", DataType=typeof(DateTime)},
                new DataColumn {ColumnName ="DTB", DataType=typeof(double)},
                new DataColumn {ColumnName ="Anh", DataType = typeof(bool)},
                new DataColumn {ColumnName = "HB", DataType=typeof(bool)},
                new DataColumn {ColumnName = "CMND", DataType=typeof(bool)}
                }

            );
            DTSV.Rows.Add("102", "NVA", "18T", true, DateTime.Now, 1.1, true, true, false);
            DTSV.Rows.Add("103", "NVB", "18T", false, DateTime.Now, 2.2, true, true, true);
            DTSV.Rows.Add("104", "NVC", "19T", true, DateTime.Now, 3.3, false, true, false);
            DTSV.Rows.Add("105", "NVD", "20T", true, DateTime.Now, 4.4, true, true, false);

        }

        public void AddDTSV(SV s)
        {
            DTSV.Rows.Add(s.MSSV, s.NameSV, s.LopSH, s.Gender, s.NgaySinh, s.DTB, s.Anh, s.Hocba, s.CMND);
        }
        public void UpdateDTSV(SV s)
        {
            DTSV.Rows.Find(s.MSSV).SetField("NameSV", s.NameSV);
            DTSV.Rows.Find(s.MSSV).SetField("LopSH", s.LopSH);
            DTSV.Rows.Find(s.MSSV).SetField("Gender", s.Gender);
            DTSV.Rows.Find(s.MSSV).SetField("Ngay Sinh", s.NgaySinh);
            DTSV.Rows.Find(s.MSSV).SetField("Anh", s.Anh);
            DTSV.Rows.Find(s.MSSV).SetField("Hoc ba", s.Hocba);
            DTSV.Rows.Find(s.MSSV).SetField("CCNN", s.CMND);
        }
        public void AddRow(SV s)
        {
           
        }
        public void UpdateRow(SV s)
        {
            
        }
        public void DelRow(string MSSV)
        {
            for (int i = DBSV.Instance.DTSV.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = DBSV.Instance.DTSV.Rows[i];
                if (dr["MSSV"].ToString() == MSSV)
                    dr.Delete();
            }
            DBSV.Instance.DTSV.AcceptChanges();
        }
    }
}
