// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.CrystalDisassembleWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003417")]
  public class CrystalDisassembleWindowExhibit : 
    BaseExhibit,
    IRenderModel<CrystalDisassembleWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400F71D")]
    [FieldOffset(Offset = "0x34")]
    public CrystalIcon BaseCrystalIcon;
    [Token(Token = "0x400F71E")]
    [FieldOffset(Offset = "0x38")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (CrystalDisassembleWindowExhibit.EKey), typeof (CrystalDisassembleWindowExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E900")]
    [Address(RVA = "0xAD9C70", Offset = "0xAD8A70", VA = "0x10AD9C70", Slot = "8")]
    public void Render(CrystalDisassembleWindowModel _model)
    {
    }

    [Token(Token = "0x600E901")]
    [Address(RVA = "0xAD9E30", Offset = "0xAD8C30", VA = "0x10AD9E30")]
    private void SetCrystalIcon(CrystalData data)
    {
    }

    [Token(Token = "0x600E902")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalDisassembleWindowExhibit()
    {
    }

    [Token(Token = "0x2003418")]
    private enum EKey
    {
      [Token(Token = "0x400F720")] None,
      [Token(Token = "0x400F721")] BaseIcon,
      [Token(Token = "0x400F722")] PreRankImage,
      [Token(Token = "0x400F723")] AfterRankImage,
      [Token(Token = "0x400F724")] ResultIcon,
    }
  }
}
