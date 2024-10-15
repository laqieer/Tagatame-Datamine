// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.PAS.DMMGamesStore.Fulfillment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Purchase.API.PAS.DMMGamesStore
{
  [Token(Token = "0x2003636")]
  public class Fulfillment : Request<Fulfillment, Gsc.Purchase.API.Response.Fulfillment>
  {
    [Token(Token = "0x400FEEC")]
    private const string ___path = "{0}/pas/dmmgamesstore/{1}/fulfill";

    [Token(Token = "0x170022A9")]
    public List<Fulfillment.PurchaseData_t> PurchaseDataList
    {
      [Token(Token = "0x600F1DE"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<Fulfillment.PurchaseData_t>) null;
      }
      [Token(Token = "0x600F1DF"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x170022AA")]
    public string DeviceId
    {
      [Token(Token = "0x600F1E0"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F1E1"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x600F1E2")]
    [Address(RVA = "0xB23880", Offset = "0xB22680", VA = "0x10B23880")]
    public Fulfillment(string deviceId, List<Fulfillment.PurchaseData_t> purchaseDataList)
    {
    }

    [Token(Token = "0x600F1E3")]
    [Address(RVA = "0xB231C0", Offset = "0xB21FC0", VA = "0x10B231C0", Slot = "29")]
    public override string GetUrl() => (string) null;

    [Token(Token = "0x600F1E4")]
    [Address(RVA = "0xB22EF0", Offset = "0xB21CF0", VA = "0x10B22EF0", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F1E5")]
    [Address(RVA = "0xB21DC0", Offset = "0xB20BC0", VA = "0x10B21DC0", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F1E6")]
    [Address(RVA = "0xB22340", Offset = "0xB21140", VA = "0x10B22340", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x2003637")]
    public class PurchaseData_t : IRequestObject, IObject
    {
      [Token(Token = "0x170022AB")]
      public int ViewerID
      {
        [Token(Token = "0x600F1E7"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return new int();
        }
        [Token(Token = "0x600F1E8"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] set
        {
        }
      }

      [Token(Token = "0x170022AC")]
      public string OnetimeToken
      {
        [Token(Token = "0x600F1E9"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F1EA"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] set
        {
        }
      }

      [Token(Token = "0x170022AD")]
      public string PaymentId
      {
        [Token(Token = "0x600F1EB"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F1EC"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
        {
        }
      }

      [Token(Token = "0x600F1ED")]
      [Address(RVA = "0xB26B10", Offset = "0xB25910", VA = "0x10B26B10")]
      public PurchaseData_t(int viewerId, string onetimeToken, string paymentId)
      {
      }

      [Token(Token = "0x600F1EE")]
      [Address(RVA = "0xB262C0", Offset = "0xB250C0", VA = "0x10B262C0", Slot = "4")]
      public Dictionary<string, object> GetPayload() => (Dictionary<string, object>) null;
    }
  }
}
