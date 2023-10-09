using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Random number generator.
        private Random Rand = new Random();

        // Pick a random number.
        private void randomButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Text = Rand.Next(int.MaxValue).ToString();
        }





        /*
         * Bài toán tìm số nguyên tố trong khoảng từ 1 đến n là một trong những bài toán quan trọng trong 
         * toán học và khoa học máy tính với nhiều ứng dụng thực tế quan trọng. 
         * Dưới đây là một số ứng dụng của bài toán này:

        Bảo mật và mã hóa: Số nguyên tố được sử dụng trong nhiều thuật toán mã hóa, 
        như RSA (Rivest-Shamir-Adleman), một hệ thống mã hóa công khai phổ biến. 
        Việc tìm số nguyên tố là quan trọng để tạo ra các khóa bảo mật và giải mã thông tin một cách an toàn.

        Tính toán số lượng ước số: Số nguyên tố là các số chỉ có hai ước số dương (1 và chính nó).
        Việc tìm số nguyên tố giúp tính toán số lượng ước số của một số, một phần quan trọng trong 
        lý thuyết số học và ứng dụng như việc kiểm tra tính nguyên tố của một số.

        Quản lý tài liệu và dữ liệu: Số nguyên tố được sử dụng để tạo ra các mã độc đáo 
        (ví dụ: ISBN cho sách, mã UPC cho sản phẩm) để quản lý và theo dõi các sản phẩm và tài liệu.

        Tối ưu hóa: Số nguyên tố có nhiều ứng dụng trong tối ưu hóa và lập lịch, 
        chẳng hạn như tạo ra các chu kỳ không trùng lặp hoặc tối ưu hóa phân phối tài nguyên.

        Xử lý dữ liệu: Trong khoa học máy tính và khoa học dữ liệu, việc tìm số nguyên tố trong 
        một khoảng có thể được sử dụng để tạo dữ liệu kiểm tra hoặc ví dụ thử nghiệm cho các thuật toán khác.

        Khoa học và toán học thuần túy: Tìm số nguyên tố là một phần quan trọng của lý thuyết số học
        và có thể được sử dụng trong nhiều nghiên cứu toán học.

        Việc tìm số nguyên tố trong khoảng từ 1 đến n không chỉ là một bài toán thú vị trong 
        toán học mà còn có nhiều ứng dụng thực tiễn quan trọng trong nhiều lĩnh vực khác nhau.
         */
        // Find a number that is probably prime.
        private void findPrimeButton_Click(object sender, EventArgs e)
        {
            // Find a probable prime.
            int numTests;
            numberTextBox.Text = FindProbablePrime(
                100000000, 2000000000, 100, out numTests).ToString();
            isPrimeTextBox.Text = "Found probable prime in " + numTests.ToString() + " attempts.";

            // Factor it.
            DisplayFactors();
        }

        // See if this number is prime.
        private void isPrimeButton_Click(object sender, EventArgs e)
        {
            int number = int.Parse(numberTextBox.Text);
            if (IsPrimeFermat(number, 100))
                isPrimeTextBox.Text = "Probably prime.";
            else
                isPrimeTextBox.Text = "Not prime.";
        }





        /*
         * Hàm IsPrimeFermat được sử dụng để kiểm tra xem một số nguyên có phải là số nguyên tố hay không, 
         * nhưng không phải là phương pháp kiểm tra tuyệt đối. 
         * Thay vào đó, nó sử dụng một phương pháp gọi là "Kiểm tra Fermat" (Fermat Primality Test) để đưa ra dự đoán xem một số có thể là số nguyên tố hoặc có thể không. Đây là cách hàm hoạt động:

        Vòng lặp chạy numTrials lần để thực hiện kiểm tra Fermat nhiều lần để tăng độ chính xác của kiểm tra. 
        Số lần kiểm tra được xác định bởi tham số numTrials.

        Trong mỗi lần kiểm tra, hàm chọn một số nguyên ngẫu nhiên test trong khoảng từ 2 đến number - 1. 
        Điều này được thực hiện để tạo ra một số nguyên ngẫu nhiên để kiểm tra tính nguyên tố của number.

        Sau khi chọn được số test, hàm kiểm tra xem test và number có nguyên tố cùng nhau (relatively prime) không.
        Điều này được thực hiện bằng cách sử dụng hàm Gcd(test, number) để tính ước số chung lớn nhất 
        (GCD - Greatest Common Divisor) của test và number. Nếu GCD bằng 1, tức là test và number nguyên tố 
        cùng nhau, hàm tiếp tục kiểm tra.

        Hàm tính giá trị của test^(number-1) mod number. Điều này tương đương với việc tính lũy thừa của 
        test lên số mũ number - 1, sau đó lấy phần dư khi chia cho number.

        Nếu kết quả tính toán trong bước trước không bằng 1 (result != 1), thì hàm trả về false, 
        đồng nghĩa với việc number không phải là số nguyên tố. Nếu kết quả tính toán là 1, 
        hàm tiếp tục vòng lặp để kiểm tra số tiếp theo.

        Nếu tất cả các lần kiểm tra đều kết thúc mà không tìm thấy bất kỳ lần nào khi kết quả 
        tính toán khác 1, thì hàm trả về true, đồng nghĩa với việc number có thể là số nguyên tố 
        (nhưng không phải tuyệt đối).



        Phương pháp kiểm tra Fermat không phải là phương pháp kiểm tra tuyệt đối để xác định một số
        có phải là số nguyên tố hay không. Thay vào đó, nó được gọi là một "phương pháp xác suất" 
        (probabilistic method) để kiểm tra số nguyên tố. Sự không chắc chắn trong kết quả xuất phát 
        từ việc nó có thể cho kết quả sai cho một số cụ thể trong một số trường hợp.

        Ứng dụng của kiểm tra Fermat và các phương pháp kiểm tra xác suất khác cho số nguyên tố thường
        liên quan đến việc thực hiện kiểm tra sơ bộ trước khi thực hiện kiểm tra số nguyên tố nghiêm ngặt
        và tốn kém hơn.
        Dưới đây là một số ứng dụng:

        Lọc số nguyên tố ứng viên: Trong các ứng dụng yêu cầu sử dụng số nguyên tố lớn 
        (ví dụ: trong mã hóa RSA), việc sử dụng kiểm tra Fermat hoặc các kiểm tra xác suất khác 
        có thể giúp lọc ra các số ứng viên có thể là số nguyên tố trước khi thực hiện kiểm tra 
        nguyên tố chi tiết và tốn kém hơn.

        Kiểm tra số nguyên tố trong các bài toán đòi hỏi độ chính xác không cao: Trong một số ứng dụng, 
        độ chính xác tuyệt đối không cần thiết và kiểm tra xác suất có thể cung cấp đủ độ tin cậy 
        cho mục đích cụ thể.

        Kiểm tra số nguyên tố trên các nền tảng có tài nguyên hạn chế: Trong môi trường có tài nguyên hạn chế,
        việc sử dụng kiểm tra xác suất có thể nhanh hơn và tiết kiệm tài nguyên hơn so với kiểm tra nguyên tố
        tuyệt đối.

        Tuy nhiên, cần lưu ý rằng kiểm tra Fermat và các kiểm tra xác suất khác có thể cho kết quả sai 
        trong một số trường hợp, do đó, nếu độ chính xác là yếu tố quan trọng, thì sau đó cần thực hiện
        kiểm tra số nguyên tố tuyệt đối để xác nhận kết quả.
         */

        // Use Fermat's little theorem to see if the number is probably prime.
        private bool IsPrimeFermat(int number, int numTrials)
        {
            for (int trial = 0; trial < numTrials; trial++)
            {
                // Pick a random test number.
                int test = Rand.Next(2, number);
                do
                {
                    test = Rand.Next(2, number);
                } while (Gcd(test, number) != 1);

                // Make sure it is relatively prime with number.

                // Calculate: test ^ (number-1) mod number.
                int result = (int)Exponentiate(test, number - 1, number);

                // If this is not -1, then the number is not prime.
                if (result != 1) return false;
            }

            // If we made it this far, the number is probably prime.
            return true;
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

        // Pick a number that is probably prime between the given bounds.
        private int FindProbablePrime(int lowerBound, int upperBound, int numTrials)
        {
            int numTests;
            return FindProbablePrime(lowerBound, upperBound, numTrials, out numTests);
        }

        // Pick a number that is probably prime between the given bounds.
        private int FindProbablePrime(int lowerBound, int upperBound, int numTrials, out int numTests)
        {
            numTests = 0;
            do
            {
                numTests++;
                int number = Rand.Next(lowerBound, upperBound);
                if (IsPrimeFermat(number, numTrials)) return number;
            } while (true);
        }

        // Factor the number.
        private void factorButton_Click(object sender, EventArgs e)
        {
            DisplayFactors();
        }
        private void DisplayFactors()
        {
            // Get the factors.
            int number = int.Parse(numberTextBox.Text);
            List<int> factors = PrimeFactors(number);

            // Display the factors.
            string result = "1";
            foreach (int factor in factors)
                result += " x " + factor.ToString();
            factorsTextBox.Text = result;
        }

        // Return the number's factors.
        private List<int> PrimeFactors(int number)
        {
            List<int> factors = new List<int>();

            // Pull out factors of 2.
            while (number % 2 == 0)
            {
                factors.Add(2);
                number /= 2;
            }

            // Check odd numbers up to Sqrt(number).
            int maxFactor = (int)Math.Sqrt(number);
            int testFactor = 3;
            while (testFactor <= maxFactor)
            {
                while (number % testFactor == 0)
                {
                    factors.Add(testFactor);
                    number /= testFactor;
                }
                maxFactor = (int)Math.Sqrt(number);
                testFactor += 2;
            }

            // If there's anything left of the number, add it.
            if (number > 1) factors.Add(number);

            return factors;
        }

        // Perform the exponentiation.
        private long Exponentiate(long value, long exponent, long modulus)
        {
            // Make lists of powers and the value to that power.
            List<long> powers = new List<long>();
            List<long> valueToPowers = new List<long>();

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

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {
            isPrimeTextBox.Clear();
            factorsTextBox.Clear();
        }
    }
}
