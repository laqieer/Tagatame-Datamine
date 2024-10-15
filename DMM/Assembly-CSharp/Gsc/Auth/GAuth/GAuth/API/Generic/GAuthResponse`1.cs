// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.GAuth.API.Generic.GAuthResponse`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.DOM;
using Gsc.Network;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Auth.GAuth.GAuth.API.Generic
{
  [Token(Token = "0x2003677")]
  public abstract class GAuthResponse<TResponse> : Response<TResponse> where TResponse : IResponse<TResponse>
  {
    [Token(Token = "0x600F3B9")]
    public IDocument Parse(WebInternalResponse response) => (IDocument) null;

    [Token(Token = "0x600F3BA")]
    protected GAuthResponse()
    {
    }
  }
}
