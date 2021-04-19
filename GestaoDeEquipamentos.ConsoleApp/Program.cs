using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEquipamentos.ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Equipamento> equipamentos = new List<Equipamento>();
            List<Chamado> chamados = new List<Chamado>();
            Chamado chamado = new Chamado();
                
            Equipamento equipamento = new Equipamento();
            string menu;

            bool sair = true;
            do
            {
                menu = OpcaoMenu();

                if (menu == "1")
                {
                    var equipTemp = equipamento.registrar();
                    equipamentos.Add(equipTemp);
                    continue;
                }
                if (menu == "2")
                {
                    equipamento.mostrar(equipamentos);
                    continue;
                }
                if (menu == "3")
                {
                    Console.WriteLine("Excluindo equipamentos....\n");

                    equipamento.mostrar(equipamentos);

                    Console.WriteLine("Digite o número do equipamento que deseja excluir");

                    int numeroSelecionado = Convert.ToInt32(Console.ReadLine());

                    var equipamentoTemp = equipamentos;

                    for (int i = 0; i < equipamentos.Count; i++)
                    {
                        if (equipamentos[i].id == numeroSelecionado)
                        {
                            equipamentos.RemoveRange(i, 1);
                        }
                    }

                    Console.WriteLine("Equipamento excluído com sucesso! \n");
                    continue;
                }
                if (menu == "4")
                {
                    if (equipamentos.Count == 0)
                    {
                        Console.WriteLine("Nenhum equipamento cadastrado....\n");
                    }
                    else
                    {
                        Console.WriteLine("Editando equipamentos....\n");

                        equipamento.mostrar(equipamentos);

                        Console.WriteLine("Digite o número do equipamento que deseja editar");

                        int numeroSelecionado = Convert.ToInt32(Console.ReadLine());

                        foreach (var item in equipamentos)
                        {
                            if (item.id == numeroSelecionado)
                            {
                                equipamento.editar(item);
                            }
                        }
                    }

                    continue;
                }
                if (menu == "5")
                {
                    chamados.Add( chamado.registrar());
                    continue;
                }
                if (menu == "6")
                {
                    chamado.mostrar(chamados);
                    continue;
                }

                if (menu == "7")
                {
                    ExcluirChamados(chamados, chamado);
                }

                if (menu =="8")
                {
                    if (chamados.Count == 0)
                    {
                        Console.WriteLine("Nenhuma Chamada cadastrada....\n");
                    }
                    else
                    {
                        Console.WriteLine("Editando Chamada....\n");

                        chamado.mostrar(chamados);

                        Console.WriteLine("Digite o número da Chamada que deseja editar");

                        int numeroSelecionado = Convert.ToInt32(Console.ReadLine());

                        foreach (var item in chamados)
                        {
                            if (item.id == numeroSelecionado)
                            {
                                chamado.Editar(item);
                            }
                        }
                    }
                }


                if (menu.Equals("0"))
                {
                    sair = false;
                }

            } while (sair);


            //equipamentos.Add(equipamento.registrar());

            //if (menu == "1")
            //{
            //    Console.WriteLine("Digite o número do equipamento:");
            //    int numeroEquipamento = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Digite o título do chamado:");
            //    string título = Console.ReadLine();

            //    Console.WriteLine("Digite a descrição do chamado:");
            //    string descricao = Console.ReadLine();

            //    DateTime dataAbertura = DateTime.Now;

            //    Console.WriteLine("Digite 1 para voltar ao menu ou 2 para adicionar mais uma chamada");

            //    Chamada = Console.ReadLine();

            //    if (Chamada == "1")
            //    {
            //        return;
            //    }

            //    if (Chamada == "2")
            //    {

            //    }


            //}

            //}
            //Console.WriteLine("Digite 1 para voltar ao menu ou 2 para adicionar mais uma chamada");

            //Chamada = Console.ReadLine();

            //if (Chamada == "1")
            //{
            //    return;
            //}

            //if (Chamada == "2")
            //{
            //    continue;
            //}

            //menu = Console.ReadLine();



        }

        private static void ExcluirChamados(List<Chamado> chamados, Chamado chamado)
        {
            Console.WriteLine("Excluindo Chamadas....\n");

            chamado.mostrar(chamados);

            Console.WriteLine("Digite o número da chamada que deseja excluir");

            int numeroSelecionado = Convert.ToInt32(Console.ReadLine());

            var chamadosTemp = chamado;

            for (int i = 0; i < chamados.Count; i++)
            {
                if (chamados[i].id == numeroSelecionado)
                {
                    chamados.RemoveRange(i, 1);
                }
            }
        }

        private static string OpcaoMenu()
        {
            //Menu Interativo

            string menu;

            Console.WriteLine("Registrar Equipamento = 1");
            Console.WriteLine("Vizualizar Equipamentos  = 2");
            Console.WriteLine("Excluir Equipamento = 3");
            Console.WriteLine("Editar Equipamento = 4");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Registrar Chamado= 5");
            Console.WriteLine("Vizualizar Chamado  = 6");
            Console.WriteLine("Excluir Chamado = 7");
            Console.WriteLine("Editar Chamado = 8");
            Console.WriteLine("Sair = 0");

            

            menu = Console.ReadLine();
            return menu;
        }
    }
}
