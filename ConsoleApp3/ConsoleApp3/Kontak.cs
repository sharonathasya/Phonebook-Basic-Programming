using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp3
{
    public class Kontak:PhoneBook
    {
        public static void Add()
        {
            Kontak Kontak = new Kontak();

            Console.Write("First Name: ");
            Kontak.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            Kontak.LastName = Console.ReadLine();

            Console.Write("Phone Number: ");
            Kontak.PhoneNumber = Console.ReadLine();

            Console.Write("Address 1: ");
            string[] addresses = new string[2];
            addresses[0] = Console.ReadLine();
            Console.Write("Address 2 (Optional): ");
            addresses[1] = Console.ReadLine();
            Kontak.Addresses = addresses;

            DaftarKontak.Add(Kontak);
        }

        public static void UpdateKontak()
        {
            Console.WriteLine("Masukkan Nama Depan dari Kontak yang akan diupdate.");
            Console.WriteLine("----------------------------------------------------");
            string firstName = Console.ReadLine();
            Kontak Kontak = DaftarKontak.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());
            if (Kontak == null)
            {
                Console.Write("Kontak tersebut tidak dapat ditemukan. Tekan apa saja untuk melanjutkan");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("----------------------------------------------------");
            Console.Write("Yakin akan mengupdate Kontak ini? (Y/T)\n");
            PrintKontak(Kontak);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {

                Console.Write("\nNomor Telepon Terbaru: ");
                var NewPhoneNumber = Console.ReadLine();
                Kontak.PhoneNumber = NewPhoneNumber;

                Console.WriteLine("-----------------------------------------------");

                PrintKontak(Kontak);
                Console.Write("Kontak sudah terupdate. Tekan apa saja untuk melanjutkan.");
                Console.ReadKey();
            }
        }

        public static void RemoveKontak()
        {
            Console.WriteLine("Masukkan Nama Depan dari Kontak yang ingin dihapus.");
            string firstName = Console.ReadLine();
            Kontak Kontak = DaftarKontak.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());
            if (Kontak == null)
            {
                Console.Write("Kontak tersebut tidak dapat ditemukan. Tekan apa saja untuk melanjutkan");
                Console.ReadKey();
                return;
            }

            Console.Write("Yakin akan menghapus Kontak ini? (Y/T)");
            PrintKontak(Kontak);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                DaftarKontak.Remove(Kontak);
                Console.Write("Kontak terhapus. Tekan apa saja untuk melanjutkan.");
                Console.ReadKey();
            }
        }

    }
}
