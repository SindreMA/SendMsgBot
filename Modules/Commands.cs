using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TemplateBot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("Ping")]
        public async Task Ping()
        {
            await Context.Channel.SendMessageAsync("Pong!");
        }
        [Command("sendmsg")]
        public async Task sendmsg(ulong channelid, [Remainder]string text)
        {
            try
            {
                var chan = Context.Client.GetChannel(channelid);
                var channel = (chan as SocketTextChannel);
                await channel.SendMessageAsync(text);
            }
            catch (Exception)
            {
            }
        }
    }
}
