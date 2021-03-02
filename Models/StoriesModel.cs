using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI_Lab07.Models
{
  

    public class StoriesModelForm
    {
        private List<CommentModel> comments = new List<CommentModel>();
        // EF Core will configure the database to generate this value
        [Key]
        public int StoryID { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="Title between 1 and 50 chars")]
        public string StoryTitle { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "storyTopic between 1 and 25 chars")]
        public string StoryTopic { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "storyText between 1 and 250 chars")]
        public string StoryText { get; set; }

        // changfe due to identity  =>  stuff public string Name { get; set; }
        public AppUser Poster { get; set; }       
        
        public DateTime StoryTime { get; set; }

        public List<CommentModel> Comments
        {
            get { return comments; }
        }

        public string Slug =>
         StoryTitle?.Replace(' ', '-').ToLower() + '-' + StoryTopic?.ToString();

    }
    
}
  