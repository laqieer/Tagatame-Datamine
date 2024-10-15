// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeagueMatchShamMatchUpExhibit
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
  [Token(Token = "0x2003467")]
  public class LeagueMatchShamMatchUpExhibit : 
    BaseExhibit,
    IRenderModel<LeagueMatchShamMatchUpModel>,
    IRenderModel
  {
    [Token(Token = "0x400F8A3")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeagueMatchShamMatchUpExhibit.EKey), typeof (LeagueMatchShamMatchUpExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400F8A4")]
    [FieldOffset(Offset = "0x38")]
    [CustomField("アイコンのオブジェクト", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("ユニット")]
    public GameObject UnitTemplate;
    [Token(Token = "0x400F8A5")]
    [FieldOffset(Offset = "0x3C")]
    private List<ExhibitList> mCreateUnits;

    [Token(Token = "0x600E987")]
    [Address(RVA = "0xAE2370", Offset = "0xAE1170", VA = "0x10AE2370", Slot = "8")]
    public void Render(LeagueMatchShamMatchUpModel model)
    {
    }

    [Token(Token = "0x600E988")]
    [Address(RVA = "0xAE20E0", Offset = "0xAE0EE0", VA = "0x10AE20E0")]
    private void CreateUnitIcons(List<Unit> units)
    {
    }

    [Token(Token = "0x600E989")]
    [Address(RVA = "0xAE2620", Offset = "0xAE1420", VA = "0x10AE2620")]
    public LeagueMatchShamMatchUpExhibit()
    {
    }

    [Token(Token = "0x2003468")]
    private enum EKey
    {
      [Token(Token = "0x400F8A7")] None,
      [Token(Token = "0x400F8A8")] OffenseUnits,
      [Token(Token = "0x400F8A9")] OffenseTotalCombatPower,
      [Token(Token = "0x400F8AA")] OffenseResultWin,
      [Token(Token = "0x400F8AB")] OffenseResultLose,
      [Token(Token = "0x400F8AC")] DefenseUnits,
      [Token(Token = "0x400F8AD")] DefenseTotalCombatPower,
      [Token(Token = "0x400F8AE")] DefenseResultWin,
      [Token(Token = "0x400F8AF")] DefenseResultLose,
      [Token(Token = "0x400F8B0")] AutoBtn,
      [Token(Token = "0x400F8B1")] BattleReadyParent,
      [Token(Token = "0x400F8B2")] BattleResultParent,
    }
  }
}
