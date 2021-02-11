using System;
using System.Collections.Generic;

#nullable disable

namespace AlanTuring.Models
{
    public partial class FilesLearningMaterial
    {
        public int? FilesId { get; set; }
        public int? LearningMaterialsId { get; set; }

        public virtual File Files { get; set; }
        public virtual LearningMaterial LearningMaterials { get; set; }
    }
}
