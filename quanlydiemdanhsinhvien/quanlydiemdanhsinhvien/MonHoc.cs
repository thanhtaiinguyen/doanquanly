using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlydiemdanhsinhvien
{
    internal class MonHoc
    {
        private string m_MaMonHoc, m_TenMonHoc,m_PhanLoai;

        public string MaMonHoc
        {
            get
            {
                return m_MaMonHoc;
            }
            set
            {
                m_MaMonHoc = value;
            }
        }
        public string TenMonHoc
        {
            get
            {
                return m_TenMonHoc;
            }
            set
            {
                m_TenMonHoc = value;
            }
        }
        public string PhanLoai
        {
            get
            {
                return m_PhanLoai;
            }
            set
            {
                m_PhanLoai = value;
            }
        }
        public MonHoc()
        {
            m_TenMonHoc = " ";
            m_TenMonHoc = " ";
            m_PhanLoai = string.Empty;
        }
        public MonHoc(string mamon, string tenmon, string phanloai)
        {
            MaMonHoc = mamon;
            TenMonHoc = tenmon;
            PhanLoai = phanloai;
        }
    }
}
