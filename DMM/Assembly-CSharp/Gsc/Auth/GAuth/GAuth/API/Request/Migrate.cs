// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.GAuth.API.Request.Migrate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Auth.GAuth.GAuth.API.Generic;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Auth.GAuth.GAuth.API.Request
{
  [Token(Token = "0x2003672")]
  public class Migrate : GAuthRequest<Migrate, Gsc.Auth.GAuth.GAuth.API.Response.Migrate>
  {
    [Token(Token = "0x400FF96")]
    private const string ___path = "/migrate";

    [Token(Token = "0x17002331")]
    public string Passcode
    {
      [Token(Token = "0x600F387"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F388"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x17002332")]
    public string SecretKey
    {
      [Token(Token = "0x600F389"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F38A"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x17002333")]
    public string DeviceId
    {
      [Token(Token = "0x600F38B"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F38C"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] set
      {
      }
    }

    [Token(Token = "0x600F38D")]
    [Address(RVA = "0xB246A0", Offset = "0xB234A0", VA = "0x10B246A0")]
    public Migrate(string passcode, string secretKey, string deviceId)
    {
    }

    [Token(Token = "0x600F38E")]
    [Address(RVA = "0xB24610", Offset = "0xB23410", VA = "0x10B24610", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F38F")]
    [Address(RVA = "0xB243A0", Offset = "0xB231A0", VA = "0x10B243A0", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F390")]
    [Address(RVA = "0xB243D0", Offset = "0xB231D0", VA = "0x10B243D0", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }
  }
}
