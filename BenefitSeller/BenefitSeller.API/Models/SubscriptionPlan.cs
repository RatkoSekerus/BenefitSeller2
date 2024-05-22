using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BenefitSeller.API.Models
{
    public class SubscriptionPlan
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public SubscriptionType SubscriptionType { get; set; }
    }
}
