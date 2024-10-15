// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.Platform.GooglePlay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Purchase.Platform
{
  [Token(Token = "0x200361C")]
  public class GooglePlay : FlowWithPurchaseKit
  {
    [Token(Token = "0x600F153")]
    [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
    public GooglePlay(PurchaseHandler handler)
    {
    }

    [Token(Token = "0x600F154")]
    [Address(RVA = "0xB23960", Offset = "0xB22760", VA = "0x10B23960", Slot = "22")]
    protected override IWebTask CreateFulfillmentTask(PurchaseKit.PurchaseResponse response)
    {
      return (IWebTask) null;
    }
  }
}
