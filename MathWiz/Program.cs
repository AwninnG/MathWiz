internal class Program
{
    private static void Main(string[] args)
    {
        bool devam = true;
        bool isTurkish = true;  // isTurkish değişkenini dışarıya alıyoruz

        while (devam)
        {
            try
            {
                Console.WriteLine("    ╔═══════════════════════════════════════════╗");
                Console.WriteLine("    ║                                           ║");
                Console.WriteLine("    ║    Lütfen devam etmek için bir dil seçin  ║");
                Console.WriteLine("    ║                                           ║");
                Console.WriteLine("    ║    Please select a language to continue   ║");
                Console.WriteLine("    ║                                           ║");
                Console.WriteLine("    ║               Türkçe:  (1)                ║");
                Console.WriteLine("    ║               English: (2)                ║");
                Console.WriteLine("    ║                                           ║");
                Console.WriteLine("    ╚═══════════════════════════════════════════╝");
                Console.WriteLine(" ");

                Console.WriteLine("            ╔════════════════════╗           ");
                Console.WriteLine("            ║  made by AwninnG   ║           ");
                Console.WriteLine("            ╚════════════════════╝           ");

                Console.WriteLine(" ");

                Console.Write("Seçiminiz / Your choice: ");
                string dilSecimi = Console.ReadLine();
                isTurkish = dilSecimi == "1";  // isTurkish değerini burada ayarlıyoruz
                Console.Clear();

                Console.WriteLine("            ╔════════════════════╗           ");
                Console.WriteLine("            ║  made by AwninnG   ║           ");
                Console.WriteLine("            ╚════════════════════╝           ");
                Console.WriteLine(" ");

                // Kullanıcıdan kullanmak için 2 adet sayı alıyoruz.
                Console.Write(isTurkish ? "Lütfen Bir Sayı Giriniz: " : "Please Enter the First Number: ");
                string sayi_str1 = Console.ReadLine();

                Console.Write(isTurkish ? "Lütfen İkinci Sayıyı Giriniz: " : "Please Enter the Second Number: ");
                string sayi_str2 = Console.ReadLine();

                double sayi1, sayi2;
                bool sayi1Dogru = double.TryParse(sayi_str1, out sayi1);
                bool sayi2Dogru = double.TryParse(sayi_str2, out sayi2);

                if (sayi1Dogru && sayi2Dogru)
                {
                    Console.Clear();

                    Console.WriteLine((isTurkish ? "Birinci Sayı: " : "First Number: ") + sayi1);
                    Console.WriteLine((isTurkish ? "İkinci Sayı: " : "Second Number: ") + sayi2);
                    Console.WriteLine();

                    // Yapabileceğimiz işlemlerimiz.
                    Console.Write(isTurkish ? "(1)Toplama " : "(1)Addition ");
                    Console.Write(isTurkish ? "(2)Çıkartma " : "(2)Subtraction ");
                    Console.Write(isTurkish ? "(3)Çarpma " : "(3)Multiplication ");
                    Console.Write(isTurkish ? "(4)Bölme " : "(4)Division ");
                    Console.Write(isTurkish ? "(5)Mod Alma " : "(5)Modulo ");
                    Console.WriteLine(isTurkish ? "(6)Üs Alma " : "(6)Exponentiation ");
                    Console.WriteLine();

                    Console.Write(isTurkish ? "Lütfen Bir İşlem Seçiniz: " : "Please Select an Operation: ");
                    string numaraSec = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine((isTurkish ? "Birinci Sayı: " : "First Number: ") + sayi1);
                    Console.WriteLine((isTurkish ? "İkinci Sayı: " : "Second Number: ") + sayi2);
                    Console.WriteLine(" ");

                    int secim;
                    bool secimDogru = int.TryParse(numaraSec, out secim);

                    // Seçilen numaraya göre yapılacak işlemlerin ayarlamalarını burada yapıyoruz.
                    if (secimDogru && secim >= 1 && secim <= 6)
                    {
                        if (secim == 1)
                        {
                            Console.WriteLine((isTurkish ? "Toplama İşleminin Sonucu: " : "Result of Addition: ") + (sayi1 + sayi2));
                        }
                        else if (secim == 2)
                        {
                            Console.WriteLine((isTurkish ? "Çıkartma İşleminin Sonucu: " : "Result of Subtraction: ") + (sayi1 - sayi2));
                        }
                        else if (secim == 3)
                        {
                            Console.WriteLine((isTurkish ? "Çarpma İşleminin Sonucu: " : "Result of Multiplication: ") + (sayi1 * sayi2));
                        }
                        else if (secim == 4)
                        {
                            if (sayi2 != 0)
                            {
                                Console.WriteLine((isTurkish ? "Bölme İşleminin Sonucu: " : "Result of Division: ") + (sayi1 / sayi2));
                            }
                            else
                            {
                                Console.WriteLine(isTurkish ? "Bir sayıyı 0'a bölemezsiniz." : "You cannot divide by 0.");
                            }
                        }
                        else if (secim == 5)
                        {
                            if (sayi2 != 0)
                            {
                                Console.WriteLine((isTurkish ? "Mod Alma İşleminin Sonucu: " : "Result of Modulo: ") + (sayi1 % sayi2));
                            }
                            else
                            {
                                Console.WriteLine(isTurkish ? "Bir sayıyı 0'a bölemezsiniz." : "You cannot divide by 0.");
                            }
                        }
                        else if (secim == 6)
                        {
                            Console.WriteLine((isTurkish ? "Üs Alma İşleminin Sonucu: " : "Result of Exponentiation: ") + Math.Pow(sayi1, sayi2));
                        }

                        Console.WriteLine(" ");

                        Console.Write(isTurkish ? "Yeni bir işlem yapmak için bir tuşa basınız, Uygulamadan çıkmak için 'Esc' tuşuna basınız." :
                                                  "Press any key to perform a new operation, or press 'Esc' to exit the application.");
                        var keyPressed = Console.ReadKey().Key;
                        if (keyPressed == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            devam = false;
                        }
                        else
                        {
                            Console.Clear();
                            Console.Write(isTurkish ? "Program yeniden başlatılıyor. Lütfen bekleyiniz..." : "Restarting the program. Please wait...");
                            System.Threading.Thread.Sleep(1300);
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(isTurkish ? "Hatalı Numara, Lütfen 1 ile 6 arasında bir işlem numarası giriniz." :
                                                      "Invalid Number, Please enter an operation number between 1 and 6.");
                    }
                }
                else
                {
                    throw new FormatException(isTurkish ? "Sayı formatı hatalı." : "Number format is incorrect.");
                }
            }
            catch (FormatException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.WriteLine(isTurkish ? "Program yeniden başlatılıyor. Lütfen bekleyiniz..." : "Restarting the program. Please wait...");
                System.Threading.Thread.Sleep(1300);
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(isTurkish ? "Bir hata oluştu: " + ex.Message : "An error occurred: " + ex.Message);
                Console.WriteLine(isTurkish ? "Program yeniden başlatılıyor. Lütfen bekleyiniz..." : "Restarting the program. Please wait...");
                System.Threading.Thread.Sleep(1300);
                Console.Clear();
            }
        }
    }
}
