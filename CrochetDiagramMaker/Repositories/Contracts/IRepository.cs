using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrochetDiagramMaker.Repositories.Contracts
{
    interface IRepository<T>
    {
        IReadOnlyCollection<T> Models { get; }

        void Add(T model);

        bool Remove(T model);

    }
}
