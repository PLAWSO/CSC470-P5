using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class FakeIssueStatusRepository : IIssueStatusRepository
    {
        public List<IssueStatus> issueStatuses;
        public void Add(int Id, string value)
        {

        }

        public List<IssueStatus> GetAll()
        {
            return this.issueStatuses;
        }

        public int GetIdByStatus(string value)
        {
            return 0;
        }

        public string GetValueById(int Id)
        {
            return "ur mom";
        }

    }
}
