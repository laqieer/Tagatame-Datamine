// Decompiled with JetBrains decompiler
// Type: FlowNode_Sequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200020A")]
[FlowNode.NodeType("Common/Sequence", 32741)]
[FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
[AddComponentMenu("")]
public class FlowNode_Sequence : FlowNode
{
  [Token(Token = "0x40008F1")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private int m_Num;
  [Token(Token = "0x40008F2")]
  [FieldOffset(Offset = "0x1C")]
  [HideInInspector]
  [SerializeField]
  private FlowNode.Pin[] m_Pins;

  [Token(Token = "0x6000B5E")]
  [Address(RVA = "0x107E180", Offset = "0x107CF80", VA = "0x1107E180", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B5F")]
  [Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0", Slot = "9")]
  public override FlowNode.Pin[] GetDynamicPins() => (FlowNode.Pin[]) null;

  [Token(Token = "0x6000B60")]
  [Address(RVA = "0x107E1E0", Offset = "0x107CFE0", VA = "0x1107E1E0")]
  public FlowNode_Sequence()
  {
  }
}
