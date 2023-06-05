using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Controller.Models;

namespace Web_Controller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        List<StudentDtO>  studentDtOList = new List<StudentDtO>();
        public HomeController()
        {
            studentDtOList = new List<StudentDtO>();
            for(var i = 0; i < 5; i++)
            {
                studentDtOList.Add(new StudentDtO()
                {
                    Name = "sid" + i,
                    Id = i,
                    Description = "Dev" + i

                });
            }
        }
        [HttpGet]
        public  IEnumerable<StudentDtO> Get()
        {
            return studentDtOList;
        }
        [HttpPost]
        public List<StudentDtO> Post(StudentDtO student)
        {
            studentDtOList.Add(student);
            return studentDtOList;
           
        }
        [HttpPut]
        public List<StudentDtO> Put(StudentDtO student)
        {
            studentDtOList.RemoveAll(c=>c.Id == student.Id);
            studentDtOList.Add(student);
            return studentDtOList;

        }
        [HttpDelete]
        public List<StudentDtO> Delete(int id)
        {
            studentDtOList.RemoveAll(c => c.Id == id);
            return studentDtOList;

        }


    }
}
