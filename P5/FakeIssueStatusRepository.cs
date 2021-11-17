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
        public FakeIssueStatusRepository()
        {

            issueStatuses = new List<IssueStatus>();
            IssueStatus stat = new IssueStatus();
            stat.Id = 1;
            stat.Value = "Open";
            issueStatuses.Add(stat);
            IssueStatus stat2 = new IssueStatus();
            stat2.Id = 2;
            stat2.Value = "Assigned";
            issueStatuses.Add(stat2);
            IssueStatus stat3 = new IssueStatus();
            stat3.Id = 3;
            stat3.Value = "Fixed";
            issueStatuses.Add(stat3);
            IssueStatus stat4 = new IssueStatus();
            stat4.Id = 4;
            stat4.Value = "Closed-Won't Fix";
            issueStatuses.Add(stat4);
            IssueStatus stat5 = new IssueStatus();
            stat5.Id = 5;
            stat5.Value = "Closed-Fixed";
            issueStatuses.Add(stat5);
            IssueStatus stat6 = new IssueStatus();
            stat6.Id = 6;
            stat6.Value = "Closed-by design";
            issueStatuses.Add(stat6);


       

        }
        public void Add(int Id, string value)
        {

        }

        public List<IssueStatus> GetAll()
        {
        
            return issueStatuses;
        }

        public int GetIdByStatus(string value)
        {
            return 0;
        }

        public string GetValueById(int Id)
        {
            foreach (IssueStatus p in issueStatuses)
            {
                if (p.Id == Id)
                    return p.Value;
            }


                return "Change";
        }

    }
}
