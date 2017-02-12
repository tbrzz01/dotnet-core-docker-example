
using System;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.SwaggerGen.Annotations;

[Route("api/[controller]")]
public class ValuesController : Controller
{

    // Get ValueModel
    [Produces(typeof(ValueModel))]
    [SwaggerOperation(OperationId="Get")]
    [HttpGet("{id}")]
    public IActionResult Get(string id) 
    {
        if(string.IsNullOrEmpty(id))
            return NotFound();

        if(string.Equals("1", id))
            return NotFound();

        return Ok(new ValueModel()
        {
            Id = Guid.NewGuid(),
            Name = "Value Name",
            Description = "Value Description"
        });
    }
}