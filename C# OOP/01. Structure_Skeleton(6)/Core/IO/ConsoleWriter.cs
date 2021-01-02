using System;
using System.IO;
using WarCroft.Core.IO.Contracts;

namespace WarCroft.Core.IO
{
	public class ConsoleWriter : IWriter
	{
		public void WriteLine(string message)
		{
			File.AppendAllText("../../../output.txt", message + Environment.NewLine);
		}
	}
}