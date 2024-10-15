// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeagueMatchUnitHideExhibit
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
  [Token(Token = "0x200344F")]
  public class LeagueMatchUnitHideExhibit : 
    BaseExhibit,
    IRenderModel<LeagueMatchUnitHideModel>,
    IRenderModel
  {
    [Token(Token = "0x400F806")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeagueMatchUnitHideExhibit.EKey), typeof (LeagueMatchUnitHideExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;
    [Token(Token = "0x400F807")]
    [FieldOffset(Offset = "0x38")]
    [CustomField("非表示リスト", CustomFieldAttribute.Type.Array)]
    public List<GameObject> objectList;
    [Token(Token = "0x400F808")]
    [FieldOffset(Offset = "0x3C")]
    [CustomField("表示リスト", CustomFieldAttribute.Type.Array)]
    public List<GameObject> showObjectList;

    [Token(Token = "0x600E964")]
    [Address(RVA = "0xAE2C00", Offset = "0xAE1A00", VA = "0x10AE2C00", Slot = "8")]
    public void Render(LeagueMatchUnitHideModel model)
    {
    }

    [Token(Token = "0x600E965")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchUnitHideExhibit()
    {
    }

    [Token(Token = "0x2003450")]
    private enum EKey
    {
      [Token(Token = "0x400F80A")] None,
      [Token(Token = "0x400F80B")] ALL,
      [Token(Token = "0x400F80C")] UnitJob,
      [Token(Token = "0x400F80D")] UnitLevel,
      [Token(Token = "0x400F80E")] UnitRarity,
    }
  }
}
