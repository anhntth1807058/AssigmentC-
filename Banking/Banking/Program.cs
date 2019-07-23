using System;
using Banking.controller;
using Banking.entity;

namespace Banking
{
    class Program
    {
        public static SHBAccount currentLoggedInAccount;
        public static BlockchainAddress currentLoggedInAddress;

        static void Main(string[] args)
        {
            while (true)
            {
                GiaoDich giaodich = null;
                Console.WriteLine("Vui lòng lựa chọn phương thức giao dịch.");
                Console.WriteLine("1. Giao dịch ngân hàng SHB.");
                Console.WriteLine("2. Giao dịch blockchain.");
                Console.WriteLine("Nhập lựa chọn của bạn: ");
                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        giaodich = new GiaoDichSHB();
                        break;
                    case 2:
                        giaodich = new GiaoDichBlockChain();
                        break;
                    default:
                        Console.WriteLine("Chọn sai. Vui lòng chọn lại dùm.");
                        break;
                }

                if (choice == 3)
                {
                    break;
                    ;
                }

                giaodich.Login();
                if (currentLoggedInAccount != null || currentLoggedInAddress != null)
                {
                    Console.WriteLine("Đăng nhập thành công: ");
                    GenerateTransactionMenu(giaodich);
                }
            }
        }

        private static void GenerateTransactionMenu(GiaoDich giaodich)
        {
            while (true)
            {
                Console.WriteLine("Vui lòng lựa chọn giao dịch.");
                Console.WriteLine("1. Rút tiền.");
                Console.WriteLine("2. Gửi tiền.");
                Console.WriteLine("3. Chuyển tiền.");
                Console.WriteLine("4. THoát ra.");
                Console.WriteLine("Nhập lựa chọn của bạn: ");
                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        giaodich.RutTien();
                        break;
                    case 2:
                        giaodich.GuiTien();
                        break;
                    case 3:
                        giaodich.ChuyenKhoan();
                        break;
                    case 4:
                        Console.WriteLine("Thoát ra.");
                        break;
                    default:
                        Console.WriteLine("Chọn sai. Vui lòng chọn lại dùm.");
                        break;
                }

                if (choice == 4)
                {
                    break;
                }
            }
        }
    }

    internal interface GiaoDich
    {
        void RutTien();
        void GuiTien();
        void ChuyenKhoan();
        void Login();
    }
}