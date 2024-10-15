// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.CrystalSetBonusWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003423")]
  public class CrystalSetBonusWindowExhibit : 
    BaseExhibit,
    IRenderModel<CrystalSetBonusWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400F756")]
    [FieldOffset(Offset = "0x34")]
    public CrystalIcon MainCrystalIcon;
    [Token(Token = "0x400F757")]
    [FieldOffset(Offset = "0x38")]
    public List<CrystalIcon> SubCrystalIconList;
    [Token(Token = "0x400F758")]
    [FieldOffset(Offset = "0x3C")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (CrystalSetBonusWindowExhibit.EKey), typeof (CrystalSetBonusWindowExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600E911")]
    [Address(RVA = "0xADBB70", Offset = "0xADA970", VA = "0x10ADBB70", Slot = "8")]
    public void Render(CrystalSetBonusWindowModel model)
    {
    }

    [Token(Token = "0x600E912")]
    [Address(RVA = "0xADBD00", Offset = "0xADAB00", VA = "0x10ADBD00")]
    private void SetCrystal(CrystalSetBonusWindowModel model)
    {
    }

    [Token(Token = "0x600E913")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalSetBonusWindowExhibit()
    {
    }

    [Token(Token = "0x2003424")]
    private enum EKey
    {
      [Token(Token = "0x400F75A")] None,
      [Token(Token = "0x400F75B")] SetBonusTitle,
      [Token(Token = "0x400F75C")] SetBonusExpr,
      [Token(Token = "0x400F75D")] CrystalIcon,
      [Token(Token = "0x400F75E")] SetBonusRate,
    }
  }
}
