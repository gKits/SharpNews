namespace SharpNews {
    public abstract class Manager<T> : IManager<T> {
        internal List<T> subjects;

        public Manager() {
            subjects = new();
        }

        public List<T> GetSubjects() => subjects;
        public void AddSubject(T subject) { subjects.Add(subject); }
    }
}