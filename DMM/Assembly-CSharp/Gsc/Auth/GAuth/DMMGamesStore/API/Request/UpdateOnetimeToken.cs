// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.DMMGamesStore.API.Request.UpdateOnetimeToken
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Auth.GAuth.DMMGamesStore.API.Request
{
  [Token(Token = "0x2003684")]
  public class UpdateOnetimeToken : Gsc.Network.Request<UpdateOnetimeToken, UpdateOnetimeTokenResponse>
  {
    [Token(Token = "0x400FFC7")]
    private const string ___path = "{0}/dmm-auth-proxy/{1}/update_onetime_token";

    [Token(Token = "0x17002358")]
    public int ViewerID
    {
      [Token(Token = "0x600F412"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F413"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] set
      {
      }
    }

    [Token(Token = "0x17002359")]
    public string OnetimeToken
    {
      [Token(Token = "0x600F414"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F415"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x600F416")]
    [Address(RVA = "0xB338D0", Offset = "0xB326D0", VA = "0x10B338D0")]
    public UpdateOnetimeToken(int viewerId, string onetimeToken)
    {
    }

    [Token(Token = "0x600F417")]
    [Address(RVA = "0xB33800", Offset = "0xB32600", VA = "0x10B33800", Slot = "29")]
    public override string GetUrl() => (string) null;

    [Token(Token = "0x600F418")]
    [Address(RVA = "0xB337D0", Offset = "0xB325D0", VA = "0x10B337D0", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F419")]
    [Address(RVA = "0xB335C0", Offset = "0xB323C0", VA = "0x10B335C0", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F41A")]
    [Address(RVA = "0xB335F0", Offset = "0xB323F0", VA = "0x10B335F0", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }
  }
}
