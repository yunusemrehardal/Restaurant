using Restaurant_DataAccessLayer.Abstract;
using Restaurant_DataAccessLayer.Repositories;
using Restaurant_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_DataAccessLayer.EntityFramework
{
    public class EfOurTeamDal : GenericRepository<OurTeam>, IOurTeamDal
    {
    }
}
