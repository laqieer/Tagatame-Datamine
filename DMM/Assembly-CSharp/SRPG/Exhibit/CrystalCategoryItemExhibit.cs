// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.CrystalCategoryItemExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20033FD")]
  public class CrystalCategoryItemExhibit : 
    BaseExhibit,
    IRenderModel<CrystalCategoryItemModel>,
    IRenderModel
  {
    [Token(Token = "0x400F68E")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (CrystalCategoryItemExhibit.EKey), typeof (CrystalCategoryItemExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600E8E0")]
    [Address(RVA = "0xAD92F0", Offset = "0xAD80F0", VA = "0x10AD92F0", Slot = "8")]
    public void Render(CrystalCategoryItemModel _model)
    {
    }

    [Token(Token = "0x600E8E1")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalCategoryItemExhibit()
    {
    }

    [Token(Token = "0x20033FE")]
    private enum EKey
    {
      [Token(Token = "0x400F690")] None,
      [Token(Token = "0x400F691")] TitleObj,
      [Token(Token = "0x400F692")] TitleText,
      [Token(Token = "0x400F693")] SubObj,
      [Token(Token = "0x400F694")] SubText,
    }
  }
}
