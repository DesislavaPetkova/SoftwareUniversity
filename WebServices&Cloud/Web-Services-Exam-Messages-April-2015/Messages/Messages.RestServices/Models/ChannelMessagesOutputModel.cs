namespace Messages.RestServices.Models
{
    using System;

    public class ChannelMessagesOutputModel
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime DateSent { get; set; }

        public string Sender { get; set; }
    }
}
