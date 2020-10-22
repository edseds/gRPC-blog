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

            //var response = client.CreateBlog(new CreateBlogRequest()
            //{
            //    Blog = new Blog.Blog()
            //    {
            //        AuthorId = "Edgars",
            //        Title = "New Blog",
            //        Content = "Hello, this is my new blog"
            //    }
            //});

            //Console.WriteLine("The blog {0} was created", response.Blog.Id);
            try
            {
                var response = client.ReadBlog(new ReadBlogRequest()
                {
                    BlogId = ""
                });

                Console.WriteLine(response.Blog.ToString());

            }
            catch (RpcException e)
            {
                Console.WriteLine(e.Status.Detail);
            }

            channel.ShutdownAsync().Wait();
            Console.ReadKey();
        }
    }
}
