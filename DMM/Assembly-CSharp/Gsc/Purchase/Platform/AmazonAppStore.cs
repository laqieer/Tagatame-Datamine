// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.Platform.AmazonAppStore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Purchase.Platform
{
  [Token(Token = "0x2003602")]
  public class AmazonAppStore : FlowWithPurchaseKit
  {
    [Token(Token = "0x600F0EE")]
    [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
    public AmazonAppStore(PurchaseHandler handler)
    {
    }

    [Token(Token = "0x600F0EF")]
    [Address(RVA = "0xB1D180", Offset = "0xB1BF80", VA = "0x10B1D180", Slot = "13")]
    public override void Init(string[] productIds)
    {
    }

    [Token(Token = "0x600F0F0")]
    [Address(RVA = "0xB1EF60", Offset = "0xB1DD60", VA = "0x10B1EF60", Slot = "22")]
    protected override IWebTask CreateFulfillmentTask(PurchaseKit.PurchaseResponse response)
    {
      return (IWebTask) null;
    }
  }
}
