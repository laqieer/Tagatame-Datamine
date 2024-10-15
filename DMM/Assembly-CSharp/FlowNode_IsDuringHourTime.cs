// Decompiled with JetBrains decompiler
// Type: FlowNode_IsDuringHourTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001E5")]
[FlowNode.NodeType("Timer/IsDuringHourTime", 16755200)]
[FlowNode.Pin(10, "true", FlowNode.PinTypes.Output, 10)]
[FlowNode.Pin(11, "false", FlowNode.PinTypes.Output, 11)]
[AddComponentMenu("")]
[FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
public class FlowNode_IsDuringHourTime : FlowNode
{
  [Token(Token = "0x400087E")]
  public const int PIN_INPUT = 0;
  [Token(Token = "0x400087F")]
  public const int PIN_TRUE = 10;
  [Token(Token = "0x4000880")]
  public const int PIN_FALSE = 11;
  [Token(Token = "0x4000881")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private string mStartTime;
  [Token(Token = "0x4000882")]
  [FieldOffset(Offset = "0x1C")]
  [SerializeField]
  private string mEndTime;

  [Token(Token = "0x6000AE5")]
  [Address(RVA = "0xF4E550", Offset = "0xF4D350", VA = "0x10F4E550", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000AE6")]
  [Address(RVA = "0xF4E4A0", Offset = "0xF4D2A0", VA = "0x10F4E4A0", Slot = "6")]
  public override string[] GetInfoLines() => (string[]) null;

  [Token(Token = "0x6000AE7")]
  [Address(RVA = "0xF4E800", Offset = "0xF4D600", VA = "0x10F4E800")]
  public FlowNode_IsDuringHourTime()
  {
  }
}
