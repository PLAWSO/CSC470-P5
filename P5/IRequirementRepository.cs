using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IRequirementRepository
    {
        string Add(Requirement requirement);
        List<Requirement> GetAll(Requirement requirement);
        string Remove(Requirement requirement);
        string Modify(Requirement requirement);
        Requirement GetRequirementById(int requirementId);
        int CountByFeatureId(int featureId);
        void RemoveByFeatureId(int featureId);
    }
}
