namespace SharpNews {
    public abstract class Article : IArticle {
        public string title;
        public readonly Author author;
        public string body;
        public List<IObserver<IArticle>> _observers;

        public Article(Author author, string title, string body) {
            this.title = title;
            this.author = author;
            this.body = body;

            _observers = new();
        }

        public string GetTitle() => title;
        public string GetBody() => body;
        public Author GetAuthor() => author;
    
        public void SetTitle(string title) { this.title = title; }
        public void SetBody(string body) { this.body = body; }

        public abstract void Attach(IObserver<IArticle> observer);
        public abstract void Detach(IObserver<IArticle> observer);
        public abstract void Notify();
    }
}