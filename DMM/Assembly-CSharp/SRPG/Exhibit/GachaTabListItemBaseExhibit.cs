// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.GachaTabListItemBaseExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003439")]
  public class GachaTabListItemBaseExhibit : 
    BaseExhibit,
    IRenderModel<GachaTabListItemBaseModel>,
    IRenderModel
  {
    [Token(Token = "0x400F79F")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (GachaTabListItemBaseExhibit.BaseEKey), typeof (GachaTabListItemBaseExhibit))]
    public string m_BaseKeyName;
    [Token(Token = "0x400F7A0")]
    [FieldOffset(Offset = "0x38")]
    [CustomField("サイズ変更", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("タブ")]
    public GameObject tabObject;

    [Token(Token = "0x600E947")]
    [Address(RVA = "0xADC8A0", Offset = "0xADB6A0", VA = "0x10ADC8A0", Slot = "8")]
    public void Render(GachaTabListItemBaseModel model)
    {
    }

    [Token(Token = "0x600E948")]
    [Address(RVA = "0xADCB80", Offset = "0xADB980", VA = "0x10ADCB80")]
    private void SetCursor(GachaTabListItemBaseModel model)
    {
    }

    [Token(Token = "0x600E949")]
    [Address(RVA = "0xADCB00", Offset = "0xADB900", VA = "0x10ADCB00")]
    private void SetButtonEnable(GachaTabListItemBaseModel model)
    {
    }

    [Token(Token = "0x600E94A")]
    [Address(RVA = "0xADCAF0", Offset = "0xADB8F0", VA = "0x10ADCAF0")]
    private void SetBadge(bool isBadgeEnable)
    {
    }

    [Token(Token = "0x600E94B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GachaTabListItemBaseExhibit()
    {
    }

    [Token(Token = "0x200343A")]
    private enum BaseEKey
    {
      [Token(Token = "0x400F7A2")] None,
      [Token(Token = "0x400F7A3")] Cursor,
      [Token(Token = "0x400F7A4")] Button,
      [Token(Token = "0x400F7A5")] BadgeValidator,
    }
  }
}
