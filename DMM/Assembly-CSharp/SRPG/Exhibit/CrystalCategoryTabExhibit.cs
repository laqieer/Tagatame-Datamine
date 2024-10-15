// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.CrystalCategoryTabExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20033FF")]
  public class CrystalCategoryTabExhibit : 
    BaseExhibit,
    IRenderModel<CrystalCategoryTabModel>,
    IRenderModel
  {
    [Token(Token = "0x400F695")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (CrystalCategoryTabExhibit.EKey), typeof (CrystalCategoryTabExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E8E2")]
    [Address(RVA = "0xAD94A0", Offset = "0xAD82A0", VA = "0x10AD94A0", Slot = "8")]
    public void Render(CrystalCategoryTabModel _model)
    {
    }

    [Token(Token = "0x600E8E3")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalCategoryTabExhibit()
    {
    }

    [Token(Token = "0x2003400")]
    private enum EKey
    {
      [Token(Token = "0x400F697")] None,
      [Token(Token = "0x400F698")] TabText,
    }
  }
}
