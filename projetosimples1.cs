using System;
class Program
{
    static void Main()
    {
        // Variáveis para acesso de dados
        string? readResult;
        string menuSelection = "";

        // flag
        bool sairDoPrograma = false;

        do
        {
            // Opções do display
            Console.Clear();
            Console.WriteLine("\tCONVERSOR DE MEDIDAS");
            Console.WriteLine();
            Console.WriteLine("1. Converter temperatura °celsius em °Fahrenheit");
            Console.WriteLine("2. Converter Km em milha");
            Console.WriteLine("3. Converter Kg em Libras");
            Console.WriteLine("4. Converter Metros em Pés");
            Console.WriteLine("5. Sair");

            sairDoPrograma = false;

            readResult = Console.ReadLine();
            if (readResult != null)
            {
                menuSelection = readResult.ToLower();
            }

            switch (menuSelection)
            {
                case "1":
                    // Convertertendo graus celsius em fahrenheit
                    Console.Clear();
                    Console.WriteLine("Digite sua temperatura em °C (ex: 25°C)");
                    readResult = Console.ReadLine();

                    if (double.TryParse(readResult, out double tempEscolhida))
                    {
                        double resultadoTemp = (tempEscolhida * 1.8) + 32; // Fórmula
                        Console.WriteLine($"{resultadoTemp}°F");

                        Console.WriteLine("Pressione a tecla 'Enter' para sair.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($@"""{readResult}"" não é um resultado válido."); 
                    }
                    break;

                case "2":
                    // Convertendo Kms em Milhas
                    Console.Clear();
                    Console.WriteLine("Digite a kilometragem (ex: 10km)");
                    readResult = Console.ReadLine();

                    if (double.TryParse(readResult, out double kmMetragem))
                    {
                        double resultadoMilhas = kmMetragem * 0.621371; // Fórmula
                        Console.WriteLine($"{resultadoMilhas.ToString("F2")} Milhas");

                        Console.WriteLine("Pressione a tecla 'Enter' para sair.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($@"""{readResult}"" não é um resultado válido."); continue;
                    }
                    break;

                case "3":
                    // Converter kilos em libras
                    Console.Clear();
                    Console.WriteLine("Digite o valor em kg (ex: 100kg)");
                    readResult = Console.ReadLine();

                    if (double.TryParse(readResult, out double kgsEscolhido))
                    {
                        double resultadoLibras = kgsEscolhido * 2.20462; // Fórmula
                        Console.WriteLine($"{resultadoLibras.ToString("F2")}lb");

                        Console.WriteLine("Pressione a tecla 'Enter' para sair.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(@$"""{readResult}"" não é um resultado válido."); continue;
                    }
                    break;

                case "4":
                    // Coverter Metros em Pés(ft)
                    Console.Clear();
                    Console.WriteLine("Digite a altura deseja em metros (ex: 5m)");
                    readResult = Console.ReadLine();

                    if (double.TryParse(readResult, out double metrosPedidos))
                    {
                        double resultadoPés = metrosPedidos * 3.28084; // Fórmula
                        Console.WriteLine($"{resultadoPés.ToString("F1")}ft");

                        Console.WriteLine("Pressione a tecla 'Enter' para sair.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($@"""{readResult}"" não é um resultado válido."); continue;
                    }
                    break;

                case "5":
                    sairDoPrograma = true;
                    break;
            }

        } while (sairDoPrograma == false);
    }
}