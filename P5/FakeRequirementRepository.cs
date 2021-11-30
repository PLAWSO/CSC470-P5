using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FakeRequirementRepository : IRequirementRepository
    {
        public string NO_ERROR = "";
        public string DUPLICATE_STATEMENT_ERROR = "Statements must be unique";
        public string EMPTY_STATEMENT_ERROR = "Statement must have a value";
        public string REQUIREMENT_NOT_FOUND_ERROR = "Requirement does not exist";
        public string MISSING_FEATURE_ERROR = "Must select a feature for this requirement.";
        public string MISSING_PROJECTID_ERROR = "Must select a project for this requirement.";

        List<Requirement> requirements;

        public string Add(Requirement requirement)
        {
            return "cool";
        }
        public List<Requirement> GetAll(Requirement requirement)
        {
            return new List<Requirement>();
        }
        public string Remove(Requirement requirement)
        {
            return "cool";
        }
        public string Modify(Requirement requirement)
        {
            return "cool";
        }
        public Requirement GetRequirementById(int requirementId)
        {
            return new Requirement();
        }
        public int CountByFeatureId(int featureId)
        {
            return 0;
        }
        public void RemoveByFeatureId(int featureId)
        {

        }
    }
}
