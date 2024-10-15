// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SwitchBuyShopType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200131A")]
  [FlowNode.Pin(12, "PIN_OUTPUT_COLLABO", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(15, "PIN_OUTPUT_HOTDEAL", FlowNode.PinTypes.Output, 15)]
  [FlowNode.Pin(11, "PIN_OUTPUT_LIMITED", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(10, "PIN_OUTPUT_COIN", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(13, "PIN_OUTPUT_EXPANSION", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(14, "PIN_OUTPUT_FGG", FlowNode.PinTypes.Output, 14)]
  [FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(16, "PIN_OUTPUT_STEPUP", FlowNode.PinTypes.Output, 16)]
  [FlowNode.Pin(17, "PIN_OUTPUT_FREE1", FlowNode.PinTypes.Output, 17)]
  [FlowNode.Pin(18, "PIN_OUTPUT_FREE2", FlowNode.PinTypes.Output, 18)]
  [FlowNode.Pin(19, "PIN_OUTPUT_FREE3", FlowNode.PinTypes.Output, 19)]
  [FlowNode.Pin(100, "PIN_OUTPUT_DEFAULT", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1000, "PIN_OUTPUT_UNKNOWN", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.NodeType("BuyCoin/BuyShopType", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_SwitchBuyShopType : FlowNode
  {
    [Token(Token = "0x40046DF")]
    private const int PIN_INPUT = 0;
    [Token(Token = "0x40046E0")]
    private const int PIN_OUTPUT_COIN = 10;
    [Token(Token = "0x40046E1")]
    private const int PIN_OUTPUT_LIMITED = 11;
    [Token(Token = "0x40046E2")]
    private const int PIN_OUTPUT_COLLABO = 12;
    [Token(Token = "0x40046E3")]
    private const int PIN_OUTPUT_EXPANSION = 13;
    [Token(Token = "0x40046E4")]
    private const int PIN_OUTPUT_FGG = 14;
    [Token(Token = "0x40046E5")]
    private const int PIN_OUTPUT_HOTDEAL = 15;
    [Token(Token = "0x40046E6")]
    private const int PIN_OUTPUT_STEPUP = 16;
    [Token(Token = "0x40046E7")]
    private const int PIN_OUTPUT_FREE1 = 17;
    [Token(Token = "0x40046E8")]
    private const int PIN_OUTPUT_FREE2 = 18;
    [Token(Token = "0x40046E9")]
    private const int PIN_OUTPUT_FREE3 = 19;
    [Token(Token = "0x40046EA")]
    private const int PIN_OUTPUT_DEFAULT = 100;
    [Token(Token = "0x40046EB")]
    private const int PIN_OUTPUT_UNKNOWN = 1000;

    [Token(Token = "0x600508C")]
    [Address(RVA = "0x1263A00", Offset = "0x1262800", VA = "0x11263A00", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600508D")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SwitchBuyShopType()
    {
    }
  }
}
