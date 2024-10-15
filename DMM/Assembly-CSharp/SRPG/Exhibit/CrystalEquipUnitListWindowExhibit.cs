// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.CrystalEquipUnitListWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200341D")]
  public class CrystalEquipUnitListWindowExhibit : 
    BaseExhibit,
    IRenderModel<CrystalEquipUnitListWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400F73A")]
    [FieldOffset(Offset = "0x34")]
    public ExhibitList mExhibitList;
    [Token(Token = "0x400F73B")]
    [FieldOffset(Offset = "0x38")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (CrystalEquipUnitListWindowExhibit.EKey), typeof (CrystalEquipUnitListWindowExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600E909")]
    [Address(RVA = "0xADA080", Offset = "0xAD8E80", VA = "0x10ADA080", Slot = "8")]
    public void Render(CrystalEquipUnitListWindowModel _model)
    {
    }

    [Token(Token = "0x600E90A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalEquipUnitListWindowExhibit()
    {
    }

    [Token(Token = "0x200341E")]
    private enum EKey
    {
      [Token(Token = "0x400F73D")] None,
      [Token(Token = "0x400F73E")] UnitIcon,
      [Token(Token = "0x400F73F")] QuestBadge,
      [Token(Token = "0x400F740")] ArenaBadge,
      [Token(Token = "0x400F741")] SupportBadge,
      [Token(Token = "0x400F742")] GvGBadge,
      [Token(Token = "0x400F743")] LeagueMatchBadge,
    }
  }
}
