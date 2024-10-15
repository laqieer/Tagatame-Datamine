// Decompiled with JetBrains decompiler
// Type: FlowNode_Input
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001E2")]
[FlowNode.NodeType("Event/Input", 58751)]
[AddComponentMenu("")]
[FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 0)]
public class FlowNode_Input : FlowNode
{
  [Token(Token = "0x400087A")]
  [FieldOffset(Offset = "0x18")]
  public string PinName;

  [Token(Token = "0x6000ADD")]
  [Address(RVA = "0xF4E240", Offset = "0xF4D040", VA = "0x10F4E240", Slot = "10")]
  public override string GetCaption() => (string) null;

  [Token(Token = "0x6000ADE")]
  [Address(RVA = "0xF49830", Offset = "0xF48630", VA = "0x10F49830", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000ADF")]
  [Address(RVA = "0xF474B0", Offset = "0xF462B0", VA = "0x10F474B0")]
  public FlowNode_Input()
  {
  }
}
