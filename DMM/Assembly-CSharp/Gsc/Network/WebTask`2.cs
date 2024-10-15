// Decompiled with JetBrains decompiler
// Type: Gsc.Network.WebTask`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Tasks;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Reflection;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x2003599")]
  public class WebTask<TRequest, TResponse> : 
    IWebTask<TRequest, TResponse>,
    IWebTask<TResponse>,
    IWebTask,
    IWebTaskBase,
    ITask,
    IEnumerator
    where TRequest : IRequest<TRequest, TResponse>
    where TResponse : IResponse<TResponse>
  {
    [Token(Token = "0x400FD6C")]
    [FieldOffset(Offset = "0x0")]
    private WebInternalTask<TRequest, TResponse> internalTask;
    [Token(Token = "0x400FD6D")]
    [FieldOffset(Offset = "0x0")]
    private WebTaskAttribute attributes;

    [Token(Token = "0x170021FB")]
    public IWebCallback<TRequest, TResponse> callback
    {
      [Token(Token = "0x600ED93")] get => (IWebCallback<TRequest, TResponse>) null;
      [Token(Token = "0x600ED94")] private set
      {
      }
    }

    [Token(Token = "0x170021FC")]
    public WebTaskResult acceptResults
    {
      [Token(Token = "0x600ED95")] get => new WebTaskResult();
      [Token(Token = "0x600ED96")] private set
      {
      }
    }

    [Token(Token = "0x170021FD")]
    public TRequest Request
    {
      [Token(Token = "0x600ED97")] get => (TRequest) null;
      [Token(Token = "0x600ED98")] private set
      {
      }
    }

    [Token(Token = "0x170021FE")]
    public TResponse Response
    {
      [Token(Token = "0x600ED99")] get => (TResponse) null;
      [Token(Token = "0x600ED9A")] private set
      {
      }
    }

    [Token(Token = "0x170021FF")]
    public IErrorResponse ErrorResponse
    {
      [Token(Token = "0x600ED9B")] get => (IErrorResponse) null;
      [Token(Token = "0x600ED9C")] private set
      {
      }
    }

    [Token(Token = "0x17002200")]
    public byte[] error
    {
      [Token(Token = "0x600ED9D")] get => (byte[]) null;
      [Token(Token = "0x600ED9E")] private set
      {
      }
    }

    [Token(Token = "0x17002201")]
    public bool isBreak
    {
      [Token(Token = "0x600ED9F")] get => new bool();
      [Token(Token = "0x600EDA0")] private set
      {
      }
    }

    [Token(Token = "0x17002202")]
    public bool isDone
    {
      [Token(Token = "0x600EDA1")] get => new bool();
      [Token(Token = "0x600EDA2")] private set
      {
      }
    }

    [Token(Token = "0x17002203")]
    public WebTaskResult Result
    {
      [Token(Token = "0x600EDA3")] get => new WebTaskResult();
      [Token(Token = "0x600EDA4")] private set
      {
      }
    }

    [Token(Token = "0x17002204")]
    public bool handled
    {
      [Token(Token = "0x600EDA5")] get => new bool();
      [Token(Token = "0x600EDA6")] private set
      {
      }
    }

    [Token(Token = "0x600EDA7")]
    public static WebTask<TRequest, TResponse> Send(
      IRequest<TRequest, TResponse> request,
      WebTaskAttribute attributes)
    {
      return (WebTask<TRequest, TResponse>) null;
    }

    [Token(Token = "0x600EDA8")]
    private WebTask(WebTaskAttribute attributes)
    {
    }

    [Token(Token = "0x600EDA9")]
    public Type GetRequestType() => (Type) null;

    [Token(Token = "0x600EDAA")]
    public bool IsAcceptResult(WebTaskResult result) => new bool();

    [Token(Token = "0x600EDAB")]
    public bool HasAttributes(WebTaskAttribute attributes) => new bool();

    [Token(Token = "0x600EDAC")]
    public void Retry()
    {
    }

    [Token(Token = "0x600EDAD")]
    public void Break()
    {
    }

    [Token(Token = "0x600EDAE")]
    public WebTask<TRequest, TResponse> SetAcceptResults(WebTaskResult handleResults)
    {
      return (WebTask<TRequest, TResponse>) null;
    }

    [Token(Token = "0x600EDAF")]
    public WebInternalTask GetInternalTask() => (WebInternalTask) null;

    [Token(Token = "0x17002205")]
    public object Current
    {
      [Token(Token = "0x600EDB0")] get => (object) null;
    }

    [Token(Token = "0x600EDB1")]
    public void Reset()
    {
    }

    [Token(Token = "0x600EDB2")]
    public bool MoveNext() => new bool();

    [Token(Token = "0x600EDB3")]
    public WebTask<TRequest, TResponse> OnResponse(VoidCallback<TResponse> callback)
    {
      return (WebTask<TRequest, TResponse>) null;
    }

    [Token(Token = "0x600EDB4")]
    public WebTask<TRequest, TResponse> OnResponse(VoidCallbackWithError<TResponse> callback)
    {
      return (WebTask<TRequest, TResponse>) null;
    }

    [Token(Token = "0x600EDB5")]
    public WebTask<TRequest, TResponse> OnCoroutineResponse(YieldCallback<TResponse> callback)
    {
      return (WebTask<TRequest, TResponse>) null;
    }

    [Token(Token = "0x600EDB6")]
    public WebTask<TRequest, TResponse> OnCoroutineResponse(
      YieldCallbackWithError<TResponse> callback)
    {
      return (WebTask<TRequest, TResponse>) null;
    }

    [Token(Token = "0x600EDB7")]
    public IEnumerator Run() => (IEnumerator) null;

    [Token(Token = "0x600EDB8")]
    public void OnStart()
    {
    }

    [Token(Token = "0x600EDB9")]
    public void OnFinish()
    {
    }

    [Token(Token = "0x600EDBA")]
    private static WebTaskResult GetTaskResult(WebInternalResponse response) => new WebTaskResult();

    [Token(Token = "0x600EDBB")]
    public static WebTaskResult TryGetResponse(
      TRequest request,
      WebInternalResponse internalResponse,
      out TResponse response,
      out IErrorResponse error)
    {
      return new WebTaskResult();
    }

    [Token(Token = "0x200359A")]
    public class ParseError : Exception
    {
      [Token(Token = "0x600EDBC")]
      public ParseError(byte[] payload, TargetInvocationException e)
      {
      }
    }
  }
}
