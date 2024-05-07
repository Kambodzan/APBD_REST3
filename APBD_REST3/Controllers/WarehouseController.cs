using System.Data.SqlClient;
using APBD_REST3.Models_DTOs;
using APBD_REST3.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace APBD_REST3.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WarehouseController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public WarehouseController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpPost]
    public IActionResult ChangeOrderStatus(StatusChangeModel statusChangeModel)
    {
        using SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("Default"));
        connection.Open();

        SqlCommand selectQuery = new SqlCommand("select count(*) as Checkvalue from Product where IdProduct = 5;");

        var reader = selectQuery.ExecuteReader();

        int checksum = reader.GetOrdinal("Checkvalue");

        if (reader.GetInt32(checksum) == 0)
        {
            return NotFound("Product with this id was not found");
        }

        return Ok(reader);
    }
    
}

