// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeagueMatchRankingListModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003364")]
  public class LeagueMatchRankingListModel
  {
    [Token(Token = "0x400F2C4")]
    [FieldOffset(Offset = "0x8")]
    private string _playerName;
    [Token(Token = "0x400F2C5")]
    [FieldOffset(Offset = "0xC")]
    private int _point;
    [Token(Token = "0x400F2C6")]
    [FieldOffset(Offset = "0x10")]
    private UnitData _userIconUnit;
    [Token(Token = "0x400F2C7")]
    [FieldOffset(Offset = "0x14")]
    private int _level;
    [Token(Token = "0x400F2C8")]
    [FieldOffset(Offset = "0x18")]
    private string _award;
    [Token(Token = "0x400F2C9")]
    [FieldOffset(Offset = "0x1C")]
    private bool _isBelongPort;
    [Token(Token = "0x400F2CA")]
    [FieldOffset(Offset = "0x20")]
    private string _portName;
    [Token(Token = "0x400F2CB")]
    [FieldOffset(Offset = "0x24")]
    private int _portId;
    [Token(Token = "0x400F2CC")]
    [FieldOffset(Offset = "0x28")]
    private string _rankIconKey;
    [Token(Token = "0x400F2CD")]
    [FieldOffset(Offset = "0x2C")]
    private int _rank;
    [Token(Token = "0x400F2CE")]
    [FieldOffset(Offset = "0x30")]
    private int _rankImageIndex;
    [Token(Token = "0x400F2CF")]
    [FieldOffset(Offset = "0x34")]
    private bool _isActRankText;
    [Token(Token = "0x400F2D0")]
    [FieldOffset(Offset = "0x35")]
    private bool _isActOutOfRankText;
    [Token(Token = "0x400F2D1")]
    [FieldOffset(Offset = "0x38")]
    private JSON_LeagueMatchRanking _rankingParam;
    [Token(Token = "0x400F2D2")]
    [FieldOffset(Offset = "0x3C")]
    private int _rankingLimit;
    [Token(Token = "0x400F2D3")]
    [FieldOffset(Offset = "0x40")]
    private int _rankingImageArrayLength;

    [Token(Token = "0x17001EE0")]
    public string PlayerName
    {
      [Token(Token = "0x600E3C4"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001EE1")]
    public int Point
    {
      [Token(Token = "0x600E3C5"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001EE2")]
    public int Level
    {
      [Token(Token = "0x600E3C6"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001EE3")]
    public string Award
    {
      [Token(Token = "0x600E3C7"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001EE4")]
    public UnitData UserIconUnit
    {
      [Token(Token = "0x600E3C8"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001EE5")]
    public bool IsBelongPort
    {
      [Token(Token = "0x600E3C9"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001EE6")]
    public int PortId
    {
      [Token(Token = "0x600E3CA"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001EE7")]
    public string PortName
    {
      [Token(Token = "0x600E3CB"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001EE8")]
    public string RankIconKey
    {
      [Token(Token = "0x600E3CC"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001EE9")]
    public int Rank
    {
      [Token(Token = "0x600E3CD"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001EEA")]
    public int RankImageIndex
    {
      [Token(Token = "0x600E3CE"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001EEB")]
    public bool IsActiveRankText
    {
      [Token(Token = "0x600E3CF"), Address(RVA = "0x54FFB0", Offset = "0x54EDB0", VA = "0x1054FFB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001EEC")]
    public bool IsActiveOutOfRankText
    {
      [Token(Token = "0x600E3D0"), Address(RVA = "0x8E4B70", Offset = "0x8E3970", VA = "0x108E4B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E3D1")]
    [Address(RVA = "0xAB8900", Offset = "0xAB7700", VA = "0x10AB8900")]
    public void Initialize(JSON_LeagueMatchRanking rankingParam, int rankingLimit)
    {
    }

    [Token(Token = "0x600E3D2")]
    [Address(RVA = "0xAB8930", Offset = "0xAB7730", VA = "0x10AB8930")]
    public void SetRankingImageLength(ImageArray arr)
    {
    }

    [Token(Token = "0x600E3D3")]
    [Address(RVA = "0xAB89A0", Offset = "0xAB77A0", VA = "0x10AB89A0")]
    private void SetUserData()
    {
    }

    [Token(Token = "0x600E3D4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchRankingListModel()
    {
    }
  }
}
