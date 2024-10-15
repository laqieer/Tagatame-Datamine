// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.DMMGamesStore.API.Request.AddDeviceWithEmailAddressAndPassword
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Auth.GAuth.GAuth.API.Generic;
using Gsc.Network;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Auth.GAuth.DMMGamesStore.API.Request
{
  [Token(Token = "0x2003680")]
  public class AddDeviceWithEmailAddressAndPassword : 
    Gsc.Network.Request<AddDeviceWithEmailAddressAndPassword, AddDeviceWithEmailAddressAndPassword.Response>
  {
    [Token(Token = "0x400FFBC")]
    private const string ___path = "{0}/dmm-auth-proxy/{1}/add_device";

    [Token(Token = "0x1700234D")]
    public int ViewerID
    {
      [Token(Token = "0x600F3EE"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F3EF"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] set
      {
      }
    }

    [Token(Token = "0x1700234E")]
    public string OnetimeToken
    {
      [Token(Token = "0x600F3F0"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F3F1"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x1700234F")]
    public string EmailAddress
    {
      [Token(Token = "0x600F3F2"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F3F3"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] set
      {
      }
    }

    [Token(Token = "0x17002350")]
    public string Password
    {
      [Token(Token = "0x600F3F4"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F3F5"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] set
      {
      }
    }

    [Token(Token = "0x600F3F6")]
    [Address(RVA = "0xB1ED20", Offset = "0xB1DB20", VA = "0x10B1ED20")]
    public AddDeviceWithEmailAddressAndPassword(
      int viewerId,
      string onetimeToken,
      string emailAddress,
      string password)
    {
    }

    [Token(Token = "0x600F3F7")]
    [Address(RVA = "0xB1EA20", Offset = "0xB1D820", VA = "0x10B1EA20", Slot = "29")]
    public override string GetUrl() => (string) null;

    [Token(Token = "0x600F3F8")]
    [Address(RVA = "0xB1E9F0", Offset = "0xB1D7F0", VA = "0x10B1E9F0", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F3F9")]
    [Address(RVA = "0xB1E400", Offset = "0xB1D200", VA = "0x10B1E400", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F3FA")]
    [Address(RVA = "0xB1E6A0", Offset = "0xB1D4A0", VA = "0x10B1E6A0", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x600F3FB")]
    [Address(RVA = "0xB1E3B0", Offset = "0xB1D1B0", VA = "0x10B1E3B0", Slot = "35")]
    public override Type GetErrorResponseType() => (Type) null;

    [Token(Token = "0x2003681")]
    public class Response : GAuthResponse<AddDeviceWithEmailAddressAndPassword.Response>
    {
      [Token(Token = "0x17002351")]
      public bool IsSucceeded
      {
        [Token(Token = "0x600F3FC"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
        {
          return new bool();
        }
        [Token(Token = "0x600F3FD"), Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")] private set
        {
        }
      }

      [Token(Token = "0x600F3FE")]
      [Address(RVA = "0xB2CB30", Offset = "0xB2B930", VA = "0x10B2CB30")]
      public Response(WebInternalResponse response)
      {
      }
    }
  }
}
