﻿using NBitcoin;
using NBXplorer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NBXplorer.DerivationStrategy;
using System.Threading.Tasks;

namespace NBXplorer.Tests
{
	public static class Extensions
	{
		public static async Task<KeyPathInformation> GetKeyInformation(this Repository repo, Script script)
		{
			return (await repo.GetKeyInformations(new Script[] { script }))[script].SingleOrDefault();
		}
	}
}
