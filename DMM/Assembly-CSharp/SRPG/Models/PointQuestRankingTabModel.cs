// Decompiled with JetBrains decompiler
// Type: SRPG.Models.PointQuestRankingTabModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003379")]
  public class PointQuestRankingTabModel
  {
    [Token(Token = "0x400F374")]
    [FieldOffset(Offset = "0x8")]
    private PointQuestRankingTab.RankingDrawType mRankingDrawType;
    [Token(Token = "0x400F375")]
    [FieldOffset(Offset = "0xC")]
    private PointQuestRankingTab.RankingRangeType mRankingRangeType;
    [Token(Token = "0x400F376")]
    [FieldOffset(Offset = "0x10")]
    private string mText;
    [Token(Token = "0x400F377")]
    [FieldOffset(Offset = "0x14")]
    private ChapterParam mChapter;
    [Token(Token = "0x400F378")]
    [FieldOffset(Offset = "0x18")]
    private PointQuestRankingWindow.RankingAPIType mApiType;
    [Token(Token = "0x400F379")]
    [FieldOffset(Offset = "0x1C")]
    private bool mIsToggleOn;

    [Token(Token = "0x17001F77")]
    public PointQuestRankingTab.RankingDrawType RankingDrawType
    {
      [Token(Token = "0x600E4BB"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new PointQuestRankingTab.RankingDrawType();
      }
    }

    [Token(Token = "0x17001F78")]
    public PointQuestRankingTab.RankingRangeType RankingRangeType
    {
      [Token(Token = "0x600E4BC"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new PointQuestRankingTab.RankingRangeType();
      }
    }

    [Token(Token = "0x17001F79")]
    public string Text
    {
      [Token(Token = "0x600E4BD"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F7A")]
    public ChapterParam Chapter
    {
      [Token(Token = "0x600E4BE"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (ChapterParam) null;
      }
    }

    [Token(Token = "0x17001F7B")]
    public PointQuestRankingWindow.RankingAPIType ApiType
    {
      [Token(Token = "0x600E4BF"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new PointQuestRankingWindow.RankingAPIType();
      }
    }

    [Token(Token = "0x17001F7C")]
    public bool IsToggleOn
    {
      [Token(Token = "0x600E4C0"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E4C1")]
    [Address(RVA = "0xABCC30", Offset = "0xABBA30", VA = "0x10ABCC30")]
    public void Initialize(
      PointQuestRankingTab.RankingDrawType drawType,
      PointQuestRankingTab.RankingRangeType rangeType,
      ChapterParam chapter)
    {
    }

    [Token(Token = "0x600E4C2")]
    [Address(RVA = "0xABCC80", Offset = "0xABBA80", VA = "0x10ABCC80")]
    public void SetApiType()
    {
    }

    [Token(Token = "0x600E4C3")]
    [Address(RVA = "0xABCD50", Offset = "0xABBB50", VA = "0x10ABCD50")]
    public void SetText(string text)
    {
    }

    [Token(Token = "0x600E4C4")]
    [Address(RVA = "0xABCCB0", Offset = "0xABBAB0", VA = "0x10ABCCB0")]
    public void SetChapterText(string text)
    {
    }

    [Token(Token = "0x600E4C5")]
    [Address(RVA = "0x2A5AE0", Offset = "0x2A48E0", VA = "0x102A5AE0")]
    public void SetToggleFlag(bool isFlag)
    {
    }

    [Token(Token = "0x600E4C6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestRankingTabModel()
    {
    }
  }
}
