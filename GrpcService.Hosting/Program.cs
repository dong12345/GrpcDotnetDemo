using GrpcService.Impl;
using System;

namespace GrpcService.Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            RpcConfig.Start();
        }
    }
}
