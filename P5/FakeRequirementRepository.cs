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

        string Add(Requirement requirement)
        {

        }
        List<Requirement> GetAll(Requirement requirement)
        {

        }
        string Remove(Requirement requirement)
        {

        }
        string Modify(Requirement requirement)
        {

        }
        Requirement GetRequirementById(int requirementId)
        {

        }
        int CountByFeatureId(int featureId)
        {

        }
        void RemoveByFeatureId(int featureId)
        {

        }

        string IRequirementRepository.Add(Requirement requirement)
        {
            throw new NotImplementedException();
        }

        List<Requirement> IRequirementRepository.GetAll(Requirement requirement)
        {
            throw new NotImplementedException();
        }

        string IRequirementRepository.Remove(Requirement requirement)
        {
            throw new NotImplementedException();
        }

        string IRequirementRepository.Modify(Requirement requirement)
        {
            throw new NotImplementedException();
        }

        Requirement IRequirementRepository.GetRequirementById(int requirementId)
        {
            throw new NotImplementedException();
        }

        int IRequirementRepository.CountByFeatureId(int featureId)
        {
            throw new NotImplementedException();
        }

        void IRequirementRepository.RemoveByFeatureId(int featureId)
        {
            throw new NotImplementedException();
        }
    }
}
