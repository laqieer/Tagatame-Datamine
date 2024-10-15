// Decompiled with JetBrains decompiler
// Type: SRPG.UnitPieceShopBuyConfirmWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002CDC")]
  [FlowNode.Pin(11, "Slider Minus", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Slider Plus", FlowNode.PinTypes.Input, 10)]
  [AddComponentMenu("UI/UnitPieceShopBuyConfirmWindow")]
  public class UnitPieceShopBuyConfirmWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DEF4")]
    private const int PINID_REFRESH = 1;
    [Token(Token = "0x400DEF5")]
    private const int PINID_SLIDER_PLUS = 10;
    [Token(Token = "0x400DEF6")]
    private const int PINID_SLIDER_MINUS = 11;
    [Token(Token = "0x400DEF7")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text m_SoldText;
    [Token(Token = "0x400DEF8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text m_DescriptionText;
    [Token(Token = "0x400DEF9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject HasCount;
    [Token(Token = "0x400DEFA")]
    [FieldOffset(Offset = "0x18")]
    [HeaderBar("▼アイコン表示用オブジェクト")]
    [SerializeField]
    private GameObject m_ItemIconRoot;
    [Token(Token = "0x400DEFB")]
    [FieldOffset(Offset = "0x1C")]
    [HeaderBar("▼まとめ買い用")]
    [SerializeField]
    private GameObject m_AmountSliderHolder;
    [Token(Token = "0x400DEFC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Slider m_AmountSlider;
    [Token(Token = "0x400DEFD")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text m_AmountNum;
    [Token(Token = "0x400DEFE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button m_IncrementButton;
    [Token(Token = "0x400DEFF")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button m_DecrementButton;
    [Token(Token = "0x400DF00")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text m_ItemPriceText;
    [Token(Token = "0x400DF01")]
    [FieldOffset(Offset = "0x34")]
    [HeaderBar("▼所持コイン")]
    [SerializeField]
    private GameObject HasCoin;
    [Token(Token = "0x400DF02")]
    [FieldOffset(Offset = "0x38")]
    private bool mEnabledSlider;
    [Token(Token = "0x400DF03")]
    [FieldOffset(Offset = "0x3C")]
    private UnitPieceShopItem mShopitem;

    [Token(Token = "0x600D0C4")]
    [Address(RVA = "0x9BD140", Offset = "0x9BBF40", VA = "0x109BD140")]
    private void Start()
    {
    }

    [Token(Token = "0x600D0C5")]
    [Address(RVA = "0x9BC7A0", Offset = "0x9BB5A0", VA = "0x109BC7A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D0C6")]
    [Address(RVA = "0x9BC910", Offset = "0x9BB710", VA = "0x109BC910")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600D0C7")]
    [Address(RVA = "0x9BC8A0", Offset = "0x9BB6A0", VA = "0x109BC8A0")]
    private void IncrementSliderValue()
    {
    }

    [Token(Token = "0x600D0C8")]
    [Address(RVA = "0x9BC850", Offset = "0x9BB650", VA = "0x109BC850")]
    private void DecrementSliderValue()
    {
    }

    [Token(Token = "0x600D0C9")]
    [Address(RVA = "0x9BCFB0", Offset = "0x9BBDB0", VA = "0x109BCFB0")]
    private void SetSliderValue(int newValue)
    {
    }

    [Token(Token = "0x600D0CA")]
    [Address(RVA = "0x9BC8F0", Offset = "0x9BB6F0", VA = "0x109BC8F0")]
    private void OnSliderValueChanged(float newValue)
    {
    }

    [Token(Token = "0x600D0CB")]
    [Address(RVA = "0x9BD150", Offset = "0x9BBF50", VA = "0x109BD150")]
    public void UpdateBuyAmount()
    {
    }

    [Token(Token = "0x600D0CC")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitPieceShopBuyConfirmWindow()
    {
    }
  }
}
