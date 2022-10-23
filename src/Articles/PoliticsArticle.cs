namespace SharpNews {
    public class PoliticsArticle : Article {
        public PoliticsArticle(ref Author author) : base(ref author) {
            title = String.Format("PoliticsArticle by {0}", this.author.name);
        }
    }
}