// Decompiled with JetBrains decompiler
// Type: FlowNode_ResetAnimatorTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000207")]
[AddComponentMenu("")]
[FlowNode.Pin(10, "Output", FlowNode.PinTypes.Output, 10)]
[FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
[FlowNode.NodeType("Animator/ResetTime", 32741)]
public class FlowNode_ResetAnimatorTime : FlowNode
{
  [Token(Token = "0x40008EC")]
  private const int PIN_IN_INPUT = 0;
  [Token(Token = "0x40008ED")]
  private const int PIN_IN_OUTPUT = 10;
  [Token(Token = "0x40008EE")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  [FlowNode.DropTarget(typeof (GameObject), true)]
  [FlowNode.ShowInInfo]
  private GameObject Target;
  [Token(Token = "0x40008EF")]
  [FieldOffset(Offset = "0x1C")]
  [SerializeField]
  private float Time;
  [Token(Token = "0x40008F0")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private bool IsSearchChildren;

  [Token(Token = "0x6000B57")]
  [Address(RVA = "0x107DD50", Offset = "0x107CB50", VA = "0x1107DD50", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B58")]
  [Address(RVA = "0x107DEC0", Offset = "0x107CCC0", VA = "0x1107DEC0")]
  private void ResetTime(float time)
  {
  }

  [Token(Token = "0x6000B59")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_ResetAnimatorTime()
  {
  }
}
