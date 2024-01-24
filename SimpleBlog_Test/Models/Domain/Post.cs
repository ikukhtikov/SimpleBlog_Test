namespace SimpleBlog_Test.Models.Domain
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string Author { get; set; }
        public DateTime CreatedPost { get; set; }
        public DateTime UpdatedPost { get; set;}
        public bool IsVisiable { get; set; }
    }
}
