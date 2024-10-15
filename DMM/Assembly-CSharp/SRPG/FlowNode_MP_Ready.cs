// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_Ready
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017E2")]
  [FlowNode.NodeType("MultiPlay/Room/Ready", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(103, "Change to Edit", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(102, "Change to Wait", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "Change to Ready", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(104, "Change to Select floor", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(3, "Edit", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "Wait", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Ready", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "Select Floor", FlowNode.PinTypes.Input, 11)]
  public class FlowNode_MP_Ready : FlowNode
  {
    [Token(Token = "0x4005601")]
    private const int PIN_IN_READY = 1;
    [Token(Token = "0x4005602")]
    private const int PIN_IN_WAIT = 2;
    [Token(Token = "0x4005603")]
    private const int PIN_IN_EDIT = 3;
    [Token(Token = "0x4005604")]
    private const int PIN_IN_MT_FLOOR_SELECT = 11;
    [Token(Token = "0x4005605")]
    private const int PIN_OUT_CHANGED_TO_READY = 101;
    [Token(Token = "0x4005606")]
    private const int PIN_OUT_CHANGED_TO_WAIT = 102;
    [Token(Token = "0x4005607")]
    private const int PIN_OUT_CHANGED_TO_EDIT = 103;
    [Token(Token = "0x4005608")]
    private const int PIN_OUT_CHANGED_TO_FLOOR_SELECT = 104;

    [Token(Token = "0x60060BC")]
    [Address(RVA = "0x1359B70", Offset = "0x1358970", VA = "0x11359B70", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60060BD")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_Ready()
    {
    }
  }
}
