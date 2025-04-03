using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgra2
{
    class TicTac
    {
        private string[] fila1 = { "*", "*", "*" };
        private string[] fila2 = { "*", "*", "*" };
        private string[] fila3 = { "*", "*", "*" };
        private List<int> entradaUsuario = new List<int>();

        public int adversario()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(0, 9);
            return numeroAleatorio;

        }

        public void jugar()
        {
            
            bool jugando = true;

            while (jugando)
            {
                int turnos = 9;
                mostrarCeldas();
                
                bool verficador = verificarCeldasCompletas();
                if(verficador == true)
                {
                    jugando = false;
                    Console.WriteLine("Felicidades Ganaste");
                    break;
                    
                    
                } 
                if(turnos == 0)
                {
                    jugando = false;
                    Console.WriteLine("\n\t Empate");
                    break;
                    
                }
                int posicion = Jugador.incluirElemento();
                entradaUsuario.Add(posicion);

                if (posicion <= 3)
                {
                    posicion--;
                    for (int i = 0; i < fila1.Length; i++)
                    {
                        
                        if(i == posicion)
                        {
                            fila1[i] = "X";
                        }
                        

                    }
                }
                else if(posicion >= 3 && posicion <= 6)
                {
                    posicion = posicion-4;
                    for (int i = 0; i < fila2.Length; i++)
                    {

                        if (i == posicion)
                        {
                            fila2[i] = "X";
                        }
                        

                    }
                }
                else if(posicion >= 6 && posicion <= 9)
                   
                {
                    posicion = posicion - 7 ;
                    for (int i = 0; i < fila3.Length; i++)
                    {

                        if (i == posicion )
                        {
                            fila3[i] = "X";
                        }
                        

                    }
                }
                else
                {
                    Console.Write("Numero Invalido, perdiste tu oportunidad: ");
                }
                mostrarCeldas();

                if (verficador == true)
                {
                    jugando = false;
                    Console.WriteLine("Felicidades Ganaste");
                    break;


                }
                if (turnos == 0)
                {
                    jugando = false;
                    Console.WriteLine("\n\t Empate");
                    break;


                }
                Console.WriteLine("Espera tu turno\n");
                Console.ReadKey();

                int enemigo = adversario();
                for (int i = 0; i < entradaUsuario.Count; i++)
                {

                    while (enemigo == entradaUsuario[i])
                    {
                        enemigo = adversario();
                    }

                }
                

                
                    if (enemigo <= 3)
                    {
                        enemigo--;
                        for (int i = 0; i < fila1.Length; i++)
                        {

                            if (i == enemigo)
                            {
                                
                                
                                fila1[i] = "0";
                                    
                                
                            }

                        }
                    }
                    else if (enemigo >= 3 && enemigo <= 6)
                    {
                        enemigo = enemigo - 4;
                        for (int i = 0; i < fila2.Length; i++)
                        {

                            if (i == enemigo)
                            {
                                
                                
                                fila2[i] = "0";
                                   
                                
                            }

                        }
                    }
                    else if (enemigo >= 6 && enemigo <= 9)

                    {
                        enemigo = enemigo - 7;
                        for (int i = 0; i < fila3.Length; i++)
                        {


                            if (i == enemigo)
                            {


                                fila3[i] = "0";


                            }



                    }
                    }

                
                turnos--;






            }
            return;

            
        }

        public void mostrarCeldas()
        {
            mostrar1();
            mostrar2();
            mostrar3();
        }
        public void mostrar1()
        {
            for (int i = 0; i < fila1.Length; i++)
            {
                Console.Write("\t" + fila1[i]);
                
            }
            Console.WriteLine("\n");
        }
        public void mostrar2()
        {
            for (int i = 0; i < fila1.Length; i++)
            {
                Console.Write("\t" + fila2[i]);
                
            }
            Console.WriteLine("\n");
        }
        public void mostrar3()
        {
            for (int i = 0; i < fila1.Length; i++)
            {
                Console.Write("\t" + fila3[i]);
                
            }
            Console.WriteLine("\n");
        }

        public bool verificarCeldasCompletas()
        {
            string primerElemento = "X";
            string primerElemento2 = "O";

            if (fila1[0] == primerElemento && fila1[1] == primerElemento && fila1[2] == primerElemento || fila1[0] == primerElemento2 && fila1[1] == primerElemento2 && fila1[2] == primerElemento2)
            {
                return true;
            }
            if (fila2[0] == primerElemento && fila2[1] == primerElemento && fila2[2] == primerElemento || fila2[0] == primerElemento2 && fila2[1] == primerElemento2 && fila2[2] == primerElemento2)
            {
                return true;
            }
            if (fila3[0] == primerElemento && fila3[1] == primerElemento && fila3[2] == primerElemento || fila3[0] == primerElemento2 && fila3[1] == primerElemento2 && fila3[2] == primerElemento2)
            {
                return true;
            }
            
           
            if (fila1[0]==primerElemento && fila2[0]==primerElemento && fila3[0] == primerElemento)
            {
                return true;
            }
            if (fila1[1]==primerElemento && fila2[1]==primerElemento && fila3[1] == primerElemento)
            {
                return true;
            } 
            if (fila1[2]==primerElemento && fila2[2]==primerElemento && fila3[2] == primerElemento)
            {
                return true;
            }
            if (fila1[0]==primerElemento && fila2[1]==primerElemento && fila3[2] == primerElemento)
            {
                return true;
            }
            if (fila1[2]==primerElemento && fila2[1]==primerElemento && fila3[0] == primerElemento)
            {
                return true;
            }





            return false;
        }



    }
}
