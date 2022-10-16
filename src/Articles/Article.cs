namespace SharpNews {
    public abstract class Article : IArticle {
        internal Author author;

        internal string title;
        internal string body;

        internal bool published;
        internal List<string> comments;

        internal List<IObserver<IArticle>> observers;

        public Article(Author author) {
            this.author = author;
            title = "Title";
            body = "Body";
            comments = new();
            observers = new();
            published = false;
        }

        // Getter
        public Author GetAuthor() => author;
        public string GetTitle() => title;
        public string GetBody() => body;
        public bool GetPublished() => published;

        // Setter
        public void SetTitle(string title) {
            this.title = title;
            if (published)
                Notify();
        }
        public void SetBody(string body) {
            this.body = body;
            if (published)
                Notify();    
        }
        public void SetPublish(bool published) { 
            this.published = published;
            Notify();
        }

        // Observer Methods
        public void Attach(IObserver<IArticle> observer) {
            if (!observers.Contains(observer))
                observers.Add(observer);
        }
        public void Detach(IObserver<IArticle> observer) {
            if (observers.Contains(observer))
                observers.Remove(observer);
        }
        public void Notify() {
            foreach (IObserver<IArticle> observer in observers) {
                observer.Update(this);
            }
        }
    }
}