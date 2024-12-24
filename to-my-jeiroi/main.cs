using System;
using System.IO;

class Program {
  
public static void TypeWriter(string Datas){
   char [] PurposeChar = Datas.ToCharArray();

    foreach (char x in PurposeChar){
      Console.Write(x);
      System.Threading.Thread.Sleep(10);
    }
  
}
  
  public static void Main (string[] args) {

   Console.WriteLine();
    Console.WriteLine();
    string Hi = "Hi, my Jeiroi!";
    TypeWriter(Hi);
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    string GREET = File.ReadAllText("greet.txt");
    Console.ForegroundColor=ConsoleColor.Blue;
    Console.WriteLine(GREET);
    Console.WriteLine();
    string Continue = File.ReadAllText("continue.txt");
    Console.ForegroundColor=ConsoleColor.DarkGreen;
    Console.WriteLine(Continue);
    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine();
    Console.ReadKey();
    Console.Clear();


    // Entertain Oyo
    Console.ForegroundColor=ConsoleColor.DarkMagenta;
    Console.WriteLine();
    Console.WriteLine();
    string sing = "Happy birthday to you!";
    TypeWriter(sing);
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    TypeWriter(sing);
   string sing2 = "Happy birthday, happy birthday"; 
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    TypeWriter(sing2);
    string sing3 = "Happy birthday JEIRAWRRRR";
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    TypeWriter(sing3);
    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("How old are you now? Answer next to Mr. Squidward's feet pwease."); 
    string ward = File.ReadAllText("ward.txt");
    Console.ForegroundColor=ConsoleColor.Magenta;
    Console.Write(ward);
    Console.ResetColor();
    int age = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.ForegroundColor=ConsoleColor.DarkGreen;
    Console.WriteLine(Continue);
    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine();
    Console.ReadKey();
    Console.Clear();
    string Intro = File.ReadAllText("intro.txt");
    Console.ForegroundColor=ConsoleColor.Red;
    Console.WriteLine(Intro);
    Console.ResetColor();
    Console.WriteLine(Continue);
    Console.WriteLine();
    Console.ResetColor();
    Console.ReadKey();
    Console.Clear();

    Console.WriteLine();
    Console.WriteLine();
    string Awk = "You are old na :DDD";
    TypeWriter(Awk);
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine(Continue);
    Console.WriteLine();
    Console.ResetColor();
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    string Oyo = File.ReadAllText("oyo.txt");
    Console.ForegroundColor=ConsoleColor.DarkBlue;
    Console.WriteLine(Oyo);
    string finish = File.ReadAllText("finish.txt");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine(finish);
    Console.WriteLine();
    Console.ResetColor();
    Console.ReadKey();
    Console.Clear();
    string crush = File.ReadAllText("crush.txt");
    Console.ForegroundColor=ConsoleColor.Red;
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine(crush);
    
  }
  }