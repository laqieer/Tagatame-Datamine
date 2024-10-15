// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_DestroyCanvasAll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013BE")]
  [FlowNode.NodeType("UI/DestroyCanvasAll", 32741)]
  [FlowNode.Pin(0, "In", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Out", FlowNode.PinTypes.Output, 0)]
  [AddComponentMenu("")]
  public class FlowNode_DestroyCanvasAll : FlowNode
  {
    [Token(Token = "0x600528E")]
    [Address(RVA = "0x12742B0", Offset = "0x12730B0", VA = "0x112742B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600528F")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_DestroyCanvasAll()
    {
    }
  }
}
