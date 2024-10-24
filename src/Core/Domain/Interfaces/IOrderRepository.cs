using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataBase.Repositories
{
    public interface IOrderRepository
    {
        Task Create(Order request, CancellationToken cancellationToken);
    }
}
