// Decompiled with JetBrains decompiler
// Type: SRPG.Flownode_GuildRaidForcedDeck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016BC")]
  [FlowNode.Pin(101, "ForceDeck", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Start", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(102, "Not ForceDeck", FlowNode.PinTypes.Output, 102)]
  [FlowNode.NodeType("GuildRaid/ForceDeck", 32741)]
  [FlowNode.Pin(900, "Error", FlowNode.PinTypes.Output, 900)]
  public class Flownode_GuildRaidForcedDeck : FlowNode
  {
    [Token(Token = "0x6005D0A")]
    [Address(RVA = "0x132DEC0", Offset = "0x132CCC0", VA = "0x1132DEC0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D0B")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public Flownode_GuildRaidForcedDeck()
    {
    }
  }
}
