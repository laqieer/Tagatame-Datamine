// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.PAS.AUMarket.Fulfillment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Purchase.API.PAS.AUMarket
{
  [Token(Token = "0x200363A")]
  public class Fulfillment : Request<Fulfillment, Gsc.Purchase.API.Response.Fulfillment>
  {
    [Token(Token = "0x400FEF8")]
    private const string ___path = "{0}/pas/aumarket/{1}/fulfill";

    [Token(Token = "0x170022B1")]
    public string DeviceId
    {
      [Token(Token = "0x600F1FB"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F1FC"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x170022B2")]
    public List<Fulfillment.PurchaseData_t> PurchaseDataList
    {
      [Token(Token = "0x600F1FD"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<Fulfillment.PurchaseData_t>) null;
      }
      [Token(Token = "0x600F1FE"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x170022B3")]
    public string Signature
    {
      [Token(Token = "0x600F1FF"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F200"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] set
      {
      }
    }

    [Token(Token = "0x170022B4")]
    public string ReceiptData
    {
      [Token(Token = "0x600F201"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F202"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] set
      {
      }
    }

    [Token(Token = "0x600F203")]
    [Address(RVA = "0xB238E0", Offset = "0xB226E0", VA = "0x10B238E0")]
    public Fulfillment(
      string deviceId,
      string signature,
      string receiptData,
      List<Fulfillment.PurchaseData_t> purchaseDataList)
    {
    }

    [Token(Token = "0x600F204")]
    [Address(RVA = "0xB23020", Offset = "0xB21E20", VA = "0x10B23020", Slot = "29")]
    public override string GetUrl() => (string) null;

    [Token(Token = "0x600F205")]
    [Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F206")]
    [Address(RVA = "0xB21D30", Offset = "0xB20B30", VA = "0x10B21D30", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F207")]
    [Address(RVA = "0xB22510", Offset = "0xB21310", VA = "0x10B22510", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x200363B")]
    public class PurchaseData_t : IRequestObject, IObject
    {
      [Token(Token = "0x170022B5")]
      public string Currency
      {
        [Token(Token = "0x600F208"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F209"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
        {
        }
      }

      [Token(Token = "0x170022B6")]
      public float Price
      {
        [Token(Token = "0x600F20A"), Address(RVA = "0x2CD6E0", Offset = "0x2CC4E0", VA = "0x102CD6E0")] get
        {
          return new float();
        }
        [Token(Token = "0x600F20B"), Address(RVA = "0xB24FB0", Offset = "0xB23DB0", VA = "0x10B24FB0")] set
        {
        }
      }

      [Token(Token = "0x170022B7")]
      public string PayInfoNo
      {
        [Token(Token = "0x600F20C"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F20D"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
        {
        }
      }

      [Token(Token = "0x600F20E")]
      [Address(RVA = "0xB26A80", Offset = "0xB25880", VA = "0x10B26A80")]
      public PurchaseData_t(string currency, float price, string payInfoNo)
      {
      }

      [Token(Token = "0x600F20F")]
      [Address(RVA = "0xB26050", Offset = "0xB24E50", VA = "0x10B26050", Slot = "4")]
      public Dictionary<string, object> GetPayload() => (Dictionary<string, object>) null;
    }
  }
}
