// Decompiled with JetBrains decompiler
// Type: FlowNode_ActiveControlGraphicRaycasterExtend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001C4")]
[FlowNode.Pin(0, "Set Active True", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(1, "Set Active false", FlowNode.PinTypes.Input, 1)]
[AddComponentMenu("")]
[FlowNode.NodeType("Common/ActiveControlGraphicRaycasterExtend", 32741)]
public class FlowNode_ActiveControlGraphicRaycasterExtend : FlowNode
{
  [Token(Token = "0x400081E")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.ShowInInfo]
  [FlowNode.DropTarget(typeof (GameObject), false)]
  public GraphicsRaycasterExtend Target;
  [Token(Token = "0x400081F")]
  private const int PIN_INPUT_ON = 0;
  [Token(Token = "0x4000820")]
  private const int PIN_INPUT_OFF = 1;

  [Token(Token = "0x6000A68")]
  [Address(RVA = "0xF47880", Offset = "0xF46680", VA = "0x10F47880", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000A69")]
  [Address(RVA = "0xF474B0", Offset = "0xF462B0", VA = "0x10F474B0")]
  public FlowNode_ActiveControlGraphicRaycasterExtend()
  {
  }
}
