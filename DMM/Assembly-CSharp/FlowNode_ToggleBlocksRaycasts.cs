// Decompiled with JetBrains decompiler
// Type: FlowNode_ToggleBlocksRaycasts
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000221")]
[FlowNode.NodeType("Toggle/BlocksRaycasts", 32741)]
[FlowNode.Pin(10, "Disable", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(11, "Enable", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 0)]
[AddComponentMenu("")]
public class FlowNode_ToggleBlocksRaycasts : FlowNodePersistent
{
  [Token(Token = "0x4000955")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.ShowInInfo]
  [FlowNode.DropTarget(typeof (GameObject), true)]
  public GameObject Target;

  [Token(Token = "0x6000B8D")]
  [Address(RVA = "0x1080260", Offset = "0x107F060", VA = "0x11080260", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B8E")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_ToggleBlocksRaycasts()
  {
  }
}
