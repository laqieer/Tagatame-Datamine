// Decompiled with JetBrains decompiler
// Type: SRPG.ArenaPartyWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FD3")]
  [AddComponentMenu("UI/Arena/ArenaPartyWindow")]
  public class ArenaPartyWindow : PartyWindow2
  {
    [Token(Token = "0x40086F2")]
    [FieldOffset(Offset = "0x2D4")]
    [SerializeField]
    private GameObject mMapInfo;
    [Token(Token = "0x40086F3")]
    [FieldOffset(Offset = "0x2D8")]
    [SerializeField]
    private GameObject mRestTimeRoot;
    [Token(Token = "0x40086F4")]
    [FieldOffset(Offset = "0x2DC")]
    [SerializeField]
    private Text mRestTimeText;
    [Token(Token = "0x40086F5")]
    [FieldOffset(Offset = "0x2E0")]
    [SerializeField]
    private Text mPartyDescText;

    [Token(Token = "0x6008310")]
    [Address(RVA = "0x439150", Offset = "0x437F50", VA = "0x10439150", Slot = "6")]
    protected override void Init()
    {
    }

    [Token(Token = "0x6008311")]
    [Address(RVA = "0x4393B0", Offset = "0x4381B0", VA = "0x104393B0", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6008312")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
    protected override void ChangeEnabledTeamTabs(int index)
    {
    }

    [Token(Token = "0x6008313")]
    [Address(RVA = "0x438F50", Offset = "0x437D50", VA = "0x10438F50", Slot = "24")]
    protected override void CreateSlots_Arena(
      ref List<PartySlotData> main_slots,
      ref PartySlotData support,
      ref List<PartySlotData> sub_slots)
    {
    }

    [Token(Token = "0x6008314")]
    [Address(RVA = "0x439470", Offset = "0x438270", VA = "0x10439470")]
    public void OnTeamTabChange_Arena()
    {
    }

    [Token(Token = "0x6008315")]
    [Address(RVA = "0x439720", Offset = "0x438520", VA = "0x10439720")]
    private void Refresh_ToggleInteractable()
    {
    }

    [Token(Token = "0x6008316")]
    [Address(RVA = "0x439620", Offset = "0x438420", VA = "0x10439620")]
    private void Refresh_DescText(PartyWindow2.EditPartyTypes party_type)
    {
    }

    [Token(Token = "0x6008317")]
    [Address(RVA = "0x4397A0", Offset = "0x4385A0", VA = "0x104397A0", Slot = "37")]
    protected override void UnitList_OnSelect_RefreshOverWrite(UnitData selected_unit)
    {
    }

    [Token(Token = "0x6008318")]
    [Address(RVA = "0x439930", Offset = "0x438730", VA = "0x10439930")]
    public ArenaPartyWindow()
    {
    }
  }
}
