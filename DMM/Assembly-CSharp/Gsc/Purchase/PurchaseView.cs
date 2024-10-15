// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.PurchaseView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Gsc.Purchase
{
  [Token(Token = "0x20035FD")]
  [AddComponentMenu("Gsc.App/PurchaseView")]
  public class PurchaseView : MonoBehaviour, IPurchaseFlowListener, IPurchaseResultListener
  {
    [Token(Token = "0x600F0BF")]
    [Address(RVA = "0xB2A840", Offset = "0xB29640", VA = "0x10B2A840")]
    private void Start()
    {
    }

    [Token(Token = "0x600F0C0")]
    [Address(RVA = "0xB2A420", Offset = "0xB29220", VA = "0x10B2A420", Slot = "4")]
    public void InputBirthday(PurchaseFlow flow)
    {
    }

    [Token(Token = "0x600F0C1")]
    [Address(RVA = "0xB2A4F0", Offset = "0xB292F0", VA = "0x10B2A4F0", Slot = "6")]
    public void OnInvalidBirthday(PurchaseFlow flow)
    {
    }

    [Token(Token = "0x600F0C2")]
    [Address(RVA = "0xB2A3D0", Offset = "0xB291D0", VA = "0x10B2A3D0", Slot = "5")]
    public void Confirm(PurchaseFlow flow, ProductInfo product)
    {
    }

    [Token(Token = "0x600F0C3")]
    [Address(RVA = "0xB2A5B0", Offset = "0xB293B0", VA = "0x10B2A5B0", Slot = "7")]
    public void OnProducts(PurchaseFlow flow, ProductInfo[] products)
    {
    }

    [Token(Token = "0x600F0C4")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
    public void OnPurchaseSucceeded(FulfillmentResult result)
    {
    }

    [Token(Token = "0x600F0C5")]
    [Address(RVA = "0xB2A780", Offset = "0xB29580", VA = "0x10B2A780", Slot = "9")]
    public void OnPurchaseFailed()
    {
    }

    [Token(Token = "0x600F0C6")]
    [Address(RVA = "0xB2A6F0", Offset = "0xB294F0", VA = "0x10B2A6F0", Slot = "10")]
    public void OnPurchaseCanceled()
    {
    }

    [Token(Token = "0x600F0C7")]
    [Address(RVA = "0xB2A6A0", Offset = "0xB294A0", VA = "0x10B2A6A0", Slot = "11")]
    public void OnPurchaseAlreadyOwned()
    {
    }

    [Token(Token = "0x600F0C8")]
    [Address(RVA = "0xB2A570", Offset = "0xB29370", VA = "0x10B2A570", Slot = "15")]
    public void OnOverCreditLimited()
    {
    }

    [Token(Token = "0x600F0C9")]
    [Address(RVA = "0xB2A4B0", Offset = "0xB292B0", VA = "0x10B2A4B0", Slot = "16")]
    public void OnInsufficientBalances()
    {
    }

    [Token(Token = "0x600F0CA")]
    [Address(RVA = "0xB2A740", Offset = "0xB29540", VA = "0x10B2A740", Slot = "12")]
    public void OnPurchaseDeferred()
    {
    }

    [Token(Token = "0x600F0CB")]
    [Address(RVA = "0xB2A460", Offset = "0xB29260", VA = "0x10B2A460", Slot = "17")]
    public void OnFinished(bool isSuccess)
    {
    }

    [Token(Token = "0x600F0CC")]
    [Address(RVA = "0xB2A800", Offset = "0xB29600", VA = "0x10B2A800", Slot = "13")]
    public void OnPurchasePending()
    {
    }

    [Token(Token = "0x600F0CD")]
    [Address(RVA = "0xB2A7C0", Offset = "0xB295C0", VA = "0x10B2A7C0", Slot = "14")]
    public void OnPurchasePendingExists()
    {
    }

    [Token(Token = "0x600F0CE")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PurchaseView()
    {
    }
  }
}
