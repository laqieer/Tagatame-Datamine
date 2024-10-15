// Decompiled with JetBrains decompiler
// Type: SRPG.DuelPartyWindow
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
  [Token(Token = "0x200231E")]
  [AddComponentMenu("UI/Duel/DuelPartyWindow")]
  public class DuelPartyWindow : PartyWindow2
  {
    [Token(Token = "0x4009CCC")]
    [FieldOffset(Offset = "0x2D4")]
    [SerializeField]
    private GameObject mMapInfo;
    [Token(Token = "0x4009CCD")]
    [FieldOffset(Offset = "0x2D8")]
    [SerializeField]
    private GameObject mRestTimeRoot;
    [Token(Token = "0x4009CCE")]
    [FieldOffset(Offset = "0x2DC")]
    [SerializeField]
    private Text mRestTimeText;

    [Token(Token = "0x600971C")]
    [Address(RVA = "0x599100", Offset = "0x597F00", VA = "0x10599100", Slot = "6")]
    protected override void Init()
    {
    }

    [Token(Token = "0x600971D")]
    [Address(RVA = "0x5992F0", Offset = "0x5980F0", VA = "0x105992F0", Slot = "37")]
    protected override void UnitList_OnSelect_RefreshOverWrite(UnitData selected_unit)
    {
    }

    [Token(Token = "0x600971E")]
    [Address(RVA = "0x599000", Offset = "0x597E00", VA = "0x10599000", Slot = "24")]
    protected override void CreateSlots_Arena(
      ref List<PartySlotData> main_slots,
      ref PartySlotData support,
      ref List<PartySlotData> sub_slots)
    {
    }

    [Token(Token = "0x600971F")]
    [Address(RVA = "0x439930", Offset = "0x438730", VA = "0x10439930")]
    public DuelPartyWindow()
    {
    }
  }
}
