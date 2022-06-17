using Microsoft.AspNetCore.Mvc;
using MockServices.Idp.Entities;
using MockServices.Idp.Manager;

namespace MockServices.Idp.Controllers
{
    public class IdpController : ControllerBase
    {
        private readonly IdpManager _idpManager;

        public IdpController(IdpManager idpManager)
        {
            _idpManager = idpManager;
        }

        [HttpGet("/api/content/34")]
        public IdpModel GetIdpModel()
        {
            var model = _idpManager.GetModel();
            
            return model;
        }

        [HttpPut("/api/change-content")]
        public IActionResult ChangeContent(IdpModel idpModel)
        {
            _idpManager.SetModel(idpModel);
            
            return Ok();
        }
    }
}