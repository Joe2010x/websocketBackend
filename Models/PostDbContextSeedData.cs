using System;
using System.Linq;

namespace WSserver.Models;

public static class PostDbContextSeedData
{
    static bool seeded = false;

    public static void EnsureSeedDate (this PostDbContext context) {

        if (!seeded && context.Posts.Count() == 0) {
            var post = new Post ("Jackson",null, "a new post","empty content");

            context.Posts.Add(post);
            context.SaveChanges();
            seeded = true;
        }
    }

}