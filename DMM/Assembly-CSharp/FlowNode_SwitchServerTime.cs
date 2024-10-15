// Decompiled with JetBrains decompiler
// Type: FlowNode_SwitchServerTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000220")]
[FlowNode.Pin(10, "Before", FlowNode.PinTypes.Output, 10)]
[AddComponentMenu("")]
[FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
[FlowNode.NodeType("Timer/SwitchServerTime", 32741)]
[FlowNode.Pin(11, "After", FlowNode.PinTypes.Output, 11)]
public class FlowNode_SwitchServerTime : FlowNode
{
  [Token(Token = "0x4000951")]
  public const int PIN_INPUT = 0;
  [Token(Token = "0x4000952")]
  public const int PIN_BEFORE = 10;
  [Token(Token = "0x4000953")]
  public const int PIN_AFTER = 11;
  [Token(Token = "0x4000954")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  public string m_Time;

  [Token(Token = "0x6000B8A")]
  [Address(RVA = "0x10800A0", Offset = "0x107EEA0", VA = "0x110800A0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B8B")]
  [Address(RVA = "0x1080010", Offset = "0x107EE10", VA = "0x11080010", Slot = "6")]
  public override string[] GetInfoLines() => (string[]) null;

  [Token(Token = "0x6000B8C")]
  [Address(RVA = "0x1080210", Offset = "0x107F010", VA = "0x11080210")]
  public FlowNode_SwitchServerTime()
  {
  }
}
