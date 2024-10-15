// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ClosePopupPlayerStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200139C")]
  [FlowNode.NodeType("System/Buy/ClosePopupPlayerStatus", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  public class FlowNode_ClosePopupPlayerStatus : FlowNode
  {
    [Token(Token = "0x600522A")]
    [Address(RVA = "0x126EA20", Offset = "0x126D820", VA = "0x1126EA20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600522B")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ClosePopupPlayerStatus()
    {
    }
  }
}
