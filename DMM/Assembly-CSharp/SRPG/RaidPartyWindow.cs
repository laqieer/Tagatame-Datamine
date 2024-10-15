// Decompiled with JetBrains decompiler
// Type: SRPG.RaidPartyWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028E7")]
  [FlowNode.Pin(1000, "ラストアッタクパーティに固定", FlowNode.PinTypes.Input, 1000)]
  [FlowNode.Pin(1010, "レイド挑戦回数を回復", FlowNode.PinTypes.Output, 1010)]
  [AddComponentMenu("UI/Raid/RaidPartyWindow")]
  public class RaidPartyWindow : PartyWindow2
  {
    [Token(Token = "0x400C4B4")]
    private const int PIN_INPUT_GUILDRAID_FIXPARTY = 1000;
    [Token(Token = "0x400C4B5")]
    private const int PIN_OUTPUT_RAIDBOSS_BP_RECOVER = 1010;
    [Token(Token = "0x400C4B6")]
    [FieldOffset(Offset = "0x2D4")]
    private GameObject mConfirmBox;

    [Token(Token = "0x600B91E")]
    [Address(RVA = "0x8014B0", Offset = "0x8002B0", VA = "0x108014B0", Slot = "30")]
    protected override void OverrideLoadTeam()
    {
    }

    [Token(Token = "0x600B91F")]
    [Address(RVA = "0x801190", Offset = "0x7FFF90", VA = "0x10801190", Slot = "22")]
    protected override bool CheckMember(int numMainUnits) => new bool();

    [Token(Token = "0x17001955")]
    protected override int AvailableMainMemberSlots
    {
      [Token(Token = "0x600B920"), Address(RVA = "0x801F00", Offset = "0x800D00", VA = "0x10801F00", Slot = "31")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600B921")]
    [Address(RVA = "0x801D10", Offset = "0x800B10", VA = "0x10801D10", Slot = "33")]
    protected override void RegistPartyMember(
      List<UnitData> allUnits,
      bool heroesAvailable,
      bool selectedSlotIsEmpty,
      int numMainMembers)
    {
    }

    [Token(Token = "0x600B922")]
    [Address(RVA = "0x8017C0", Offset = "0x8005C0", VA = "0x108017C0", Slot = "23")]
    protected override void PostForwardPressed()
    {
    }

    [Token(Token = "0x600B923")]
    [Address(RVA = "0x6CC990", Offset = "0x6CB790", VA = "0x106CC990")]
    private void OnBattleGo(GameObject go)
    {
    }

    [Token(Token = "0x600B924")]
    [Address(RVA = "0x801070", Offset = "0x7FFE70", VA = "0x10801070", Slot = "32")]
    public override void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B925")]
    [Address(RVA = "0x439930", Offset = "0x438730", VA = "0x10439930")]
    public RaidPartyWindow()
    {
    }
  }
}
