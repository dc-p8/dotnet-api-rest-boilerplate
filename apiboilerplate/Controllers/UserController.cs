using apiboilerplate.DAL;
using apiboilerplate.DAL.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiboilerplate.Controllers
{
    [RoutePrefix("users")]
    public class UserController : ApiController
    {
        IRepo _repo;
        ILogger _logger;
        public UserController(IRepo repo, ILogger logger)
        {
            _repo = repo;
            _logger = logger;
        }

        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetName(int id)
        {
            _logger.Info("requestign name for id " + id);
            User user = _repo.GetOne(id);
            if (user != null)
                return Ok(user.Name);
            return NotFound();
        }
    }
}
