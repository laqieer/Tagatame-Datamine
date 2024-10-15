// Decompiled with JetBrains decompiler
// Type: SRPG.LimitedShopBuySetConfirmWindow
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
  [Token(Token = "0x20026C7")]
  [FlowNode.Pin(100, "武具詳細情報セット(in)", FlowNode.PinTypes.Input, 100)]
  [AddComponentMenu("UI/LimitedShopBuySetConfirmWindow")]
  [FlowNode.Pin(101, "武具詳細情報セット(out)", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(11, "Slider Minus", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Slider Plus", FlowNode.PinTypes.Input, 10)]
  public class LimitedShopBuySetConfirmWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B61C")]
    private const int PINID_REFRESH = 1;
    [Token(Token = "0x400B61D")]
    private const int PINID_SLIDER_PLUS = 10;
    [Token(Token = "0x400B61E")]
    private const int PINID_SLIDER_MINUS = 11;
    [Token(Token = "0x400B61F")]
    private const int PINID_ARTIFACT_DETAIL_SET_INPUT = 100;
    [Token(Token = "0x400B620")]
    private const int PINID_ARTIFACT_DETAIL_SET_OUTPUT = 101;
    [Token(Token = "0x400B621")]
    [FieldOffset(Offset = "0xC")]
    [Description("リストアイテムとして使用するゲームオブジェクト")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400B622")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemParent;
    [Token(Token = "0x400B623")]
    [FieldOffset(Offset = "0x14")]
    public GameObject ItemWindow;
    [Token(Token = "0x400B624")]
    [FieldOffset(Offset = "0x18")]
    public GameObject ArtifactWindow;
    [Token(Token = "0x400B625")]
    [FieldOffset(Offset = "0x1C")]
    private List<LimitedShopSetItemListElement> limited_shop_item_set_list;
    [Token(Token = "0x400B626")]
    [FieldOffset(Offset = "0x20")]
    public StatusList ArtifactStatus;
    [Token(Token = "0x400B627")]
    [FieldOffset(Offset = "0x24")]
    private ArtifactParam mArtifactParam;
    [Token(Token = "0x400B628")]
    [FieldOffset(Offset = "0x28")]
    private bool mIsShowArtifactJob;
    [Token(Token = "0x400B629")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject ArtifactAbility;
    [Token(Token = "0x400B62A")]
    [FieldOffset(Offset = "0x30")]
    public Animator ArtifactAbilityAnimation;
    [Token(Token = "0x400B62B")]
    [FieldOffset(Offset = "0x34")]
    public string AbilityListItemState;
    [Token(Token = "0x400B62C")]
    [FieldOffset(Offset = "0x38")]
    public int AbilityListItem_Hidden;
    [Token(Token = "0x400B62D")]
    [FieldOffset(Offset = "0x3C")]
    public int AbilityListItem_Unlocked;
    [Token(Token = "0x400B62E")]
    [FieldOffset(Offset = "0x40")]
    public Text AmountNum;
    [Token(Token = "0x400B62F")]
    [FieldOffset(Offset = "0x44")]
    public GameObject Sold;
    [Token(Token = "0x400B630")]
    [FieldOffset(Offset = "0x48")]
    [Space(20f)]
    public GameObject ItemAmountSliderHolder;
    [Token(Token = "0x400B631")]
    [FieldOffset(Offset = "0x4C")]
    public Slider ItemAmountSlider;
    [Token(Token = "0x400B632")]
    [FieldOffset(Offset = "0x50")]
    public Text ItemAmountSliderNum;
    [Token(Token = "0x400B633")]
    [FieldOffset(Offset = "0x54")]
    public Button ItemIncrementButton;
    [Token(Token = "0x400B634")]
    [FieldOffset(Offset = "0x58")]
    public Button ItemDecrementButton;
    [Token(Token = "0x400B635")]
    [FieldOffset(Offset = "0x5C")]
    [Space(20f)]
    public GameObject ArtifactAmountSliderHolder;
    [Token(Token = "0x400B636")]
    [FieldOffset(Offset = "0x60")]
    public Slider ArtifactAmountSlider;
    [Token(Token = "0x400B637")]
    [FieldOffset(Offset = "0x64")]
    public Text ArtifactAmountSliderNum;
    [Token(Token = "0x400B638")]
    [FieldOffset(Offset = "0x68")]
    public Button ArtifactIncrementButton;
    [Token(Token = "0x400B639")]
    [FieldOffset(Offset = "0x6C")]
    public Button ArtifactDecrementButton;
    [Token(Token = "0x400B63A")]
    [FieldOffset(Offset = "0x70")]
    [Space(20f)]
    public Text LimitedItemPriceText;
    [Token(Token = "0x400B63B")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    [HeaderBar("▼セット効果確認用のボタン")]
    private Button m_SetEffectsButton;
    [Token(Token = "0x400B63C")]
    [FieldOffset(Offset = "0x78")]
    private GameObject AmountSliderHolder;
    [Token(Token = "0x400B63D")]
    [FieldOffset(Offset = "0x7C")]
    private Slider AmountSlider;
    [Token(Token = "0x400B63E")]
    [FieldOffset(Offset = "0x80")]
    private Text AmountSliderNum;
    [Token(Token = "0x400B63F")]
    [FieldOffset(Offset = "0x84")]
    private Button IncrementButton;
    [Token(Token = "0x400B640")]
    [FieldOffset(Offset = "0x88")]
    private Button DecrementButton;
    [Token(Token = "0x400B641")]
    [FieldOffset(Offset = "0x8C")]
    private bool mEnabledSlider;
    [Token(Token = "0x400B642")]
    [FieldOffset(Offset = "0x90")]
    private LimitedShopItem mShopitem;
    [Token(Token = "0x400B643")]
    [FieldOffset(Offset = "0x94")]
    [HeaderBar("▼特商法対応")]
    public GameObject JemConfirmItemParent;
    [Token(Token = "0x400B644")]
    [FieldOffset(Offset = "0x98")]
    public GameObject JemWarningItemTxt;
    [Token(Token = "0x400B645")]
    [FieldOffset(Offset = "0x9C")]
    public GameObject JemConfirmgArtifactParent;
    [Token(Token = "0x400B646")]
    [FieldOffset(Offset = "0xA0")]
    public GameObject JemWarningArtifactTxt;
    [Token(Token = "0x400B647")]
    [FieldOffset(Offset = "0xA4")]
    public GameObject TimeLimitParent;
    [Token(Token = "0x400B648")]
    [FieldOffset(Offset = "0xA8")]
    public Text TimeLimit;
    [Token(Token = "0x400B649")]
    [FieldOffset(Offset = "0xAC")]
    public GameObject UsePaymentCointText;

    [Token(Token = "0x600AD9A")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AD9B")]
    [Address(RVA = "0x7183B0", Offset = "0x7171B0", VA = "0x107183B0")]
    private void Start()
    {
    }

    [Token(Token = "0x600AD9C")]
    [Address(RVA = "0x716AF0", Offset = "0x7158F0", VA = "0x10716AF0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AD9D")]
    [Address(RVA = "0x7170B0", Offset = "0x715EB0", VA = "0x107170B0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600AD9E")]
    [Address(RVA = "0x718330", Offset = "0x717130", VA = "0x10718330")]
    public void ShowJobList()
    {
    }

    [Token(Token = "0x600AD9F")]
    [Address(RVA = "0x500530", Offset = "0x4FF330", VA = "0x10500530")]
    public void CloseJobList()
    {
    }

    [Token(Token = "0x600ADA0")]
    [Address(RVA = "0x716D50", Offset = "0x715B50", VA = "0x10716D50")]
    private void RefreshSlider()
    {
    }

    [Token(Token = "0x600ADA1")]
    [Address(RVA = "0x716CE0", Offset = "0x715AE0", VA = "0x10716CE0")]
    private void IncrementSliderValue()
    {
    }

    [Token(Token = "0x600ADA2")]
    [Address(RVA = "0x716C90", Offset = "0x715A90", VA = "0x10716C90")]
    private void DecrementSliderValue()
    {
    }

    [Token(Token = "0x600ADA3")]
    [Address(RVA = "0x718100", Offset = "0x716F00", VA = "0x10718100")]
    private void SetSliderValue(float newValue)
    {
    }

    [Token(Token = "0x600ADA4")]
    [Address(RVA = "0x718040", Offset = "0x716E40", VA = "0x10718040")]
    private void SetArtifactDetailData()
    {
    }

    [Token(Token = "0x600ADA5")]
    [Address(RVA = "0x716D30", Offset = "0x715B30", VA = "0x10716D30")]
    private void OnSliderValueChanged(float newValue)
    {
    }

    [Token(Token = "0x600ADA6")]
    [Address(RVA = "0x7183C0", Offset = "0x7171C0", VA = "0x107183C0")]
    public void UpdateBuyAmount()
    {
    }

    [Token(Token = "0x600ADA7")]
    [Address(RVA = "0x718470", Offset = "0x717270", VA = "0x10718470")]
    public LimitedShopBuySetConfirmWindow()
    {
    }
  }
}
