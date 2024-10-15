// Decompiled with JetBrains decompiler
// Type: FlowNode_ToggleChange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000224")]
[AddComponentMenu("")]
[FlowNode.NodeType("Event/ToggleChange", 58751)]
[FlowNode.Pin(1, "enable", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(2, "disable", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(10, "enable", FlowNode.PinTypes.Output, 0)]
[FlowNode.Pin(11, "disable", FlowNode.PinTypes.Output, 0)]
public class FlowNode_ToggleChange : FlowNode
{
  [Token(Token = "0x4000957")]
  private const int PIN_OUT_ENABLE = 10;
  [Token(Token = "0x4000958")]
  private const int PIN_OUT_DISABLE = 11;
  [Token(Token = "0x4000959")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.ShowInInfo]
  [FlowNode.DropTarget(typeof (Toggle), true)]
  public Toggle Target;

  [Token(Token = "0x6000B93")]
  [Address(RVA = "0x10806F0", Offset = "0x107F4F0", VA = "0x110806F0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B94")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_ToggleChange()
  {
  }
}
