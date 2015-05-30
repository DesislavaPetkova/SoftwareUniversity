namespace Twitter.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Notification
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime NotificationDate { get; set; }

        public NotificationType NotificationType { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
