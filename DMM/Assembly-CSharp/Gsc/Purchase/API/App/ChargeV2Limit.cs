// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.App.ChargeV2Limit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Purchase.API.App
{
  [Token(Token = "0x200364F")]
  public class ChargeV2Limit : GenericRequest<ChargeV2Limit, Gsc.Purchase.API.Response.ChargeV2Limit>
  {
    [Token(Token = "0x400FF4B")]
    private const string ___path = "/v2/limit";

    [Token(Token = "0x170022F7")]
    public List<float> Prices
    {
      [Token(Token = "0x600F2C7"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<float>) null;
      }
      [Token(Token = "0x600F2C8"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x170022F8")]
    public string Currency
    {
      [Token(Token = "0x600F2C9"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F2CA"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x600F2CB")]
    [Address(RVA = "0xB201E0", Offset = "0xB1EFE0", VA = "0x10B201E0")]
    public ChargeV2Limit(List<float> prices, string currency)
    {
    }

    [Token(Token = "0x600F2CC")]
    [Address(RVA = "0xB20040", Offset = "0xB1EE40", VA = "0x10B20040", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F2CD")]
    [Address(RVA = "0xB20010", Offset = "0xB1EE10", VA = "0x10B20010", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F2CE")]
    [Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }
  }
}
