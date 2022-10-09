using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.EntityControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurkishEnglishWLevelsController : ControllerBase
    {


        ITurkishEnglishWLevelService _turkishEnglishWLevelService;

        public TurkishEnglishWLevelsController(ITurkishEnglishWLevelService turkishEnglishWLevelService)
        {
            _turkishEnglishWLevelService = turkishEnglishWLevelService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _turkishEnglishWLevelService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }



        //[HttpGet("getbyid")]
        //public IActionResult GetById(int id)
        //{
        //    var result = _turkishEnglishWLevelService.GetById(id);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}




        [HttpPost("add")]
        public IActionResult Add(TurkishEnglishWLevel turkishEnglishWLevel)
        {
            var result = _turkishEnglishWLevelService.Add(turkishEnglishWLevel);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPut("update")]
        public IActionResult Update(TurkishEnglishWLevel turkishEnglishWLevel)
        {
            var result = _turkishEnglishWLevelService.Update(turkishEnglishWLevel);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpDelete("delete")]
        public IActionResult Delete(TurkishEnglishWLevel turkishEnglishWLevel)
        {
            var result = _turkishEnglishWLevelService.Delete(turkishEnglishWLevel);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }





    }
}
