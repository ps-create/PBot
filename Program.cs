using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PBot
{
    class Program
    {
        private DiscordSocketClient _client;
        private LoggingService _loggingService;
		public static void Main(string[] args)
			=> new Program().MainAsync().GetAwaiter().GetResult();

		public async Task MainAsync()
		{
            _client = new DiscordSocketClient();
			_loggingService = new LoggingService(_client);

			//  You can assign your bot token to a string, and pass that in to connect.
			//  This is, however, insecure, particularly if you plan to have your code hosted in a public repository.
			var token = "ODA4MzczODUwNzI2NzI3NzAw.YCFm0A.OG0QZhar0okN_If-ZKul_9BUSoI";

			// Some alternative options would be to keep your token in an Environment Variable or a standalone file.
			// var token = Environment.GetEnvironmentVariable("NameOfYourEnvironmentVariable");
			// var token = File.ReadAllText("token.txt");
			// var token = JsonConvert.DeserializeObject<AConfigurationClass>(File.ReadAllText("config.json")).Token;

			await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();
			// Block this task until the program is closed.
			await Task.Delay(-1);
        }

	}
}
