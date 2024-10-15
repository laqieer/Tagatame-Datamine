// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.IPurchaseFlowImpl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.Purchase
{
  [Token(Token = "0x20035F1")]
  public interface IPurchaseFlowImpl
  {
    [Token(Token = "0x600F06A")]
    void Init(string[] productIds);

    [Token(Token = "0x600F06B")]
    void UpdateProducts(string[] productIds);

    [Token(Token = "0x600F06C")]
    void Resume();

    [Token(Token = "0x600F06D")]
    bool Confirmed();

    [Token(Token = "0x600F06E")]
    bool Purchase(ProductInfo product);

    [Token(Token = "0x600F06F")]
    void Consume(string productId, string receiptId);
  }
}
