// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.CrystalBulkGradeUpWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200341B")]
  public class CrystalBulkGradeUpWindowExhibit : 
    BaseExhibit,
    IRenderModel<CrystalBulkGradeUpWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400F72D")]
    [FieldOffset(Offset = "0x34")]
    public CrystalIcon mCrystalIcon;
    [Token(Token = "0x400F72E")]
    [FieldOffset(Offset = "0x38")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (CrystalBulkGradeUpWindowExhibit.EKey), typeof (CrystalBulkGradeUpWindowExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600E905")]
    [Address(RVA = "0xAD8F40", Offset = "0xAD7D40", VA = "0x10AD8F40", Slot = "8")]
    public void Render(CrystalBulkGradeUpWindowModel _model)
    {
    }

    [Token(Token = "0x600E906")]
    [Address(RVA = "0xAD91F0", Offset = "0xAD7FF0", VA = "0x10AD91F0")]
    private void SetCrystalIcon(CrystalData data)
    {
    }

    [Token(Token = "0x600E907")]
    [Address(RVA = "0xAD9270", Offset = "0xAD8070", VA = "0x10AD9270")]
    private void SetToggleFunc(bool value)
    {
    }

    [Token(Token = "0x600E908")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalBulkGradeUpWindowExhibit()
    {
    }

    [Token(Token = "0x200341C")]
    private enum EKey
    {
      [Token(Token = "0x400F730")] None,
      [Token(Token = "0x400F731")] ExecToggle,
      [Token(Token = "0x400F732")] BaseIcon,
      [Token(Token = "0x400F733")] MaterialIcon,
      [Token(Token = "0x400F734")] PreRankImage,
      [Token(Token = "0x400F735")] AfterRankImage,
      [Token(Token = "0x400F736")] MaterialAmount,
      [Token(Token = "0x400F737")] ResultIcon,
      [Token(Token = "0x400F738")] DetailButtonParent,
      [Token(Token = "0x400F739")] DetailButtonChildren,
    }
  }
}
