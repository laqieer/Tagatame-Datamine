// Decompiled with JetBrains decompiler
// Type: Gsc.Network.Request`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Parser;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x2003562")]
  public abstract class Request<TRequest, TResponse> : 
    ApiObject,
    IRequest<TRequest, TResponse>,
    IRequest
    where TRequest : IRequest<TRequest, TResponse>
    where TResponse : IResponse<TResponse>
  {
    [Token(Token = "0x400FCE5")]
    [FieldOffset(Offset = "0x0")]
    private readonly string ___request_id;
    [Token(Token = "0x400FCE6")]
    [FieldOffset(Offset = "0x0")]
    protected IWebTask<TRequest, TResponse> ___task;

    [Token(Token = "0x170021DC")]
    public CustomHeaders CustomHeaders
    {
      [Token(Token = "0x600EC93")] get => (CustomHeaders) null;
      [Token(Token = "0x600EC94")] private set
      {
      }
    }

    [Token(Token = "0x170021DD")]
    public byte[] UnencryptedPayload
    {
      [Token(Token = "0x600EC95")] get => (byte[]) null;
      [Token(Token = "0x600EC96")] set
      {
      }
    }

    [Token(Token = "0x170021DE")]
    public bool IsUseEncryption
    {
      [Token(Token = "0x600EC97")] get => new bool();
    }

    [Token(Token = "0x170021DF")]
    public bool isDone
    {
      [Token(Token = "0x600EC98")] get => new bool();
    }

    [Token(Token = "0x600EC99")]
    public Request()
    {
    }

    [Token(Token = "0x600EC9A")]
    public string GetRequestID() => (string) null;

    [Token(Token = "0x600EC9B")]
    public virtual string GetHost() => (string) null;

    [Token(Token = "0x600EC9C")]
    public virtual string GetUrl() => (string) null;

    [Token(Token = "0x600EC9D")]
    public abstract string GetPath();

    [Token(Token = "0x600EC9E")]
    public abstract string GetMethod();

    [Token(Token = "0x600EC9F")]
    protected virtual Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x600ECA0")]
    protected virtual bool IsParameterUseParam() => new bool();

    [Token(Token = "0x600ECA1")]
    public virtual byte[] GetPayload() => (byte[]) null;

    [Token(Token = "0x600ECA2")]
    public virtual Type GetErrorResponseType() => (Type) null;

    [Token(Token = "0x600ECA3")]
    public virtual WebTaskResult InquireResult(WebTaskResult result, WebInternalResponse response)
    {
      return new WebTaskResult();
    }

    [Token(Token = "0x600ECA4")]
    private IWebTask Gsc\u002ENetwork\u002EIRequest\u002ECast() => (IWebTask) null;

    [Token(Token = "0x600ECA5")]
    private IWebTask Gsc\u002ENetwork\u002EIRequest\u002ESend() => (IWebTask) null;

    [Token(Token = "0x600ECA6")]
    public void Retry()
    {
    }

    [Token(Token = "0x600ECA7")]
    public WebTask<TRequest, TResponse> Cast() => (WebTask<TRequest, TResponse>) null;

    [Token(Token = "0x600ECA8")]
    public WebTask<TRequest, TResponse> Send() => (WebTask<TRequest, TResponse>) null;

    [Token(Token = "0x600ECA9")]
    public WebTask<TRequest, TResponse> SerialSend() => (WebTask<TRequest, TResponse>) null;

    [Token(Token = "0x600ECAA")]
    public WebTask<TRequest, TResponse> ToWebTask(WebTaskAttribute attributes)
    {
      return (WebTask<TRequest, TResponse>) null;
    }

    [Token(Token = "0x600ECAB")]
    public TResponse GetResponse() => (TResponse) null;

    [Token(Token = "0x600ECAC")]
    public IErrorResponse GetError() => (IErrorResponse) null;

    [Token(Token = "0x600ECAD")]
    public WebTaskResult GetResult() => new WebTaskResult();
  }
}
