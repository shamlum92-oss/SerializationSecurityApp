using Microsoft.AspNetCore.Mvc;
using SerializationSecurityApp.Models;

namespace SerializationSecurityApp.Controllers
{
    [ApiController]
    [Route("api/secure-transaction")]
    public class SecureTransactionController : ControllerBase
    {
        [HttpPost("process")]
        public IActionResult ProcessTransaction([FromBody] SecureTransactionRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new 
                { 
                    Error = "Validation failed", 
                    Details = ModelState.Values
                        .SelectMany(v => v.Errors)
                        .Select(e => e.ErrorMessage) 
                });
            }

            return Ok(new
            {
                Status = "Success",
                Message = "Payload successfully validated and processed securely.",
                TransactionId = request.TransactionId,
                VerifiedAmount = request.Amount
            });
        }
    }
}