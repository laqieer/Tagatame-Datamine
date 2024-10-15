// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidPartyWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D6E")]
  [FlowNode.Pin(3000, "BP回復へ", FlowNode.PinTypes.Output, 3000)]
  [AddComponentMenu("UI/WorldRaid/WorldRaidPartyWindow")]
  public class WorldRaidPartyWindow : PartyWindow2
  {
    [Token(Token = "0x400E27C")]
    private const int PIN_OUTPUT_GOTO_BP_HEAL = 3000;

    [Token(Token = "0x600D3D3")]
    [Address(RVA = "0x9E8F90", Offset = "0x9E7D90", VA = "0x109E8F90", Slot = "22")]
    protected override bool CheckMember(int numMainUnits) => new bool();

    [Token(Token = "0x600D3D4")]
    [Address(RVA = "0x9E9220", Offset = "0x9E8020", VA = "0x109E9220", Slot = "33")]
    protected override void RegistPartyMember(
      List<UnitData> allUnits,
      bool heroesAvailable,
      bool selectedSlotIsEmpty,
      int numMainMembers)
    {
    }

    [Token(Token = "0x600D3D5")]
    [Address(RVA = "0x9E9130", Offset = "0x9E7F30", VA = "0x109E9130", Slot = "23")]
    protected override void PostForwardPressed()
    {
    }

    [Token(Token = "0x600D3D6")]
    [Address(RVA = "0x9E91D0", Offset = "0x9E7FD0", VA = "0x109E91D0", Slot = "20")]
    public override void PrepareStartQuest()
    {
    }

    [Token(Token = "0x600D3D7")]
    [Address(RVA = "0x9E9100", Offset = "0x9E7F00", VA = "0x109E9100")]
    private bool IsWorldRaidBPCount() => new bool();

    [Token(Token = "0x600D3D8")]
    [Address(RVA = "0x439930", Offset = "0x438730", VA = "0x10439930")]
    public WorldRaidPartyWindow()
    {
    }
  }
}
