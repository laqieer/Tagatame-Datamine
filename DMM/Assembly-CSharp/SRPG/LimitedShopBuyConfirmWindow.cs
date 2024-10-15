// Decompiled with JetBrains decompiler
// Type: SRPG.LimitedShopBuyConfirmWindow
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
  [Token(Token = "0x20026C4")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Slider Plus", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(11, "Slider Minus", FlowNode.PinTypes.Input, 11)]
  [AddComponentMenu("UI/LimitedShopBuyConfirmWindow")]
  public class LimitedShopBuyConfirmWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B5DA")]
    private const int PINID_REFRESH = 1;
    [Token(Token = "0x400B5DB")]
    private const int PINID_SLIDER_PLUS = 10;
    [Token(Token = "0x400B5DC")]
    private const int PINID_SLIDER_MINUS = 11;
    [Token(Token = "0x400B5DD")]
    [FieldOffset(Offset = "0xC")]
    public GameObject limited_item;
    [Token(Token = "0x400B5DE")]
    [FieldOffset(Offset = "0x10")]
    public GameObject no_limited_item;
    [Token(Token = "0x400B5DF")]
    [FieldOffset(Offset = "0x14")]
    public GameObject Sold;
    [Token(Token = "0x400B5E0")]
    [FieldOffset(Offset = "0x18")]
    public Text SoldNum;
    [Token(Token = "0x400B5E1")]
    [FieldOffset(Offset = "0x1C")]
    public Text TextDesc;
    [Token(Token = "0x400B5E2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject HasCount;
    [Token(Token = "0x400B5E3")]
    [FieldOffset(Offset = "0x24")]
    [HeaderBar("▼アイコン表示用オブジェクト")]
    public GameObject ItemIconRoot;
    [Token(Token = "0x400B5E4")]
    [FieldOffset(Offset = "0x28")]
    public GameObject ConceptCardIconRoot;
    [Token(Token = "0x400B5E5")]
    [FieldOffset(Offset = "0x2C")]
    public ShopBuyConfirmCrystal CrystalIconRoot;
    [Token(Token = "0x400B5E6")]
    [FieldOffset(Offset = "0x30")]
    [HeaderBar("▼右側の表示領域")]
    public GameObject LayoutRight;
    [Token(Token = "0x400B5E7")]
    [FieldOffset(Offset = "0x34")]
    public GameObject EnableEquipUnitWindow;
    [Token(Token = "0x400B5E8")]
    [FieldOffset(Offset = "0x38")]
    public RectTransform UnitLayoutParent;
    [Token(Token = "0x400B5E9")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject UnitTemplate;
    [Token(Token = "0x400B5EA")]
    [FieldOffset(Offset = "0x40")]
    public GameObject ConceptCardDetail;
    [Token(Token = "0x400B5EB")]
    [FieldOffset(Offset = "0x44")]
    [HeaderBar("▼まとめ買い用")]
    public GameObject AmountSliderHolder;
    [Token(Token = "0x400B5EC")]
    [FieldOffset(Offset = "0x48")]
    public Slider AmountSlider;
    [Token(Token = "0x400B5ED")]
    [FieldOffset(Offset = "0x4C")]
    public Text AmountSliderNum;
    [Token(Token = "0x400B5EE")]
    [FieldOffset(Offset = "0x50")]
    public Button IncrementButton;
    [Token(Token = "0x400B5EF")]
    [FieldOffset(Offset = "0x54")]
    public Button DecrementButton;
    [Token(Token = "0x400B5F0")]
    [FieldOffset(Offset = "0x58")]
    public Text LimitedItemPriceText;
    [Token(Token = "0x400B5F1")]
    [FieldOffset(Offset = "0x5C")]
    [HeaderBar("▼所持 幻晶石/ゼニー等")]
    public GameObject HasJem;
    [Token(Token = "0x400B5F2")]
    [FieldOffset(Offset = "0x60")]
    public GameObject HasCoin;
    [Token(Token = "0x400B5F3")]
    [FieldOffset(Offset = "0x64")]
    public GameObject HasZenny;
    [Token(Token = "0x400B5F4")]
    [FieldOffset(Offset = "0x68")]
    [Space(20f)]
    private List<GameObject> mUnits;
    [Token(Token = "0x400B5F5")]
    [FieldOffset(Offset = "0x6C")]
    private bool mEnabledSlider;
    [Token(Token = "0x400B5F6")]
    [FieldOffset(Offset = "0x70")]
    private LimitedShopItem mShopitem;
    [Token(Token = "0x400B5F7")]
    [FieldOffset(Offset = "0x74")]
    [HeaderBar("▼特商法対応")]
    public GameObject JemConfrimTxt;
    [Token(Token = "0x400B5F8")]
    [FieldOffset(Offset = "0x78")]
    public GameObject JemWarningTxt;
    [Token(Token = "0x400B5F9")]
    [FieldOffset(Offset = "0x7C")]
    public GameObject TimeLimitParent;
    [Token(Token = "0x400B5FA")]
    [FieldOffset(Offset = "0x80")]
    public Text TimeLimit;
    [Token(Token = "0x400B5FB")]
    [FieldOffset(Offset = "0x84")]
    public GameObject UsePaymentCointText;

    [Token(Token = "0x600AD81")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AD82")]
    [Address(RVA = "0x715BB0", Offset = "0x7149B0", VA = "0x10715BB0")]
    private void Start()
    {
    }

    [Token(Token = "0x600AD83")]
    [Address(RVA = "0x714770", Offset = "0x713570", VA = "0x10714770", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AD84")]
    [Address(RVA = "0x714F10", Offset = "0x713D10", VA = "0x10714F10")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600AD85")]
    [Address(RVA = "0x7148F0", Offset = "0x7136F0", VA = "0x107148F0")]
    private void RefreshEnableEquipUnitWindow(List<UnitData> units)
    {
    }

    [Token(Token = "0x600AD86")]
    [Address(RVA = "0x714BD0", Offset = "0x7139D0", VA = "0x10714BD0")]
    private void RefreshSlider()
    {
    }

    [Token(Token = "0x600AD87")]
    [Address(RVA = "0x714880", Offset = "0x713680", VA = "0x10714880")]
    private void IncrementSliderValue()
    {
    }

    [Token(Token = "0x600AD88")]
    [Address(RVA = "0x714830", Offset = "0x713630", VA = "0x10714830")]
    private void DecrementSliderValue()
    {
    }

    [Token(Token = "0x600AD89")]
    [Address(RVA = "0x715990", Offset = "0x714790", VA = "0x10715990")]
    private void SetSliderValue(float newValue)
    {
    }

    [Token(Token = "0x600AD8A")]
    [Address(RVA = "0x7148D0", Offset = "0x7136D0", VA = "0x107148D0")]
    private void OnSliderValueChanged(float newValue)
    {
    }

    [Token(Token = "0x600AD8B")]
    [Address(RVA = "0x715D10", Offset = "0x714B10", VA = "0x10715D10")]
    public void UpdateBuyAmount()
    {
    }

    [Token(Token = "0x600AD8C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LimitedShopBuyConfirmWindow()
    {
    }
  }
}
