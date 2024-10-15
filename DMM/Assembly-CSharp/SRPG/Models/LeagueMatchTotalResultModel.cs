// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeagueMatchTotalResultModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200336B")]
  public class LeagueMatchTotalResultModel
  {
    [Token(Token = "0x400F2F8")]
    [FieldOffset(Offset = "0x8")]
    private ReqLeagueMatchTop.Response _response;
    [Token(Token = "0x400F2F9")]
    [FieldOffset(Offset = "0xC")]
    private ReqLeagueMatchReward.Response _responseMatchReward;
    [Token(Token = "0x400F2FA")]
    [FieldOffset(Offset = "0x10")]
    private string _rankIconKey;
    [Token(Token = "0x400F2FB")]
    [FieldOffset(Offset = "0x14")]
    private string _rankNameKey;
    [Token(Token = "0x400F2FC")]
    [FieldOffset(Offset = "0x18")]
    private string _offenseScore;
    [Token(Token = "0x400F2FD")]
    [FieldOffset(Offset = "0x1C")]
    private string _defenseScore;
    [Token(Token = "0x400F2FE")]
    [FieldOffset(Offset = "0x20")]
    private string _getTotalScore;
    [Token(Token = "0x400F2FF")]
    [FieldOffset(Offset = "0x24")]
    private bool _isRankBefore;

    [Token(Token = "0x17001F17")]
    public string RankIconKey
    {
      [Token(Token = "0x600E420"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F18")]
    public string RankNameKey
    {
      [Token(Token = "0x600E421"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E422")]
    [Address(RVA = "0xAB9C10", Offset = "0xAB8A10", VA = "0x10AB9C10")]
    public int GetWinLoss(int index) => new int();

    [Token(Token = "0x17001F19")]
    public int OffenseScore
    {
      [Token(Token = "0x600E423"), Address(RVA = "0xABA380", Offset = "0xAB9180", VA = "0x10ABA380")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001F1A")]
    public string StrOffenseScore
    {
      [Token(Token = "0x600E424"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F1B")]
    public int DefenseNum
    {
      [Token(Token = "0x600E425"), Address(RVA = "0xABA270", Offset = "0xAB9070", VA = "0x10ABA270")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001F1C")]
    public int DefenseScore
    {
      [Token(Token = "0x600E426"), Address(RVA = "0xABA2A0", Offset = "0xAB90A0", VA = "0x10ABA2A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001F1D")]
    public string StrDefenseScore
    {
      [Token(Token = "0x600E427"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F1E")]
    public int TotalScore
    {
      [Token(Token = "0x600E428"), Address(RVA = "0xABA3B0", Offset = "0xAB91B0", VA = "0x10ABA3B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001F1F")]
    public int BeforeTotalScore
    {
      [Token(Token = "0x600E429"), Address(RVA = "0xABA200", Offset = "0xAB9000", VA = "0x10ABA200")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001F20")]
    public int GetTotalScore
    {
      [Token(Token = "0x600E42A"), Address(RVA = "0xABA2D0", Offset = "0xAB90D0", VA = "0x10ABA2D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001F21")]
    public string StrGetTotalScore
    {
      [Token(Token = "0x600E42B"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F22")]
    public bool IsRankChange
    {
      [Token(Token = "0x600E42C"), Address(RVA = "0xABA340", Offset = "0xAB9140", VA = "0x10ABA340")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F23")]
    public bool IsDefenseReward
    {
      [Token(Token = "0x600E42D"), Address(RVA = "0xABA320", Offset = "0xAB9120", VA = "0x10ABA320")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E42E")]
    [Address(RVA = "0xABA0F0", Offset = "0xAB8EF0", VA = "0x10ABA0F0")]
    public void Initialize(SerializeValueList _valueList, bool isRankBefore = true)
    {
    }

    [Token(Token = "0x600E42F")]
    [Address(RVA = "0xAB9CB0", Offset = "0xAB8AB0", VA = "0x10AB9CB0")]
    private void InitializeData(GameManager gm)
    {
    }

    [Token(Token = "0x600E430")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchTotalResultModel()
    {
    }
  }
}
