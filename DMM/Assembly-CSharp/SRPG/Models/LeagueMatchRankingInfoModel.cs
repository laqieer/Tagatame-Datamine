// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeagueMatchRankingInfoModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003363")]
  public class LeagueMatchRankingInfoModel
  {
    [Token(Token = "0x400F2B9")]
    [FieldOffset(Offset = "0x8")]
    private string _rankKey;
    [Token(Token = "0x400F2BA")]
    [FieldOffset(Offset = "0xC")]
    private string _rankNameKey;
    [Token(Token = "0x400F2BB")]
    [FieldOffset(Offset = "0x10")]
    private int _rankRateMin;
    [Token(Token = "0x400F2BC")]
    [FieldOffset(Offset = "0x14")]
    private int _rankRateMax;
    [Token(Token = "0x400F2BD")]
    [FieldOffset(Offset = "0x18")]
    private bool _isDispSubLetter;
    [Token(Token = "0x400F2BE")]
    [FieldOffset(Offset = "0x19")]
    private bool _isDispMinRank;
    [Token(Token = "0x400F2BF")]
    [FieldOffset(Offset = "0x1A")]
    private bool _isDispMaxRank;
    [Token(Token = "0x400F2C0")]
    [FieldOffset(Offset = "0x1B")]
    private bool _isBelong;
    [Token(Token = "0x400F2C1")]
    [FieldOffset(Offset = "0x1C")]
    private bool _isDispRankChar;
    [Token(Token = "0x400F2C2")]
    [FieldOffset(Offset = "0x1D")]
    private bool _isDispPointChar;
    [Token(Token = "0x400F2C3")]
    [FieldOffset(Offset = "0x20")]
    private LeagueMatchRewardParam _rewardData;

    [Token(Token = "0x17001ED6")]
    public string RankKey
    {
      [Token(Token = "0x600E3B8"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001ED7")]
    public int RankRateMin
    {
      [Token(Token = "0x600E3B9"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001ED8")]
    public int RankRateMax
    {
      [Token(Token = "0x600E3BA"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001ED9")]
    public bool IsDispSubLetter
    {
      [Token(Token = "0x600E3BB"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001EDA")]
    public bool IsDispMinRank
    {
      [Token(Token = "0x600E3BC"), Address(RVA = "0x3FE5C0", Offset = "0x3FD3C0", VA = "0x103FE5C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001EDB")]
    public bool IsDispMaxRank
    {
      [Token(Token = "0x600E3BD"), Address(RVA = "0x408500", Offset = "0x407300", VA = "0x10408500")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001EDC")]
    public LeagueMatchRewardParam RewardData
    {
      [Token(Token = "0x600E3BE"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (LeagueMatchRewardParam) null;
      }
    }

    [Token(Token = "0x17001EDD")]
    public bool IsBelong
    {
      [Token(Token = "0x600E3BF"), Address(RVA = "0x4084F0", Offset = "0x4072F0", VA = "0x104084F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001EDE")]
    public bool IsDispRankChar
    {
      [Token(Token = "0x600E3C0"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001EDF")]
    public bool IsDispPointChar
    {
      [Token(Token = "0x600E3C1"), Address(RVA = "0x5EDE50", Offset = "0x5ECC50", VA = "0x105EDE50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E3C2")]
    [Address(RVA = "0xAB86A0", Offset = "0xAB74A0", VA = "0x10AB86A0")]
    public void Initialize(LeagueMatchRankClassParam rankClassParam)
    {
    }

    [Token(Token = "0x600E3C3")]
    [Address(RVA = "0xAB88E0", Offset = "0xAB76E0", VA = "0x10AB88E0")]
    public LeagueMatchRankingInfoModel()
    {
    }
  }
}
