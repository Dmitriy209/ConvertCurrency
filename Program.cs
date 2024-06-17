using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertCurrency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint clientDollars = null;
            uint clientRubles = null;
            uint clientEuro = null;

            decimal exchangeRateRublesToDollars = 89.6m;
            decimal exchangeRateEuroToDollars = 0.93m;
            decimal exchangeRateDollarsToRubles = 85.8m;
            decimal exchangeRateEuroToRubles = 90.9m;
            decimal exchangeRateDollarsToEuro = 1.06m;
            decimal exchangeRateRublesToEuro = 95.6m;

            const string ButtonConvertRublesToDollars = "1";
            const string ButtonConvertEuroToDollars = "2";
            const string ButtonConvertDollarsToRubles = "3";
            const string ButtonConvertEuroToRubles = "4";
            const string ButtonConvertDollarsToEuro = "5";
            const string ButtonConvertRublesToEuro = "6";
            const string ButtonCheckWallet = "7";
            const string ButtonHelpMenu = "8";
            const string ButtonEscape = "9";

            string notEnoughMoney = "У вас не хватает валюты, чтобы купить заданное количество средств.";
            string questionToConvert = "Сколько вы хотите купить?";
            
            string CheckWallet = $"На вашем балансе сейчас:\n" +
                            $"{clientDollars} - долларов.\n" +
                            $"{clientRubles} - рублей.\n" +
                            $"{clientEuro} - евро.";
            
            string helpMenu = $"Нажмите {ButtonConvertRublesToDollars}, чтобы конвертировать рубли в доллары.\n" +
                $"Нажмите {ButtonConvertEuroToDollars}, чтобы конвертировать евро в доллары.\n" +
                $"Нажмите {ButtonConvertDollarsToRubles}, чтобы конвертировать доллары в рубли.\n" +
                $"Нажмите {ButtonConvertEuroToRubles}, чтобы конвертировать евро в рубли.\n" +
                $"Нажмите {ButtonConvertDollarsToEuro}, чтобы конвертировать доллары в евро.\n" +
                $"Нажмите {ButtonConvertRublesToEuro}, чтобы конвертировать рубли в евро.\n" +
                $"Нажмите {ButtonCheckWallet}, чтобы проверить кошелёк.\n" +
                $"Нажмите {ButtonHelpMenu}, чтобы вызвать меню помощи.\n" +
                $"Нажмите {ButtonEscape}, чтобы выйти из программы.";

            string commandUser = null;

            uint commandUserToConvert = null;

            decimal ConvertRublesToDollars = clientRubles - commandUserToConvert * exchangeRateRublesToDollars;
            decimal ConvertEuroToDollars = clientEuro - commandUserToConvert * exchangeRateEuroToDollars;
            decimal ConvertDollarsToRubles = clientDollars - commandUserToConvert * exchangeRateDollarsToRubles;
            decimal ConvertEuroToRubles = clientEuro - commandUserToConvert * exchangeRateEuroToRubles;
            decimal ConvertDollarsToEuro = clientDollars - commandUserToConvert * exchangeRateDollarsToEuro;
            decimal ConvertRublesToEuro = clientRubles - commandUserToConvert * exchangeRateRublesToEuro;

            Console.WriteLine(helpMenu);

            while (commandUser != ButtonEscape)
            {
                Console.WriteLine("Введите команду:");
                commandUser = Console.ReadLine();

                switch (commandUser)
                {
                    case ButtonConvertRublesToDollars:
                        Console.WriteLine(questionToConvert);
                        Convert.ToUInt64(Console.ReadLine());
                        if (ConvertRublesToDollars < 0)
                        {
                            Console.WriteLine(notEnoughMoney);
                        }   
                        
                        break;

                    case ButtonConvertEuroToDollars:
                        Console.WriteLine(questionToConvert);
                        ConvertEuroToDollars;
                        break;

                    case ButtonConvertDollarsToRubles:
                        Console.WriteLine(questionToConvert);
                        ConvertDollarsToRubles;
                        break;

                    case ButtonConvertEuroToRubles:
                        Console.WriteLine(questionToConvert);
                        ConvertEuroToRubles;
                        break;

                    case ButtonConvertDollarsToEuro:
                        Console.WriteLine(questionToConvert);
                        ConvertDollarsToEuro;
                        break;

                    case ButtonConvertRublesToEuro:
                        Console.WriteLine(questionToConvert);
                        ConvertRublesToEuro;
                        break;

                    case ButtonCheckWallet:
                        Console.WriteLine(CheckWallet);
                        break;

                    case ButtonHelpMenu:
                        Console.WriteLine(helpMenu);
                        break;
                }
            }

            Console.WriteLine("Вы вышли из конвертера валют. Спасибо, что выбрали именно наш сервис!");
        }
    }
}
