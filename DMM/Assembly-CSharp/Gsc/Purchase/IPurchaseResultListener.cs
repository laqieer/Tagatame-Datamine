// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.IPurchaseResultListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.Purchase
{
  [Token(Token = "0x20035F4")]
  public interface IPurchaseResultListener
  {
    [Token(Token = "0x600F075")]
    void OnPurchaseSucceeded(FulfillmentResult result);

    [Token(Token = "0x600F076")]
    void OnPurchaseFailed();

    [Token(Token = "0x600F077")]
    void OnPurchaseCanceled();

    [Token(Token = "0x600F078")]
    void OnPurchaseAlreadyOwned();

    [Token(Token = "0x600F079")]
    void OnPurchaseDeferred();

    [Token(Token = "0x600F07A")]
    void OnPurchasePending();

    [Token(Token = "0x600F07B")]
    void OnPurchasePendingExists();

    [Token(Token = "0x600F07C")]
    void OnOverCreditLimited();

    [Token(Token = "0x600F07D")]
    void OnInsufficientBalances();

    [Token(Token = "0x600F07E")]
    void OnFinished(bool isSuccess);
  }
}
