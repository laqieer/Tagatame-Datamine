// Decompiled with JetBrains decompiler
// Type: SRPG.RuneListItemBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029AE")]
  [AddComponentMenu("UI/Rune/RuneListItemBadge")]
  public class RuneListItemBadge : BaseListItemBadge
  {
    [Token(Token = "0x400CA15")]
    [FieldOffset(Offset = "0x38")]
    public GameObject m_Favorite;
    [Token(Token = "0x400CA16")]
    [FieldOffset(Offset = "0x3C")]
    public ListItemUnitBadge m_Dedicated;
    [Token(Token = "0x400CA17")]
    [FieldOffset(Offset = "0x40")]
    private RuneData m_RuneData;
    [Token(Token = "0x400CA18")]
    [FieldOffset(Offset = "0x44")]
    private List<UnitData> mQuestUnits;
    [Token(Token = "0x400CA19")]
    [FieldOffset(Offset = "0x48")]
    private List<UnitData> mArenaUnits;
    [Token(Token = "0x400CA1A")]
    [FieldOffset(Offset = "0x4C")]
    private List<UnitData> mArenaDefUnits;
    [Token(Token = "0x400CA1B")]
    [FieldOffset(Offset = "0x50")]
    private List<UnitData> mSupportUnits;
    [Token(Token = "0x400CA1C")]
    [FieldOffset(Offset = "0x54")]
    private List<UnitData> mGvGUnits;
    [Token(Token = "0x400CA1D")]
    [FieldOffset(Offset = "0x58")]
    private List<UnitData> mLeagueMatchAtkUnits;
    [Token(Token = "0x400CA1E")]
    [FieldOffset(Offset = "0x5C")]
    private List<UnitData> mLeagueMatchAtkSetUnits;
    [Token(Token = "0x400CA1F")]
    [FieldOffset(Offset = "0x60")]
    private List<UnitData> mLeagueMatchDefUnits;
    [Token(Token = "0x400CA20")]
    [FieldOffset(Offset = "0x64")]
    private List<UnitData> mLeagueMatchShamUnits;
    [Token(Token = "0x400CA21")]
    [FieldOffset(Offset = "0x68")]
    private bool IsIncludeOverWrite;

    [Token(Token = "0x600BD4B")]
    [Address(RVA = "0x84EF60", Offset = "0x84DD60", VA = "0x1084EF60", Slot = "4")]
    public override void ClearDisableObject()
    {
    }

    [Token(Token = "0x600BD4C")]
    [Address(RVA = "0x84EFE0", Offset = "0x84DDE0", VA = "0x1084EFE0", Slot = "5")]
    public override void GetRefreshUnits()
    {
    }

    [Token(Token = "0x600BD4D")]
    [Address(RVA = "0x84FCD0", Offset = "0x84EAD0", VA = "0x1084FCD0")]
    private void SetSupportOnlyIcon()
    {
    }

    [Token(Token = "0x600BD4E")]
    [Address(RVA = "0x84FBA0", Offset = "0x84E9A0", VA = "0x1084FBA0")]
    private void SetSupportAllIcon()
    {
    }

    [Token(Token = "0x600BD4F")]
    [Address(RVA = "0x84F420", Offset = "0x84E220", VA = "0x1084F420", Slot = "6")]
    public override void Refresh()
    {
    }

    [Token(Token = "0x600BD50")]
    [Address(RVA = "0x84FDD0", Offset = "0x84EBD0", VA = "0x1084FDD0")]
    public RuneListItemBadge()
    {
    }
  }
}
