// Decompiled with JetBrains decompiler
// Type: FlowNode_ToggleInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000227")]
[FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 0)]
[FlowNode.NodeType("Toggle/Input", 32741)]
[FlowNode.Pin(10, "Enable", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(11, "Disable", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(12, "Reset", FlowNode.PinTypes.Input, 0)]
[AddComponentMenu("")]
public class FlowNode_ToggleInput : FlowNode
{
  [Token(Token = "0x6000B99")]
  [Address(RVA = "0x1080A00", Offset = "0x107F800", VA = "0x11080A00", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B9A")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_ToggleInput()
  {
  }
}
