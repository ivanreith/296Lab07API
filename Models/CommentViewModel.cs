using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IvanCastronuno.Models
{
    public class CommentViewModel
    {   
        [Required]
        public int StoryID { get; set; }
        [Required]
         public string StoryTopic { get; set; }
        [Required]
        public string CommentText { get; set; }
       
    }
}
