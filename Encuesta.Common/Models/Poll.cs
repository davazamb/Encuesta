using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuesta.Common.Models
{
    public class Poll
    {
        [Key]
        public int PollId { get; set; }
        public string Question { get; set; }
        public string User { get; set; }
        public string IsAvailable { get; set; }
        public DateTime DatePoll { get; set; }
    }
}
