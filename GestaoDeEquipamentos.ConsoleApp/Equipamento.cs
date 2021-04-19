using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEquipamentos.ConsoleApp
{
    public class Equipamento
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string  fabricante { get; set; }
        public string numero { get; set; }
        public double valor { get; set; }
        public DateTime dataFabricacao { get; set; }

        public Equipamento registrar()
        {
            Equipamento equipamento = new Equipamento();
            bool NomeInvalido = false;
            do
            {
                Console.WriteLine("Digite o nome do equipamento");

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("No mínimo 6 digitos");

                Console.ResetColor();

                equipamento.nome = Console.ReadLine();
                if (equipamento.nome.Length <= 6)
                {
                    NomeInvalido = true;
                    Console.WriteLine("Quantidade de caracteres inválidas");
                }

                continue;

            } while (NomeInvalido);

            Console.WriteLine("Digite o preço do equipamento");

            equipamento.valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o Número de série");

            equipamento.numero = Console.ReadLine();

            Console.WriteLine("Digite a data de fabricação");

            equipamento.dataFabricacao = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Digite o nome da fabricante");

            equipamento.fabricante = Console.ReadLine();
            
            Random rnd = new Random();
            equipamento.id = rnd.Next();
            
            return equipamento;
        }

        public void mostrar(List<Equipamento> equipamentos)
        {
            Console.WriteLine("----- Lista de equipamentos -----");
            foreach (var item in equipamentos)
            {
                Console.WriteLine($"ID: {item.id}");
                Console.WriteLine($"Fabricante: {item.fabricante}");
                Console.WriteLine($"Nome: {item.nome}");
                Console.WriteLine($"Numero série: {item.numero}");
                Console.WriteLine($"Valor: {item.valor}");
                Console.WriteLine($"Data Fabricação: {item.dataFabricacao}");
            }
            Console.WriteLine("---------------------------------");
        }

        public void editar(Equipamento equipamento)
        {
            bool sair = true;
            do
            {
                Console.WriteLine($"1 - Fabricante: {equipamento.fabricante}");
                Console.WriteLine($"2 - Nome: {equipamento.nome}");
                Console.WriteLine($"3 - Numero série: {equipamento.numero}");
                Console.WriteLine($"4 - Valor: {equipamento.valor}");
                Console.WriteLine($"5 - Data Fabricação: {equipamento.dataFabricacao}");
                Console.WriteLine($"Digite o valor correspondente a propriedade que deseja editar ou 6 para sair:");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o novo fabricante: ");
                        equipamento.fabricante = Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("Digite o novo nome: ");
                        equipamento.nome = Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine("Digite o novo número de série: ");
                        equipamento.numero = Console.ReadLine();
                        break;

                    
                        

                    default:
                        sair = false;
                        break;
                }

            } while (sair);
        }
    }


}
