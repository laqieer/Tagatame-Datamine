// Decompiled with JetBrains decompiler
// Type: FlowNode_AnimatorPollFromName
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001C7")]
[AddComponentMenu("")]
[FlowNode.NodeType("Animator/PollFromName", 32741)]
[FlowNode.Pin(10, "Start", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(100, "Output", FlowNode.PinTypes.Output, 100)]
public class FlowNode_AnimatorPollFromName : FlowNode
{
  [Token(Token = "0x4000826")]
  [FieldOffset(Offset = "0x18")]
  public string m_AnimatorName;
  [Token(Token = "0x4000827")]
  [FieldOffset(Offset = "0x1C")]
  public string m_StateName;
  [Token(Token = "0x4000828")]
  [FieldOffset(Offset = "0x20")]
  private Animator m_Animator;

  [Token(Token = "0x6000A6F")]
  [Address(RVA = "0xF47AA0", Offset = "0xF468A0", VA = "0x10F47AA0", Slot = "7")]
  protected override void Awake()
  {
  }

  [Token(Token = "0x6000A70")]
  [Address(RVA = "0xF47B40", Offset = "0xF46940", VA = "0x10F47B40", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000A71")]
  [Address(RVA = "0xF47B60", Offset = "0xF46960", VA = "0x10F47B60")]
  private void Update()
  {
  }

  [Token(Token = "0x6000A72")]
  [Address(RVA = "0xF47CF0", Offset = "0xF46AF0", VA = "0x10F47CF0")]
  public FlowNode_AnimatorPollFromName()
  {
  }
}
