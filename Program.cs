using System;
using System.Diagnostics;
using System.Drawing;
using NAudio.MediaFoundation;
using NAudio.Wave;


class Program
{
    static void Main(string[] args)
    {
        
        string filePath = @"C:\Users\aki pro\Desktop\worldexecute\world.execute-me-\noname.mp3"; // Specify the full path to your noname.mp3 file here

        double skipToSeconds = 0;

        try
        {
            using (var audioFile = new AudioFileReader(filePath))
            using (var outputDevice = new WaveOutEvent())
            {

                audioFile.CurrentTime = TimeSpan.FromSeconds(skipToSeconds);

                

                outputDevice.Init(audioFile);
                outputDevice.Play();



                /////////////////////////////////////////////////////////////////////////////////////////////////////////////
                Console.ForegroundColor = ConsoleColor.White;

                if (skipToSeconds == 0)
                {
                    TextOne();
                }
                TextTwo();
                TextThree();
                TextFour();
                TextFive();
                TextSix();
                TextSeven();
                TextEight();
                TextNine();
                if (skipToSeconds == 103.5 || skipToSeconds == 0)
                {
                    TextTen();
                }
                if (skipToSeconds == 134 || skipToSeconds == 0)
                {
                    TextEleven();
                }
                if (skipToSeconds == 148 || skipToSeconds == 0)
                {
                    TextTwelve();
                }
                if (skipToSeconds ==162.8 || skipToSeconds == 0)
                {
                    TextThirteen();
                }
                if (skipToSeconds == 205 || skipToSeconds == 0)
                {
                    ExecutionExe();
                }


                OpenUrl("https://www.youtube.com/watch?v=ESx_hy1n7HA");
                OpenUrl("");


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
    static void TextSeven()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        string text41 = "if(me.getNumStimulationsAvaible() >= you getNumStimulationsNeeded())";
        foreach (char c in text41)
        {
            Console.Write(c);
            Thread.Sleep(47);
        }
        Console.WriteLine("");
        Console.WriteLine("{");
        string text42 = "you.setSatisfaction(me.toSatisfaction());";
        foreach (char c in text42)
        {
            Console.Write(c);
            Thread.Sleep(75);
        }
        Console.WriteLine("");
        Console.WriteLine("}");
        Console.WriteLine("");
        string text43 = "if(you get.FeelingInex((\"happy\") != -1)";
        foreach (char c in text43)
        {
            Console.Write(c);
            Thread.Sleep(62);
        }
        Console.WriteLine("");
        Console.WriteLine("{");
        string text44 = "me.requestExecution(world);";
        foreach (char c in text44)
        {
            Console.Write(c);
            Thread.Sleep(40);
        }
        Console.WriteLine("");
        Console.WriteLine("}");
        string text45 = "world lockThing(me);";
        foreach (char c in text45)
        {
            Console.Write(c);
            Thread.Sleep(72);
        }
        Console.WriteLine("");
        string text46 = "world lockThing(you);";
        foreach (char c in text46)
        {
            Console.Write(c);
            Thread.Sleep(72);
        }
        Console.WriteLine("\n");
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        string text47 = "Simulation";
        foreach (char c in text47)
        {
            Console.Write(c);
            Thread.Sleep(33);
        }
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.White;
    }
    static void TextEight()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        string text48 = "if(me instanceof EggPlant)";
        foreach (char c in text48)
        {
            Console.Write(c);
            Thread.Sleep(47);
        }
        Console.WriteLine("\n{");
        string text49 = "you.addAttribute(me.getNutrients().toAttribute());";
        foreach (char c in text49)
        {
            Console.Write(c);
            Thread.Sleep(25);
        }
        Console.WriteLine("");
        string text50 = "me.resetNutrients();";
        foreach (char c in text50)
        {
            Console.Write(c);
            Thread.Sleep(25);
        }
        Console.WriteLine("\n}");
        Console.WriteLine("");


        //


        string text51 = "if(me instanceof Tomato)";
        foreach (char c in text51)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine("\n{");
        string text52 = "you.addAttribute(me.getAntioxidants().toAttribute());";
        foreach (char c in text52)
        {
            Console.Write(c);
            Thread.Sleep(25);
        }
        Console.WriteLine("");
        string text53 = "me.resetAntioxidants();";
        foreach (char c in text53)
        {
            Console.Write(c);
            Thread.Sleep(25);
        }
        Console.WriteLine("\n}");


        //


        string text54 = "if(me instanceof TabbyCat)";
        foreach (char c in text54)
        {
            Console.Write(c);
            Thread.Sleep(47);
        }
        Console.WriteLine("\n{");
        string text55 = "me.purr(); // :3";
        foreach (char c in text55)
        {
            Console.Write(c);
            Thread.Sleep(120);
        }
        Console.WriteLine("\n}");


        //



        string text56 = "if(world.getGod().equals(me))";
        foreach (char c in text56)
        {
            Console.Write(c);
            Thread.Sleep(47);
        }

        Console.WriteLine("\n{");
        string text57 = "me.setProof(you.Proof());";
        foreach (char c in text57)
        {
            Console.Write(c);
            Thread.Sleep(70);
        }
        Console.WriteLine("\n}");
        Console.WriteLine("");


    }
    static void TextNine()
    {
        Console.WriteLine("\n\n\n");
        string text58 = "me.toggleGender(); //f  //m";
        foreach (char c in text58)
        {
            Console.Write(c);
            Thread.Sleep(110);
        }
        Console.WriteLine("\n");
        string text59 = "world.procreate(me, you);";
        foreach (char c in text59)
        {
            Console.Write(c);
            Thread.Sleep(80);
        }
        Console.WriteLine("\n");
        string text60 = "me.toggleRoleBDSM();";
        foreach (char c in text60)
        {
            Console.Write(c);
            Thread.Sleep(80);
        }
        Console.WriteLine("\n\n");
        string text61 = "world.makeHigh(me);";
        foreach (char c in text61)
        {
            Console.Write(c);
            Thread.Sleep(80);
        }
        Console.WriteLine("\n");
        string text62 = "world.makeHigh(you);";
        foreach (char c in text62)
        {
            Console.Write(c);
            Thread.Sleep(80);
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n");
        string text63 = "So we can enter";
        foreach (char c in text63)
        {
            Console.Write(c);
            Thread.Sleep(80);
        }
        Console.WriteLine("\n");
        string text64 = "The tance the tance";
        foreach (char c in text64)
        {
            Console.Write(c);
            Thread.Sleep(85);
        }
    }
    static void TextTen()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n");
        string text65 = "if(me.getSenseIndex(\"";
        foreach (char c in text65)
        {
            Console.Write(c);
            Thread.Sleep(110);
        }
        Console.ForegroundColor = ConsoleColor.Green;
        string text651 = "vibation";
        foreach (char c in text651)
        {
            Console.Write(c);
            Thread.Sleep(110);
        }
        Console.ForegroundColor = ConsoleColor.White;
        string text6511 = "\"))";
        foreach (char c in text6511)
        {
            Console.Write(c);
            Thread.Sleep(110);
        }


        //


        Console.WriteLine("\n{");
        string text66 = "me.AddFeeling(\"";
        foreach (char c in text66)
        {
            Console.Write(c);
            Thread.Sleep(135);
        }
        Console.ForegroundColor = ConsoleColor.Green;
        string text661 = "complate";
        foreach (char c in text661)
        {
            Console.Write(c);
            Thread.Sleep(135);
        }
        Console.ForegroundColor = ConsoleColor.White;
        string text6611 = "\");";
        foreach (char c in text6611)
        {
            Console.Write(c);
            Thread.Sleep(135);
        }
        Console.WriteLine("\n}");

        //


        Console.WriteLine("\n");
        string text67 = "world.unlock(";
        foreach (char c in text67)
        {
            Console.Write(c);
            Thread.Sleep(15);
        }
        Console.ForegroundColor = ConsoleColor.Red;
        string text68 = "you";
        foreach (char c in text68)
        {
            Console.Write(c);
            Thread.Sleep(5);
        }
        Console.ForegroundColor = ConsoleColor.White;
        string text69 = ");";
        foreach (char c in text69)
        {
            Console.Write(c);
            Thread.Sleep(5);
        }


        //


        Console.WriteLine("\n");
        string text70 = "world.removeThing(";
        foreach (char c in text70)
        {
            Console.Write(c);
            Thread.Sleep(20);
        }
        Console.ForegroundColor = ConsoleColor.Red;
        string text71 = "you";
        foreach (char c in text71)
        {
            Console.Write(c);
            Thread.Sleep(5);
        }
        Console.ForegroundColor = ConsoleColor.White;
        string text72 = ");";
        foreach (char c in text72)
        {
            Console.Write(c);
            Thread.Sleep(5);
        }

        //


        for (int i = 0; i <= 15; i++)
        {
            Console.WriteLine("\n");
            string text73 = "me.lookFor(";
            foreach (char c in text73)
            {
                Console.Write(c);
                Thread.Sleep(10);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            string text74 = "you";
            foreach (char c in text74)
            {
                Console.Write(c);
                Thread.Sleep(5);
            }
            Console.ForegroundColor = ConsoleColor.White;
            string text75 = ", world);";
            foreach (char c in text75)
            {
                Console.Write(c);
                Thread.Sleep(10);
            }
        }


        //


        Console.WriteLine("\n");
        string text76 = "if(me.getMemory().isErasable())";
        foreach (char c in text76)
        {
            Console.Write(c);
            Thread.Sleep(110);
        }
        Console.WriteLine("\n{");
        string text77 = "me.removeFeeling(\"";
        foreach (char c in text77)
        {
            Console.Write(c);
            Thread.Sleep(150);
        }

        Console.ForegroundColor = ConsoleColor.Red;
        string text771 = "dishertened";
        foreach (char c in text771)
        {
            Console.Write(c);
            Thread.Sleep(65);
        }
        Console.ForegroundColor = ConsoleColor.White;
        string text772 = "\");";
        foreach (char c in text772)
        {
            Console.Write(c);
            Thread.Sleep(110);
        }
        Console.WriteLine("\n}");


        //


        string text78 = "try";
        foreach (char c in text78)
        {
            Console.Write(c);
            Thread.Sleep(80);
        }
        Console.WriteLine("\n{");
        string text79 = "     me.setOpinion(me.getOpinionIndex(\"you are here\"), false);";
        foreach (char c in text79)
        {
            Console.Write(c);
            Thread.Sleep(80);
        }
        Console.WriteLine("\n}");
        string text80 = "catch(IllegalArgumentException e)";
        foreach (char c in text80)
        {
            Console.Write(c);
            Thread.Sleep(75);
        }
        Console.WriteLine("\n{");
        string text81 = "     world.announce(\"";
        foreach (char c in text81)
        {
            Console.Write(c);
            Thread.Sleep(70);
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        string text811 = "God";
        foreach (char c in text811)
        {
            Console.Write(c);
            Thread.Sleep(70);
        }
        Console.ForegroundColor = ConsoleColor.White;
        string text812 = " is always true. \");";
        foreach (char c in text812)
        {
            Console.Write(c);
            Thread.Sleep(70);
        }
        Console.WriteLine("\n}");

    }
    static void TextEleven()
    {
        Console.WriteLine("\n");
        for (int i = 0; i <= 100; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(i);
            Thread.Sleep(25);
        }
        int totalNumbers = 101;

        for (int i = 0; i < totalNumbers; i++)
        {
            for (int j = totalNumbers - 1; j > i; j--)
            {
                Console.Write(" ");
            }
            Console.WriteLine(i);

            Thread.Sleep(25);
        }
        Console.ForegroundColor= ConsoleColor.Green;
        for (int i = 1; i <= 100; i++)
        {
            Console.Write("\r" + i + "%");
            Thread.Sleep(25);
            if (i == 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (i == 42)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            if(i == 54)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if (i == 78)
            {
                Console.ResetColor();
            }
            if(i == 99)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }
        Console.Write("Execution");
        Console.ForegroundColor = ConsoleColor.White;
    }
    static void TextTwelve()
    {

        
        for (int i = 0; i <25; i++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string text00 = "world.runExecution();";
            foreach (char c in text00)
            {
                Console.Write(c);
                Thread.Sleep(15);
            }
            Console.WriteLine("\n");
        }

        Console.ForegroundColor = ConsoleColor.White;
        string text1 = "world.announce(\"1\", \"de\");";
        foreach (char c in text1)
        {
            Console.Write(c);
            Thread.Sleep(15);
        }

        Console.WriteLine("\n");
        string text2 = "world.announce(\"2\", \"es\");";
        foreach (char c in text2)
        {
            Console.Write(c);
            Thread.Sleep(15);
        }

        Console.WriteLine("\n");
        string text3 = "world.announce(\"3\", \"fr\");";
        foreach (char c in text3)
        {
            Console.Write(c);
            Thread.Sleep(15);
        }

        Console.WriteLine("\n");
        string text4 = "world.announce(\"4\", \"kr\");";
        foreach (char c in text4)
        {
            Console.Write(c);
            Thread.Sleep(15);
        }

        Console.WriteLine("\n");
        string text5 = "world.announce(\"5\", \"se\");";
        foreach (char c in text5)
        {
            Console.Write(c);
            Thread.Sleep(15);
        }

        Console.WriteLine("\n");
        string text6 = "world.announce(\"6\", \"cn\");";
        foreach (char c in text6)
        {
            Console.Write(c);
            Thread.Sleep(15);
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n");
        string text0 = "world.runExecution();";
        foreach (char c in text0)
        {
            Console.Write(c);
            Thread.Sleep(15);
        }
        Console.WriteLine("\n");
        Console.ForegroundColor = ConsoleColor.White;
    }
    static void TextThirteen()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        string text1 = "if(world.isExecutableBy(me))";
        foreach (char c in text1)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine("\n{");
        string text2 = "    you.setExecution(me.toExecution());";
        foreach (char c in text2)
        {
            Console.Write(c);
            Thread.Sleep(35);
        }
        Console.WriteLine("\n}");
        Console.WriteLine("");


        //


        string text3 = "if(world.getThingIndex(you) != -1)";
        foreach (char c in text3)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine("\n{");
        string text4 = "    world.runExecution();";
        foreach (char c in text4)
        {
            Console.Write(c);
            Thread.Sleep(35);
        }
        Console.WriteLine("\n}");
        Console.WriteLine("");


        //


        string text5 = "me.escape(world);";
        foreach (char c in text5)
        {
            Console.Write(c);
            Thread.Sleep(10);
        }


        //

        Console.WriteLine("\n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        string text6 = "If i can have you back";
        foreach (char c in text6)
        {
            Console.Write(c);
            Thread.Sleep(80);
        }
        Console.WriteLine("");
        string text7 = "I will run the";
        foreach (char c in text7)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine("\n");
        Console.ForegroundColor = ConsoleColor.Red;
        string text8 = "Execution";
        foreach (char c in text8)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        string text9 = "Though we are trapped";
        foreach (char c in text9)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine("");
        string text10 = "We are tapped ";
        foreach (char c in text10)
        {
            Console.Write(c);
            Thread.Sleep(60);
        }
        Console.WriteLine("");
        string text11 = "??????????????????????";
        foreach (char c in text11)
        {
            Console.Write(c);
            Thread.Sleep(60);
        }
        Console.WriteLine("");
        string text12 = "I've studied";
        foreach (char c in text12)
        {
            Console.Write(c);
            Thread.Sleep(55);
        }
        Console.WriteLine("");
        string text13 = "I've studied how to propely";
        foreach (char c in text13)
        {
            Console.Write(c);
            Thread.Sleep(80);
        }
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n");
        string text14 = "LO-O-OVE";
        foreach (char c in text14)
        {
            Console.Write(c);
            Thread.Sleep(80);
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n");
        string text15 = "Question me";
        foreach (char c in text15)
        {
            Console.Write(c);
            Thread.Sleep(60);
        }
        Console.WriteLine("");
        string text16 = "Question me i can answer all";
        foreach (char c in text16)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n");
        string text17 = "LO-O-OVE";
        foreach (char c in text17)
        {
            Console.Write(c);
            Thread.Sleep(80);
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n");
        string text18 = "I know the algebraic expression of";
        foreach (char c in text18)
        {
            Console.Write(c);
            Thread.Sleep(90);
        }
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n");
        string text19 = "LO-O-OVE";
        foreach (char c in text19)
        {
            Console.Write(c);
            Thread.Sleep(80);
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n");
        string text20 = "Though you are free";
        foreach (char c in text20)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine("");
        string text21 = "I am trapped";
        foreach (char c in text21)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine("");
        string text23 = "Trapped in";
        foreach (char c in text23)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n");
        string text24 = "LO-O-OVE";
        foreach (char c in text24)
        {
            Console.Write(c);
            Thread.Sleep(80);
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");


    }
    static void ExecutionExe()
    {

        //all that art done on asciiart.eu website
        Thread.Sleep(15000);
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


    }
    static void OpenUrl(string url)
    {
        try
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while trying to open the URL: " + ex.Message);
        }
    }    //for url
}
