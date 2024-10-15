// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.CrystalStatusItemExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200340B")]
  public class CrystalStatusItemExhibit : 
    BaseExhibit,
    IRenderModel<CrystalStatusItemModel>,
    IRenderModel
  {
    [Token(Token = "0x400F6DB")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (CrystalStatusItemExhibit.EKey), typeof (CrystalStatusItemExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E8F1")]
    [Address(RVA = "0xADBEF0", Offset = "0xADACF0", VA = "0x10ADBEF0", Slot = "8")]
    public void Render(CrystalStatusItemModel _model)
    {
    }

    [Token(Token = "0x600E8F2")]
    [Address(RVA = "0xADC0E0", Offset = "0xADAEE0", VA = "0x10ADC0E0")]
    private new void SetTextColor(Color _color)
    {
    }

    [Token(Token = "0x600E8F3")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalStatusItemExhibit()
    {
    }

    [Token(Token = "0x200340C")]
    private enum EKey
    {
      [Token(Token = "0x400F6DD")] None,
      [Token(Token = "0x400F6DE")] ParamName,
      [Token(Token = "0x400F6DF")] ParamText,
      [Token(Token = "0x400F6E0")] ParamEquip,
      [Token(Token = "0x400F6E1")] ParamLimit,
    }
  }
}
