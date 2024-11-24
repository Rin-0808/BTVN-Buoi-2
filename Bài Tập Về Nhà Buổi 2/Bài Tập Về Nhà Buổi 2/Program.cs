using System;
using System.Collections.Generic;
using System.Linq;

namespace bai_tap_buoi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<sinhvien> sinhviens = new List<sinhvien> {
                new sinhvien(437,"An Khoi",14),
                new sinhvien(675,"Bao Tran",15),
                new sinhvien(803,"Minh Chau",18),
                new sinhvien(109,"Hoang Duy",17),
                new sinhvien(49,"Ngoc Thao",12),
                new sinhvien(109,"Gia Hung",19)
            };

            while (true)
            {
                Console.WriteLine("\nChọn một tùy chọn:");
                Console.WriteLine("a. In danh sách toàn bộ sinh viên.");
                Console.WriteLine("b. Tìm và in danh sách các học sinh có tuổi từ 15 đến 18.");
                Console.WriteLine("c. Tìm và in danh sách các học sinh có tên bắt đầu bằng chữ 'A'.");
                Console.WriteLine("d. Tính tổng tuổi của tất cả học sinh.");
                Console.WriteLine("e. Tìm và in học sinh có tuổi lớn nhất.");
                Console.WriteLine("f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra.");
                Console.WriteLine("q. Thoát chương trình.");

                Console.Write("Nhập lựa chọn của bạn: ");
                string choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "a":
                        Console.WriteLine("\nThông tin sinh viên:");
                        sinhviens.ForEach(sv => Console.WriteLine(sv));
                        break;

                    case "b":
                        var agelimitsv = sinhviens.Where(s => s.age >= 15 && s.age <= 18).ToList();
                        Console.WriteLine("\nCác học sinh từ 15 đến 18 tuổi:");
                        agelimitsv.ForEach(s => Console.WriteLine(s));
                        break;

                    case "c":
                        var namestarta = sinhviens.Where(s => s.name.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();
                        Console.WriteLine("\nSinh viên có tên bắt đầu bằng chữ 'A':");
                        namestarta.ForEach(s => Console.WriteLine(s));
                        break;

                    case "d":
                        int totalAge = sinhviens.Sum(s => s.age);
                        Console.WriteLine($"\nTổng tuổi của các học sinh là: {totalAge}");
                        break;

                    case "e":
                        var maxAgeStudent = sinhviens.OrderByDescending(s => s.age).FirstOrDefault();
                        Console.WriteLine($"\nHọc sinh có tuổi lớn nhất là: {maxAgeStudent}");
                        break;

                    case "f":
                        var sortedList = sinhviens.OrderBy(s => s.age).ToList();
                        Console.WriteLine("\nDanh sách học sinh theo tuổi tăng dần:");
                        sortedList.ForEach(s => Console.WriteLine(s));
                        break;

                    case "q":
                        Console.WriteLine("\nThoát chương trình.");
                        return;

                    default:
                        Console.WriteLine("\nLựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }
            }
        }
    }
}