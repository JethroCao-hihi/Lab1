using System; // Thư viện cơ bản của C#.

public class Viewer // Lớp Viewer dùng để hiển thị kết quả của phương trình bậc hai.
{
    public void ShowResult(QuadraticEquation2 qe2) // Phương thức hiển thị kết quả của phương trình.
    {
        double[] roots = qe2.Resolve(); // Gọi phương thức Resolve() để tính nghiệm của phương trình.

        Console.WriteLine($"Phương trình : {qe2.A} x^2 + {qe2.B}x + {qe2.C} = 0");
        // Hiển thị phương trình bậc hai.

        if (roots.Length == 0) // Nếu không có nghiệm.
        {
            Console.WriteLine("Phương trình vô nghiệm."); // Hiển thị thông báo không có nghiệm.
        }
        else if (roots.Length == 1) // Nếu có nghiệm kép.
        {
            Console.WriteLine($"Phương trình có nghiệm kép: x = {roots[0]}");
            // Hiển thị nghiệm kép.
        }
        else // Nếu có hai nghiệm phân biệt.
        {
            Console.WriteLine($"Phương trình có hai nghiệm phân biệt: x1 = {roots[0]}, x2 = {roots[1]}");
            // Hiển thị hai nghiệm phân biệt.
        }
    }
}