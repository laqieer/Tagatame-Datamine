// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.BulkReleaseEquipUnitContentNodeExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003429")]
  public class BulkReleaseEquipUnitContentNodeExhibit : 
    BaseExhibit,
    IRenderModel<BulkReleaseEquipUnitContentNodeModel>,
    IRenderModel
  {
    [Token(Token = "0x400F770")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (BulkReleaseEquipUnitContentNodeExhibit.EKey), typeof (BulkReleaseEquipUnitContentNodeExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400F771")]
    [FieldOffset(Offset = "0x38")]
    public ExhibitList m_UnitIcon;
    [Token(Token = "0x400F772")]
    [FieldOffset(Offset = "0x3C")]
    public ContentExhibit m_ContentExhibit;

    [Token(Token = "0x600E918")]
    [Address(RVA = "0xAD7860", Offset = "0xAD6660", VA = "0x10AD7860", Slot = "8")]
    public void Render(BulkReleaseEquipUnitContentNodeModel model)
    {
    }

    [Token(Token = "0x600E919")]
    [Address(RVA = "0xAD77A0", Offset = "0xAD65A0", VA = "0x10AD77A0")]
    public void BadgeRender(List<PartyToggleModel> Models)
    {
    }

    [Token(Token = "0x600E91A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BulkReleaseEquipUnitContentNodeExhibit()
    {
    }

    [Token(Token = "0x200342A")]
    private enum EKey
    {
      [Token(Token = "0x400F774")] None,
      [Token(Token = "0x400F775")] UnitIcon,
      [Token(Token = "0x400F776")] BadgeVisibleNone,
      [Token(Token = "0x400F777")] BadgeVisibleArena,
      [Token(Token = "0x400F778")] BadgeVisibleSupport,
      [Token(Token = "0x400F779")] BadgeVisibleGvG,
      [Token(Token = "0x400F77A")] BadgeVisibleLeagueMatch,
      [Token(Token = "0x400F77B")] Badges,
    }
  }
}
