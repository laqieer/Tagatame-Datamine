// Decompiled with JetBrains decompiler
// Type: SRPG.Models.PointQuestChapterSelectorModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003376")]
  public class PointQuestChapterSelectorModel
  {
    [Token(Token = "0x400F32F")]
    [FieldOffset(Offset = "0x8")]
    private string mTitleText;
    [Token(Token = "0x400F330")]
    [FieldOffset(Offset = "0xC")]
    private int mClearCount;
    [Token(Token = "0x400F331")]
    [FieldOffset(Offset = "0x10")]
    private int mQuestCount;
    [Token(Token = "0x400F332")]
    [FieldOffset(Offset = "0x14")]
    private bool mLeftArrowButton;
    [Token(Token = "0x400F333")]
    [FieldOffset(Offset = "0x15")]
    private bool mRightArrowButton;

    [Token(Token = "0x17001F53")]
    public string TitleText
    {
      [Token(Token = "0x600E481"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F54")]
    public string ClearCountText
    {
      [Token(Token = "0x600E482"), Address(RVA = "0xABBDB0", Offset = "0xABABB0", VA = "0x10ABBDB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F55")]
    public string QuestCountText
    {
      [Token(Token = "0x600E483"), Address(RVA = "0xABB560", Offset = "0xABA360", VA = "0x10ABB560")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F56")]
    public bool LeftArrowButton
    {
      [Token(Token = "0x600E484"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F57")]
    public bool RightArrowButton
    {
      [Token(Token = "0x600E485"), Address(RVA = "0x39C2B0", Offset = "0x39B0B0", VA = "0x1039C2B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E486")]
    [Address(RVA = "0xABBC40", Offset = "0xABAA40", VA = "0x10ABBC40")]
    public void SetData(
      ChapterParam _param,
      List<QuestParam> _quest_list,
      bool _is_left_arrow,
      bool _is_right_arrow)
    {
    }

    [Token(Token = "0x600E487")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestChapterSelectorModel()
    {
    }
  }
}
