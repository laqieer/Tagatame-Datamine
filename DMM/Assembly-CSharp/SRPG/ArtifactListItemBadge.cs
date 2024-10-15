// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactListItemBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FE5")]
  [AddComponentMenu("UI/Artifact/ArtifactListItemBadge")]
  public class ArtifactListItemBadge : BaseListItemBadge
  {
    [Token(Token = "0x4008776")]
    [FieldOffset(Offset = "0x38")]
    private ArtifactData m_ArtifactData;
    [Token(Token = "0x4008777")]
    [FieldOffset(Offset = "0x3C")]
    private List<BadgeViewUnitData> _quest;
    [Token(Token = "0x4008778")]
    [FieldOffset(Offset = "0x40")]
    private List<BadgeViewUnitData> _arena;
    [Token(Token = "0x4008779")]
    [FieldOffset(Offset = "0x44")]
    private List<BadgeViewUnitData> _arenaDef;
    [Token(Token = "0x400877A")]
    [FieldOffset(Offset = "0x48")]
    private List<BadgeViewUnitData> _support;
    [Token(Token = "0x400877B")]
    [FieldOffset(Offset = "0x4C")]
    private List<BadgeViewUnitData> _gvg;
    [Token(Token = "0x400877C")]
    [FieldOffset(Offset = "0x50")]
    private List<BadgeViewUnitData> _leagueMatchAtk;
    [Token(Token = "0x400877D")]
    [FieldOffset(Offset = "0x54")]
    private List<BadgeViewUnitData> _leagueMatchAtkSet;
    [Token(Token = "0x400877E")]
    [FieldOffset(Offset = "0x58")]
    private List<BadgeViewUnitData> _leagueMatchDef;
    [Token(Token = "0x400877F")]
    [FieldOffset(Offset = "0x5C")]
    private List<BadgeViewUnitData> _leagueMatchSham;

    [Token(Token = "0x6008389")]
    [Address(RVA = "0x440AC0", Offset = "0x43F8C0", VA = "0x10440AC0", Slot = "5")]
    public override void GetRefreshUnits()
    {
    }

    [Token(Token = "0x600838A")]
    [Address(RVA = "0x441450", Offset = "0x440250", VA = "0x10441450")]
    private void SetSupportOnlyIcon()
    {
    }

    [Token(Token = "0x600838B")]
    [Address(RVA = "0x4413B0", Offset = "0x4401B0", VA = "0x104413B0")]
    private void SetSupportAllIcon()
    {
    }

    [Token(Token = "0x600838C")]
    [Address(RVA = "0x4413A0", Offset = "0x4401A0", VA = "0x104413A0", Slot = "6")]
    public override void Refresh()
    {
    }

    [Token(Token = "0x600838D")]
    [Address(RVA = "0x440D60", Offset = "0x43FB60", VA = "0x10440D60")]
    public void RefreshBadge()
    {
    }

    [Token(Token = "0x600838E")]
    [Address(RVA = "0x441550", Offset = "0x440350", VA = "0x10441550")]
    public ArtifactListItemBadge()
    {
    }
  }
}
