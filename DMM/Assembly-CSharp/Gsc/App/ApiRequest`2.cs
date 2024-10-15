// Decompiled with JetBrains decompiler
// Type: Gsc.App.ApiRequest`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.App
{
  [Token(Token = "0x2003541")]
  public abstract class ApiRequest<TRequest, TResponse> : Request<TRequest, TResponse>
    where TRequest : IRequest<TRequest, TResponse>
    where TResponse : IResponse<TResponse>
  {
    [Token(Token = "0x600EBE3")]
    protected ApiRequest()
    {
    }
  }
}
