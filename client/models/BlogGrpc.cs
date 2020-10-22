// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: blog.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Blog {
  public static partial class BlogService
  {
    static readonly string __ServiceName = "blog.BlogService";


    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Blog.BlogReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of BlogService</summary>
    [grpc::BindServiceMethod(typeof(BlogService), "BindService")]
    public abstract partial class BlogServiceBase
    {
    }

    /// <summary>Client for BlogService</summary>
    public partial class BlogServiceClient : grpc::ClientBase<BlogServiceClient>
    {
      /// <summary>Creates a new client for BlogService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public BlogServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for BlogService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public BlogServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected BlogServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected BlogServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override BlogServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new BlogServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(BlogServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder().Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, BlogServiceBase serviceImpl)
    {
    }

  }
}
#endregion
