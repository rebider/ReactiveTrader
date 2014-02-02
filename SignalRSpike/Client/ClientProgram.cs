﻿using System;
using Autofac;

namespace Client
{
    class ClientProgram
    {
        static void Main()
        {
            log4net.Config.XmlConfigurator.Configure();

            Start();

            Console.ReadKey();
        }

        private static async void Start()
        {
            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.Build();

            var sampleClient = container.Resolve<ISampleClient>();
            await sampleClient.Start();
        }
    }
}
