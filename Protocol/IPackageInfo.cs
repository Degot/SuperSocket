﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocket.Protocol
{
    public interface IPackageInfo
    {

    }

    public interface IPackageInfo<out TKey> : IPackageInfo
    {
        TKey Key { get; }
    }
}
