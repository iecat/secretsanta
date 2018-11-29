using Amazon.DynamoDBv2.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SecretSanta.AWS
{
    public class DataService: IDataService
    {
        private readonly IAWSClient _client;
        public DataService (IAWSClient client)
        {
            _client = client;
        }

        public async Task AddNewRecord(Dictionary<string,string> dataToAdd)
        {
            Dictionary<string, AttributeValue> attributes = new Dictionary<string, AttributeValue>();
            foreach (var keyVal in dataToAdd)
            {
                attributes[keyVal.Key] = new AttributeValue { S = keyVal.Value };
            }

            PutItemRequest request = new PutItemRequest
            {
                TableName = "SS.Attendees",
                Item = attributes
            };      

            await _client.PutItem(request);
        }

        public async Task<string> GetItemByKey()
        {
            QueryRequest request = new QueryRequest
            {
                TableName = "SS.Attendees",
                KeyConditionExpression = "Id = :v_Id",
                ExpressionAttributeValues = new Dictionary<string, AttributeValue> { { ":v_Id", new AttributeValue { S = "Amazon DynamoDB#DynamoDB Thread 1" } } }
            };

           QueryResponse response =  _client.Query(request).GetAwaiter().GetResult() ;
            return "";       
        }


        public async Task<string> ScanTable()
        {
            ScanRequest request = new ScanRequest
            {
                TableName = "SS.Attendees",

            };

            ScanResponse response = _client.Scan(request).GetAwaiter().GetResult();

            return "";
        }


        public async Task GetAllItems()
        {

        }
    }
}
