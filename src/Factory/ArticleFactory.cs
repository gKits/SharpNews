namespace SharpNews {
    public abstract class ArticleFactory : IFactory<IArticle, Author> {
        public IArticle Create(string type, Author author) {
            if (type == "TechArticle") {
                return new TechArticle(ref author);
            }
            else if ( type == "PoliticsArticle" ) {
                return new PoliticsArticle(ref author);
            }
            else if ( type == "BusinessArticle" ) {
                return new BusinessArticle(ref author);
            }
            else if ( type == "CelebrityArticle" ) {
                return new CelebrityArticle(ref author);
            }
            throw new ArgumentException(String.Format("{0} is not a valid type", type));
        }
    }
}