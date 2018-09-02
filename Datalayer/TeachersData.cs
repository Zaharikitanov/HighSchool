using Datalayer.Interfaces;
using Entities;
using Entities.Factory;
using System.Collections.Generic;

namespace Datalayer
{
    class TeachersData : IDataComponents<ITeacher>
    {
        public List<ITeacher> ObjectsList { get; set; }

        public List<ITeacher> RetrieveObjects()
        {
            this.ObjectsList = new List<ITeacher>()
            {
                EntityFactory.CreateTeacher(111, "Johnson", 109),
                EntityFactory.CreateTeacher(111, "Vernon", 108),
                EntityFactory.CreateTeacher(111, "Dunn", 107)
            };

            return this.ObjectsList;
        }
    }
}
