using Grpc.Core;
using MyGrpcService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static MyGrpcService.SchoolService;

namespace GrpcService.Impl
{
    public class MsgServiceImpl:SchoolService.SchoolServiceBase
    {
        public MsgServiceImpl()
        {

        }

        public override async  Task<StudentListResponse> getAllStudent(Empty request, ServerCallContext context)
        {
            StudentListResponse list = new StudentListResponse();
            var stu = new StudentResponse()
            {
                Id = 1,
                Name = "史育东",
                Email = "1031342303@qq.com"
            };

            list.ListData.Add(stu);
            return list;
        }
    }
}
