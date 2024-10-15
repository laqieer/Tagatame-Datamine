// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.CrystalCategoryToggleExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003401")]
  public class CrystalCategoryToggleExhibit : 
    BaseExhibit,
    IRenderModel<CrystalCategoryToggleModel>,
    IRenderModel
  {
    [Token(Token = "0x400F699")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (CrystalCategoryToggleExhibit.EKey), typeof (CrystalCategoryToggleExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600E8E4")]
    [Address(RVA = "0xAD95E0", Offset = "0xAD83E0", VA = "0x10AD95E0", Slot = "8")]
    public void Render(CrystalCategoryToggleModel _model)
    {
    }

    [Token(Token = "0x600E8E5")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalCategoryToggleExhibit()
    {
    }

    [Token(Token = "0x2003402")]
    private enum EKey
    {
      [Token(Token = "0x400F69B")] None,
      [Token(Token = "0x400F69C")] ButtonText,
    }
  }
}
