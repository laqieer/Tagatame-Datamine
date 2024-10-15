// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchNPCPartyParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BBD")]
  [MessagePackObject(true)]
  public class LeagueMatchNPCPartyParam
  {
    [Token(Token = "0x4006A29")]
    [FieldOffset(Offset = "0x8")]
    private int mId;
    [Token(Token = "0x4006A2A")]
    [FieldOffset(Offset = "0xC")]
    private string mName;
    [Token(Token = "0x4006A2B")]
    [FieldOffset(Offset = "0x10")]
    private int mLv;
    [Token(Token = "0x4006A2C")]
    [FieldOffset(Offset = "0x14")]
    private int mScore;
    [Token(Token = "0x4006A2D")]
    [FieldOffset(Offset = "0x18")]
    private int mRank_class_id;
    [Token(Token = "0x4006A2E")]
    [FieldOffset(Offset = "0x1C")]
    private string mRank_class;
    [Token(Token = "0x4006A2F")]
    [FieldOffset(Offset = "0x20")]
    private int mRank_unit1_id;
    [Token(Token = "0x4006A30")]
    [FieldOffset(Offset = "0x24")]
    private int mRank_unit2_id;
    [Token(Token = "0x4006A31")]
    [FieldOffset(Offset = "0x28")]
    private int mRank_unit3_id;
    [Token(Token = "0x4006A32")]
    [FieldOffset(Offset = "0x2C")]
    private string mQuestIname;
    [Token(Token = "0x4006A33")]
    [FieldOffset(Offset = "0x30")]
    private LeagueMatchNPCPartyBuffParam[] mBuffs;

    [Token(Token = "0x17000E00")]
    public int Id
    {
      [Token(Token = "0x600727D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E01")]
    public string Name
    {
      [Token(Token = "0x600727E"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E02")]
    public int Lv
    {
      [Token(Token = "0x600727F"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E03")]
    public int Score
    {
      [Token(Token = "0x6007280"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E04")]
    public int Rank_class_id
    {
      [Token(Token = "0x6007281"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E05")]
    public string Rank_class
    {
      [Token(Token = "0x6007282"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E06")]
    public int Rank_unit1_id
    {
      [Token(Token = "0x6007283"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E07")]
    public int Rank_unit2_id
    {
      [Token(Token = "0x6007284"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E08")]
    public int Rank_unit3_id
    {
      [Token(Token = "0x6007285"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E09")]
    public string QuestIname
    {
      [Token(Token = "0x6007286"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E0A")]
    public LeagueMatchNPCPartyBuffParam[] Buffs
    {
      [Token(Token = "0x6007287"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (LeagueMatchNPCPartyBuffParam[]) null;
      }
    }

    [Token(Token = "0x6007288")]
    [Address(RVA = "0x379470", Offset = "0x378270", VA = "0x10379470")]
    public bool Deserialize(JSON_LeagueMatchNPCPartyParam json) => new bool();

    [Token(Token = "0x6007289")]
    [Address(RVA = "0x379330", Offset = "0x378130", VA = "0x10379330")]
    public static bool Deserialize(
      ref List<LeagueMatchNPCPartyParam> paramList,
      JSON_LeagueMatchNPCPartyParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x600728A")]
    [Address(RVA = "0x3791C0", Offset = "0x377FC0", VA = "0x103791C0")]
    public List<UnitData> CreatePartyUnitDatas() => (List<UnitData>) null;

    [Token(Token = "0x600728B")]
    [Address(RVA = "0x3796D0", Offset = "0x3784D0", VA = "0x103796D0")]
    private UnitData GetNpcUnitData(GameManager gm, int id) => (UnitData) null;

    [Token(Token = "0x600728C")]
    [Address(RVA = "0x379050", Offset = "0x377E50", VA = "0x10379050")]
    public List<Json_Unit> CreateJsonUnitPartyData() => (List<Json_Unit>) null;

    [Token(Token = "0x600728D")]
    [Address(RVA = "0x379600", Offset = "0x378400", VA = "0x10379600")]
    private Json_Unit GetJsonUnitData(GameManager gm, int id) => (Json_Unit) null;

    [Token(Token = "0x600728E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchNPCPartyParam()
    {
    }
  }
}
