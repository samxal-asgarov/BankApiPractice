using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankUserApi.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime UseTime { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int BankId { get; set; }
        public virtual Bank Bank { get; set; }


    }
}
