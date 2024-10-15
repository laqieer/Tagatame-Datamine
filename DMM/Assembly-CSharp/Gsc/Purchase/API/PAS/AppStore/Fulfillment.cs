// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.PAS.AppStore.Fulfillment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Purchase.API.PAS.AppStore
{
  [Token(Token = "0x200363C")]
  public class Fulfillment : Request<Fulfillment, Gsc.Purchase.API.Response.Fulfillment>
  {
    [Token(Token = "0x400FEFF")]
    private const string ___path = "{0}/pas/appstore/{1}/fulfill";

    [Token(Token = "0x170022B8")]
    public string DeviceId
    {
      [Token(Token = "0x600F210"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F211"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x170022B9")]
    public List<Fulfillment.PurchaseData_t> PurchaseDataList
    {
      [Token(Token = "0x600F212"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<Fulfillment.PurchaseData_t>) null;
      }
      [Token(Token = "0x600F213"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x170022BA")]
    public string ReceiptData
    {
      [Token(Token = "0x600F214"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F215"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] set
      {
      }
    }

    [Token(Token = "0x600F216")]
    [Address(RVA = "0xB23500", Offset = "0xB22300", VA = "0x10B23500")]
    public Fulfillment(List<Fulfillment.PurchaseData_t> purchaseDataList, string receiptData)
    {
    }

    [Token(Token = "0x600F217")]
    [Address(RVA = "0xB22F50", Offset = "0xB21D50", VA = "0x10B22F50", Slot = "29")]
    public override string GetUrl() => (string) null;

    [Token(Token = "0x600F218")]
    [Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F219")]
    [Address(RVA = "0xB21E20", Offset = "0xB20C20", VA = "0x10B21E20", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F21A")]
    [Address(RVA = "0xB22060", Offset = "0xB20E60", VA = "0x10B22060", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x200363D")]
    public class PurchaseData_t : IRequestObject, IObject
    {
      [Token(Token = "0x170022BB")]
      public string Currency
      {
        [Token(Token = "0x600F21B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F21C"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
        {
        }
      }

      [Token(Token = "0x170022BC")]
      public float Price
      {
        [Token(Token = "0x600F21D"), Address(RVA = "0x2CD6E0", Offset = "0x2CC4E0", VA = "0x102CD6E0")] get
        {
          return new float();
        }
        [Token(Token = "0x600F21E"), Address(RVA = "0xB24FB0", Offset = "0xB23DB0", VA = "0x10B24FB0")] set
        {
        }
      }

      [Token(Token = "0x170022BD")]
      public string TransactionId
      {
        [Token(Token = "0x600F21F"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F220"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
        {
        }
      }

      [Token(Token = "0x600F221")]
      [Address(RVA = "0xB26A80", Offset = "0xB25880", VA = "0x10B26A80")]
      public PurchaseData_t(string currency, float price, string transactionId)
      {
      }

      [Token(Token = "0x600F222")]
      [Address(RVA = "0xB257D0", Offset = "0xB245D0", VA = "0x10B257D0", Slot = "4")]
      public Dictionary<string, object> GetPayload() => (Dictionary<string, object>) null;
    }
  }
}
