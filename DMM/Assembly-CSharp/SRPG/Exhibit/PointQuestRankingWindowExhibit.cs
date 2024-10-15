// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.PointQuestRankingWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200348F")]
  public class PointQuestRankingWindowExhibit : 
    BaseExhibit,
    IRenderModel<PointQuestRankingWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400F96A")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (PointQuestRankingWindowExhibit.EKey), typeof (PointQuestRankingWindowExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400F96B")]
    [FieldOffset(Offset = "0x38")]
    public ExhibitList m_MinePersonRankingExhibitList;
    [Token(Token = "0x400F96C")]
    [FieldOffset(Offset = "0x3C")]
    public ContentExhibit m_PersonRankingExhibitList;
    [Token(Token = "0x400F96D")]
    [FieldOffset(Offset = "0x40")]
    public ExhibitList m_MinePortRankingExhibitList;
    [Token(Token = "0x400F96E")]
    [FieldOffset(Offset = "0x44")]
    public ContentExhibit m_PortRankingExhibitList;

    [Token(Token = "0x600E9B9")]
    [Address(RVA = "0xAE67E0", Offset = "0xAE55E0", VA = "0x10AE67E0", Slot = "8")]
    public void Render(PointQuestRankingWindowModel model)
    {
    }

    [Token(Token = "0x600E9BA")]
    [Address(RVA = "0xAE6660", Offset = "0xAE5460", VA = "0x10AE6660")]
    public void PersonRankingContentNodeUpdate(
      List<PointQuestPersonRankingContentNodeModel> models)
    {
    }

    [Token(Token = "0x600E9BB")]
    [Address(RVA = "0xAE6560", Offset = "0xAE5360", VA = "0x10AE6560")]
    public void MinePersonRankingContentNodeUpdate(PointQuestPersonRankingContentNodeModel model)
    {
    }

    [Token(Token = "0x600E9BC")]
    [Address(RVA = "0xAE6720", Offset = "0xAE5520", VA = "0x10AE6720")]
    public void PortRankingContentNodeUpdate(List<PointQuestPortRankingContentNodeModel> models)
    {
    }

    [Token(Token = "0x600E9BD")]
    [Address(RVA = "0xAE65E0", Offset = "0xAE53E0", VA = "0x10AE65E0")]
    public void MinePortRankingContentNodeUpdate(PointQuestPortRankingContentNodeModel model)
    {
    }

    [Token(Token = "0x600E9BE")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PointQuestRankingWindowExhibit()
    {
    }

    [Token(Token = "0x2003490")]
    private enum EKey
    {
      [Token(Token = "0x400F970")] None,
      [Token(Token = "0x400F971")] PersonRanking,
      [Token(Token = "0x400F972")] PortRanking,
      [Token(Token = "0x400F973")] MinePersonRanking,
      [Token(Token = "0x400F974")] MinePortRanking,
      [Token(Token = "0x400F975")] TabGroup,
      [Token(Token = "0x400F976")] Pulldown,
    }
  }
}
