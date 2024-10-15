// Decompiled with JetBrains decompiler
// Type: FlowNode_GetAutoRuneDisassembly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000236")]
[AddComponentMenu("")]
[FlowNode.NodeType("Rune/AutoRuneDisassembly/GetAutoRuneDisassembly", 32741)]
[FlowNode.Pin(1, "Check", FlowNode.PinTypes.Input, 1)]
[FlowNode.Pin(10, "有効", FlowNode.PinTypes.Output, 10)]
[FlowNode.Pin(11, "無効", FlowNode.PinTypes.Output, 11)]
[FlowNode.ShowInInspector]
public class FlowNode_GetAutoRuneDisassembly : FlowNode
{
  [Token(Token = "0x4000983")]
  private const int PIN_IN_CHECK = 1;
  [Token(Token = "0x4000984")]
  private const int PIN_OUT_ON = 10;
  [Token(Token = "0x4000985")]
  private const int PIN_OUT_OFF = 11;

  [Token(Token = "0x6000BC6")]
  [Address(RVA = "0x1079A50", Offset = "0x1078850", VA = "0x11079A50", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000BC7")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_GetAutoRuneDisassembly()
  {
  }
}
