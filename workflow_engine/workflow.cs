using System.Collections.Generic;

namespace workflow_engine
{
    public class workflow : IWorkflow
    {
        private readonly List<IStep> _steps;

        public workflow()
        {
            _steps = new List<IStep>();
        }

        public void AddStep(IStep step)
        {
            _steps.Add(step);
        }

        public IEnumerable<IStep> GetSteps()
        {
            return _steps;
        }

        public void RemoveStep(IStep step)
        {
            _steps.Remove(step);
        }
    }
}
