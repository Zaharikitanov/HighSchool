using System.Collections.Generic;

namespace Datalayer.Interfaces
{
    public interface IDataComponents<T>
    {
        List<T> ObjectsList { get; set; }

        List<T> RetrieveObjects();
    }
}
