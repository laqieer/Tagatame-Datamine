// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.ArtiStoneEffect_ExchangeConfirmExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20033EB")]
  public class ArtiStoneEffect_ExchangeConfirmExhibit : 
    BaseExhibit,
    IRenderModel<ArtiStoneEffect_ExchangeConfirmModel>,
    IRenderModel
  {
    [Token(Token = "0x400F60C")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (ArtiStoneEffect_ExchangeConfirmExhibit.EKey), typeof (ArtiStoneEffect_ExchangeConfirmExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400F60D")]
    [FieldOffset(Offset = "0x38")]
    public ContentExhibit mContentExhibit;

    [Token(Token = "0x600E8C0")]
    [Address(RVA = "0xAD5C30", Offset = "0xAD4A30", VA = "0x10AD5C30", Slot = "8")]
    public void Render(ArtiStoneEffect_ExchangeConfirmModel model)
    {
    }

    [Token(Token = "0x600E8C1")]
    [Address(RVA = "0xAD5E90", Offset = "0xAD4C90", VA = "0x10AD5E90")]
    private void SetIcons(List<ArtifactIconBlockContentNodeModel> models)
    {
    }

    [Token(Token = "0x600E8C2")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtiStoneEffect_ExchangeConfirmExhibit()
    {
    }

    [Token(Token = "0x20033EC")]
    private enum EKey
    {
      [Token(Token = "0x400F60F")] None,
      [Token(Token = "0x400F610")] ArtifactCheck,
      [Token(Token = "0x400F611")] ArtifactCheckIcons,
      [Token(Token = "0x400F612")] ArtifactCheckNum,
      [Token(Token = "0x400F613")] ArtifactCheckExchangePoint,
      [Token(Token = "0x400F614")] ArtifactCheckCautionText,
      [Token(Token = "0x400F615")] RarityCheck,
      [Token(Token = "0x400F616")] RarityCheckIcons,
      [Token(Token = "0x400F617")] RarityCheckText,
    }
  }
}
