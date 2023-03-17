using Microsoft.AspNetCore.Mvc;

namespace DtMoneyBackend.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TransactionController : ControllerBase
{
    [HttpGet]
    public IActionResult List()
    {
        return Ok();
    }
    [HttpPost]
    public IActionResult Add()
    {
        return Ok();
    }
    [HttpPut("{transactionId}")]
    public IActionResult Edit(int transactionId)
    {
        return Ok();
    }
    [HttpDelete("{transactionId}")]
    public IActionResult Delete(int transactionId)
    {
        return Ok();
    }
    [HttpGet("{transactionId}")]
    public IActionResult Find(int transactionId)
    {
        return Ok();
    }
    [HttpDelete("MoveToTrash/{transactionId}")]
    public IActionResult MoveToTrash(int transactionId)
    {
        return Ok();
    }
}