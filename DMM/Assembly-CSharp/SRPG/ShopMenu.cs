// Decompiled with JetBrains decompiler
// Type: SRPG.ShopMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F21")]
  [FlowNode.Pin(4, "魂の交換所", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(1, "通常ショップ", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "秘密の店", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "コイン交換所", FlowNode.PinTypes.Input, 3)]
  [AddComponentMenu("/ShopMenu")]
  public class ShopMenu : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008300")]
    [FieldOffset(Offset = "0xC")]
    public Button ShopButton;
    [Token(Token = "0x4008301")]
    [FieldOffset(Offset = "0x10")]
    public Button GuerrillaShopButton;
    [Token(Token = "0x4008302")]
    [FieldOffset(Offset = "0x14")]
    public Button LimitedShopButton;
    [Token(Token = "0x4008303")]
    [FieldOffset(Offset = "0x18")]
    public Button CoinShopButton;
    [Token(Token = "0x4008304")]
    [FieldOffset(Offset = "0x1C")]
    public Button KakeraShopButton;
    [Token(Token = "0x4008305")]
    [FieldOffset(Offset = "0x20")]
    [Space(10f)]
    public GameObject ActiveShop;
    [Token(Token = "0x4008306")]
    [FieldOffset(Offset = "0x24")]
    public GameObject ActiveGuerrilla;
    [Token(Token = "0x4008307")]
    [FieldOffset(Offset = "0x28")]
    public GameObject ActiveLimited;
    [Token(Token = "0x4008308")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject ActiveCoin;
    [Token(Token = "0x4008309")]
    [FieldOffset(Offset = "0x30")]
    public GameObject ActiveKakera;
    [Token(Token = "0x400830A")]
    [FieldOffset(Offset = "0x34")]
    public GameObject GuerrillaBallon;

    [Token(Token = "0x6007F5C")]
    [Address(RVA = "0x411810", Offset = "0x410610", VA = "0x10411810", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6007F5D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ShopMenu()
    {
    }
  }
}
