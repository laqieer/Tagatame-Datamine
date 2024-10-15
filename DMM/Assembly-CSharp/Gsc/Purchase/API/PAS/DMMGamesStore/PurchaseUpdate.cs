// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.PAS.DMMGamesStore.PurchaseUpdate
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
  [Token(Token = "0x2003632")]
  public class PurchaseUpdate : Request<PurchaseUpdate, PurchaseUpdate.Response>
  {
    [Token(Token = "0x400FEE4")]
    private const string ___path = "{0}/pas/dmmgamesstore/{1}/purchase/update";

    [Token(Token = "0x170022A3")]
    public int ViewerID
    {
      [Token(Token = "0x600F1C8"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F1C9"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] set
      {
      }
    }

    [Token(Token = "0x170022A4")]
    public string OnetimeToken
    {
      [Token(Token = "0x600F1CA"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F1CB"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x170022A5")]
    public List<string> PaymentIds
    {
      [Token(Token = "0x600F1CC"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x600F1CD"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] set
      {
      }
    }

    [Token(Token = "0x600F1CE")]
    [Address(RVA = "0xB2A370", Offset = "0xB29170", VA = "0x10B2A370")]
    public PurchaseUpdate(int viewerId, string onetimeToken, List<string> paymentIds)
    {
    }

    [Token(Token = "0x600F1CF")]
    [Address(RVA = "0xB2A2A0", Offset = "0xB290A0", VA = "0x10B2A2A0", Slot = "29")]
    public override string GetUrl() => (string) null;

    [Token(Token = "0x600F1D0")]
    [Address(RVA = "0xB2A270", Offset = "0xB29070", VA = "0x10B2A270", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F1D1")]
    [Address(RVA = "0xB29FB0", Offset = "0xB28DB0", VA = "0x10B29FB0", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F1D2")]
    [Address(RVA = "0xB29FE0", Offset = "0xB28DE0", VA = "0x10B29FE0", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x2003633")]
    public class Response : GenericResponse<PurchaseUpdate.Response>
    {
      [Token(Token = "0x170022A6")]
      public PurchaseUpdate.Response.Status_t[] Results
      {
        [Token(Token = "0x600F1D3"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (PurchaseUpdate.Response.Status_t[]) null;
        }
        [Token(Token = "0x600F1D4"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
        {
        }
      }

      [Token(Token = "0x600F1D5")]
      [Address(RVA = "0xB2C550", Offset = "0xB2B350", VA = "0x10B2C550")]
      public Response(WebInternalResponse response)
      {
      }

      [Token(Token = "0x2003634")]
      public class Status_t : IResponseObject, Gsc.Network.IObject
      {
        [Token(Token = "0x170022A7")]
        public string PaymentId
        {
          [Token(Token = "0x600F1D6"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
          {
            return (string) null;
          }
          [Token(Token = "0x600F1D7"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
          {
          }
        }

        [Token(Token = "0x170022A8")]
        public string Status
        {
          [Token(Token = "0x600F1D8"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
          {
            return (string) null;
          }
          [Token(Token = "0x600F1D9"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
          {
          }
        }

        [Token(Token = "0x600F1DA")]
        [Address(RVA = "0xB2EFD0", Offset = "0xB2DDD0", VA = "0x10B2EFD0")]
        public Status_t(IValue node)
        {
        }
      }
    }
  }
}
