// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.ConceptCardSlotExExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20033FB")]
  public class ConceptCardSlotExExhibit : 
    BaseExhibit,
    IRenderModel<ConceptCardSlotExModel>,
    IRenderModel
  {
    [Token(Token = "0x400F687")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (ConceptCardSlotExExhibit.EKey), typeof (ConceptCardSlotExExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E8DE")]
    [Address(RVA = "0xAD89E0", Offset = "0xAD77E0", VA = "0x10AD89E0", Slot = "8")]
    public void Render(ConceptCardSlotExModel model)
    {
    }

    [Token(Token = "0x600E8DF")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardSlotExExhibit()
    {
    }

    [Token(Token = "0x20033FC")]
    private enum EKey
    {
      [Token(Token = "0x400F689")] None,
      [Token(Token = "0x400F68A")] Disabled,
      [Token(Token = "0x400F68B")] OverlayImage,
      [Token(Token = "0x400F68C")] EnableGroupEffect,
      [Token(Token = "0x400F68D")] SettableIcon,
    }
  }
}
