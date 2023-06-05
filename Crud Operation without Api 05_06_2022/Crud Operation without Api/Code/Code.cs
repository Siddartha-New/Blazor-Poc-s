using Crud_Operation_without_Api.Models;
using Microsoft.AspNetCore.Components;
using Crud_Operation_without_Api.Models;


namespace Crud_Operation_without_Api.Code
{
    public partial class Code : ComponentBase
    {
        StudentDtO students = new StudentDtO();
         List<StudentDtO> studentDtOList = new List<StudentDtO>();
        public IEnumerable<StudentDtO> FetchLookUp(string Name, string Description)
        {
           
            studentDtOList.Add(new StudentDtO()
            {
                Name = students.Name,
                Description = students.Description

            });


            return studentDtOList;



        }
        public IEnumerable<StudentDtO> SaveVt1(StudentDtO student)
        {
            studentDtOList.Add(student);
            return studentDtOList;
        }

        public List<StudentDtO> UpdateVt1(StudentDtO student)
        {
            studentDtOList.RemoveAll(c => c.Name == student.Name);
            studentDtOList.Add(student);
            return studentDtOList;
        }

        public List<StudentDtO> DeleteVt1(StudentDtO student)
        {
            studentDtOList.Remove(student);
            return studentDtOList;

        }
    }
}
