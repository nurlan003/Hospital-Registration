using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp14
{
    static public class HospitalFunction
    {
        static public void Hospital()
        {
            Doctor dc1 = new Doctor("Ali", "Aliyev", 1, false, false, false, "Pediatr");
            Doctor dc2 = new Doctor("Vali", "Valiyev", 1, false, false, false, "Pediatr");

            Doctor dc3 = new Doctor("Memmed", "Memmedov", 1, false, false, false, "Travmatoloq");
            Doctor dc4 = new Doctor("Elvin", "Elvinov", 1, false, false, false, "Travmatoloq");

            Doctor dc5 = new Doctor("Seymur", "Seymurov", 1, false, false, false, "Stamatoloq");
            Doctor dc6 = new Doctor("Ekber", "Ekberov", 1, false, false, false, "Stamatoloq");


            while (true)
            {
                Console.Clear();

                Console.Write("Enter your name-");
                string name = Console.ReadLine();
                Console.Write("Enter your Surname-");
                string surname = Console.ReadLine();
                Console.Write("Enter your email-");
                string email = Console.ReadLine();
                Console.Write("Enter your phone number-");
                string phoneNumber = Console.ReadLine();
                bool asd = true;
                while (asd)
                {
                    Console.Clear();
                    Console.WriteLine("1-Pediatriya");
                    Console.WriteLine("2-Travmatologiya");
                    Console.WriteLine("3-Stamotologiya");
                    Console.Write(">>>");
                    string shobeSecim = Console.ReadLine();
                    if (shobeSecim=="1")
                    {
                        Console.Clear();
                        Console.WriteLine("1-Ali Aliyev");
                        Console.WriteLine("2-Vali Valiyev");
                        Console.WriteLine(">>>");
                        string dc1Select = Console.ReadLine();


                        if (dc1Select=="1")
                        {
                            while (true) {
                                Console.Clear();    
                                if (dc1.watch1==false)
                                {
                                    Console.WriteLine("1)09:00-11:00 Rezerv olunmayib");
                                }
                                else if (dc1.watch1==true)
                                {
                                    Console.WriteLine("1)09:00-11:00 Artig rezerv olunub");
                                }
                                if (dc1.watch2==false)
                                {
                                    Console.WriteLine("2)12:00-14:00 Rezerv olunmayib");
                                }
                                else if (dc1.watch2==true)
                                {
                                    Console.WriteLine("2)12:00-14:00 Artig rezerv olunub");
                                }
                                if (dc1.watch3==false)
                                {
                                    Console.WriteLine("3)15:00-17:00 Rezerv olunmayib");
                                }
                                else if (dc1.watch3==true)
                                {
                                    Console.WriteLine("3)15:00-17:00 Artig rezerv olunub");
                                }
                                Console.WriteLine("Saati secin:");
                                string AliyevSaatSecim = Console.ReadLine();
                                if (AliyevSaatSecim=="1")
                                {
                                    if (dc1.watch1==false)
                                    {
                                        Console.WriteLine($"Tesekkurler{name} {surname} siz 09:00 da {dc1.Name} hekimin qebuluna yazilmisiniz");
                                        dc1.watch1 = true;
                                        Thread.Sleep(1000);
                                        asd=false;
                                        break;
                                    }
                                    else if (dc1.watch1==true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Bu saat artig rezerv olunub!!!");
                                        Console.ResetColor();
                                        Thread.Sleep(1000);


                                    }

                                }
                                if (AliyevSaatSecim=="2")
                                {
                                    if (dc1.watch2==false)
                                    {
                                        Console.WriteLine($"Tesekkurler{name} {surname} siz 12:00 da {dc1.Name} hekimin qebuluna yazilmisiniz");
                                        dc1.watch2 = true;
                                        Thread.Sleep(1000);
                                        asd=false;

                                        break;
                                    }
                                    else if (dc1.watch2==true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Bu saat artig rezerv olunub!!!");
                                        Console.ResetColor();
                                        Thread.Sleep(1000);


                                    }
                                }
                                if (AliyevSaatSecim=="3")
                                {
                                    if (dc1.watch3==false)
                                    {
                                        Console.WriteLine($"Tesekkurler{name} {surname} siz 15:00 da {dc1.Name} hekimin qebuluna yazilmisiniz");
                                        dc1.watch3 = true;
                                        Thread.Sleep(1000);
                                        asd=false;

                                        break;
                                    }
                                    else if (dc1.watch3==true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Bu saat artig rezerv olunub!!!");
                                        Console.ResetColor();
                                        Thread.Sleep(1000);


                                    }
                                }

                            }
                        }
                        if (dc1Select=="2")
                        {
                            while (true)
                            {
                                Console.Clear();
                                if (dc2.watch1==false)
                                {
                                    Console.WriteLine("1)09:00-11:00 Rezerv olunmayib");
                                }
                                else if (dc2.watch1==true)
                                {
                                    Console.WriteLine("1)09:00-11:00 Artig rezerv olunub");
                                }
                                if (dc2.watch2==false)
                                {
                                    Console.WriteLine("2)12:00-14:00 Rezerv olunmayib");
                                }
                                else if (dc2.watch2==true)
                                {
                                    Console.WriteLine("2)12:00-14:00 Artig rezerv olunub");
                                }
                                if (dc2.watch3==false)
                                {
                                    Console.WriteLine("3)15:00-17:00 Rezerv olunmayib");
                                }
                                else if (dc2.watch3==true)
                                {
                                    Console.WriteLine("3)15:00-17:00 Artig rezerv olunub");
                                }
                                Console.WriteLine("Saati secin:");
                                string ValiyevSaatSecim = Console.ReadLine();
                                if (ValiyevSaatSecim=="1")
                                {
                                    if (dc2.watch1==false)
                                    {
                                        Console.WriteLine($"Tesekkurler{name} {surname} siz 09:00 da {dc2.Name} hekimin qebuluna yazilmisiniz");
                                        dc2.watch1 = true;
                                        Thread.Sleep(1000);
                                        asd=false;

                                        break;
                                    }
                                    else if (dc2.watch1==true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Bu saat artig rezerv olunub!!!");
                                        Console.ResetColor();
                                        Thread.Sleep(1000);


                                    }

                                }
                                if (ValiyevSaatSecim=="2")
                                {
                                    if (dc2.watch2==false)
                                    {
                                        Console.WriteLine($"Tesekkurler{name} {surname} siz 12:00 da {dc2.Name} hekimin qebuluna yazilmisiniz");
                                        dc2.watch2 = true;
                                        Thread.Sleep(1000);
                                        asd=false;

                                        break;
                                    }
                                    else if (dc2.watch2==true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Bu saat artig rezerv olunub!!!");
                                        Console.ResetColor();
                                        Thread.Sleep(1000);


                                    }
                                }
                                if (ValiyevSaatSecim=="3")
                                {
                                    if (dc2.watch3==false)
                                    {
                                        Console.WriteLine($"Tesekkurler{name} {surname} siz 15:00 da {dc2.Name} hekimin qebuluna yazilmisiniz");
                                        dc2.watch3 = true;
                                        Thread.Sleep(1000);
                                        asd=false;

                                        break;
                                    }
                                    else if (dc2.watch3==true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Bu saat artig rezerv olunub!!!");
                                        Console.ResetColor();
                                        Thread.Sleep(1000);


                                    }
                                }

                            }
                        }
                    }
                    if (shobeSecim=="2")
                    {
                        Console.Clear();

                        Console.WriteLine("1-Memmed Memmedov");
                        Console.WriteLine("2-Elvin Elvinov");
                        Console.WriteLine(">>>");
                        string dc2Select = Console.ReadLine();
                        if (dc2Select=="1")
                        {
                            while (true)
                            {
                                Console.Clear();

                                if (dc3.watch1==false)
                                {
                                    Console.WriteLine("1)09:00-11:00 Rezerv olunmayib");
                                }
                                else if (dc3.watch1==true)
                                {
                                    Console.WriteLine("1)09:00-11:00 Artig rezerv olunub");
                                }
                                if (dc3.watch2==false)
                                {
                                    Console.WriteLine("2)12:00-14:00 Rezerv olunmayib");
                                }
                                else if (dc3.watch2==true)
                                {
                                    Console.WriteLine("2)12:00-14:00 Artig rezerv olunub");
                                }
                                if (dc3.watch3==false)
                                {
                                    Console.WriteLine("3)15:00-17:00 Rezerv olunmayib");
                                }
                                else if (dc3.watch3==true)
                                {
                                    Console.WriteLine("3)15:00-17:00 Artig rezerv olunub");
                                }
                                Console.WriteLine("Saati secin:");
                                string MemmedovSaatSecim = Console.ReadLine();
                                if (MemmedovSaatSecim=="1")
                                {
                                    if (dc3.watch1==false)
                                    {
                                        Console.WriteLine($"Tesekkurler{name} {surname} siz 09:00 da {dc3.Name} hekimin qebuluna yazilmisiniz");
                                        dc3.watch1 = true;
                                        Thread.Sleep(1000);
                                        asd=false;

                                        break;
                                    }
                                    else if (dc3.watch1==true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Bu saat artig rezerv olunub!!!");
                                        Console.ResetColor();
                                        Thread.Sleep(1000);


                                    }

                                }
                                if (MemmedovSaatSecim=="2")
                                {
                                    if (dc3.watch2==false)
                                    {
                                        Console.WriteLine($"Tesekkurler{name} {surname} siz 12:00 da {dc3.Name} hekimin qebuluna yazilmisiniz");
                                        dc3.watch2 = true;
                                        Thread.Sleep(1000);
                                        asd=false;

                                        break;
                                    }
                                    else if (dc3.watch2==true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Bu saat artig rezerv olunub!!!");
                                        Console.ResetColor();
                                        Thread.Sleep(1000);


                                    }
                                }
                                if (MemmedovSaatSecim=="3")
                                {
                                    if (dc3.watch3==false)
                                    {
                                        Console.WriteLine($"Tesekkurler{name} {surname} siz 15:00 da {dc3.Name} hekimin qebuluna yazilmisiniz");
                                        dc3.watch3 = true;
                                        Thread.Sleep(1000);
                                        asd=false;

                                        break;
                                    }
                                    else if (dc3.watch3==true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Bu saat artig rezerv olunub!!!");
                                        Console.ResetColor();
                                        Thread.Sleep(1000);


                                    }
                                }
                            }
                        }
                        if (dc2Select=="2")
                        {
                            while (true)
                            {
                                Console.Clear();

                                if (dc4.watch1==false)
                                {
                                    Console.WriteLine("1)09:00-11:00 Rezerv olunmayib");
                                }
                                else if (dc4.watch1==true)
                                {
                                    Console.WriteLine("1)09:00-11:00 Artig rezerv olunub");
                                }
                                if (dc4.watch2==false)
                                {
                                    Console.WriteLine("2)12:00-14:00 Rezerv olunmayib");
                                }
                                else if (dc4.watch2==true)
                                {
                                    Console.WriteLine("2)12:00-14:00 Artig rezerv olunub");
                                }
                                if (dc4.watch3==false)
                                {
                                    Console.WriteLine("3)15:00-17:00 Rezerv olunmayib");
                                }
                                else if (dc4.watch3==true)
                                {
                                    Console.WriteLine("3)15:00-17:00 Artig rezerv olunub");
                                }
                                Console.WriteLine("Saati secin:");
                                string ElvinovSaatSecim = Console.ReadLine();
                                if (ElvinovSaatSecim=="1")
                                {
                                    if (dc4.watch1==false)
                                    {
                                        Console.WriteLine($"Tesekkurler{name} {surname} siz 09:00 da {dc4.Name} hekimin qebuluna yazilmisiniz");
                                        dc4.watch1 = true;
                                        Thread.Sleep(1000);
                                        asd=false;

                                        break;
                                    }
                                    else if (dc4.watch1==true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Bu saat artig rezerv olunub!!!");
                                        Console.ResetColor();
                                        Thread.Sleep(1000);

                                    }

                                }
                                if (ElvinovSaatSecim=="2")
                                {
                                    if (dc4.watch2==false)
                                    {
                                        Console.WriteLine($"Tesekkurler{name} {surname} siz 12:00 da {dc4.Name} hekimin qebuluna yazilmisiniz");
                                        dc4.watch2 = true;
                                        Thread.Sleep(1000);
                                        asd=false;

                                        break;
                                    }
                                    else if (dc4.watch2==true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Bu saat artig rezerv olunub!!!");
                                        Console.ResetColor();
                                        Thread.Sleep(1000);


                                    }
                                }
                                if (ElvinovSaatSecim=="3")
                                {
                                    if (dc4.watch3==false)
                                    {
                                        Console.WriteLine($"Tesekkurler{name} {surname} siz 15:00 da {dc4.Name} hekimin qebuluna yazilmisiniz");
                                        dc4.watch3 = true;
                                        Thread.Sleep(1000);
                                        asd=false;

                                        break;
                                    }
                                    else if (dc4.watch3==true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Bu saat artig rezerv olunub!!!");
                                        Console.ResetColor();
                                        Thread.Sleep(1000);


                                    }
                                }
                            }
                        }

                    }
                    if (shobeSecim=="3")
                    {
                        Console.Clear();

                        Console.WriteLine("1-Seymur Seymurov");
                        Console.WriteLine("2-Ekber Ekberov");
                        Console.WriteLine(">>>");
                        string dc3Select = Console.ReadLine();
                        if (dc3Select=="1")
                        {
                            while (true)
                            {
                                Console.Clear();

                                if (dc5.watch1==false)
                                {
                                    Console.WriteLine("1)09:00-11:00 Rezerv olunmayib");
                                }
                                else if (dc5.watch1==true)
                                {
                                    Console.WriteLine("1)09:00-11:00 Artig rezerv olunub");
                                }
                                if (dc5.watch2==false)
                                {
                                    Console.WriteLine("2)12:00-14:00 Rezerv olunmayib");
                                }
                                else if (dc5.watch2==true)
                                {
                                    Console.WriteLine("2)12:00-14:00 Artig rezerv olunub");
                                }
                                if (dc5.watch3==false)
                                {
                                    Console.WriteLine("3)15:00-17:00 Rezerv olunmayib");
                                }
                                else if (dc5.watch3==true)
                                {
                                    Console.WriteLine("3)15:00-17:00 Artig rezerv olunub");
                                }
                                Console.WriteLine("Saati secin:");
                                string SeymurovSaatSecim = Console.ReadLine();
                                if (SeymurovSaatSecim=="1")
                                {
                                    if (dc5.watch1==false)
                                    {
                                        Console.WriteLine($"Tesekkurler{name} {surname} siz 09:00 da {dc5.Name} hekimin qebuluna yazilmisiniz");
                                        dc5.watch1 = true;
                                        Thread.Sleep(1000);
                                        break;
                                    }
                                    else if (dc5.watch1==true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Bu saat artig rezerv olunub!!!");
                                        Console.ResetColor();
                                        Thread.Sleep(1000);


                                    }

                                }
                                if (SeymurovSaatSecim=="2")
                                {
                                    if (dc5.watch2==false)
                                    {
                                        Console.WriteLine($"Tesekkurler{name} {surname} siz 12:00 da {dc5.Name} hekimin qebuluna yazilmisiniz");
                                        dc5.watch2 = true;
                                        Thread.Sleep(1000);
                                        asd=false;

                                        break;
                                    }
                                    else if (dc5.watch2==true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Bu saat artig rezerv olunub!!!");
                                        Console.ResetColor();
                                        Thread.Sleep(1000);


                                    }
                                }
                                if (SeymurovSaatSecim=="3")
                                {
                                    if (dc5.watch3==false)
                                    {
                                        Console.WriteLine($"Tesekkurler{name} {surname} siz 15:00 da {dc5.Name} hekimin qebuluna yazilmisiniz");
                                        dc5.watch3 = true;
                                        Thread.Sleep(1000);
                                        asd=false;

                                        break;
                                    }
                                    else if (dc5.watch3==true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Bu saat artig rezerv olunub!!!");
                                        Console.ResetColor();
                                        Thread.Sleep(1000);


                                    }
                                }
                            }
                        }
                        if (dc3Select=="2")
                        {
                            while (true)
                            {
                                Console.Clear();

                                if (dc6.watch1==false)
                                {
                                    Console.WriteLine("1)09:00-11:00 Rezerv olunmayib");
                                }
                                else if (dc6.watch1==true)
                                {
                                    Console.WriteLine("1)09:00-11:00 Artig rezerv olunub");
                                }
                                if (dc6.watch2==false)
                                {
                                    Console.WriteLine("2)12:00-14:00 Rezerv olunmayib");
                                }
                                else if (dc6.watch2==true)
                                {
                                    Console.WriteLine("2)12:00-14:00 Artig rezerv olunub");
                                }
                                if (dc6.watch3==false)
                                {
                                    Console.WriteLine("3)15:00-17:00 Rezerv olunmayib");
                                }
                                else if (dc6.watch3==true)
                                {
                                    Console.WriteLine("3)15:00-17:00 Artig rezerv olunub");
                                }
                                Console.WriteLine("Saati secin:");
                                string EkberovSaatSecim = Console.ReadLine();
                                if (EkberovSaatSecim=="1")
                                {
                                    if (dc6.watch1==false)
                                    {
                                        Console.WriteLine($"Tesekkurler{name} {surname} siz 09:00 da {dc6.Name} hekimin qebuluna yazilmisiniz");
                                        dc6.watch1 = true;
                                        Thread.Sleep(1000);
                                        asd=false;

                                        break;
                                    }
                                    else if (dc6.watch1==true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Bu saat artig rezerv olunub!!!");
                                        Console.ResetColor();
                                        Thread.Sleep(1000);


                                    }

                                }
                                if (EkberovSaatSecim=="2")
                                {
                                    if (dc6.watch2==false)
                                    {
                                        Console.WriteLine($"Tesekkurler{name} {surname} siz 12:00 da {dc6.Name} hekimin qebuluna yazilmisiniz");
                                        dc6.watch2 = true;
                                        Thread.Sleep(1000);
                                        asd=false;

                                        break;
                                    }
                                    else if (dc6.watch2==true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Bu saat artig rezerv olunub!!!");
                                        Console.ResetColor();
                                        Thread.Sleep(1000);


                                    }
                                }
                                if (EkberovSaatSecim=="3")
                                {
                                    if (dc6.watch3==false)
                                    {
                                        Console.WriteLine($"Tesekkurler{name} {surname} siz 15:00 da {dc6.Name} hekimin qebuluna yazilmisiniz");
                                        dc6.watch3 = true;
                                        Thread.Sleep(1000);
                                        asd=false;

                                        break;
                                    }
                                    else if (dc6.watch3==true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Bu saat artig rezerv olunub!!!");
                                        Console.ResetColor();
                                        Thread.Sleep(1000);

                                    }
                                }

                            }
                        }
                    }
                }

                //Esas while
            }






            //Function finish
        }




    }
}
