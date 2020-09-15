using System;

namespace classes_ex1.funcs
{
    public class Stopwatch
        {
            internal int flag;

            public DateTime Start()
            {   
                if (flag == 0)
                {
                var date = DateTime.Now;
                this.flag = 1;

                return date;
                }
                else
                {
                    throw new InvalidOperationException("Cannot start twice");
                }
                
                
            }

            public DateTime Stop(DateTime start)
            {
                var date = DateTime.Now;
                this.flag = 0;
                var elapsed_time = (date - start).Seconds;
                System.Console.WriteLine("elapsed time: ");
                System.Console.WriteLine(elapsed_time);

                return date;
            }


        }
}