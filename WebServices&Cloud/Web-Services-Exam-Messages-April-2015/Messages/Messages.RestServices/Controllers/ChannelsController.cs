namespace Messages.RestServices.Models
{
    using System.Linq;
    using System.Web.Http;
    using System.Web.Http.Description;

    using Messages.Data;
    using Messages.Data.Models;

    public class ChannelsController : ApiController
    {
        private MessagesDbContext db = new MessagesDbContext();

        // GET: api/Channels
        public IHttpActionResult GetChannels()
        {
            var channels =
                this.db.Channels.OrderBy(c => c.Name)
                    .ThenBy(c => c.Id)
                    .Select(
                        c => new ChannelOutputModel() { Id = c.Id, Name = c.Name });
            return this.Ok(channels);
            
        }

        // GET: api/Channels/5
        [ResponseType(typeof(Channel))]
        public IHttpActionResult GetChannel(int id)
        {
            var channel = this.db.Channels
                .Where( c => c.Id == id)
                .Select(c => new ChannelOutputModel()
                    {
                       Id = c.Id,
                       Name = c.Name                                        
                    });
            if (channel.FirstOrDefault() == null)
            {
                return this.NotFound();
            }

            return this.Ok(channel);
        }

        // PUT: api/Channels/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutChannel(int id, ChannelInputModel channelData)
        {
            if (channelData == null)
            {
                return this.BadRequest("Invalid channel data");
            }
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            Channel channel = this.db.Channels.Find(id);
            if (channel == null)
            {
                return this.NotFound();
            }

            var duplicateChannel = db.Channels.Any(c => c.Name == channelData.Name);

            if (duplicateChannel)
            {
                return this.Conflict();
            }
            channel.Name = channelData.Name;
            this.db.SaveChanges();

            return this.Ok(new
                {
                    Message = "Channel #" + channel.Id + " edited successfully"
                });
        }

        // POST: api/Channels
        [ResponseType(typeof(Channel))]
        public IHttpActionResult PostChannel(ChannelInputModel channelData)
        {
            if (channelData == null)
            {
                return this.BadRequest();
            }
            if (this.db.Channels.Any(c=> c.Name == channelData.Name))
            {
                return this.Conflict();
            }
            
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }
            var channel = new Channel(){Name = channelData.Name};


            this.db.Channels.Add(channel);
            this.db.SaveChanges();

            var createdCHannelOutput = new ChannelOutputModel()
                {
                    Id = channel.Id,
                    Name = channel.Name
                };

            return this.CreatedAtRoute("DefaultApi", new { id = channel.Id }, createdCHannelOutput);
        }

        // DELETE: api/Channels/5
        [ResponseType(typeof(Channel))]
        public IHttpActionResult DeleteChannel(int id)
        {
            Channel channel = db.Channels.Find(id);
            if (channel == null)
            {
                return NotFound();
            }

            if (channel.ChannelMessages.Any())
            {
                return this.Conflict();
            }

            db.Channels.Remove(channel);
            db.SaveChanges();
            
            return Ok(new
                {
                    Message = "Channel # "+channel.Id+" deleted."          
                });
        }



       
    }
}