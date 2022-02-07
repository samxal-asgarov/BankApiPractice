using AutoMapper;
using BankUserApi.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
namespace BankUserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        private UserDbContext Db;
        protected UserDbContext app => Db ??= HttpContext.RequestServices.GetService<UserDbContext>();

        private IMapper Mapper;
        protected IMapper mapper => Mapper ??= HttpContext.RequestServices.GetService<IMapper>();
    }
}
