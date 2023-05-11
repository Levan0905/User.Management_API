using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using User.Management_Domain.Models;
using User.Management_Domain.Repository;
using Azure.Identity;
using User.Management_Domain.Data;
using Microsoft.EntityFrameworkCore;

namespace User.Management_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationDbContext _context;



        public UserController(IUnitOfWork unitOfWork, ApplicationDbContext context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }


        [HttpPost("/adduser")]
        public IActionResult Add(User.Management_Domain.Entities.User req)
        {
            if (ModelState.IsValid)
            {
                var newUser = _unitOfWork.NewUser.Add(req);
                return Ok();
            }
            return Ok();

        }

        [HttpPost("/updateuser")]
        public IActionResult Update(User.Management_Domain.Entities.User req)
        {
            if (ModelState.IsValid)
            {
                var updateUser = _unitOfWork.NewUser.Update(req);
                return Ok();
            }

            return Ok();

        }

        [HttpGet("api/getuser")]
        public ActionResult GetUserByRole([FromQuery] GetUserByRoleRequest req) 
        {
            var role = req.RoleName;
            //var result = _unitOfWork.NewUser.Get(req);
            return Ok();
              
        }

        [HttpGet("api/getusers")]
        public ActionResult GetUsersByRole([FromQuery] GetUserByRoleRequest req)
        {
            var role = req.RoleName;
            //var result = _unitOfWork.NewUser.Get(req);
            return Ok();

        }

    }
}
