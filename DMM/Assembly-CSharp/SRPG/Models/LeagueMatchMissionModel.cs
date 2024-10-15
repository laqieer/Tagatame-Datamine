// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeagueMatchMissionModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003360")]
  public class LeagueMatchMissionModel
  {
    [Token(Token = "0x400F2AD")]
    [FieldOffset(Offset = "0x8")]
    private LeagueMatchMissionModel.EState _state;
    [Token(Token = "0x400F2AE")]
    [FieldOffset(Offset = "0xC")]
    private string _iname;
    [Token(Token = "0x400F2AF")]
    [FieldOffset(Offset = "0x10")]
    private string _name;
    [Token(Token = "0x400F2B0")]
    [FieldOffset(Offset = "0x14")]
    private string _expr;
    [Token(Token = "0x400F2B1")]
    [FieldOffset(Offset = "0x18")]
    private int _prog;
    [Token(Token = "0x400F2B2")]
    [FieldOffset(Offset = "0x1C")]
    private int _ival;
    [Token(Token = "0x400F2B3")]
    [FieldOffset(Offset = "0x20")]
    private LeagueMatchRewardParam _rewardData;

    [Token(Token = "0x17001ECD")]
    public LeagueMatchMissionModel.EState State
    {
      [Token(Token = "0x600E3AB"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new LeagueMatchMissionModel.EState();
      }
    }

    [Token(Token = "0x17001ECE")]
    public string Iname
    {
      [Token(Token = "0x600E3AC"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001ECF")]
    public string Name
    {
      [Token(Token = "0x600E3AD"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001ED0")]
    public string Expr
    {
      [Token(Token = "0x600E3AE"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001ED1")]
    public LeagueMatchRewardParam RewardData
    {
      [Token(Token = "0x600E3AF"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (LeagueMatchRewardParam) null;
      }
    }

    [Token(Token = "0x17001ED2")]
    public int Prog
    {
      [Token(Token = "0x600E3B0"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001ED3")]
    public int Ival
    {
      [Token(Token = "0x600E3B1"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001ED4")]
    public int SortNum
    {
      [Token(Token = "0x600E3B2"), Address(RVA = "0xAB84D0", Offset = "0xAB72D0", VA = "0x10AB84D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600E3B3")]
    [Address(RVA = "0xAB8430", Offset = "0xAB7230", VA = "0x10AB8430")]
    public void Initialize(
      LeagueMatchMissionParam param,
      LeagueMatchRewardParam reward,
      JSON_LeagueMatchMission data)
    {
    }

    [Token(Token = "0x600E3B4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchMissionModel()
    {
    }

    [Token(Token = "0x2003361")]
    public enum EState
    {
      [Token(Token = "0x400F2B5")] PROGRESS,
      [Token(Token = "0x400F2B6")] CLEAR,
      [Token(Token = "0x400F2B7")] RECEIVED,
    }
  }
}
