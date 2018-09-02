using Datalayer.Interfaces;
using Entities;
using Entities.Factory;
using System.Collections.Generic;

namespace Datalayer
{
    public class StudentsData : IDataComponents<IStudent>
    {
        public List<IStudent> ObjectsList { get; set; }

        public List<IStudent> RetrieveObjects()
        {
            this.ObjectsList = new List<IStudent>()
            {
                EntityFactory.CreateStudent(11, "Peter"),
                EntityFactory.CreateStudent(22, "John"),
                EntityFactory.CreateStudent(33, "Frederic")
            };

            return this.ObjectsList;
        }
    }
}
