// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.PAS.DMMGamesStore.PurchaseList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.DOM;
using Gsc.Network;
using Gsc.Purchase.API.App;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Purchase.API.PAS.DMMGamesStore
{
  [Token(Token = "0x200362C")]
  public class PurchaseList : Request<PurchaseList, PurchaseList.Response>
  {
    [Token(Token = "0x400FED6")]
    private const string ___path = "{0}/pas/dmmgamesstore/{1}/purchase/list";

    [Token(Token = "0x1700229A")]
    public int ViewerID
    {
      [Token(Token = "0x600F1A6"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F1A7"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] set
      {
      }
    }

    [Token(Token = "0x1700229B")]
    public string OnetimeToken
    {
      [Token(Token = "0x600F1A8"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F1A9"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x600F1AA")]
    [Address(RVA = "0xB290C0", Offset = "0xB27EC0", VA = "0x10B290C0")]
    public PurchaseList(int viewerId, string onetimeToken)
    {
    }

    [Token(Token = "0x600F1AB")]
    [Address(RVA = "0xB28FF0", Offset = "0xB27DF0", VA = "0x10B28FF0", Slot = "29")]
    public override string GetUrl() => (string) null;

    [Token(Token = "0x600F1AC")]
    [Address(RVA = "0xB28FC0", Offset = "0xB27DC0", VA = "0x10B28FC0", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F1AD")]
    [Address(RVA = "0xB28DB0", Offset = "0xB27BB0", VA = "0x10B28DB0", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F1AE")]
    [Address(RVA = "0xB28DE0", Offset = "0xB27BE0", VA = "0x10B28DE0", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x200362D")]
    public class Response : GenericResponse<PurchaseList.Response>
    {
      [Token(Token = "0x1700229C")]
      public PurchaseList.Response.PurchaseInfo_t[] Infos
      {
        [Token(Token = "0x600F1AF"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (PurchaseList.Response.PurchaseInfo_t[]) null;
        }
        [Token(Token = "0x600F1B0"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
        {
        }
      }

      [Token(Token = "0x600F1B1")]
      [Address(RVA = "0xB2BF30", Offset = "0xB2AD30", VA = "0x10B2BF30")]
      public Response(WebInternalResponse response)
      {
      }

      [Token(Token = "0x200362E")]
      public class PurchaseInfo_t : IResponseObject, Gsc.Network.IObject
      {
        [Token(Token = "0x1700229D")]
        public string PaymentId
        {
          [Token(Token = "0x600F1B2"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
          {
            return (string) null;
          }
          [Token(Token = "0x600F1B3"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
          {
          }
        }

        [Token(Token = "0x1700229E")]
        public string ProductId
        {
          [Token(Token = "0x600F1B4"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
          {
            return (string) null;
          }
          [Token(Token = "0x600F1B5"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
          {
          }
        }

        [Token(Token = "0x600F1B6")]
        [Address(RVA = "0xB28CC0", Offset = "0xB27AC0", VA = "0x10B28CC0")]
        public PurchaseInfo_t(IValue node)
        {
        }
      }
    }
  }
}
