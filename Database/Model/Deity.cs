using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectZeus.Database.Model
{
    public class Deity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MythologyId { get; set; }
        public  virtual Mythology Mythology { get; set; }
    }
}
