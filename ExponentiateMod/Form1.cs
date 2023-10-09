using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExponentiateMod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Demonstrate fast exponentiation with a modulus.
        private void evaluateButton_Click(object sender, EventArgs e)
        {
            long value = long.Parse(valueTextBox.Text);
            long exponent = long.Parse(exponentTextBox.Text);
            long modulus = long.Parse(modulusTextBox.Text);
            long result = Exponentiate(value, exponent, modulus);
            resultTextBox.Text = result.ToString();
        }


        /*
         * Hàm này thực hiện phép tính lũy thừa (exponentiation) của một số nguyên (value) 
         * theo một số mũ (exponent) trong một modulo (modulus) đã cho. 
         * Hàm này sử dụng một phương pháp gọi là "lũy thừa modulo" để tính toán lũy thừa mà không bị tràn số.

        Dưới đây là cách hàm hoạt động:

        Tạo danh sách (List) powers và valueToPowers để lưu trữ các giá trị liên quan đến lũy thừa và 
        giá trị của value^lũy thừa tương ứng.

        Kiểm tra xem modulus có phải là số dương hay không. Nếu modulus bằng 0, hàm hiển thị một thông báo
        lỗi và trả về -1.

        Giới hạn giá trị của value bằng modulus (value = value % modulus). Điều này đảm bảo rằng value 
        không lớn hơn modulus.

        Khởi tạo lastPower và lastValue với giá trị ban đầu là 1 và value tương ứng. Sau đó, 
        thêm lastPower và lastValue vào danh sách powers và valueToPowers.

        Sử dụng vòng lặp while để tính toán các lũy thừa và giá trị của value^lũy thừa. 
        Lặp cho đến khi lastPower lớn hơn hoặc bằng exponent.

        Tính toán kết quả cuối cùng bằng cách sử dụng một vòng lặp for để tách giá trị của exponent
        thành các lũy thừa nhỏ hơn và nhân chúng với giá trị tương ứng của value^lũy thừa vào result. Kết quả cuối cùng là result % modulus để đảm bảo rằng nó nằm trong khoảng từ 0 đến modulus - 1.

        Trả về kết quả cuối cùng là lũy thừa của value theo exponent trong modulo modulus.

        Hàm này hữu ích trong các lĩnh vực như mã hóa và giải mã, mật mã học, và các ứng dụng liên quan
        đến tính toán trên các miền hữu hạn.*/
        
        
        // Perform the exponentiation.
        private long Exponentiate(long value, long exponent, long modulus)
        {
            // Make lists of powers and the value to that power.
            List<long> powers = new List<long>();
            List<long> valueToPowers = new List<long>();

            if (modulus == 0)
            {
                MessageBox.Show("Modulus must be greater than 0");
                return -1;
            }

            // Makes sure the value isn't greater than the modulus.
            value = value % modulus;

            // Start with the power 1 and value^1.
            long lastPower = 1;
            long lastValue = value;
            powers.Add(lastPower);
            valueToPowers.Add(lastValue);

            // Calculate other powers until we get to one bigger than exponent.
            while (lastPower < exponent)
            {
                lastPower *= 2;
                lastValue = (lastValue * lastValue) % modulus;
                powers.Add(lastPower);
                valueToPowers.Add(lastValue);
            }

            // Combine values to make the required power.
            long result = 1;

            // Get the index of the largest power that is smaller than exponent.
            for (int powerIndex = powers.Count - 1; powerIndex >= 0; powerIndex--)
            {
                // See if this power fits within exponent.
                if (powers[powerIndex] <= exponent)
                {
                    // It fits. Use this power.
                    exponent -= powers[powerIndex];
                    result = (result * valueToPowers[powerIndex]) % modulus;
                }
            }

            // Return the result.
            return result;
        }
    }
}
