// Decompiled with JetBrains decompiler
// Type: FlowNode_Output
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001FE")]
[FlowNode.NodeType("Event/Output", 32741)]
[FlowNode.Pin(1, "", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(10, "", FlowNode.PinTypes.Output, 10)]
[AddComponentMenu("")]
public class FlowNode_Output : FlowNode
{
  [Token(Token = "0x40008C0")]
  [FieldOffset(Offset = "0x18")]
  public string PinName;
  [Token(Token = "0x40008C1")]
  [FieldOffset(Offset = "0x1C")]
  [NonSerialized]
  public FlowNode_ExternalLink TargetNode;
  [Token(Token = "0x40008C2")]
  [FieldOffset(Offset = "0x20")]
  [NonSerialized]
  public int TargetPinID;

  [Token(Token = "0x6000B3C")]
  [Address(RVA = "0x107CD40", Offset = "0x107BB40", VA = "0x1107CD40", Slot = "10")]
  public override string GetCaption() => (string) null;

  [Token(Token = "0x6000B3D")]
  [Address(RVA = "0x107CD90", Offset = "0x107BB90", VA = "0x1107CD90", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B3E")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_Output()
  {
  }
}
