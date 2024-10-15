// Decompiled with JetBrains decompiler
// Type: FlowNode_DestroyObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001D1")]
[AddComponentMenu("")]
[FlowNode.Pin(10, "Destroy", FlowNode.PinTypes.Input, 0)]
[FlowNode.NodeType("Common/DestroyGameObject", 32741)]
public class FlowNode_DestroyObject : FlowNode
{
  [Token(Token = "0x4000847")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.ShowInInfo]
  [FlowNode.DropTarget(typeof (GameObject), false)]
  public GameObject Target;

  [Token(Token = "0x6000A8C")]
  [Address(RVA = "0xF49540", Offset = "0xF48340", VA = "0x10F49540", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000A8D")]
  [Address(RVA = "0xF474B0", Offset = "0xF462B0", VA = "0x10F474B0")]
  public FlowNode_DestroyObject()
  {
  }
}
