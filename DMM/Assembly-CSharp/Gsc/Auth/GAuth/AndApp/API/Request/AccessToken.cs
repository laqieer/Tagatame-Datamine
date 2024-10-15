// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.AndApp.API.Request.AccessToken
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Auth.GAuth.GAuth.API.Generic;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Auth.GAuth.AndApp.API.Request
{
  [Token(Token = "0x2003686")]
  public class AccessToken : GAuthRequest<AccessToken, Gsc.Auth.GAuth.GAuth.API.Response.AccessToken>
  {
    [Token(Token = "0x400FFC9")]
    private const string ___path = "{0}/authp-andapp/{1}/get_access_token";

    [Token(Token = "0x1700235A")]
    public string IDToken
    {
      [Token(Token = "0x600F41C"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F41D"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x600F41E")]
    [Address(RVA = "0xB1E180", Offset = "0xB1CF80", VA = "0x10B1E180")]
    public AccessToken(string idToken)
    {
    }

    [Token(Token = "0x600F41F")]
    [Address(RVA = "0xB1DDB0", Offset = "0xB1CBB0", VA = "0x10B1DDB0", Slot = "29")]
    public override string GetUrl() => (string) null;

    [Token(Token = "0x600F420")]
    [Address(RVA = "0xB1DCC0", Offset = "0xB1CAC0", VA = "0x10B1DCC0", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F421")]
    [Address(RVA = "0xB1D590", Offset = "0xB1C390", VA = "0x10B1D590", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F422")]
    [Address(RVA = "0xB1D5F0", Offset = "0xB1C3F0", VA = "0x10B1D5F0", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }
  }
}
