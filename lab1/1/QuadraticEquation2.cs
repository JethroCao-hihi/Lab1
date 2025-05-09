public class QuadraticEquation2 // Lớp đại diện cho phương trình bậc hai.
{
    public double A { get; set; } // Hệ số A của phương trình.
    public double B { get; set; } // Hệ số B của phương trình.
    public double C { get; set; } // Hệ số C của phương trình.

    public QuadraticEquation2(double a, double b, double c) // Hàm khởi tạo lớp.
    {
        A = a; // Gán giá trị hệ số A.
        B = b; // Gán giá trị hệ số B.
        C = c; // Gán giá trị hệ số C.
    }

    public double[] Resolve() // Phương thức tính nghiệm của phương trình.
    {
        if (A == 0) // Kiểm tra nếu A bằng 0.
        {
            throw new ArgumentException("A không được bằng 0.");
            // Ném ngoại lệ vì phương trình không phải bậc hai.
        }

        double delta = B * B - 4 * A * C; // Tính delta của phương trình.

        if (delta < 0) // Nếu delta < 0.
        {
            return new double[0]; // Không có nghiệm thực.
        }
        else if (delta == 0) // Nếu delta = 0.
        {
            double root = -B / (2 * A); // Tính nghiệm kép.
            return new double[] { root }; // Trả về nghiệm kép.
        }
        else // Nếu delta > 0.
        {
            double root1 = (-B + Math.Sqrt(delta)) / (2 * A); // Tính nghiệm thứ nhất.
            double root2 = (-B - Math.Sqrt(delta)) / (2 * A); // Tính nghiệm thứ hai.
            return new double[] { root1, root2 }; // Trả về hai nghiệm phân biệt.
        }
    }
}