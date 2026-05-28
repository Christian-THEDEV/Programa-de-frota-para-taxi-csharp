using System.Collections;

namespace Programa_frota_de_taxi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de variáveis e vetor
            double[] carros = new double[20];
            char opc_user;
            int ncarro=0;
            double carroComMenorValor;

            double total = 0;
            double valorcorrida=0;
            double valormaiormenor;

            //opções para o usuário
            do
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(" Sistema de controle de frota NewTaxi® ");
                Console.WriteLine("---------------------------------------\n");
                Console.WriteLine("Selecione a opção desejada\n");
                Console.WriteLine("|1 - Lançar Corrida                      |");
                Console.WriteLine("|2 - Mostrar Faturamento                 |");
                Console.WriteLine("|3 - Informar carro com menor faturamento|");
                Console.WriteLine("|4 - Informar carro com maior faturamento|");
                Console.WriteLine("|5 - Zerar o faturamento                 |");
                Console.WriteLine("|0 - Finalizar                           |\n");
                Console.Write("Sua opção: ");
                opc_user = Console.ReadKey().KeyChar;
            

            //switchcase com as opçoes do usuário
            switch (opc_user)
            {
                //opção de lançamento de corrida
                case '1':
                    Console.Clear();
                    Console.WriteLine("==========================");
                    Console.WriteLine($" {"TAXI",-5} | {"R$",10} ");

                //menu com os taxis e seus respectivos valores.
                    
                    for (int i = 0; i < 20; i++)
                    { 
                        Console.WriteLine($" {i+1,-5} | {carros[i].ToString("C"),10} ");
                    }
                    for(int i=0;i<20;i++)
                        {
                            total+=carros[i];
                        }
                    Console.WriteLine($" {"Total",-5} | {"{0}",10} ",total.ToString("C"));
                //informar o N° do carro e se o usuário colocar um negativo ou 0, deverá por o valor novamente.

                    do{
                    Console.Write("informe o n° do carro: ");
                    ncarro = int.Parse(Console.ReadLine());
                    if((ncarro<1) || (ncarro>20))
                            {
                                Console.WriteLine("Opção Incorreta! Tente Novamente");
                            }
                    }while(ncarro<=0 || ncarro >20);

                //diminuir -1 para evitar erro
                    ncarro = ncarro - 1;

                //Informar o valor da corrida e , se der menor ou igual a 0, devera por o valor novamente    
                    do{
                    Console.Write("Informe o valor da corrida: ");
                    valorcorrida = int.Parse(Console.ReadLine());
                    }while(valorcorrida<0);

                    //armazenar e somarvalor da corrida
                    carros[ncarro] += valorcorrida;

                    //Retorna ao usuário que o valor foi informado e pedir para clicar em qualquer tecla para voltar
                    Console.Write("Valor de {0} informado com sucesso, clique em qualquer tecla para voltar ao menu inicial!",valorcorrida.ToString("C"));
                    Console.ReadKey();

                    break;

                    case '2':
                    Console.Clear();
                    Console.WriteLine("==========================");
                    Console.WriteLine($" {"TAXI",-5} | {"R$",10} ");

                    //menu com os taxis e seus respectivos valores.
                    for (int i = 0; i < 20; i++)
                    {
                    Console.WriteLine($" {i+1,-5} | {carros[i].ToString("C"),10} ");
                    }

                    for(int i=0;i<20;i++)
                        {
                            total+=carros[i];
                        }
                    Console.WriteLine($" {"Total",-5} | {"{0}",10} ",total.ToString("C"));
                    Console.WriteLine("Pressione qualquer tecla para voltar!");
                    Console.ReadKey();
                    
                    break;


                    case '3':
                    valormaiormenor = 999999.00; 
                    carroComMenorValor = 0;
                    //ver o carro com o menor faturamento
                    for(int i=0;i<carros.Length;i++)
                        {
                      if (carros[i] < valormaiormenor && carros[i] > 0)
                            {
                            valormaiormenor = carros[i]; 
                            carroComMenorValor = i + 1;
                            }
                        }
                    if (carroComMenorValor == 0)
                        {
                        Console.WriteLine("Nenhum carro teve faturamento registrado ainda.");
                        }

                    else
                        {
                        Console.WriteLine("O carro com menor valor é o {0}, com o faturamento de {1:C}", carroComMenorValor, valormaiormenor);
                        }

                    Console.Write("Clique em qualquer tecla para voltar!");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                    

                    case '4':
                        {
                    valormaiormenor = 0; 
                    carroComMenorValor = 0;
                    //ver o carro com o maior faturamento
                    for(int i=0;i<carros.Length;i++)
                        {
                      if (carros[i] > valormaiormenor)
                            {
                            valormaiormenor = carros[i]; 
                            carroComMenorValor = i + 1;
                            }
                        }
                    if (carroComMenorValor == 0)
                        {
                        Console.WriteLine("Nenhum carro teve faturamento registrado ainda.");
                        }

                    else
                        {
                        Console.WriteLine("O carro com maior valor é o {0}, com o faturamento de {1:C}", carroComMenorValor, valormaiormenor);
                        }

                    Console.Write("Clique em qualquer tecla para voltar!");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                    }


                    case '5':
                        {
                            // zerar o valor dos carros
                            for(int i=0;i<20;i++)
                            {
                                carros[i]=0;
                                total=0;
                                ncarro=0;
                            }
                            Console.Write("Valores zerados com sucesso!, clique em qualquer tecla para voltar ao menu");
                            Console.ReadKey();
                            break;
                        }
                        case '0':
                        {
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("Encerrando... Tenha um bom dia!");
                            break;
                        }
                    default:
                        {
                        Console.Clear();
                        Console.WriteLine("Opção Invalida!");
                        Console.WriteLine("Pressione qualquer tecla para tentar novamente!");
                        Console.ReadLine();
                        break;
                        }  
            }  
            } while (opc_user != '0');
        }
    }
}
