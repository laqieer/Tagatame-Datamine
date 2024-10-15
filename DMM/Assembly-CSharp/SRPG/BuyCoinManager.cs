// Decompiled with JetBrains decompiler
// Type: SRPG.BuyCoinManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002116")]
  [AddComponentMenu("UI/BuyCoinManager")]
  [FlowNode.Pin(1000, "Initialized", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(999, "Close me", FlowNode.PinTypes.Output, 999)]
  [FlowNode.Pin(100, "URL OPEN", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(8, "InitTabFree3", FlowNode.PinTypes.Input, 8)]
  [FlowNode.Pin(6, "InitTabFree1", FlowNode.PinTypes.Input, 6)]
  [FlowNode.Pin(5, "InitTabFgG", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(4, "InitTabCollabo", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(3, "InitTabLimited", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "InitTabExpansion", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "InitTabCoin", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(7, "InitTabFree2", FlowNode.PinTypes.Input, 7)]
  public class BuyCoinManager : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008F60")]
    public const int PIN_INPUT_INIT_TAB_COIN = 1;
    [Token(Token = "0x4008F61")]
    public const int PIN_INPUT_INIT_TAB_EXPANSION = 2;
    [Token(Token = "0x4008F62")]
    public const int PIN_INPUT_INIT_TAB_LIMITED = 3;
    [Token(Token = "0x4008F63")]
    public const int PIN_INPUT_INIT_TAB_COLLABO = 4;
    [Token(Token = "0x4008F64")]
    public const int PIN_INPUT_INIT_TAB_FGG = 5;
    [Token(Token = "0x4008F65")]
    public const int PIN_INPUT_INIT_TAB_FREE1 = 6;
    [Token(Token = "0x4008F66")]
    public const int PIN_INPUT_INIT_TAB_FREE2 = 7;
    [Token(Token = "0x4008F67")]
    public const int PIN_INPUT_INIT_TAB_FREE3 = 8;
    [Token(Token = "0x4008F68")]
    public const int PIN_OUTPUT_OPEN_URL = 100;
    [Token(Token = "0x4008F69")]
    public const int PIN_OUTPUT_CLOSE_ME = 999;
    [Token(Token = "0x4008F6A")]
    public const int PIN_OUTPUT_INITIALIZED = 1000;
    [Token(Token = "0x4008F6B")]
    public const string BUYCOIN_URL_KEY = "BUYCOIN_URL";
    [Token(Token = "0x4008F6C")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mTabCoin;
    [Token(Token = "0x4008F6D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mTabLimited;
    [Token(Token = "0x4008F6E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mTabCollabo;
    [Token(Token = "0x4008F6F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mTabExpansion;
    [Token(Token = "0x4008F70")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mTabFgG;
    [Token(Token = "0x4008F71")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mTabFree1;
    [Token(Token = "0x4008F72")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mTabFree2;
    [Token(Token = "0x4008F73")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mTabFree3;
    [Token(Token = "0x4008F74")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mPeriod;
    [Token(Token = "0x4008F75")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text mPeriodText;
    [Token(Token = "0x4008F76")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mNoticeButton;
    [Token(Token = "0x4008F77")]
    [FieldOffset(Offset = "0x0")]
    private static BuyCoinManager mInstance;
    [Token(Token = "0x4008F78")]
    [FieldOffset(Offset = "0x38")]
    public BuyCoinManager.BuyCoinShopType mNowSelectTab;
    [Token(Token = "0x4008F79")]
    [FieldOffset(Offset = "0x3C")]
    private string mSelectNoticeURL;
    [Token(Token = "0x4008F7A")]
    [FieldOffset(Offset = "0x40")]
    private List<BuyCoinStep> mBuycoinSteps;
    [Token(Token = "0x4008F7B")]
    [FieldOffset(Offset = "0x44")]
    private GameObject mNowTabObject;

    [Token(Token = "0x170013AA")]
    public static BuyCoinManager Instance
    {
      [Token(Token = "0x6008A9B"), Address(RVA = "0x4E4C60", Offset = "0x4E3A60", VA = "0x104E4C60")] get
      {
        return (BuyCoinManager) null;
      }
    }

    [Token(Token = "0x170013AB")]
    public string SelectNoticeURL
    {
      [Token(Token = "0x6008A9C"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6008A9D")]
    [Address(RVA = "0x4E3280", Offset = "0x4E2080", VA = "0x104E3280")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008A9E")]
    [Address(RVA = "0x4E3E30", Offset = "0x4E2C30", VA = "0x104E3E30")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6008A9F")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Update()
    {
    }

    [Token(Token = "0x6008AA0")]
    [Address(RVA = "0x4E31B0", Offset = "0x4E1FB0", VA = "0x104E31B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008AA1")]
    [Address(RVA = "0x4E3310", Offset = "0x4E2110", VA = "0x104E3310")]
    public void CloseMe()
    {
    }

    [Token(Token = "0x6008AA2")]
    [Address(RVA = "0x4E3720", Offset = "0x4E2520", VA = "0x104E3720")]
    private void Init()
    {
    }

    [Token(Token = "0x6008AA3")]
    [Address(RVA = "0x4E36A0", Offset = "0x4E24A0", VA = "0x104E36A0")]
    private GameObject GetTabObject(BuyCoinManager.BuyCoinShopType type) => (GameObject) null;

    [Token(Token = "0x6008AA4")]
    [Address(RVA = "0x4E46D0", Offset = "0x4E34D0", VA = "0x104E46D0")]
    private void SelectedToggleTab(BuyCoinManager.BuyCoinShopType type)
    {
    }

    [Token(Token = "0x6008AA5")]
    [Address(RVA = "0x4E3D10", Offset = "0x4E2B10", VA = "0x104E3D10")]
    public void OnClickTab(GameObject go)
    {
    }

    [Token(Token = "0x6008AA6")]
    [Address(RVA = "0x4E4930", Offset = "0x4E3730", VA = "0x104E4930")]
    private void UpdateShopInfo(BuyCoinManager.BuyCoinShopType shopType)
    {
    }

    [Token(Token = "0x6008AA7")]
    [Address(RVA = "0x4E3E80", Offset = "0x4E2C80", VA = "0x104E3E80")]
    private void RefreshShopList(BuyCoinShopParam _param)
    {
    }

    [Token(Token = "0x6008AA8")]
    [Address(RVA = "0x4E34B0", Offset = "0x4E22B0", VA = "0x104E34B0")]
    public PaymentManager.Product[] GetProduct() => (PaymentManager.Product[]) null;

    [Token(Token = "0x6008AA9")]
    [Address(RVA = "0x4E3BB0", Offset = "0x4E29B0", VA = "0x104E3BB0")]
    private bool IsValidShop(List<BuyCoinShopParam> shopList, string shopId) => new bool();

    [Token(Token = "0x6008AAA")]
    [Address(RVA = "0x4E3420", Offset = "0x4E2220", VA = "0x104E3420")]
    public PaymentManager.Product GetProductByProductId(string _id)
    {
      return (PaymentManager.Product) null;
    }

    [Token(Token = "0x6008AAB")]
    [Address(RVA = "0x4E33E0", Offset = "0x4E21E0", VA = "0x104E33E0")]
    public bool GetProductBuyConfirm(PaymentManager.Product product) => new bool();

    [Token(Token = "0x6008AAC")]
    [Address(RVA = "0x4E3330", Offset = "0x4E2130", VA = "0x104E3330")]
    private void DisableAllTab()
    {
    }

    [Token(Token = "0x6008AAD")]
    [Address(RVA = "0x4E47A0", Offset = "0x4E35A0", VA = "0x104E47A0")]
    private void SetNorticeActive(BuyCoinShopParam _param)
    {
    }

    [Token(Token = "0x6008AAE")]
    [Address(RVA = "0x4E3DC0", Offset = "0x4E2BC0", VA = "0x104E3DC0")]
    public void OnClickURLButton()
    {
    }

    [Token(Token = "0x6008AAF")]
    [Address(RVA = "0x4E4840", Offset = "0x4E3640", VA = "0x104E4840")]
    public void SetUpBuyCoinSteps(Json_BuyCoinSteps[] json)
    {
    }

    [Token(Token = "0x6008AB0")]
    [Address(RVA = "0x4E3AA0", Offset = "0x4E28A0", VA = "0x104E3AA0")]
    public bool IsStepUpProductId(List<BuyCoinShopParam> _shopList, PaymentManager.Product _product)
    {
      return new bool();
    }

    [Token(Token = "0x6008AB1")]
    [Address(RVA = "0x4E4BD0", Offset = "0x4E39D0", VA = "0x104E4BD0")]
    public BuyCoinManager()
    {
    }

    [Token(Token = "0x2002117")]
    public enum BuyCoinShopType
    {
      [Token(Token = "0x4008F7D")] COIN,
      [Token(Token = "0x4008F7E")] LIMITED,
      [Token(Token = "0x4008F7F")] COLLABO,
      [Token(Token = "0x4008F80")] EXPANSION,
      [Token(Token = "0x4008F81")] FGG,
      [Token(Token = "0x4008F82")] HOTDEAL,
      [Token(Token = "0x4008F83")] STEPUP,
      [Token(Token = "0x4008F84")] FREE1,
      [Token(Token = "0x4008F85")] FREE2,
      [Token(Token = "0x4008F86")] FREE3,
      [Token(Token = "0x4008F87")] ALL,
    }

    [Token(Token = "0x2002118")]
    public enum PremiumRewadType
    {
      [Token(Token = "0x4008F89")] Item,
      [Token(Token = "0x4008F8A")] Gold,
      [Token(Token = "0x4008F8B")] Coin,
      [Token(Token = "0x4008F8C")] Artifact,
      [Token(Token = "0x4008F8D")] ConceptCard,
      [Token(Token = "0x4008F8E")] Unit,
    }

    [Token(Token = "0x2002119")]
    public enum PremiumRestrictionType
    {
      [Token(Token = "0x4008F90")] None,
      [Token(Token = "0x4008F91")] AllBuy,
      [Token(Token = "0x4008F92")] DayBuy,
    }
  }
}
