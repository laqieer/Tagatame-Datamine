// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.PAS.DMMGamesStore.Purchase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Gsc.Purchase.API.App;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Purchase.API.PAS.DMMGamesStore
{
  [Token(Token = "0x2003630")]
  public class Purchase : Request<Gsc.Purchase.API.PAS.DMMGamesStore.Purchase, Gsc.Purchase.API.PAS.DMMGamesStore.Purchase.Response>
  {
    [Token(Token = "0x400FEDF")]
    private const string ___path = "{0}/pas/dmmgamesstore/{1}/purchase";

    [Token(Token = "0x1700229F")]
    public int ViewerID
    {
      [Token(Token = "0x600F1BA"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F1BB"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] set
      {
      }
    }

    [Token(Token = "0x170022A0")]
    public string OnetimeToken
    {
      [Token(Token = "0x600F1BC"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F1BD"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x170022A1")]
    public string ProductID
    {
      [Token(Token = "0x600F1BE"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F1BF"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] set
      {
      }
    }

    [Token(Token = "0x600F1C0")]
    [Address(RVA = "0xB2AC30", Offset = "0xB29A30", VA = "0x10B2AC30")]
    public Purchase(int viewerId, string onetimeToken, string productId)
    {
    }

    [Token(Token = "0x600F1C1")]
    [Address(RVA = "0xB2AB60", Offset = "0xB29960", VA = "0x10B2AB60", Slot = "29")]
    public override string GetUrl() => (string) null;

    [Token(Token = "0x600F1C2")]
    [Address(RVA = "0xB2AB30", Offset = "0xB29930", VA = "0x10B2AB30", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F1C3")]
    [Address(RVA = "0xB2A8A0", Offset = "0xB296A0", VA = "0x10B2A8A0", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F1C4")]
    [Address(RVA = "0xB2A8D0", Offset = "0xB296D0", VA = "0x10B2A8D0", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x2003631")]
    public class Response : GenericResponse<Gsc.Purchase.API.PAS.DMMGamesStore.Purchase.Response>
    {
      [Token(Token = "0x170022A2")]
      public string PaymentId
      {
        [Token(Token = "0x600F1C5"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600F1C6"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
        {
        }
      }

      [Token(Token = "0x600F1C7")]
      [Address(RVA = "0xB2D220", Offset = "0xB2C020", VA = "0x10B2D220")]
      public Response(WebInternalResponse response)
      {
      }
    }
  }
}
