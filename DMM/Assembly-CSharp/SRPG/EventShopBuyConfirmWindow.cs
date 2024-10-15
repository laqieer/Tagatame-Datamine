// Decompiled with JetBrains decompiler
// Type: SRPG.EventShopBuyConfirmWindow
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
  [Token(Token = "0x200237F")]
  [AddComponentMenu("UI/EventShopBuyConfirmWindow")]
  [FlowNode.Pin(11, "Slider Minus", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(10, "Slider Plus", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  public class EventShopBuyConfirmWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009FBF")]
    private const int PINID_REFRESH = 1;
    [Token(Token = "0x4009FC0")]
    private const int PINID_SLIDER_PLUS = 10;
    [Token(Token = "0x4009FC1")]
    private const int PINID_SLIDER_MINUS = 11;
    [Token(Token = "0x4009FC2")]
    [FieldOffset(Offset = "0xC")]
    public GameObject limited_item;
    [Token(Token = "0x4009FC3")]
    [FieldOffset(Offset = "0x10")]
    public GameObject no_limited_item;
    [Token(Token = "0x4009FC4")]
    [FieldOffset(Offset = "0x14")]
    public GameObject Sold;
    [Token(Token = "0x4009FC5")]
    [FieldOffset(Offset = "0x18")]
    public Text SoldNum;
    [Token(Token = "0x4009FC6")]
    [FieldOffset(Offset = "0x1C")]
    public Text TextDesc;
    [Token(Token = "0x4009FC7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject HasCount;
    [Token(Token = "0x4009FC8")]
    [FieldOffset(Offset = "0x24")]
    [HeaderBar("▼アイコン表示用オブジェクト")]
    public GameObject ItemIconRoot;
    [Token(Token = "0x4009FC9")]
    [FieldOffset(Offset = "0x28")]
    public GameObject ConceptCardIconRoot;
    [Token(Token = "0x4009FCA")]
    [FieldOffset(Offset = "0x2C")]
    public ShopBuyConfirmCrystal CrystalIconRoot;
    [Token(Token = "0x4009FCB")]
    [FieldOffset(Offset = "0x30")]
    [HeaderBar("▼右側の表示領域")]
    public GameObject LayoutRight;
    [Token(Token = "0x4009FCC")]
    [FieldOffset(Offset = "0x34")]
    public GameObject EnableEquipUnitWindow;
    [Token(Token = "0x4009FCD")]
    [FieldOffset(Offset = "0x38")]
    public RectTransform UnitLayoutParent;
    [Token(Token = "0x4009FCE")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject UnitTemplate;
    [Token(Token = "0x4009FCF")]
    [FieldOffset(Offset = "0x40")]
    public GameObject ConceptCardDetail;
    [Token(Token = "0x4009FD0")]
    [FieldOffset(Offset = "0x44")]
    [HeaderBar("▼まとめ買い用")]
    public GameObject AmountSliderHolder;
    [Token(Token = "0x4009FD1")]
    [FieldOffset(Offset = "0x48")]
    public Slider AmountSlider;
    [Token(Token = "0x4009FD2")]
    [FieldOffset(Offset = "0x4C")]
    public Text AmountSliderNum;
    [Token(Token = "0x4009FD3")]
    [FieldOffset(Offset = "0x50")]
    public Button IncrementButton;
    [Token(Token = "0x4009FD4")]
    [FieldOffset(Offset = "0x54")]
    public Button DecrementButton;
    [Token(Token = "0x4009FD5")]
    [FieldOffset(Offset = "0x58")]
    public Text LimitedItemPriceText;
    [Token(Token = "0x4009FD6")]
    [FieldOffset(Offset = "0x5C")]
    [HeaderBar("▼所持 幻晶石/ゼニー等")]
    public GameObject HasJem;
    [Token(Token = "0x4009FD7")]
    [FieldOffset(Offset = "0x60")]
    public GameObject HasCoin;
    [Token(Token = "0x4009FD8")]
    [FieldOffset(Offset = "0x64")]
    public GameObject HasZenny;
    [Token(Token = "0x4009FD9")]
    [FieldOffset(Offset = "0x68")]
    private List<GameObject> mUnits;
    [Token(Token = "0x4009FDA")]
    [FieldOffset(Offset = "0x6C")]
    private bool mEnabledSlider;
    [Token(Token = "0x4009FDB")]
    [FieldOffset(Offset = "0x70")]
    private EventShopItem mShopitem;

    [Token(Token = "0x6009962")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009963")]
    [Address(RVA = "0x5D9160", Offset = "0x5D7F60", VA = "0x105D9160")]
    private void Start()
    {
    }

    [Token(Token = "0x6009964")]
    [Address(RVA = "0x5D7DA0", Offset = "0x5D6BA0", VA = "0x105D7DA0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009965")]
    [Address(RVA = "0x5D7F20", Offset = "0x5D6D20", VA = "0x105D7F20")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6009966")]
    [Address(RVA = "0x5D7EB0", Offset = "0x5D6CB0", VA = "0x105D7EB0")]
    private void IncrementSliderValue()
    {
    }

    [Token(Token = "0x6009967")]
    [Address(RVA = "0x5D7E60", Offset = "0x5D6C60", VA = "0x105D7E60")]
    private void DecrementSliderValue()
    {
    }

    [Token(Token = "0x6009968")]
    [Address(RVA = "0x5D8F30", Offset = "0x5D7D30", VA = "0x105D8F30")]
    private void SetSliderValue(float newValue)
    {
    }

    [Token(Token = "0x6009969")]
    [Address(RVA = "0x5D7F00", Offset = "0x5D6D00", VA = "0x105D7F00")]
    private void OnSliderValueChanged(float newValue)
    {
    }

    [Token(Token = "0x600996A")]
    [Address(RVA = "0x5D9300", Offset = "0x5D8100", VA = "0x105D9300")]
    public void UpdateBuyAmount()
    {
    }

    [Token(Token = "0x600996B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public EventShopBuyConfirmWindow()
    {
    }
  }
}
