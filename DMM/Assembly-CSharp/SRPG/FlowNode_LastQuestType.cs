// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_LastQuestType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001417")]
  [FlowNode.Pin(211, "Gps", FlowNode.PinTypes.Output, 211)]
  [FlowNode.Pin(210, "VersusRank", FlowNode.PinTypes.Output, 210)]
  [FlowNode.Pin(209, "VersusFree", FlowNode.PinTypes.Output, 209)]
  [FlowNode.Pin(208, "Tower", FlowNode.PinTypes.Output, 208)]
  [FlowNode.Pin(207, "Character", FlowNode.PinTypes.Output, 207)]
  [FlowNode.Pin(206, "Event", FlowNode.PinTypes.Output, 206)]
  [FlowNode.Pin(205, "Free", FlowNode.PinTypes.Output, 205)]
  [FlowNode.Pin(212, "Extra", FlowNode.PinTypes.Output, 212)]
  [FlowNode.Pin(203, "Arena", FlowNode.PinTypes.Output, 203)]
  [FlowNode.Pin(202, "Multi", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(201, "Story", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(200, "Input", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(102, "MultiPlay", FlowNode.PinTypes.Output, 102)]
  [FlowNode.NodeType("Battle/LastQuestType", 32741)]
  [FlowNode.Pin(204, "Tutorial", FlowNode.PinTypes.Output, 204)]
  [FlowNode.Pin(213, "MultiTower", FlowNode.PinTypes.Output, 213)]
  [FlowNode.Pin(221, "AdvanceStory", FlowNode.PinTypes.Output, 221)]
  [FlowNode.Pin(215, "MultiGps", FlowNode.PinTypes.Output, 215)]
  [FlowNode.Pin(216, "Ordeal", FlowNode.PinTypes.Output, 216)]
  [FlowNode.Pin(217, "RankMatch", FlowNode.PinTypes.Output, 217)]
  [FlowNode.Pin(218, "Raid", FlowNode.PinTypes.Output, 218)]
  [FlowNode.Pin(219, "GenesisStory", FlowNode.PinTypes.Output, 219)]
  [FlowNode.Pin(220, "GenesisBoss", FlowNode.PinTypes.Output, 220)]
  [FlowNode.Pin(101, "SinglePlay", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(222, "AdvanceBoss", FlowNode.PinTypes.Output, 222)]
  [FlowNode.Pin(223, "UnitRental", FlowNode.PinTypes.Output, 223)]
  [FlowNode.Pin(225, "WorldRaid", FlowNode.PinTypes.Output, 225)]
  [FlowNode.Pin(227, "CombatPower", FlowNode.PinTypes.Output, 227)]
  [FlowNode.Pin(228, "DragonGod", FlowNode.PinTypes.Output, 228)]
  [FlowNode.Pin(229, "PointEvent", FlowNode.PinTypes.Output, 229)]
  [AddComponentMenu("")]
  [FlowNode.Pin(214, "Beginner", FlowNode.PinTypes.Output, 214)]
  [FlowNode.Pin(100, "Input", FlowNode.PinTypes.Input, 100)]
  public class FlowNode_LastQuestType : FlowNode
  {
    [Token(Token = "0x60053EE")]
    [Address(RVA = "0x1286930", Offset = "0x1285730", VA = "0x11286930", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60053EF")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_LastQuestType()
    {
    }
  }
}
