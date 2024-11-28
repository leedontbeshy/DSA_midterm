Trong một hệ thống ERM, giả sử người ta sử dụng một dạng cấu trúc HashTable với hai tập key và value để quản lý, trong đó, tập key tương ứng với mã nhân viên và tập value tương ứng với thông tin của nhân viên. Hãy xây dựng lớp thông tin của nhân viên Employee với các thông tin sau: 
-	Họ tên của nhân viên – fullname: string 
-	Giới tính – gender: bool 
-	Thời gian vào làm – approval_time: DateTime 
-	Trình độ – education_level: string 1/ Khai báo lớp Empoyee theo mô tả ở trên. 
2/ Khai báo lớp ERM với 2 List sử dụng cho tập key và tập value. Trong đó, List<string> key tương ứng với danh sách mã nhân viên, List<Employee> tương ứng với danh sách nhân viên.  
3/ Bổ sung vào lớp ERM các phương thức Add, Remove, Map và Sort. Trong đó,  
-	Phương thức Map để tạo một ánh xạ 1-1 từ tập key sang tập value. Giả sử rằng, ánh xạ này sẽ tạo ra một vùng ngắt quãng n, với n là tham số của lớp ERM. Giá trị n có nghĩa là phần tử thứ i trong tập key sẽ tương ứng với phần tử thứ i+n trong tập value. 
-	Phương thức Add và Remove để thêm hoặc xoá một phần tử tương ứng với cặp key-value. 
-	Phương thức Sort: Sử dụng BubbleSort, để sắp xếp cấu trúc Hashtable ở trên theo thứ tự tăng dần của tập key. 
4/ Bổ sung hàm main để thực thi kết quả. 
 
Lưu ý: Dữ liệu được thêm sẵn, không nhập thủ công! 
