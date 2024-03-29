﻿using System.ComponentModel.DataAnnotations.Schema;

namespace DemoProject.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Make Make { get; set; }

        [ForeignKey("Make")]
        public int MakeId { get; set; }
    }
}
