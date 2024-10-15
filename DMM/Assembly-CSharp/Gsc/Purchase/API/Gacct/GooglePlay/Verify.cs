// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.Gacct.GooglePlay.Verify
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Gsc.Purchase.API.App;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Purchase.API.Gacct.GooglePlay
{
  [Token(Token = "0x2003642")]
  public class Verify : GenericRequest<Verify, Verify.Response>
  {
    [Token(Token = "0x400FF12")]
    private const string ___path = "/v2/android/verify";

    [Token(Token = "0x170022C7")]
    public string Currency
    {
      [Token(Token = "0x600F243"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F244"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x170022C8")]
    public float Price
    {
      [Token(Token = "0x600F245"), Address(RVA = "0x3A3990", Offset = "0x3A2790", VA = "0x103A3990")] get
      {
        return new float();
      }
      [Token(Token = "0x600F246"), Address(RVA = "0xB34830", Offset = "0xB33630", VA = "0x10B34830")] set
      {
      }
    }

    [Token(Token = "0x170022C9")]
    public string Signature
    {
      [Token(Token = "0x600F247"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F248"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] set
      {
      }
    }

    [Token(Token = "0x170022CA")]
    public string ReceiptData
    {
      [Token(Token = "0x600F249"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F24A"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] set
      {
      }
    }

    [Token(Token = "0x600F24B")]
    [Address(RVA = "0xB346F0", Offset = "0xB334F0", VA = "0x10B346F0")]
    public Verify(string currency, float price, string signature, string receiptData)
    {
    }

    [Token(Token = "0x600F24C")]
    [Address(RVA = "0xB34560", Offset = "0xB33360", VA = "0x10B34560", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F24D")]
    [Address(RVA = "0xB339B0", Offset = "0xB327B0", VA = "0x10B339B0", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F24E")]
    [Address(RVA = "0xB33BE0", Offset = "0xB329E0", VA = "0x10B33BE0", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x2003643")]
    public class Response : GenericResponse<Verify.Response>
    {
      [Token(Token = "0x170022CB")]
      public string SuccessTransactionId
      {
        [Token(Token = "0x600F24F"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F250"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
        {
        }
      }

      [Token(Token = "0x170022CC")]
      public int CurrentPaidCoin
      {
        [Token(Token = "0x600F251"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
        [Token(Token = "0x600F252"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
        {
        }
      }

      [Token(Token = "0x170022CD")]
      public int CurrentFreeCoin
      {
        [Token(Token = "0x600F253"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return new int();
        }
        [Token(Token = "0x600F254"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
        {
        }
      }

      [Token(Token = "0x170022CE")]
      public int CurrentCommonCoin
      {
        [Token(Token = "0x600F255"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return new int();
        }
        [Token(Token = "0x600F256"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
        {
        }
      }

      [Token(Token = "0x170022CF")]
      public int AdditionalPaidCoin
      {
        [Token(Token = "0x600F257"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
        {
          return new int();
        }
        [Token(Token = "0x600F258"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] private set
        {
        }
      }

      [Token(Token = "0x170022D0")]
      public int AdditionalFreeCoin
      {
        [Token(Token = "0x600F259"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
        {
          return new int();
        }
        [Token(Token = "0x600F25A"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] private set
        {
        }
      }

      [Token(Token = "0x600F25B")]
      [Address(RVA = "0xB2C7C0", Offset = "0xB2B5C0", VA = "0x10B2C7C0")]
      public Response(WebInternalResponse response)
      {
      }
    }
  }
}
