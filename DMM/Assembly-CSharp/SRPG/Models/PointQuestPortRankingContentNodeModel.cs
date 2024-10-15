// Decompiled with JetBrains decompiler
// Type: SRPG.Models.PointQuestPortRankingContentNodeModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003378")]
  public class PointQuestPortRankingContentNodeModel
  {
    [Token(Token = "0x400F356")]
    private const string NOT_AFFILIATION_TEXT = "sys.POINTQUEST_RANKING_NOT_AFFILIATION";
    [Token(Token = "0x400F357")]
    private const string NOT_AFFILIATION_MASTER_NAME_TEXT = "sys.POINTQUEST_RANKING_NOT_AFFILIATION_MASTER_NAME";
    [Token(Token = "0x400F358")]
    private const string NOTHING_LEVEL_TEXT = "sys.POINTQUEST_RANKING_NOTHING_LEVEL";
    [Token(Token = "0x400F359")]
    private const string NOTHING_SCORE_TEXT = "sys.POINTQUEST_RANKING_NOTHING_SCORE";
    [Token(Token = "0x400F35A")]
    private const int mNonePortId = -1;
    [Token(Token = "0x400F35B")]
    private const int mRankingImageIndexMax = 4;
    [Token(Token = "0x400F35C")]
    private const int mRankingDefault = 0;
    [Token(Token = "0x400F35D")]
    private const int mRankingStartRange = 1;
    [Token(Token = "0x400F35E")]
    [FieldOffset(Offset = "0x8")]
    private int mRankingRange;
    [Token(Token = "0x400F35F")]
    private const int mLevelMin = 1;
    [Token(Token = "0x400F360")]
    private const int mLevelDefault = 0;
    [Token(Token = "0x400F361")]
    private const int mScoreMin = 1;
    [Token(Token = "0x400F362")]
    private const int mScoreDefault = 0;
    [Token(Token = "0x400F363")]
    [FieldOffset(Offset = "0x10")]
    private long mPortId;
    [Token(Token = "0x400F364")]
    [FieldOffset(Offset = "0x18")]
    private int mRanking;
    [Token(Token = "0x400F365")]
    [FieldOffset(Offset = "0x1C")]
    private int mLevel;
    [Token(Token = "0x400F366")]
    [FieldOffset(Offset = "0x20")]
    private int mScore;
    [Token(Token = "0x400F367")]
    [FieldOffset(Offset = "0x24")]
    private int mRankingImageIndex;
    [Token(Token = "0x400F368")]
    [FieldOffset(Offset = "0x28")]
    private bool mRankingTextVisible;
    [Token(Token = "0x400F369")]
    [FieldOffset(Offset = "0x2C")]
    private string mRankingText;
    [Token(Token = "0x400F36A")]
    [FieldOffset(Offset = "0x30")]
    private bool mRankingOutRangeTextVisible;
    [Token(Token = "0x400F36B")]
    [FieldOffset(Offset = "0x31")]
    private bool mRankingNotAttendedTextVisible;
    [Token(Token = "0x400F36C")]
    [FieldOffset(Offset = "0x34")]
    private string mPortEmblem;
    [Token(Token = "0x400F36D")]
    [FieldOffset(Offset = "0x38")]
    private bool mPortEmblemVisible;
    [Token(Token = "0x400F36E")]
    [FieldOffset(Offset = "0x3C")]
    private Sprite mPortEmblemSprite;
    [Token(Token = "0x400F36F")]
    [FieldOffset(Offset = "0x40")]
    private string mPortNameText;
    [Token(Token = "0x400F370")]
    [FieldOffset(Offset = "0x44")]
    private string mPortMasterNameText;
    [Token(Token = "0x400F371")]
    [FieldOffset(Offset = "0x48")]
    private string mPortLevelText;
    [Token(Token = "0x400F372")]
    [FieldOffset(Offset = "0x4C")]
    private string mPortScoreText;
    [Token(Token = "0x400F373")]
    [FieldOffset(Offset = "0x50")]
    private bool mIsMask;

    [Token(Token = "0x17001F68")]
    public long PortId
    {
      [Token(Token = "0x600E4A3"), Address(RVA = "0x361230", Offset = "0x360030", VA = "0x10361230")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17001F69")]
    public int Ranking
    {
      [Token(Token = "0x600E4A4"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001F6A")]
    public int RankingImageIndex
    {
      [Token(Token = "0x600E4A5"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001F6B")]
    public bool RankingTextVisible
    {
      [Token(Token = "0x600E4A6"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F6C")]
    public string RankingText
    {
      [Token(Token = "0x600E4A7"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F6D")]
    public bool RankingOutRangeTextVisible
    {
      [Token(Token = "0x600E4A8"), Address(RVA = "0x380080", Offset = "0x37EE80", VA = "0x10380080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F6E")]
    public bool RankingNotAttendedTextVisible
    {
      [Token(Token = "0x600E4A9"), Address(RVA = "0x7F55A0", Offset = "0x7F43A0", VA = "0x107F55A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F6F")]
    public string PortEmblem
    {
      [Token(Token = "0x600E4AA"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F70")]
    public bool PortEmblemVisible
    {
      [Token(Token = "0x600E4AB"), Address(RVA = "0x2836F0", Offset = "0x2824F0", VA = "0x102836F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F71")]
    public Sprite PortEmblemSprite
    {
      [Token(Token = "0x600E4AC"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17001F72")]
    public string PortNameText
    {
      [Token(Token = "0x600E4AD"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F73")]
    public string PortMasterNameText
    {
      [Token(Token = "0x600E4AE"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F74")]
    public string PortLevelText
    {
      [Token(Token = "0x600E4AF"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F75")]
    public string PortScoreText
    {
      [Token(Token = "0x600E4B0"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F76")]
    public bool IsMask
    {
      [Token(Token = "0x600E4B1"), Address(RVA = "0x2AABD0", Offset = "0x2A99D0", VA = "0x102AABD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E4B2")]
    [Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")]
    public void Initialize(int rankingRange)
    {
    }

    [Token(Token = "0x600E4B3")]
    [Address(RVA = "0xABC670", Offset = "0xABB470", VA = "0x10ABC670")]
    public bool Deserialize(JSON_PointQuestGuildRankingData json) => new bool();

    [Token(Token = "0x600E4B4")]
    [Address(RVA = "0xABC730", Offset = "0xABB530", VA = "0x10ABC730")]
    public void SetDefaultDesplay()
    {
    }

    [Token(Token = "0x600E4B5")]
    [Address(RVA = "0xABC990", Offset = "0xABB790", VA = "0x10ABC990")]
    private void SetEmblem()
    {
    }

    [Token(Token = "0x600E4B6")]
    [Address(RVA = "0xABCB20", Offset = "0xABB920", VA = "0x10ABCB20")]
    private void SetRanking()
    {
    }

    [Token(Token = "0x600E4B7")]
    [Address(RVA = "0xABCA70", Offset = "0xABB870", VA = "0x10ABCA70")]
    private void SetLevelText()
    {
    }

    [Token(Token = "0x600E4B8")]
    [Address(RVA = "0xABCBB0", Offset = "0xABB9B0", VA = "0x10ABCBB0")]
    private void SetScoreText()
    {
    }

    [Token(Token = "0x600E4B9")]
    [Address(RVA = "0xABCAF0", Offset = "0xABB8F0", VA = "0x10ABCAF0")]
    private void SetMask()
    {
    }

    [Token(Token = "0x600E4BA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestPortRankingContentNodeModel()
    {
    }
  }
}
