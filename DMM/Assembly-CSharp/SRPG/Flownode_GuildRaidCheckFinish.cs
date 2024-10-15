// Decompiled with JetBrains decompiler
// Type: SRPG.Flownode_GuildRaidCheckFinish
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016BA")]
  [FlowNode.NodeType("GuildRaid/CheckFinish", 32741)]
  [FlowNode.Pin(1, "Check", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "End GuildRaid", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(102, "Not End GuildRaid", FlowNode.PinTypes.Output, 3)]
  [AddComponentMenu("")]
  [FlowNode.Pin(900, "Error", FlowNode.PinTypes.Output, 9)]
  public class Flownode_GuildRaidCheckFinish : FlowNode
  {
    [Token(Token = "0x6005D06")]
    [Address(RVA = "0x132DDC0", Offset = "0x132CBC0", VA = "0x1132DDC0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D07")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public Flownode_GuildRaidCheckFinish()
    {
    }
  }
}
