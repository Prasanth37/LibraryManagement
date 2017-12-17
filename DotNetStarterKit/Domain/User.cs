using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetStarterKit.Domain
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public long UserId { get; set; }

        public string EmailId { get; set; }

        public int MobileNumber { get; set; }

        public int Main { get; set; }

        public int Cross { get; set; }

        public int SubscriptionId { get; set; }

        public Subscription SubscriptionPlan { get; set; }
    }
}