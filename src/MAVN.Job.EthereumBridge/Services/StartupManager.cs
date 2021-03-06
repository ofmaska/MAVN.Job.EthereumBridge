﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Common;
using Lykke.Sdk;

namespace MAVN.Job.EthereumBridge.Services
{
    public class StartupManager : IStartupManager
    {
        private readonly IEnumerable<IStartStop> _startables;

        public StartupManager(IEnumerable<IStartStop> startables)
        {
            _startables = startables;
        }

        public Task StartAsync()
        {
            foreach (var startable in _startables)
            {
                startable.Start();
            }

            return Task.CompletedTask;
        }
    }
}
