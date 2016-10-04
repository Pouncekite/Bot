using Discord;
using Discord.Commands;

using System;

namespace NSNBot
{
    public static class Commands
    {
        public static void LoadCommands(this DiscordClient d)
        {
            d.UsingCommands(x =>
            {
                x.PrefixChar = '!';
            });
            var comm = d.GetService<CommandService>();

            comm.CreateCommand("help")
                .Do(async (e) =>
                {
                    User personToHelp = e.Message.User;
                    await personToHelp.SendMessage("You can PM any feedback about *anything* to this bot, "
                        + "and it will be rebroadcast anonymously to the officers.\n"
                        +"**DISCORDS:**\n"
                        + "**!<class>** (full name e.g. !deathknight)\n"
                        + "**!tanks**,**!healers**, **!weakauras**, **!amr**\n"
                        + "**!logs**: Link to our raid logs\n"
                        + "**!armory <name> <opt:server>** for the relevant armory link. US-only right now. ex: !armory pouncekite sargeras\n"
                        + "**!source**: The source code for this bot");
                });

            comm.CreateCommand("jake")
                .Do(async (e) =>
                {
                   await e.Channel.SendFile(Config.GetServer() + "jake.png");
                });

            comm.CreateCommand("pedantry")
               .Do(async (e) =>
               {
                   await e.Channel.SendFile(Config.GetServer() + "pedantry.png");
               });

            comm.CreateCommand("armory")
                .Parameter("charName", ParameterType.Required)
                .Parameter("charServer", ParameterType.Optional)
                .Do(async (e) =>
                {
                    string charServer = (e.GetArg("charServer").Equals("")) ? "area-52" : e.GetArg("charServer");
                    await e.Channel.SendMessage("http://us.battle.net/wow/en/character/" + charServer + "/" + e.GetArg("charName") + "/advanced");
                });

            comm.CreateCommand("deathknight")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://discord.gg/0ez1cFfUH3ingV96");
                });

            comm.CreateCommand("demonhunter")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://discord.gg/zGGkNGC");
                });

            comm.CreateCommand("druid")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://discord.gg/0dWu0WkuetF87H9H");
                });

            comm.CreateCommand("hunter")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://discord.gg/yqer4BX");
                });

            comm.CreateCommand("mage")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://discord.gg/0gLMHikX2aZ23VdA");
                });

            comm.CreateCommand("monk")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://discord.gg/0dkfBMAxzTmggsPH");
                });

            comm.CreateCommand("paladin")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://discord.gg/0dvRDgpa5xZHFfnD");
                });

            comm.CreateCommand("priest")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://discord.gg/0f1Ta8lT8xXXEAIY");
                });

            comm.CreateCommand("rogue")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://discord.gg/0h08tydxoNhfDVZf");
                });

            comm.CreateCommand("shaman")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://discord.gg/0VcupJEQX0HuE5HH");
                });

            comm.CreateCommand("warlock")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://discord.gg/0onXDymd9Wpc2CEu");
                });

            comm.CreateCommand("warrior")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://discord.gg/0pYY7932lTH4FHW6");
                });

            comm.CreateCommand("weakauras")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://discord.me/wa2");
                });

            comm.CreateCommand("tanks")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://discord.gg/fGzZSA5");
                });

            comm.CreateCommand("healers")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://discord.gg/0l64WMq72BIzjH3C");
                });

            comm.CreateCommand("amr")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://discord.gg/GC2GvmH");
                });

            comm.CreateCommand("logs")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("Raid logs: https://www.warcraftlogs.com/guilds/154690/");
                });

            comm.CreateCommand("source")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("Source code: https://github.com/Pouncekite/Bot");
                });
        }
    }
}
