// Decompiled with JetBrains decompiler
// Type: SRPG.Models.PointQuestPersonRankingContentNodeModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003377")]
  public class PointQuestPersonRankingContentNodeModel
  {
    [Token(Token = "0x400F334")]
    private const string NOT_AFFILIATION_TEXT = "sys.POINTQUEST_RANKING_NOT_AFFILIATION";
    [Token(Token = "0x400F335")]
    private const string NOTHING_LEVEL_TEXT = "sys.POINTQUEST_RANKING_NOTHING_LEVEL";
    [Token(Token = "0x400F336")]
    private const string NOTHING_SCORE_TEXT = "sys.POINTQUEST_RANKING_NOTHING_SCORE";
    [Token(Token = "0x400F337")]
    private const string DEFAULT_QUEST_TEXT = "sys.POINTQUEST_RANKING_DEFAULT_QUEST_TEXT";
    [Token(Token = "0x400F338")]
    private const int mRankingImageIndexMax = 4;
    [Token(Token = "0x400F339")]
    private const int mRankingDefault = 0;
    [Token(Token = "0x400F33A")]
    private const int mRankingStartRange = 1;
    [Token(Token = "0x400F33B")]
    [FieldOffset(Offset = "0x8")]
    private int mRankingRange;
    [Token(Token = "0x400F33C")]
    private const int mLevelMin = 1;
    [Token(Token = "0x400F33D")]
    private const int mLevelDefault = 0;
    [Token(Token = "0x400F33E")]
    private const int mScoreMin = 1;
    [Token(Token = "0x400F33F")]
    private const int mScoreDefault = 0;
    [Token(Token = "0x400F340")]
    [FieldOffset(Offset = "0xC")]
    private UnitData mUnitData;
    [Token(Token = "0x400F341")]
    [FieldOffset(Offset = "0x10")]
    private UnitModel mUnitIconModel;
    [Token(Token = "0x400F342")]
    [FieldOffset(Offset = "0x14")]
    private int mRanking;
    [Token(Token = "0x400F343")]
    [FieldOffset(Offset = "0x18")]
    private int mLevel;
    [Token(Token = "0x400F344")]
    [FieldOffset(Offset = "0x1C")]
    private string mSelectAward;
    [Token(Token = "0x400F345")]
    [FieldOffset(Offset = "0x20")]
    private string mQuestId;
    [Token(Token = "0x400F346")]
    [FieldOffset(Offset = "0x24")]
    private int mScore;
    [Token(Token = "0x400F347")]
    [FieldOffset(Offset = "0x28")]
    private AwardParam mAward;
    [Token(Token = "0x400F348")]
    [FieldOffset(Offset = "0x2C")]
    private int mRankingImageIndex;
    [Token(Token = "0x400F349")]
    [FieldOffset(Offset = "0x30")]
    private bool mRankingTextVisible;
    [Token(Token = "0x400F34A")]
    [FieldOffset(Offset = "0x34")]
    private string mRankingText;
    [Token(Token = "0x400F34B")]
    [FieldOffset(Offset = "0x38")]
    private bool mRankingOutRangeTextVisible;
    [Token(Token = "0x400F34C")]
    [FieldOffset(Offset = "0x39")]
    private bool mRankingNotAttendedTextVisible;
    [Token(Token = "0x400F34D")]
    [FieldOffset(Offset = "0x3C")]
    private string mUserNameText;
    [Token(Token = "0x400F34E")]
    [FieldOffset(Offset = "0x40")]
    private bool mQuestTitleTextVisible;
    [Token(Token = "0x400F34F")]
    [FieldOffset(Offset = "0x44")]
    private string mQuestTitleText;
    [Token(Token = "0x400F350")]
    [FieldOffset(Offset = "0x48")]
    private bool mQuestNameTextVisible;
    [Token(Token = "0x400F351")]
    [FieldOffset(Offset = "0x4C")]
    private string mQuestNameText;
    [Token(Token = "0x400F352")]
    [FieldOffset(Offset = "0x50")]
    private int mQuestBgIndex;
    [Token(Token = "0x400F353")]
    [FieldOffset(Offset = "0x54")]
    private string mLevelText;
    [Token(Token = "0x400F354")]
    [FieldOffset(Offset = "0x58")]
    private string mScoreText;
    [Token(Token = "0x400F355")]
    [FieldOffset(Offset = "0x5C")]
    private bool mIsMask;

    [Token(Token = "0x17001F58")]
    public UnitModel UnitIconModel
    {
      [Token(Token = "0x600E488"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (UnitModel) null;
      }
    }

    [Token(Token = "0x17001F59")]
    public int Ranking
    {
      [Token(Token = "0x600E489"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001F5A")]
    public int RankingImageIndex
    {
      [Token(Token = "0x600E48A"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001F5B")]
    public bool RankingTextVisible
    {
      [Token(Token = "0x600E48B"), Address(RVA = "0x380080", Offset = "0x37EE80", VA = "0x10380080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F5C")]
    public string RankingText
    {
      [Token(Token = "0x600E48C"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F5D")]
    public bool RankingOutRangeTextVisible
    {
      [Token(Token = "0x600E48D"), Address(RVA = "0x2836F0", Offset = "0x2824F0", VA = "0x102836F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F5E")]
    public bool RankingNotAttendedTextVisible
    {
      [Token(Token = "0x600E48E"), Address(RVA = "0x34AF90", Offset = "0x349D90", VA = "0x1034AF90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F5F")]
    public string UserNameText
    {
      [Token(Token = "0x600E48F"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F60")]
    public bool QuestTitleTextVisible
    {
      [Token(Token = "0x600E490"), Address(RVA = "0x288080", Offset = "0x286E80", VA = "0x10288080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F61")]
    public string QuestTitleText
    {
      [Token(Token = "0x600E491"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F62")]
    public bool QuestNameTextVisible
    {
      [Token(Token = "0x600E492"), Address(RVA = "0x661B10", Offset = "0x660910", VA = "0x10661B10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F63")]
    public string QuestNameText
    {
      [Token(Token = "0x600E493"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F64")]
    public int QuestBgIndex
    {
      [Token(Token = "0x600E494"), Address(RVA = "0x3490F0", Offset = "0x347EF0", VA = "0x103490F0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001F65")]
    public string LevelText
    {
      [Token(Token = "0x600E495"), Address(RVA = "0x349170", Offset = "0x347F70", VA = "0x10349170")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F66")]
    public string ScoreText
    {
      [Token(Token = "0x600E496"), Address(RVA = "0x349160", Offset = "0x347F60", VA = "0x10349160")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F67")]
    public bool IsMask
    {
      [Token(Token = "0x600E497"), Address(RVA = "0x685520", Offset = "0x684320", VA = "0x10685520")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E498")]
    [Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")]
    public void Initialize(int rankingRange)
    {
    }

    [Token(Token = "0x600E499")]
    [Address(RVA = "0xABBDD0", Offset = "0xABABD0", VA = "0x10ABBDD0")]
    public bool Deserialize(JSON_PointQuestRankingData json) => new bool();

    [Token(Token = "0x600E49A")]
    [Address(RVA = "0xABBFE0", Offset = "0xABADE0", VA = "0x10ABBFE0")]
    public void SetDefaultDesplay()
    {
    }

    [Token(Token = "0x600E49B")]
    [Address(RVA = "0xABC5F0", Offset = "0xABB3F0", VA = "0x10ABC5F0")]
    private void SetUnitIcon()
    {
    }

    [Token(Token = "0x600E49C")]
    [Address(RVA = "0xABC4E0", Offset = "0xABB2E0", VA = "0x10ABC4E0")]
    private void SetRanking()
    {
    }

    [Token(Token = "0x600E49D")]
    [Address(RVA = "0xABC2A0", Offset = "0xABB0A0", VA = "0x10ABC2A0")]
    private void SetLevelText()
    {
    }

    [Token(Token = "0x600E49E")]
    [Address(RVA = "0xABBEF0", Offset = "0xABACF0", VA = "0x10ABBEF0")]
    private void SetAwardImage()
    {
    }

    [Token(Token = "0x600E49F")]
    [Address(RVA = "0xABC340", Offset = "0xABB140", VA = "0x10ABC340")]
    private void SetQuestText()
    {
    }

    [Token(Token = "0x600E4A0")]
    [Address(RVA = "0xABC570", Offset = "0xABB370", VA = "0x10ABC570")]
    private void SetScoreText()
    {
    }

    [Token(Token = "0x600E4A1")]
    [Address(RVA = "0xABC320", Offset = "0xABB120", VA = "0x10ABC320")]
    private void SetMask()
    {
    }

    [Token(Token = "0x600E4A2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestPersonRankingContentNodeModel()
    {
    }
  }
}
