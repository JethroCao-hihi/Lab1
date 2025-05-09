using System; // Thư viện cơ bản của C#.
using System.Collections.Generic; // Thư viện hỗ trợ danh sách (List).
using System.IO; // Thư viện hỗ trợ thao tác với file.
using System.Linq; // Thư viện hỗ trợ các truy vấn LINQ.
using System.Text.Json; // Thư viện hỗ trợ tuần tự hóa JSON.

public class BookManager // Lớp quản lý sách.
{
    private List<Sach> books = new List<Sach>(); // Danh sách các sách.
    private readonly string filePath = "books.dat"; // Đường dẫn file lưu trữ dữ liệu sách.

    public void AddBook(Sach book) // Phương thức thêm sách vào danh sách.
    {
        books.Add(book); // Thêm sách vào danh sách.
    }

    public List<Sach> SearchByTitle(string title) // Phương thức tìm kiếm sách theo tiêu đề.
    {
        if (string.IsNullOrWhiteSpace(title)) // Kiểm tra nếu tiêu đề rỗng hoặc chỉ chứa khoảng trắng.
        {
            Console.WriteLine("Tiêu đề không được để trống.");
            return new List<Sach>();
        }
        return books.Where(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Sach> SearchByAuthor(string author) // Phương thức tìm kiếm sách theo tác giả.
    {
        if (string.IsNullOrWhiteSpace(author)) // Kiểm tra nếu tác giả rỗng hoặc chỉ chứa khoảng trắng.
        {
            Console.WriteLine("Tác giả không được để trống.");
            return new List<Sach>();
        }
        return books.Where(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public void LoadFromFile() // Phương thức tải dữ liệu sách từ file.
    {
        if (File.Exists(filePath)) // Kiểm tra nếu file tồn tại.
        {
            string json = File.ReadAllText(filePath); // Đọc nội dung file JSON.
            books = JsonSerializer.Deserialize<List<Sach>>(json) ?? new List<Sach>();
            // Giải tuần tự hóa JSON thành danh sách sách.
        }
        else
        {
            Console.WriteLine("File dữ liệu không tồn tại. Khởi tạo danh sách trống.");
            books = new List<Sach>(); // Khởi tạo danh sách trống nếu file không tồn tại.
        }
    }

    public void SaveToFile() // Phương thức lưu dữ liệu sách vào file.
    {
        string json = JsonSerializer.Serialize(books); // Tuần tự hóa danh sách sách thành JSON.
        File.WriteAllText(filePath, json); // Ghi JSON vào file.
    }

    public List<Sach> GetAllBooks() // Phương thức lấy toàn bộ danh sách sách.
    {
        return books; // Trả về danh sách sách.
    }
}