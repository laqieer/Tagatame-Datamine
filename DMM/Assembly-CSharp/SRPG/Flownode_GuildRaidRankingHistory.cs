// Decompiled with JetBrains decompiler
// Type: SRPG.Flownode_GuildRaidRankingHistory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016BE")]
  [FlowNode.NodeType("GuildRaid/RankingHistory", 32741)]
  [FlowNode.Pin(1, "Set Current", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Set History", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(101, "Set", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(900, "Error", FlowNode.PinTypes.Output, 9)]
  [AddComponentMenu("")]
  public class Flownode_GuildRaidRankingHistory : FlowNode
  {
    [Token(Token = "0x6005D0E")]
    [Address(RVA = "0x132E070", Offset = "0x132CE70", VA = "0x1132E070", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D0F")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public Flownode_GuildRaidRankingHistory()
    {
    }
  }
}
