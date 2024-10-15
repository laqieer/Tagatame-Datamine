// Decompiled with JetBrains decompiler
// Type: SRPG.EventShopBuySetConfirmWindow
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
  [Token(Token = "0x2002382")]
  [FlowNode.Pin(101, "武具詳細情報セット(out)", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "武具詳細情報セット(in)", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(11, "Slider Minus", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(10, "Slider Plus", FlowNode.PinTypes.Input, 10)]
  [AddComponentMenu("UI/EventShopBuySetConfirmWindow")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  public class EventShopBuySetConfirmWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009FFC")]
    private const int PINID_REFRESH = 1;
    [Token(Token = "0x4009FFD")]
    private const int PINID_SLIDER_PLUS = 10;
    [Token(Token = "0x4009FFE")]
    private const int PINID_SLIDER_MINUS = 11;
    [Token(Token = "0x4009FFF")]
    private const int PINID_ARTIFACT_DETAIL_SET_INPUT = 100;
    [Token(Token = "0x400A000")]
    private const int PINID_ARTIFACT_DETAIL_SET_OUTPUT = 101;
    [Token(Token = "0x400A001")]
    [FieldOffset(Offset = "0xC")]
    [Description("リストアイテムとして使用するゲームオブジェクト")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400A002")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemParent;
    [Token(Token = "0x400A003")]
    [FieldOffset(Offset = "0x14")]
    public GameObject ItemWindow;
    [Token(Token = "0x400A004")]
    [FieldOffset(Offset = "0x18")]
    public GameObject ArtifactWindow;
    [Token(Token = "0x400A005")]
    [FieldOffset(Offset = "0x1C")]
    private List<EventShopSetItemListElement> event_shop_item_set_list;
    [Token(Token = "0x400A006")]
    [FieldOffset(Offset = "0x20")]
    public StatusList ArtifactStatus;
    [Token(Token = "0x400A007")]
    [FieldOffset(Offset = "0x24")]
    private ArtifactParam mArtifactParam;
    [Token(Token = "0x400A008")]
    [FieldOffset(Offset = "0x28")]
    private bool mIsShowArtifactJob;
    [Token(Token = "0x400A009")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject ArtifactAbility;
    [Token(Token = "0x400A00A")]
    [FieldOffset(Offset = "0x30")]
    public Animator ArtifactAbilityAnimation;
    [Token(Token = "0x400A00B")]
    [FieldOffset(Offset = "0x34")]
    public string AbilityListItemState;
    [Token(Token = "0x400A00C")]
    [FieldOffset(Offset = "0x38")]
    public int AbilityListItem_Hidden;
    [Token(Token = "0x400A00D")]
    [FieldOffset(Offset = "0x3C")]
    public int AbilityListItem_Unlocked;
    [Token(Token = "0x400A00E")]
    [FieldOffset(Offset = "0x40")]
    public Text AmountNum;
    [Token(Token = "0x400A00F")]
    [FieldOffset(Offset = "0x44")]
    public GameObject Sold;
    [Token(Token = "0x400A010")]
    [FieldOffset(Offset = "0x48")]
    [Space(20f)]
    public GameObject ItemAmountSliderHolder;
    [Token(Token = "0x400A011")]
    [FieldOffset(Offset = "0x4C")]
    public Slider ItemAmountSlider;
    [Token(Token = "0x400A012")]
    [FieldOffset(Offset = "0x50")]
    public Text ItemAmountSliderNum;
    [Token(Token = "0x400A013")]
    [FieldOffset(Offset = "0x54")]
    public Button ItemIncrementButton;
    [Token(Token = "0x400A014")]
    [FieldOffset(Offset = "0x58")]
    public Button ItemDecrementButton;
    [Token(Token = "0x400A015")]
    [FieldOffset(Offset = "0x5C")]
    [Space(20f)]
    public GameObject ArtifactAmountSliderHolder;
    [Token(Token = "0x400A016")]
    [FieldOffset(Offset = "0x60")]
    public Slider ArtifactAmountSlider;
    [Token(Token = "0x400A017")]
    [FieldOffset(Offset = "0x64")]
    public Text ArtifactAmountSliderNum;
    [Token(Token = "0x400A018")]
    [FieldOffset(Offset = "0x68")]
    public Button ArtifactIncrementButton;
    [Token(Token = "0x400A019")]
    [FieldOffset(Offset = "0x6C")]
    public Button ArtifactDecrementButton;
    [Token(Token = "0x400A01A")]
    [FieldOffset(Offset = "0x70")]
    [Space(20f)]
    public Text LimitedItemPriceText;
    [Token(Token = "0x400A01B")]
    [FieldOffset(Offset = "0x74")]
    [HeaderBar("▼セット効果確認用のボタン")]
    [SerializeField]
    private Button m_SetEffectsButton;
    [Token(Token = "0x400A01C")]
    [FieldOffset(Offset = "0x78")]
    private GameObject AmountSliderHolder;
    [Token(Token = "0x400A01D")]
    [FieldOffset(Offset = "0x7C")]
    private Slider AmountSlider;
    [Token(Token = "0x400A01E")]
    [FieldOffset(Offset = "0x80")]
    private Text AmountSliderNum;
    [Token(Token = "0x400A01F")]
    [FieldOffset(Offset = "0x84")]
    private Button IncrementButton;
    [Token(Token = "0x400A020")]
    [FieldOffset(Offset = "0x88")]
    private Button DecrementButton;
    [Token(Token = "0x400A021")]
    [FieldOffset(Offset = "0x8C")]
    private bool mEnabledSlider;
    [Token(Token = "0x400A022")]
    [FieldOffset(Offset = "0x90")]
    private EventShopItem mShopitem;

    [Token(Token = "0x600997A")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600997B")]
    [Address(RVA = "0x5DB7B0", Offset = "0x5DA5B0", VA = "0x105DB7B0")]
    private void Start()
    {
    }

    [Token(Token = "0x600997C")]
    [Address(RVA = "0x5DA0E0", Offset = "0x5D8EE0", VA = "0x105DA0E0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600997D")]
    [Address(RVA = "0x5DA340", Offset = "0x5D9140", VA = "0x105DA340")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600997E")]
    [Address(RVA = "0x5DB730", Offset = "0x5DA530", VA = "0x105DB730")]
    public void ShowJobList()
    {
    }

    [Token(Token = "0x600997F")]
    [Address(RVA = "0x500530", Offset = "0x4FF330", VA = "0x10500530")]
    public void CloseJobList()
    {
    }

    [Token(Token = "0x6009980")]
    [Address(RVA = "0x5DA2D0", Offset = "0x5D90D0", VA = "0x105DA2D0")]
    private void IncrementSliderValue()
    {
    }

    [Token(Token = "0x6009981")]
    [Address(RVA = "0x5DA280", Offset = "0x5D9080", VA = "0x105DA280")]
    private void DecrementSliderValue()
    {
    }

    [Token(Token = "0x6009982")]
    [Address(RVA = "0x5DB500", Offset = "0x5DA300", VA = "0x105DB500")]
    private void SetSliderValue(float newValue)
    {
    }

    [Token(Token = "0x6009983")]
    [Address(RVA = "0x5DB440", Offset = "0x5DA240", VA = "0x105DB440")]
    private void SetArtifactDetailData()
    {
    }

    [Token(Token = "0x6009984")]
    [Address(RVA = "0x5DA320", Offset = "0x5D9120", VA = "0x105DA320")]
    private void OnSliderValueChanged(float newValue)
    {
    }

    [Token(Token = "0x6009985")]
    [Address(RVA = "0x5DB7C0", Offset = "0x5DA5C0", VA = "0x105DB7C0")]
    public void UpdateBuyAmount()
    {
    }

    [Token(Token = "0x6009986")]
    [Address(RVA = "0x5DB870", Offset = "0x5DA670", VA = "0x105DB870")]
    public EventShopBuySetConfirmWindow()
    {
    }
  }
}
