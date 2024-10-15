// Decompiled with JetBrains decompiler
// Type: SRPG.Flownode_GuildRaidSchedule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016C0")]
  [FlowNode.Pin(900, "Error", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  [FlowNode.Pin(104, "GuildRaid CloseShedule", FlowNode.PinTypes.Output, 5)]
  [FlowNode.NodeType("GuildRaid/GuildRaidSchedule", 32741)]
  [FlowNode.Pin(102, "GuildRaid OpenSchedule", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(101, "GuildRaid Open", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(1, "Set", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(103, "GuildRaid Close", FlowNode.PinTypes.Output, 4)]
  public class Flownode_GuildRaidSchedule : FlowNode
  {
    [Token(Token = "0x6005D12")]
    [Address(RVA = "0x132E210", Offset = "0x132D010", VA = "0x1132E210", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D13")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public Flownode_GuildRaidSchedule()
    {
    }
  }
}
