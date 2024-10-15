// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001581")]
  [FlowNode.NodeType("System/ReqRanking", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Quest", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Arena", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "TowerMuch", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  public class FlowNode_ReqRanking : FlowNode_Network
  {
    [Token(Token = "0x60058BA")]
    [Address(RVA = "0x12DA2E0", Offset = "0x12D90E0", VA = "0x112DA2E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60058BB")]
    [Address(RVA = "0x12DA430", Offset = "0x12D9230", VA = "0x112DA430", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60058BC")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRanking()
    {
    }
  }
}
