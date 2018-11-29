using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using System;
using System.Threading.Tasks;

namespace SecretSanta.AWS
{
    public class AWSClient : IAWSClient
    {
        AmazonDynamoDBClient _client;

        public AWSClient()
        {
            AWSCredentials credentials = new BasicAWSCredentials(accessKey: "AKIAIHF34373ETSMSU2A", secretKey: "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");
            _client = new AmazonDynamoDBClient(credentials, Amazon.RegionEndpoint.USEast2);
        }

        public Task<PutItemResponse> PutItem(PutItemRequest itemRequest)
        {
            return _client.PutItemAsync(itemRequest);
        }
        public Task<QueryResponse> Query(QueryRequest queryRequest)
        {
            return _client.QueryAsync(queryRequest);
        }
        public Task<ScanResponse> Scan(ScanRequest scanRequest)
        {
            return _client.ScanAsync(scanRequest);
        }
    }
}
