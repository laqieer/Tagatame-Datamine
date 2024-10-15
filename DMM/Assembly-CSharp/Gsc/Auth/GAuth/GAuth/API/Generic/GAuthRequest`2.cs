// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.GAuth.API.Generic.GAuthRequest`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Auth.GAuth.GAuth.API.Generic
{
  [Token(Token = "0x2003676")]
  public abstract class GAuthRequest<TRequest, TResponse> : Request<TRequest, TResponse>
    where TRequest : IRequest<TRequest, TResponse>
    where TResponse : IResponse<TResponse>
  {
    [Token(Token = "0x600F3B6")]
    public override WebTaskResult InquireResult(WebTaskResult result, WebInternalResponse response)
    {
      return new WebTaskResult();
    }

    [Token(Token = "0x600F3B7")]
    public override byte[] GetPayload() => (byte[]) null;

    [Token(Token = "0x600F3B8")]
    protected GAuthRequest()
    {
    }
  }
}
