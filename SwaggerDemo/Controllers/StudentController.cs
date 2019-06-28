using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwaggerDemo.Model;

namespace SwaggerDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        List<Student> stuList = new List<Student>() {
                new Student{ Id = 1, Name = "张三", Age = 18 },
                new Student{ Id = 2, Name = "李四", Age = 19 },
                new Student{ Id = 3, Name = "王五", Age = 20 }};

        /// <summary>
        /// 学生信息列表
        /// </summary>
        /// <remarks>
        /// 这个api是用来获取学生详细信息列表的接口
        /// </remarks>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<Student>> GetList()
        {
            return stuList;
        }

        /// <summary>
        /// 学生信息
        /// </summary>
        /// <remarks>
        /// 这个api是用来获取单个学生信息的接口
        /// </remarks>
        /// <param name="Id">学生Id</param>
        /// <returns></returns>
        [HttpGet("{Id}")]
        public ActionResult<Student> GetStudent(int Id)
        {
            return stuList.Where(s => s.Id == Id).SingleOrDefault();
        }
    }
}