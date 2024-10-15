// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_BlockInterrupt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001369")]
  [FlowNode.Pin(10, "OnDestroy", FlowNode.PinTypes.Output, 0)]
  [FlowNode.NodeType("BlockInterrupt", 32741)]
  [FlowNode.Pin(5, "Create", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "Destroy", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(20, "OnCreate", FlowNode.PinTypes.Output, 0)]
  public class FlowNode_BlockInterrupt : FlowNode
  {
    [Token(Token = "0x40047A8")]
    [FieldOffset(Offset = "0x18")]
    public BlockInterrupt.EType Type;
    [Token(Token = "0x40047A9")]
    [FieldOffset(Offset = "0x1C")]
    private BlockInterrupt mBlock;

    [Token(Token = "0x600516D")]
    [Address(RVA = "0x1266A80", Offset = "0x1265880", VA = "0x11266A80", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600516E")]
    [Address(RVA = "0x12669D0", Offset = "0x12657D0", VA = "0x112669D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600516F")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_BlockInterrupt()
    {
    }
  }
}
