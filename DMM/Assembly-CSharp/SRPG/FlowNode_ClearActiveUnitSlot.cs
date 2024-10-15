// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ClearActiveUnitSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001396")]
  [FlowNode.NodeType("SRPG/ClearActiveUnitSlot", 32741)]
  [FlowNode.Pin(1, "Clear Slot", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Out", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  public class FlowNode_ClearActiveUnitSlot : FlowNode
  {
    [Token(Token = "0x6005213")]
    [Address(RVA = "0x126E5A0", Offset = "0x126D3A0", VA = "0x1126E5A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005214")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ClearActiveUnitSlot()
    {
    }
  }
}
