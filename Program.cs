using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicegame
{
    internal class Program
    {
        static string player1;
        static string player2;
        static string logic1;
        private static int val1 = 0;
        public static int val2 = 0;
        private static int p1;
        private static int p2;



        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------------------- \n \t \t   WELCOME TO THE TWO PLAYER DICE GAME \n ---------------------------------------------------------------------------- \n \t \t   ENTER THE PALYERS NAMES  \n ---------------------------------------------------------------------------- ");
            Console.WriteLine("----------------------------------------GAME RULES  :      -------------------------------------------------------------\n If 02 dices give the same result (except the dice value 1), the same player will get another\r\nchance to roll the dice.\r\n• Else other player gets the chance to roll 02 dices.\n");
            Console.WriteLine("----------------------------------------Calculation of score  :---------------------------------------------------------  \r\n• If both dices give the value 1, the individual marks of the respective player will be\r\nreduced to 0.\r\n• Else sum of the two dice values will be added to individual scores of the respective\r\nplayer.\r\n");
            Console.WriteLine("FIRST PLAYER NAME   :"); player1 = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------------------------------- \n");
            Console.WriteLine("SECOND PLAYER NAME   :"); player2 = Console.ReadLine();

            Console.WriteLine("\n---------------------------------------------------------------------------- \n  FIRST PLAYER TERM \n---------------------------------------------------------------------------- \n");
            //Console.WriteLine("...................................... START THE GAME ENTER ANY.......................................");
            Console.WriteLine("...................................... IF YOU READY TO PLAY ENTER 'Y' .......................................\n----------- YOU CAN START THE GAME ENTER 'Y' -----------\n -----------------------------------------------------------------------------");

            logic1 = Console.ReadLine();
            if (logic1 != "Y")
            {
                  Console.WriteLine("...................................... IF YOU READY TO PLAY ENTER 'Y' .......................................\n-----------  IF YOU DO NOT ENTER 'Y' -----------\n ----------- YOU ARE GOING TO EXIT THE GAME.....................................");
                logic1 = Console.ReadLine();
                if (logic1 != "Y")
                {
                    Console.WriteLine("-----------------------------------------------------------------------\n           SORRY GAME IS OVER BECAUSE OG NOT FOLLOWING THE INSTRUCTION!!!!!!!!!!!!!!!!!!!!!!!!!!!!!       \n  ----------------------------------------------------------------------------------");
                }
                else
                {
                    play1();
                }
            }
            else
            {
                play1();
            }
            //play1();
        }



        static void play1()
        {
            
            Random rand = new Random(); p1 = rand.Next(1, 7);
            //Random wanf = new Random(); 
            p2 = rand.Next(1, 6);
            Console.WriteLine("DICE ONE GIVES :-  " + p1);
            Console.WriteLine("DICE TWO GIVES :-  " + p2);
            if (p1 == p2)
            {
                if (p1 == 1 && p2==1)
                {
                    val1 = 0;
                    Console.WriteLine("----------------------------------------------------------------------------- \n  THE BOTH DICE GIVES 1! THEN "+player1+" LOSE YOUR MARKS!!!!!!!!!!!! \n -----------------------------------------------------------------------\n ----------------------------------------------------------------------- "+player1+" MARKS IS " +val1 +"-----------------------------------------------------------------------\n");
                    play2();
                }
                else
                {
                    val1 = val1 + p1 + p2;
                    Console.WriteLine("----------------------------------------------------------------------------- \n  THE BOTH DICE GIVES SAME NUMBER! THEN YOU HAVE ANOTHER CHANCE TO PLAY!!!!!!!!!!!!! \n -----------------------------------------------------------------------");


                    Console.WriteLine("----------------------------------------------- \n " + "\t " + player1 + "    SCORE IS " + val1 + "\t" + "------------------------------------------------------------");
                    if (val1 < 100)
                    {
                        Console.WriteLine("...................................... IF YOU READY TO PLAY ENTER 'Y' .......................................");
                        logic1 = Console.ReadLine();
                        if (logic1 != "Y")
                        {
                            Console.WriteLine("...................................... IF YOU READY TO PLAY ENTER 'Y' .......................................\n-----------  IF YOU DO NOT ENTER 'Y' -----------\n ----------- YOU ARE GOING TO EXIT THE GAME.....................................");
                            logic1 = Console.ReadLine();
                            if (logic1 != "Y")
                            {
                                Console.WriteLine("-----------------------------------------------------------------------\n           SORRY GAME IS OVER BECAUSE OG NOT FOLLOWING THE INSTRUCTION!!!!!!!!!!!!!!!!!!!!!!!!!!!!!       \n  ----------------------------------------------------------------------------------");
                            }
                            else
                            {
                                play1();
                            }
                        }
                        else
                        {
                            play1();
                        }
                        // play1();
                    }
                    else
                    {
                        Console.WriteLine("----------------------------------------------------------\n \t " + player1 + "\t IS THE WINNER \t \n--------------------------------------------------------");
                    }
                }
            }
            else
            {
                val1 = val1 + p1 + p2;

                Console.WriteLine("----------------------------------------------- \n " + "\t " + player1 + "    SCORE IS " + val1 + "\t" + "------------------------------------------------------------");
                if (val1 < 100)
                {
                    Console.WriteLine("...................................... IF YOU READY TO PLAY ENTER 'Y' .......................................");
                    logic1 = Console.ReadLine();
                    if (logic1 != "Y")
                    {
                        Console.WriteLine("...................................... IF YOU READY TO PLAY ENTER 'Y' .......................................\n-----------  IF YOU DO NOT ENTER 'Y' -----------\n ----------- YOU ARE GOING TO EXIT THE GAME.....................................");
                        logic1 = Console.ReadLine();
                        if (logic1 != "Y")
                        {
                            Console.WriteLine("-----------------------------------------------------------------------\n           SORRY GAME IS OVER BECAUSE OG NOT FOLLOWING THE INSTRUCTION!!!!!!!!!!!!!!!!!!!!!!!!!!!!!       \n  ----------------------------------------------------------------------------------");
                        }
                        else
                        {
                            play2();
                        }
                    }
                    else
                    {
                        play2();
                    }
                    //play2();
                }
                else
                {
                    Console.WriteLine("----------------------------------------------------------\n \t " + player1 + "\t IS THE WINNER \t \n--------------------------------------------------------");
                }
            }
        }
        static void play2()
        {
            Random randq = new Random(); p1 = randq.Next(1, 7);
            //Random wanfw = new Random(); 
            p2 = randq.Next(1, 6);
            Console.WriteLine("DICE ONE GIVES :-  " + p1);
            Console.WriteLine("DICE TWO GIVES :-  " + p2);
            if (p1 == p2)
            {
                if (p1 == 1 && p2 == 1)
                {
                    val2 = 0;
                    Console.WriteLine("----------------------------------------------------------------------------- \n  THE BOTH DICE GIVES 1! THEN "+player2+" YOU LOSE YOUR MARKS!!!!!!!!!!!! \n -----------------------------------------------------------------------\n ----------------------------------------------------------------------- "+player2+"  MARKS IS " + val2 + "-----------------------------------------------------------------------\n");
                    play1();

                }
                else
                {
                    val2 = val2 + p1 + p2;
                    Console.WriteLine("----------------------------------------------------------------------------- \n  THE BOTH DICE GIVES SAME NUMBER! THEN YOU HAVE ANOTHER CHANCE TO PLAY!!!!!!!!!!!!! \n -----------------------------------------------------------------------");

                    Console.WriteLine("----------------------------------------------- \n " + "\t " + player2 + "   SCORE IS " + val2 + "\t" + "------------------------------------------------------------");
                    if (val2 < 100)
                    {
                        Console.WriteLine("...................................... IF YOU READY TO PLAY ENTER 'Y' .......................................");
                        logic1 = Console.ReadLine();
                        if (logic1 != "Y")
                        {
                            Console.WriteLine("...................................... IF YOU READY TO PLAY ENTER 'Y' .......................................\n-----------  IF YOU DO NOT ENTER 'Y' -----------\n ----------- YOU ARE GOING TO EXIT THE GAME.....................................");
                            logic1 = Console.ReadLine();
                            if (logic1 != "Y")
                            {
                                Console.WriteLine("-----------------------------------------------------------------------\n           SORRY GAME IS OVER BECAUSE OG NOT FOLLOWING THE INSTRUCTION!!!!!!!!!!!!!!!!!!!!!!!!!!!!!       \n  ----------------------------------------------------------------------------------");
                            }
                            else
                            {
                                play2();
                            }
                        }
                        else
                        {
                            play2();
                        }
                        //play2();
                    }
                    else
                    {
                        Console.WriteLine("----------------------------------------------------------\n \t " + player2 + "\t IS THE WINNER \t \n--------------------------------------------------------");
                    }

                }
            }
            else
            {
                val2 = val2 + p1 + p2;

                Console.WriteLine("----------------------------------------------- \n " + "\t " + player2 + "    SCORE IS " + val2 + "\t" + "------------------------------------------------------------");
                if (val2 < 100)
                {
                    Console.WriteLine("...................................... IF YOU READY TO PLAY ENTER 'Y' .......................................");
                    logic1 = Console.ReadLine();
                    if (logic1 != "Y")
                    {
                        Console.WriteLine("...................................... IF YOU READY TO PLAY ENTER 'Y'  .......................................\n     ...............................................\n-----------  IF YOU DO NOT ENTER 'Y' -----------\n ----------- YOU ARE GOING TO EXIT THE GAME.....................................");
                        logic1 = Console.ReadLine();
                        if (logic1 != "Y")
                        {
                            Console.WriteLine("-----------------------------------------------------------------------\n           SORRY GAME IS OVER BECAUSE OG NOT FOLLOWING THE INSTRUCTION!!!!!!!!!!!!!!!!!!!!!!!!!!!!!       \n  ----------------------------------------------------------------------------------");
                        }
                        else
                        {
                            play1();
                        }
                    }
                    else
                    {
                        play1();
                    }   
                }
                else
                {
                    Console.WriteLine("----------------------------------------------------------\n \t " + player2 + "\t IS THE WINNER \t \n--------------------------------------------------------");
                }
            }
        }
    }
}
