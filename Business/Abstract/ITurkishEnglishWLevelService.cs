using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ITurkishEnglishWLevelService
    {

        IDataResult<List<TurkishEnglishWLevel>> GetAll();

        IDataResult<TurkishEnglishWLevel> GetById(int wordId, int userId);

        IResult Add(TurkishEnglishWLevel turkishEnglishWLevel);
        IResult Update(TurkishEnglishWLevel turkishEnglishWLevel);
        IResult Delete(TurkishEnglishWLevel turkishEnglishWLevel);


    }

}
