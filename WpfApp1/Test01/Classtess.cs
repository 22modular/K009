using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace K009
{
    [TestFixture]
    internal class Classtess
    {
        [Test]
        public void TestVar()
        {
            /*
             * Ví dụ về for tạo ra ma trận số theo thứ tự ngẫu nhiên
             */
            // tạo biến đến số lặp
            int countloop = 0;
            // tạo biên số lần lặp
            int countlooptime = 0;
            // tạo biến có bao nhiên giá trị 
            int countvalue = 10;
            // tạo biện số lần lặp lại
            int looptime = 5;

            // Cần đặt số ngầu nhiên chạy cần khai báo biến giá trị nhỏ nhất và giá trị lớn nhất của giá trị đó
            int minranvalue = 0;
            int maxranvalue = 50;

            // Cấu trúc câu khai báo tạo số ngẫu nhiên 
            Random rand = new Random();
            /*
             * Câu vòng lặp dùng "while" trong đó điều kiện là "countlooptime" nhỏ hơn "looptime"
             * dùng để tạo dãy số từ trên xuống dưới
             */
            while (countlooptime < looptime)
            {
                // Đặt "countloop" = 0 để viết lại từ đầu
                countloop = 0;

                // Đặt điều kiện để viết số từ trái qua phải
                while (countloop < countvalue)
                {

                    int showValue = rand.Next(minranvalue, maxranvalue);
                    /*
                     * Nếu showValue có ít hơn 8 ký tự, C# sẽ tự động thêm khoảng trắng (space) vào bên trái 
                     * của giá trị để đảm bảo tổng độ rộng là 8 ký tự
                     * Nếu showValue có nhiều hơn 8 ký tự, C# sẽ hiển thị đầy đủ giá trị mà không cắt bớt.
                     * Lưu ý : 8,.. số dương là căn lề bên phải, còn -8,... số âm là căn lề bên trái.
                     */
                    Console.Write("{0,8}", countloop);
                    countloop++;
                }
                // Sau khi xong 1 dòng là hoàn thành 1 looptime thì xuống dòng viết tiếp
                Console.WriteLine();
                // Sau đó tăng dòng là tăng countlooptime lên 1 lần nữa sao cho ko được lớn hơn looptime để nhận kết quả true
                countlooptime++;
            }
            Console.ReadKey();
        }
    }
}
