// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeagueMatchTopModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200336A")]
  public class LeagueMatchTopModel
  {
    [Token(Token = "0x400F2EE")]
    [FieldOffset(Offset = "0x8")]
    private ReqLeagueMatchTop.Response _response;
    [Token(Token = "0x400F2EF")]
    [FieldOffset(Offset = "0xC")]
    private JSON_LeagueMatchDefenseParty _defense_info;
    [Token(Token = "0x400F2F0")]
    [FieldOffset(Offset = "0x10")]
    private ReqLeagueMatchReward.Response _responseReward;
    [Token(Token = "0x400F2F1")]
    [FieldOffset(Offset = "0x14")]
    private PartyEditData _partyEditData;
    [Token(Token = "0x400F2F2")]
    [FieldOffset(Offset = "0x18")]
    private int _seasonID;
    [Token(Token = "0x400F2F3")]
    [FieldOffset(Offset = "0x1C")]
    private string _rankIconKey;
    [Token(Token = "0x400F2F4")]
    [FieldOffset(Offset = "0x20")]
    private string _rankNameKey;
    [Token(Token = "0x400F2F5")]
    [FieldOffset(Offset = "0x24")]
    private int _point;
    [Token(Token = "0x400F2F6")]
    [FieldOffset(Offset = "0x28")]
    private string _event_url;
    [Token(Token = "0x400F2F7")]
    [FieldOffset(Offset = "0x2C")]
    private bool _isShowRanking;

    [Token(Token = "0x17001F07")]
    public int SeasonID
    {
      [Token(Token = "0x600E408"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001F08")]
    public string RankIconKey
    {
      [Token(Token = "0x600E409"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F09")]
    public string RankNameKey
    {
      [Token(Token = "0x600E40A"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F0A")]
    public int Point
    {
      [Token(Token = "0x600E40B"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001F0B")]
    public string Event_url
    {
      [Token(Token = "0x600E40C"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F0C")]
    public UnitData[] DefenseUnits
    {
      [Token(Token = "0x600E40D"), Address(RVA = "0xAB9B60", Offset = "0xAB8960", VA = "0x10AB9B60")] get
      {
        return (UnitData[]) null;
      }
    }

    [Token(Token = "0x17001F0D")]
    public string DefenseMap
    {
      [Token(Token = "0x600E40E"), Address(RVA = "0xAB9B20", Offset = "0xAB8920", VA = "0x10AB9B20")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F0E")]
    public JSON_LeagueMatchBuffs[] DefenseBuffs
    {
      [Token(Token = "0x600E40F"), Address(RVA = "0xAB9B00", Offset = "0xAB8900", VA = "0x10AB9B00")] get
      {
        return (JSON_LeagueMatchBuffs[]) null;
      }
    }

    [Token(Token = "0x17001F0F")]
    public bool IsShowShop
    {
      [Token(Token = "0x600E410"), Address(RVA = "0xAB9BF0", Offset = "0xAB89F0", VA = "0x10AB9BF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F10")]
    public bool IsShowRanking
    {
      [Token(Token = "0x600E411"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F11")]
    public bool IsShowDefense
    {
      [Token(Token = "0x600E412"), Address(RVA = "0xAB9BD0", Offset = "0xAB89D0", VA = "0x10AB9BD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F12")]
    public ReqLeagueMatchTop.Response Response
    {
      [Token(Token = "0x600E413"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (ReqLeagueMatchTop.Response) null;
      }
    }

    [Token(Token = "0x17001F13")]
    public ReqLeagueMatchReward.Response ResponseReward
    {
      [Token(Token = "0x600E414"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (ReqLeagueMatchReward.Response) null;
      }
    }

    [Token(Token = "0x17001F14")]
    public int ChallengeCount
    {
      [Token(Token = "0x600E415"), Address(RVA = "0xAB9AA0", Offset = "0xAB88A0", VA = "0x10AB9AA0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001F15")]
    public int ChallengeCountMax
    {
      [Token(Token = "0x600E416"), Address(RVA = "0xAB9A70", Offset = "0xAB8870", VA = "0x10AB9A70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600E417")]
    [Address(RVA = "0xAB92C0", Offset = "0xAB80C0", VA = "0x10AB92C0")]
    public int GetResult(int index) => new int();

    [Token(Token = "0x600E418")]
    [Address(RVA = "0xAB99F0", Offset = "0xAB87F0", VA = "0x10AB99F0")]
    public void RefreshDefense(JSON_LeagueMatchDefenseParty param)
    {
    }

    [Token(Token = "0x600E419")]
    [Address(RVA = "0xAB9A20", Offset = "0xAB8820", VA = "0x10AB9A20")]
    public void RefreshMission(JSON_LeagueMatchMission[] missions)
    {
    }

    [Token(Token = "0x600E41A")]
    [Address(RVA = "0xAB9A50", Offset = "0xAB8850", VA = "0x10AB9A50")]
    public void RefreshReward(ReqLeagueMatchReward.Response param)
    {
    }

    [Token(Token = "0x600E41B")]
    [Address(RVA = "0xAB9620", Offset = "0xAB8420", VA = "0x10AB9620")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E41C")]
    [Address(RVA = "0xAB93D0", Offset = "0xAB81D0", VA = "0x10AB93D0")]
    private void InitializeData()
    {
    }

    [Token(Token = "0x600E41D")]
    [Address(RVA = "0xAB9750", Offset = "0xAB8550", VA = "0x10AB9750")]
    private void RefreshDefUnit(JSON_LeagueMatchDefenseParty json)
    {
    }

    [Token(Token = "0x17001F16")]
    private bool IsRanking
    {
      [Token(Token = "0x600E41E"), Address(RVA = "0xAB9BB0", Offset = "0xAB89B0", VA = "0x10AB9BB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E41F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchTopModel()
    {
    }
  }
}
