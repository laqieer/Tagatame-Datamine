// Decompiled with JetBrains decompiler
// Type: SRPG.ShopExchangeCountWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A99")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Tab Element", FlowNode.PinTypes.Input, 10)]
  [AddComponentMenu("UI/ShopExchangeCountWindow")]
  [FlowNode.Pin(11, "Tab Rainbow", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(100, "Plus", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(101, "Minus", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(102, "Do Convert", FlowNode.PinTypes.Input, 102)]
  [FlowNode.Pin(1000, "Do Convert", FlowNode.PinTypes.Output, 1000)]
  public class ShopExchangeCountWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CF99")]
    private const int PIN_IN_REFRESH = 1;
    [Token(Token = "0x400CF9A")]
    private const int PIN_IN_TAB_CHANGE_ELEMENT = 10;
    [Token(Token = "0x400CF9B")]
    private const int PIN_IN_TAB_CHANGE_RAINBOW = 11;
    [Token(Token = "0x400CF9C")]
    private const int PIN_IN_BTN_PLUS = 100;
    [Token(Token = "0x400CF9D")]
    private const int PIN_IN_BTN_MINUS = 101;
    [Token(Token = "0x400CF9E")]
    private const int PIN_IN_BTN_DO_CONVERT = 102;
    [Token(Token = "0x400CF9F")]
    private const int PIN_OUT_BTN_DO_CONVERT = 1000;
    [Token(Token = "0x400CFA0")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject PieceIcon;
    [Token(Token = "0x400CFA1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject UnitIcon;
    [Token(Token = "0x400CFA2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Slider Slider;
    [Token(Token = "0x400CFA3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button PlusButton;
    [Token(Token = "0x400CFA4")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button MinusButton;
    [Token(Token = "0x400CFA5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button DecideButton;
    [Token(Token = "0x400CFA6")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text PieceNumText;
    [Token(Token = "0x400CFA7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text UnitNumText;
    [Token(Token = "0x400CFA8")]
    [FieldOffset(Offset = "0x2C")]
    private ShopExchangeCountWindow.PieceType mPieceType;
    [Token(Token = "0x400CFA9")]
    [FieldOffset(Offset = "0x30")]
    private int mConvertRate;
    [Token(Token = "0x400CFAA")]
    [FieldOffset(Offset = "0x34")]
    private int mSliderMaxValue;
    [Token(Token = "0x400CFAB")]
    [FieldOffset(Offset = "0x38")]
    private int mPieceCount;
    [Token(Token = "0x400CFAC")]
    [FieldOffset(Offset = "0x3C")]
    private int mMaxSliderValuer;
    [Token(Token = "0x400CFAD")]
    [FieldOffset(Offset = "0x40")]
    private int mElementSliderValue;
    [Token(Token = "0x400CFAE")]
    [FieldOffset(Offset = "0x44")]
    private int mRainbowSliderValue;
    [Token(Token = "0x400CFAF")]
    [FieldOffset(Offset = "0x48")]
    private string mSelectingPiece;
    [Token(Token = "0x400CFB0")]
    [FieldOffset(Offset = "0x4C")]
    private string mSelectingUnitPiece;

    [Token(Token = "0x600C28A")]
    [Address(RVA = "0x8AC430", Offset = "0x8AB230", VA = "0x108AC430", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C28B")]
    [Address(RVA = "0x8ACCE0", Offset = "0x8ABAE0", VA = "0x108ACCE0")]
    public void SliderOnValueChanged(float value)
    {
    }

    [Token(Token = "0x600C28C")]
    [Address(RVA = "0x8ACC80", Offset = "0x8ABA80", VA = "0x108ACC80")]
    private void SetUIInteractable(int val)
    {
    }

    [Token(Token = "0x600C28D")]
    [Address(RVA = "0x8AC8C0", Offset = "0x8AB6C0", VA = "0x108AC8C0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C28E")]
    [Address(RVA = "0x8AC5E0", Offset = "0x8AB3E0", VA = "0x108AC5E0")]
    private void AddSliderValue(int value)
    {
    }

    [Token(Token = "0x600C28F")]
    [Address(RVA = "0x8AC640", Offset = "0x8AB440", VA = "0x108AC640")]
    private void ChangeNumText(int value)
    {
    }

    [Token(Token = "0x600C290")]
    [Address(RVA = "0x8AC6C0", Offset = "0x8AB4C0", VA = "0x108AC6C0")]
    private void DoConvert()
    {
    }

    [Token(Token = "0x600C291")]
    [Address(RVA = "0x8AC7D0", Offset = "0x8AB5D0", VA = "0x108AC7D0")]
    private ItemParam ElementToItemParam(EElement element) => (ItemParam) null;

    [Token(Token = "0x600C292")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ShopExchangeCountWindow()
    {
    }

    [Token(Token = "0x2002A9A")]
    private enum PieceType
    {
      [Token(Token = "0x400CFB2")] Element,
      [Token(Token = "0x400CFB3")] Rainbow,
    }
  }
}
