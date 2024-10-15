// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.GAuth.API.Response.RegisterEmailAddressAndPassword
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Auth.GAuth.GAuth.API.Generic;
using Gsc.Network;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Auth.GAuth.GAuth.API.Response
{
  [Token(Token = "0x200366E")]
  public class RegisterEmailAddressAndPassword : GAuthResponse<RegisterEmailAddressAndPassword>
  {
    [Token(Token = "0x17002329")]
    public bool IsSuccess
    {
      [Token(Token = "0x600F368"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F369"), Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")] private set
      {
      }
    }

    [Token(Token = "0x600F36A")]
    [Address(RVA = "0xB2B800", Offset = "0xB2A600", VA = "0x10B2B800")]
    public RegisterEmailAddressAndPassword(WebInternalResponse response)
    {
    }
  }
}
