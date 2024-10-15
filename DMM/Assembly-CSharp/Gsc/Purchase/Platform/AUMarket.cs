// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.Platform.AUMarket
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Purchase.Platform
{
  [Token(Token = "0x200360B")]
  public class AUMarket : FlowWithPurchaseKit
  {
    [Token(Token = "0x400FE7E")]
    public const int RESULT_AUMARKET_OVER_CREDIT_LIMIT = 49;

    [Token(Token = "0x600F101")]
    [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
    public AUMarket(PurchaseHandler handler)
    {
    }

    [Token(Token = "0x600F102")]
    [Address(RVA = "0xB1D160", Offset = "0xB1BF60", VA = "0x10B1D160", Slot = "13")]
    public override void Init(string[] productIds)
    {
    }

    [Token(Token = "0x600F103")]
    [Address(RVA = "0xB1D190", Offset = "0xB1BF90", VA = "0x10B1D190", Slot = "17")]
    public override void UpdateProducts(string[] productIds)
    {
    }

    [Token(Token = "0x600F104")]
    [Address(RVA = "0xB1CD60", Offset = "0xB1BB60", VA = "0x10B1CD60", Slot = "22")]
    protected override IWebTask CreateFulfillmentTask(PurchaseKit.PurchaseResponse response)
    {
      return (IWebTask) null;
    }
  }
}
