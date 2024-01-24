using SimpleBlog_Test.Models.Domain;

namespace SimpleBlog_Test
{
    public static class StaticData
    {
        public static List<Post> Posts = new();
        public static void AddPost(Post newPost)
        {
            Posts.Add(newPost);
        }
    }
}
