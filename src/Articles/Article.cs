namespace SharpNews {
    public abstract class Article : IArticle {
        internal Author author;

        internal string title;
        internal string body;

        internal bool published;
        internal List<string> comments;

        internal List<IObserver<IArticle>> observers;

        public Article(ref Author author) {
            this.author = author;
            title = String.Format("Article by {0}", this.author.name);
            body = "Lorem epsum";
            comments = new();
            observers = new();
            published = false;
            this.author.AddArticle(this);
        }

        // Getter
        public Author GetAuthor() => author;
        public string GetTitle() => title;
        public string GetBody() => body;
        public bool GetPublished() => published;
        public List<string> GetComments() => comments;

        // Setter
        public void SetTitle(Author author, string title) {
            if (this.author == author)
                if (published)
                    Notify(String.Format("Title of {0} was changed to {1}", this.title, title));
                this.title = title;
        }
        public void SetBody(Author author, string body) {
            if (this.author == author)
                if (published)
                    Notify(String.Format("Body of {0} was changed", this.body));
                this.body = body;  
        }
        public void SetPublish(Author author, bool published) { 
            if (this.author == author)
                if (published)
                    Notify(String.Format("The Article {0} was published", title));
                this.published = published;
        }

        public void AddComment(string body) {
            comments.Add(body);
            author.Update(this, String.Format("New Comment under {0} {1}", title, body));
        }

        public override string ToString()
        {
            string commentString = "";
            foreach (string comment in comments) {
                commentString += comment + "\n";
            }
            return String.Format("{0}\n\n{1}\n\nwritten by {2}\n\n\nComments:\n{3}", title, body, author.name, commentString);
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
        public void Notify(string message) {
            foreach (IObserver<IArticle> observer in observers) {
                observer.Update(this, message);
            }
        }
    }
}