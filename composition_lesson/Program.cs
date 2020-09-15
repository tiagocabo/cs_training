using System;
using composition_lesson.funcs;

namespace composition_lesson
{
   
    
    
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();

            new DbMigrator(logger).Migrate();

            new Installer(new Logger()).Install();
        }
    }
}
