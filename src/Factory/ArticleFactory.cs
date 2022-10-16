namespace SharpNews {
    public abstract class ArticleFactory : IFactory<IArticle, Author> {
        public IArticle Create(string type, Author author) {
            if (type == "TechArticle") {
                return new TechArticle(author);
            }
            else if ( type == "PoliticsArticle" ) {
                return new PoliticsArticle(author);
            }
            else if ( type == "BusinessArticle" ) {
                return new BusinessArticle(author);
            }
            else if ( type == "CelebrityArticle" ) {
                return new CelebrityArticle(author);
            }
            throw new ArgumentException(String.Format("{0} is not a valid type", type));
        }
    }
}