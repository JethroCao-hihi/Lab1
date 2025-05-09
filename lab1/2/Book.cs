using System; // Thư viện cơ bản của C#.

[Serializable] // Thuộc tính cho phép lớp được tuần tự hóa (serialization).
public class Sach // Lớp đại diện cho một cuốn sách.
{
    public string Title { get; set; } // Thuộc tính tiêu đề sách.
    public string Author { get; set; } // Thuộc tính tác giả sách.
    public int Year { get; set; } // Thuộc tính năm xuất bản.

    public Sach(string title, string author, int year) // Hàm khởi tạo lớp Sach.
    {
        Title = title; // Gán giá trị tiêu đề.
        Author = author; // Gán giá trị tác giả.
        Year = year; // Gán giá trị năm xuất bản.
    }

    public override string ToString() // Phương thức chuyển đối tượng sách thành chuỗi.
    {
        return $"{Title} sáng tắc bởi {Author}, phát hành năm {Year}";
    }
}