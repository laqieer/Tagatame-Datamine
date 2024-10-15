// Decompiled with JetBrains decompiler
// Type: SRPG.Models.PointQuestRankingWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200337A")]
  public class PointQuestRankingWindowModel
  {
    [Token(Token = "0x400F37A")]
    [FieldOffset(Offset = "0x8")]
    private readonly string PERSON_RANKING_TAB_TEXT;
    [Token(Token = "0x400F37B")]
    [FieldOffset(Offset = "0xC")]
    private readonly string PORT_RANKING_TAB_TEXT;
    [Token(Token = "0x400F37C")]
    [FieldOffset(Offset = "0x10")]
    private readonly string PORTPERSON_RANKING_TAB_TEXT;
    [Token(Token = "0x400F37D")]
    private const int PageStart = 1;
    [Token(Token = "0x400F37E")]
    [FieldOffset(Offset = "0x14")]
    private PointQuestRankingTabModel mCurrentTabModel;
    [Token(Token = "0x400F37F")]
    [FieldOffset(Offset = "0x18")]
    private PointQuestRankingWindow.RankingAPIType mAPIType;
    [Token(Token = "0x400F380")]
    [FieldOffset(Offset = "0x1C")]
    private bool mIsPersonRanking;
    [Token(Token = "0x400F381")]
    [FieldOffset(Offset = "0x20")]
    private List<PointQuestRankingTabModel> mTabModelList;
    [Token(Token = "0x400F382")]
    [FieldOffset(Offset = "0x24")]
    private List<PointQuestRankingTabModel> mPullDownModelList;
    [Token(Token = "0x400F383")]
    [FieldOffset(Offset = "0x28")]
    private bool mIsOpenPort;
    [Token(Token = "0x400F384")]
    [FieldOffset(Offset = "0x2C")]
    private string mSelectedChapter;
    [Token(Token = "0x400F385")]
    [FieldOffset(Offset = "0x30")]
    private PointQuestRankingWindow.OpenPageType mPageType;
    [Token(Token = "0x400F386")]
    [FieldOffset(Offset = "0x34")]
    private int mTotalPageNum;
    [Token(Token = "0x400F387")]
    [FieldOffset(Offset = "0x38")]
    private int mPageNum;
    [Token(Token = "0x400F388")]
    [FieldOffset(Offset = "0x3C")]
    private PointQuestPersonRankingContentNodeModel mMinePersonRankingModel;
    [Token(Token = "0x400F389")]
    [FieldOffset(Offset = "0x40")]
    private List<PointQuestPersonRankingContentNodeModel> mPersonRankingModelList;
    [Token(Token = "0x400F38A")]
    [FieldOffset(Offset = "0x44")]
    private PointQuestPortRankingContentNodeModel mMinePortRankingModel;
    [Token(Token = "0x400F38B")]
    [FieldOffset(Offset = "0x48")]
    private List<PointQuestPortRankingContentNodeModel> mPortRankingModelList;
    [Token(Token = "0x400F38C")]
    [FieldOffset(Offset = "0x4C")]
    private string mReplaceToken;

    [Token(Token = "0x17001F7D")]
    public PointQuestRankingTabModel CurrentTabModel
    {
      [Token(Token = "0x600E4C7"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (PointQuestRankingTabModel) null;
      }
    }

    [Token(Token = "0x17001F7E")]
    public PointQuestRankingWindow.RankingAPIType APIType
    {
      [Token(Token = "0x600E4C8"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new PointQuestRankingWindow.RankingAPIType();
      }
    }

    [Token(Token = "0x17001F7F")]
    public bool IsPersonRanking
    {
      [Token(Token = "0x600E4C9"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F80")]
    public List<PointQuestRankingTabModel> TabModelList
    {
      [Token(Token = "0x600E4CA"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<PointQuestRankingTabModel>) null;
      }
    }

    [Token(Token = "0x17001F81")]
    public List<PointQuestRankingTabModel> PullDownModelList
    {
      [Token(Token = "0x600E4CB"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (List<PointQuestRankingTabModel>) null;
      }
    }

    [Token(Token = "0x17001F82")]
    public bool IsOpenPort
    {
      [Token(Token = "0x600E4CC"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F83")]
    public int TotalPageNum
    {
      [Token(Token = "0x600E4CD"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001F84")]
    public int PageNum
    {
      [Token(Token = "0x600E4CE"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001F85")]
    public PointQuestPersonRankingContentNodeModel MinePersonRankingModel
    {
      [Token(Token = "0x600E4CF"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return (PointQuestPersonRankingContentNodeModel) null;
      }
    }

    [Token(Token = "0x17001F86")]
    public List<PointQuestPersonRankingContentNodeModel> PersonRankingModelList
    {
      [Token(Token = "0x600E4D0"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (List<PointQuestPersonRankingContentNodeModel>) null;
      }
    }

    [Token(Token = "0x17001F87")]
    public PointQuestPortRankingContentNodeModel MinePortRankingModel
    {
      [Token(Token = "0x600E4D1"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return (PointQuestPortRankingContentNodeModel) null;
      }
    }

    [Token(Token = "0x17001F88")]
    public List<PointQuestPortRankingContentNodeModel> PortRankingModelList
    {
      [Token(Token = "0x600E4D2"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return (List<PointQuestPortRankingContentNodeModel>) null;
      }
    }

    [Token(Token = "0x600E4D3")]
    [Address(RVA = "0xABE4E0", Offset = "0xABD2E0", VA = "0x10ABE4E0")]
    public PointQuestRankingWindowModel(string replace_token)
    {
    }

    [Token(Token = "0x600E4D4")]
    [Address(RVA = "0xABCDC0", Offset = "0xABBBC0", VA = "0x10ABCDC0")]
    public void Initialize(PointQuestRankingWindow.OpenPageType type)
    {
    }

    [Token(Token = "0x600E4D5")]
    [Address(RVA = "0xABD280", Offset = "0xABC080", VA = "0x10ABD280")]
    public void SetInitTabModel()
    {
    }

    [Token(Token = "0x600E4D6")]
    [Address(RVA = "0xABD220", Offset = "0xABC020", VA = "0x10ABD220")]
    public bool SetCurrentTabModel(PointQuestRankingTabModel tabModel) => new bool();

    [Token(Token = "0x600E4D7")]
    [Address(RVA = "0xABD340", Offset = "0xABC140", VA = "0x10ABD340")]
    private void SetOpenPointQuest()
    {
    }

    [Token(Token = "0x600E4D8")]
    [Address(RVA = "0xABD410", Offset = "0xABC210", VA = "0x10ABD410")]
    private void SetOpenPort()
    {
    }

    [Token(Token = "0x600E4D9")]
    [Address(RVA = "0xABD1B0", Offset = "0xABBFB0", VA = "0x10ABD1B0")]
    private string RemakeChapterName(string src, string dest) => (string) null;

    [Token(Token = "0x600E4DA")]
    [Address(RVA = "0xABE000", Offset = "0xABCE00", VA = "0x10ABE000")]
    private void SetTabModelList(ChapterParam chapterParam)
    {
    }

    [Token(Token = "0x600E4DB")]
    [Address(RVA = "0xABDFD0", Offset = "0xABCDD0", VA = "0x10ABDFD0")]
    public void SetTabModelList(PointQuestRankingTabModel pulldownModel)
    {
    }

    [Token(Token = "0x600E4DC")]
    [Address(RVA = "0xABCF20", Offset = "0xABBD20", VA = "0x10ABCF20")]
    private bool IsPersonTab() => new bool();

    [Token(Token = "0x600E4DD")]
    [Address(RVA = "0xABD0B0", Offset = "0xABBEB0", VA = "0x10ABD0B0")]
    private bool IsPortTab() => new bool();

    [Token(Token = "0x600E4DE")]
    [Address(RVA = "0xABD010", Offset = "0xABBE10", VA = "0x10ABD010")]
    private bool IsPortJoin() => new bool();

    [Token(Token = "0x600E4DF")]
    [Address(RVA = "0xABCF00", Offset = "0xABBD00", VA = "0x10ABCF00")]
    public bool IsMaxPage() => new bool();

    [Token(Token = "0x600E4E0")]
    [Address(RVA = "0xABD1A0", Offset = "0xABBFA0", VA = "0x10ABD1A0")]
    public int NextPage() => new int();

    [Token(Token = "0x600E4E1")]
    [Address(RVA = "0xABD330", Offset = "0xABC130", VA = "0x10ABD330")]
    public void SetNextPage()
    {
    }

    [Token(Token = "0x600E4E2")]
    [Address(RVA = "0xABCDB0", Offset = "0xABBBB0", VA = "0x10ABCDB0")]
    public void InitPage()
    {
    }

    [Token(Token = "0x600E4E3")]
    [Address(RVA = "0xABDF40", Offset = "0xABCD40", VA = "0x10ABDF40")]
    public void SetRankingRequest(SerializeValueList svl)
    {
    }

    [Token(Token = "0x600E4E4")]
    [Address(RVA = "0xABD810", Offset = "0xABC610", VA = "0x10ABD810")]
    public void SetPersonRankingModel(ReqPointQuestRanking.Response res)
    {
    }

    [Token(Token = "0x600E4E5")]
    [Address(RVA = "0xABDCE0", Offset = "0xABCAE0", VA = "0x10ABDCE0")]
    public void SetPortRankingModel(ReqPointQuestGuildRanking.Response res)
    {
    }

    [Token(Token = "0x600E4E6")]
    [Address(RVA = "0xABDA70", Offset = "0xABC870", VA = "0x10ABDA70")]
    public void SetPortPersonRankingModel(ReqPointQuestGuildPersonRanking.Response res)
    {
    }
  }
}
