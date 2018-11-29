using Amazon.DynamoDBv2.DataModel;


namespace SecretSanta.AWS
{
    [DynamoDBTable("AnimalsInventory")]
    public class Attendees {

        [DynamoDBHashKey]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
