﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HBitcoin.Models;
using NBitcoin;

namespace HBitcoin.Helpers
{
    public static class ExtensionMethods
    {
		public static ChainedBlock GetBlock(this ConcurrentChain concurrentChain, Height height) => concurrentChain.GetBlock(height.Value);
    }
}
