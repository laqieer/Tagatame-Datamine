// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.GAuth.API.Request.AddDeviceWithEmailAddressAndPassword
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
  [Token(Token = "0x2003671")]
  public class AddDeviceWithEmailAddressAndPassword : 
    GAuthRequest<AddDeviceWithEmailAddressAndPassword, Gsc.Auth.GAuth.GAuth.API.Response.AddDeviceWithEmailAddressAndPassword>
  {
    [Token(Token = "0x400FF92")]
    private const string ___path = "/auth/email/device";

    [Token(Token = "0x1700232E")]
    public string EmailAddress
    {
      [Token(Token = "0x600F37A"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F37B"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x1700232F")]
    public string Password
    {
      [Token(Token = "0x600F37C"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F37D"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x17002330")]
    public string Idfv
    {
      [Token(Token = "0x600F37E"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F37F"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] set
      {
      }
    }

    [Token(Token = "0x600F380")]
    [Address(RVA = "0xB1ED90", Offset = "0xB1DB90", VA = "0x10B1ED90")]
    public AddDeviceWithEmailAddressAndPassword(string emailAddress, string password)
    {
    }

    [Token(Token = "0x600F381")]
    [Address(RVA = "0xB1E9C0", Offset = "0xB1D7C0", VA = "0x10B1E9C0", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F382")]
    [Address(RVA = "0xB1E430", Offset = "0xB1D230", VA = "0x10B1E430", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F383")]
    [Address(RVA = "0xB1E460", Offset = "0xB1D260", VA = "0x10B1E460", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x600F384")]
    [Address(RVA = "0xB1E360", Offset = "0xB1D160", VA = "0x10B1E360", Slot = "35")]
    public override Type GetErrorResponseType() => (Type) null;

    [Token(Token = "0x600F385")]
    [Address(RVA = "0xB1EAF0", Offset = "0xB1D8F0", VA = "0x10B1EAF0", Slot = "36")]
    public override WebTaskResult InquireResult(WebTaskResult result, WebInternalResponse response)
    {
      return new WebTaskResult();
    }

    [Token(Token = "0x600F386")]
    [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "33")]
    protected override bool IsParameterUseParam() => new bool();
  }
}
