using System.Collections.Generic;

namespace League.Domain.Entities
{
    public class Style
    {
        public string description { get; set; }
        public List<Selection> selections { get; set; }
        public int style { get; set; }
    }


}
