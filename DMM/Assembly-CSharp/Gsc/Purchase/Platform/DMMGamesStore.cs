// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.Platform.DMMGamesStore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Purchase.Platform
{
  [Token(Token = "0x2003611")]
  public class DMMGamesStore : IPurchaseFlowImpl
  {
    [Token(Token = "0x400FE87")]
    [FieldOffset(Offset = "0x8")]
    private readonly PurchaseHandler handler;
    [Token(Token = "0x400FE88")]
    [FieldOffset(Offset = "0xC")]
    private ProductInfo processProduct;

    [Token(Token = "0x17002278")]
    private static int ViewerID
    {
      [Token(Token = "0x600F111"), Address(RVA = "0xB20FD0", Offset = "0xB1FDD0", VA = "0x10B20FD0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002279")]
    private static string OnetimeToken
    {
      [Token(Token = "0x600F112"), Address(RVA = "0xB20F90", Offset = "0xB1FD90", VA = "0x10B20F90")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600F113")]
    [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
    public DMMGamesStore(PurchaseHandler handler)
    {
    }

    [Token(Token = "0x600F114")]
    [Address(RVA = "0xB20CA0", Offset = "0xB1FAA0", VA = "0x10B20CA0", Slot = "4")]
    public void Init(string[] productIds)
    {
    }

    [Token(Token = "0x600F115")]
    [Address(RVA = "0xB20F00", Offset = "0xB1FD00", VA = "0x10B20F00", Slot = "6")]
    public void Resume()
    {
    }

    [Token(Token = "0x600F116")]
    [Address(RVA = "0xB20DD0", Offset = "0xB1FBD0", VA = "0x10B20DD0", Slot = "8")]
    public bool Purchase(ProductInfo product) => new bool();

    [Token(Token = "0x600F117")]
    [Address(RVA = "0xB209A0", Offset = "0xB1F7A0", VA = "0x10B209A0", Slot = "7")]
    public bool Confirmed() => new bool();

    [Token(Token = "0x600F118")]
    [Address(RVA = "0xB20CA0", Offset = "0xB1FAA0", VA = "0x10B20CA0", Slot = "5")]
    public void UpdateProducts(string[] productIds)
    {
    }

    [Token(Token = "0x600F119")]
    [Address(RVA = "0xB20B30", Offset = "0xB1F930", VA = "0x10B20B30", Slot = "9")]
    public void Consume(string productId, string receiptId)
    {
    }

    [Token(Token = "0x2003612")]
    private class InnerFlow
    {
      [Token(Token = "0x400FE89")]
      private const float TIMEOUT_SECONDS = 30f;
      [Token(Token = "0x400FE8A")]
      [FieldOffset(Offset = "0x8")]
      private readonly PurchaseHandler handler;
      [Token(Token = "0x400FE8B")]
      [FieldOffset(Offset = "0xC")]
      private string waitingPaymentId;
      [Token(Token = "0x400FE8C")]
      [FieldOffset(Offset = "0x10")]
      private string paymentStatus;

      [Token(Token = "0x600F11A")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      private InnerFlow(PurchaseHandler handler)
      {
      }

      [Token(Token = "0x600F11B")]
      [Address(RVA = "0xB24080", Offset = "0xB22E80", VA = "0x10B24080")]
      public static void Purchase(PurchaseHandler handler, string productId)
      {
      }

      [Token(Token = "0x600F11C")]
      [Address(RVA = "0xB24160", Offset = "0xB22F60", VA = "0x10B24160")]
      public static void Resume(PurchaseHandler handler)
      {
      }

      [Token(Token = "0x600F11D")]
      [Address(RVA = "0xB24250", Offset = "0xB23050", VA = "0x10B24250")]
      private IEnumerator _Purchase(string productId) => (IEnumerator) null;

      [Token(Token = "0x600F11E")]
      [Address(RVA = "0xB241E0", Offset = "0xB22FE0", VA = "0x10B241E0")]
      private IEnumerator _GetPaymentId(string productId) => (IEnumerator) null;

      [Token(Token = "0x600F11F")]
      [Address(RVA = "0xB24330", Offset = "0xB23130", VA = "0x10B24330")]
      private IEnumerator _WaitPurchase() => (IEnumerator) null;

      [Token(Token = "0x600F120")]
      [Address(RVA = "0xB242C0", Offset = "0xB230C0", VA = "0x10B242C0")]
      private static IEnumerator _Resume(PurchaseHandler handler) => (IEnumerator) null;

      [Token(Token = "0x600F121")]
      [Address(RVA = "0xB23D90", Offset = "0xB22B90", VA = "0x10B23D90")]
      private static IWebTask CreateFulfillmentTask(
        PurchaseHandler handler,
        List<string> paymentIds)
      {
        return (IWebTask) null;
      }
    }
  }
}
