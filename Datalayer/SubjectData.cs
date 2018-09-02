using Datalayer.Interfaces;
using Entities;
using Entities.Factory;
using System.Collections.Generic;

namespace Datalayer
{
    public class SubjectData : IDataComponents<ISubjectClass>
    {
        public List<ISubjectClass> ObjectsList { get; set; }

        public List<ISubjectClass> RetrieveObjects()
        {
            this.ObjectsList = new List<ISubjectClass>()
            {
                EntityFactory.CreateSubjectClass(109, "History"),
                EntityFactory.CreateSubjectClass(108, "Mathematics"),
                EntityFactory.CreateSubjectClass(107, "Mathematics")
            };

            return this.ObjectsList;
        }
    }
}
