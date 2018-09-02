using Datalayer.Interfaces;
using Entities;
using Entities.Factory;
using System.Collections.Generic;

namespace Datalayer
{
    public class GradesData : IDataComponents<IGrade>
    {
        public List<IGrade> ObjectsList { get; set; }

        public List<IGrade> RetrieveObjects()
        {
            this.ObjectsList = new List<IGrade>() {

                EntityFactory.CreateGrade(11, 109, 6),
                EntityFactory.CreateGrade(11, 109, 5),
                EntityFactory.CreateGrade(11, 109, 4),
                EntityFactory.CreateGrade(22, 109, 4),
                EntityFactory.CreateGrade(22, 109, 4),
                EntityFactory.CreateGrade(22, 109, 4),
                EntityFactory.CreateGrade(33, 109, 4),
                EntityFactory.CreateGrade(33, 109, 4),
                EntityFactory.CreateGrade(33, 109, 4),

                EntityFactory.CreateGrade(11, 108, 2),
                EntityFactory.CreateGrade(11, 108, 5),
                EntityFactory.CreateGrade(11, 108, 5),
                EntityFactory.CreateGrade(22, 108, 6),
                EntityFactory.CreateGrade(22, 108, 3),
                EntityFactory.CreateGrade(22, 108, 6),
                EntityFactory.CreateGrade(33, 108, 5),
                EntityFactory.CreateGrade(33, 108, 5),
                EntityFactory.CreateGrade(33, 108, 4),

                EntityFactory.CreateGrade(11, 107, 6),
                EntityFactory.CreateGrade(11, 107, 5),
                EntityFactory.CreateGrade(11, 107, 6),
                EntityFactory.CreateGrade(22, 107, 5),
                EntityFactory.CreateGrade(22, 107, 4),
                EntityFactory.CreateGrade(22, 107, 2),
                EntityFactory.CreateGrade(33, 107, 3),
                EntityFactory.CreateGrade(33, 107, 3),
                EntityFactory.CreateGrade(33, 107, 3)
            };

            return this.ObjectsList;
        }
    }
}
