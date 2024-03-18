[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly PropertyService _propertyService;

    public CustomerController(PropertyService propertyService)
    {
        _propertyService = propertyService;
    }
    [HttpGet("search")]
    public async Task<IActionResult> SearchProperties(SearchCriteria criteria)
    {
        // Implement logic to search properties
        return Ok();
    }
    //Other actions: view property details, contact owner, etc.}
