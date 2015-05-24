using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Web
{
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
