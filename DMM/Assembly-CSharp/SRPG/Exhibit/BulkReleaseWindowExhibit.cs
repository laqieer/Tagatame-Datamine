// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.BulkReleaseWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200342B")]
  public class BulkReleaseWindowExhibit : 
    BaseExhibit,
    IRenderModel<BulkReleaseWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400F77C")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (BulkReleaseWindowExhibit.EKey), typeof (BulkReleaseWindowExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;
    [Token(Token = "0x400F77D")]
    [FieldOffset(Offset = "0x38")]
    public ContentExhibit m_ContentExhibit;

    [Token(Token = "0x600E91B")]
    [Address(RVA = "0xAD7D00", Offset = "0xAD6B00", VA = "0x10AD7D00", Slot = "8")]
    public void Render(BulkReleaseWindowModel model)
    {
    }

    [Token(Token = "0x600E91C")]
    [Address(RVA = "0xAD7C80", Offset = "0xAD6A80", VA = "0x10AD7C80")]
    private void ContentNodeRender(List<BulkReleaseEquipUnitContentNodeModel> Models)
    {
    }

    [Token(Token = "0x600E91D")]
    [Address(RVA = "0xAD7BC0", Offset = "0xAD69C0", VA = "0x10AD7BC0")]
    private void BadgeContentNodeRender(List<PartyToggleModel> Models)
    {
    }

    [Token(Token = "0x600E91E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BulkReleaseWindowExhibit()
    {
    }

    [Token(Token = "0x200342C")]
    private enum EKey
    {
      [Token(Token = "0x400F77F")] None,
      [Token(Token = "0x400F780")] BadgeContentNode,
      [Token(Token = "0x400F781")] ContentNode,
      [Token(Token = "0x400F782")] ContentNode2,
      [Token(Token = "0x400F783")] OkButton,
      [Token(Token = "0x400F784")] NoneText,
    }
  }
}
