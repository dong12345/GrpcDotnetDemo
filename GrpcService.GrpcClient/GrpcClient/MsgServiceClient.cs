using Grpc.Core;
using MyGrpcService;

namespace GrpcService.GrpcClient.GrpcClient
{
    public static class MsgServiceClient
    {
        private static Channel _channel;
        private static SchoolService.SchoolServiceClient _client;

        static MsgServiceClient()
        {
            _channel = new Channel("127.0.0.1:40001", ChannelCredentials.Insecure);
            _client = new SchoolService.SchoolServiceClient(_channel);
        }

        public static StudentListResponse GetStudentList(Empty empty)
        {
            var list= _client.getAllStudent(empty);
            return list;
        }
    }
}
