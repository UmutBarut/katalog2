using Katalog.Business.Abstracts;
using Katalog.Core.Utilities.Results;
using Katalog.Dataaccess.Abstracts;
using Katalog.Entity;
using System.Linq.Expressions;


namespace Katalog.Business.Concrete
{
    public class MarkaManager : IMarkaService
    {
        private readonly IMarkaDal _markaDal;

        public MarkaManager(IMarkaDal markaDal)
        {
            _markaDal = markaDal;
        }

        public IResult Add(Marka marka)
        {
            _markaDal.InsertAsync(marka);
            return new SuccessResult();
        }

        public IResult Delete(Marka marka)
        {
            _markaDal.Delete(marka);
            return new SuccessResult();
        }

        public IDataResult<Marka> GetById(Expression<Func<Marka, bool>> expression)
        {
            return new SuccessDataResult<Marka>(_markaDal.GetAll(expression).First());
        }

       public IDataResult<List<Marka>> MarkaList(Expression<Func<Marka, bool>> expression = null)
        {
            if(expression == null)
            {
            return new SuccessDataResult<List<Marka>>(_markaDal.GetAll());
            }
            return new SuccessDataResult<List<Marka>>(_markaDal.GetAll(expression));
        }

        public IResult Update(Marka marka)
        {
            _markaDal.Update(marka);
            return new SuccessResult();
        }
    }
}