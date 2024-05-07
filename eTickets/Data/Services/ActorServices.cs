using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ActorServices : EntityBaseRepository<Actor>, IActorServices
    {
        public ActorServices(AppDbContext context): base(context) { }
    }
}
