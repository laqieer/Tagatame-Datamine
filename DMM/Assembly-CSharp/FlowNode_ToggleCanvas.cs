// Decompiled with JetBrains decompiler
// Type: FlowNode_ToggleCanvas
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000222")]
[AddComponentMenu("")]
[FlowNode.NodeType("Toggle/Canvas", 32741)]
[FlowNode.Pin(0, "Out", FlowNode.PinTypes.Output, 999)]
[FlowNode.Pin(1, "Turn On", FlowNode.PinTypes.Input, 5)]
[FlowNode.Pin(2, "Turn Off", FlowNode.PinTypes.Input, 6)]
public class FlowNode_ToggleCanvas : FlowNode
{
  [Token(Token = "0x6000B8F")]
  [Address(RVA = "0x10805B0", Offset = "0x107F3B0", VA = "0x110805B0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B90")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_ToggleCanvas()
  {
  }
}
