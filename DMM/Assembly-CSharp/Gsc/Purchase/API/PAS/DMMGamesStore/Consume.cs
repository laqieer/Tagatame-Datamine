// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.API.PAS.DMMGamesStore.Consume
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
  [Token(Token = "0x2003638")]
  public class Consume : Request<Consume, Consume.Response>
  {
    [Token(Token = "0x400FEF3")]
    private const string ___path = "{0}/pas/dmmgamesstore/{1}/purchase/consume";

    [Token(Token = "0x170022AE")]
    public int ViewerId
    {
      [Token(Token = "0x600F1EF"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F1F0"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] set
      {
      }
    }

    [Token(Token = "0x170022AF")]
    public string OnetimeToken
    {
      [Token(Token = "0x600F1F1"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F1F2"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x170022B0")]
    public string PaymentId
    {
      [Token(Token = "0x600F1F3"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F1F4"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] set
      {
      }
    }

    [Token(Token = "0x600F1F5")]
    [Address(RVA = "0xB20940", Offset = "0xB1F740", VA = "0x10B20940")]
    public Consume(int viewerId, string onetimeToken, string paymentId)
    {
    }

    [Token(Token = "0x600F1F6")]
    [Address(RVA = "0xB20870", Offset = "0xB1F670", VA = "0x10B20870", Slot = "29")]
    public override string GetUrl() => (string) null;

    [Token(Token = "0x600F1F7")]
    [Address(RVA = "0xB20840", Offset = "0xB1F640", VA = "0x10B20840", Slot = "30")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600F1F8")]
    [Address(RVA = "0xB205B0", Offset = "0xB1F3B0", VA = "0x10B205B0", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600F1F9")]
    [Address(RVA = "0xB205E0", Offset = "0xB1F3E0", VA = "0x10B205E0", Slot = "32")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x2003639")]
    public class Response : GenericResponse<Consume.Response>
    {
      [Token(Token = "0x600F1FA")]
      [Address(RVA = "0xB2C510", Offset = "0xB2B310", VA = "0x10B2C510")]
      public Response(WebInternalResponse response)
      {
      }
    }
  }
}
