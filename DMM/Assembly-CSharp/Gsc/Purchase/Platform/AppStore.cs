// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.Platform.AppStore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Purchase.Platform
{
  [Token(Token = "0x2003605")]
  public class AppStore : FlowWithPurchaseKit
  {
    [Token(Token = "0x600F0F5")]
    [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
    public AppStore(PurchaseHandler handler)
    {
    }

    [Token(Token = "0x600F0F6")]
    [Address(RVA = "0xB1F3B0", Offset = "0xB1E1B0", VA = "0x10B1F3B0", Slot = "22")]
    protected override IWebTask CreateFulfillmentTask(PurchaseKit.PurchaseResponse response)
    {
      return (IWebTask) null;
    }

    [Token(Token = "0x600F0F7")]
    [Address(RVA = "0xB1F770", Offset = "0xB1E570", VA = "0x10B1F770")]
    private void OnFulfillmentResult(FulfillmentResult result, IErrorResponse error)
    {
    }
  }
}
