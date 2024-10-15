// Decompiled with JetBrains decompiler
// Type: FlowNode_Count
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001CE")]
[FlowNode.Pin(1, "Count Up", FlowNode.PinTypes.Input, 1)]
[AddComponentMenu("")]
[FlowNode.Pin(100, "Finished", FlowNode.PinTypes.Output, 100)]
[FlowNode.Pin(2, "Reset", FlowNode.PinTypes.Input, 2)]
[FlowNode.NodeType("Common/Count", 32741)]
public class FlowNode_Count : FlowNode
{
  [Token(Token = "0x400083C")]
  [FieldOffset(Offset = "0x18")]
  public int Count;
  [Token(Token = "0x400083D")]
  [FieldOffset(Offset = "0x1C")]
  private int mCount;
  [Token(Token = "0x400083E")]
  [FieldOffset(Offset = "0x20")]
  public bool AutoReset;

  [Token(Token = "0x6000A81")]
  [Address(RVA = "0xF48A70", Offset = "0xF47870", VA = "0x10F48A70", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000A82")]
  [Address(RVA = "0xF48AC0", Offset = "0xF478C0", VA = "0x10F48AC0")]
  public FlowNode_Count()
  {
  }
}
