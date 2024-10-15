// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.FulfillmentResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Purchase
{
  [Token(Token = "0x20035EE")]
  public class FulfillmentResult : IResponseObject, Gsc.Network.IObject
  {
    [Token(Token = "0x400FE35")]
    [FieldOffset(Offset = "0x8")]
    public readonly int CurrentFreeCoin;
    [Token(Token = "0x400FE36")]
    [FieldOffset(Offset = "0xC")]
    public readonly int CurrentPaidCoin;
    [Token(Token = "0x400FE37")]
    [FieldOffset(Offset = "0x10")]
    public readonly int CurrentCommonCoin;
    [Token(Token = "0x400FE38")]
    [FieldOffset(Offset = "0x14")]
    public readonly FulfillmentResult.OrderInfo[] SucceededTransactions;
    [Token(Token = "0x400FE39")]
    [FieldOffset(Offset = "0x18")]
    public readonly FulfillmentResult.OrderInfo[] DuplicatedTransactions;

    [Token(Token = "0x600F062")]
    [Address(RVA = "0xB09940", Offset = "0xB08740", VA = "0x10B09940")]
    public FulfillmentResult(
      int currentFreeCoin,
      int currentPaidCoin,
      int currentCommonCoin,
      FulfillmentResult.OrderInfo[] succeededTransactions,
      FulfillmentResult.OrderInfo[] duplicatedTransactions)
    {
    }

    [Token(Token = "0x600F063")]
    [Address(RVA = "0xB09620", Offset = "0xB08420", VA = "0x10B09620")]
    public FulfillmentResult(Gsc.DOM.IObject node)
    {
    }

    [Token(Token = "0x20035EF")]
    public class OrderInfo : IResponseObject, Gsc.Network.IObject
    {
      [Token(Token = "0x400FE3A")]
      [FieldOffset(Offset = "0x8")]
      public readonly int FreeCoin;
      [Token(Token = "0x400FE3B")]
      [FieldOffset(Offset = "0xC")]
      public readonly int PaidCoin;
      [Token(Token = "0x400FE3C")]
      [FieldOffset(Offset = "0x10")]
      public readonly string ProductId;
      [Token(Token = "0x400FE3D")]
      [FieldOffset(Offset = "0x14")]
      public readonly string TransactionId;

      [Token(Token = "0x600F064")]
      [Address(RVA = "0xB0E360", Offset = "0xB0D160", VA = "0x10B0E360")]
      public OrderInfo(int freeCoin, int paidCoin, string productId, string transactionId)
      {
      }

      [Token(Token = "0x600F065")]
      [Address(RVA = "0xB0E210", Offset = "0xB0D010", VA = "0x10B0E210")]
      public OrderInfo(Gsc.DOM.IObject node)
      {
      }
    }
  }
}
