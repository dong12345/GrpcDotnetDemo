using GrpcService.GrpcClient.GrpcClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using MyGrpcService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService.GrpcClient.Controllers
{
    [Route("[Controller]/[action]")]
    public class StudentController:ControllerBase
    {
        public StudentController()
        {

        }

        public StudentListResponse GetAllStudent(Empty empty)
        {
            return MsgServiceClient.GetStudentList(empty);
        }
    }
}
