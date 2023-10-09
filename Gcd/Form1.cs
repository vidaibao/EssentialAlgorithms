using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gcd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findGcdButton_Click(object sender, EventArgs e)
        {
            long number1 = long.Parse(number1TextBox.Text);
            long number2 = long.Parse(number2TextBox.Text);

            long gcd = Gcd(number1, number2);
            gcdTextBox.Text = gcd.ToString();

            long lcm = Lcm(number1, number2);
            lcmTextBox.Text = lcm.ToString();
        }

        // Find Greatest Common Divisor  -  Tìm ước số chung lớn nhất của 2 số
        // -    Euclid algorithm
        /*
         *  Bài toán "Tìm ước số chung lớn nhất của hai số" (Greatest Common Divisor - GCD) có nhiều ứng dụng
         *  thực tế quan trọng trong nhiều lĩnh vực khác nhau, bao gồm:

            1. Toán học:
            Trong toán học thuần túy, việc tìm GCD của hai số là một phần quan trọng của lý thuyết số học
            và cơ sở cho nhiều thuật toán khác, như tối giản phân số, kiểm tra tính nguyên tố, và nhiều 
            vấn đề liên quan đến số học.
        
            2. Kỹ thuật:
            Trong lĩnh vực kỹ thuật và khoa học máy tính, GCD được sử dụng để tối ưu hóa các thuật toán và 
            cấu trúc dữ liệu, chẳng hạn như việc tối ưu hóa thuật toán Euclid để tìm GCD.
            GCD cũng được sử dụng trong việc tạo ra các hàm băm hiệu quả cho các cơ sở dữ liệu và cấu trúc 
            dữ liệu như bộ chia và gộp (hash tables).
            
            3. Khoa học và công nghệ:
            Trong công nghệ thông tin và truyền thông, GCD có thể được sử dụng để tối ưu hóa quy trình mã hóa và 
            giải mã dữ liệu.
            Trong khoa học, nó có thể được áp dụng trong việc tối ưu hóa thời gian và tài nguyên khi lập kế hoạch
            thí nghiệm hoặc sử dụng máy tính siêu lớn.
            
            4. Tài chính:
            GCD cũng có ứng dụng trong tài chính để tính toán lãi suất và chu kỳ thanh toán, đặc biệt trong 
            lĩnh vực tài trợ và quản lý tài chính.
        
            5. Mạng:
            Trong lĩnh vực mạng, GCD có thể được sử dụng để đồng bộ hóa các chu kỳ thời gian, chẳng hạn như 
            đồng bộ hóa giao thức trên các thiết bị mạng.
        */


        // Find GCD(a, b) recursively.
        // GCD(a, b) = GCD(b, a mod b).
        private long RecursiveGcd(long a, long b)
        {
            if (b == 0) return a;
            return RecursiveGcd(b, a % b);
        }

        // Find GCD(a, b).
        // GCD(a, b) = GCD(b, a mod b).
        private long Gcd(long a, long b)
        {
            while (b != 0)
            {
                // Calculate the remainder.
                long remainder = a % b;

                // Calculate GCD(b, remainder).
                a = b;
                b = remainder;
            }

            // GCD(a, 0) is a.
            return a;
        }





        /*
         * LCM là viết tắt của "Least Common Multiple" trong tiếng Anh, còn được gọi là Bội số chung nhỏ nhất
         * trong tiếng Việt. LCM của hai hoặc nhiều số là số nguyên dương nhỏ nhất mà tất cả các số đó chia hết
         * cho nó mà không có số nào nhỏ hơn chia hết cho nó.

            LCM thường được ký hiệu bằng ký tự "lcm" hoặc bằng "máu chung nhỏ nhất". 
            Ví dụ, LCM của các số 4 và 6 là 12, vì 12 là số nhỏ nhất mà cả 4 và 6 đều chia hết.

            LCM có nhiều ứng dụng trong toán học và thực tế, bao gồm:

            Tối giản phân số: Để tối giản phân số, bạn cần tính LCM của tử số và mẫu số, sau đó chia cả tử số 
            và mẫu số cho LCM đó.

            Quản lý thời gian: LCM được sử dụng để đồng bộ hóa thời gian và lên kế hoạch trong nhiều lĩnh vực,
            chẳng hạn như lên lịch học, quản lý dự án và quản lý sản xuất.

            Mạng: Trong lĩnh vực mạng, LCM có thể được sử dụng để đồng bộ hóa các chu kỳ thời gian, 
            chẳng hạn như đồng bộ hóa giao thức trên các thiết bị mạng.

            Khoa học máy tính: LCM có thể được sử dụng trong thuật toán và cấu trúc dữ liệu, 
            chẳng hạn như lập kế hoạch thời gian cho các sự kiện hoặc xác định tần số thực hiện một loạt tác vụ.

            Ví dụ:
            LCM của 4 và 6 là 12.
            LCM của 8, 12 và 18 là 72.
            LCM của 5, 7 và 9 là 315.
         */

        // Find LCM(a, b).
        // LCM(a, b) = a * b * GCD(a, b).
        private long Lcm(long a, long b)
        {
            return a * (b / Gcd(a, b));
        }
    }
}
