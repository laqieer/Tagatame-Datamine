// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.App.ChargeAge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Purchase.API.App
{
  [Token(Token = "0x200364E")]
  public class ChargeAge : GenericRequest<ChargeAge, Gsc.Purchase.API.Response.ChargeAge>
  {
    [Token(Token = "0x400FF48")]
    private const string ___path = "/age";

    [Token(Token = "0x170022F4")]
    public int BirthDay
    {
      [Token(Token = "0x600F2BD"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F2BE"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] set
      {
      }
    }

    [Token(Token = "0x170022F5")]
    public int BirthYear
    {
      [Token(Token = "0x600F2BF"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F2C0"), Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")] set
      {
      }
    }

    [Token(Token = "0x170022F6")]
    public int BirthMonth
    {
      [Token(Token = "0x600F2C1"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
      [Token(Token = "0x600F2C2"), Address(RVA = "0x311230", Offset = "0x310030", VA = "0x10311230")] set
      {
      }
    }

    [Token(Token = "0x600F2C3")]
    [Address(RVA = "0xB1FE50", Offset = "0xB1EC50", VA = "0x10B1FE50")]
    public ChargeAge(int birthMonth, int birthYear)
    {
    }

    [Token(Token = "0x600F2C4")]
    [Address(RVA = "0xB1FDC0", Offset = "0xB1EBC0", VA = "0x10B1FDC0", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F2C5")]
    [Address(RVA = "0xB1FB50", Offset = "0xB1E950", VA = "0x10B1FB50", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F2C6")]
    [Address(RVA = "0xB1FB80", Offset = "0xB1E980", VA = "0x10B1FB80", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }
  }
}
