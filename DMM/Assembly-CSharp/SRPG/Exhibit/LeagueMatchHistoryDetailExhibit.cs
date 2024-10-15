// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeagueMatchHistoryDetailExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003453")]
  public class LeagueMatchHistoryDetailExhibit : 
    BaseExhibit,
    IRenderModel<LeagueMatchHistoryDetailModel>,
    IRenderModel
  {
    [Token(Token = "0x400F825")]
    [FieldOffset(Offset = "0x34")]
    public ExhibitList PlayerUnitIcon;
    [Token(Token = "0x400F826")]
    [FieldOffset(Offset = "0x38")]
    public ConceptCardIconEx ConceptCardIcon;
    [Token(Token = "0x400F827")]
    [FieldOffset(Offset = "0x3C")]
    public Transform ConceptCardIconParent;
    [Token(Token = "0x400F828")]
    [FieldOffset(Offset = "0x40")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeagueMatchHistoryDetailExhibit.EKey), typeof (LeagueMatchHistoryDetailExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E969")]
    [Address(RVA = "0xADF620", Offset = "0xADE420", VA = "0x10ADF620", Slot = "8")]
    public void Render(LeagueMatchHistoryDetailModel model)
    {
    }

    [Token(Token = "0x600E96A")]
    [Address(RVA = "0xADF250", Offset = "0xADE050", VA = "0x10ADF250")]
    private void CreateUnitIcon(LeagueMatchHistoryDetailModel model, List<UnitModel> unit_models)
    {
    }

    [Token(Token = "0x600E96B")]
    [Address(RVA = "0xADEFB0", Offset = "0xADDDB0", VA = "0x10ADEFB0")]
    private void CreateConceptCardsIcon(List<UnitModel> unit_models, Transform parent)
    {
    }

    [Token(Token = "0x600E96C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchHistoryDetailExhibit()
    {
    }

    [Token(Token = "0x2003454")]
    private enum EKey
    {
      [Token(Token = "0x400F82A")] None,
      [Token(Token = "0x400F82B")] PlayerPartyUnits,
      [Token(Token = "0x400F82C")] EnemyPartyUnits,
      [Token(Token = "0x400F82D")] PlayerName,
      [Token(Token = "0x400F82E")] PlayerLv,
      [Token(Token = "0x400F82F")] PlayerTotalCombatPower,
      [Token(Token = "0x400F830")] PlayerLeaderSkillName,
      [Token(Token = "0x400F831")] PlayerLeaderSkillExper,
      [Token(Token = "0x400F832")] EnemyName,
      [Token(Token = "0x400F833")] EnemyLv,
      [Token(Token = "0x400F834")] EnemyTotalCombatPower,
      [Token(Token = "0x400F835")] EnemyLeaderSkillName,
      [Token(Token = "0x400F836")] EnemyLeaderSkillExper,
      [Token(Token = "0x400F837")] OffenseBackGroundImg,
      [Token(Token = "0x400F838")] DefenseBackGroundImg,
      [Token(Token = "0x400F839")] ShamBattleBtn,
    }
  }
}
