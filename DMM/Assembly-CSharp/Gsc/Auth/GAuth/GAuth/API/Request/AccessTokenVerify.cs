// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.GAuth.API.Request.AccessTokenVerify
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Auth.GAuth.GAuth.API.Generic;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Auth.GAuth.GAuth.API.Request
{
  [Token(Token = "0x2003670")]
  public class AccessTokenVerify : GAuthRequest<AccessTokenVerify, Gsc.Auth.GAuth.GAuth.API.Response.AccessTokenVerify>
  {
    [Token(Token = "0x400FF8E")]
    private const string ___path = "/v2/accesstoken/verify";

    [Token(Token = "0x600F377")]
    [Address(RVA = "0xB1D4E0", Offset = "0xB1C2E0", VA = "0x10B1D4E0")]
    public AccessTokenVerify()
    {
    }

    [Token(Token = "0x600F378")]
    [Address(RVA = "0xB1D450", Offset = "0xB1C250", VA = "0x10B1D450", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F379")]
    [Address(RVA = "0xB1D420", Offset = "0xB1C220", VA = "0x10B1D420", Slot = "31")]
    public override string GetMethod() => (string) null;
  }
}
