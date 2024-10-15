// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardSlotEx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200224A")]
  [AddComponentMenu("UI/ConceptCardSlotEx")]
  public class ConceptCardSlotEx : MonoBehaviour, IGameParameter
  {
    [Token(Token = "0x4009826")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x4009827")]
    [FieldOffset(Offset = "0x10")]
    private ConceptCardSlotExModel mModel;

    [Token(Token = "0x6009219")]
    [Address(RVA = "0x5569D0", Offset = "0x5557D0", VA = "0x105569D0")]
    public void Initialize(
      PartySlotData partySlotData,
      ConceptCardData conceptCardData,
      UnitData unitData,
      UnitData leaderUnitData = null)
    {
    }

    [Token(Token = "0x600921A")]
    [Address(RVA = "0x556BB0", Offset = "0x5559B0", VA = "0x10556BB0")]
    public void Setup(
      PartySlotData partySlotData,
      ConceptCardData conceptCardData,
      UnitData unitData,
      UnitData leaderUnitData = null)
    {
    }

    [Token(Token = "0x600921B")]
    [Address(RVA = "0x556AB0", Offset = "0x5558B0", VA = "0x10556AB0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600921C")]
    [Address(RVA = "0x556AB0", Offset = "0x5558B0", VA = "0x10556AB0", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x600921D")]
    [Address(RVA = "0x556AB0", Offset = "0x5558B0", VA = "0x10556AB0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600921E")]
    [Address(RVA = "0x556B70", Offset = "0x555970", VA = "0x10556B70")]
    public void SetPartySlotData(PartySlotData partySlotData, bool isSetup = false)
    {
    }

    [Token(Token = "0x600921F")]
    [Address(RVA = "0x556B30", Offset = "0x555930", VA = "0x10556B30")]
    public void SetConceptCardData(ConceptCardData conceptCardData, bool isSetup = false)
    {
    }

    [Token(Token = "0x6009220")]
    [Address(RVA = "0x556B90", Offset = "0x555990", VA = "0x10556B90")]
    public void SetUnitData(UnitData unitData, bool isSetup = false)
    {
    }

    [Token(Token = "0x6009221")]
    [Address(RVA = "0x556B50", Offset = "0x555950", VA = "0x10556B50")]
    public void SetLeaderUnit(UnitData leaderUnitData, bool isSetup = false)
    {
    }

    [Token(Token = "0x6009222")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardSlotEx()
    {
    }
  }
}
