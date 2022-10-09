using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.EntityControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurkishWordsController : ControllerBase
    {


        ITurkishWordService _turkishWordService;

        public TurkishWordsController(ITurkishWordService turkishWordService)
        {
            _turkishWordService = turkishWordService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _turkishWordService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }



        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _turkishWordService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




        [HttpPost("add")]
        public IActionResult Add(TurkishWord turkishWord)
        {
            var result = _turkishWordService.Add(turkishWord);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPut("update")]
        public IActionResult Update(TurkishWord turkishWord)
        {
            var result = _turkishWordService.Update(turkishWord);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpDelete("delete")]
        public IActionResult Delete(TurkishWord turkishWord)
        {
            var result = _turkishWordService.Delete(turkishWord);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




    }
}
