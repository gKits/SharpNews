namespace SharpNews {
    public interface IManager<T> {
        List<T> GetSubjects();
        void AddSubject(T subject);
    }
}