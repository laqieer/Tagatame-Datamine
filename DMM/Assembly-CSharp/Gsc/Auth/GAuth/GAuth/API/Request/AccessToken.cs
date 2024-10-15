// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.GAuth.API.Request.AccessToken
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Auth.GAuth.GAuth.API.Generic;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Auth.GAuth.GAuth.API.Request
{
  [Token(Token = "0x200366F")]
  public class AccessToken : GAuthRequest<AccessToken, Gsc.Auth.GAuth.GAuth.API.Response.AccessToken>
  {
    [Token(Token = "0x400FF8D")]
    private const string ___path = "/accesstoken";

    [Token(Token = "0x1700232A")]
    public string SecretKey
    {
      [Token(Token = "0x600F36B"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F36C"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x1700232B")]
    public string Idfv
    {
      [Token(Token = "0x600F36D"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F36E"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x1700232C")]
    public string Idfa
    {
      [Token(Token = "0x600F36F"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F370"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] set
      {
      }
    }

    [Token(Token = "0x1700232D")]
    public string DeviceId
    {
      [Token(Token = "0x600F371"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F372"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] set
      {
      }
    }

    [Token(Token = "0x600F373")]
    [Address(RVA = "0xB1E1D0", Offset = "0xB1CFD0", VA = "0x10B1E1D0")]
    public AccessToken(string secretKey, string deviceId)
    {
    }

    [Token(Token = "0x600F374")]
    [Address(RVA = "0xB1DCF0", Offset = "0xB1CAF0", VA = "0x10B1DCF0", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F375")]
    [Address(RVA = "0xB1D560", Offset = "0xB1C360", VA = "0x10B1D560", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F376")]
    [Address(RVA = "0xB1DA00", Offset = "0xB1C800", VA = "0x10B1DA00", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }
  }
}
