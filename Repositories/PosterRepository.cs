using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Lab07.Models;
using WebAPI_Lab07.Repositories;
namespace WebAPI_Lab07.Repositories
{
    public class PosterRepository : IPosters
    {
        private StoryContext context;
        public PosterRepository(StoryContext c)
        {
            context = c;

        }
        public List<AppUser> GetAllPosters()
        {
            List<AppUser> posters = context.AppUser.ToList<AppUser>();
            return posters;
        }
        public AppUser GetPosterByName(string name)
        {
            throw new NotImplementedException();
        }

        public AppUser GetPosterById(string id)
        {
            return context.AppUser.First(a => a.Id == id);
        }

        public List<AppUser> GetPosterByStory(StoriesModelForm story)
        {
            throw new NotImplementedException();
        }

        public int Add(AppUser author)
        {
            context.AppUser.Add(author);
            return context.SaveChanges();
        }

        public int Edit(AppUser poster)
        {
            var posterFromDb = GetPosterById(poster.Id);
            posterFromDb.Email = poster.Email;
            posterFromDb.Name = poster.Name;
            posterFromDb.UserName = poster.UserName;
            return context.SaveChanges();
        }

        public int Delete(string id)
        {
            var posterFromDb = context.AppUser.First(a => a.Id == id);
            context.Remove(posterFromDb);
            return context.SaveChanges();
        }

    }
}
