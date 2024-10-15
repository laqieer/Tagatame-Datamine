// Decompiled with JetBrains decompiler
// Type: SRPG.HotDealManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002639")]
  [FlowNode.Pin(0, "HotDealリスト表示", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "新HotDealのみでリスト生成", FlowNode.PinTypes.Input, 10)]
  [FlowNode.NodeType("HotDeal/HotDealManager", 32741)]
  [FlowNode.Pin(20, "新HotDealDialogのSetup", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(11, "新HotDealのみでリスト生成", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(1, "HotDealリスト表示", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(300, "BuyHotDeal", FlowNode.PinTypes.Output, 300)]
  [FlowNode.Pin(200, "OpenDialog", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(21, "新HotDealDialogのSetup", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(40, "購入したHotDeal削除", FlowNode.PinTypes.Input, 40)]
  [FlowNode.Pin(31, "既存HotDealDialogのSetup", FlowNode.PinTypes.Output, 31)]
  [FlowNode.Pin(30, "既存HotDealDialogのSetup", FlowNode.PinTypes.Input, 30)]
  [AddComponentMenu("UI/HotDeal/HotDealManager")]
  [FlowNode.Pin(41, "購入したHotDeal削除", FlowNode.PinTypes.Output, 41)]
  public class HotDealManager : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B272")]
    private const int PIN_INPUT_SETUP_MODE_LIST = 0;
    [Token(Token = "0x400B273")]
    private const int PIN_OUTPUT_SETUP_MODE_LIST = 1;
    [Token(Token = "0x400B274")]
    private const int PIN_INPUT_SETUP_NEWLY = 10;
    [Token(Token = "0x400B275")]
    private const int PIN_OUTPUT_SETUP_NEWLY = 11;
    [Token(Token = "0x400B276")]
    private const int PIN_INPUT_SETUP_NEWLY_DIALOG = 20;
    [Token(Token = "0x400B277")]
    private const int PIN_OUTPUT_SETUP_NEWLY_DIALOG = 21;
    [Token(Token = "0x400B278")]
    private const int PIN_INPUT_SETUP_FOUND_DIALOG = 30;
    [Token(Token = "0x400B279")]
    private const int PIN_OUTPUT_SETUP_FOUND_DIALOG = 31;
    [Token(Token = "0x400B27A")]
    private const int PIN_INPUT_CLEAR_BUY_HOTDEAL = 40;
    [Token(Token = "0x400B27B")]
    private const int PIN_OUTPUT_CLEAR_BUY_HOTDEAL = 41;
    [Token(Token = "0x400B27C")]
    private const int PIN_OUTPUT_OPEN_DIALOG = 200;
    [Token(Token = "0x400B27D")]
    private const int PIN_OUTPUT_ONCLICK_BUY = 300;
    [Token(Token = "0x400B27E")]
    [FieldOffset(Offset = "0x0")]
    private static HotDealManager instance;
    [Token(Token = "0x400B27F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private HotDeal_BannerList m_HotDealBannerList;
    [Token(Token = "0x400B280")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private HotDeal_Dialog m_HotDealDialog;
    [Token(Token = "0x400B281")]
    [FieldOffset(Offset = "0x14")]
    private HotDealData m_HotDealData;

    [Token(Token = "0x170017EF")]
    public static HotDealManager Instance
    {
      [Token(Token = "0x600AA7B"), Address(RVA = "0x6DF720", Offset = "0x6DE520", VA = "0x106DF720")] get
      {
        return (HotDealManager) null;
      }
    }

    [Token(Token = "0x600AA7C")]
    [Address(RVA = "0x6DECA0", Offset = "0x6DDAA0", VA = "0x106DECA0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AA7D")]
    [Address(RVA = "0x6DF320", Offset = "0x6DE120", VA = "0x106DF320")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x170017F0")]
    public HotDealData HotDealData
    {
      [Token(Token = "0x600AA7E"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (HotDealData) null;
      }
    }

    [Token(Token = "0x600AA7F")]
    [Address(RVA = "0x6DE910", Offset = "0x6DD710", VA = "0x106DE910", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AA80")]
    [Address(RVA = "0x6DE8F0", Offset = "0x6DD6F0", VA = "0x106DE8F0")]
    public void ActivatedOpenDialog()
    {
    }

    [Token(Token = "0x600AA81")]
    [Address(RVA = "0x6DE8D0", Offset = "0x6DD6D0", VA = "0x106DE8D0")]
    public void ActivatedBuyCoin()
    {
    }

    [Token(Token = "0x600AA82")]
    [Address(RVA = "0x6DF360", Offset = "0x6DE160", VA = "0x106DF360")]
    private static int PriceCompare(HotDealInfo a, HotDealInfo b) => new int();

    [Token(Token = "0x600AA83")]
    [Address(RVA = "0x6DF620", Offset = "0x6DE420", VA = "0x106DF620")]
    private static int SortOrderCompare(HotDealInfo a, HotDealInfo b) => new int();

    [Token(Token = "0x600AA84")]
    [Address(RVA = "0x6DF4D0", Offset = "0x6DE2D0", VA = "0x106DF4D0")]
    private void SetupNewlySlideList()
    {
    }

    [Token(Token = "0x600AA85")]
    [Address(RVA = "0x6DF0C0", Offset = "0x6DDEC0", VA = "0x106DF0C0")]
    private void DiaLogOpen(bool is_newly)
    {
    }

    [Token(Token = "0x600AA86")]
    [Address(RVA = "0x6DF1C0", Offset = "0x6DDFC0", VA = "0x106DF1C0")]
    private void ListOpen()
    {
    }

    [Token(Token = "0x600AA87")]
    [Address(RVA = "0x6DF3D0", Offset = "0x6DE1D0", VA = "0x106DF3D0")]
    private void SetupHotDealBannerList()
    {
    }

    [Token(Token = "0x600AA88")]
    [Address(RVA = "0x6DF150", Offset = "0x6DDF50", VA = "0x106DF150")]
    public List<BuyCoinRewardItemParam> GetHotDealProductRewardList(string buycoin_product_iname)
    {
      return (List<BuyCoinRewardItemParam>) null;
    }

    [Token(Token = "0x600AA89")]
    [Address(RVA = "0x6DED20", Offset = "0x6DDB20", VA = "0x106DED20")]
    public List<RewardListItem> CreateItemIcon(HotDealInfo m_info, RewardListItem listItem)
    {
      return (List<RewardListItem>) null;
    }

    [Token(Token = "0x600AA8A")]
    [Address(RVA = "0x6DF010", Offset = "0x6DDE10", VA = "0x106DF010")]
    private BuyCoinRewardItemParam CreateReward_Coin(PaymentManager.Product payment_product)
    {
      return (BuyCoinRewardItemParam) null;
    }

    [Token(Token = "0x600AA8B")]
    [Address(RVA = "0x6DF660", Offset = "0x6DE460", VA = "0x106DF660")]
    public HotDealManager()
    {
    }
  }
}
