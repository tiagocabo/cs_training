using System;

namespace workflow_engine
{

    class Program
    {
        static void Main(string[] args)
        {

            var workflow = new workflow();

            workflow.AddStep(new step1());
            workflow.AddStep(new step2());

            var worflow_engine = new workflow_engine();
            worflow_engine.Run(workflow);


        }
    }
}
