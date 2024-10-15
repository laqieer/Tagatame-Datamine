// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.DMMGamesStore.API.Request.AccessToken
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Auth.GAuth.DMMGamesStore.API.Request
{
  [Token(Token = "0x200367F")]
  public class AccessToken : Gsc.Network.Request<AccessToken, Gsc.Auth.GAuth.GAuth.API.Response.AccessToken>
  {
    [Token(Token = "0x400FFB7")]
    private const string ___path = "{0}/dmm-auth-proxy/{1}/get_access_token";

    [Token(Token = "0x1700234B")]
    public int ViewerID
    {
      [Token(Token = "0x600F3E5"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F3E6"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] set
      {
      }
    }

    [Token(Token = "0x1700234C")]
    public string OnetimeToken
    {
      [Token(Token = "0x600F3E7"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F3E8"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x600F3E9")]
    [Address(RVA = "0xB1E130", Offset = "0xB1CF30", VA = "0x10B1E130")]
    public AccessToken(int viewerId, string onetimeToken)
    {
    }

    [Token(Token = "0x600F3EA")]
    [Address(RVA = "0xB1DE80", Offset = "0xB1CC80", VA = "0x10B1DE80", Slot = "29")]
    public override string GetUrl() => (string) null;

    [Token(Token = "0x600F3EB")]
    [Address(RVA = "0xB1DD80", Offset = "0xB1CB80", VA = "0x10B1DD80", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F3EC")]
    [Address(RVA = "0xB1D5C0", Offset = "0xB1C3C0", VA = "0x10B1D5C0", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F3ED")]
    [Address(RVA = "0xB1D7A0", Offset = "0xB1C5A0", VA = "0x10B1D7A0", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }
  }
}
