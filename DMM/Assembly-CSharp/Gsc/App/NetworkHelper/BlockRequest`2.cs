﻿// Decompiled with JetBrains decompiler
// Type: Gsc.App.NetworkHelper.BlockRequest`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.App.NetworkHelper
{
  [Token(Token = "0x200354E")]
  public class BlockRequest<TRequest, TResponse>
    where TRequest : IRequest<TRequest, TResponse>
    where TResponse : IResponse<TResponse>
  {
    [Token(Token = "0x400FCD0")]
    [FieldOffset(Offset = "0x0")]
    protected WebInternalTask<TRequest, TResponse> task;

    [Token(Token = "0x600EC45")]
    public BlockRequest(WebInternalTask<TRequest, TResponse> task)
    {
    }

    [Token(Token = "0x600EC46")]
    private void Wait()
    {
    }

    [Token(Token = "0x600EC47")]
    public WebTaskResult GetResult() => new WebTaskResult();

    [Token(Token = "0x600EC48")]
    public TResponse GetResponse() => (TResponse) null;

    [Token(Token = "0x600EC49")]
    public IErrorResponse GetErrorResponse() => (IErrorResponse) null;
  }
}