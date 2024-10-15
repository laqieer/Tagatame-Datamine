// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.PAS.WindowsStore.Fulfillment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Purchase.API.PAS.WindowsStore
{
  [Token(Token = "0x2003628")]
  public class Fulfillment : Request<Fulfillment, Gsc.Purchase.API.Response.Fulfillment>
  {
    [Token(Token = "0x400FEC8")]
    private const string ___path = "{0}/pas/windowsstore/{1}/fulfill";

    [Token(Token = "0x1700228E")]
    public string DeviceId
    {
      [Token(Token = "0x600F180"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F181"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x1700228F")]
    public List<Fulfillment.PurchaseData_t> PurchaseDataList
    {
      [Token(Token = "0x600F182"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<Fulfillment.PurchaseData_t>) null;
      }
      [Token(Token = "0x600F183"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x600F184")]
    [Address(RVA = "0xB23760", Offset = "0xB22560", VA = "0x10B23760")]
    public Fulfillment(string deviceId, List<Fulfillment.PurchaseData_t> purchaseDataList)
    {
    }

    [Token(Token = "0x600F185")]
    [Address(RVA = "0xB230F0", Offset = "0xB21EF0", VA = "0x10B230F0", Slot = "29")]
    public override string GetUrl() => (string) null;

    [Token(Token = "0x600F186")]
    [Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F187")]
    [Address(RVA = "0xB21E50", Offset = "0xB20C50", VA = "0x10B21E50", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F188")]
    [Address(RVA = "0xB22D20", Offset = "0xB21B20", VA = "0x10B22D20", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x2003629")]
    public class PurchaseData_t : IRequestObject, IObject
    {
      [Token(Token = "0x17002290")]
      public string Currency
      {
        [Token(Token = "0x600F189"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F18A"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
        {
        }
      }

      [Token(Token = "0x17002291")]
      public float Price
      {
        [Token(Token = "0x600F18B"), Address(RVA = "0x2CD6E0", Offset = "0x2CC4E0", VA = "0x102CD6E0")] get
        {
          return new float();
        }
        [Token(Token = "0x600F18C"), Address(RVA = "0xB24FB0", Offset = "0xB23DB0", VA = "0x10B24FB0")] set
        {
        }
      }

      [Token(Token = "0x17002292")]
      public string ReceiptXml
      {
        [Token(Token = "0x600F18D"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F18E"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
        {
        }
      }

      [Token(Token = "0x17002293")]
      public string TransactionId
      {
        [Token(Token = "0x600F18F"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F190"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] set
        {
        }
      }

      [Token(Token = "0x600F191")]
      [Address(RVA = "0xB26AC0", Offset = "0xB258C0", VA = "0x10B26AC0")]
      public PurchaseData_t(string currency, float price, string receiptXml, string transactionId)
      {
      }

      [Token(Token = "0x600F192")]
      [Address(RVA = "0xB254E0", Offset = "0xB242E0", VA = "0x10B254E0", Slot = "4")]
      public Dictionary<string, object> GetPayload() => (Dictionary<string, object>) null;
    }
  }
}
