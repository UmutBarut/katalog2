using Katalog.Core.Dataaccess.EntityFramework;
using Katalog.Dataaccess.Abstracts;
using Katalog.Dataaccess.Concrete.Contexts;
using Katalog.Entity;

namespace Katalog.Dataaccess.Concrete
{
    public class TipDal : EfEntityRepositoryBase<Tip, ApplicationDbContext>, ITipDal
    {
         
    }
}