using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{


    public interface ITurkishWordService
    {

        IDataResult<List<TurkishWord>> GetAll();

        IDataResult<TurkishWord> GetById(int turkishWordId);

        IResult Add(TurkishWord turkishWord);
        IResult Update(TurkishWord turkishWord);
        IResult Delete(TurkishWord turkishWord);



    }

}
