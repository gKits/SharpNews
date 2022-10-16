namespace SharpNews {
    public interface IArticle : IObservable<IArticle> {
        // Getter
        Author GetAuthor();
        string GetTitle();
        string GetBody();
        bool GetPublished();
        List<string> GetComments();

        // Setter
        void SetTitle(string title);
        void SetBody(string body);
        void SetPublish(bool published);

        //
        void AddComment(string comment);
    }
}