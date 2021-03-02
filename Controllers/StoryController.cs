using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Lab07.Models;
using WebAPI_Lab07.Repositories;
namespace WebAPI_Lab07.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
   
    public class StoryController : ControllerBase
    {
        private IStories storiesRepo;

        public StoryController(IStories storiesRepository)
        {
            this.storiesRepo = storiesRepository;
        }


        [HttpGet]
        public IActionResult GetAllStories()
        {
            var stories = storiesRepo.GetAllStories();
            if (stories.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(stories);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetStory( string id)
        {
            var story = storiesRepo.GetStoryById(id);
            if (story == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(story);
            }
        }
        [HttpPost]
        public IActionResult AddStory([FromBody] StoriesModelForm StoryVm)
        {
            if (StoryVm != null)
            {
                StoriesModelForm story = new StoriesModelForm
                {
                    StoryTitle = StoryVm.StoryTitle,
                    StoryTopic = StoryVm.StoryTopic,
                    StoryText = StoryVm.StoryText,
                    Poster = StoryVm.Poster,
                    StoryTime =StoryVm.StoryTime                 
                };              
                return Ok(story);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult Replace(string id, [FromBody] StoriesModelForm StoryVm)
        {
            if (StoryVm != null)
            {
                StoriesModelForm story = storiesRepo.GetStoryById(id);
                story.StoryTitle = StoryVm.StoryTitle;
                story.StoryTopic = StoryVm.StoryTopic;
                story.StoryText = StoryVm.StoryText;
                story.Poster.Name = StoryVm.Poster.Name;
                story.StoryTime = StoryVm.StoryTime;


                storiesRepo.Edit(story);   
                return Ok(story);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPatch("{id}")]
        public IActionResult UpdateStory(string id, [FromBody] PatchViewModel patchVm)
        {
            // TODO: Add support for more ops: remove, copy, move, test

            StoriesModelForm story = storiesRepo.GetStoryById(id);
            switch (patchVm.Path)
            {
                case "title":
                    story.StoryTitle = patchVm.Value;
                    break;
                case "time":
                    story.StoryTime = Convert.ToDateTime(patchVm.Value);
                    break;
                case "poster":
                    story.Poster.Name = patchVm.Value;   // TODO: manage author collection
                    break;
                case "topic":
                   story.StoryTopic = patchVm.Value;
                    break;
                case "text":
                    story.StoryText = patchVm.Value;
                    break;
                default:
                    return BadRequest();
            }
            storiesRepo.Edit(story);
            return Ok(story);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStory(string id)
        {
            StoriesModelForm story = storiesRepo.GetStoryById(id);
            if (story != null)
            {
                storiesRepo.Delete(story);
                return NoContent();  // Successfully completed, no data to send back
            }
            else
            {
                return NotFound();
            }
        }



    }
}
