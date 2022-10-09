using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{

    public interface IEnglishWordService
    {

        IDataResult<List<EnglishWord>> GetAll();

        IDataResult<EnglishWord> GetById(int wordId);

        IResult Add(EnglishWord englishWord);
        IResult Update(EnglishWord englishWord);
        IResult Delete(EnglishWord englishWord);



    }

}
