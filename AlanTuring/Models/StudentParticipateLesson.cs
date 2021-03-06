﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AlanTuring.Models
{
    public partial class StudentParticipateLesson
    {
        public int Id { get; set; }
        public int PathsId { get; set; }
        public int CoursesId { get; set; }
        public int DeclarativeLessonsId { get; set; }
        public int LessonsId { get; set; }
        public int StudentsId { get; set; }
        public int? Mark { get; set; }
        public bool? Attendance { get; set; }
        public int StudentsParticipateLessonsIdentity { get; set; }
    }
}
