namespace SharpNews {
    public class ArticleFactory : IFactory<IArticle, Author> {
        public IArticle Create(string type, Author author) {
            switch(type) {
                case "TechArticle":
                    return new TechArticle(ref author);
                case "PoliticsArticle":
                    return new PoliticsArticle(ref author);
                case "BusinessArticle":
                    return new BusinessArticle(ref author);
                case "CelebrityArticle":
                    return new CelebrityArticle(ref author);
                default:
                    throw new ArgumentException(String.Format("{0} is not a valid type", type));
            }
        }
    }
}