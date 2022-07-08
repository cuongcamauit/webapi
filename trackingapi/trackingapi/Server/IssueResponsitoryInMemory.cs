using trackingapi.Models;

namespace trackingapi.Server
{
    public class IssueResponsitoryInMemory : IIssueResponsitory
    {
        static List<Issue> issues = new List<Issue>
        {
            new Issue {Id = 1, Title = "logic_error", Description = "missing_formula"},
            new Issue {Id = 2, Title = "syntax_error", Description = "missing_a_blanket"}
        };
        public Issue Add(Issue issue)
        {
            issues.Add(issue);
            return issue;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Issue> GetAll()
        {
            return issues;
        }

        public Issue? GetById(int id)
        {
            return issues.SingleOrDefault(i => i.Id == id);
        }

        public void Update(Issue issue)
        {
            throw new NotImplementedException();
        }
    }
}
