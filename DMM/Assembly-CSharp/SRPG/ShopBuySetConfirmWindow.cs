// Decompiled with JetBrains decompiler
// Type: SRPG.ShopBuySetConfirmWindow
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
  [Token(Token = "0x2002A92")]
  [FlowNode.Pin(11, "Slider Minus", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(100, "武具詳細情報セット(in)", FlowNode.PinTypes.Input, 100)]
  [AddComponentMenu("UI/ShopBuySetConfirmWindow")]
  [FlowNode.Pin(10, "Slider Plus", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(101, "武具詳細情報セット(out)", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  public class ShopBuySetConfirmWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CF4C")]
    private const int PINID_REFRESH = 1;
    [Token(Token = "0x400CF4D")]
    private const int PINID_SLIDER_PLUS = 10;
    [Token(Token = "0x400CF4E")]
    private const int PINID_SLIDER_MINUS = 11;
    [Token(Token = "0x400CF4F")]
    private const int PINID_ARTIFACT_DETAIL_SET_INPUT = 100;
    [Token(Token = "0x400CF50")]
    private const int PINID_ARTIFACT_DETAIL_SET_OUTPUT = 101;
    [Token(Token = "0x400CF51")]
    [FieldOffset(Offset = "0xC")]
    [Description("リストアイテムとして使用するゲームオブジェクト")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400CF52")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemParent;
    [Token(Token = "0x400CF53")]
    [FieldOffset(Offset = "0x14")]
    public GameObject ItemWindow;
    [Token(Token = "0x400CF54")]
    [FieldOffset(Offset = "0x18")]
    public GameObject ArtifactWindow;
    [Token(Token = "0x400CF55")]
    [FieldOffset(Offset = "0x1C")]
    private List<ShopSetItemListElement> shop_item_set_list;
    [Token(Token = "0x400CF56")]
    [FieldOffset(Offset = "0x20")]
    public StatusList ArtifactStatus;
    [Token(Token = "0x400CF57")]
    [FieldOffset(Offset = "0x24")]
    private ArtifactParam mArtifactParam;
    [Token(Token = "0x400CF58")]
    [FieldOffset(Offset = "0x28")]
    private bool mIsShowArtifactJob;
    [Token(Token = "0x400CF59")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject ArtifactAbility;
    [Token(Token = "0x400CF5A")]
    [FieldOffset(Offset = "0x30")]
    public Animator ArtifactAbilityAnimation;
    [Token(Token = "0x400CF5B")]
    [FieldOffset(Offset = "0x34")]
    public string AbilityListItemState;
    [Token(Token = "0x400CF5C")]
    [FieldOffset(Offset = "0x38")]
    public int AbilityListItem_Hidden;
    [Token(Token = "0x400CF5D")]
    [FieldOffset(Offset = "0x3C")]
    public int AbilityListItem_Unlocked;
    [Token(Token = "0x400CF5E")]
    [FieldOffset(Offset = "0x40")]
    public Text AmountNum;
    [Token(Token = "0x400CF5F")]
    [FieldOffset(Offset = "0x44")]
    public GameObject Sold;
    [Token(Token = "0x400CF60")]
    [FieldOffset(Offset = "0x48")]
    [Space(20f)]
    public GameObject ItemAmountSliderHolder;
    [Token(Token = "0x400CF61")]
    [FieldOffset(Offset = "0x4C")]
    public Slider ItemAmountSlider;
    [Token(Token = "0x400CF62")]
    [FieldOffset(Offset = "0x50")]
    public Text ItemAmountSliderNum;
    [Token(Token = "0x400CF63")]
    [FieldOffset(Offset = "0x54")]
    public Button ItemIncrementButton;
    [Token(Token = "0x400CF64")]
    [FieldOffset(Offset = "0x58")]
    public Button ItemDecrementButton;
    [Token(Token = "0x400CF65")]
    [FieldOffset(Offset = "0x5C")]
    [Space(20f)]
    public GameObject ArtifactAmountSliderHolder;
    [Token(Token = "0x400CF66")]
    [FieldOffset(Offset = "0x60")]
    public Slider ArtifactAmountSlider;
    [Token(Token = "0x400CF67")]
    [FieldOffset(Offset = "0x64")]
    public Text ArtifactAmountSliderNum;
    [Token(Token = "0x400CF68")]
    [FieldOffset(Offset = "0x68")]
    public Button ArtifactIncrementButton;
    [Token(Token = "0x400CF69")]
    [FieldOffset(Offset = "0x6C")]
    public Button ArtifactDecrementButton;
    [Token(Token = "0x400CF6A")]
    [FieldOffset(Offset = "0x70")]
    [Space(20f)]
    public Text LimitedItemPriceText;
    [Token(Token = "0x400CF6B")]
    [FieldOffset(Offset = "0x74")]
    [HeaderBar("▼セット効果確認用のボタン")]
    [SerializeField]
    private Button m_SetEffectsButton;
    [Token(Token = "0x400CF6C")]
    [FieldOffset(Offset = "0x78")]
    private GameObject AmountSliderHolder;
    [Token(Token = "0x400CF6D")]
    [FieldOffset(Offset = "0x7C")]
    private Slider AmountSlider;
    [Token(Token = "0x400CF6E")]
    [FieldOffset(Offset = "0x80")]
    private Text AmountSliderNum;
    [Token(Token = "0x400CF6F")]
    [FieldOffset(Offset = "0x84")]
    private Button IncrementButton;
    [Token(Token = "0x400CF70")]
    [FieldOffset(Offset = "0x88")]
    private Button DecrementButton;
    [Token(Token = "0x400CF71")]
    [FieldOffset(Offset = "0x8C")]
    private bool mEnabledSlider;
    [Token(Token = "0x400CF72")]
    [FieldOffset(Offset = "0x90")]
    private ShopItem mShopitem;
    [Token(Token = "0x400CF73")]
    [FieldOffset(Offset = "0x94")]
    [HeaderBar("▼特商法対応")]
    public GameObject JemConfirmItemParent;
    [Token(Token = "0x400CF74")]
    [FieldOffset(Offset = "0x98")]
    public GameObject JemWarningItemTxt;
    [Token(Token = "0x400CF75")]
    [FieldOffset(Offset = "0x9C")]
    public GameObject JemConfirmgArtifactParent;
    [Token(Token = "0x400CF76")]
    [FieldOffset(Offset = "0xA0")]
    public GameObject JemWarningArtifactTxt;
    [Token(Token = "0x400CF77")]
    [FieldOffset(Offset = "0xA4")]
    public GameObject TimeLimitParent;
    [Token(Token = "0x400CF78")]
    [FieldOffset(Offset = "0xA8")]
    public Text TimeLimit;
    [Token(Token = "0x400CF79")]
    [FieldOffset(Offset = "0xAC")]
    public GameObject UsePaymentCointText;

    [Token(Token = "0x600C262")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C263")]
    [Address(RVA = "0x8AA7B0", Offset = "0x8A95B0", VA = "0x108AA7B0")]
    private void Start()
    {
    }

    [Token(Token = "0x600C264")]
    [Address(RVA = "0x8A91D0", Offset = "0x8A7FD0", VA = "0x108A91D0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C265")]
    [Address(RVA = "0x8A96C0", Offset = "0x8A84C0", VA = "0x108A96C0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C266")]
    [Address(RVA = "0x8A9370", Offset = "0x8A8170", VA = "0x108A9370")]
    private void RefreshSlider()
    {
    }

    [Token(Token = "0x600C267")]
    [Address(RVA = "0x8AA730", Offset = "0x8A9530", VA = "0x108AA730")]
    public void ShowJobList()
    {
    }

    [Token(Token = "0x600C268")]
    [Address(RVA = "0x500530", Offset = "0x4FF330", VA = "0x10500530")]
    public void CloseJobList()
    {
    }

    [Token(Token = "0x600C269")]
    [Address(RVA = "0x716CE0", Offset = "0x715AE0", VA = "0x10716CE0")]
    private void IncrementSliderValue()
    {
    }

    [Token(Token = "0x600C26A")]
    [Address(RVA = "0x716C90", Offset = "0x715A90", VA = "0x10716C90")]
    private void DecrementSliderValue()
    {
    }

    [Token(Token = "0x600C26B")]
    [Address(RVA = "0x718100", Offset = "0x716F00", VA = "0x10718100")]
    private void SetSliderValue(float newValue)
    {
    }

    [Token(Token = "0x600C26C")]
    [Address(RVA = "0x8AA670", Offset = "0x8A9470", VA = "0x108AA670")]
    private void SetArtifactDetailData()
    {
    }

    [Token(Token = "0x600C26D")]
    [Address(RVA = "0x716D30", Offset = "0x715B30", VA = "0x10716D30")]
    private void OnSliderValueChanged(float newValue)
    {
    }

    [Token(Token = "0x600C26E")]
    [Address(RVA = "0x8AA7C0", Offset = "0x8A95C0", VA = "0x108AA7C0")]
    public void UpdateBuyAmount()
    {
    }

    [Token(Token = "0x600C26F")]
    [Address(RVA = "0x8AA870", Offset = "0x8A9670", VA = "0x108AA870")]
    public ShopBuySetConfirmWindow()
    {
    }
  }
}
