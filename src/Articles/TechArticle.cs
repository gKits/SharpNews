namespace SharpNews {
    public class TechArticle : Article {
        public TechArticle(ref Author author) : base(ref author) {
            title = String.Format("TechArticle by {0}", this.author.name);
        }
    }
}