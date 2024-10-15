// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.GAuth.API.Request.Register
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Auth.GAuth.GAuth.API.Generic;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Auth.GAuth.GAuth.API.Request
{
  [Token(Token = "0x2003674")]
  public class Register : GAuthRequest<Register, Gsc.Auth.GAuth.GAuth.API.Response.Register>
  {
    [Token(Token = "0x400FF9E")]
    private const string ___path = "/register";

    [Token(Token = "0x17002336")]
    public string Udid
    {
      [Token(Token = "0x600F399"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F39A"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x17002337")]
    public string SecretKey
    {
      [Token(Token = "0x600F39B"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F39C"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x17002338")]
    public string Idfv
    {
      [Token(Token = "0x600F39D"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F39E"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] set
      {
      }
    }

    [Token(Token = "0x17002339")]
    public string Idfa
    {
      [Token(Token = "0x600F39F"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F3A0"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] set
      {
      }
    }

    [Token(Token = "0x600F3A1")]
    [Address(RVA = "0xB2BEE0", Offset = "0xB2ACE0", VA = "0x10B2BEE0")]
    public Register(string secretKey)
    {
    }

    [Token(Token = "0x600F3A2")]
    [Address(RVA = "0xB2BCD0", Offset = "0xB2AAD0", VA = "0x10B2BCD0", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F3A3")]
    [Address(RVA = "0xB2B9E0", Offset = "0xB2A7E0", VA = "0x10B2B9E0", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F3A4")]
    [Address(RVA = "0xB2BA10", Offset = "0xB2A810", VA = "0x10B2BA10", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }
  }
}
