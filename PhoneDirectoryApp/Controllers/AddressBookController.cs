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
        private readonly IAddressBookService _addressBookService;
        private readonly ILogger<AddressBookController> _logger;
        public AddressBookController(IAddressBookService addressBookService, ILogger<AddressBookController> logger)
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
        public async Task<IActionResult> AddPerson(PersonDto personDto)
        {
            try
            {
                var resultJsonInfo = JsonSerializer.Serialize(personDto);

                _logger.LogInformation($"Added registration information - Json Info : {resultJsonInfo}");

                return Ok(await _addressBookService.AddPerson(personDto));

            }
            catch (Exception exception)
            {
                _logger.LogError($"An error occurred during the request - {exception}. Service info: {MB.GetCurrentMethod()?.ReflectedType?.FullName} ");

                return BadRequest("Something went wrong");
            }
        }
    }
}
