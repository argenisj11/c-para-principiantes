using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_game
{
    public class Question
    {
        public int id {  get; set; }
        public string QuestionText { get; set; }
        public List<option> options { get; set; }
       
    }
}
