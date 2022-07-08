using trackingapi.Data;
using trackingapi.Models;

namespace trackingapi.Server
{
    public class IssueResponsitory : IIssueResponsitory
    {
        private readonly IssueDbContext _context;

        public IssueResponsitory(IssueDbContext issueDbContext)
        {
            _context = issueDbContext;
        }
        public Issue Add(Issue issue)
        {
            _context.Add(issue);
            _context.SaveChanges();
            return issue;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Issue> GetAll()
        {
            return _context.Issues.ToList();
        }

        public Issue? GetById(int id)
        {
            return _context.Issues.SingleOrDefault(h => h.Id == id);
        }

        public void Update(Issue issue)
        {
            throw new NotImplementedException();
        }
    }
}
