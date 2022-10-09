using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract.IDal;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class TurkishEnglishWLevelManager : ITurkishEnglishWLevelService
    {
        ITurkishEnglishWLevelDal _turkishEnglishWLevelDal;

        public TurkishEnglishWLevelManager(ITurkishEnglishWLevelDal turkishEnglishWLevelDal)
        {
            _turkishEnglishWLevelDal = turkishEnglishWLevelDal;
        }

        public IResult Add(TurkishEnglishWLevel turkishEnglishWLevel)
        {
            _turkishEnglishWLevelDal.Add(turkishEnglishWLevel);
            return new SuccessResult();
        }

        public IResult Delete(TurkishEnglishWLevel turkishEnglishWLevel)
        {
            _turkishEnglishWLevelDal.Delete(turkishEnglishWLevel);
            return new SuccessResult();
        }

        public IDataResult<List<TurkishEnglishWLevel>> GetAll()
        {
            return new SuccessDataResult<List<TurkishEnglishWLevel>>(_turkishEnglishWLevelDal.GetAll());
        }

        public IDataResult<TurkishEnglishWLevel> GetById(int wordId,int userId)
        {
            return new SuccessDataResult<TurkishEnglishWLevel>(_turkishEnglishWLevelDal.Get(tew => tew.WordId == wordId && tew.UserId == userId));
        }

        public IResult Update(TurkishEnglishWLevel turkishEnglishWLevel)
        {
            _turkishEnglishWLevelDal.Update(turkishEnglishWLevel);
            return new SuccessResult();
        }
    }





}
