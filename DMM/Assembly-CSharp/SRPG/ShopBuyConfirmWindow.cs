// Decompiled with JetBrains decompiler
// Type: SRPG.ShopBuyConfirmWindow
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
  [Token(Token = "0x2002A8E")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Slider Plus", FlowNode.PinTypes.Input, 10)]
  [AddComponentMenu("UI/ShopBuyConfirmWindow")]
  [FlowNode.Pin(11, "Slider Minus", FlowNode.PinTypes.Input, 11)]
  public class ShopBuyConfirmWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CF0B")]
    private const int PINID_REFRESH = 1;
    [Token(Token = "0x400CF0C")]
    private const int PINID_SLIDER_PLUS = 10;
    [Token(Token = "0x400CF0D")]
    private const int PINID_SLIDER_MINUS = 11;
    [Token(Token = "0x400CF0E")]
    [FieldOffset(Offset = "0xC")]
    public GameObject limited_item;
    [Token(Token = "0x400CF0F")]
    [FieldOffset(Offset = "0x10")]
    public GameObject no_limited_item;
    [Token(Token = "0x400CF10")]
    [FieldOffset(Offset = "0x14")]
    public GameObject Sold;
    [Token(Token = "0x400CF11")]
    [FieldOffset(Offset = "0x18")]
    public Text SoldNum;
    [Token(Token = "0x400CF12")]
    [FieldOffset(Offset = "0x1C")]
    public Text TextDesc;
    [Token(Token = "0x400CF13")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject HasCount;
    [Token(Token = "0x400CF14")]
    [FieldOffset(Offset = "0x24")]
    [HeaderBar("▼アイコン表示用オブジェクト")]
    public GameObject ItemIconRoot;
    [Token(Token = "0x400CF15")]
    [FieldOffset(Offset = "0x28")]
    public GameObject ConceptCardIconRoot;
    [Token(Token = "0x400CF16")]
    [FieldOffset(Offset = "0x2C")]
    public ShopBuyConfirmCrystal CrystalIconRoot;
    [Token(Token = "0x400CF17")]
    [FieldOffset(Offset = "0x30")]
    [HeaderBar("▼右側の表示領域")]
    public GameObject LayoutRight;
    [Token(Token = "0x400CF18")]
    [FieldOffset(Offset = "0x34")]
    public GameObject EnableEquipUnitWindow;
    [Token(Token = "0x400CF19")]
    [FieldOffset(Offset = "0x38")]
    public RectTransform UnitLayoutParent;
    [Token(Token = "0x400CF1A")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject UnitTemplate;
    [Token(Token = "0x400CF1B")]
    [FieldOffset(Offset = "0x40")]
    public GameObject ConceptCardDetail;
    [Token(Token = "0x400CF1C")]
    [FieldOffset(Offset = "0x44")]
    [HeaderBar("▼まとめ買い用")]
    public GameObject AmountSliderHolder;
    [Token(Token = "0x400CF1D")]
    [FieldOffset(Offset = "0x48")]
    public Slider AmountSlider;
    [Token(Token = "0x400CF1E")]
    [FieldOffset(Offset = "0x4C")]
    public Text AmountSliderNum;
    [Token(Token = "0x400CF1F")]
    [FieldOffset(Offset = "0x50")]
    public Button IncrementButton;
    [Token(Token = "0x400CF20")]
    [FieldOffset(Offset = "0x54")]
    public Button DecrementButton;
    [Token(Token = "0x400CF21")]
    [FieldOffset(Offset = "0x58")]
    public Text LimitedItemPriceText;
    [Token(Token = "0x400CF22")]
    [FieldOffset(Offset = "0x5C")]
    [HeaderBar("▼所持 幻晶石/ゼニー等")]
    public GameObject HasJem;
    [Token(Token = "0x400CF23")]
    [FieldOffset(Offset = "0x60")]
    public GameObject HasCoin;
    [Token(Token = "0x400CF24")]
    [FieldOffset(Offset = "0x64")]
    public GameObject HasZenny;
    [Token(Token = "0x400CF25")]
    [FieldOffset(Offset = "0x68")]
    [Space(20f)]
    private List<GameObject> mUnits;
    [Token(Token = "0x400CF26")]
    [FieldOffset(Offset = "0x6C")]
    private bool mEnabledSlider;
    [Token(Token = "0x400CF27")]
    [FieldOffset(Offset = "0x70")]
    private ShopItem mShopitem;
    [Token(Token = "0x400CF28")]
    [FieldOffset(Offset = "0x74")]
    [HeaderBar("▼特商法対応")]
    public GameObject JemConfrimTxt;
    [Token(Token = "0x400CF29")]
    [FieldOffset(Offset = "0x78")]
    public GameObject JemWarningTxt;
    [Token(Token = "0x400CF2A")]
    [FieldOffset(Offset = "0x7C")]
    public GameObject TimeLimitParent;
    [Token(Token = "0x400CF2B")]
    [FieldOffset(Offset = "0x80")]
    public Text TimeLimit;
    [Token(Token = "0x400CF2C")]
    [FieldOffset(Offset = "0x84")]
    public GameObject UsePaymentCointText;

    [Token(Token = "0x600C24B")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C24C")]
    [Address(RVA = "0x8A8610", Offset = "0x8A7410", VA = "0x108A8610")]
    private void Start()
    {
    }

    [Token(Token = "0x600C24D")]
    [Address(RVA = "0x8A7560", Offset = "0x8A6360", VA = "0x108A7560", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C24E")]
    [Address(RVA = "0x8A7C00", Offset = "0x8A6A00", VA = "0x108A7C00")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C24F")]
    [Address(RVA = "0x8A78C0", Offset = "0x8A66C0", VA = "0x108A78C0")]
    private void RefreshSlider()
    {
    }

    [Token(Token = "0x600C250")]
    [Address(RVA = "0x8A7620", Offset = "0x8A6420", VA = "0x108A7620")]
    private void RefreshEnableEquipUnitWindow(List<UnitData> units)
    {
    }

    [Token(Token = "0x600C251")]
    [Address(RVA = "0x714880", Offset = "0x713680", VA = "0x10714880")]
    private void IncrementSliderValue()
    {
    }

    [Token(Token = "0x600C252")]
    [Address(RVA = "0x714830", Offset = "0x713630", VA = "0x10714830")]
    private void DecrementSliderValue()
    {
    }

    [Token(Token = "0x600C253")]
    [Address(RVA = "0x715990", Offset = "0x714790", VA = "0x10715990")]
    private void SetSliderValue(float newValue)
    {
    }

    [Token(Token = "0x600C254")]
    [Address(RVA = "0x7148D0", Offset = "0x7136D0", VA = "0x107148D0")]
    private void OnSliderValueChanged(float newValue)
    {
    }

    [Token(Token = "0x600C255")]
    [Address(RVA = "0x8A8770", Offset = "0x8A7570", VA = "0x108A8770")]
    public void UpdateBuyAmount()
    {
    }

    [Token(Token = "0x600C256")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ShopBuyConfirmWindow()
    {
    }
  }
}
