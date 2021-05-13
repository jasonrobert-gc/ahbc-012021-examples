namespace Lab27.Models
{
    public class RedditViewModel
    {
        public RedditViewModel(string title, string thumbnail, string url)
        {
            Title = title;
            Thumbnail = thumbnail;
            Url = url;
        }

        public string Title { get; }
        public string Thumbnail { get; }
        public string Url { get; }
    }
}
