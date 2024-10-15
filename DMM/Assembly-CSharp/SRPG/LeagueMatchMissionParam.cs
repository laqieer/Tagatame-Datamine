// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchMissionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BBA")]
  [MessagePackObject(true)]
  public class LeagueMatchMissionParam
  {
    [Token(Token = "0x4006A16")]
    [FieldOffset(Offset = "0x8")]
    public int mSeasonId;
    [Token(Token = "0x4006A17")]
    [FieldOffset(Offset = "0xC")]
    public string mIname;
    [Token(Token = "0x4006A18")]
    [FieldOffset(Offset = "0x10")]
    public string mName;
    [Token(Token = "0x4006A19")]
    [FieldOffset(Offset = "0x14")]
    public string mExpr;
    [Token(Token = "0x4006A1A")]
    [FieldOffset(Offset = "0x18")]
    public ELeagueMatchMissionType mType;
    [Token(Token = "0x4006A1B")]
    [FieldOffset(Offset = "0x1C")]
    public int mIval;
    [Token(Token = "0x4006A1C")]
    [FieldOffset(Offset = "0x20")]
    public string mRewardId;

    [Token(Token = "0x17000DF9")]
    public int SeasonId
    {
      [Token(Token = "0x6007271"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000DFA")]
    public string Iname
    {
      [Token(Token = "0x6007272"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DFB")]
    public string Name
    {
      [Token(Token = "0x6007273"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DFC")]
    public string Expr
    {
      [Token(Token = "0x6007274"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DFD")]
    public ELeagueMatchMissionType Type
    {
      [Token(Token = "0x6007275"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new ELeagueMatchMissionType();
      }
    }

    [Token(Token = "0x17000DFE")]
    public int Ival
    {
      [Token(Token = "0x6007276"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000DFF")]
    public string RewardId
    {
      [Token(Token = "0x6007277"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007278")]
    [Address(RVA = "0x378E90", Offset = "0x377C90", VA = "0x10378E90")]
    public bool Deserialize(JSON_LeagueMatchMissionParam json) => new bool();

    [Token(Token = "0x6007279")]
    [Address(RVA = "0x378CF0", Offset = "0x377AF0", VA = "0x10378CF0")]
    public static bool Deserialize(
      ref List<LeagueMatchMissionParam> paramList,
      JSON_LeagueMatchMissionParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x600727A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchMissionParam()
    {
    }
  }
}
