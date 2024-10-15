// Decompiled with JetBrains decompiler
// Type: SRPG.Flownode_RaidCheckRescueCount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001819")]
  [AddComponentMenu("")]
  [FlowNode.Pin(900, "Error", FlowNode.PinTypes.Output, 9)]
  [FlowNode.Pin(101, "Has Rescue Member", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(1, "Check", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(102, "Nothing", FlowNode.PinTypes.Output, 3)]
  [FlowNode.NodeType("Raid/CheckRescueCount", 32741)]
  public class Flownode_RaidCheckRescueCount : FlowNode
  {
    [Token(Token = "0x600614F")]
    [Address(RVA = "0x136DCC0", Offset = "0x136CAC0", VA = "0x1136DCC0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006150")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public Flownode_RaidCheckRescueCount()
    {
    }
  }
}
