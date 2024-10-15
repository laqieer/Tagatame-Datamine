// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeagueMatchReadyExhibit
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
  [Token(Token = "0x2003465")]
  public class LeagueMatchReadyExhibit : 
    BaseExhibit,
    IRenderModel<LeagueMatchReadyModel>,
    IRenderModel
  {
    [Token(Token = "0x400F891")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeagueMatchReadyExhibit.EKey), typeof (LeagueMatchReadyExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400F892")]
    [FieldOffset(Offset = "0x38")]
    [CustomField("アイコンのオブジェクト", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("ユニット")]
    public GameObject UnitTemplate;
    [Token(Token = "0x400F893")]
    [FieldOffset(Offset = "0x3C")]
    private List<ExhibitList> mPlayerUnits;
    [Token(Token = "0x400F894")]
    [FieldOffset(Offset = "0x40")]
    private List<ExhibitList> mEnemyUnits;
    [Token(Token = "0x400F895")]
    [FieldOffset(Offset = "0x44")]
    private List<ExhibitList> mEnemyHideUnits;

    [Token(Token = "0x600E984")]
    [Address(RVA = "0xAE19C0", Offset = "0xAE07C0", VA = "0x10AE19C0", Slot = "8")]
    public void Render(LeagueMatchReadyModel model)
    {
    }

    [Token(Token = "0x600E985")]
    [Address(RVA = "0xAE1580", Offset = "0xAE0380", VA = "0x10AE1580")]
    private void CreateUnitIcons(
      List<UnitModel> unit_models,
      ref List<ExhibitList> unit_exhibit_list,
      List<ExhibitList> hideUnit_exhibit_list)
    {
    }

    [Token(Token = "0x600E986")]
    [Address(RVA = "0xAE1C80", Offset = "0xAE0A80", VA = "0x10AE1C80")]
    public LeagueMatchReadyExhibit()
    {
    }

    [Token(Token = "0x2003466")]
    private enum EKey
    {
      [Token(Token = "0x400F897")] None,
      [Token(Token = "0x400F898")] P_Units,
      [Token(Token = "0x400F899")] P_Name,
      [Token(Token = "0x400F89A")] P_TotalCombatPower,
      [Token(Token = "0x400F89B")] P_Rank,
      [Token(Token = "0x400F89C")] P_Point,
      [Token(Token = "0x400F89D")] E_Units,
      [Token(Token = "0x400F89E")] E_Name,
      [Token(Token = "0x400F89F")] E_TotalCombatPower,
      [Token(Token = "0x400F8A0")] E_Rank,
      [Token(Token = "0x400F8A1")] E_Point,
      [Token(Token = "0x400F8A2")] AutoBtn,
    }
  }
}
