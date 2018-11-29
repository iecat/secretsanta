using Amazon.DynamoDBv2.Model;
using System.Threading.Tasks;

namespace SecretSanta.AWS
{
    public interface IAWSClient
    {
        Task<PutItemResponse> PutItem(PutItemRequest itemRequest);
        Task<QueryResponse> Query(QueryRequest queryRequest);

        Task<ScanResponse> Scan(ScanRequest scanRequest);
    }
}
