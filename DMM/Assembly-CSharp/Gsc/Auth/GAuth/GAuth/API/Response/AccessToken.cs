// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.GAuth.API.Response.AccessToken
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Auth.GAuth.GAuth.API.Generic;
using Gsc.Network;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Auth.GAuth.GAuth.API.Response
{
  [Il2CppDummyDll.Token(Token = "0x2003666")]
  public class AccessToken : GAuthResponse<AccessToken>
  {
    [Il2CppDummyDll.Token(Token = "0x1700231D")]
    public string Token
    {
      [Il2CppDummyDll.Token(Token = "0x600F349"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Il2CppDummyDll.Token(Token = "0x600F34A"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Il2CppDummyDll.Token(Token = "0x1700231E")]
    public int ExpiresIn
    {
      [Il2CppDummyDll.Token(Token = "0x600F34B"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Il2CppDummyDll.Token(Token = "0x600F34C"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Il2CppDummyDll.Token(Token = "0x600F34D")]
    [Address(RVA = "0xB1DF50", Offset = "0xB1CD50", VA = "0x10B1DF50")]
    public AccessToken(WebInternalResponse response)
    {
    }
  }
}
