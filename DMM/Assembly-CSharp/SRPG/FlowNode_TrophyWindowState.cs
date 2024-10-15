// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_TrophyWindowState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001887")]
  [AddComponentMenu("")]
  [FlowNode.Pin(13, "Reset", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(12, "Compare Not Match", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(11, "Compare Match", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(1, "Action", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Set", FlowNode.PinTypes.Output, 10)]
  [FlowNode.NodeType("Trophy/TrophyWindowState", 32741)]
  public class FlowNode_TrophyWindowState : FlowNode
  {
    [Token(Token = "0x40057F5")]
    private const int PIN_IN_ACTION = 1;
    [Token(Token = "0x40057F6")]
    private const int PIN_OUT_SET = 10;
    [Token(Token = "0x40057F7")]
    private const int PIN_OUT_COMPARE_MATCH = 11;
    [Token(Token = "0x40057F8")]
    private const int PIN_OUT_COMPARE_NOT_MATCH = 12;
    [Token(Token = "0x40057F9")]
    private const int PIN_OUT_RESET = 13;
    [Token(Token = "0x40057FA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private FlowNode_TrophyWindowState.Type ActionType;
    [Token(Token = "0x40057FB")]
    [FieldOffset(Offset = "0x19")]
    [SerializeField]
    private FlowNode_TrophyWindowState.TrophyType SelectTrophyType;
    [Token(Token = "0x40057FC")]
    [FieldOffset(Offset = "0x0")]
    private static FlowNode_TrophyWindowState.TrophyType mTrophyType;

    [Token(Token = "0x60062CF")]
    [Address(RVA = "0x315F00", Offset = "0x314D00", VA = "0x10315F00", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60062D0")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_TrophyWindowState()
    {
    }

    [Token(Token = "0x60062D1")]
    [Address(RVA = "0x315FF0", Offset = "0x314DF0", VA = "0x10315FF0")]
    static FlowNode_TrophyWindowState()
    {
    }

    [Token(Token = "0x2001888")]
    private enum Type : byte
    {
      [Token(Token = "0x40057FE")] NONE,
      [Token(Token = "0x40057FF")] SET,
      [Token(Token = "0x4005800")] COMPARE,
      [Token(Token = "0x4005801")] RESET,
    }

    [Token(Token = "0x2001889")]
    private enum TrophyType : byte
    {
      [Token(Token = "0x4005803")] NONE,
      [Token(Token = "0x4005804")] DAILY,
      [Token(Token = "0x4005805")] RECORD,
      [Token(Token = "0x4005806")] GUILD_DAILY,
      [Token(Token = "0x4005807")] QUEST_ARCHIVE,
    }
  }
}
