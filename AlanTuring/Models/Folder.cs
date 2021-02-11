using System;
using System.Collections.Generic;

#nullable disable

namespace AlanTuring.Models
{
    public partial class Folder
    {
        public Folder()
        {
            Files = new HashSet<File>();
        }

        public int ParentId { get; set; }
        public string Name { get; set; }
        public bool Accessibility { get; set; }
        public int? ChildId { get; set; }

        public virtual ICollection<File> Files { get; set; }
    }
}
