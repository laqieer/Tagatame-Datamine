// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.Gacct.AUMarket.Verify
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Gsc.Purchase.API.App;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Purchase.API.Gacct.AUMarket
{
  [Token(Token = "0x2003644")]
  public class Verify : GenericRequest<Verify, Verify.Response>
  {
    [Token(Token = "0x400FF1C")]
    private const string ___path = "/aumarket/verify";

    [Token(Token = "0x170022D1")]
    public List<Verify.PurchaseData_t> PurchaseDataList
    {
      [Token(Token = "0x600F25C"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<Verify.PurchaseData_t>) null;
      }
      [Token(Token = "0x600F25D"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x170022D2")]
    public string Signature
    {
      [Token(Token = "0x600F25E"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F25F"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x170022D3")]
    public string ReceiptData
    {
      [Token(Token = "0x600F260"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F261"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] set
      {
      }
    }

    [Token(Token = "0x600F262")]
    [Address(RVA = "0xB34680", Offset = "0xB33480", VA = "0x10B34680")]
    public Verify(
      string signature,
      string receiptData,
      List<Verify.PurchaseData_t> purchaseDataList)
    {
    }

    [Token(Token = "0x600F263")]
    [Address(RVA = "0xB344D0", Offset = "0xB332D0", VA = "0x10B344D0", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F264")]
    [Address(RVA = "0xB33920", Offset = "0xB32720", VA = "0x10B33920", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F265")]
    [Address(RVA = "0xB33ED0", Offset = "0xB32CD0", VA = "0x10B33ED0", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x2003645")]
    public class PurchaseData_t : IRequestObject, IObject
    {
      [Token(Token = "0x170022D4")]
      public string Currency
      {
        [Token(Token = "0x600F266"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F267"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
        {
        }
      }

      [Token(Token = "0x170022D5")]
      public float Price
      {
        [Token(Token = "0x600F268"), Address(RVA = "0x2CD6E0", Offset = "0x2CC4E0", VA = "0x102CD6E0")] get
        {
          return new float();
        }
        [Token(Token = "0x600F269"), Address(RVA = "0xB24FB0", Offset = "0xB23DB0", VA = "0x10B24FB0")] set
        {
        }
      }

      [Token(Token = "0x170022D6")]
      public string PayInfoNo
      {
        [Token(Token = "0x600F26A"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F26B"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
        {
        }
      }

      [Token(Token = "0x600F26C")]
      [Address(RVA = "0xB26A80", Offset = "0xB25880", VA = "0x10B26A80")]
      public PurchaseData_t(string currency, float price, string payInfoNo)
      {
      }

      [Token(Token = "0x600F26D")]
      [Address(RVA = "0xB26810", Offset = "0xB25610", VA = "0x10B26810", Slot = "4")]
      public Dictionary<string, object> GetPayload() => (Dictionary<string, object>) null;
    }

    [Token(Token = "0x2003646")]
    public class Response : GenericResponse<Verify.Response>
    {
      [Token(Token = "0x170022D7")]
      public string[] SuccessTransactionIds
      {
        [Token(Token = "0x600F26E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string[]) null;
        }
        [Token(Token = "0x600F26F"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
        {
        }
      }

      [Token(Token = "0x170022D8")]
      public string[] DuplicatedTransactionIds
      {
        [Token(Token = "0x600F270"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (string[]) null;
        }
        [Token(Token = "0x600F271"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
        {
        }
      }

      [Token(Token = "0x170022D9")]
      public int CurrentPaidCoin
      {
        [Token(Token = "0x600F272"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return new int();
        }
        [Token(Token = "0x600F273"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
        {
        }
      }

      [Token(Token = "0x170022DA")]
      public int CurrentFreeCoin
      {
        [Token(Token = "0x600F274"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return new int();
        }
        [Token(Token = "0x600F275"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
        {
        }
      }

      [Token(Token = "0x170022DB")]
      public int CurrentCommonCoin
      {
        [Token(Token = "0x600F276"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
        {
          return new int();
        }
        [Token(Token = "0x600F277"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] private set
        {
        }
      }

      [Token(Token = "0x170022DC")]
      public int AdditionalPaidCoin
      {
        [Token(Token = "0x600F278"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
        {
          return new int();
        }
        [Token(Token = "0x600F279"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] private set
        {
        }
      }

      [Token(Token = "0x170022DD")]
      public int AdditionalFreeCoin
      {
        [Token(Token = "0x600F27A"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
        {
          return new int();
        }
        [Token(Token = "0x600F27B"), Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")] private set
        {
        }
      }

      [Token(Token = "0x600F27C")]
      [Address(RVA = "0xB2D510", Offset = "0xB2C310", VA = "0x10B2D510")]
      public Response(WebInternalResponse response)
      {
      }
    }
  }
}
