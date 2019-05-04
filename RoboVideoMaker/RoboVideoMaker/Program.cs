using System;

namespace RoboVideoMaker
{
  class Program
  {
    static string AskAndReturnSearchTerm()
    {
      /*Console.WriteLine("Informe o termo a ser buscado na wikipedia para geração do vídeo: ");
      return Console.ReadLine();*/
      return "Atlético Mineiro";
    }

    static string AskAndReturnPrefix()
    {
      /*do
      {
        Console.WriteLine($"Informe o prefixo:{Environment.NewLine}[1]: Who is{Environment.NewLine}[2]: What is{Environment.NewLine}[3]: The history of{Environment.NewLine}[4]: Cancelar");
        int option;
        if ((!int.TryParse(Console.ReadLine(), out option)) || (option <= 0) || (option > 4))
          Console.WriteLine("Opção inválida!");
        else
        {
          switch (option)
          {
            case 1: return "Who is";
            case 2: return "What is";
            case 3: return "The history of";
            case 4: Environment.Exit(0); break;
            default: Console.WriteLine("Opção inválida!"); break;
          }
        }
      } while(true);*/
      return "This history of";
    }

    static void Main(string[] args)
    {
      new VideoMakerRobot(new Content { SearchTerm = AskAndReturnSearchTerm(), Prefix = AskAndReturnPrefix() }).Start();
    }
  }

}
