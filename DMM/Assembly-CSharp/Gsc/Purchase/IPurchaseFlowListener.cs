// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.IPurchaseFlowListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.Purchase
{
  [Token(Token = "0x20035F2")]
  public interface IPurchaseFlowListener : IPurchaseResultListener
  {
    [Token(Token = "0x600F070")]
    void InputBirthday(PurchaseFlow flow);

    [Token(Token = "0x600F071")]
    void Confirm(PurchaseFlow flow, ProductInfo product);

    [Token(Token = "0x600F072")]
    void OnInvalidBirthday(PurchaseFlow flow);

    [Token(Token = "0x600F073")]
    void OnProducts(PurchaseFlow flow, ProductInfo[] products);
  }
}
