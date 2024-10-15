// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardListItemBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021C6")]
  [AddComponentMenu("UI/ConceptCard/ConceptCardListItemBadge")]
  public class ConceptCardListItemBadge : BaseListItemBadge
  {
    [Token(Token = "0x400941A")]
    [FieldOffset(Offset = "0x38")]
    private ConceptCardData m_CardData;
    [Token(Token = "0x400941B")]
    [FieldOffset(Offset = "0x3C")]
    private List<BadgeViewUnitData> _quest;
    [Token(Token = "0x400941C")]
    [FieldOffset(Offset = "0x40")]
    private List<BadgeViewUnitData> _arena;
    [Token(Token = "0x400941D")]
    [FieldOffset(Offset = "0x44")]
    private List<BadgeViewUnitData> _arenaDef;
    [Token(Token = "0x400941E")]
    [FieldOffset(Offset = "0x48")]
    private List<BadgeViewUnitData> _support;
    [Token(Token = "0x400941F")]
    [FieldOffset(Offset = "0x4C")]
    private List<BadgeViewUnitData> _gvg;
    [Token(Token = "0x4009420")]
    [FieldOffset(Offset = "0x50")]
    private List<BadgeViewUnitData> _leagueMatchAtkUnits;
    [Token(Token = "0x4009421")]
    [FieldOffset(Offset = "0x54")]
    private List<BadgeViewUnitData> _leagueMatchAtkSetUnits;
    [Token(Token = "0x4009422")]
    [FieldOffset(Offset = "0x58")]
    private List<BadgeViewUnitData> _leagueMatchDefUnits;
    [Token(Token = "0x4009423")]
    [FieldOffset(Offset = "0x5C")]
    private List<BadgeViewUnitData> _leagueMatchShamUnits;

    [Token(Token = "0x6008E7E")]
    [Address(RVA = "0x51B410", Offset = "0x51A210", VA = "0x1051B410", Slot = "5")]
    public override void GetRefreshUnits()
    {
    }

    [Token(Token = "0x6008E7F")]
    [Address(RVA = "0x51BDA0", Offset = "0x51ABA0", VA = "0x1051BDA0")]
    private void SetSupportOnlyIcon()
    {
    }

    [Token(Token = "0x6008E80")]
    [Address(RVA = "0x51BD00", Offset = "0x51AB00", VA = "0x1051BD00")]
    private void SetSupportAllIcon()
    {
    }

    [Token(Token = "0x6008E81")]
    [Address(RVA = "0x51B6B0", Offset = "0x51A4B0", VA = "0x1051B6B0")]
    private void RefreshBadge()
    {
    }

    [Token(Token = "0x6008E82")]
    [Address(RVA = "0x51BCF0", Offset = "0x51AAF0", VA = "0x1051BCF0", Slot = "6")]
    public override void Refresh()
    {
    }

    [Token(Token = "0x6008E83")]
    [Address(RVA = "0x51BEA0", Offset = "0x51ACA0", VA = "0x1051BEA0")]
    public ConceptCardListItemBadge()
    {
    }
  }
}
