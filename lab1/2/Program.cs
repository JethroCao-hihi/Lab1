using System; // Thư viện cơ bản của C#.

class Program
{
    static void Main(string[] args)
    {
        BookManager quanLy = new BookManager(); // Tạo đối tượng quản lý sách.
        quanLy.LoadFromFile(); // Tải dữ liệu sách từ file.

        while (true) // Vòng lặp chính của chương trình.
        {
            Console.WriteLine("\n--- Quản Lý Sách ---"); // Hiển thị tiêu đề menu.
            Console.WriteLine("1. Thêm sách"); // Tùy chọn thêm sách.
            Console.WriteLine("2. Tìm kiếm theo tiêu đề"); // Tùy chọn tìm kiếm sách theo tiêu đề.
            Console.WriteLine("3. Tìm kiếm theo tác giả"); // Tùy chọn tìm kiếm sách theo tác giả.
            Console.WriteLine("4. Hiển thị tất cả sách"); // Tùy chọn hiển thị danh sách tất cả sách.
            Console.WriteLine("0. Thoát"); // Tùy chọn thoát chương trình.
            Console.Write("Chọn: "); // Yêu cầu người dùng nhập lựa chọn.

            string luaChon = Console.ReadLine()?.Trim() ?? ""; // Đảm bảo không có giá trị null.

            switch (luaChon) // Xử lý lựa chọn của người dùng.
            {
                case "1": // Nếu người dùng chọn thêm sách.
                    Console.Write("Tên sách: "); // Yêu cầu nhập tiêu đề sách.
                    string tieuDe = Console.ReadLine()?.Trim() ?? ""; // Đảm bảo không có giá trị null.
                    Console.Write("Tác giả: "); // Yêu cầu nhập tác giả sách.
                    string tacGia = Console.ReadLine()?.Trim() ?? ""; // Đảm bảo không có giá trị null.
                    Console.Write("Năm xuất bản: "); // Yêu cầu nhập năm xuất bản.
                    if (!int.TryParse(Console.ReadLine(), out int nam)) // Kiểm tra nếu năm xuất bản không hợp lệ.
                    {
                        Console.WriteLine("Năm xuất bản không hợp lệ. Vui lòng nhập số."); // Thông báo lỗi.
                        break; // Thoát khỏi case này.
                    }
                    quanLy.AddBook(new Sach(tieuDe, tacGia, nam)); // Thêm sách vào danh sách.
                    Console.WriteLine("Đã thêm sách."); // Thông báo thành công.
                    break;

                case "2": // Nếu người dùng chọn tìm kiếm theo tiêu đề.
                    Console.Write("Nhập tên sách để tìm: "); // Yêu cầu nhập tiêu đề cần tìm.
                    var ketQua1 = quanLy.SearchByTitle(Console.ReadLine()?.Trim() ?? ""); // Tìm kiếm sách theo tiêu đề.
                    if (ketQua1.Count == 0)
                    {
                        Console.WriteLine("Không tìm thấy sách nào.");
                    }
                    else
                    {
                        ketQua1.ForEach(s => Console.WriteLine(s)); // Hiển thị kết quả tìm kiếm.
                    }
                    break;

                case "3": // Nếu người dùng chọn tìm kiếm theo tác giả.
                    Console.Write("Nhập tác giả để tìm: "); // Yêu cầu nhập tác giả cần tìm.
                    var ketQua2 = quanLy.SearchByAuthor(Console.ReadLine()?.Trim() ?? ""); // Tìm kiếm sách theo tác giả.
                    if (ketQua2.Count == 0)
                    {
                        Console.WriteLine("Không tìm thấy sách nào.");
                    }
                    else
                    {
                        ketQua2.ForEach(s => Console.WriteLine(s)); // Hiển thị kết quả tìm kiếm.
                    }
                    break;

                case "4": // Nếu người dùng chọn hiển thị tất cả sách.
                    var allBooks = quanLy.GetAllBooks();
                    if (allBooks.Count == 0)
                    {
                        Console.WriteLine("Không có sách nào trong danh sách.");
                    }
                    else
                    {
                        allBooks.ForEach(s => Console.WriteLine(s)); // Hiển thị danh sách tất cả sách.
                    }
                    break;

                case "0": // Nếu người dùng chọn thoát.
                    quanLy.SaveToFile(); // Lưu dữ liệu sách vào file.
                    Console.WriteLine("Dữ liệu đã được lưu. Tạm biệt!"); // Thông báo thoát chương trình.
                    return; // Kết thúc chương trình.

                default: // Nếu người dùng nhập lựa chọn không hợp lệ.
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập số từ 0 đến 4."); // Thông báo lỗi.
                    break;
            }
        }
    }
}