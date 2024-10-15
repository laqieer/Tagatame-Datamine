// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.DMMGamesStore.API.Request.RegisterEmailAddressAndPassword
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
  [Token(Token = "0x2003682")]
  public class RegisterEmailAddressAndPassword : 
    Gsc.Network.Request<RegisterEmailAddressAndPassword, RegisterEmailAddressAndPassword.Response>
  {
    [Token(Token = "0x400FFC3")]
    private const string ___path = "{0}/dmm-auth-proxy/{1}/register";

    [Token(Token = "0x17002352")]
    public int ViewerID
    {
      [Token(Token = "0x600F3FF"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F400"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] set
      {
      }
    }

    [Token(Token = "0x17002353")]
    public string OnetimeToken
    {
      [Token(Token = "0x600F401"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F402"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x17002354")]
    public string EmailAddress
    {
      [Token(Token = "0x600F403"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F404"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] set
      {
      }
    }

    [Token(Token = "0x17002355")]
    public string Password
    {
      [Token(Token = "0x600F405"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F406"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] set
      {
      }
    }

    [Token(Token = "0x17002356")]
    public bool DisableValidationEmail
    {
      [Token(Token = "0x600F407"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F408"), Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", VA = "0x104A9DB0")] set
      {
      }
    }

    [Token(Token = "0x600F409")]
    [Address(RVA = "0xB2B970", Offset = "0xB2A770", VA = "0x10B2B970")]
    public RegisterEmailAddressAndPassword(
      int viewerId,
      string onetimeToken,
      string emailAddress,
      string password)
    {
    }

    [Token(Token = "0x600F40A")]
    [Address(RVA = "0xB2B6B0", Offset = "0xB2A4B0", VA = "0x10B2B6B0", Slot = "29")]
    public override string GetUrl() => (string) null;

    [Token(Token = "0x600F40B")]
    [Address(RVA = "0xB2B680", Offset = "0xB2A480", VA = "0x10B2B680", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F40C")]
    [Address(RVA = "0xB2AF00", Offset = "0xB29D00", VA = "0x10B2AF00", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F40D")]
    [Address(RVA = "0xB2B2B0", Offset = "0xB2A0B0", VA = "0x10B2B2B0", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x600F40E")]
    [Address(RVA = "0xB2AE80", Offset = "0xB29C80", VA = "0x10B2AE80", Slot = "35")]
    public override Type GetErrorResponseType() => (Type) null;

    [Token(Token = "0x2003683")]
    public class Response : GAuthResponse<RegisterEmailAddressAndPassword.Response>
    {
      [Token(Token = "0x17002357")]
      public bool IsSucceeded
      {
        [Token(Token = "0x600F40F"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
        {
          return new bool();
        }
        [Token(Token = "0x600F410"), Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")] private set
        {
        }
      }

      [Token(Token = "0x600F411")]
      [Address(RVA = "0xB2D3A0", Offset = "0xB2C1A0", VA = "0x10B2D3A0")]
      public Response(WebInternalResponse response)
      {
      }
    }
  }
}
