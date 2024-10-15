// Decompiled with JetBrains decompiler
// Type: PaymentManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Gsc.Purchase;
using Il2CppDummyDll;
using SRPG;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x200023B")]
[AddComponentMenu("Manager/PaymentManager")]
public class PaymentManager : MonoSingleton<PaymentManager>
{
  [Token(Token = "0x400098E")]
  [FieldOffset(Offset = "0xC")]
  private bool isSetupOK;
  [Token(Token = "0x4000990")]
  [FieldOffset(Offset = "0x14")]
  private Dictionary<string, ProductInfo> ProductOnStores;
  [Token(Token = "0x4000991")]
  [FieldOffset(Offset = "0x18")]
  public PaymentManager.ShowItemsDelegate OnShowItems;
  [Token(Token = "0x4000992")]
  [FieldOffset(Offset = "0x1C")]
  private PaymentManager.ERequestPurchaseResult purchaseResult;
  [Token(Token = "0x4000993")]
  [FieldOffset(Offset = "0x20")]
  public PaymentManager.RequestPurchaseDelegate OnRequestPurchase;
  [Token(Token = "0x4000994")]
  [FieldOffset(Offset = "0x24")]
  public PaymentManager.RegisterBirthdayDelegate OnRegisterBirthday;
  [Token(Token = "0x4000995")]
  [FieldOffset(Offset = "0x28")]
  public PaymentManager.RequestSucceededDelegate OnRequestSucceeded;
  [Token(Token = "0x4000996")]
  [FieldOffset(Offset = "0x2C")]
  public PaymentManager.RequestProcessingDelegate OnRequestProcessing;

