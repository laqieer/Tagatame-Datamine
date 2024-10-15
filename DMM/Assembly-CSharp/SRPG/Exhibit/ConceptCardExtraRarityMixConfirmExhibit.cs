// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.ConceptCardExtraRarityMixConfirmExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20033F7")]
  public class ConceptCardExtraRarityMixConfirmExhibit : 
    BaseExhibit,
    IRenderModel<ConceptCardExtraRarityMixConfirmModel>,
    IRenderModel
  {
    [Token(Token = "0x400F66B")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (ConceptCardExtraRarityMixConfirmExhibit.EKey), typeof (ConceptCardExtraRarityMixConfirmExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600E8DA")]
    [Address(RVA = "0xAD8370", Offset = "0xAD7170", VA = "0x10AD8370", Slot = "8")]
    public void Render(ConceptCardExtraRarityMixConfirmModel model)
    {
    }

    [Token(Token = "0x600E8DB")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardExtraRarityMixConfirmExhibit()
    {
    }

    [Token(Token = "0x20033F8")]
    private enum EKey
    {
      [Token(Token = "0x400F66D")] None,
      [Token(Token = "0x400F66E")] CONCEPT_CARD_ICON,
    }
  }
}
