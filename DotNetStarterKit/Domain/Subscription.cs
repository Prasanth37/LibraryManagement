using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetStarterKit.Domain
{
    public class Subscription
    {
        public int SubscriptionId { get; set; }

        public string SubscriptionType { get; set; }

        public int MaximumBooksAllowed { get; set; }

        public DateTime SubscribedDate { get; set; }

        public DateTime ExpiryDate { get; set; }

    }
}