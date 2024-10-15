// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_UpdateParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001669")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("UI/UpdateParameter", 32741)]
  [FlowNode.Pin(100, "Update", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(101, "UpdateAll", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Updated", FlowNode.PinTypes.Output, 1)]
  public class FlowNode_UpdateParameter : FlowNode
  {
    [Token(Token = "0x400516E")]
    [FieldOffset(Offset = "0x18")]
    [FlowNode.DropTarget(typeof (GameObject), false)]
    [FlowNode.ShowInInfo]
    public GameObject Target;

    [Token(Token = "0x6005C0B")]
    [Address(RVA = "0x1314D70", Offset = "0x1313B70", VA = "0x11314D70", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C0C")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_UpdateParameter()
    {
    }
  }
}
