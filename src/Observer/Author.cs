namespace SharpNews {
    public class Author : Person {
        private List<IArticle> articles;

        public Author(string name) : base(name) {
            articles = new();
        }

        public void AddArticle(IArticle article) {
            articles.Add(article);
        }
        
        public void Publish(string title) {
            List<int> foundArticle = new();

            foreach (IArticle article in articles) {
                if (article.GetTitle() == title)
                    foundArticle.Add(articles.IndexOf(article));
            }

            switch (foundArticle.Count) {
                case 0:
                    throw new ArgumentException(String.Format("There are no articles with the title {0}", title));
                case 1:
                    articles[foundArticle[0]].SetPublish(this, true);
                    return;
                default:
                    throw new ArgumentException(String.Format("There are multiple articles with the title {0}", title));
            }
        }

        override public void Update(IArticle article, string message) {
            Console.WriteLine(String.Format("@[Author] {0}: {1}", name, message));
        }
    }
}