namespace SharpNews {
    public class CelebrityArticle : Article {
        public CelebrityArticle(ref Author author) : base(ref author) {
            title = String.Format("CelebrityArticle by {0}", this.author.name);
        }
    }
}