  [Token(Token = "0x1700015F")]
  public bool IsAvailable
  {
    [Token(Token = "0x6000BD6"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x17000160")]
  public bool IsUnavailabled
  {
    [Token(Token = "0x6000BD7"), Address(RVA = "0x1089360", Offset = "0x1088160", VA = "0x11089360")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x17000161")]
  private List<ProductParam> ProductMasters
  {
    [Token(Token = "0x6000BD8"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
    {
      return (List<ProductParam>) null;
    }
    [Token(Token = "0x6000BD9"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
    {
    }
  }

  [Token(Token = "0x6000BDA")]
  [Address(RVA = "0x10881D0", Offset = "0x1086FD0", VA = "0x110881D0")]
  private ProductParam GetProductMaster(string productId) => (ProductParam) null;

  [Token(Token = "0x6000BDB")]
  [Address(RVA = "0x1088330", Offset = "0x1087130", VA = "0x11088330")]
  public PaymentManager.Product GetProduct(string productId) => (PaymentManager.Product) null;

  [Token(Token = "0x6000BDC")]
  [Address(RVA = "0x1088350", Offset = "0x1087150", VA = "0x11088350")]
  public List<PaymentManager.Product> GetProducts() => (List<PaymentManager.Product>) null;

  [Token(Token = "0x17000162")]
  private string AgreedVer
  {
    [Token(Token = "0x6000BDD"), Address(RVA = "0x1089270", Offset = "0x1088070", VA = "0x11089270")] get
    {
      return (string) null;
    }
    [Token(Token = "0x6000BDE"), Address(RVA = "0x10893A0", Offset = "0x10881A0", VA = "0x110893A0")] set
    {
    }
  }

  [Token(Token = "0x6000BDF")]
  [Address(RVA = "0x10886B0", Offset = "0x10874B0", VA = "0x110886B0", Slot = "4")]
  protected override void Initialize()
  {
  }

  [Token(Token = "0x6000BE0")]
  [Address(RVA = "0x1089090", Offset = "0x1087E90", VA = "0x11089090", Slot = "5")]
  protected override void Release()
  {
  }

  [Token(Token = "0x6000BE1")]
  [Address(RVA = "0x10884F0", Offset = "0x10872F0", VA = "0x110884F0")]
  public bool InitOnlyProductMaster(bool isResetMaster = false, ProductParamResponse res = null)
  {
    return new bool();
  }

  [Token(Token = "0x6000BE2")]
  [Address(RVA = "0x1088570", Offset = "0x1087370", VA = "0x11088570")]
  public bool Init(bool isResetMaster = false, ProductParamResponse res = null) => new bool();

  [Token(Token = "0x6000BE3")]
  [Address(RVA = "0x1089170", Offset = "0x1087F70", VA = "0x11089170")]
  public bool ShowItems() => new bool();

  [Token(Token = "0x6000BE4")]
  [Address(RVA = "0x10890E0", Offset = "0x1087EE0", VA = "0x110890E0")]
  public bool RequestPurchase(string productId) => new bool();

  [Token(Token = "0x6000BE5")]
  [Address(RVA = "0x1088FE0", Offset = "0x1087DE0", VA = "0x11088FE0")]
  public bool RegisterBirthday(int year, int month, int day) => new bool();

  [Token(Token = "0x6000BE6")]
  [Address(RVA = "0x10887E0", Offset = "0x10875E0", VA = "0x110887E0")]
  public void OnAgree()
  {
  }

  [Token(Token = "0x6000BE7")]
  [Address(RVA = "0x1088730", Offset = "0x1087530", VA = "0x11088730")]
  public bool IsAgree() => new bool();

  [Token(Token = "0x6000BE8")]
  [Address(RVA = "0x1088770", Offset = "0x1087570", VA = "0x11088770")]
  public void OnAgeResponse(PaymentManager.ERegisterBirthdayResult result)
  {
  }

  [Token(Token = "0x6000BE9")]
  [Address(RVA = "0x1088F00", Offset = "0x1087D00", VA = "0x11088F00")]
  public void OnUpdateProductDetails(ProductInfo[] products)
  {
  }

  [Token(Token = "0x6000BEA")]
  [Address(RVA = "0x1088D30", Offset = "0x1087B30", VA = "0x11088D30")]
  public void OnPurchaseSucceeded(FulfillmentResult.OrderInfo order, bool isDupe)
  {
  }

  [Token(Token = "0x6000BEB")]
  [Address(RVA = "0x1088B40", Offset = "0x1087940", VA = "0x11088B40")]
  public void OnPurchaseFailed()
  {
  }

  [Token(Token = "0x6000BEC")]
  [Address(RVA = "0x10888D0", Offset = "0x10876D0", VA = "0x110888D0")]
  public void OnInsufficientBalances()
  {
  }

  [Token(Token = "0x6000BED")]
  [Address(RVA = "0x1088A80", Offset = "0x1087880", VA = "0x11088A80")]
  public void OnPurchaseCanceled(string message)
  {
  }

  [Token(Token = "0x6000BEE")]
  [Address(RVA = "0x1088A20", Offset = "0x1087820", VA = "0x11088A20")]
  public void OnPurchaseAlreadyOwned(string message)
  {
  }

  [Token(Token = "0x6000BEF")]
  [Address(RVA = "0x1088AE0", Offset = "0x10878E0", VA = "0x11088AE0")]
  public void OnPurchaseDeferred()
  {
  }

  [Token(Token = "0x6000BF0")]
  [Address(RVA = "0x10889C0", Offset = "0x10877C0", VA = "0x110889C0")]
  public void OnOverCreditLimited()
  {
  }

  [Token(Token = "0x6000BF1")]
  [Address(RVA = "0x1088CB0", Offset = "0x1087AB0", VA = "0x11088CB0")]
  public void OnPurchasePending()
  {
  }

  [Token(Token = "0x6000BF2")]
  [Address(RVA = "0x1088C50", Offset = "0x1087A50", VA = "0x11088C50")]
  public void OnPurchasePendingExists()
  {
  }

  [Token(Token = "0x6000BF3")]
  [Address(RVA = "0x1088BA0", Offset = "0x10879A0", VA = "0x11088BA0")]
  public void OnPurchaseFinished(bool isSuccess)
  {
  }

  [Token(Token = "0x6000BF4")]
  [Address(RVA = "0x1088D10", Offset = "0x1087B10", VA = "0x11088D10")]
  public void OnPurchaseProcessing()
  {
  }

  [Token(Token = "0x6000BF5")]
  [Address(RVA = "0x1088930", Offset = "0x1087730", VA = "0x11088930")]
  public void OnNeedBirthday()
  {
  }

  [Token(Token = "0x6000BF6")]
  [Address(RVA = "0x10891E0", Offset = "0x1087FE0", VA = "0x110891E0")]
  public PaymentManager()
  {
  }

  [Token(Token = "0x200023C")]
  public enum ECheckChargeLimitResult
  {
    [Token(Token = "0x4000998")] SUCCESS,
    [Token(Token = "0x4000999")] NONAGE,
    [Token(Token = "0x400099A")] NEED_CHECK,
    [Token(Token = "0x400099B")] ERROR,
    [Token(Token = "0x400099C")] NEED_BIRTHDAY,
    [Token(Token = "0x400099D")] LIMIT_OVER,
  }

  [Token(Token = "0x200023D")]
  public class Product
  {
    [Token(Token = "0x400099E")]
    [FieldOffset(Offset = "0x8")]
    private ProductInfo store;
    [Token(Token = "0x400099F")]
    [FieldOffset(Offset = "0xC")]
    private ProductParam master;

    [Token(Token = "0x17000163")]
    public string ID
    {
      [Token(Token = "0x6000BF7"), Address(RVA = "0x3DA4C0", Offset = "0x3D92C0", VA = "0x103DA4C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000164")]
    public string productID
    {
      [Token(Token = "0x6000BF8"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6000BF9"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17000165")]
    public string name
    {
      [Token(Token = "0x6000BFA"), Address(RVA = "0x1089B10", Offset = "0x1088910", VA = "0x11089B10")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000166")]
    public string desc
    {
      [Token(Token = "0x6000BFB"), Address(RVA = "0x1089AE0", Offset = "0x10888E0", VA = "0x11089AE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000167")]
    public string price
    {
      [Token(Token = "0x6000BFC"), Address(RVA = "0x749500", Offset = "0x748300", VA = "0x10749500")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000168")]
    public double sellPrice
    {
      [Token(Token = "0x6000BFD"), Address(RVA = "0x1089BB0", Offset = "0x10889B0", VA = "0x11089BB0")] get
      {
        return new double();
      }
    }

    [Token(Token = "0x17000169")]
    public int numPaid
    {
      [Token(Token = "0x6000BFE"), Address(RVA = "0x1089B70", Offset = "0x1088970", VA = "0x11089B70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700016A")]
    public int numFree
    {
      [Token(Token = "0x6000BFF"), Address(RVA = "0x1089B40", Offset = "0x1088940", VA = "0x11089B40")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700016B")]
    public int CampaignRemainNum
    {
      [Token(Token = "0x6000C00"), Address(RVA = "0x1089A70", Offset = "0x1088870", VA = "0x11089A70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700016C")]
    public int remainNum
    {
      [Token(Token = "0x6000C01"), Address(RVA = "0x1089B90", Offset = "0x1088990", VA = "0x11089B90")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700016D")]
    public int StepUpIndex
    {
      [Token(Token = "0x6000C02"), Address(RVA = "0x1089AC0", Offset = "0x10888C0", VA = "0x11089AC0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700016E")]
    public bool IsDisplayOnly
    {
      [Token(Token = "0x6000C03"), Address(RVA = "0x1089AA0", Offset = "0x10888A0", VA = "0x11089AA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6000C04")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Product()
    {
    }

    [Token(Token = "0x6000C05")]
    [Address(RVA = "0x1089770", Offset = "0x1088570", VA = "0x11089770")]
    public static PaymentManager.Product Create(string productId_) => (PaymentManager.Product) null;

    [Token(Token = "0x6000C06")]
    [Address(RVA = "0x10898C0", Offset = "0x10886C0", VA = "0x110898C0")]
    public bool Reflesh(string productId_ = null) => new bool();

    [Token(Token = "0x6000C07")]
    [Address(RVA = "0x10899D0", Offset = "0x10887D0", VA = "0x110899D0", Slot = "3")]
    public override string ToString() => (string) null;
  }

  [Token(Token = "0x200023E")]
  public class CoinRecord
  {
    [Token(Token = "0x40009A1")]
    [FieldOffset(Offset = "0x8")]
    public string[] productIds;
    [Token(Token = "0x40009A2")]
    [FieldOffset(Offset = "0xC")]
    public int currentPaidCoin;
    [Token(Token = "0x40009A3")]
    [FieldOffset(Offset = "0x10")]
    public int currentFreeCoin;
    [Token(Token = "0x40009A4")]
    [FieldOffset(Offset = "0x14")]
    public int additionalPaidCoin;
    [Token(Token = "0x40009A5")]
    [FieldOffset(Offset = "0x18")]
    public int additionalFreeCoin;

    [Token(Token = "0x6000C08")]
    [Address(RVA = "0x1076870", Offset = "0x1075670", VA = "0x11076870")]
    public CoinRecord(
      string[] productIds_,
      int currentPaidCoin_,
      int currentFreeCoin_,
      int additionalPaidCoin_,
      int additionalFreeCoin_)
    {
    }
  }

  [Token(Token = "0x200023F")]
  public enum EShowItemsResult
  {
    [Token(Token = "0x40009A7")] SUCCESS,
    [Token(Token = "0x40009A8")] ERROR,
  }

  [Token(Token = "0x2000240")]
  public delegate void ShowItemsDelegate(
    PaymentManager.EShowItemsResult result,
    PaymentManager.Product[] products);

  [Token(Token = "0x2000241")]
  public enum ERequestPurchaseResult
  {
    [Token(Token = "0x40009AA")] NONE = -1, // 0xFFFFFFFF
    [Token(Token = "0x40009AB")] SUCCESS = 0,
    [Token(Token = "0x40009AC")] CANCEL = 1,
    [Token(Token = "0x40009AD")] ALREADY_OWN = 2,
    [Token(Token = "0x40009AE")] DEFERRED = 3,
    [Token(Token = "0x40009AF")] INSUFFICIENT_BALANCES = 4,
    [Token(Token = "0x40009B0")] OVER_LIMITED = 5,
    [Token(Token = "0x40009B1")] NEED_BIRTHDAY = 6,
    [Token(Token = "0x40009B2")] PENDING = 7,
    [Token(Token = "0x40009B3")] PENDING_EXISTS = 8,
    [Token(Token = "0x40009B4")] ERROR = 9,
  }

  [Token(Token = "0x2000242")]
  public delegate void RequestPurchaseDelegate(
    PaymentManager.ERequestPurchaseResult result,
    PaymentManager.CoinRecord record = null);

  [Token(Token = "0x2000243")]
  public enum ERegisterBirthdayResult
  {
    [Token(Token = "0x40009B6")] SUCCESS,
    [Token(Token = "0x40009B7")] ERROR,
  }

  [Token(Token = "0x2000244")]
  public delegate void RegisterBirthdayDelegate(PaymentManager.ERegisterBirthdayResult result);

  [Token(Token = "0x2000245")]
  private class MyDebug
  {
    [Token(Token = "0x40009B8")]
    [FieldOffset(Offset = "0x0")]
    private static PaymentManager.MyDebug self;
    [Token(Token = "0x40009B9")]
    [FieldOffset(Offset = "0x8")]
    private int max;
    [Token(Token = "0x40009BA")]
    [FieldOffset(Offset = "0xC")]
    private List<string> contents;

    [Token(Token = "0x6000C15")]
    [Address(RVA = "0x1082F20", Offset = "0x1081D20", VA = "0x11082F20")]
    public static void PushMessage(string msg)
    {
    }

    [Token(Token = "0x6000C16")]
    [Address(RVA = "0x1082DA0", Offset = "0x1081BA0", VA = "0x11082DA0")]
    public static IEnumerable<string> EachMessage() => (IEnumerable<string>) null;

    [Token(Token = "0x6000C17")]
    [Address(RVA = "0x10831F0", Offset = "0x1081FF0", VA = "0x110831F0")]
    public MyDebug()
    {
    }

    [Token(Token = "0x6000C18")]
    [Address(RVA = "0x1083000", Offset = "0x1081E00", VA = "0x11083000")]
    static MyDebug()
    {
    }
  }

  [Token(Token = "0x2000247")]
  public delegate void RequestSucceededDelegate();

  [Token(Token = "0x2000248")]
  public delegate void RequestProcessingDelegate();
}
