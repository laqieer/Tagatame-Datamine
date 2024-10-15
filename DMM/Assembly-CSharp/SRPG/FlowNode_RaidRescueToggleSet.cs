// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RaidRescueToggleSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200146E")]
  [AddComponentMenu("")]
  [FlowNode.Pin(10, "Not Join Guild", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "Friend Empty", FlowNode.PinTypes.Output, 11)]
  [FlowNode.NodeType("Raid/RaidRescueToggleSet", 32741)]
  [FlowNode.Pin(0, "input", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_RaidRescueToggleSet : FlowNode
  {
    [Token(Token = "0x6005568")]
    [Address(RVA = "0x129BD40", Offset = "0x129AB40", VA = "0x1129BD40", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005569")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_RaidRescueToggleSet()
    {
    }
  }
}
