namespace SimpleApi
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        private List<string> names = new List<string>() { "Bob", "Robert", "Maria", "Jason", "Freddy" };

        public Person()
        {
            Name = names[Random.Shared.Next(1, names.Count)];
            Age = Random.Shared.Next(1, 20);
            Id = Guid.NewGuid();
        }
    }
}
