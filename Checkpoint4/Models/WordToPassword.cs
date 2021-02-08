using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkpoint4.Models
{
    public class WordToPassword
    {
        private string title { get; set; }
        private string password { get; set; }
        private string description { get; set; }
        private List<GeneratedPassword> GeneratedPasswords { get; set; }
    }
}
