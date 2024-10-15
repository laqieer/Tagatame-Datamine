// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.CrystalDisassembleResultWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003415")]
  public class CrystalDisassembleResultWindowExhibit : 
    BaseExhibit,
    IRenderModel<CrystalDisassembleWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400F717")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (CrystalDisassembleResultWindowExhibit.EKey), typeof (CrystalDisassembleResultWindowExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600E8FE")]
    [Address(RVA = "0xAD9B10", Offset = "0xAD8910", VA = "0x10AD9B10", Slot = "8")]
    public void Render(CrystalDisassembleWindowModel _model)
    {
    }

    [Token(Token = "0x600E8FF")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalDisassembleResultWindowExhibit()
    {
    }

    [Token(Token = "0x2003416")]
    private enum EKey
    {
      [Token(Token = "0x400F719")] None,
      [Token(Token = "0x400F71A")] CrystalName,
      [Token(Token = "0x400F71B")] RankImage,
      [Token(Token = "0x400F71C")] IconImage,
    }
  }
}
