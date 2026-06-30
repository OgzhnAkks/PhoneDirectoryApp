using Microsoft.AspNetCore.Mvc;
using PhoneDirectory.Business.Services.Services.Abstract;
using PhoneDirectory.Entity.Services.Models.Dto;
using PhoneDirectoryApp.Helper;
using System;
using System.Text.Json;
using MB = System.Reflection.MethodBase;

namespace PhoneDirectoryApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressBookController : ControllerBase
    {
        private readonly IPersonService _addressBookService;
        private readonly ILogger<AddressBookController> _logger;
        public AddressBookController(IPersonService addressBookService, ILogger<AddressBookController> logger)
        {
            _addressBookService = addressBookService;
            _logger = logger;
        }

        [HttpGet]
        [Route("ContactAll")]
        public async Task<IActionResult> GetAll(PaginationFilter paginationFilter)
        {
            try
            {
                var paginatedPersonDtosResult = PagingFunction.GetPage(await _addressBookService.GetPersons(), paginationFilter.PageSize, paginationFilter.PageNumber);
                return Ok(paginatedPersonDtosResult);
            }
            catch (Exception exception)
            {
                _logger.LogError($"An error occurred during the request - {exception}. Service info: {MB.GetCurrentMethod()?.Name} ");

                return BadRequest("Something went wrong");
            }
        }

        [HttpPost]
        [Route("CreateContact")]
        public async Task<IActionResult> AddPerson(CreatePersonDto personDto)
        {
            try
            {
                _logger.LogInformation("AddPerson request received for {Name}", personDto.Name);

                var result = await _addressBookService.AddPerson(personDto);

                return Ok(result);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex,
                    "Error in AddPerson. Method: {Method}",
                     nameof(AddPerson));

                return StatusCode(500, "Internal server error");
            }
        }
    }
}
