// Decompiled with JetBrains decompiler
// Type: FlowNode_Log
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001EB")]
[FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 1)]
[FlowNode.NodeType("Debug/Log", 32741)]
[FlowNode.Pin(10, "Input", FlowNode.PinTypes.Input, 0)]
[AddComponentMenu("")]
public class FlowNode_Log : FlowNode
{
  [Token(Token = "0x400088D")]
  [FieldOffset(Offset = "0x18")]
  public string Value;

  [Token(Token = "0x6000AF2")]
  [Address(RVA = "0xF4F0E0", Offset = "0xF4DEE0", VA = "0x10F4F0E0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000AF3")]
  [Address(RVA = "0xF474B0", Offset = "0xF462B0", VA = "0x10F474B0")]
  public FlowNode_Log()
  {
  }
}
