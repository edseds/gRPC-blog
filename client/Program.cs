using Blog;
using Grpc.Core;
using System;
using System.IO;
using System.Threading.Tasks;

namespace client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Channel channel = new Channel("localhost", 50052, ChannelCredentials.Insecure);

            await channel.ConnectAsync().ContinueWith((task) =>
            {
                if (task.Status == TaskStatus.RanToCompletion)
                    Console.WriteLine("The client connected successfully");
            });

            var client = new BlogService.BlogServiceClient(channel);

            //var newBlog = CreateBlog(client);
            //ReadBlog(client);

            //UpdateBlog(client, newBlog);
            //DeleteBlog(client, newBlog);

           // await ListBlog(client);

            channel.ShutdownAsync().Wait();
            Console.ReadKey();
        }
    }
}
