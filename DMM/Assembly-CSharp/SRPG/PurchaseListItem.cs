// Decompiled with JetBrains decompiler
// Type: SRPG.PurchaseListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002863")]
  [AddComponentMenu("UI/Purchase/PurchaseListItem")]
  [FlowNode.Pin(200, "購入後の30日ログインボーナスをクリック", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(101, "指定したURLを開く", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(201, "終売後の30日ログインボーナスをクリック", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(100, "プレミアムセットの詳細ボタンをクリックした", FlowNode.PinTypes.Output, 100)]
  public class PurchaseListItem : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C0D6")]
    private const int OUTPUT_SEL_PREMIUM_PRODUCTID = 100;
    [Token(Token = "0x400C0D7")]
    private const int OUTPUT_OPEN_URL = 101;
    [Token(Token = "0x400C0D8")]
    private const int OUTPUT_PURCHASED_VIP_PRODUCT = 200;
    [Token(Token = "0x400C0D9")]
    private const int OUTPUT_END_OF_SALE = 201;
    [Token(Token = "0x400C0DA")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject PurchaseBefore;
    [Token(Token = "0x400C0DB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject PurchaseBeforePremiumDetail;
    [Token(Token = "0x400C0DC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject Purchased;
    [Token(Token = "0x400C0DD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject PurchasedLimited;
    [Token(Token = "0x400C0DE")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject Purchasable;
    [Token(Token = "0x400C0DF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject PurchasedOverdue;
    [Token(Token = "0x400C0E0")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject PurchaseIcon;
    [Token(Token = "0x400C0E1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RewardListItem PurchaseIconList;
    [Token(Token = "0x400C0E2")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject PurchaseBadge;
    [Token(Token = "0x400C0E3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ImageArray PurchaseBadgeImage;
    [Token(Token = "0x400C0E4")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text PurchaseBuyCountTitle;
    [Token(Token = "0x400C0E5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text PurchaseBuyCountText;
    [Token(Token = "0x400C0E6")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject PurchaseBuyCountObject;
    [Token(Token = "0x400C0E7")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject PurchaseSoldOut;
    [Token(Token = "0x400C0E8")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject BonusItem;
    [Token(Token = "0x400C0E9")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject CampaignRemainItem;
    [Token(Token = "0x400C0EA")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private ImageArray CoinIcon;
    [Token(Token = "0x400C0EB")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject BuyCoinItemDetailWindow;
    [Token(Token = "0x400C0EC")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private int RepurchaseRemainDay;
    [Token(Token = "0x400C0ED")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject LockObject;
    [Token(Token = "0x400C0EE")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private Text LockText;
    [Token(Token = "0x400C0EF")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject GuildLockObject;
    [Token(Token = "0x400C0F0")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private Text GuildLockText;
    [Token(Token = "0x400C0F1")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject PeriodObj;
    [Token(Token = "0x400C0F2")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private Text PeriodText;
    [Token(Token = "0x400C0F3")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject OverdueObj;
    [Token(Token = "0x400C0F4")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private GameObject DescRePurchase;
    [Token(Token = "0x400C0F5")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Button rootButton;
    [Token(Token = "0x400C0F6")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    private LText DescRePurchaseTxt;
    [Token(Token = "0x400C0F7")]
    [FieldOffset(Offset = "0x80")]
    private bool mIsVip;
    [Token(Token = "0x400C0F8")]
    [FieldOffset(Offset = "0x81")]
    private bool mIsPremium;
    [Token(Token = "0x400C0F9")]
    [FieldOffset(Offset = "0x82")]
    private bool mIsPurchased;
    [Token(Token = "0x400C0FA")]
    [FieldOffset(Offset = "0x83")]
    private bool mIsDispOnly;
    [Token(Token = "0x400C0FB")]
    [FieldOffset(Offset = "0x84")]
    private PaymentManager.Product mProduct;
    [Token(Token = "0x400C0FC")]
    [FieldOffset(Offset = "0x88")]
    private string mOpenUrl;

    [Token(Token = "0x170018FF")]
    public bool IsVip
    {
      [Token(Token = "0x600B678"), Address(RVA = "0x2B5E90", Offset = "0x2B4C90", VA = "0x102B5E90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001900")]
    public bool IsPremium
    {
      [Token(Token = "0x600B679"), Address(RVA = "0x2B6050", Offset = "0x2B4E50", VA = "0x102B6050")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001901")]
    public bool IsPurchased
    {
      [Token(Token = "0x600B67A"), Address(RVA = "0x7D0160", Offset = "0x7CEF60", VA = "0x107D0160")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001902")]
    public bool IsDispOnly
    {
      [Token(Token = "0x600B67B"), Address(RVA = "0x7D0150", Offset = "0x7CEF50", VA = "0x107D0150")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001903")]
    public int CoinNum
    {
      [Token(Token = "0x600B67C"), Address(RVA = "0x7D0100", Offset = "0x7CEF00", VA = "0x107D0100")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001904")]
    public int CoinNumPaid
    {
      [Token(Token = "0x600B67D"), Address(RVA = "0x7D00D0", Offset = "0x7CEED0", VA = "0x107D00D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001905")]
    public PaymentManager.Product ProductID
    {
      [Token(Token = "0x600B67E"), Address(RVA = "0x2B6020", Offset = "0x2B4E20", VA = "0x102B6020")] get
      {
        return (PaymentManager.Product) null;
      }
    }

    [Token(Token = "0x600B67F")]
    [Address(RVA = "0x7CE3B0", Offset = "0x7CD1B0", VA = "0x107CE3B0")]
    public void Init(PaymentManager.Product product)
    {
    }

    [Token(Token = "0x600B680")]
    [Address(RVA = "0x7CFFD0", Offset = "0x7CEDD0", VA = "0x107CFFD0")]
    public void SetSpriteId(int index)
    {
    }

    [Token(Token = "0x600B681")]
    [Address(RVA = "0x7CFF40", Offset = "0x7CED40", VA = "0x107CFF40")]
    public void SetBadgeId(int index)
    {
    }

    [Token(Token = "0x600B682")]
    [Address(RVA = "0x7CFA70", Offset = "0x7CE870", VA = "0x107CFA70")]
    public void OnButtonHelpClick()
    {
    }

    [Token(Token = "0x600B683")]
    [Address(RVA = "0x7CFDD0", Offset = "0x7CEBD0", VA = "0x107CFDD0")]
    public void OnPremiumAfterButton()
    {
    }

    [Token(Token = "0x600B684")]
    [Address(RVA = "0x7CFE50", Offset = "0x7CEC50", VA = "0x107CFE50")]
    public void OnPurchasedVipButton()
    {
    }

    [Token(Token = "0x600B685")]
    [Address(RVA = "0x7CF8A0", Offset = "0x7CE6A0", VA = "0x107CF8A0")]
    private bool IsExtraQuestsAvailable() => new bool();

    [Token(Token = "0x600B686")]
    [Address(RVA = "0x7CDD60", Offset = "0x7CCB60", VA = "0x107CDD60")]
    private void ExpansionPurchaseLock(PaymentManager.Product _product)
    {
    }

    [Token(Token = "0x600B687")]
    [Address(RVA = "0x7CE270", Offset = "0x7CD070", VA = "0x107CE270")]
    private string GetExpansionUrl(PaymentManager.Product _product) => (string) null;

    [Token(Token = "0x600B688")]
    [Address(RVA = "0x7CFC70", Offset = "0x7CEA70", VA = "0x107CFC70")]
    public void OnClickURLButton()
    {
    }

    [Token(Token = "0x600B689")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B68A")]
    [Address(RVA = "0x7D0080", Offset = "0x7CEE80", VA = "0x107D0080")]
    public PurchaseListItem()
    {
    }
  }
}
