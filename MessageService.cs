using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PBot
{
    class MessageService
    {
		public MessageService(DiscordSocketClient client) 
		{
			client.MessageReceived += MessageReceivedHandler;
			client.MessageReceived += MessageSentHandler;
		}
		private Task MessageReceivedHandler(SocketMessage msg)
		{
			var usermsg = msg as SocketUserMessage;
			Console.WriteLine($"[{msg.Author}] : `{msg.Content}`  ==> [{msg.Channel}]");
			return Task.CompletedTask;
		}

		private Task MessageSentHandler(SocketMessage msg)
		{
			var message = msg as SocketUserMessage;
			//variables
			string command = "!c";
			//filtering messages
			if (!message.Content.StartsWith('!')) // prefix
				return Task.CompletedTask;

			if (message.Author.IsBot) //ignores all commands from bots
				return Task.CompletedTask;

			if (message.Content.Contains(' '))
				 
			else
			
			//Commands
			return Task.CompletedTask;
		}
	}
}
