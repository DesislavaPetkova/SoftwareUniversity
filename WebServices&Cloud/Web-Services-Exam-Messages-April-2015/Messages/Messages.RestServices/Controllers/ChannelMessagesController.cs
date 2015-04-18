namespace Messages.RestServices.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using System.Web.Http.Description;
    using System.Web.Mvc;

    using Messages.Data;
    using Messages.Data.Models;
    using Messages.RestServices.Models;

    public class ChannelMessagesController : ApiController
    {
        private MessagesDbContext db = new MessagesDbContext();

        // GET: api/channel-messages/5
        [System.Web.Http.Route("api/channel-messages/{channelName}")]
        [ResponseType(typeof(Channel))]
        public IHttpActionResult GetChannelMessages(string channelName, [FromUri]string limit = null)
        {
            var channel = db.Channels.FirstOrDefault(c => c.Name == channelName);
            if (channel == null)
            {
                return this.NotFound();
            }

            var channelMessages = this.db.ChannelMessages
                .OrderByDescending(m => m.DateSent)
                .ThenByDescending(m => m.Id)
                .Where(m => m.Channel.Name == channelName)
                .Select(m => new ChannelMessagesOutputModel()
                {
                    Id = m.Id,
                    Text = m.Text,
                    DateSent = m.DateSent,
                    Sender = m.Sender != null ? m.Sender.UserName : null
                });

            if (limit != null)
            {
                int maxCount = 0;
                int.TryParse(limit, out maxCount);
                if (maxCount < 1 || maxCount > 1000)
                {
                    return this.BadRequest("Limit range should be 1..1000");
                }
                channelMessages = channelMessages.Take(maxCount);
            }


            return this.Ok(channelMessages);
        }
    }
}
