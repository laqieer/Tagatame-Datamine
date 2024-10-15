// Decompiled with JetBrains decompiler
// Type: SRPG.CheckVersusBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200261C")]
  [FlowNode.NodeType("UI/CheckVersusBadge", 32741)]
  [FlowNode.Pin(1, "CheckArena", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/CheckVersusBadge")]
  [FlowNode.Pin(2, "CheckDuel", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "CheckLeagueMatch", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(102, "Disable", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "Enable", FlowNode.PinTypes.Output, 101)]
  public class CheckVersusBadge : FlowNode
  {
    [Token(Token = "0x400B17B")]
    private const int PIN_IN_CHECK_ARENA = 1;
    [Token(Token = "0x400B17C")]
    private const int PIN_IN_CHECK_DUEL = 2;
    [Token(Token = "0x400B17D")]
    private const int PIN_IN_CHECK_LEAGUEMATCH = 3;
    [Token(Token = "0x400B17E")]
    private const int PIN_OUT_ENABLE = 101;
    [Token(Token = "0x400B17F")]
    private const int PIN_OUT_DISABLE = 102;

    [Token(Token = "0x600A9F0")]
    [Address(RVA = "0x6C5F10", Offset = "0x6C4D10", VA = "0x106C5F10", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600A9F1")]
    [Address(RVA = "0x6C5EF0", Offset = "0x6C4CF0", VA = "0x106C5EF0")]
    private void CheckFlag(bool flag)
    {
    }

    [Token(Token = "0x600A9F2")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public CheckVersusBadge()
    {
    }
  }
}
