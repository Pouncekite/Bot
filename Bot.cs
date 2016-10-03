using Discord;
using System.Linq;

namespace NSNBot
{
    class Bot
    {
        DiscordClient discord;
        public Bot()
        {
            discord = new DiscordClient();
            discord.MessageReceived += Discord_MessageReceived;
            
            discord.LoadCommands();

            //Connection event needs to be last
            discord.ExecuteAndWait(async () =>
            {
                await discord.Connect(Config.GetDiscordID(), TokenType.Bot);
            });
        }

        private void Discord_MessageReceived(object sender, MessageEventArgs e)
        {
            if (e.Message.Channel.ToString().Contains("@"))
            {
                Server NSNServer = discord.GetServer(Config.GetServerID());
                Channel responseChannel = NSNServer.FindChannels("feedback").FirstOrDefault();

                if (!e.Message.IsAuthor)
                {
                    responseChannel.SendMessage(e.Message.Text);
                }
            }
        }
    }
}
