using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IWordService
    {
        IDataResult<List<Word>> GetAll();

        IDataResult<Word> GetById(int wordId);

        IDataResult<List<Word>> GetByDifficultyLevel(int difficultyLevel);

        IResult Add(Word word);
        IResult Update(Word word);
        IResult Delete(Word word);
    }

}
