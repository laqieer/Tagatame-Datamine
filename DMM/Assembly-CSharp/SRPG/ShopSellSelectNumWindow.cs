// Decompiled with JetBrains decompiler
// Type: SRPG.ShopSellSelectNumWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AA7")]
  [FlowNode.Pin(100, "決定", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(101, "キャンセル", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/ShopSellSelectNumWindow")]
  public class ShopSellSelectNumWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CFE6")]
    [FieldOffset(Offset = "0xC")]
    public Text TxtTitle;
    [Token(Token = "0x400CFE7")]
    [FieldOffset(Offset = "0x10")]
    public Text TxtSellItemPriceStr;
    [Token(Token = "0x400CFE8")]
    [FieldOffset(Offset = "0x14")]
    public Text TxtSellNumStr;
    [Token(Token = "0x400CFE9")]
    [FieldOffset(Offset = "0x18")]
    public Text TxtSellTotalPriceStr;
    [Token(Token = "0x400CFEA")]
    [FieldOffset(Offset = "0x1C")]
    public Text TxtDecide;
    [Token(Token = "0x400CFEB")]
    [FieldOffset(Offset = "0x20")]
    public Slider SellNumSlider;
    [Token(Token = "0x400CFEC")]
    [FieldOffset(Offset = "0x24")]
    public Button BtnDecide;
    [Token(Token = "0x400CFED")]
    [FieldOffset(Offset = "0x28")]
    public Button BtnCancel;
    [Token(Token = "0x400CFEE")]
    [FieldOffset(Offset = "0x2C")]
    public Button BtnPlus;
    [Token(Token = "0x400CFEF")]
    [FieldOffset(Offset = "0x30")]
    public Button BtnMinus;
    [Token(Token = "0x400CFF0")]
    [FieldOffset(Offset = "0x34")]
    private int mSaveSellNum;

    [Token(Token = "0x600C2C1")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C2C2")]
    [Address(RVA = "0x8B19A0", Offset = "0x8B07A0", VA = "0x108B19A0")]
    private void Start()
    {
    }

    [Token(Token = "0x600C2C3")]
    [Address(RVA = "0x8B1100", Offset = "0x8AFF00", VA = "0x108B1100", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C2C4")]
    [Address(RVA = "0x8B1120", Offset = "0x8AFF20", VA = "0x108B1120")]
    private void OnAddNum()
    {
    }

    [Token(Token = "0x600C2C5")]
    [Address(RVA = "0x8B13F0", Offset = "0x8B01F0", VA = "0x108B13F0")]
    private void OnRemoveNum()
    {
    }

    [Token(Token = "0x600C2C6")]
    [Address(RVA = "0x8B1550", Offset = "0x8B0350", VA = "0x108B1550")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C2C7")]
    [Address(RVA = "0x8B14B0", Offset = "0x8B02B0", VA = "0x108B14B0")]
    private void OnSellNumChanged(float value)
    {
    }

    [Token(Token = "0x600C2C8")]
    [Address(RVA = "0x8B12B0", Offset = "0x8B00B0", VA = "0x108B12B0")]
    private void OnDecide()
    {
    }

    [Token(Token = "0x600C2C9")]
    [Address(RVA = "0x8B1240", Offset = "0x8B0040", VA = "0x108B1240")]
    private void OnCancel()
    {
    }

    [Token(Token = "0x600C2CA")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ShopSellSelectNumWindow()
    {
    }
  }
}
