using Microsoft.AspNetCore.Mvc;
using Member.Data.Model;
using Member.Data.Repository;
namespace Member.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        public Repository_Member members = new Repository_Member();

        [HttpGet]
        public ActionResult<IEnumerable<Members>> GetAllMembersinList()
        {
            return members.GetAllMembers();
        }

        [HttpGet("{id}")]
        public Members GetMemberbyID(int id)
        {
            return members.GetMemberId(id);
        }

        [HttpPost]
        public void AddNewMember(Members mem)
        {
            members.AddNewMember(mem);
            members.GetAllMembers();
        }

        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        [HttpDelete("{id}")]
        public void DeleteMember(int id)
        {
            members.DeleteMember(id);
        }
    }
}
