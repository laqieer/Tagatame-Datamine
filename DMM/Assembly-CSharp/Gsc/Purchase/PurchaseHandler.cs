// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.PurchaseHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Gsc.Purchase
{
  [Token(Token = "0x20035F8")]
  public class PurchaseHandler
  {
    [Token(Token = "0x400FE4F")]
    [FieldOffset(Offset = "0x0")]
    private static LogKit.Logger logger;
    [Token(Token = "0x400FE50")]
    [FieldOffset(Offset = "0x18")]
    private IPurchaseFlowListener flowListener;
    [Token(Token = "0x400FE51")]
    [FieldOffset(Offset = "0x1C")]
    private bool enabledInactiveCallback;
    [Token(Token = "0x400FE52")]
    [FieldOffset(Offset = "0x20")]
    private string[] productIds;
    [Token(Token = "0x400FE53")]
    [FieldOffset(Offset = "0x24")]
    private IPurchaseFlowImpl impl;
    [Token(Token = "0x400FE55")]
    public const WebTaskAttribute TASK_ATTRIBUTES = WebTaskAttribute.Reliable | WebTaskAttribute.Silent | WebTaskAttribute.Parallel;
    [Token(Token = "0x400FE56")]
    [FieldOffset(Offset = "0x4")]
    public static readonly PurchaseHandler Instance;
    [Token(Token = "0x400FE57")]
    [FieldOffset(Offset = "0x2C")]
    private float _lastResumed;

    [Token(Token = "0x17002270")]
    public bool initialized
    {
      [Token(Token = "0x600F097"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F098"), Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")] private set
      {
      }
    }

    [Token(Token = "0x17002271")]
    public bool unavailabled
    {
      [Token(Token = "0x600F099"), Address(RVA = "0x34B080", Offset = "0x349E80", VA = "0x1034B080")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F09A"), Address(RVA = "0x3FA400", Offset = "0x3F9200", VA = "0x103FA400")] private set
      {
      }
    }

    [Token(Token = "0x17002272")]
    public ProductInfo[] ProductList
    {
      [Token(Token = "0x600F09B"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (ProductInfo[]) null;
      }
      [Token(Token = "0x600F09C"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17002273")]
    public bool HasCreditLimit
    {
      [Token(Token = "0x600F09D"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F09E"), Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")] private set
      {
      }
    }

    [Token(Token = "0x17002274")]
    public float CreditLimit
    {
      [Token(Token = "0x600F09F"), Address(RVA = "0x2C72E0", Offset = "0x2C60E0", VA = "0x102C72E0")] get
      {
        return new float();
      }
      [Token(Token = "0x600F0A0"), Address(RVA = "0x2C73A0", Offset = "0x2C61A0", VA = "0x102C73A0")] private set
      {
      }
    }

    [Token(Token = "0x600F0A1")]
    [Address(RVA = "0xB27B60", Offset = "0xB26960", VA = "0x10B27B60")]
    public static void Log(int type, string tag, string message)
    {
    }

    [Token(Token = "0x17002275")]
    public bool isProcessing
    {
      [Token(Token = "0x600F0A2"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F0A3"), Address(RVA = "0x7BB1C0", Offset = "0x7B9FC0", VA = "0x107BB1C0")] private set
      {
      }
    }

    [Token(Token = "0x600F0A4")]
    [Address(RVA = "0xB28B80", Offset = "0xB27980", VA = "0x10B28B80")]
    static PurchaseHandler()
    {
    }

    [Token(Token = "0x600F0A5")]
    [Address(RVA = "0xB28C40", Offset = "0xB27A40", VA = "0x10B28C40")]
    private PurchaseHandler()
    {
    }

    [Token(Token = "0x600F0A6")]
    [Address(RVA = "0xB27950", Offset = "0xB26750", VA = "0x10B27950")]
    public static void Initialize()
    {
    }

    [Token(Token = "0x600F0A7")]
    [Address(RVA = "0xB278F0", Offset = "0xB266F0", VA = "0x10B278F0")]
    public void Init(string[] productIds)
    {
    }

    [Token(Token = "0x600F0A8")]
    [Address(RVA = "0xB278A0", Offset = "0xB266A0", VA = "0x10B278A0")]
    private void Init()
    {
    }

    [Token(Token = "0x600F0A9")]
    [Address(RVA = "0xB28AC0", Offset = "0xB278C0", VA = "0x10B28AC0")]
    public void UpdateProducts(string[] productIds)
    {
    }

    [Token(Token = "0x600F0AA")]
    [Address(RVA = "0xB28B30", Offset = "0xB27930", VA = "0x10B28B30")]
    private void UpdateProducts()
    {
    }

    [Token(Token = "0x600F0AB")]
    [Address(RVA = "0xB287E0", Offset = "0xB275E0", VA = "0x10B287E0")]
    public void Resume()
    {
    }

    [Token(Token = "0x600F0AC")]
    [Address(RVA = "0xB27B30", Offset = "0xB26930", VA = "0x10B27B30")]
    public void Launch(IPurchaseFlowListener listener, bool enableInactiveCallback)
    {
    }

    [Token(Token = "0x600F0AD")]
    [Address(RVA = "0xB28270", Offset = "0xB27070", VA = "0x10B28270")]
    public bool Purchase(string productId) => new bool();

    [Token(Token = "0x600F0AE")]
    [Address(RVA = "0xB27730", Offset = "0xB26530", VA = "0x10B27730")]
    public void Confirm(ProductInfo product)
    {
    }

    [Token(Token = "0x600F0AF")]
    [Address(RVA = "0xB27840", Offset = "0xB26640", VA = "0x10B27840")]
    public void Confirmed(bool isOK)
    {
    }

    [Token(Token = "0x600F0B0")]
    [Address(RVA = "0xB27A30", Offset = "0xB26830", VA = "0x10B27A30")]
    public void InputBirthday(int year, int month, int date)
    {
    }

    [Token(Token = "0x600F0B1")]
    [Address(RVA = "0xB284B0", Offset = "0xB272B0", VA = "0x10B284B0")]
    private void RenderProducts()
    {
    }

    [Token(Token = "0x600F0B2")]
    [Address(RVA = "0xB27C40", Offset = "0xB26A40", VA = "0x10B27C40")]
    public void OnInitResult(ResultCode resultCode)
    {
    }

    [Token(Token = "0x600F0B3")]
    [Address(RVA = "0xB27D60", Offset = "0xB26B60", VA = "0x10B27D60")]
    public void OnProductResult(ResultCode resultCode, ProductInfo[] products)
    {
    }

    [Token(Token = "0x600F0B4")]
    [Address(RVA = "0xB27E00", Offset = "0xB26C00", VA = "0x10B27E00")]
    public void OnPurchaseResult(ResultCode resultCode, FulfillmentResult result)
    {
    }

    [Token(Token = "0x20035F9")]
    public class Observer : MonoBehaviour
    {
      [Token(Token = "0x400FE58")]
      [FieldOffset(Offset = "0xC")]
      private int cachedInstanceId;

      [Token(Token = "0x600F0B7")]
      [Address(RVA = "0xB24890", Offset = "0xB23690", VA = "0x10B24890")]
      private void Awake()
      {
      }

      [Token(Token = "0x600F0B8")]
      [Address(RVA = "0xB248B0", Offset = "0xB236B0", VA = "0x10B248B0")]
      private void OnApplicationFocus(bool focusState)
      {
      }

      [Token(Token = "0x600F0B9")]
      [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
      public Observer()
      {
      }
    }
  }
}
