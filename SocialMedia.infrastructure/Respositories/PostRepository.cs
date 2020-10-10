using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.infrastructure.Respositories
{
    public class PostRepository : IPostRepository
    {
        //dummy para obtener datos;
        public async Task<IEnumerable<Post>> GetPost()
        {
            var posts = Enumerable.Range(1, 10).Select(x => new Post
            {
                PostId = x,
                Description = $"Description {x}",
                Date = DateTime.Now,
                Image = $"https://misapis.com/{x}",
                UserId = x * 2
            });
            await Task.Delay(10);

            return posts;
        }

        
    }
}
