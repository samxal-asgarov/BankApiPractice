using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankUserApi.Models.DTOs
{
    public class CardDto
    {

        public string Name { get; set; }
        public DateTime UseTime { get; set; }

        public int BankId { get; set; }

        public int UserId { get; set; }
    }
}
