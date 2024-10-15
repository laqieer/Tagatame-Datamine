// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.Platform.FlowWithPurchaseKit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Gsc.Purchase.API.Response;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Purchase.Platform
{
  [Token(Token = "0x200361B")]
  public abstract class FlowWithPurchaseKit : IPurchaseFlowImpl, IPurchaseListener
  {
    [Token(Token = "0x400FEAD")]
    [FieldOffset(Offset = "0x8")]
    protected readonly PurchaseHandler handler;

    [Token(Token = "0x600F146")]
    [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
    public FlowWithPurchaseKit(PurchaseHandler handler)
    {
    }

    [Token(Token = "0x600F147")]
    [Address(RVA = "0xB218B0", Offset = "0xB206B0", VA = "0x10B218B0", Slot = "13")]
    public virtual void Init(string[] productIds)
    {
    }

    [Token(Token = "0x600F148")]
    [Address(RVA = "0xB21D00", Offset = "0xB20B00", VA = "0x10B21D00", Slot = "14")]
    public virtual void Resume()
    {
    }

    [Token(Token = "0x600F149")]
    [Address(RVA = "0xB21CA0", Offset = "0xB20AA0", VA = "0x10B21CA0", Slot = "15")]
    public virtual bool Purchase(ProductInfo product) => new bool();

    [Token(Token = "0x600F14A")]
    [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "16")]
    public virtual bool Confirmed() => new bool();

    [Token(Token = "0x600F14B")]
    [Address(RVA = "0xB21D10", Offset = "0xB20B10", VA = "0x10B21D10", Slot = "17")]
    public virtual void UpdateProducts(string[] productIds)
    {
    }

    [Token(Token = "0x600F14C")]
    [Address(RVA = "0xB21820", Offset = "0xB20620", VA = "0x10B21820", Slot = "18")]
    public virtual void Consume(string productId, string receiptId)
    {
    }

    [Token(Token = "0x600F14D")]
    [Address(RVA = "0xB21840", Offset = "0xB20640", VA = "0x10B21840")]
    private static ResultCode GetResultCode(int resultCode) => new ResultCode();

    [Token(Token = "0x600F14E")]
    [Address(RVA = "0xB219A0", Offset = "0xB207A0", VA = "0x10B219A0", Slot = "19")]
    public virtual void OnInitResult(int resultCode)
    {
    }

    [Token(Token = "0x600F14F")]
    [Address(RVA = "0xB219D0", Offset = "0xB207D0", VA = "0x10B219D0", Slot = "20")]
    public virtual void OnProductResult(int resultCode, PurchaseKit.ProductResponse response)
    {
    }

    [Token(Token = "0x600F150")]
    [Address(RVA = "0xB21C40", Offset = "0xB20A40", VA = "0x10B21C40", Slot = "21")]
    public virtual void OnPurchaseResult(int resultCode, PurchaseKit.PurchaseResponse response)
    {
    }

    [Token(Token = "0x600F151")]
    [Address(RVA = "0xB21940", Offset = "0xB20740", VA = "0x10B21940")]
    protected void OnFulfillmentResponse(Fulfillment response, IErrorResponse error)
    {
    }

    [Token(Token = "0x600F152")]
    protected abstract IWebTask CreateFulfillmentTask(PurchaseKit.PurchaseResponse response);
  }
}
