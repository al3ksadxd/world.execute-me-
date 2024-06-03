using System;
using System.Drawing;
using NAudio.Wave;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"C:\Users\aki pro\Desktop\zadaci programiranje\vezbe\cs-exercises\world.execute(me)\bin\Debug\noname.mp3"; // Specify the full path to your noname.mp3 file here

        try
        {
            using (var audioFile = new AudioFileReader(filePath))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////
                Console.ForegroundColor = ConsoleColor.White;

                TextOne();
                TextTwo();
                TextThree();
                TextFour();
                TextFive();
                TextSix();






                /////////////////////////////////////////////////////////////////////////////////////////////////////////////
                Console.WriteLine("Playing... Press any key to exit.");
                Console.ReadKey(); // To keep the console open and playing
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    static void TextOne()
    {

        string text1 = "Switch on the power line";
        foreach (char c in text1)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine("");

        string text2 = "Remember to put on";
        foreach (char c in text2)
        {
            Console.Write(c);
            Thread.Sleep(60);
        }
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Red;

        string text3 = "PROTECTION";
        foreach (char c in text3)
        {
            Console.Write(c);
            Thread.Sleep(80);
        }
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.White;

        string text4 = "Lay down your pieces";
        foreach (char c in text4)
        {
            Console.Write(c);
            Thread.Sleep(70);
        }
        Console.WriteLine("");

        string text5 = "And let's begin";
        foreach (char c in text5)
        {
            Console.Write(c);
            Thread.Sleep(70);
        }
        Console.WriteLine("\n");

    }
    static void TextTwo()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        string text6 = "OBJECT CREATION";
        foreach (char c in text6)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n");

        string text7 = "Fill in my data";
        foreach (char c in text7)
        {
            Console.Write(c);
            Thread.Sleep(70);
        }
        Console.Write(" ");

        Thread.Sleep(450);
        string text8 = "p a r a m e t e r s";
        foreach (char c in text8)
        {
            Console.Write(c);
            Thread.Sleep(35);
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Thread.Sleep(30);
        string text9 = "INITIALIZATION";
        foreach (char c in text9)
        {
            Console.Write(c);
            Thread.Sleep(75);
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n");

        string text10 = "Set up our new world";
        foreach (char c in text10)
        {
            Console.Write(c);
            Thread.Sleep(75);
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");

        string text11 = "And let's begin the";
        foreach (char c in text11)
        {
            Console.Write(c);
            Thread.Sleep(75);
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n");

    }
    static void TextThree()
    {
        string text12 = "SIMULATION";
        foreach (char c in text12)
        {
            Console.Write(c);
            Thread.Sleep(75);
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");



        for (int i = 1; i <= 100; i++)
        {
            Console.Write("\r" + i + "%");

            Thread.Sleep(50);
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("DONE");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n");

        string text404 = "404--------404--------404--------404-------404--------404-------404";
        foreach (char c in text404)
        {
            Console.Write(c);
            Thread.Sleep(25);
        }
        Console.WriteLine("\n");


        string text13 = "public static void main(String[] args)";
        foreach (char c in text13)
        {
            Console.Write(c);
            Thread.Sleep(10);
        }
        Console.WriteLine("");
        Console.WriteLine("{");
        string text14 = "    Thing me = new Loveble(\"Me\", 0, true, -1, false);";
        foreach (char c in text14)
        {
            Console.Write(c);
            Thread.Sleep(10);
        }
        Console.WriteLine("");
        string text15 = "    Thing you = new Loveble(\"You\", 0, false, -1, false);";
        foreach (char c in text15)
        {
            Console.Write(c);
            Thread.Sleep(10);
        }
        Console.WriteLine("");
        Console.WriteLine("");
        string text16 = "    World world = new World(5);";
        foreach (char c in text16)
        {
            Console.Write(c);
            Thread.Sleep(10);
        }
        Console.WriteLine("");
        string text17 = "    world.addThing(me);";
        foreach (char c in text17)
        {
            Console.Write(c);
            Thread.Sleep(10);
        }
        Console.WriteLine("");
        string text18 = "    world.addThing(you);";
        foreach (char c in text18)
        {
            Console.Write(c);
            Thread.Sleep(10);
        }
        Console.WriteLine("");
        string text19 = "    world.startSimulation();";
        foreach (char c in text19)
        {
            Console.Write(c);
            Thread.Sleep(10);
        }
        Console.WriteLine("");
        Console.WriteLine("}");
        Console.WriteLine("\n");
        Thread.Sleep(100);


        //all that art done on asciiart.eu website
        Console.ForegroundColor = ConsoleColor.Magenta;
        string worldexecuteme = @"
                    _     _                           _        __            __    
__      _____  _ __| | __| |  _____  _____  ___ _   _| |_ ___ / / __ ___   __\ \ _ 
\ \ /\ / / _ \| '__| |/ _` | / _ \ \/ / _ \/ __| | | | __/ _ \ | '_ ` _ \ / _ \ (_)
 \ V  V / (_) | |  | | (_| ||  __/>  <  __/ (__| |_| | ||  __/ | | | | | |  __/ |_ 
  \_/\_/ \___/|_|  |_|\__,_(_)___/_/\_\___|\___|\__,_|\__\___| |_| |_| |_|\___| ( )
                                                              \_\            /_/|/ 
";
        foreach (char c in worldexecuteme)
        {
            Console.Write(c);
            Thread.Sleep(0);
        }
        Console.ForegroundColor = ConsoleColor.White;
        Thread.Sleep(90);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n");



        string text20 = "01110111 01101111 01110010 01101100 01100100 00101110 01100101\n01111000 01100101 01100011 01110100 01110101 01100101 00101000\n01101101 01100101 00101001 00111011";
        foreach (char c in text20)
        {
            Console.Write(c);
            Thread.Sleep(1);
        }
        Console.WriteLine("\n");
        Console.ForegroundColor = ConsoleColor.White;

    }
    static void TextFour()
    {
        string text21 = "if(me instanceof PointSet)";
        foreach (char c in text21)
        {
            Console.Write(c);
            Thread.Sleep(45);
        }
        Console.WriteLine("");
        Console.WriteLine("{");
        Console.WriteLine("");
        string text22 = "    you.addAttribute(me.getDimensions().toAttribute());";
        foreach (char c in text22)
        {
            Console.Write(c);
            Thread.Sleep(19);
        }
        Console.WriteLine("");
        string text23 = "    me.resetDimensions();";
        foreach (char c in text23)
        {
            Console.Write(c);
            Thread.Sleep(5);
        }
        Console.WriteLine("");
        Console.WriteLine("}");
        Console.WriteLine("");


        //


        string text24 = "if(me instanceof Circle)";
        foreach (char c in text24)
        {
            Console.Write(c);
            Thread.Sleep(55);
        }
        Console.WriteLine("");
        Console.WriteLine("{");
        Console.WriteLine("");
        string text25 = "    you.addAttribute(me.getCircumference().toAttribute());";
        foreach (char c in text25)
        {
            Console.Write(c);
            Thread.Sleep(30);
        }
        Console.WriteLine("");
        string text26 = "    me.resetCircumerence();";
        foreach (char c in text26)
        {
            Console.Write(c);
            Thread.Sleep(5);
        }
        Console.WriteLine("");
        Console.WriteLine("}");
        Console.WriteLine("");


        //


        string text27 = "if(me instanceof SineWave)";
        foreach (char c in text27)
        {
            Console.Write(c);
            Thread.Sleep(55);
        }
        Console.WriteLine("");
        Console.WriteLine("{");
        Console.WriteLine("");
        string text28 = "    you.addAttribute(\"sit\", me.getTangent(you.getXPosition()));";
        foreach (char c in text28)
        {
            Console.Write(c);
            Thread.Sleep(25);
        }
        Console.WriteLine("");
        Console.WriteLine("}");
        Console.WriteLine("");


        //


        string text29 = "if(me instanceof Sequence)";
        foreach (char c in text29)
        {
            Console.Write(c);
            Thread.Sleep(70);
        }
        Console.WriteLine("");
        Console.WriteLine("{");
        Console.WriteLine("");
        string text30 = "    me.setLimit(you.toLimit());";
        foreach (char c in text30)
        {
            Console.Write(c);
            Thread.Sleep(35);
        }
        Console.WriteLine("");
        Console.WriteLine("}");
        Console.WriteLine("");

    }
    static void TextFive()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        string text31 = "Switch my current";
        foreach (char c in text31)
        {
            Console.Write(c);
            Thread.Sleep(100);
        }
        Console.WriteLine("");

        string text32 = "to AC to DC";
        foreach (char c in text32)
        {
            Console.Write(c);
            Thread.Sleep(150);
        }
        Console.WriteLine("");

        string text33 = "And then blind my vision";
        foreach (char c in text33)
        {
            Console.Write(c);
            Thread.Sleep(60);
        }
        Console.WriteLine("\n");

        Console.ForegroundColor = ConsoleColor.White;
        string text34 = "me.addFeeling(\"dizzy\");";
        foreach (char c in text34)
        {
            Console.Write(c);
            Thread.Sleep(40);
        }
        Console.WriteLine("");

        string text35 = $"me.addFeeling(\"dizzy\");";
        foreach (char c in text35)
        {
            Console.Write(c);
            Thread.Sleep(40);
        }
        Console.WriteLine("");

        string text36 = "me.canSee(false);";
        foreach (char c in text36)
        {
            Console.Write(c);
            Thread.Sleep(8);
        }

    }
    static void TextSix()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n");
        string text37 = "OH we can travel";
        foreach (char c in text37)
        {
            Console.Write(c);
            Thread.Sleep(100);
        }
        Console.WriteLine("");
        string text38 = "To";
        foreach (char c in text38)
        {
            Console.Write(c);
            Thread.Sleep(15);
        }
        Console.WriteLine("");
        string text39 = "B.C--------------------------------A.D";
        foreach (char c in text39)
        {
            Console.Write(c);
            Thread.Sleep(30);
        }
        Console.WriteLine("");
        string text40 = "And we can unite";
        foreach (char c in text40)
        {
            Console.Write(c);
            Thread.Sleep(150);
        }
        Console.WriteLine("");
        string text41 = "So deeply so deeply";
        foreach (char c in text41)
        {
            Console.Write(c);
            Thread.Sleep(100);
        }
        Console.WriteLine("");
    }
}