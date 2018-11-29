using System.Collections.Generic;
using System.Threading.Tasks;

namespace SecretSanta.AWS
{
    public interface IDataService
    {
        Task AddNewRecord(Dictionary<string, string> dataToAdd);
        Task<string> GetItemByKey();
        Task<string> ScanTable();
    }
}
