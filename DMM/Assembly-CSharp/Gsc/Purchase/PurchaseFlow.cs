// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.PurchaseFlow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Gsc.Purchase
{
  [Token(Token = "0x20035F7")]
  public class PurchaseFlow
  {
    [Token(Token = "0x400FE47")]
    [FieldOffset(Offset = "0x0")]
    public static PurchaseFlow Instance;
    [Token(Token = "0x400FE49")]
    [FieldOffset(Offset = "0x8")]
    private static PurchaseHandler _Handler;

    [Token(Token = "0x1700226C")]
    public static bool initialized
    {
      [Token(Token = "0x600F087"), Address(RVA = "0xB272A0", Offset = "0xB260A0", VA = "0x10B272A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700226D")]
    public static bool unavailabled
    {
      [Token(Token = "0x600F088"), Address(RVA = "0xB27310", Offset = "0xB26110", VA = "0x10B27310")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700226E")]
    public static ProductInfo[] ProductList
    {
      [Token(Token = "0x600F089"), Address(RVA = "0xB27230", Offset = "0xB26030", VA = "0x10B27230")] get
      {
        return (ProductInfo[]) null;
      }
    }

    [Token(Token = "0x1700226F")]
    public static IPurchaseGlobalListener Listener
    {
      [Token(Token = "0x600F08A"), Address(RVA = "0xB271F0", Offset = "0xB25FF0", VA = "0x10B271F0")] get
      {
        return (IPurchaseGlobalListener) null;
      }
      [Token(Token = "0x600F08B"), Address(RVA = "0xB27380", Offset = "0xB26180", VA = "0x10B27380")] private set
      {
      }
    }

    [Token(Token = "0x600F08C")]
    [Address(RVA = "0xB27140", Offset = "0xB25F40", VA = "0x10B27140")]
    static PurchaseFlow()
    {
    }

    [Token(Token = "0x600F08D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private PurchaseFlow()
    {
    }

    [Token(Token = "0x600F08E")]
    [Address(RVA = "0xB26BF0", Offset = "0xB259F0", VA = "0x10B26BF0")]
    public static void Init(string[] productIds, IPurchaseGlobalListener listener)
    {
    }

    [Token(Token = "0x600F08F")]
    [Address(RVA = "0xB27070", Offset = "0xB25E70", VA = "0x10B27070")]
    public static void UpdateProducts(string[] productIds)
    {
    }

    [Token(Token = "0x600F090")]
    [Address(RVA = "0xB26F50", Offset = "0xB25D50", VA = "0x10B26F50")]
    public static void Resume()
    {
    }

    [Token(Token = "0x600F091")]
    public static void LaunchFlow<T>(T listener) where T : MonoBehaviour, IPurchaseFlowListener
    {
    }

    [Token(Token = "0x600F092")]
    public static void LaunchFlow<T>(T listener, bool enableInactiveCallback) where T : MonoBehaviour, IPurchaseFlowListener
    {
    }

    [Token(Token = "0x600F093")]
    [Address(RVA = "0xB26EF0", Offset = "0xB25CF0", VA = "0x10B26EF0")]
    public bool Purchase(string productId) => new bool();

    [Token(Token = "0x600F094")]
    [Address(RVA = "0xB26D10", Offset = "0xB25B10", VA = "0x10B26D10")]
    public void InputBirthday(int year, int month, int date)
    {
    }

    [Token(Token = "0x600F095")]
    [Address(RVA = "0xB26B50", Offset = "0xB25950", VA = "0x10B26B50")]
    public void Confirmed(bool isOK)
    {
    }

    [Token(Token = "0x600F096")]
    [Address(RVA = "0xB26E50", Offset = "0xB25C50", VA = "0x10B26E50")]
    public static bool IsEnable(ProductInfo productInfo) => new bool();
  }
}
