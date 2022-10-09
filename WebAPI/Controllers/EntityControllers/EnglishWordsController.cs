using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.EntityControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnglishWordsController : ControllerBase
    {


        IEnglishWordService _englishWordService;

        public EnglishWordsController(IEnglishWordService englishWordService)
        {
            _englishWordService = englishWordService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _englishWordService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }



        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _englishWordService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




        [HttpPost("add")]
        public IActionResult Add(EnglishWord englishWord)
        {
            var result = _englishWordService.Add(englishWord);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPut("update")]
        public IActionResult Update(EnglishWord englishWord)
        {
            var result = _englishWordService.Update(englishWord);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpDelete("delete")]
        public IActionResult Delete(EnglishWord englishWord)
        {
            var result = _englishWordService.Delete(englishWord);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




    }
}
