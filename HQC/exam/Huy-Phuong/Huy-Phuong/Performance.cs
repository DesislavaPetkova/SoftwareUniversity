namespace Huy_Phuong
{
    using System;
   

    public class Performance : IComparable<Performance>
    {
        public Performance(string tr23, string tr32, DateTime s2, TimeSpan thoiGian, decimal gia)
        {
            this.Tr23 = tr23;
            this.Tr32 = tr32;
            this.S2 = s2;
            this.ThoiGian = thoiGian;
            this.Gia = gia;
        }

        public string Tr23 { get; protected internal set; }

        public string Tr32 { get; private set; }

        public DateTime S2 { get; set; }

        public TimeSpan ThoiGian { get; private set; }

        public decimal Gia { get; private set; }

        int IComparable<Performance>.CompareTo(Performance otherShow)
        {
            int tmp = this.S2.CompareTo(otherShow.S2);
            return tmp;
        }

        public override string ToString()
        {
            string result = string.Format(
                "BuoiDien(Tr32: {0}; Tr23: {1}; s2: {2}, ThoiGian: {3}, Gia: {4})",
                this.Tr23,
                this.Tr32,
                this.S2.ToString("dd.MM.yyyy HH:mm"),
                this.ThoiGian.ToString("hh':'mm"),
                this.Gia.ToString("f2"));
            return result;
        }
    }
}
