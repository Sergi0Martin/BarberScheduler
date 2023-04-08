namespace BarberScheduler.Domain.Aggregates.Users
{
    public sealed class User
    {
        public User(string userName, string firstName, string lastName, bool owner)
        {
            Id = Guid.NewGuid();
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            Owner = owner;
        }

        public Guid Id { get; private set; }

        public string UserName { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public bool Owner { get; private set; }
    }
}
