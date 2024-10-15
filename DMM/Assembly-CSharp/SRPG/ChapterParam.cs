// Decompiled with JetBrains decompiler
// Type: SRPG.ChapterParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A47")]
  public class ChapterParam
  {
    [Token(Token = "0x40060D9")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40060DA")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x40060DB")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x40060DC")]
    [FieldOffset(Offset = "0x14")]
    private short world_index;
    [Token(Token = "0x40060DD")]
    [FieldOffset(Offset = "0x18")]
    public long start;
    [Token(Token = "0x40060DE")]
    [FieldOffset(Offset = "0x20")]
    public long end;
    [Token(Token = "0x40060DF")]
    [FieldOffset(Offset = "0x28")]
    public long key_end;
    [Token(Token = "0x40060E0")]
    [FieldOffset(Offset = "0x30")]
    private bool hidden;
    [Token(Token = "0x40060E1")]
    [FieldOffset(Offset = "0x32")]
    private short section_index;
    [Token(Token = "0x40060E2")]
    [FieldOffset(Offset = "0x34")]
    public string banner;
    [Token(Token = "0x40060E3")]
    [FieldOffset(Offset = "0x38")]
    public string prefabPath;
    [Token(Token = "0x40060E4")]
    [FieldOffset(Offset = "0x3C")]
    public ChapterParam parent;
    [Token(Token = "0x40060E5")]
    [FieldOffset(Offset = "0x40")]
    public List<ChapterParam> children;
    [Token(Token = "0x40060E6")]
    [FieldOffset(Offset = "0x44")]
    public List<QuestParam> quests;
    [Token(Token = "0x40060E7")]
    [FieldOffset(Offset = "0x48")]
    public SectionParam sectionParam;
    [Token(Token = "0x40060E8")]
    [FieldOffset(Offset = "0x4C")]
    public List<KeyItem> keys;
    [Token(Token = "0x40060E9")]
    [FieldOffset(Offset = "0x50")]
    public long keytime;
    [Token(Token = "0x40060EA")]
    [FieldOffset(Offset = "0x58")]
    public string helpURL;
    [Token(Token = "0x40060EB")]
    [FieldOffset(Offset = "0x5C")]
    private int m_challenge_limit;
    [Token(Token = "0x40060EC")]
    [FieldOffset(Offset = "0x60")]
    public int challengeCount;
    [Token(Token = "0x40060ED")]
    [FieldOffset(Offset = "0x64")]
    private int mCombatPowerValue;
    [Token(Token = "0x40060EE")]
    [FieldOffset(Offset = "0x68")]
    private bool m_IsArchiveQuest;

    [Token(Token = "0x17000BC0")]
    public string world
    {
      [Token(Token = "0x6006C04"), Address(RVA = "0x3524E0", Offset = "0x3512E0", VA = "0x103524E0")] set
      {
      }
      [Token(Token = "0x6006C05"), Address(RVA = "0x352400", Offset = "0x351200", VA = "0x10352400")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BC1")]
    public string section
    {
      [Token(Token = "0x6006C06"), Address(RVA = "0x352480", Offset = "0x351280", VA = "0x10352480")] set
      {
      }
      [Token(Token = "0x6006C07"), Address(RVA = "0x3523A0", Offset = "0x3511A0", VA = "0x103523A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BC2")]
    public int CombatPowerValue
    {
      [Token(Token = "0x6006C08"), Address(RVA = "0x2B6040", Offset = "0x2B4E40", VA = "0x102B6040")] get
      {
        return new int();
      }
      [Token(Token = "0x6006C09"), Address(RVA = "0x352460", Offset = "0x351260", VA = "0x10352460")] set
      {
      }
    }

    [Token(Token = "0x17000BC3")]
    public bool IsArchiveQuest
    {
      [Token(Token = "0x6006C0A"), Address(RVA = "0x352390", Offset = "0x351190", VA = "0x10352390")] get
      {
        return new bool();
      }
      [Token(Token = "0x6006C0B"), Address(RVA = "0x352470", Offset = "0x351270", VA = "0x10352470")] set
      {
      }
    }

    [Token(Token = "0x6006C0C")]
    [Address(RVA = "0x3504F0", Offset = "0x34F2F0", VA = "0x103504F0")]
    public void Deserialize(JSON_ChapterParam json)
    {
    }

    [Token(Token = "0x6006C0D")]
    [Address(RVA = "0x350C90", Offset = "0x34FA90", VA = "0x10350C90")]
    public bool IsAvailable(DateTime t) => new bool();

    [Token(Token = "0x6006C0E")]
    [Address(RVA = "0x3513F0", Offset = "0x3501F0", VA = "0x103513F0")]
    public bool IsKeyQuest() => new bool();

    [Token(Token = "0x6006C0F")]
    [Address(RVA = "0x3507A0", Offset = "0x34F5A0", VA = "0x103507A0")]
    public KeyQuestTypes GetKeyQuestType() => new KeyQuestTypes();

    [Token(Token = "0x6006C10")]
    [Address(RVA = "0x351310", Offset = "0x350110", VA = "0x10351310")]
    public bool IsGpsQuest() => new bool();

    [Token(Token = "0x6006C11")]
    [Address(RVA = "0x351CC0", Offset = "0x350AC0", VA = "0x10351CC0")]
    public bool IsTowerQuest() => new bool();

    [Token(Token = "0x6006C12")]
    [Address(RVA = "0x350EB0", Offset = "0x34FCB0", VA = "0x10350EB0")]
    public bool IsBeginnerQuest() => new bool();

    [Token(Token = "0x6006C13")]
    [Address(RVA = "0x351BA0", Offset = "0x3509A0", VA = "0x10351BA0")]
    public bool IsSeiseki() => new bool();

    [Token(Token = "0x6006C14")]
    [Address(RVA = "0x350D90", Offset = "0x34FB90", VA = "0x10350D90")]
    public bool IsBabel() => new bool();

    [Token(Token = "0x6006C15")]
    [Address(RVA = "0x351610", Offset = "0x350410", VA = "0x10351610")]
    public bool IsMultiGpsQuest() => new bool();

    [Token(Token = "0x6006C16")]
    [Address(RVA = "0x3516F0", Offset = "0x3504F0", VA = "0x103516F0")]
    public bool IsOrdealQuest() => new bool();

    [Token(Token = "0x6006C17")]
    [Address(RVA = "0x350800", Offset = "0x34F600", VA = "0x10350800")]
    public SubQuestTypes GetSubQuestType() => new SubQuestTypes();

    [Token(Token = "0x6006C18")]
    [Address(RVA = "0x3508B0", Offset = "0x34F6B0", VA = "0x103508B0")]
    public bool HasGpsQuest() => new bool();

    [Token(Token = "0x6006C19")]
    [Address(RVA = "0x351190", Offset = "0x34FF90", VA = "0x10351190")]
    public bool IsDateUnlock(long unixtime) => new bool();

    [Token(Token = "0x6006C1A")]
    [Address(RVA = "0x351440", Offset = "0x350240", VA = "0x10351440")]
    public bool IsKeyUnlock(long unixtime) => new bool();

    [Token(Token = "0x6006C1B")]
    [Address(RVA = "0x350340", Offset = "0x34F140", VA = "0x10350340")]
    public bool CheckHasKeyItem() => new bool();

    [Token(Token = "0x6006C1C")]
    [Address(RVA = "0x350420", Offset = "0x34F220", VA = "0x10350420")]
    public bool CheckHasKey() => new bool();

    [Token(Token = "0x6006C1D")]
    [Address(RVA = "0x350320", Offset = "0x34F120", VA = "0x10350320")]
    public bool CheckEnableChallange() => new bool();

    [Token(Token = "0x6006C1E")]
    [Address(RVA = "0x3500C0", Offset = "0x34EEC0", VA = "0x103500C0")]
    public bool CheckEnableChallange(out ChapterParam chapter) => new bool();

    [Token(Token = "0x6006C1F")]
    [Address(RVA = "0x350990", Offset = "0x34F790", VA = "0x10350990")]
    public bool IncrementChallangeCount() => new bool();

    [Token(Token = "0x17000BC4")]
    public bool HasChallengeLimit
    {
      [Token(Token = "0x6006C20"), Address(RVA = "0x352380", Offset = "0x351180", VA = "0x10352380")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6006C21")]
    [Address(RVA = "0x351A20", Offset = "0x350820", VA = "0x10351A20")]
    public bool IsQuestCondition() => new bool();

    [Token(Token = "0x6006C22")]
    [Address(RVA = "0x288090", Offset = "0x286E90", VA = "0x10288090")]
    public int ChallengeLimitCount() => new int();

    [Token(Token = "0x6006C23")]
    [Address(RVA = "0x3510B0", Offset = "0x34FEB0", VA = "0x103510B0")]
    public bool IsCombatPowerQuest() => new bool();

    [Token(Token = "0x6006C24")]
    [Address(RVA = "0x351230", Offset = "0x350030", VA = "0x10351230")]
    public bool IsDragonGodQuest() => new bool();

    [Token(Token = "0x6006C25")]
    [Address(RVA = "0x3517D0", Offset = "0x3505D0", VA = "0x103517D0")]
    public bool IsPointEventQuest() => new bool();

    [Token(Token = "0x6006C26")]
    [Address(RVA = "0x350F90", Offset = "0x34FD90", VA = "0x10350F90")]
    public bool IsCloseScoreCallengeQuest() => new bool();

    [Token(Token = "0x6006C27")]
    [Address(RVA = "0x352290", Offset = "0x351090", VA = "0x10352290")]
    public bool UnLockCombatPowerConditions() => new bool();

    [Token(Token = "0x6006C28")]
    [Address(RVA = "0x351DD0", Offset = "0x350BD0", VA = "0x10351DD0")]
    public static bool TransSectionGotoPointQuest(
      string chapter,
      UIUtility.DialogResultEvent callback)
    {
      return new bool();
    }

    [Token(Token = "0x6006C29")]
    [Address(RVA = "0x3522C0", Offset = "0x3510C0", VA = "0x103522C0")]
    public ChapterParam()
    {
    }
  }
}
