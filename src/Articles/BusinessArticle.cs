namespace SharpNews {
    public class BusinessArticle : Article {
        public BusinessArticle(ref Author author) : base(ref author) {
            title = String.Format("BusinessArticle by {0}", this.author.name);
        }
    }
}