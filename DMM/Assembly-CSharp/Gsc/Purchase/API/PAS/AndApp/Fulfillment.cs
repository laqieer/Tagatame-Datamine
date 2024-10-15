// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.PAS.AndApp.Fulfillment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Purchase.API.PAS.AndApp
{
  [Token(Token = "0x200363E")]
  public class Fulfillment : Request<Fulfillment, Gsc.Purchase.API.Response.Fulfillment>
  {
    [Token(Token = "0x400FF05")]
    private const string ___path = "{0}/pas/andapp/{1}/fulfill";

    [Token(Token = "0x170022BE")]
    public string DeviceId
    {
      [Token(Token = "0x600F223"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F224"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x170022BF")]
    public List<Fulfillment.PurchaseData_t> PurchaseDataList
    {
      [Token(Token = "0x600F225"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<Fulfillment.PurchaseData_t>) null;
      }
      [Token(Token = "0x600F226"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x600F227")]
    [Address(RVA = "0xB237C0", Offset = "0xB225C0", VA = "0x10B237C0")]
    public Fulfillment(string deviceId, List<Fulfillment.PurchaseData_t> purchaseDataList)
    {
    }

    [Token(Token = "0x600F228")]
    [Address(RVA = "0xB23290", Offset = "0xB22090", VA = "0x10B23290", Slot = "29")]
    public override string GetUrl() => (string) null;

    [Token(Token = "0x600F229")]
    [Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F22A")]
    [Address(RVA = "0xB21D90", Offset = "0xB20B90", VA = "0x10B21D90", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F22B")]
    [Address(RVA = "0xB21E90", Offset = "0xB20C90", VA = "0x10B21E90", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x200363F")]
    public class PurchaseData_t : IRequestObject, IObject
    {
      [Token(Token = "0x170022C0")]
      public string ReceiptData
      {
        [Token(Token = "0x600F22C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F22D"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
        {
        }
      }

      [Token(Token = "0x600F22E")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public PurchaseData_t(string receiptData)
      {
      }

      [Token(Token = "0x600F22F")]
      [Address(RVA = "0xB25CB0", Offset = "0xB24AB0", VA = "0x10B25CB0", Slot = "4")]
      public Dictionary<string, object> GetPayload() => (Dictionary<string, object>) null;
    }
  }
}
