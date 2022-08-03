﻿using Capoia.Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capoia.Core.Bus
{
    public interface IMediatrHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
    }
}
