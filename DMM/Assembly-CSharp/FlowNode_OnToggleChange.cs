// Decompiled with JetBrains decompiler
// Type: FlowNode_OnToggleChange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20001F9")]
[AddComponentMenu("")]
[FlowNode.NodeType("Event/OnToggleChange", 58751)]
[FlowNode.Pin(1, "Enable", FlowNode.PinTypes.Output, 1)]
[FlowNode.Pin(2, "Disable", FlowNode.PinTypes.Output, 2)]
public class FlowNode_OnToggleChange : FlowNodePersistent
{
  [Token(Token = "0x400089E")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.ShowInInfo]
  [FlowNode.DropTarget(typeof (Toggle), true)]
  public Toggle Target;

  [Token(Token = "0x6000B22")]
  [Address(RVA = "0x107AF70", Offset = "0x1079D70", VA = "0x1107AF70")]
  private void Start()
  {
  }

  [Token(Token = "0x6000B23")]
  [Address(RVA = "0x107AF50", Offset = "0x1079D50", VA = "0x1107AF50")]
  private void OnValueChanged(bool value)
  {
  }

  [Token(Token = "0x6000B24")]
  [Address(RVA = "0x107AF10", Offset = "0x1079D10", VA = "0x1107AF10", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B25")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_OnToggleChange()
  {
  }
}
