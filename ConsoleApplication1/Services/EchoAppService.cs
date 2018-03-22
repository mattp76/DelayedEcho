﻿using ConsoleApplication1.Helpers;
using ConsoleApplication1.Interfaces;
using DelayedEcho;
using DelayedEcho.Interfaces;
using System;
using System.Threading;

namespace ConsoleApplication1.Services
{
    public class EchoAppService : IEchoAppService
    {

        protected readonly IConcreteClass _concreteClass;

        public EchoAppService(IConcreteClass concreteClass)
        {
            this._concreteClass = concreteClass;
        }

        public void WriteToTheApp()
        {
            _concreteClass.EchoEvent += EchoEventHandler;

            while (true)
            {
                string valueStr = Console.ReadLine();

                if (!string.IsNullOrEmpty(valueStr))
                {
                    var strArr = valueStr.Split(':');

                    if (strArr.Length == 2)
                    {
                        var message = valueStr.Split(':')[0];
                        var secondsStr = valueStr.Split(':')[1];

                        int seconds;
                        bool res = int.TryParse(secondsStr, out seconds);
                        if (res)
                        {
                            _concreteClass.EchoDelayed(message, seconds);
                            Console.WriteLine(StringHelper.GetMessage(DateTime.Now, "Queued."));
                        }
                    }
                }

                Thread.Sleep(500);
            }
        }

        static void EchoEventHandler(object sender, EchoEventArgs e)
        {
            Console.WriteLine(StringHelper.GetMessage(e.DateTime, e.Message));
        }
    }
}