using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract.IDal;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class TurkishWordManager : ITurkishWordService
    {
        ITurkishWordDal _turkishWordDal;

        public TurkishWordManager(ITurkishWordDal turkishWordDal)
        {
            _turkishWordDal = turkishWordDal;
        }

        public IResult Add(TurkishWord turkishWord)
        {
            _turkishWordDal.Add(turkishWord);
            return new SuccessResult();
        }

        public IResult Delete(TurkishWord turkishWord)
        {
            _turkishWordDal.Delete(turkishWord);
            return new SuccessResult();
        }

        public IDataResult<List<TurkishWord>> GetAll()
        {
            return new SuccessDataResult<List<TurkishWord>>(_turkishWordDal.GetAll());
        }

        public IDataResult<TurkishWord> GetById(int turkishWordId)
        {
            return new SuccessDataResult<TurkishWord>(_turkishWordDal.Get(tw => tw.Id == turkishWordId));
        }

        public IResult Update(TurkishWord turkishWord)
        {
            _turkishWordDal.Update(turkishWord);
            return new SuccessResult();
        }
    }





}
