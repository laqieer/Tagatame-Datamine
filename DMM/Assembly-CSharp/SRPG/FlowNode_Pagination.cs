// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_Pagination
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200144A")]
  [FlowNode.NodeType("Common/Pagination", 32741)]
  [FlowNode.Pin(1, "Next", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Prev", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(10, "Output", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  public class FlowNode_Pagination : FlowNode
  {
    [Token(Token = "0x4004B07")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [FlowNode.DropTarget(typeof (IPagination), false)]
    private Component target;

    [Token(Token = "0x60054CA")]
    [Address(RVA = "0x1293600", Offset = "0x1292400", VA = "0x11293600", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60054CB")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_Pagination()
    {
    }
  }
}
