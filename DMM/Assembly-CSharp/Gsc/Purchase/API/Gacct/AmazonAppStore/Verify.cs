// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.Gacct.AmazonAppStore.Verify
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Gsc.Purchase.API.App;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Purchase.API.Gacct.AmazonAppStore
{
  [Token(Token = "0x200364C")]
  public class Verify : GenericRequest<Verify, Verify.Response>
  {
    [Token(Token = "0x400FF3E")]
    private const string ___path = "/amazon/verify";

    [Token(Token = "0x170022EA")]
    public string UserId
    {
      [Token(Token = "0x600F2A4"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F2A5"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x170022EB")]
    public string Currency
    {
      [Token(Token = "0x600F2A6"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F2A7"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x170022EC")]
    public float Price
    {
      [Token(Token = "0x600F2A8"), Address(RVA = "0x3A3940", Offset = "0x3A2740", VA = "0x103A3940")] get
      {
        return new float();
      }
      [Token(Token = "0x600F2A9"), Address(RVA = "0xB34850", Offset = "0xB33650", VA = "0x10B34850")] set
      {
      }
    }

    [Token(Token = "0x170022ED")]
    public string ReceiptId
    {
      [Token(Token = "0x600F2AA"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F2AB"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] set
      {
      }
    }

    [Token(Token = "0x600F2AC")]
    [Address(RVA = "0xB34760", Offset = "0xB33560", VA = "0x10B34760")]
    public Verify(string userId, string currency, float price, string receiptId)
    {
    }

    [Token(Token = "0x600F2AD")]
    [Address(RVA = "0xB345F0", Offset = "0xB333F0", VA = "0x10B345F0", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F2AE")]
    [Address(RVA = "0xB33950", Offset = "0xB32750", VA = "0x10B33950", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F2AF")]
    [Address(RVA = "0xB34150", Offset = "0xB32F50", VA = "0x10B34150", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x200364D")]
    public class Response : GenericResponse<Verify.Response>
    {
      [Token(Token = "0x170022EE")]
      public string SuccessTransactionId
      {
        [Token(Token = "0x600F2B0"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F2B1"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
        {
        }
      }

      [Token(Token = "0x170022EF")]
      public int CurrentPaidCoin
      {
        [Token(Token = "0x600F2B2"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
        [Token(Token = "0x600F2B3"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
        {
        }
      }

      [Token(Token = "0x170022F0")]
      public int CurrentFreeCoin
      {
        [Token(Token = "0x600F2B4"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return new int();
        }
        [Token(Token = "0x600F2B5"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
        {
        }
      }

      [Token(Token = "0x170022F1")]
      public int CurrentCommonCoin
      {
        [Token(Token = "0x600F2B6"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return new int();
        }
        [Token(Token = "0x600F2B7"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
        {
        }
      }

      [Token(Token = "0x170022F2")]
      public int AdditionalPaidCoin
      {
        [Token(Token = "0x600F2B8"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
        {
          return new int();
        }
        [Token(Token = "0x600F2B9"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] private set
        {
        }
      }

      [Token(Token = "0x170022F3")]
      public int AdditionalFreeCoin
      {
        [Token(Token = "0x600F2BA"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
        {
          return new int();
        }
        [Token(Token = "0x600F2BB"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] private set
        {
        }
      }

      [Token(Token = "0x600F2BC")]
      [Address(RVA = "0xB2C1A0", Offset = "0xB2AFA0", VA = "0x10B2C1A0")]
      public Response(WebInternalResponse response)
      {
      }
    }
  }
}
