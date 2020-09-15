using System.Collections.Generic;

namespace workflow_engine
{
    public class workflow
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


        public void Execute()
        {
            foreach (IStep step in _steps)
            {
                step.Run();
            }
        }

    }
}
