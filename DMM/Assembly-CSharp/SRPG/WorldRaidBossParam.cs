// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidBossParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EFA")]
  public class WorldRaidBossParam
  {
    [Token(Token = "0x4008273")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4008274")]
    [FieldOffset(Offset = "0xC")]
    private string mName;
    [Token(Token = "0x4008275")]
    [FieldOffset(Offset = "0x10")]
    private long mHp;
    [Token(Token = "0x4008276")]
    [FieldOffset(Offset = "0x18")]
    private string mUnitId;
    [Token(Token = "0x4008277")]
    [FieldOffset(Offset = "0x1C")]
    private UnitParam mUnitParam;
    [Token(Token = "0x4008278")]
    [FieldOffset(Offset = "0x20")]
    private string mQuestId;
    [Token(Token = "0x4008279")]
    [FieldOffset(Offset = "0x24")]
    private QuestParam mQuestParam;
    [Token(Token = "0x400827A")]
    [FieldOffset(Offset = "0x28")]
    private string mDetailUrl;
    [Token(Token = "0x400827B")]
    [FieldOffset(Offset = "0x2C")]
    private string mDetailTitle;

    [Token(Token = "0x17001200")]
    public string Iname
    {
      [Token(Token = "0x6007EA2"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001201")]
    public string Name
    {
      [Token(Token = "0x6007EA3"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001202")]
    public long Hp
    {
      [Token(Token = "0x6007EA4"), Address(RVA = "0x361230", Offset = "0x360030", VA = "0x10361230")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17001203")]
    public string UnitId
    {
      [Token(Token = "0x6007EA5"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001204")]
    public UnitParam UnitParam
    {
      [Token(Token = "0x6007EA6"), Address(RVA = "0x413160", Offset = "0x411F60", VA = "0x10413160")] get
      {
        return (UnitParam) null;
      }
    }

    [Token(Token = "0x17001205")]
    public string QuestId
    {
      [Token(Token = "0x6007EA7"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001206")]
    public QuestParam QuestParam
    {
      [Token(Token = "0x6007EA8"), Address(RVA = "0x4130E0", Offset = "0x411EE0", VA = "0x104130E0")] get
      {
        return (QuestParam) null;
      }
    }

    [Token(Token = "0x17001207")]
    public string DetailUrl
    {
      [Token(Token = "0x6007EA9"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001208")]
    public string DetailTitle
    {
      [Token(Token = "0x6007EAA"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007EAB")]
    [Address(RVA = "0x412F30", Offset = "0x411D30", VA = "0x10412F30")]
    public void Deserialize(JSON_WorldRaidBossParam json)
    {
    }

    [Token(Token = "0x6007EAC")]
    [Address(RVA = "0x412D80", Offset = "0x411B80", VA = "0x10412D80")]
    public static void Deserialize(
      ref List<WorldRaidBossParam> list,
      JSON_WorldRaidBossParam[] json)
    {
    }

    [Token(Token = "0x6007EAD")]
    [Address(RVA = "0x412FD0", Offset = "0x411DD0", VA = "0x10412FD0")]
    public static WorldRaidBossParam GetParam(string iname) => (WorldRaidBossParam) null;

    [Token(Token = "0x6007EAE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public WorldRaidBossParam()
    {
    }
  }
}
