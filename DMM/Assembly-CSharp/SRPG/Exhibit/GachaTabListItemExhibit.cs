// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.GachaTabListItemExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200343B")]
  public class GachaTabListItemExhibit : 
    GachaTabListItemBaseExhibit,
    IRenderModel<GachaTabListItemModel>,
    IRenderModel
  {
    [Token(Token = "0x400F7A6")]
    [FieldOffset(Offset = "0x3C")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (GachaTabListItemExhibit.EKey), typeof (GachaTabListItemExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E94C")]
    [Address(RVA = "0xADCC40", Offset = "0xADBA40", VA = "0x10ADCC40", Slot = "9")]
    public void Render(GachaTabListItemModel model)
    {
    }

    [Token(Token = "0x600E94D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GachaTabListItemExhibit()
    {
    }

    [Token(Token = "0x200343C")]
    private enum EKey
    {
      [Token(Token = "0x400F7A8")] None,
      [Token(Token = "0x400F7A9")] Date,
      [Token(Token = "0x400F7AA")] TabImage,
      [Token(Token = "0x400F7AB")] ButtonInteractable,
    }
  }
}
