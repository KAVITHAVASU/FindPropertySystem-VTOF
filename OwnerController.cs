[Route("api/[controller]")]
[ApiController]
public class OwnerController : ControllerBase
{
    private readonly PropertyService _propertyService;

    public OwnerController(PropertyService propertyService)
    {
        _propertyService = propertyService;
    }
    [HttpPost("add")]
    public async Task<IActionResult> AddProperty(PropertyModel property)
    {
        // Implement logic to add property
        return Ok();
    }
    // Other actions: update, view properties, etc.
}
