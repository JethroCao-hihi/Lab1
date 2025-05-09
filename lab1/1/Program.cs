using System; // Thư viện cơ bản của C#.

class Program
{
    static void Main() // Điểm bắt đầu của chương trình.
    {
        QuadraticEquation2 qe2 = new QuadraticEquation2(1, -3, 2);
        // Tạo đối tượng phương trình bậc hai với A = 1, B = -3, C = 2.

        Viewer viewer = new Viewer(); // Tạo đối tượng Viewer để hiển thị kết quả.
        viewer.ShowResult(qe2); // Gọi phương thức ShowResult() để hiển thị kết quả của phương trình.
    }
}