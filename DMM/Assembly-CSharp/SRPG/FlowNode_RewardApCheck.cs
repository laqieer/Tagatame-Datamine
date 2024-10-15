// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RewardApCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015F9")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.NodeType("System/Check/RewardApCheck", 32741)]
  [FlowNode.Pin(0, "Check", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(3, "Overflow", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("")]
  [FlowNode.Pin(2, "AlreadyCapped", FlowNode.PinTypes.Output, 2)]
  public class FlowNode_RewardApCheck : FlowNode
  {
    [Token(Token = "0x6005A71")]
    [Address(RVA = "0x12F24E0", Offset = "0x12F12E0", VA = "0x112F24E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005A72")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_RewardApCheck()
    {
    }
  }
}
