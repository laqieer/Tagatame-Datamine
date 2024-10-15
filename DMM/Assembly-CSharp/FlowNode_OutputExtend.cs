// Decompiled with JetBrains decompiler
// Type: FlowNode_OutputExtend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001FF")]
[AddComponentMenu("")]
[FlowNode.Pin(10, "", FlowNode.PinTypes.Output, 10)]
[FlowNode.Pin(1, "", FlowNode.PinTypes.Input, 0)]
[FlowNode.NodeType("Event/OutputExtend", 32741)]
public class FlowNode_OutputExtend : FlowNode
{
  [Token(Token = "0x40008C3")]
  [FieldOffset(Offset = "0x18")]
  public string PinName;
  [Token(Token = "0x40008C4")]
  [FieldOffset(Offset = "0x1C")]
  [NonSerialized]
  public FlowNode_ExternalLink TargetNode;
  [Token(Token = "0x40008C5")]
  [FieldOffset(Offset = "0x20")]
  [NonSerialized]
  public int TargetPinID;

  [Token(Token = "0x6000B3F")]
  [Address(RVA = "0x107CC70", Offset = "0x107BA70", VA = "0x1107CC70", Slot = "10")]
  public override string GetCaption() => (string) null;

  [Token(Token = "0x6000B40")]
  [Address(RVA = "0x107CCC0", Offset = "0x107BAC0", VA = "0x1107CCC0", Slot = "5")]
  public override void OnActivate(int pinID, SerializeValueList valueList)
  {
  }

  [Token(Token = "0x6000B41")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_OutputExtend()
  {
  }
}
