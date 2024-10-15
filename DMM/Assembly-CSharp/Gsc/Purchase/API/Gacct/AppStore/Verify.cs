// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.Gacct.AppStore.Verify
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Gsc.Purchase.API.App;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Purchase.API.Gacct.AppStore
{
  [Token(Token = "0x2003648")]
  public class Verify : GenericRequest<Verify, Verify.Response>
  {
    [Token(Token = "0x400FF2C")]
    private const string ___path = "/v2/ios/verify";

    [Token(Token = "0x170022DE")]
    public List<Verify.PurchaseData_t> Receipts
    {
      [Token(Token = "0x600F281"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<Verify.PurchaseData_t>) null;
      }
      [Token(Token = "0x600F282"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x170022DF")]
    public string ReceiptData
    {
      [Token(Token = "0x600F283"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F284"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x600F285")]
    [Address(RVA = "0xB347D0", Offset = "0xB335D0", VA = "0x10B347D0")]
    public Verify(List<Verify.PurchaseData_t> receipts, string receiptData)
    {
    }

    [Token(Token = "0x600F286")]
    [Address(RVA = "0xB34440", Offset = "0xB33240", VA = "0x10B34440", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F287")]
    [Address(RVA = "0xB33980", Offset = "0xB32780", VA = "0x10B33980", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F288")]
    [Address(RVA = "0xB339E0", Offset = "0xB327E0", VA = "0x10B339E0", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x2003649")]
    public class PurchaseData_t : IRequestObject, IObject
    {
      [Token(Token = "0x170022E0")]
      public string Currency
      {
        [Token(Token = "0x600F289"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F28A"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
        {
        }
      }

      [Token(Token = "0x170022E1")]
      public float Price
      {
        [Token(Token = "0x600F28B"), Address(RVA = "0x2CD6E0", Offset = "0x2CC4E0", VA = "0x102CD6E0")] get
        {
          return new float();
        }
        [Token(Token = "0x600F28C"), Address(RVA = "0xB24FB0", Offset = "0xB23DB0", VA = "0x10B24FB0")] set
        {
        }
      }

      [Token(Token = "0x170022E2")]
      public string TransactionId
      {
        [Token(Token = "0x600F28D"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F28E"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
        {
        }
      }

      [Token(Token = "0x600F28F")]
      [Address(RVA = "0xB26A80", Offset = "0xB25880", VA = "0x10B26A80")]
      public PurchaseData_t(string currency, float price, string transactionId)
      {
      }

      [Token(Token = "0x600F290")]
      [Address(RVA = "0xB25DE0", Offset = "0xB24BE0", VA = "0x10B25DE0", Slot = "4")]
      public Dictionary<string, object> GetPayload() => (Dictionary<string, object>) null;
    }

    [Token(Token = "0x200364A")]
    public class Response : GenericResponse<Verify.Response>
    {
      [Token(Token = "0x170022E3")]
      public string[] SuccessTransactionIds
      {
        [Token(Token = "0x600F291"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string[]) null;
        }
        [Token(Token = "0x600F292"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
        {
        }
      }

      [Token(Token = "0x170022E4")]
      public string[] DuplicatedTransactionIds
      {
        [Token(Token = "0x600F293"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (string[]) null;
        }
        [Token(Token = "0x600F294"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
        {
        }
      }

      [Token(Token = "0x170022E5")]
      public int CurrentPaidCoin
      {
        [Token(Token = "0x600F295"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return new int();
        }
        [Token(Token = "0x600F296"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
        {
        }
      }

      [Token(Token = "0x170022E6")]
      public int CurrentFreeCoin
      {
        [Token(Token = "0x600F297"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return new int();
        }
        [Token(Token = "0x600F298"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
        {
        }
      }

      [Token(Token = "0x170022E7")]
      public int CurrentCommonCoin
      {
        [Token(Token = "0x600F299"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
        {
          return new int();
        }
        [Token(Token = "0x600F29A"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] private set
        {
        }
      }

      [Token(Token = "0x170022E8")]
      public int AdditionalPaidCoin
      {
        [Token(Token = "0x600F29B"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
        {
          return new int();
        }
        [Token(Token = "0x600F29C"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] private set
        {
        }
      }

      [Token(Token = "0x170022E9")]
      public int AdditionalFreeCoin
      {
        [Token(Token = "0x600F29D"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
        {
          return new int();
        }
        [Token(Token = "0x600F29E"), Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")] private set
        {
        }
      }

      [Token(Token = "0x600F29F")]
      [Address(RVA = "0xB2CCA0", Offset = "0xB2BAA0", VA = "0x10B2CCA0")]
      public Response(WebInternalResponse response)
      {
      }
    }
  }
}
