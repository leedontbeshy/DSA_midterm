using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{

    //Tập key : Mã nhân viên => Sort theo mã nv
    //Tập value: tt cá nhân
    // 1. Lớp Employee
    public class Employee
    {
        public string FullName { get; set; }
        public bool Gender { get; set; }
        public DateTime ApprovalTime { get; set; }
        public string EducationLevel { get; set; }

        // Hàm tạo
        public Employee(string fullname, bool gender, DateTime approval_time, string education_level)
        {
            FullName = fullname;
            Gender = gender;
            ApprovalTime = approval_time;
            EducationLevel = education_level;
        }

        // Override ToString 
        public override string ToString()
        {
            return $"Tên: {FullName}, Giới tính: {(Gender ? "Nam" : "Nữ")}, " +
                   $"Thời gian vào làm: {ApprovalTime.ToShortDateString()}, " +
                   $"Trình độ: {EducationLevel}";
        }
    }

    // 2. Lớp ERM
    public class ERM
    {
        public List<string> Keys { get; set; }
        public List<Employee> Values { get; set; }
        private int n; //Tham số ánh xạ

        // Hàm tạo


        public ERM(int mappingOffset = 1)
        {
            Keys = new List<string>();
            Values = new List<Employee>();
            n = mappingOffset;
        }

        // Phương thức swap
        public void Swap(string keya, string keyb)
        {
            int a = Keys.IndexOf(keya);
            int b = Keys.IndexOf(keyb);
            if (a != -1 && b != -1)
            {

                string tempKey = Keys[a];
                Keys[a] = Keys[b];
                Keys[b] = tempKey;

                Employee Values_tt = Values[a];
                Values[a] = Values[b];
                Values[b] = Values_tt;
            }
            else
            {
                System.Console.WriteLine("Không có cặp giá trị phù hợp");
            }

        }

        // Phương thức thêm cặp khóa - giá trị
        public void Add(string key, Employee value)
        {
            Keys.Add(key);
            Values.Add(value);
        }

        // Xóa cặp khóa - giá trị
        public void Remove(string key)
        {
            int index = Keys.IndexOf(key);
            if (index != -1)
            {
                Keys.RemoveAt(index);
                Values.RemoveAt(index);
            }
        }

        // Map n-offset
        // Phương thức map
        public void Map(int n)
        {
            for (int i = 0; i < Keys.Count; i++)
            {
                if (i + n < Values.Count)
                {
                    Employee tempValue = Values[i];
                    Values[i] = Values[i + n];
                    Values[i + n] = tempValue;
                    Console.WriteLine($"Key: {Keys[i]} -> Value: {Values[i]}");
                }
            }
        }

        // Bubble Sort 
        public void BubbleSort()
        {
            int length = Keys.Count;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (string.Compare(Keys[j], Keys[j + 1]) > 0)
                    {
                        Swap(Keys[j], Keys[j + 1]);
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ERM erm = new ERM();

            // tạo mới 5 đối tượng và thêm vào erm
            erm.Add("00005", new Employee("Nguyen Van A", true, new DateTime(2024, 10, 15), "Đại học"));
            erm.Add("00009", new Employee("Nguyen Thi B", false, new DateTime(2022, 5, 20), "THPT"));
            erm.Add("00003", new Employee("Nguyen Van C", true, new DateTime(2023, 5, 10), "Thạc sĩ"));
            erm.Add("00002", new Employee("Nguyen Thi D", false, new DateTime(2014, 11, 5), "Tiến sĩ"));
            erm.Add("00006", new Employee("Nguyen Van E", true, new DateTime(2004, 6, 9), "Giáo sư"));


            // In kết quả
            Console.WriteLine("Trước sắp xếp ");
            for (int i = 0; i < erm.Keys.Count; i++)
            {
                Console.WriteLine($"Mã nhân viên: {erm.Keys[i]}: {erm.Values[i]}");
            }

            System.Console.WriteLine("");
            // Sort & in kết quả
            Console.WriteLine("\nSau Sắp xếp: ");

            erm.BubbleSort();
            for (int i = 0; i < erm.Keys.Count; i++)
            {
                Console.WriteLine($"Mã nhân viên {erm.Keys[i]}: {erm.Values[i]}");
            }

            System.Console.WriteLine("");


            erm.Map(1);
            // Xóa 1 phần tử -> in ra kết quả
            // Xóa phần tử nhân viên mã 00002

            Console.WriteLine("\nSau khi loại bỏ 00002:");
            erm.Remove("00002");
            for (int i = 0; i < erm.Keys.Count; i++)
            {
                Console.WriteLine($"Mã nhân viên {erm.Keys[i]}: {erm.Values[i]}");
            }
            Console.ReadKey();
        }
    }
}
