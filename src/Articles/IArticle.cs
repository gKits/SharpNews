namespace SharpNews {
    public interface IArticle : IObservable<IArticle> {
        // Getter
        Author GetAuthor();
        string GetTitle();
        string GetBody();
        bool GetPublished();
        List<string> GetComments();

        // Setter
        void SetTitle(Author author, string title);
        void SetBody(Author author, string body);
        void SetPublish(Author author, bool published);

        //
        void AddComment(string comment);
    }
}