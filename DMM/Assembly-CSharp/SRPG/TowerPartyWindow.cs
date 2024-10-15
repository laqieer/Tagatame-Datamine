// Decompiled with JetBrains decompiler
// Type: SRPG.TowerPartyWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B48")]
  [AddComponentMenu("UI/TowerPartyWindow")]
  public class TowerPartyWindow : PartyWindow2
  {
    [Token(Token = "0x600C625")]
    [Address(RVA = "0x8EA7E0", Offset = "0x8E95E0", VA = "0x108EA7E0", Slot = "22")]
    protected override bool CheckMember(int numMainUnits) => new bool();

    [Token(Token = "0x17001A43")]
    protected override int AvailableMainMemberSlots
    {
      [Token(Token = "0x600C626"), Address(RVA = "0x8EACF0", Offset = "0x8E9AF0", VA = "0x108EACF0", Slot = "31")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C627")]
    [Address(RVA = "0x8EAB00", Offset = "0x8E9900", VA = "0x108EAB00", Slot = "33")]
    protected override void RegistPartyMember(
      List<UnitData> allUnits,
      bool heroesAvailable,
      bool selectedSlotIsEmpty,
      int numMainMembers)
    {
    }

    [Token(Token = "0x600C628")]
    [Address(RVA = "0x439930", Offset = "0x438730", VA = "0x10439930")]
    public TowerPartyWindow()
    {
    }
  }
}
