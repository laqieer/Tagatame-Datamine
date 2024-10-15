// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_IsUnLookedHotDeal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001313")]
  [FlowNode.NodeType("HotDeal/IsUnLookedHotDeal", 32741)]
  [FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(11, "off", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  [FlowNode.Pin(10, "on", FlowNode.PinTypes.Output, 10)]
  public class FlowNode_IsUnLookedHotDeal : FlowNode
  {
    [Token(Token = "0x40046D0")]
    private const int PIN_INPUT = 0;
    [Token(Token = "0x40046D1")]
    private const int PIN_OUTPUT_ON = 10;
    [Token(Token = "0x40046D2")]
    private const int PIN_OUTPUT_OFF = 11;

    [Token(Token = "0x600507B")]
    [Address(RVA = "0x124FF50", Offset = "0x124ED50", VA = "0x1124FF50", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600507C")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_IsUnLookedHotDeal()
    {
    }
  }
}
