﻿using System;
namespace ElephantSwap
{
	class Elephant
	{
		public int EarSize;
		public string Name;
		public void WhoAmI()
		{
			Console.WriteLine("My name is " + Name);
			Console.WriteLine("My ears are " + EarSize + " inches tall.");
		}

		public void HearMessage(string message, Elephant whoSaidIt)
		{
			Console.WriteLine(Name + " heard a message");
			Console.WriteLine(whoSaidIt.Name + " said this " + message);
		}

		public void SpeakTo(Elephant whoTalkTo, string message)
		{
			whoTalkTo.HearMessage(message, this);
		}
	}
}

