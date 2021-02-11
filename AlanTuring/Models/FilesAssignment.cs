using System;
using System.Collections.Generic;

#nullable disable

namespace AlanTuring.Models
{
    public partial class FilesAssignment
    {
        public int? FilesId { get; set; }
        public int? AssignmentsId { get; set; }

        public virtual Assignment Assignments { get; set; }
        public virtual File Files { get; set; }
    }
}
