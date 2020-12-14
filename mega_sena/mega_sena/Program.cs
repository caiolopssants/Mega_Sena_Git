using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mega_sena
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DateTime date = DateTime.Now;            
            double days = 0;

            int daysToNextRaffle = 3;
            double pricePerTicket = 4.5;
            int ticketsPurchased = 6;
            int quantityNumbersToChoice = 6;
            
            double capital = 23000;
            double salary = 985;

            double spendedMoney = 0;

            double sixPointWin = 0;
            double sixPointPrize = 11323343.69;

            double fivePointWin = 0;
            double fivePointPrize = 15996.75;

            double fourPointWin = 0;
            double fourPointPrize = 458.94;

            double didntWinCount = 0;
            
            double rafflesCount = 0;

            int minValue = 1;
            int maxValue = 60;

            bool useSameSequence = false;
            List<List<int>> playerNumbers = new List<List<int>>();

            string playerNumbersText = string.Empty;

            bool? useDefaultValues = null;
            while(true)
            {
                try
                {
                    Console.WriteLine("Desejar usar o valor padrão do programa (s/n)");
                    switch (Console.ReadLine().ToLower())
                    {
                        case "s":
                            useDefaultValues = true;
                            break;
                        case "n":
                            useDefaultValues = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Valor inválido");
                            break;
                    }
                    if(useDefaultValues != null)
                    {
                        break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Valor inválido");
                }
            }

            if (!useDefaultValues.GetValueOrDefault())
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Quantos dias demoram entre um sorteio e outro? ");
                        daysToNextRaffle = Convert.ToInt16(Console.ReadLine());
                        if (daysToNextRaffle > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Valor inválido");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Quantos números você quer selecionar por ticket? ");
                        quantityNumbersToChoice = Convert.ToInt16(Console.ReadLine());
                        if (quantityNumbersToChoice > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Valor inválido");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Qual o preço por ticket de sorteio (R$): ");
                        pricePerTicket = Convert.ToDouble(Console.ReadLine());
                        if (pricePerTicket > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Valor inválido");
                    }
                }
                while (true)
                {
                    try
                    {                        
                        Console.WriteLine("Quantos tickets são comprados");
                        ticketsPurchased = Convert.ToInt16(Console.ReadLine());
                        if (ticketsPurchased > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Valor inválido");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Quantos reais você tem guardado?");
                        capital = Convert.ToDouble(Console.ReadLine());
                        if (capital > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Valor inválido");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Qual o valor da sua renda, para repor seu dinheiro guardado?");
                        salary = Convert.ToDouble(Console.ReadLine());
                        if (salary > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Valor inválido");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Qual o premio ao acertar 6 números? (R$)");
                        sixPointPrize = Convert.ToDouble(Console.ReadLine());
                        if (sixPointPrize > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Valor inválido");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Qual o premio ao acertar 5 números? (R$)");
                        fivePointPrize = Convert.ToDouble(Console.ReadLine());
                        if (fivePointPrize > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Valor inválido");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Qual o premio ao acertar 4 números? (R$)");
                        fourPointPrize = Convert.ToDouble(Console.ReadLine());
                        if (fourPointPrize > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Valor inválido");
                    }
                }
            }

            while (true)
            {
                #region gerando a sequência ganhadora
                string raffleNumbersText = string.Empty;
                List<int> raffleNumbers = new List<int>();
                for(int i=0; i<6;i++)
                {
                    while(true)
                    {
                        //int value = rnd.Next(minValue, maxValue);
                        int value = -1;
                        for (int j = 0; j < 100000; j++) { value = rnd.Next(minValue, maxValue); }                        
                        if (!raffleNumbers.Contains(value))
                        {
                            raffleNumbers.Add(value);
                            raffleNumbersText += $"   {value}";
                            break;
                        }
                    }
                }
                #endregion
                
                #region gerando a sequência do jogador
                if (!useSameSequence)
                {
                    playerNumbersText = string.Empty;
                    playerNumbers = new List<List<int>>();
                    List<int> sequence = new List<int>();
                    for (int i = 0; i < ticketsPurchased; i++)
                    {
                        playerNumbersText += $"\n";
                        for (int j = 0; j < quantityNumbersToChoice; j++)
                        {
                            while (true)
                            {
                                //int value = rnd.Next(minValue, maxValue);
                                int value = -1;
                                for (int k = 0; k < 100000; k++) { value = rnd.Next(minValue, maxValue); }
                                if (!sequence.Contains(value))
                                {
                                    sequence.Add(value);
                                    playerNumbersText += $"{value}      ";
                                    break;
                                }
                            }
                        }
                        playerNumbers.Add(sequence);
                        sequence = new List<int>();                        
                    }
                }
                #endregion

                #region descontando o valor do ticket
                capital -= (pricePerTicket * ticketsPurchased);
                spendedMoney += (pricePerTicket * ticketsPurchased);
                if(capital < 0)
                {
                    Console.WriteLine("Você ficou sem fundos para apostar.");
                    Console.ReadKey();
                    break;
                }
                #endregion
                                                
                #region verificando se foi vencendor no sorteio
                List<int> correctNumbers = new List<int>();                
                int count = 0;
                foreach (var x in playerNumbers)
                {                    
                    foreach (var y in x)
                    {                        
                        if (raffleNumbers.Contains(y))
                        {
                            count++;                            
                        }
                    }
                    correctNumbers.Add(count);
                    count = 0;
                }
                count = 0;                                                
                correctNumbers.ForEach(x => 
                {
                switch (x)
                {
                    case 6:
                        capital += sixPointPrize;
                        sixPointWin++;
                        rafflesCount++;
                        break;
                    case 5:
                        capital += fivePointPrize;
                        fivePointWin++;
                        rafflesCount++;
                        break;
                    case 4:
                        capital += fourPointPrize;
                        fourPointWin++;
                        rafflesCount++;
                        break;
                    default:
                        didntWinCount++;
                        rafflesCount++;
                        break;
                }
                });
                #endregion

                #region ajustando os dias
                int olderMonth = date.Month;
                int olderYear = date.Year;
                date = date.AddDays(daysToNextRaffle);
                days += daysToNextRaffle;
                if(date.Month>olderMonth || date.Month < olderMonth)
                {
                    capital += salary;
                }

                #endregion

                #region mostrando os dados
                double winRate = -1;
                double loseRate = -1;
                double sixWinRate = -1;
                double fiveWinRate = -1;
                double fourWinRate = -1;
                if(sixPointWin != 0)
                {
                    sixWinRate = (sixPointWin) / rafflesCount * 100;
                }
                else
                {
                    sixWinRate = 0;
                }
                if (fivePointWin != 0)
                {
                    fiveWinRate = (fivePointWin) / rafflesCount * 100;
                }
                else
                {
                    fiveWinRate = 0;
                }
                if (fourPointWin != 0)
                {
                    fourWinRate = (fourPointWin) / rafflesCount * 100;
                }
                else
                {
                    fourWinRate = 0;
                }
                if (didntWinCount != 0)
                {
                    loseRate = (didntWinCount) / rafflesCount * 100;
                }
                else
                {
                    loseRate = 0;
                }
                if (sixPointWin != 0 || fivePointWin != 0 || fourPointWin != 0)
                {
                    winRate = (sixPointWin + fivePointWin + fourPointWin) / rafflesCount * 100;
                }
                else
                {
                    winRate = 0;
                }

                Console.WriteLine(
                    $"\nPeço do ticket: {pricePerTicket}" +
                    $"\nTicket's comprados: {ticketsPurchased}" +
                    $"\nRenda: {salary}" +
                    $"\nPeço do ticket: {pricePerTicket}" +                    

                    $"\n\nDia: {date}" +
                    $"\nDias que se passaram: {days}" +
                    $"\nCapital: R$ {capital}" +
                    $"\nSequência vencedora: {raffleNumbersText}" +
                    $"\n\nSequência apostador: {playerNumbersText}" +
                    $"\nAcertou 6 pontos: {sixPointWin}" +
                    $"\nAcertou 5 pontos: {fivePointWin}" +
                    $"\nAcertou 4 pontos: {fourPointWin}" +
                    $"\nNão ganhou: {didntWinCount}" +
                    $"\nSorteios realizados: {rafflesCount}" +
                    $"\nValor gasto até o momento: R$ {spendedMoney}" +
                    $"\n\nPORCENTAGENS DE GANHOS E PERDAS" +
                    $"\n6 pontos: {sixWinRate} %" +
                    $"\n5 pontos: {fiveWinRate} %" +
                    $"\n4 pontos: {fourWinRate} %" +
                    $"\nVitórias: {winRate} %" +
                    $"\nDerrotas: {loseRate} %");
                #endregion                
            }
        }
    }
}
