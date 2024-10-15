// Decompiled with JetBrains decompiler
// Type: FlowNode_Random
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000206")]
[FlowNode.Pin(1003, "<= CompareValue", FlowNode.PinTypes.Output, 1003)]
[FlowNode.NodeType("Common/Random", 32741)]
[FlowNode.Pin(100, "Do", FlowNode.PinTypes.Input, 100)]
[AddComponentMenu("")]
[FlowNode.Pin(1005, ">= CompareValue", FlowNode.PinTypes.Output, 1005)]
[FlowNode.Pin(1004, "> CompareValue", FlowNode.PinTypes.Output, 1004)]
[FlowNode.Pin(101, "CompareLastResult", FlowNode.PinTypes.Input, 101)]
[FlowNode.Pin(1002, "< CompareValue", FlowNode.PinTypes.Output, 1002)]
[FlowNode.Pin(1001, "!= CompareValue", FlowNode.PinTypes.Output, 1001)]
[FlowNode.Pin(1000, "== CompareValue", FlowNode.PinTypes.Output, 1000)]
public class FlowNode_Random : FlowNode
{
  [Token(Token = "0x40008E8")]
  [FieldOffset(Offset = "0x18")]
  public int DivValue;
  [Token(Token = "0x40008E9")]
  [FieldOffset(Offset = "0x1C")]
  public int CompareValue;
  [Token(Token = "0x40008EA")]
  [FieldOffset(Offset = "0x0")]
  private static uint sLastResult;
  [Token(Token = "0x40008EB")]
  [FieldOffset(Offset = "0x20")]
  private RandXorshift mRand;

  [Token(Token = "0x6000B54")]
  [Address(RVA = "0x107DBB0", Offset = "0x107C9B0", VA = "0x1107DBB0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B55")]
  [Address(RVA = "0x107DB00", Offset = "0x107C900", VA = "0x1107DB00")]
  private void CheckResult(uint result)
  {
  }

  [Token(Token = "0x6000B56")]
  [Address(RVA = "0x107DD20", Offset = "0x107CB20", VA = "0x1107DD20")]
  public FlowNode_Random()
  {
  }
}
