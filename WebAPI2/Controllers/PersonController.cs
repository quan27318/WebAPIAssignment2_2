using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using WebAPI2.Models;
using WebAPI2.Services;
namespace WebAPI2.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
       private readonly ILogger<PersonController> _logger;
       private IPerson _person;
       public PersonController(ILogger<PersonController> logger, IPerson person){
           _logger = logger;
           _person = person;
       }
       [HttpGet]
       public List<PersonModel> GetAll(){
           return _person.GetAll();
       }
       [HttpPost]
        public HttpStatusCode Create(PersonModel per){
            _person.Create(per);
            return HttpStatusCode.OK;
        }
       [HttpPut]
       public HttpStatusCode Update(PersonModel per){
           _person.Update(per);
           return HttpStatusCode.OK;
       }
       [HttpDelete]
       public HttpStatusCode Detele(int id){
           _person.Delete(id);
           return HttpStatusCode.OK;
       }
       [HttpGet("FullName")]
       public List<PersonModel> GetFullName(string firstname,string lastname,string gender,string birthplace){
          
           return  _person.GetFullname(firstname, lastname,gender,birthplace);
       }
      
    }
    
}