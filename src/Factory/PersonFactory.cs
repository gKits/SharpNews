namespace SharpNews {
    public class PersonFactory : IFactory<IPerson, string> {
        public PersonFactory() {}

        public IPerson Create(string type, string name) {
            if (type == "Author")
                return new Author(name);
            else if ( type == "Reader" ) 
                return new Reader(name);
            throw new ArgumentException(String.Format("{0} is not a valid type", type));
        }
    }
}