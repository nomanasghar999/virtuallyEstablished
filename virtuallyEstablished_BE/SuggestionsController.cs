using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace virtuallyEstablished_BE
{
    [Route("api")]
    [ApiController]
    public class SuggestionsController : ControllerBase
    {
        [HttpPost]
        public IActionResult index([FromBody] FormData formData)
        {
            try
            {
                return Ok(new { Message = "Data saved successfully!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Error saving data.", Details = ex.Message });
            }
        }
    }
}

// Model for form data
public class FormData
{
    public string? suggestionText { get; set; }
}
