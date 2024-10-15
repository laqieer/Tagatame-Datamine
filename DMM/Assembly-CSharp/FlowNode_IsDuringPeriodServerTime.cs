// Decompiled with JetBrains decompiler
// Type: FlowNode_IsDuringPeriodServerTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001E6")]
[FlowNode.NodeType("Timer/IsDuringPeriodServerTime", 16755200)]
[FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(10, "true", FlowNode.PinTypes.Output, 10)]
[FlowNode.Pin(11, "false", FlowNode.PinTypes.Output, 11)]
[AddComponentMenu("")]
public class FlowNode_IsDuringPeriodServerTime : FlowNode
{
  [Token(Token = "0x4000883")]
  public const int PIN_INPUT = 0;
  [Token(Token = "0x4000884")]
  public const int PIN_TRUE = 10;
  [Token(Token = "0x4000885")]
  public const int PIN_FALSE = 11;
  [Token(Token = "0x4000886")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private string mStartTime;
  [Token(Token = "0x4000887")]
  [FieldOffset(Offset = "0x1C")]
  [SerializeField]
  private string mEndTime;

  [Token(Token = "0x6000AE8")]
  [Address(RVA = "0xF4E980", Offset = "0xF4D780", VA = "0x10F4E980", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000AE9")]
  [Address(RVA = "0xF4E8A0", Offset = "0xF4D6A0", VA = "0x10F4E8A0", Slot = "6")]
  public override string[] GetInfoLines() => (string[]) null;

  [Token(Token = "0x6000AEA")]
  [Address(RVA = "0xF4EBB0", Offset = "0xF4D9B0", VA = "0x10F4EBB0")]
  public FlowNode_IsDuringPeriodServerTime()
  {
  }
}
