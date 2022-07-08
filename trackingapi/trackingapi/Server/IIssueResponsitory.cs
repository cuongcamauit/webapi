using trackingapi.Data;
using trackingapi.Models;

namespace trackingapi.Server
{
    public interface IIssueResponsitory
    {
        List<Issue> GetAll();
        Issue? GetById(int id);
        Issue Add(Issue issue);
        void Update(Issue issue);
        void Delete(int id);
    }
}
