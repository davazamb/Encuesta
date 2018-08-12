using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuesta.Common.Models
{
    public class Answer
    {
        [Key]
        public int AnswerId { get; set; }
        public int PollId { get; set; }
        public string AnswerString { get; set; }
        public int Votes { get; set; }
        public DateTime DateAnswer { get; set; }

    }
}
