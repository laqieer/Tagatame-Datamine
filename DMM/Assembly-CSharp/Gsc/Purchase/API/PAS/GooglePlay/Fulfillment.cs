// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.PAS.GooglePlay.Fulfillment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Purchase.API.PAS.GooglePlay
{
  [Token(Token = "0x200362A")]
  public class Fulfillment : Request<Fulfillment, Gsc.Purchase.API.Response.Fulfillment>
  {
    [Token(Token = "0x400FECF")]
    private const string ___path = "{0}/pas/googleplay/{1}/fulfill";

    [Token(Token = "0x17002294")]
    public string DeviceId
    {
      [Token(Token = "0x600F193"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F194"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x17002295")]
    public List<Fulfillment.PurchaseData_t> PurchaseDataList
    {
      [Token(Token = "0x600F195"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<Fulfillment.PurchaseData_t>) null;
      }
      [Token(Token = "0x600F196"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x600F197")]
    [Address(RVA = "0xB23820", Offset = "0xB22620", VA = "0x10B23820")]
    public Fulfillment(string deviceId, List<Fulfillment.PurchaseData_t> purchaseDataList)
    {
    }

    [Token(Token = "0x600F198")]
    [Address(RVA = "0xB23430", Offset = "0xB22230", VA = "0x10B23430", Slot = "29")]
    public override string GetUrl() => (string) null;

    [Token(Token = "0x600F199")]
    [Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F19A")]
    [Address(RVA = "0xB21DF0", Offset = "0xB20BF0", VA = "0x10B21DF0", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F19B")]
    [Address(RVA = "0xB22870", Offset = "0xB21670", VA = "0x10B22870", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x200362B")]
    public class PurchaseData_t : IRequestObject, IObject
    {
      [Token(Token = "0x17002296")]
      public string Currency
      {
        [Token(Token = "0x600F19C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F19D"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
        {
        }
      }

      [Token(Token = "0x17002297")]
      public float Price
      {
        [Token(Token = "0x600F19E"), Address(RVA = "0x2CD6E0", Offset = "0x2CC4E0", VA = "0x102CD6E0")] get
        {
          return new float();
        }
        [Token(Token = "0x600F19F"), Address(RVA = "0xB24FB0", Offset = "0xB23DB0", VA = "0x10B24FB0")] set
        {
        }
      }

      [Token(Token = "0x17002298")]
      public string Signature
      {
        [Token(Token = "0x600F1A0"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F1A1"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
        {
        }
      }

      [Token(Token = "0x17002299")]
      public string ReceiptData
      {
        [Token(Token = "0x600F1A2"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F1A3"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] set
        {
        }
      }

      [Token(Token = "0x600F1A4")]
      [Address(RVA = "0xB26AC0", Offset = "0xB258C0", VA = "0x10B26AC0")]
      public PurchaseData_t(string currency, float price, string signature, string receiptData)
      {
      }

      [Token(Token = "0x600F1A5")]
      [Address(RVA = "0xB26520", Offset = "0xB25320", VA = "0x10B26520", Slot = "4")]
      public Dictionary<string, object> GetPayload() => (Dictionary<string, object>) null;
    }
  }
}
