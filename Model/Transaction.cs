namespace order_api.Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public Transaction(int id, string name, string value, string type, string description)
        {
            Id = id;
            Name = name;
            Value = value;
            Type = type;
            Description = description;
        }


    }
}
