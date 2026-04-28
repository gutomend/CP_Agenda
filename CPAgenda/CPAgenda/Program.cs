using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static List<string> descricoes = new List<string>();
    static List<DateTimeOffset> datas = new List<DateTimeOffset>();

    static void Main()
    {
        int opcao = -1;

        while (opcao != 0)
        {
            Console.WriteLine("\n1 - Adicionar compromisso");
            Console.WriteLine("2 - Ver compromissos de hoje");
            Console.WriteLine("3 - Ver compromissos por data");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
                Adicionar();

            else if (opcao == 2)
                VerHoje();

            else if (opcao == 3)
                VerPorData();
        }
    }

    static void Adicionar()
    {
        Console.Write("Descrição: ");
        string desc = Console.ReadLine();

        Console.Write("Data e hora (yyyy-MM-dd HH:mm): ");
        string entrada = Console.ReadLine();

        Console.Write("Timezone (ex: E. South America Standard Time): ");
        string tzId = Console.ReadLine();

        try
        {
            DateTime data = DateTime.ParseExact(entrada, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById(tzId);

            DateTimeOffset dataOffset = new DateTimeOffset(data, tz.GetUtcOffset(data));

            descricoes.Add(desc);
            datas.Add(dataOffset);

            Console.WriteLine("Adicionado!");
        }
        catch
        {
            Console.WriteLine("Erro ao cadastrar!");
        }
    }

    static void VerHoje()
    {
        Console.Write("Timezone (ENTER = padrão): ");
        string tzId = Console.ReadLine();

        TimeZoneInfo tz;

        if (tzId == "")
            tz = TimeZoneInfo.Local;
        else
            tz = TimeZoneInfo.FindSystemTimeZoneById(tzId);

        DateTime hoje = TimeZoneInfo.ConvertTime(DateTimeOffset.Now, tz).Date;

        Console.WriteLine("\nCompromissos de hoje:\n");

        for (int i = 0; i < datas.Count; i++)
        {
            DateTimeOffset convertido = TimeZoneInfo.ConvertTime(datas[i], tz);

            if (convertido.Date == hoje)
            {
                Console.WriteLine(convertido.ToString("HH:mm") + " - " + descricoes[i]);
            }
        }
    }

    static void VerPorData()
    {
        Console.Write("Data (yyyy-MM-dd): ");
        string dataInput = Console.ReadLine();

        Console.Write("Timezone: ");
        string tzId = Console.ReadLine();

        try
        {
            DateTime data = DateTime.ParseExact(dataInput, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById(tzId);

            Console.WriteLine("\nCompromissos:\n");

            for (int i = 0; i < datas.Count; i++)
            {
                DateTimeOffset convertido = TimeZoneInfo.ConvertTime(datas[i], tz);

                if (convertido.Date == data)
                {
                    Console.WriteLine(convertido.ToString("HH:mm") + " - " + descricoes[i]);
                }
            }
        }
        catch
        {
            Console.WriteLine("Erro!");
        }
    }
}