// Decompiled with JetBrains decompiler
// Type: FlowNode_TrophyUpdateProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200022B")]
[FlowNode.NodeType("Trophy/TrophyUpdateProgress", 32741)]
[FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 1)]
[FlowNode.Pin(10, "Enabled", FlowNode.PinTypes.Input, 10)]
[FlowNode.Pin(11, "Disable", FlowNode.PinTypes.Input, 11)]
[AddComponentMenu("")]
public class FlowNode_TrophyUpdateProgress : FlowNode
{
  [Token(Token = "0x400095F")]
  [FieldOffset(Offset = "0x18")]
  private bool m_IsEnable;
  [Token(Token = "0x4000960")]
  private const int INPUT_PIN = 0;
  [Token(Token = "0x4000961")]
  private const int OUTPUT_PIN = 1;
  [Token(Token = "0x4000962")]
  private const int ENABLED_PIN = 10;
  [Token(Token = "0x4000963")]
  private const int DISABLE_PIN = 11;

  [Token(Token = "0x6000BA3")]
  [Address(RVA = "0x1080E60", Offset = "0x107FC60", VA = "0x11080E60", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000BA4")]
  [Address(RVA = "0x1080EF0", Offset = "0x107FCF0", VA = "0x11080EF0")]
  public FlowNode_TrophyUpdateProgress()
  {
  }
}
