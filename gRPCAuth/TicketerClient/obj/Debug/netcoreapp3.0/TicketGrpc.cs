// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/ticket.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Ticket {
  public static partial class Ticketer
  {
    static readonly string __ServiceName = "ticket.Ticketer";

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Ticket.AvailableTicketsResponse> __Marshaller_ticket_AvailableTicketsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Ticket.AvailableTicketsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Ticket.BuyTicketsRequest> __Marshaller_ticket_BuyTicketsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Ticket.BuyTicketsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Ticket.BuyTicketsResponse> __Marshaller_ticket_BuyTicketsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Ticket.BuyTicketsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Ticket.AvailableTicketsResponse> __Method_GetAvailableTickets = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Ticket.AvailableTicketsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAvailableTickets",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_ticket_AvailableTicketsResponse);

    static readonly grpc::Method<global::Ticket.BuyTicketsRequest, global::Ticket.BuyTicketsResponse> __Method_BuyTickets = new grpc::Method<global::Ticket.BuyTicketsRequest, global::Ticket.BuyTicketsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "BuyTickets",
        __Marshaller_ticket_BuyTicketsRequest,
        __Marshaller_ticket_BuyTicketsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Ticket.TicketReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Ticketer</summary>
    public partial class TicketerClient : grpc::ClientBase<TicketerClient>
    {
      /// <summary>Creates a new client for Ticketer</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TicketerClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Ticketer that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TicketerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TicketerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TicketerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Get available ticket count
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Ticket.AvailableTicketsResponse GetAvailableTickets(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAvailableTickets(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get available ticket count
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Ticket.AvailableTicketsResponse GetAvailableTickets(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAvailableTickets, null, options, request);
      }
      /// <summary>
      /// Get available ticket count
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Ticket.AvailableTicketsResponse> GetAvailableTicketsAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAvailableTicketsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get available ticket count
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Ticket.AvailableTicketsResponse> GetAvailableTicketsAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAvailableTickets, null, options, request);
      }
      /// <summary>
      /// Buy tickets
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Ticket.BuyTicketsResponse BuyTickets(global::Ticket.BuyTicketsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BuyTickets(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Buy tickets
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Ticket.BuyTicketsResponse BuyTickets(global::Ticket.BuyTicketsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_BuyTickets, null, options, request);
      }
      /// <summary>
      /// Buy tickets
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Ticket.BuyTicketsResponse> BuyTicketsAsync(global::Ticket.BuyTicketsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BuyTicketsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Buy tickets
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Ticket.BuyTicketsResponse> BuyTicketsAsync(global::Ticket.BuyTicketsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_BuyTickets, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TicketerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TicketerClient(configuration);
      }
    }

  }
}
#endregion
