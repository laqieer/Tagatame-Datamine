// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.CrystalGradeUpWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200341F")]
  public class CrystalGradeUpWindowExhibit : 
    BaseExhibit,
    IRenderModel<CrystalGradeUpWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400F744")]
    [FieldOffset(Offset = "0x34")]
    public CrystalIcon MaterialCrystalIcon;
    [Token(Token = "0x400F745")]
    [FieldOffset(Offset = "0x38")]
    public CrystalIcon ResultCrystalIcon;
    [Token(Token = "0x400F746")]
    [FieldOffset(Offset = "0x3C")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (CrystalGradeUpWindowExhibit.EKey), typeof (CrystalGradeUpWindowExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600E90B")]
    [Address(RVA = "0xADA2D0", Offset = "0xAD90D0", VA = "0x10ADA2D0", Slot = "8")]
    public void Render(CrystalGradeUpWindowModel _model)
    {
    }

    [Token(Token = "0x600E90C")]
    [Address(RVA = "0xADA500", Offset = "0xAD9300", VA = "0x10ADA500")]
    private void SetCrystalIcon(CrystalIcon icon, CrystalData data)
    {
    }

    [Token(Token = "0x600E90D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalGradeUpWindowExhibit()
    {
    }

    [Token(Token = "0x2003420")]
    private enum EKey
    {
      [Token(Token = "0x400F748")] None,
      [Token(Token = "0x400F749")] CrystalName,
      [Token(Token = "0x400F74A")] IconImage,
      [Token(Token = "0x400F74B")] RankImage,
      [Token(Token = "0x400F74C")] RankImageAfter,
      [Token(Token = "0x400F74D")] MaterialIcon,
      [Token(Token = "0x400F74E")] ResultIcon,
    }
  }
}
