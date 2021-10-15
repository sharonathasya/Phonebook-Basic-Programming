using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    public class PhoneBook
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string[] Addresses { get; set; }
        public static List<Kontak> DaftarKontak = new List<Kontak>();

        static void Main(string[] args)
        {
            int command;
            bool exit = false;
            while (exit == false)
            {
                Console.Clear();
                Console.WriteLine("\n============ MENU NOMOR TELEPON ============");
                Console.WriteLine("1. Add Kontak");
                Console.WriteLine("2. Update Kontak");
                Console.WriteLine("3. Remove Kontak");
                Console.WriteLine("4. Listed Kontak");
                Console.WriteLine("5. Exit");
                Console.Write("Menu Dipilih : ");
                try
                {
                    command = int.Parse(Console.ReadLine());
                    switch (command)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("\n============ Masukkan Data Kontak ============");
                            Kontak.Add();
                            break;
                        case 2:
                            Console.Clear();
                            Kontak.UpdateKontak();
                            break;
                        case 3:
                            Kontak.RemoveKontak();
                            break;
                        case 4:
                            ListDaftarKontak();
                            break;
                        case 5:
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Inputan Anda Salah, masukkan angka 1-5");
                            Console.ReadKey();
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Input harus berupa angka");
                    Console.Write("Tekan apa saja untuk melanjutkan.");
                    Console.ReadKey();
                }
            }
        }


        public static void PrintKontak(Kontak Kontak)
        {
            Console.WriteLine($"First Name: {Kontak.FirstName}");
            Console.WriteLine($"Last Name: {Kontak.LastName}");
            Console.WriteLine($"Phone Number: {Kontak.PhoneNumber}");
            Console.WriteLine($"Address 1: {Kontak.Addresses[0]}");
            Console.WriteLine($"Address 2: {Kontak.Addresses[1]}");
            Console.WriteLine("----------------------------------------------------");
        }

        public static void ListDaftarKontak()
        {
            if (DaftarKontak.Count == 0)
            {
                Console.WriteLine("Buku Telepon anda kosong. Tekan apa saja untuk melanjutkan.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Berikut list Kontak Anda:\n");
            foreach (var Kontak in DaftarKontak)
            {
                PrintKontak(Kontak);
            }
            Console.WriteLine("\nTekan apa saja untuk melanjutkan.");
            Console.ReadKey();
        }

       


    }
}
