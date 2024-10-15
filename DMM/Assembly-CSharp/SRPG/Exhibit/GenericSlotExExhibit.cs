// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.GenericSlotExExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200343D")]
  public class GenericSlotExExhibit : BaseExhibit, IRenderModel<GenericSlotExModel>, IRenderModel
  {
    [Token(Token = "0x400F7AC")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (GenericSlotExExhibit.EKey), typeof (GenericSlotExExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400F7AD")]
    [FieldOffset(Offset = "0x38")]
    [CustomField("対象", CustomFieldAttribute.Type.Component, typeof (Graphic), null)]
    [CustomGroup("配色変更")]
    public Graphic m_Graphic;
    [Token(Token = "0x400F7AE")]
    [FieldOffset(Offset = "0x3C")]
    [CustomField("フラグ", CustomFieldAttribute.Type.Component, typeof (GenericSlotFlags), null)]
    [CustomGroup("スロットフラグ")]
    public GenericSlotFlags m_GenericSlotFlags;

    [Token(Token = "0x600E94E")]
    [Address(RVA = "0xADD3C0", Offset = "0xADC1C0", VA = "0x10ADD3C0", Slot = "8")]
    public void Render(GenericSlotExModel model)
    {
    }

    [Token(Token = "0x600E94F")]
    [Address(RVA = "0xADD660", Offset = "0xADC460", VA = "0x10ADD660")]
    public void SetColor(Color color)
    {
    }

    [Token(Token = "0x600E950")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GenericSlotExExhibit()
    {
    }

    [Token(Token = "0x200343E")]
    private enum EKey
    {
      [Token(Token = "0x400F7B0")] None,
      [Token(Token = "0x400F7B1")] MainGraphic,
      [Token(Token = "0x400F7B2")] BgImage,
      [Token(Token = "0x400F7B3")] Lock,
      [Token(Token = "0x400F7B4")] Plus,
      [Token(Token = "0x400F7B5")] HideIcon,
      [Token(Token = "0x400F7B6")] HideItem,
    }
  }
}
