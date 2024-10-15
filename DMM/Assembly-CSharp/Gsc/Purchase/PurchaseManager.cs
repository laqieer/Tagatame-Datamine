// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.PurchaseManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Gsc.Network.Encoding;
using Il2CppDummyDll;
using SRPG;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Gsc.Purchase
{
  [Token(Token = "0x20035FE")]
  [AddComponentMenu("Manager/PurchaseManager")]
  public class PurchaseManager : MonoSingleton<PurchaseManager>
  {
    [Token(Token = "0x400FE68")]
    [FieldOffset(Offset = "0x10")]
    private PurchaseFlow saveFlow;
    [Token(Token = "0x400FE69")]
    [FieldOffset(Offset = "0x14")]
    private EncodingTypes.ESerializeCompressMethod __serializeCompressMethod;

    [Token(Token = "0x17002276")]
    public PurchaseManager.OnProductsSchedule onProductsSchedule
    {
      [Token(Token = "0x600F0CF"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new PurchaseManager.OnProductsSchedule();
      }
      [Token(Token = "0x600F0D0"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] set
      {
      }
    }

    [Token(Token = "0x600F0D1")]
    [Address(RVA = "0xB29300", Offset = "0xB28100", VA = "0x10B29300")]
    private List<string> GetProductList(List<ProductParam> ProductMasters) => (List<string>) null;

    [Token(Token = "0x600F0D2")]
    [Address(RVA = "0xB29620", Offset = "0xB28420", VA = "0x10B29620")]
    public void Init(List<ProductParam> ProductMasters)
    {
    }

    [Token(Token = "0x600F0D3")]
    [Address(RVA = "0xB29740", Offset = "0xB28540", VA = "0x10B29740")]
    public void InputBirthday(int year, int month, int day)
    {
    }

    [Token(Token = "0x600F0D4")]
    [Address(RVA = "0xB29D40", Offset = "0xB28B40", VA = "0x10B29D40")]
    public void ResponseBirthday(PaymentManager.ERegisterBirthdayResult result)
    {
    }

    [Token(Token = "0x600F0D5")]
    [Address(RVA = "0xB29CA0", Offset = "0xB28AA0", VA = "0x10B29CA0")]
    public void Purchase(string productId)
    {
    }

    [Token(Token = "0x600F0D6")]
    [Address(RVA = "0xB29DD0", Offset = "0xB28BD0", VA = "0x10B29DD0")]
    public void UpdateProduct(List<ProductParam> ProductMasters)
    {
    }

    [Token(Token = "0x600F0D7")]
    [Address(RVA = "0xB29D90", Offset = "0xB28B90", VA = "0x10B29D90")]
    public void Resume()
    {
    }

    [Token(Token = "0x17002277")]
    private EncodingTypes.ESerializeCompressMethod SerializeCompressMethod
    {
      [Token(Token = "0x600F0D8"), Address(RVA = "0xB29F40", Offset = "0xB28D40", VA = "0x10B29F40")] get
      {
        return new EncodingTypes.ESerializeCompressMethod();
      }
      [Token(Token = "0x600F0D9"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] set
      {
      }
    }

    [Token(Token = "0x600F0DA")]
    [Address(RVA = "0xB29110", Offset = "0xB27F10", VA = "0x10B29110")]
    public void Confirm(PurchaseFlow flow, ProductInfo product)
    {
    }

    [Token(Token = "0x600F0DB")]
    [Address(RVA = "0xB298D0", Offset = "0xB286D0", VA = "0x10B298D0")]
    public void OnProducts(PurchaseFlow flow, ProductInfo[] products)
    {
    }

    [Token(Token = "0x600F0DC")]
    [Address(RVA = "0xB29990", Offset = "0xB28790", VA = "0x10B29990")]
    private void ProductChargePrepareCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600F0DD")]
    [Address(RVA = "0xB29F00", Offset = "0xB28D00", VA = "0x10B29F00")]
    public PurchaseManager()
    {
    }

    [Token(Token = "0x20035FF")]
    public enum OnProductsSchedule
    {
      [Token(Token = "0x400FE6B")] NONE,
      [Token(Token = "0x400FE6C")] REQUEST_API,
    }

    [Token(Token = "0x2003600")]
    public class PurchaseGlobalListener : IPurchaseGlobalListener, IPurchaseResultListener
    {
      [Token(Token = "0x600F0DE")]
      [Address(RVA = "0xB273E0", Offset = "0xB261E0", VA = "0x10B273E0", Slot = "4")]
      public void OnInitialized()
      {
      }

      [Token(Token = "0x600F0DF")]
      [Address(RVA = "0xB27450", Offset = "0xB26250", VA = "0x10B27450")]
      private void OnPurchaseSucceeded(FulfillmentResult.OrderInfo order, bool isdupe = false)
      {
      }

      [Token(Token = "0x600F0E0")]
      [Address(RVA = "0xB274A0", Offset = "0xB262A0", VA = "0x10B274A0", Slot = "5")]
      public void OnPurchaseSucceeded(FulfillmentResult result)
      {
      }

      [Token(Token = "0x600F0E1")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public void OnPurchaseFailed()
      {
      }

      [Token(Token = "0x600F0E2")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
      public void OnPurchaseCanceled()
      {
      }

      [Token(Token = "0x600F0E3")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
      public void OnPurchaseAlreadyOwned()
      {
      }

      [Token(Token = "0x600F0E4")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "9")]
      public void OnPurchaseDeferred()
      {
      }

      [Token(Token = "0x600F0E5")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "12")]
      public void OnOverCreditLimited()
      {
      }

      [Token(Token = "0x600F0E6")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "13")]
      public void OnInsufficientBalances()
      {
      }

      [Token(Token = "0x600F0E7")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "14")]
      public void OnFinished(bool isSuccess)
      {
      }

      [Token(Token = "0x600F0E8")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "10")]
      public void OnPurchasePending()
      {
      }

      [Token(Token = "0x600F0E9")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "11")]
      public void OnPurchasePendingExists()
      {
      }

      [Token(Token = "0x600F0EA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public PurchaseGlobalListener()
      {
      }
    }
  }
}
