using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract.IDal;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class WordManager : IWordService
    {

        IWordDal _wordDal;

        public WordManager(IWordDal wordDal)
        {
            _wordDal = wordDal;
        }



        public IResult Add(Word word)
        {
            _wordDal.Add(word);
            return new SuccessResult();
        }

        public IResult Delete(Word word)
        {
            _wordDal.Delete(word);
            return new SuccessResult();
        }

        public IDataResult<List<Word>> GetAll()
        {
            return new SuccessDataResult<List<Word>>(_wordDal.GetAll());
        }

        public IDataResult<List<Word>> GetByDifficultyLevel(int difficultyLevel)
        {
            return new SuccessDataResult<List<Word>>(_wordDal.GetAll(w=> w.DifficultyLevel == difficultyLevel));
        }

        public IDataResult<Word> GetById(int wordId)
        {
            return new SuccessDataResult<Word>(_wordDal.Get(w => w.Id == wordId));
        }

        public IResult Update(Word word)
        {
            _wordDal.Update(word);
            return new SuccessResult();
        }
    }





}
