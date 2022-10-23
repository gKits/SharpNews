namespace SharpNews {
    public class Author : Person {
        private List<IArticle> articles;

        public Author(string name) : base(name) {
            articles = new();
        }

        public void AddArticle(IArticle article) {
            articles.Add(article);
        }
        
        public void Publish(int index) {
            articles[index].SetPublish(this, true);
        }

        override public void Update(IArticle article, string message) {
            Console.WriteLine(String.Format("@[Author] {0}: {1}", name, message));
        }
    }
}