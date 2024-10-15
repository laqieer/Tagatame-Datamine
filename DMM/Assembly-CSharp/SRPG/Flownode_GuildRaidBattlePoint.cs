// Decompiled with JetBrains decompiler
// Type: SRPG.Flownode_GuildRaidBattlePoint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016B9")]
  [FlowNode.Pin(104, "NoBattleSchedule", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(103, "Challenge", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(101, "Today End", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Start", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("GuildRaid/BattlePoint", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(900, "Error", FlowNode.PinTypes.Output, 900)]
  [FlowNode.Pin(102, "No Challenge", FlowNode.PinTypes.Output, 102)]
  public class Flownode_GuildRaidBattlePoint : FlowNode
  {
    [Token(Token = "0x400526B")]
    private const int PIN_IN_START = 1;
    [Token(Token = "0x400526C")]
    private const int PIN_OUT_TODAYEND = 101;
    [Token(Token = "0x400526D")]
    private const int PIN_OUT_NO_CHALLENGE = 102;
    [Token(Token = "0x400526E")]
    private const int PIN_OUT_CHALLENGE = 103;
    [Token(Token = "0x400526F")]
    private const int PIN_OUT_NOBATTLESCHEDULE = 104;
    [Token(Token = "0x4005270")]
    private const int PIN_OUT_ERROR = 900;

    [Token(Token = "0x6005D04")]
    [Address(RVA = "0x1317860", Offset = "0x1316660", VA = "0x11317860", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D05")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public Flownode_GuildRaidBattlePoint()
    {
    }
  }
}
