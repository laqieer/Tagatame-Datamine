// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.CrystalScrollListExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine.UI;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003409")]
  public class CrystalScrollListExhibit : 
    BaseExhibit,
    IRenderModel<CrystalScrollListModel>,
    IRenderModel
  {
    [Token(Token = "0x400F6D4")]
    [FieldOffset(Offset = "0x34")]
    public Outline OutlineText;
    [Token(Token = "0x400F6D5")]
    [FieldOffset(Offset = "0x38")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (CrystalScrollListExhibit.EKey), typeof (CrystalScrollListExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E8EF")]
    [Address(RVA = "0xADB6E0", Offset = "0xADA4E0", VA = "0x10ADB6E0", Slot = "8")]
    public void Render(CrystalScrollListModel _model)
    {
    }

    [Token(Token = "0x600E8F0")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalScrollListExhibit()
    {
    }

    [Token(Token = "0x200340A")]
    private enum EKey
    {
      [Token(Token = "0x400F6D7")] None,
      [Token(Token = "0x400F6D8")] SortName,
      [Token(Token = "0x400F6D9")] FilterButtonImage,
      [Token(Token = "0x400F6DA")] FilterButtonOutLine,
    }
  }
}
