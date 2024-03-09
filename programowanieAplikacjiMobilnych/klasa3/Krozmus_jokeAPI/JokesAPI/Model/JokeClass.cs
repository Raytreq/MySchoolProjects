using System;
using System.Collections.Generic;
using System.Text;


namespace JokesAPI.Model
{
    public class JokeClass
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Setup { get; set; }
        public string Punchline { get; set; }
    }
}
