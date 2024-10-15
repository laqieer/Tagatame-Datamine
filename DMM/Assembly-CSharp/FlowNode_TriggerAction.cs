// Decompiled with JetBrains decompiler
// Type: FlowNode_TriggerAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
[Token(Token = "0x2000229")]
[FlowNode.NodeType("Event/TriggerAction", 32741)]
[FlowNode.Pin(0, "In", FlowNode.PinTypes.Input, 0)]
[AddComponentMenu("")]
[FlowNode.ShowInInspector]
[FlowNode.Pin(1, "Out", FlowNode.PinTypes.Output, 1)]
public class FlowNode_TriggerAction : FlowNode
{
  [Token(Token = "0x400095D")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  public UnityEvent Action;

  [Token(Token = "0x6000B9D")]
  [Address(RVA = "0x1080B80", Offset = "0x107F980", VA = "0x11080B80", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B9E")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_TriggerAction()
  {
  }
}
