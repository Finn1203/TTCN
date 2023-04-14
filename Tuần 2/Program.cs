using System;
using System.Collections.Generic;

class SinhVien
{
    public string hoTen;
    public int tuoi;
    public double diemTBHK;

    public SinhVien(string hoten, int tuoi, double diemtbhk)
    {
        this.hoTen = hoten;
        this.tuoi = tuoi;
        this.diemTBHK = diemtbhk;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<SinhVien> danhSachSV = new List<SinhVien>();

        Console.Write("Nhập số lượng sinh viên: ");
        int soLuong = int.Parse(Console.ReadLine());

        for (int i = 0; i < soLuong; i++)
        {
            Console.WriteLine("Sinh viên thứ {0}", i + 1);

            Console.Write("Họ tên: ");
            string hoTen = Console.ReadLine();

            Console.Write("Tuổi: ");
            int tuoi = int.Parse(Console.ReadLine());

            Console.Write("Điểm TBHK: ");
            double diemTBHK = double.Parse(Console.ReadLine());

            SinhVien sv = new SinhVien(hoTen, tuoi, diemTBHK);
            danhSachSV.Add(sv);
        }

        // Sắp xếp theo độ tuổi
        danhSachSV.Sort((sv1, sv2) => sv1.tuoi.CompareTo(sv2.tuoi));

        Console.WriteLine("\nDanh sách sinh viên theo độ tuổi:");
        foreach (SinhVien sv in danhSachSV)
        {
            Console.WriteLine("Họ tên: {0}, Tuổi: {1}, Điểm TBHK: {2}", sv.hoTen, sv.tuoi, sv.diemTBHK);
        }

        // Sắp xếp theo điểm TBHK
        danhSachSV.Sort((sv1, sv2) => sv2.diemTBHK.CompareTo(sv1.diemTBHK));

        Console.WriteLine("\nDanh sách sinh viên theo điểm TBHK:");
        foreach (SinhVien sv in danhSachSV)
        {
            Console.WriteLine("Họ tên: {0}, Tuổi: {1}, Điểm TBHK: {2}", sv.hoTen, sv.tuoi, sv.diemTBHK);
        }
    }
}
