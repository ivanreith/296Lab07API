using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Lab07.Models;

namespace WebAPI_Lab07.Repositories
{
    public  interface IPosters

    {
        List<AppUser> GetPosterByStory(StoriesModelForm story);
        List<AppUser> GetAllPosters();
        AppUser GetPosterByName(string name);
        AppUser GetPosterById(string id);
        int Add(AppUser poster);
        int Edit(AppUser poster);
        int Delete(string id);


    }

}
