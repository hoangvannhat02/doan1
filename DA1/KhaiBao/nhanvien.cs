using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA1.KhaiBao
{
    class nhanvien
    {
        private string tennv;
        private string manv;
        private int tuoinv;
        private string gioitinhnv;
        private string quequannv;
        private string sodtnv;
        private double phucap;
        public double lcb;
        public double LCB
        {
            get { return lcb; }
            set
            {
                lcb = value;
            }
        }
        public double TinhLuong()
        {
            return PC + LCB;
        }
        public nhanvien() { }
        public nhanvien(nhanvien nv)
        {
            this.tennv = nv.tennv;
            this.manv = nv.manv;
            this.gioitinhnv = nv.gioitinhnv;
            this.tuoinv = nv.tuoinv;
            this.quequannv = nv.quequannv;
            this.sodtnv = nv.sodtnv;
            this.phucap = nv.phucap;
            this.lcb = nv.lcb;
        }
        public nhanvien(string manv, string tennv, int tuoinv, string gioitinhnv, string quequannv, string sodtnv, double phucap, double lcb)
        {
            this.tennv = tennv;
            this.manv = manv;
            this.tuoinv = tuoinv;
            this.gioitinhnv = gioitinhnv;
            this.quequannv = quequannv;
            this.sodtnv = sodtnv;
            this.phucap = phucap;
            this.lcb = lcb;
        }
        public string Ten
        {
            get { return tennv; }
            set
            {
                if(value!="")
                tennv = value;
            }
        }
        public string Ma
        {
            get { return manv; }
            set
            {
                if (value != "")
                    manv = value;
            }
        }
        public int Tuoi
        {
            get { return tuoinv; }
            set
            {
                tuoinv = value;
            }
        }
        public string Que
        {
            get { return quequannv; }
            set
            {
                if (value != "")
                quequannv = value;
            }
        }
        public string SDT
        {
            get { return sodtnv; }
            set
            {
                sodtnv = value;
            }
        }
        public string Gt
        {
            get { return gioitinhnv; }
            set
            {
                gioitinhnv = value;
            }
        }
        public double PC
        {
            get { return phucap; }
            set
            {
                phucap = value;
            }
        }
    }
}
