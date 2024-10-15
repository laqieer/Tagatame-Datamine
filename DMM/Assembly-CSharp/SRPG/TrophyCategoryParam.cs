// Decompiled with JetBrains decompiler
// Type: SRPG.TrophyCategoryParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D90")]
  public class TrophyCategoryParam
  {
    [Token(Token = "0x40074FB")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40074FC")]
    [FieldOffset(Offset = "0xC")]
    public int hash_code;
    [Token(Token = "0x40074FD")]
    [FieldOffset(Offset = "0x10")]
    public TrophyCategorys category;
    [Token(Token = "0x40074FE")]
    [FieldOffset(Offset = "0x14")]
    public bool is_not_pull;
    [Token(Token = "0x40074FF")]
    [FieldOffset(Offset = "0x18")]
    public int days;
    [Token(Token = "0x4007500")]
    [FieldOffset(Offset = "0x1C")]
    public int beginner;
    [Token(Token = "0x4007501")]
    [FieldOffset(Offset = "0x20")]
    public TimeParser begin_at;
    [Token(Token = "0x4007502")]
    [FieldOffset(Offset = "0x24")]
    public TimeParser end_at;
    [Token(Token = "0x4007503")]
    [FieldOffset(Offset = "0x28")]
    public string linked_quest;
    [Token(Token = "0x4007504")]
    [FieldOffset(Offset = "0x2C")]
    public string banner;

    [Token(Token = "0x17001048")]
    public bool IsNotPull
    {
      [Token(Token = "0x60078FA"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001049")]
    public bool IsBeginner
    {
      [Token(Token = "0x60078FB"), Address(RVA = "0x3784F0", Offset = "0x3772F0", VA = "0x103784F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700104A")]
    public bool IsDaily
    {
      [Token(Token = "0x60078FC"), Address(RVA = "0x26D070", Offset = "0x26BE70", VA = "0x1026D070")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700104B")]
    public bool IsLinekedQuest
    {
      [Token(Token = "0x60078FD"), Address(RVA = "0x3A8970", Offset = "0x3A7770", VA = "0x103A8970")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60078FE")]
    [Address(RVA = "0x3A82D0", Offset = "0x3A70D0", VA = "0x103A82D0")]
    public bool Deserialize(JSON_TrophyCategoryParam json) => new bool();

    [Token(Token = "0x60078FF")]
    [Address(RVA = "0x3A8560", Offset = "0x3A7360", VA = "0x103A8560")]
    public bool IsAvailablePeriod(DateTime now, bool is_grace) => new bool();

    [Token(Token = "0x6007900")]
    [Address(RVA = "0x3A8700", Offset = "0x3A7500", VA = "0x103A8700")]
    public bool IsOpenLinekedQuest(DateTime now, bool is_grace) => new bool();

    [Token(Token = "0x6007901")]
    [Address(RVA = "0x3A8470", Offset = "0x3A7270", VA = "0x103A8470")]
    public DateTime GetQuestTime(DateTime base_time, bool is_quest_grace) => new DateTime();

    [Token(Token = "0x6007902")]
    [Address(RVA = "0x3A8170", Offset = "0x3A6F70", VA = "0x103A8170")]
    private DateTime AddTimeSpan(DateTime times, TimeSpan span) => new DateTime();

    [Token(Token = "0x6007903")]
    [Address(RVA = "0x3A83F0", Offset = "0x3A71F0", VA = "0x103A83F0")]
    private TimeSpan GetGraceRewardSpan() => new TimeSpan();

    [Token(Token = "0x6007904")]
    [Address(RVA = "0x3A8420", Offset = "0x3A7220", VA = "0x103A8420")]
    private TimeSpan GetQuestGrace() => new TimeSpan();

    [Token(Token = "0x6007905")]
    [Address(RVA = "0x3A88E0", Offset = "0x3A76E0", VA = "0x103A88E0")]
    public TrophyCategoryParam()
    {
    }
  }
}
