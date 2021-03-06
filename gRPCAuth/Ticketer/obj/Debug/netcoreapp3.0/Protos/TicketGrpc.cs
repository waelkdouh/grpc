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

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    static readonly grpc::Marshaller<global::Ticket.AvailableTicketsResponse> __Marshaller_ticket_AvailableTicketsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Ticket.AvailableTicketsResponse.Parser));
    static readonly grpc::Marshaller<global::Ticket.BuyTicketsRequest> __Marshaller_ticket_BuyTicketsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Ticket.BuyTicketsRequest.Parser));
    static readonly grpc::Marshaller<global::Ticket.BuyTicketsResponse> __Marshaller_ticket_BuyTicketsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Ticket.BuyTicketsResponse.Parser));

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

    /// <summary>Base class for server-side implementations of Ticketer</summary>
    [grpc::BindServiceMethod(typeof(Ticketer), "BindService")]
    public abstract partial class TicketerBase
    {
      /// <summary>
      /// Get available ticket count
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Ticket.AvailableTicketsResponse> GetAvailableTickets(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Buy tickets
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Ticket.BuyTicketsResponse> BuyTickets(global::Ticket.BuyTicketsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(TicketerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAvailableTickets, serviceImpl.GetAvailableTickets)
          .AddMethod(__Method_BuyTickets, serviceImpl.BuyTickets).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, TicketerBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAvailableTickets, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Ticket.AvailableTicketsResponse>(serviceImpl.GetAvailableTickets));
      serviceBinder.AddMethod(__Method_BuyTickets, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Ticket.BuyTicketsRequest, global::Ticket.BuyTicketsResponse>(serviceImpl.BuyTickets));
    }

  }
}
#endregion
