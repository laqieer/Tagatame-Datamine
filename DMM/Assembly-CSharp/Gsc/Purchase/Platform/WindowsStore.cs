// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.Platform.WindowsStore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Purchase.Platform
{
  [Token(Token = "0x200361F")]
  public class WindowsStore : FlowWithPurchaseKit
  {
    [Token(Token = "0x600F159")]
    [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
    public WindowsStore(PurchaseHandler handler)
    {
    }

    [Token(Token = "0x600F15A")]
    [Address(RVA = "0xB34870", Offset = "0xB33670", VA = "0x10B34870", Slot = "22")]
    protected override IWebTask CreateFulfillmentTask(PurchaseKit.PurchaseResponse response)
    {
      return (IWebTask) null;
    }
  }
}
