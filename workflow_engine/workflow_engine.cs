namespace workflow_engine
{
    public class workflow_engine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (IStep step in workflow.GetSteps())
            {
                step.Execute();
            }
        }
    }
}