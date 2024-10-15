// Decompiled with JetBrains decompiler
// Type: SRPG.Flownode_GuildRaidRankingMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016BF")]
  [AddComponentMenu("")]
  [FlowNode.Pin(900, "Error", FlowNode.PinTypes.Output, 9)]
  [FlowNode.Pin(1, "Set", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Current", FlowNode.PinTypes.Output, 2)]
  [FlowNode.NodeType("GuildRaid/RankingMode", 32741)]
  [FlowNode.Pin(101, "History", FlowNode.PinTypes.Output, 3)]
  public class Flownode_GuildRaidRankingMode : FlowNode
  {
    [Token(Token = "0x6005D10")]
    [Address(RVA = "0x132E140", Offset = "0x132CF40", VA = "0x1132E140", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D11")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public Flownode_GuildRaidRankingMode()
    {
    }
  }
}
