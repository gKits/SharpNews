namespace SharpNews {
    public class ArticleManager: IManager<IArticle> {
        public List<IArticle> articles = new();
        private List<Reader> subscribedReaders = new();

        public List<IArticle> GetSubjects() => articles;

        public void AddSubject(IArticle article) {
            articles.Add(article);
            AttachReadersToInterestedArticle(ref article);
        }

        public List<Reader> GetReaders() => subscribedReaders;

        public void AddReaders(params Reader[] readers) {
            foreach (Reader reader in readers) {
                subscribedReaders.Add(reader);
            }
        }

        private void AttachReadersToInterestedArticle(ref IArticle article) {
            foreach(Reader reader in subscribedReaders) {
                if (reader.InterestedIn(article.GetType())) {
                    article.Attach(reader);
                }
            }
        }
    }
}