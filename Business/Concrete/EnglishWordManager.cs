using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract.IDal;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class EnglishWordManager : IEnglishWordService
    {

        IEnglishWordDal _englishWordDal;

        public EnglishWordManager(IEnglishWordDal englishWordDal)
        {
            _englishWordDal = englishWordDal;
        }

        public IResult Add(EnglishWord englishWord)
        {
           _englishWordDal.Add(englishWord);
            return new SuccessResult();
        }

        public IResult Delete(EnglishWord englishWord)
        {
            _englishWordDal.Delete(englishWord);
            return new SuccessResult();
        }

        public IDataResult<List<EnglishWord>> GetAll()
        {
            return new SuccessDataResult<List<EnglishWord>>(_englishWordDal.GetAll());
        }

        public IDataResult<EnglishWord> GetById(int wordId)
        {
            return new SuccessDataResult<EnglishWord>(_englishWordDal.Get(ew => ew.Id == wordId));
        }

        public IResult Update(EnglishWord englishWord)
        {
            _englishWordDal.Update(englishWord);
            return new SuccessResult();
        }
    }





}
