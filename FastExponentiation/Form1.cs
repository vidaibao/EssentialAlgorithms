using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Note: This project checks for overflow and underflow.
// Project > Properties > Build > Advanced > Check for arithmetic overflow/underflow.

namespace FastExponentiation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Demonstrate fast exponentiation.
        private void evaluateButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();

            try
            {
                long value = long.Parse(valueTextBox.Text);
                long exponent = long.Parse(exponentTextBox.Text);
                long result = Exponentiate(value, exponent);
                resultTextBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        /*
         * Hàm Exponentiate thực hiện phép tính lũy thừa của một số value lên một số mũ exponent. 
         * Hàm này sử dụng một phương pháp gọi là "phân rã lũy thừa" (exponentiation by squaring) 
         * để tính toán lũy thừa một cách hiệu quả. Dưới đây là cách hàm hoạt động:

        Đầu tiên, hàm tạo hai danh sách (List) powers và valueToPowers để lưu trữ các giá trị liên quan đến
        lũy thừa và giá trị của value lũy thừa tương ứng.

        Khởi tạo lastPower và lastValue với giá trị ban đầu là 1 và value tương ứng. 
        Sau đó, thêm lastPower và lastValue vào danh sách powers và valueToPowers.

        Sử dụng vòng lặp while để tính toán các lũy thừa và giá trị của value lũy thừa tương ứng. 
        Vòng lặp này tiếp tục cho đến khi lastPower lớn hơn hoặc bằng exponent. 
        Trong mỗi vòng lặp, lastPower được nhân đôi (lastPower *= 2) và 
        lastValue được bình phương (lastValue *= lastValue). 
        Kết quả này được thêm vào danh sách powers và valueToPowers.

        Sau khi đã tính toán các lũy thừa và giá trị của value lũy thừa tương ứng, 
        hàm sử dụng một biến result để tích hợp các giá trị này lại với nhau để tạo ra kết quả cuối cùng. 
        Ban đầu, result được khởi tạo bằng 1.

        Hàm sử dụng một vòng lặp for để tìm lớn nhất trong các giá trị lũy thừa trong danh sách
        powers mà vẫn nhỏ hơn hoặc bằng exponent. Sau đó, nó sử dụng giá trị tương ứng từ 
        danh sách valueToPowers để cập nhật result bằng cách nhân với giá trị đó. 
        Đồng thời, nó cập nhật exponent bằng cách trừ đi giá trị lớn nhất đã sử dụng.

        Cuối cùng, hàm trả về result là kết quả cuối cùng của phép tính lũy thừa value^exponent.
         */

        // Perform the exponentiation.
        private long Exponentiate(long value, long exponent)
        {
            // Make lists of powers and the value to that power.
            List<long> powers = new List<long>();
            List<long> valueToPowers = new List<long>();

            // Start with the power 1 and value^1.
            long lastPower = 1;
            long lastValue = value;
            powers.Add(lastPower);
            valueToPowers.Add(lastValue);

            // Calculate other powers until we get to one bigger than exponent.
            while (lastPower < exponent)
            {
                lastPower *= 2;
                lastValue *= lastValue;
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
                    result *= valueToPowers[powerIndex];
                }
            }

            // Return the result.
            return result;
        }
    }
}
