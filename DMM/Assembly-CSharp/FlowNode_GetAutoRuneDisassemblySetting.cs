// Decompiled with JetBrains decompiler
// Type: FlowNode_GetAutoRuneDisassemblySetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000237")]
[AddComponentMenu("")]
[FlowNode.ShowInInspector]
[FlowNode.Pin(10, "設定済み", FlowNode.PinTypes.Output, 10)]
[FlowNode.Pin(1, "Check", FlowNode.PinTypes.Input, 1)]
[FlowNode.Pin(11, "未設定", FlowNode.PinTypes.Output, 11)]
[FlowNode.NodeType("Rune/AutoRuneDisassembly/GetAutoRuneDisassemblySetting", 32741)]
public class FlowNode_GetAutoRuneDisassemblySetting : FlowNode
{
  [Token(Token = "0x4000986")]
  private const int PIN_IN_CHECK = 1;
  [Token(Token = "0x4000987")]
  private const int PIN_OUT_ON = 10;
  [Token(Token = "0x4000988")]
  private const int PIN_OUT_OFF = 11;

  [Token(Token = "0x6000BC8")]
  [Address(RVA = "0x1079810", Offset = "0x1078610", VA = "0x11079810", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000BC9")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_GetAutoRuneDisassemblySetting()
  {
  }
}
