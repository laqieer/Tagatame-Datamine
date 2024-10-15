// Decompiled with JetBrains decompiler
// Type: Gsc.Network.WebCallbackBuilder`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x2003576")]
  public class WebCallbackBuilder<TRequest, TResponse>
    where TRequest : IRequest<TRequest, TResponse>
    where TResponse : IResponse<TResponse>
  {
    [Token(Token = "0x600ECFC")]
    public static WebCallbackBuilder<TRequest, TResponse>.WebCallback Build(
      VoidCallback<TResponse> callback)
    {
      return (WebCallbackBuilder<TRequest, TResponse>.WebCallback) null;
    }

    [Token(Token = "0x600ECFD")]
    public static WebCallbackBuilder<TRequest, TResponse>.WebCallback Build(
      VoidCallback<TRequest, TResponse> callback)
    {
      return (WebCallbackBuilder<TRequest, TResponse>.WebCallback) null;
    }

    [Token(Token = "0x600ECFE")]
    public static WebCallbackBuilder<TRequest, TResponse>.WebCallback Build(
      VoidCallbackWithError<TResponse> callback)
    {
      return (WebCallbackBuilder<TRequest, TResponse>.WebCallback) null;
    }

    [Token(Token = "0x600ECFF")]
    public static WebCallbackBuilder<TRequest, TResponse>.WebCallback Build(
      VoidCallbackWithError<TRequest, TResponse> callback)
    {
      return (WebCallbackBuilder<TRequest, TResponse>.WebCallback) null;
    }

    [Token(Token = "0x600ED00")]
    public static WebCallbackBuilder<TRequest, TResponse>.WebCallback Build(
      YieldCallback<TResponse> callback)
    {
      return (WebCallbackBuilder<TRequest, TResponse>.WebCallback) null;
    }

    [Token(Token = "0x600ED01")]
    public static WebCallbackBuilder<TRequest, TResponse>.WebCallback Build(
      YieldCallback<TRequest, TResponse> callback)
    {
      return (WebCallbackBuilder<TRequest, TResponse>.WebCallback) null;
    }

    [Token(Token = "0x600ED02")]
    public static WebCallbackBuilder<TRequest, TResponse>.WebCallback Build(
      YieldCallbackWithError<TResponse> callback)
    {
      return (WebCallbackBuilder<TRequest, TResponse>.WebCallback) null;
    }

    [Token(Token = "0x600ED03")]
    public static WebCallbackBuilder<TRequest, TResponse>.WebCallback Build(
      YieldCallbackWithError<TRequest, TResponse> callback)
    {
      return (WebCallbackBuilder<TRequest, TResponse>.WebCallback) null;
    }

    [Token(Token = "0x600ED04")]
    public static WebCallbackBuilder<TRequest, TResponse>.WebCallback Build<TResult>(
      Action<TResult> send,
      ReturnCallback<TResponse, TResult> callback)
    {
      return (WebCallbackBuilder<TRequest, TResponse>.WebCallback) null;
    }

    [Token(Token = "0x600ED05")]
    public static WebCallbackBuilder<TRequest, TResponse>.WebCallback Build<TResult>(
      Action<TResult> send,
      ReturnCallback<TRequest, TResponse, TResult> callback)
    {
      return (WebCallbackBuilder<TRequest, TResponse>.WebCallback) null;
    }

    [Token(Token = "0x600ED06")]
    public static WebCallbackBuilder<TRequest, TResponse>.WebCallback Build<TResult>(
      Action<TResult> send,
      ReturnCallbackWithError<TResponse, TResult> callback)
    {
      return (WebCallbackBuilder<TRequest, TResponse>.WebCallback) null;
    }

    [Token(Token = "0x600ED07")]
    public static WebCallbackBuilder<TRequest, TResponse>.WebCallback Build<TResult>(
      Action<TResult> send,
      ReturnCallbackWithError<TRequest, TResponse, TResult> callback)
    {
      return (WebCallbackBuilder<TRequest, TResponse>.WebCallback) null;
    }

    [Token(Token = "0x600ED08")]
    public WebCallbackBuilder()
    {
    }

    [Token(Token = "0x2003577")]
    public delegate void Callback(WebTask<TRequest, TResponse> callback)
      where TRequest : IRequest<TRequest, TResponse>
      where TResponse : IResponse<TResponse>;

    [Token(Token = "0x2003578")]
    public class WebCallback : IWebCallback<TRequest, TResponse>
    {
      [Token(Token = "0x400FCF3")]
      [FieldOffset(Offset = "0x0")]
      public bool isBehaviour;
      [Token(Token = "0x400FCF4")]
      [FieldOffset(Offset = "0x0")]
      public Behaviour behaviour;
      [Token(Token = "0x400FCF5")]
      [FieldOffset(Offset = "0x0")]
      public WebTaskResult acceptResults;
      [Token(Token = "0x400FCF6")]
      [FieldOffset(Offset = "0x0")]
      public WebCallbackBuilder<TRequest, TResponse>.Callback invoke;

      [Token(Token = "0x600ED0D")]
      public static WebCallbackBuilder<TRequest, TResponse>.WebCallback Create(
        WebTaskResult acceptResults,
        Behaviour behaviour,
        WebCallbackBuilder<TRequest, TResponse>.Callback invoke)
      {
        return (WebCallbackBuilder<TRequest, TResponse>.WebCallback) null;
      }

      [Token(Token = "0x600ED0E")]
      public bool OnCallback(WebTask<TRequest, TResponse> task) => new bool();

      [Token(Token = "0x600ED0F")]
      public WebCallback()
      {
      }
    }
  }
}
