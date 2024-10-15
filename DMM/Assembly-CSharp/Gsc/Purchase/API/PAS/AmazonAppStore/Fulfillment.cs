// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.PAS.AmazonAppStore.Fulfillment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Purchase.API.PAS.AmazonAppStore
{
  [Token(Token = "0x2003640")]
  public class Fulfillment : Request<Fulfillment, Gsc.Purchase.API.Response.Fulfillment>
  {
    [Token(Token = "0x400FF0A")]
    private const string ___path = "{0}/pas/amazonappstore/{1}/fulfill";

    [Token(Token = "0x170022C1")]
    public string DeviceId
    {
      [Token(Token = "0x600F230"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F231"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x170022C2")]
    public string UserId
    {
      [Token(Token = "0x600F232"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F233"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x170022C3")]
    public List<Fulfillment.PurchaseData_t> PurchaseDataList
    {
      [Token(Token = "0x600F234"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (List<Fulfillment.PurchaseData_t>) null;
      }
      [Token(Token = "0x600F235"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] set
      {
      }
    }

    [Token(Token = "0x600F236")]
    [Address(RVA = "0xB23560", Offset = "0xB22360", VA = "0x10B23560")]
    public Fulfillment(
      string deviceId,
      string userId,
      List<Fulfillment.PurchaseData_t> purchaseDataList)
    {
    }

    [Token(Token = "0x600F237")]
    [Address(RVA = "0xB23360", Offset = "0xB22160", VA = "0x10B23360", Slot = "29")]
    public override string GetUrl() => (string) null;

    [Token(Token = "0x600F238")]
    [Address(RVA = "0xB22F20", Offset = "0xB21D20", VA = "0x10B22F20", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F239")]
    [Address(RVA = "0xB21D60", Offset = "0xB20B60", VA = "0x10B21D60", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F23A")]
    [Address(RVA = "0xB22A40", Offset = "0xB21840", VA = "0x10B22A40", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x2003641")]
    public class PurchaseData_t : IRequestObject, IObject
    {
      [Token(Token = "0x170022C4")]
      public string Currency
      {
        [Token(Token = "0x600F23B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F23C"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
        {
        }
      }

      [Token(Token = "0x170022C5")]
      public float Price
      {
        [Token(Token = "0x600F23D"), Address(RVA = "0x2CD6E0", Offset = "0x2CC4E0", VA = "0x102CD6E0")] get
        {
          return new float();
        }
        [Token(Token = "0x600F23E"), Address(RVA = "0xB24FB0", Offset = "0xB23DB0", VA = "0x10B24FB0")] set
        {
        }
      }

      [Token(Token = "0x170022C6")]
      public string ReceiptId
      {
        [Token(Token = "0x600F23F"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F240"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
        {
        }
      }

      [Token(Token = "0x600F241")]
      [Address(RVA = "0xB26A80", Offset = "0xB25880", VA = "0x10B26A80")]
      public PurchaseData_t(string currency, float price, string receiptId)
      {
      }

      [Token(Token = "0x600F242")]
      [Address(RVA = "0xB25A40", Offset = "0xB24840", VA = "0x10B25A40", Slot = "4")]
      public Dictionary<string, object> GetPayload() => (Dictionary<string, object>) null;
    }
  }
}
