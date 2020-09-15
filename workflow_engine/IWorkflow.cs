using System.Collections.Generic;

namespace workflow_engine
{
    public interface IWorkflow
    {
        void AddStep(IStep step);
        void RemoveStep(IStep step);

        IEnumerable<IStep> GetSteps();
    }
}