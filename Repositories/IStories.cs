 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Lab07.Models;

namespace WebAPI_Lab07.Repositories
{
    public interface IStories
    {
        //   IQueryable<StoriesModelForm> stories { get; } // read   or get    
        // object Poster { get; }
        List<StoriesModelForm> GetAllStories();
        StoriesModelForm GetStoryById(string id);
        List<StoriesModelForm> GetStoriesByPoster(AppUser poster);
        AppUser GetPosterByStory(string id);
        StoriesModelForm GetStoryByTitle(string title);
       void  AddStory(StoriesModelForm Story);
       void Edit(StoriesModelForm Story);
       void Delete(StoriesModelForm Story);
        //void AddStory(StoriesModelForm stories);  // create
        // StoriesModelForm GetStoryById(int StoryId); //Retrieve a story by topic
        // void UpdateStory(StoriesModelForm stories);
        //  void DeleteStory(StoriesModelForm stories);
    }
}
