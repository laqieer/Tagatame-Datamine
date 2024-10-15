// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.PointQuestPersonRankingContentNodeExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003489")]
  public class PointQuestPersonRankingContentNodeExhibit : 
    BaseExhibit,
    IRenderModel<PointQuestPersonRankingContentNodeModel>,
    IRenderModel
  {
    [Token(Token = "0x400F948")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (PointQuestPersonRankingContentNodeExhibit.EKey), typeof (PointQuestPersonRankingContentNodeExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400F949")]
    [FieldOffset(Offset = "0x38")]
    public ExhibitList UnitIconExhibitList;

    [Token(Token = "0x600E9B2")]
    [Address(RVA = "0xAE5D70", Offset = "0xAE4B70", VA = "0x10AE5D70", Slot = "8")]
    public void Render(PointQuestPersonRankingContentNodeModel model)
    {
    }

    [Token(Token = "0x600E9B3")]
    [Address(RVA = "0xAE60D0", Offset = "0xAE4ED0", VA = "0x10AE60D0")]
    public void UnitIconUpdate(UnitModel model)
    {
    }

    [Token(Token = "0x600E9B4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PointQuestPersonRankingContentNodeExhibit()
    {
    }

    [Token(Token = "0x200348A")]
    private enum EKey
    {
      [Token(Token = "0x400F94B")] None,
      [Token(Token = "0x400F94C")] UnitIcon,
      [Token(Token = "0x400F94D")] RankingImage,
      [Token(Token = "0x400F94E")] RankingText,
      [Token(Token = "0x400F94F")] RankingOutRangeText,
      [Token(Token = "0x400F950")] RankingNotAttended,
      [Token(Token = "0x400F951")] UserNameText,
      [Token(Token = "0x400F952")] QuestTitleText,
      [Token(Token = "0x400F953")] QuestNameText,
      [Token(Token = "0x400F954")] QuestBgImgPath,
      [Token(Token = "0x400F955")] LevelText,
      [Token(Token = "0x400F956")] ScoreText,
      [Token(Token = "0x400F957")] Mask,
    }
  }
}
