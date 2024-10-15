// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.GAuth.API.Request.RegisterEmailAddressAndPassword
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Auth.GAuth.GAuth.API.Generic;
using Gsc.Network;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Auth.GAuth.GAuth.API.Request
{
  [Token(Token = "0x2003675")]
  public class RegisterEmailAddressAndPassword : 
    GAuthRequest<RegisterEmailAddressAndPassword, Gsc.Auth.GAuth.GAuth.API.Response.RegisterEmailAddressAndPassword>
  {
    [Token(Token = "0x400FFA4")]
    private const string ___path = "/auth/email/register";

    [Token(Token = "0x1700233A")]
    public string DeviceId
    {
      [Token(Token = "0x600F3A5"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F3A6"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x1700233B")]
    public string SecretKey
    {
      [Token(Token = "0x600F3A7"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F3A8"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x1700233C")]
    public string EmailAddress
    {
      [Token(Token = "0x600F3A9"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F3AA"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] set
      {
      }
    }

    [Token(Token = "0x1700233D")]
    public string Password
    {
      [Token(Token = "0x600F3AB"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F3AC"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] set
      {
      }
    }

    [Token(Token = "0x1700233E")]
    public bool DisableValidationEmail
    {
      [Token(Token = "0x600F3AD"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F3AE"), Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", VA = "0x104A9DB0")] set
      {
      }
    }

    [Token(Token = "0x600F3AF")]
    [Address(RVA = "0xB2B780", Offset = "0xB2A580", VA = "0x10B2B780")]
    public RegisterEmailAddressAndPassword(
      string deviceId,
      string secretKey,
      string emailAddress,
      string password)
    {
    }

    [Token(Token = "0x600F3B0")]
    [Address(RVA = "0xB2B650", Offset = "0xB2A450", VA = "0x10B2B650", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F3B1")]
    [Address(RVA = "0xB2AED0", Offset = "0xB29CD0", VA = "0x10B2AED0", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F3B2")]
    [Address(RVA = "0xB2AF30", Offset = "0xB29D30", VA = "0x10B2AF30", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x600F3B3")]
    [Address(RVA = "0xB2AE30", Offset = "0xB29C30", VA = "0x10B2AE30", Slot = "35")]
    public override Type GetErrorResponseType() => (Type) null;

    [Token(Token = "0x600F3B4")]
    [Address(RVA = "0xB1EAF0", Offset = "0xB1D8F0", VA = "0x10B1EAF0", Slot = "36")]
    public override WebTaskResult InquireResult(WebTaskResult result, WebInternalResponse response)
    {
      return new WebTaskResult();
    }

    [Token(Token = "0x600F3B5")]
    [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "33")]
    protected override bool IsParameterUseParam() => new bool();
  }
}
