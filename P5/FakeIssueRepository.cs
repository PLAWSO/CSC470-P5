using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FakeIssueRepository : IIssueRepository
    {
        string NO_ERROR = "";
        string EMPTY_TITLE_ERROR = "A Title is required.";
        string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery date/time.";
        string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future.";
        string EMPTY_DISCOVERER_ERROR = "A Discoverer is required.";

        public static List<Issue> issueList;

        public FakeIssueRepository()
        {
            if (issueList == null)
            {
                issueList = new List<Issue>();
                Issue issue = new Issue();
                issue.Id = 1;
                issue.ProjectId = 1;
                issue.Title = "issue one";
                issue.DiscoveryDate = new DateTime(2021, 11, 5);
                issue.Discoverer = "bob";
                issue.InitialDescription = "you done screwed up";
                issue.Component = "sure";
                issue.IssueStatusId = 434;

                issueList.Add(issue);

                issue = new Issue();

                issue.Id = 2;
                issue.ProjectId = 1;
                issue.Title = "issue two";
                issue.DiscoveryDate = new DateTime(2021, 11, 6);
                issue.Discoverer = "bob";
                issue.InitialDescription = "you done screwed up";
                issue.Component = "sure";
                issue.IssueStatusId = 434;

                issueList.Add(issue);

                issue = new Issue();

                issue.Id = 3;
                issue.ProjectId = 1;
                issue.Title = "issue three";
                issue.DiscoveryDate = new DateTime(2021, 10, 7);
                issue.Discoverer = "steve";
                issue.InitialDescription = "you done screwed up";
                issue.Component = "sure";
                issue.IssueStatusId = 434;

                issueList.Add(issue);
                issue = new Issue();

                issue.Id = 4;
                issue.ProjectId = 1;
                issue.Title = "issue four";
                issue.DiscoveryDate = new DateTime(2021, 12, 5);
                issue.Discoverer = "bob";
                issue.InitialDescription = "you done screwed up";
                issue.Component = "absolutely";
                issue.IssueStatusId = 434;

                issueList.Add(issue);
            }
        }

        public string Add(Issue issue)
        {
            issueList.Add(issue);
            return "Success";
        }

        public List<Issue> GetAll(int ProjectId)
        {
            return issueList;
        }

        public bool Remove(Issue issue)
        {
            return true;
        }

        public string Modify(Issue issue)
        {
            return "ur mom";
        }

        public int GetTotalNumberOfIssues(int ProjectId)
        {
            return issueList.Count;
        }

        public List<string> GetIssuesByMonth(int ProjectId)
        {
            issueList.Sort((x, y) => DateTime.Compare(x.DiscoveryDate, y.DiscoveryDate));
            List<string> list = new List<string>();

            int numOfIssues = issueList.Count;

            int currentMonth = issueList.First().DiscoveryDate.Month;
            int issuesInMonth = 1;
            for (int z = 1; z < numOfIssues; z++)
            {
                while (currentMonth == issueList[z].DiscoveryDate.Month)
                {
                    issuesInMonth++;
                    z++;
                }
                list.Add(issueList[z - 1].DiscoveryDate.Year + " - " + currentMonth + ": " + issuesInMonth);
                currentMonth = issueList[z].DiscoveryDate.Month;
                issuesInMonth = 1;
            }

            list.Add(issueList[numOfIssues - 1].DiscoveryDate.Year + " - " + currentMonth + ": " + issuesInMonth);

            return list;
        }

        public List<string> GetIssuesByDiscoverer(int ProjectId)
        {
            Dictionary<string, int> users = new Dictionary<string, int>();
            foreach (Issue issue in issueList)
            {
                if (users.ContainsKey(issue.Discoverer))
                    users[issue.Discoverer]++;
                else
                    users.Add(issue.Discoverer, 1);
            }

            List<string> list = new List<string>();
            foreach (KeyValuePair<string, int> user in users)
                list.Add(user.Key + ": " + user.Value);

            return list;
        }

        public Issue GetIssueById(int Id)
        {
            Issue issue = new Issue();
            return issue;
        }
    }
}
