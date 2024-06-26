﻿using System;
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
            const string ButtonConvertRublesToDollars = "1";
            const string ButtonConvertEuroToDollars = "2";
            const string ButtonConvertDollarsToRubles = "3";
            const string ButtonConvertEuroToRubles = "4";
            const string ButtonConvertDollarsToEuro = "5";
            const string ButtonConvertRublesToEuro = "6";
            const string ButtonCheckWallet = "7";
            const string ButtonHelpMenu = "8";
            const string ButtonEscape = "9";
            const string ButtonClear = "10";

            double clientDollars = 10000;
            double clientRubles = 10000;
            double clientEuro = 10000;

            double exchangeRateRublesToDollars = 89.6;
            double exchangeRateEuroToDollars = 0.93;
            double exchangeRateDollarsToRubles = 85.8;
            double exchangeRateEuroToRubles = 90.9;
            double exchangeRateDollarsToEuro = 1.06;
            double exchangeRateRublesToEuro = 95.6;

            uint maxValue = 4294967295;

            string lowMoney = "У вас не хватает валюты, чтобы купить заданное количество средств.";
            string convertQuestion = "Сколько вы хотите купить?\n" +
                $"Наш обменник поддерживает суммы до {maxValue}.";

            string helpMenu = $"Нажмите {ButtonConvertRublesToDollars}, чтобы конвертировать рубли в доллары.\n" +
                $"Нажмите {ButtonConvertEuroToDollars}, чтобы конвертировать евро в доллары.\n" +
                $"Нажмите {ButtonConvertDollarsToRubles}, чтобы конвертировать доллары в рубли.\n" +
                $"Нажмите {ButtonConvertEuroToRubles}, чтобы конвертировать евро в рубли.\n" +
                $"Нажмите {ButtonConvertDollarsToEuro}, чтобы конвертировать доллары в евро.\n" +
                $"Нажмите {ButtonConvertRublesToEuro}, чтобы конвертировать рубли в евро.\n" +
                $"Нажмите {ButtonCheckWallet}, чтобы проверить кошелёк.\n" +
                $"Нажмите {ButtonHelpMenu}, чтобы вызвать меню помощи.\n" +
                $"Нажмите {ButtonEscape}, чтобы выйти из программы.\n" +
                $"Нажмите {ButtonClear}, чтобы очистить консоль.";

            uint commandUserToConvert = 0;

            bool escapeProgramm = false;

            Console.WriteLine(helpMenu);

            while (escapeProgramm == false)
            {
                Console.WriteLine("Введите команду:");

                switch (Console.ReadLine())
                {
                    case ButtonConvertRublesToDollars:
                        Console.WriteLine(convertQuestion);
                        commandUserToConvert = Convert.ToUInt32(Console.ReadLine());

                        double convertRublesToDollars = commandUserToConvert * exchangeRateRublesToDollars;
                        double remainderRublesToDollars = clientRubles - convertRublesToDollars;

                        if (remainderRublesToDollars < 0)
                        {
                            Console.WriteLine(lowMoney);
                        }
                        else
                        {
                            clientRubles = remainderRublesToDollars;
                            clientDollars += commandUserToConvert;

                            Console.WriteLine($"Вы купили {commandUserToConvert} долларов.");
                        }

                        break;

                    case ButtonConvertEuroToDollars:
                        Console.WriteLine(convertQuestion);
                        commandUserToConvert = Convert.ToUInt32(Console.ReadLine());

                        double convertEuroToDollars = commandUserToConvert * exchangeRateEuroToDollars;
                        double remainderEuroToDollars = clientEuro - convertEuroToDollars;

                        if (remainderEuroToDollars < 0)
                        {
                            Console.WriteLine(lowMoney);
                        }
                        else
                        {
                            clientEuro = remainderEuroToDollars;
                            clientDollars += commandUserToConvert;
                        }

                        break;

                    case ButtonConvertDollarsToRubles:
                        Console.WriteLine(convertQuestion);
                        commandUserToConvert = Convert.ToUInt32(Console.ReadLine());

                        double convertDollarsToRubles = commandUserToConvert * exchangeRateDollarsToRubles;
                        double remainderDollarsToRubles = clientDollars - convertDollarsToRubles;

                        if (remainderDollarsToRubles < 0)
                        {
                            Console.WriteLine(lowMoney);
                        }
                        else
                        {
                            clientDollars = remainderDollarsToRubles;
                            clientRubles += commandUserToConvert;
                        }

                        break;

                    case ButtonConvertEuroToRubles:
                        Console.WriteLine(convertQuestion);
                        commandUserToConvert = Convert.ToUInt32(Console.ReadLine());

                        double convertEuroToRubles = commandUserToConvert * exchangeRateEuroToRubles;
                        double remainderEuroToRubles = clientEuro - convertEuroToRubles;

                        if (remainderEuroToRubles < 0)
                        {
                            Console.WriteLine(lowMoney);
                        }
                        else
                        {
                            clientEuro = remainderEuroToRubles;
                            clientRubles += commandUserToConvert;
                        }

                        break;

                    case ButtonConvertDollarsToEuro:
                        Console.WriteLine(convertQuestion);
                        commandUserToConvert = Convert.ToUInt32(Console.ReadLine());

                        double convertDollarsToEuro = commandUserToConvert * exchangeRateDollarsToEuro;
                        double remainderDollarsToEuro = clientDollars - convertDollarsToEuro;

                        if (remainderDollarsToEuro < 0)
                        {
                            Console.WriteLine(lowMoney);
                        }
                        else
                        {
                            clientDollars = remainderDollarsToEuro;
                            clientEuro += commandUserToConvert;
                        }

                        break;

                    case ButtonConvertRublesToEuro:
                        Console.WriteLine(convertQuestion);
                        commandUserToConvert = Convert.ToUInt32(Console.ReadLine());

                        double convertRublesToEuro = commandUserToConvert * exchangeRateRublesToEuro;
                        double remainderRublesToEuro = clientRubles - convertRublesToEuro;

                        if (remainderRublesToEuro < 0)
                        {
                            Console.WriteLine(lowMoney);
                        }
                        else
                        {
                            clientRubles = remainderRublesToEuro;
                            clientEuro += commandUserToConvert;
                        }

                        break;

                    case ButtonCheckWallet:
                        string checkWallet = $"На вашем балансе сейчас:\n" +
                            $"{clientDollars} - долларов.\n" +
                            $"{clientRubles} - рублей.\n" +
                            $"{clientEuro} - евро.";
                        Console.WriteLine(checkWallet);
                        break;

                    case ButtonHelpMenu:
                        Console.WriteLine(helpMenu);
                        break;

                    case ButtonClear:
                        Console.Clear();
                        break;

                    case ButtonEscape:
                        escapeProgramm = true;
                        break;
                }
            }

            Console.WriteLine("Вы вышли из конвертера валют. Спасибо, что выбрали именно наш сервис!");
        }
    }
}
