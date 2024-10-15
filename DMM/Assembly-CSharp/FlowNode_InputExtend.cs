// Decompiled with JetBrains decompiler
// Type: FlowNode_InputExtend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001E3")]
[FlowNode.NodeType("Event/InputExtend", 58751)]
[FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 0)]
[AddComponentMenu("")]
public class FlowNode_InputExtend : FlowNode
{
  [Token(Token = "0x400087B")]
  [FieldOffset(Offset = "0x18")]
  public string PinName;

  [Token(Token = "0x6000AE0")]
  [Address(RVA = "0xF4E1D0", Offset = "0xF4CFD0", VA = "0x10F4E1D0", Slot = "10")]
  public override string GetCaption() => (string) null;

  [Token(Token = "0x6000AE1")]
  [Address(RVA = "0xF4E220", Offset = "0xF4D020", VA = "0x10F4E220", Slot = "5")]
  public override void OnActivate(int pinID, SerializeValueList valueList)
  {
  }

  [Token(Token = "0x6000AE2")]
  [Address(RVA = "0xF474B0", Offset = "0xF462B0", VA = "0x10F474B0")]
  public FlowNode_InputExtend()
  {
  }
}
