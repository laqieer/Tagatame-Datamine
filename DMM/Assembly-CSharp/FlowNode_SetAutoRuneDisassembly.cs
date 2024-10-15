// Decompiled with JetBrains decompiler
// Type: FlowNode_SetAutoRuneDisassembly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000238")]
[FlowNode.Pin(1, "On", FlowNode.PinTypes.Input, 1)]
[FlowNode.Pin(100, "Out", FlowNode.PinTypes.Output, 100)]
[FlowNode.ShowInInspector]
[AddComponentMenu("")]
[FlowNode.NodeType("Rune/AutoRuneDisassembly/SetAutoRuneDisassembly", 32741)]
[FlowNode.Pin(2, "Off", FlowNode.PinTypes.Input, 2)]
public class FlowNode_SetAutoRuneDisassembly : FlowNode
{
  [Token(Token = "0x4000989")]
  private const int PIN_IN_ON = 1;
  [Token(Token = "0x400098A")]
  private const int PIN_IN_OFF = 2;
  [Token(Token = "0x400098B")]
  private const int PIN_OUT_END = 100;

  [Token(Token = "0x6000BCA")]
  [Address(RVA = "0x107EF30", Offset = "0x107DD30", VA = "0x1107EF30", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000BCB")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_SetAutoRuneDisassembly()
  {
  }
}
