using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HashSet: tekrar edenleri engeller
            HashSet<string> kursiyerler = new HashSet<string>
        {
            "Zeynep", "Ali", "Zeynep", "Ahmet"
        };
            Console.WriteLine("HashSet - Tekrar Etmeyen Kursiyerler:");
            foreach (var k in kursiyerler)
                Console.WriteLine(k); // Zeynep yalnızca 1 kez görünür

            // Stack: LIFO (Last In First Out)
            Stack<string> kitaplar = new Stack<string>();
            kitaplar.Push("C# Giriş");
            kitaplar.Push("Veri Yapıları");
            kitaplar.Push("Algoritmalar");

            Console.WriteLine("\nStack - Kitap Yığını:");
            while (kitaplar.Count > 0)
                Console.WriteLine(kitaplar.Pop()); // Son eklenen ilk çıkar

            // Queue: FIFO (First In First Out)
            Queue<string> islemler = new Queue<string>();
            islemler.Enqueue("Login");
            islemler.Enqueue("Dosya Aç");
            islemler.Enqueue("Çıkış Yap");

            Console.WriteLine("\nQueue - İşlem Sırası:");
            while (islemler.Count > 0)
                Console.WriteLine(islemler.Dequeue()); // İlk eklenen ilk çıkar
        }
    }
}
