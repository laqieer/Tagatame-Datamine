// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.GAuth.API.Request.Passcode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Auth.GAuth.GAuth.API.Generic;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Auth.GAuth.GAuth.API.Request
{
  [Token(Token = "0x2003673")]
  public class Passcode : GAuthRequest<Passcode, Gsc.Auth.GAuth.GAuth.API.Response.Passcode>
  {
    [Token(Token = "0x400FF99")]
    private const string ___path = "/passcode";

    [Token(Token = "0x17002334")]
    public string SecretKey
    {
      [Token(Token = "0x600F391"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F392"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x17002335")]
    public string DeviceId
    {
      [Token(Token = "0x600F393"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F394"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x600F395")]
    [Address(RVA = "0xB24D60", Offset = "0xB23B60", VA = "0x10B24D60")]
    public Passcode(string secretKey, string deviceId)
    {
    }

    [Token(Token = "0x600F396")]
    [Address(RVA = "0xB24AF0", Offset = "0xB238F0", VA = "0x10B24AF0", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F397")]
    [Address(RVA = "0xB24910", Offset = "0xB23710", VA = "0x10B24910", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F398")]
    [Address(RVA = "0xB24940", Offset = "0xB23740", VA = "0x10B24940", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }
  }
}
