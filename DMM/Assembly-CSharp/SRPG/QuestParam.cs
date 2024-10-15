// Decompiled with JetBrains decompiler
// Type: SRPG.QuestParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C50")]
  public class QuestParam
  {
    [Token(Token = "0x4006EE0")]
    [FieldOffset(Offset = "0x8")]
    private BitArray bit_array;
    [Token(Token = "0x4006EE1")]
    [FieldOffset(Offset = "0x0")]
    private static readonly int MULTI_MAX_TOTAL_UNIT;
    [Token(Token = "0x4006EE2")]
    [FieldOffset(Offset = "0x4")]
    private static readonly int MULTI_MAX_PLAYER_UNIT;
    [Token(Token = "0x4006EE3")]
    [FieldOffset(Offset = "0xC")]
    public string iname;
    [Token(Token = "0x4006EE4")]
    [FieldOffset(Offset = "0x10")]
    public string title;
    [Token(Token = "0x4006EE5")]
    [FieldOffset(Offset = "0x14")]
    public string name;
    [Token(Token = "0x4006EE6")]
    [FieldOffset(Offset = "0x18")]
    public string expr;
    [Token(Token = "0x4006EE7")]
    [FieldOffset(Offset = "0x1C")]
    private short cond_index;
    [Token(Token = "0x4006EE8")]
    [FieldOffset(Offset = "0x1E")]
    private short world_index;
    [Token(Token = "0x4006EE9")]
    [FieldOffset(Offset = "0x20")]
    private short ChapterID_index;
    [Token(Token = "0x4006EEA")]
    [FieldOffset(Offset = "0x24")]
    public string mission;
    [Token(Token = "0x4006EEB")]
    [FieldOffset(Offset = "0x28")]
    public string[] cond_quests;
    [Token(Token = "0x4006EEC")]
    [FieldOffset(Offset = "0x2C")]
    public ShareStringList units;
    [Token(Token = "0x4006EED")]
    [FieldOffset(Offset = "0x30")]
    public QuestDifficulties difficulty;
    [Token(Token = "0x4006EEE")]
    [FieldOffset(Offset = "0x34")]
    public string navigation;
    [Token(Token = "0x4006EEF")]
    [FieldOffset(Offset = "0x38")]
    public short dailyCount;
    [Token(Token = "0x4006EF0")]
    [FieldOffset(Offset = "0x3A")]
    public short dailyReset;
    [Token(Token = "0x4006EF2")]
    [FieldOffset(Offset = "0x40")]
    public string storyTextID;
    [Token(Token = "0x4006EF3")]
    [FieldOffset(Offset = "0x44")]
    public QuestStates state;
    [Token(Token = "0x4006EF4")]
    [FieldOffset(Offset = "0x48")]
    public int clear_missions;
    [Token(Token = "0x4006EF5")]
    [FieldOffset(Offset = "0x4C")]
    public int[] mission_values;
    [Token(Token = "0x4006EF6")]
    [FieldOffset(Offset = "0x50")]
    public QuestBonusObjective[] bonusObjective;
    [Token(Token = "0x4006EF7")]
    [FieldOffset(Offset = "0x54")]
    public QuestPartyParam questParty;
    [Token(Token = "0x4006EF8")]
    [FieldOffset(Offset = "0x58")]
    public short point;
    [Token(Token = "0x4006EF9")]
    [FieldOffset(Offset = "0x5A")]
    public short aplv;
    [Token(Token = "0x4006EFA")]
    [FieldOffset(Offset = "0x5C")]
    public short challengeLimit;
    [Token(Token = "0x4006EFC")]
    [FieldOffset(Offset = "0x64")]
    public int pexp;
    [Token(Token = "0x4006EFD")]
    [FieldOffset(Offset = "0x68")]
    public int uexp;
    [Token(Token = "0x4006EFE")]
    [FieldOffset(Offset = "0x6C")]
    public int gold;
    [Token(Token = "0x4006EFF")]
    [FieldOffset(Offset = "0x70")]
    public int mcoin;
    [Token(Token = "0x4006F00")]
    [FieldOffset(Offset = "0x74")]
    public short clock_win;
    [Token(Token = "0x4006F01")]
    [FieldOffset(Offset = "0x76")]
    public short clock_lose;
    [Token(Token = "0x4006F02")]
    [FieldOffset(Offset = "0x78")]
    public short win;
    [Token(Token = "0x4006F03")]
    [FieldOffset(Offset = "0x7A")]
    public short lose;
    [Token(Token = "0x4006F04")]
    [FieldOffset(Offset = "0x7C")]
    public QuestTypes type;
    [Token(Token = "0x4006F05")]
    [FieldOffset(Offset = "0x7D")]
    public SubQuestTypes subtype;
    [Token(Token = "0x4006F06")]
    [FieldOffset(Offset = "0x7E")]
    public short lv;
    [Token(Token = "0x4006F07")]
    [FieldOffset(Offset = "0x80")]
    public short multi;
    [Token(Token = "0x4006F08")]
    [FieldOffset(Offset = "0x82")]
    public short multiDead;
    [Token(Token = "0x4006F09")]
    [FieldOffset(Offset = "0x84")]
    public short playerNum;
    [Token(Token = "0x4006F0A")]
    [FieldOffset(Offset = "0x86")]
    public short unitNum;
    [Token(Token = "0x4006F0B")]
    [FieldOffset(Offset = "0x88")]
    public List<MapParam> map;
    [Token(Token = "0x4006F0C")]
    [FieldOffset(Offset = "0x8C")]
    public string event_start;
    [Token(Token = "0x4006F0D")]
    [FieldOffset(Offset = "0x90")]
    public string event_clear;
    [Token(Token = "0x4006F0E")]
    [FieldOffset(Offset = "0x94")]
    private short ticket_index;
    [Token(Token = "0x4006F0F")]
    [FieldOffset(Offset = "0x98")]
    public long start;
    [Token(Token = "0x4006F10")]
    [FieldOffset(Offset = "0xA0")]
    public long end;
    [Token(Token = "0x4006F11")]
    [FieldOffset(Offset = "0xA8")]
    public long key_end;
    [Token(Token = "0x4006F12")]
    [FieldOffset(Offset = "0xB0")]
    public int key_cnt;
    [Token(Token = "0x4006F13")]
    [FieldOffset(Offset = "0xB4")]
    public int key_limit;
    [Token(Token = "0x4006F14")]
    [FieldOffset(Offset = "0xB8")]
    public string VersusThumnail;
    [Token(Token = "0x4006F15")]
    [FieldOffset(Offset = "0xBC")]
    public string MapBuff;
    [Token(Token = "0x4006F16")]
    [FieldOffset(Offset = "0xC0")]
    public int VersusMoveCount;
    [Token(Token = "0x4006F17")]
    [FieldOffset(Offset = "0xC4")]
    public int DamageUpprPl;
    [Token(Token = "0x4006F18")]
    [FieldOffset(Offset = "0xC8")]
    public int DamageUpprEn;
    [Token(Token = "0x4006F19")]
    [FieldOffset(Offset = "0xCC")]
    public int DamageRatePl;
    [Token(Token = "0x4006F1A")]
    [FieldOffset(Offset = "0xD0")]
    public int DamageRateEn;
    [Token(Token = "0x4006F1B")]
    [FieldOffset(Offset = "0xD4")]
    public string MapEffectId;
    [Token(Token = "0x4006F1C")]
    [FieldOffset(Offset = "0xD8")]
    public string WeatherSetId;
    [Token(Token = "0x4006F1D")]
    [FieldOffset(Offset = "0xDC")]
    public string[] FirstClearItems;
    [Token(Token = "0x4006F1E")]
    [FieldOffset(Offset = "0xE0")]
    public int GenesisUIIndex;
    [Token(Token = "0x4006F1F")]
    [FieldOffset(Offset = "0xE4")]
    public string ResetItem;
    [Token(Token = "0x4006F20")]
    [FieldOffset(Offset = "0xE8")]
    public int ResetMax;
    [Token(Token = "0x4006F21")]
    [FieldOffset(Offset = "0xEC")]
    public string ResetCost;
    [Token(Token = "0x4006F22")]
    [FieldOffset(Offset = "0xF0")]
    public string OpenUnit;
    [Token(Token = "0x4006F23")]
    [FieldOffset(Offset = "0xF4")]
    public bool gps_enable;
    [Token(Token = "0x4006F24")]
    [FieldOffset(Offset = "0xF8")]
    private int mCombatPowerValue;
    [Token(Token = "0x4006F25")]
    [FieldOffset(Offset = "0xFC")]
    public string AllowedJobs;
    [Token(Token = "0x4006F26")]
    [FieldOffset(Offset = "0x100")]
    public QuestParam.Tags AllowedTags;
    [Token(Token = "0x4006F27")]
    [FieldOffset(Offset = "0x104")]
    public int PhysBonus;
    [Token(Token = "0x4006F28")]
    [FieldOffset(Offset = "0x108")]
    public int MagBonus;
    [Token(Token = "0x4006F29")]
    [FieldOffset(Offset = "0x10C")]
    public string ItemLayout;
    [Token(Token = "0x4006F2A")]
    [FieldOffset(Offset = "0x110")]
    public ChapterParam Chapter;
    [Token(Token = "0x4006F2B")]
    [FieldOffset(Offset = "0x114")]
    private int[] AtkTypeMags;
    [Token(Token = "0x4006F2C")]
    [FieldOffset(Offset = "0x118")]
    public QuestCondParam EntryCondition;
    [Token(Token = "0x4006F2D")]
    [FieldOffset(Offset = "0x11C")]
    public QuestCondParam EntryConditionCh;
    [Token(Token = "0x4006F2E")]
    [FieldOffset(Offset = "0x120")]
    public bool IsExtra;
    [Token(Token = "0x4006F2F")]
    [FieldOffset(Offset = "0x8")]
    private static Dictionary<string, bool> CachedGenesisIsBossLiberation;
    [Token(Token = "0x4006F30")]
    [FieldOffset(Offset = "0xC")]
    private static Dictionary<string, bool> CachedAdvanceIsBossLiberation;

    [Token(Token = "0x17000E9A")]
    public string cond
    {
      [Token(Token = "0x600742B"), Address(RVA = "0x38E600", Offset = "0x38D400", VA = "0x1038E600")] set
      {
      }
      [Token(Token = "0x600742C"), Address(RVA = "0x38E0B0", Offset = "0x38CEB0", VA = "0x1038E0B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E9B")]
    public string world
    {
      [Token(Token = "0x600742D"), Address(RVA = "0x38E750", Offset = "0x38D550", VA = "0x1038E750")] set
      {
      }
      [Token(Token = "0x600742E"), Address(RVA = "0x38E200", Offset = "0x38D000", VA = "0x1038E200")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E9C")]
    public string ChapterID
    {
      [Token(Token = "0x600742F"), Address(RVA = "0x38E2E0", Offset = "0x38D0E0", VA = "0x1038E2E0")] set
      {
      }
      [Token(Token = "0x6007430"), Address(RVA = "0x38D890", Offset = "0x38C690", VA = "0x1038D890")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E9D")]
    public int best_clear_time
    {
      [Token(Token = "0x6007431"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return new int();
      }
      [Token(Token = "0x6007432"), Address(RVA = "0x373920", Offset = "0x372720", VA = "0x10373920")] set
      {
      }
    }

    [Token(Token = "0x17000E9E")]
    public bool notSearch
    {
      [Token(Token = "0x6007433"), Address(RVA = "0x38E690", Offset = "0x38D490", VA = "0x1038E690")] set
      {
      }
      [Token(Token = "0x6007434"), Address(RVA = "0x38E140", Offset = "0x38CF40", VA = "0x1038E140")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000E9F")]
    public int dayReset
    {
      [Token(Token = "0x6007435"), Address(RVA = "0x2B5EA0", Offset = "0x2B4CA0", VA = "0x102B5EA0")] get
      {
        return new int();
      }
      [Token(Token = "0x6007436"), Address(RVA = "0x374A70", Offset = "0x373870", VA = "0x10374A70")] set
      {
      }
    }

    [Token(Token = "0x17000EA0")]
    public bool IsMulti
    {
      [Token(Token = "0x6007437"), Address(RVA = "0x38DD50", Offset = "0x38CB50", VA = "0x1038DD50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EA1")]
    public bool IsMultiEvent
    {
      [Token(Token = "0x6007438"), Address(RVA = "0x38DCB0", Offset = "0x38CAB0", VA = "0x1038DCB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EA2")]
    public bool IsMultiVersus
    {
      [Token(Token = "0x6007439"), Address(RVA = "0x38DD30", Offset = "0x38CB30", VA = "0x1038DD30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EA3")]
    public bool IsMultiAreaQuest
    {
      [Token(Token = "0x600743A"), Address(RVA = "0x38DC60", Offset = "0x38CA60", VA = "0x1038DC60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EA4")]
    public bool IsMultiCoop
    {
      [Token(Token = "0x600743B"), Address(RVA = "0x38DC90", Offset = "0x38CA90", VA = "0x1038DC90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EA5")]
    public bool IsMultiCoopWithTower
    {
      [Token(Token = "0x600743C"), Address(RVA = "0x38DC70", Offset = "0x38CA70", VA = "0x1038DC70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EA6")]
    public bool IsMultiPvP
    {
      [Token(Token = "0x600743D"), Address(RVA = "0x38DD00", Offset = "0x38CB00", VA = "0x1038DD00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EA7")]
    public bool IsMultiAll
    {
      [Token(Token = "0x600743E"), Address(RVA = "0x38DC30", Offset = "0x38CA30", VA = "0x1038DC30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EA8")]
    public bool IsMultiPvPAuto
    {
      [Token(Token = "0x600743F"), Address(RVA = "0x38DD00", Offset = "0x38CB00", VA = "0x1038DD00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EA9")]
    public bool EnableRentalUnit
    {
      [Token(Token = "0x6007440"), Address(RVA = "0x38D900", Offset = "0x38C700", VA = "0x1038D900")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EAA")]
    public string ticket
    {
      [Token(Token = "0x6007441"), Address(RVA = "0x38E6F0", Offset = "0x38D4F0", VA = "0x1038E6F0")] set
      {
      }
      [Token(Token = "0x6007442"), Address(RVA = "0x38E1A0", Offset = "0x38CFA0", VA = "0x1038E1A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000EAB")]
    public bool AllowRetreat
    {
      [Token(Token = "0x6007443"), Address(RVA = "0x38E2B0", Offset = "0x38D0B0", VA = "0x1038E2B0")] set
      {
      }
      [Token(Token = "0x6007444"), Address(RVA = "0x38D860", Offset = "0x38C660", VA = "0x1038D860")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EAC")]
    public bool AllowAutoPlay
    {
      [Token(Token = "0x6007445"), Address(RVA = "0x38E280", Offset = "0x38D080", VA = "0x1038E280")] set
      {
      }
      [Token(Token = "0x6007446"), Address(RVA = "0x38D830", Offset = "0x38C630", VA = "0x1038D830")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EAD")]
    public bool FirstAutoPlayProhibit
    {
      [Token(Token = "0x6007447"), Address(RVA = "0x38E3F0", Offset = "0x38D1F0", VA = "0x1038E3F0")] set
      {
      }
      [Token(Token = "0x6007448"), Address(RVA = "0x38D950", Offset = "0x38C750", VA = "0x1038D950")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EAE")]
    public bool Silent
    {
      [Token(Token = "0x6007449"), Address(RVA = "0x38E570", Offset = "0x38D370", VA = "0x1038E570")] set
      {
      }
      [Token(Token = "0x600744A"), Address(RVA = "0x38E020", Offset = "0x38CE20", VA = "0x1038E020")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EAF")]
    public bool DisableAbilities
    {
      [Token(Token = "0x600744B"), Address(RVA = "0x38E360", Offset = "0x38D160", VA = "0x1038E360")] set
      {
      }
      [Token(Token = "0x600744C"), Address(RVA = "0x383400", Offset = "0x382200", VA = "0x10383400")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EB0")]
    public bool DisableItems
    {
      [Token(Token = "0x600744D"), Address(RVA = "0x38E3C0", Offset = "0x38D1C0", VA = "0x1038E3C0")] set
      {
      }
      [Token(Token = "0x600744E"), Address(RVA = "0x383460", Offset = "0x382260", VA = "0x10383460")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EB1")]
    public bool DisableContinue
    {
      [Token(Token = "0x600744F"), Address(RVA = "0x38E390", Offset = "0x38D190", VA = "0x1038E390")] set
      {
      }
      [Token(Token = "0x6007450"), Address(RVA = "0x383430", Offset = "0x382230", VA = "0x10383430")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EB2")]
    public bool IsUnitChange
    {
      [Token(Token = "0x6007451"), Address(RVA = "0x38E4E0", Offset = "0x38D2E0", VA = "0x1038E4E0")] set
      {
      }
      [Token(Token = "0x6007452"), Address(RVA = "0x38DF20", Offset = "0x38CD20", VA = "0x1038DF20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EB3")]
    public bool IsMultiLeaderSkill
    {
      [Token(Token = "0x6007453"), Address(RVA = "0x38E480", Offset = "0x38D280", VA = "0x1038E480")] set
      {
      }
      [Token(Token = "0x6007454"), Address(RVA = "0x38DCD0", Offset = "0x38CAD0", VA = "0x1038DCD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EB4")]
    public bool IsWeatherNoChange
    {
      [Token(Token = "0x6007455"), Address(RVA = "0x38E510", Offset = "0x38D310", VA = "0x1038E510")] set
      {
      }
      [Token(Token = "0x6007456"), Address(RVA = "0x38DF70", Offset = "0x38CD70", VA = "0x1038DF70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EB5")]
    public bool hidden
    {
      [Token(Token = "0x6007457"), Address(RVA = "0x38E660", Offset = "0x38D460", VA = "0x1038E660")] set
      {
      }
      [Token(Token = "0x6007458"), Address(RVA = "0x38E110", Offset = "0x38CF10", VA = "0x1038E110")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EB6")]
    public bool replayLimit
    {
      [Token(Token = "0x6007459"), Address(RVA = "0x38E6C0", Offset = "0x38D4C0", VA = "0x1038E6C0")] set
      {
      }
      [Token(Token = "0x600745A"), Address(RVA = "0x38E170", Offset = "0x38CF70", VA = "0x1038E170")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EB7")]
    public int AdvanceUIIndex
    {
      [Token(Token = "0x600745B"), Address(RVA = "0x38D820", Offset = "0x38C620", VA = "0x1038D820")] get
      {
        return new int();
      }
      [Token(Token = "0x600745C"), Address(RVA = "0x38E260", Offset = "0x38D060", VA = "0x1038E260")] set
      {
      }
    }

    [Token(Token = "0x17000EB8")]
    public bool IsAutoRepeatQuestFlag
    {
      [Token(Token = "0x600745D"), Address(RVA = "0x38E420", Offset = "0x38D220", VA = "0x1038E420")] set
      {
      }
      [Token(Token = "0x600745E"), Address(RVA = "0x38D9F0", Offset = "0x38C7F0", VA = "0x1038D9F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EB9")]
    public bool IsAutoRepeat
    {
      [Token(Token = "0x600745F"), Address(RVA = "0x38DA20", Offset = "0x38C820", VA = "0x1038DA20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EBA")]
    public int CombatPowerValue
    {
      [Token(Token = "0x6007460"), Address(RVA = "0x38D8F0", Offset = "0x38C6F0", VA = "0x1038D8F0")] get
      {
        return new int();
      }
      [Token(Token = "0x6007461"), Address(RVA = "0x38E340", Offset = "0x38D140", VA = "0x1038E340")] set
      {
      }
    }

    [Token(Token = "0x17000EBB")]
    public bool ShowReviewPopup
    {
      [Token(Token = "0x6007462"), Address(RVA = "0x38E540", Offset = "0x38D340", VA = "0x1038E540")] set
      {
      }
      [Token(Token = "0x6007463"), Address(RVA = "0x38DFF0", Offset = "0x38CDF0", VA = "0x1038DFF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EBC")]
    public bool IsScenario
    {
      [Token(Token = "0x6007464"), Address(RVA = "0x38DE50", Offset = "0x38CC50", VA = "0x1038DE50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EBD")]
    public bool IsStory
    {
      [Token(Token = "0x6007465"), Address(RVA = "0x38DF00", Offset = "0x38CD00", VA = "0x1038DF00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EBE")]
    public bool IsStoryElite
    {
      [Token(Token = "0x6007466"), Address(RVA = "0x38DEE0", Offset = "0x38CCE0", VA = "0x1038DEE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EBF")]
    public bool IsStoryExtra
    {
      [Token(Token = "0x6007467"), Address(RVA = "0x38DEF0", Offset = "0x38CCF0", VA = "0x1038DEF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EC0")]
    public bool IsStoryAll
    {
      [Token(Token = "0x6007468"), Address(RVA = "0x38DEC0", Offset = "0x38CCC0", VA = "0x1038DEC0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EC1")]
    public bool IsEvent
    {
      [Token(Token = "0x6007469"), Address(RVA = "0x38DAF0", Offset = "0x38C8F0", VA = "0x1038DAF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EC2")]
    public bool IsGps
    {
      [Token(Token = "0x600746A"), Address(RVA = "0x38DB60", Offset = "0x38C960", VA = "0x1038DB60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EC3")]
    public bool IsVersus
    {
      [Token(Token = "0x600746B"), Address(RVA = "0x38DF50", Offset = "0x38CD50", VA = "0x1038DF50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EC4")]
    public bool IsRankMatch
    {
      [Token(Token = "0x600746C"), Address(RVA = "0x38DE40", Offset = "0x38CC40", VA = "0x1038DE40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EC5")]
    public bool IsKeyQuest
    {
      [Token(Token = "0x600746D"), Address(RVA = "0x38DBF0", Offset = "0x38C9F0", VA = "0x1038DBF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EC6")]
    public bool IsQuestDrops
    {
      [Token(Token = "0x600746E"), Address(RVA = "0x38DDF0", Offset = "0x38CBF0", VA = "0x1038DDF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EC7")]
    public bool IsTower
    {
      [Token(Token = "0x600746F"), Address(RVA = "0x38DF10", Offset = "0x38CD10", VA = "0x1038DF10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EC8")]
    public bool IsMultiTower
    {
      [Token(Token = "0x6007470"), Address(RVA = "0x38DD20", Offset = "0x38CB20", VA = "0x1038DD20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EC9")]
    public bool IsRaid
    {
      [Token(Token = "0x6007471"), Address(RVA = "0x38DE30", Offset = "0x38CC30", VA = "0x1038DE30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000ECA")]
    public bool IsGuildRaid
    {
      [Token(Token = "0x6007472"), Address(RVA = "0x38DB70", Offset = "0x38C970", VA = "0x1038DB70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000ECB")]
    public bool IsWorldRaid
    {
      [Token(Token = "0x6007473"), Address(RVA = "0x38DFA0", Offset = "0x38CDA0", VA = "0x1038DFA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000ECC")]
    public bool IsGenesisStory
    {
      [Token(Token = "0x6007474"), Address(RVA = "0x38DB30", Offset = "0x38C930", VA = "0x1038DB30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000ECD")]
    public bool IsGenesisBoss
    {
      [Token(Token = "0x6007475"), Address(RVA = "0x38DB20", Offset = "0x38C920", VA = "0x1038DB20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000ECE")]
    public bool IsGenesis
    {
      [Token(Token = "0x6007476"), Address(RVA = "0x38DB40", Offset = "0x38C940", VA = "0x1038DB40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000ECF")]
    public bool IsAdvanceStory
    {
      [Token(Token = "0x6007477"), Address(RVA = "0x38D990", Offset = "0x38C790", VA = "0x1038D990")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000ED0")]
    public bool IsAdvanceBoss
    {
      [Token(Token = "0x6007478"), Address(RVA = "0x38D980", Offset = "0x38C780", VA = "0x1038D980")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000ED1")]
    public bool IsAdvance
    {
      [Token(Token = "0x6007479"), Address(RVA = "0x38D9A0", Offset = "0x38C7A0", VA = "0x1038D9A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000ED2")]
    public bool IsGenAdvBoss
    {
      [Token(Token = "0x600747A"), Address(RVA = "0x38DB00", Offset = "0x38C900", VA = "0x1038DB00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000ED3")]
    public bool IsGvG
    {
      [Token(Token = "0x600747B"), Address(RVA = "0x38DBC0", Offset = "0x38C9C0", VA = "0x1038DBC0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000ED4")]
    public bool IsArena
    {
      [Token(Token = "0x600747C"), Address(RVA = "0x38D9E0", Offset = "0x38C7E0", VA = "0x1038D9E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000ED5")]
    public bool IsPreCalcResult
    {
      [Token(Token = "0x600747D"), Address(RVA = "0x38DDD0", Offset = "0x38CBD0", VA = "0x1038DDD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000ED6")]
    public bool IsCombatPowerQuest
    {
      [Token(Token = "0x600747E"), Address(RVA = "0x38DAD0", Offset = "0x38C8D0", VA = "0x1038DAD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000ED7")]
    public bool IsDragonGodQuest
    {
      [Token(Token = "0x600747F"), Address(RVA = "0x38DAE0", Offset = "0x38C8E0", VA = "0x1038DAE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000ED8")]
    public bool IsPointEventQuest
    {
      [Token(Token = "0x6007480"), Address(RVA = "0x38DDA0", Offset = "0x38CBA0", VA = "0x1038DDA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000ED9")]
    public bool IsPointQuest
    {
      [Token(Token = "0x6007481"), Address(RVA = "0x38DDB0", Offset = "0x38CBB0", VA = "0x1038DDB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EDA")]
    public bool IsLeagueMatch
    {
      [Token(Token = "0x6007482"), Address(RVA = "0x38DC20", Offset = "0x38CA20", VA = "0x1038DC20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EDB")]
    public bool IsGvGArenaLeagueMatch
    {
      [Token(Token = "0x6007483"), Address(RVA = "0x38DB80", Offset = "0x38C980", VA = "0x1038DB80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EDC")]
    public bool IsArenaLeagueMatch
    {
      [Token(Token = "0x6007484"), Address(RVA = "0x38D9C0", Offset = "0x38C7C0", VA = "0x1038D9C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EDD")]
    public bool IsGvGLeagueMatch
    {
      [Token(Token = "0x6007485"), Address(RVA = "0x38DBA0", Offset = "0x38C9A0", VA = "0x1038DBA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EDE")]
    public int GainPlayerExp
    {
      [Token(Token = "0x6007486"), Address(RVA = "0x2B6040", Offset = "0x2B4E40", VA = "0x102B6040")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EDF")]
    public int GainUnitExp
    {
      [Token(Token = "0x6007487"), Address(RVA = "0x349350", Offset = "0x348150", VA = "0x10349350")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EE0")]
    public int OverClockTimeWin
    {
      [Token(Token = "0x6007488"), Address(RVA = "0x38DFE0", Offset = "0x38CDE0", VA = "0x1038DFE0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EE1")]
    public int OverClockTimeLose
    {
      [Token(Token = "0x6007489"), Address(RVA = "0x38DFD0", Offset = "0x38CDD0", VA = "0x1038DFD0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EE2")]
    public bool IsBeginner
    {
      [Token(Token = "0x600748A"), Address(RVA = "0x38E450", Offset = "0x38D250", VA = "0x1038E450")] set
      {
      }
      [Token(Token = "0x600748B"), Address(RVA = "0x38DAA0", Offset = "0x38C8A0", VA = "0x1038DAA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EE3")]
    public bool UseFixEditor
    {
      [Token(Token = "0x600748C"), Address(RVA = "0x38E5A0", Offset = "0x38D3A0", VA = "0x1038E5A0")] set
      {
      }
      [Token(Token = "0x600748D"), Address(RVA = "0x38E050", Offset = "0x38CE50", VA = "0x1038E050")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EE4")]
    public bool IsNoStartVoice
    {
      [Token(Token = "0x600748E"), Address(RVA = "0x38E4B0", Offset = "0x38D2B0", VA = "0x1038E4B0")] set
      {
      }
      [Token(Token = "0x600748F"), Address(RVA = "0x38DD70", Offset = "0x38CB70", VA = "0x1038DD70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EE5")]
    public bool UseSupportUnit
    {
      [Token(Token = "0x6007490"), Address(RVA = "0x38E5D0", Offset = "0x38D3D0", VA = "0x1038E5D0")] set
      {
      }
      [Token(Token = "0x6007491"), Address(RVA = "0x38E080", Offset = "0x38CE80", VA = "0x1038E080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EE6")]
    public int MissionNum
    {
      [Token(Token = "0x6007492"), Address(RVA = "0x38DFB0", Offset = "0x38CDB0", VA = "0x1038DFB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007493")]
    [Address(RVA = "0x385550", Offset = "0x384350", VA = "0x10385550")]
    public int GetAtkTypeMag(AttackDetailTypes type) => new int();

    [Token(Token = "0x6007494")]
    [Address(RVA = "0x38B0F0", Offset = "0x389EF0", VA = "0x1038B0F0")]
    public void SetAtkTypeMag(int[] mags)
    {
    }

    [Token(Token = "0x6007495")]
    [Address(RVA = "0x3836F0", Offset = "0x3824F0", VA = "0x103836F0")]
    public void Deserialize(JSON_QuestParam json)
    {
    }

    [Token(Token = "0x6007496")]
    [Address(RVA = "0x38AD70", Offset = "0x389B70", VA = "0x1038AD70")]
    public bool IsUnitAllowed(UnitData unit) => new bool();

    [Token(Token = "0x6007497")]
    [Address(RVA = "0x38A880", Offset = "0x389680", VA = "0x1038A880")]
    public bool IsQuestCondition() => new bool();

    [Token(Token = "0x6007498")]
    [Address(RVA = "0x385050", Offset = "0x383E50", VA = "0x10385050")]
    public List<QuestParam> DetectNotClearConditionQuests() => (List<QuestParam>) null;

    [Token(Token = "0x6007499")]
    [Address(RVA = "0x38AD00", Offset = "0x389B00", VA = "0x1038AD00")]
    public bool IsTargetOfConditionQuests(QuestParam quest) => new bool();

    [Token(Token = "0x600749A")]
    [Address(RVA = "0x38ACA0", Offset = "0x389AA0", VA = "0x1038ACA0")]
    public bool IsTargetOfConditionQuests(string iname) => new bool();

    [Token(Token = "0x600749B")]
    [Address(RVA = "0x389470", Offset = "0x388270", VA = "0x10389470")]
    public bool IsAvailableUnit(UnitData unit) => new bool();

    [Token(Token = "0x600749C")]
    [Address(RVA = "0x389370", Offset = "0x388170", VA = "0x10389370")]
    public bool IsAvailableUnitCh(UnitData unit) => new bool();

    [Token(Token = "0x600749D")]
    [Address(RVA = "0x3893F0", Offset = "0x3881F0", VA = "0x103893F0")]
    public bool IsAvailableUnitInternal(QuestCondParam condition, UnitData unit) => new bool();

    [Token(Token = "0x600749E")]
    [Address(RVA = "0x38A280", Offset = "0x389080", VA = "0x1038A280")]
    public bool IsEntryQuestCondition(IEnumerable<UnitData> entryUnits, ref string error)
    {
      return new bool();
    }

    [Token(Token = "0x600749F")]
    [Address(RVA = "0x38A250", Offset = "0x389050", VA = "0x1038A250")]
    public bool IsEntryQuestCondition(UnitData unit) => new bool();

    [Token(Token = "0x60074A0")]
    [Address(RVA = "0x38A230", Offset = "0x389030", VA = "0x1038A230")]
    public bool IsEntryQuestCondition(UnitData unit, ref string error) => new bool();

    [Token(Token = "0x60074A1")]
    [Address(RVA = "0x389730", Offset = "0x388530", VA = "0x10389730")]
    public bool IsEntryQuestConditionCh(UnitData unit, ref string error) => new bool();

    [Token(Token = "0x60074A2")]
    [Address(RVA = "0x389750", Offset = "0x388550", VA = "0x10389750")]
    private bool IsEntryQuestCondition(QuestCondParam condition, UnitData unit, ref string error)
    {
      return new bool();
    }

    [Token(Token = "0x60074A3")]
    [Address(RVA = "0x3873F0", Offset = "0x3861F0", VA = "0x103873F0")]
    public List<string> GetEntryQuestConditions(bool titled = true, bool includeUnitLv = true, bool includeUnits = true)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x60074A4")]
    [Address(RVA = "0x385E90", Offset = "0x384C90", VA = "0x10385E90")]
    public List<string> GetEntryQuestConditionsCh(
      bool titled = true,
      bool includeUnitLv = true,
      bool includeUnits = true)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x60074A5")]
    [Address(RVA = "0x385EC0", Offset = "0x384CC0", VA = "0x10385EC0")]
    private List<string> GetEntryQuestConditionsInternal(
      QuestCondParam condParam,
      bool titled = true,
      bool includeUnitLv = true,
      bool includeUnits = true)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x60074A6")]
    [Address(RVA = "0x385190", Offset = "0x383F90", VA = "0x10385190")]
    public List<string> GetAddQuestInfo(bool is_inc_title = true) => (List<string>) null;

    [Token(Token = "0x60074A7")]
    [Address(RVA = "0x383100", Offset = "0x381F00", VA = "0x10383100")]
    private void AddWeatherNameLists(List<string> wth_name_lists, List<string> wth_id_lists)
    {
    }

    [Token(Token = "0x17000EE7")]
    public bool IsJigen
    {
      [Token(Token = "0x60074A8"), Address(RVA = "0x38DBD0", Offset = "0x38C9D0", VA = "0x1038DBD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60074A9")]
    [Address(RVA = "0x3895A0", Offset = "0x3883A0", VA = "0x103895A0")]
    public bool IsDateUnlock(long serverTime = -1) => new bool();

    [Token(Token = "0x60074AA")]
    [Address(RVA = "0x38AAF0", Offset = "0x3898F0", VA = "0x1038AAF0")]
    public bool IsReplayDateUnlock(long serverTime = -1) => new bool();

    [Token(Token = "0x60074AB")]
    [Address(RVA = "0x388060", Offset = "0x386E60", VA = "0x10388060")]
    public int GetSelectMainMemberNum() => new int();

    [Token(Token = "0x60074AC")]
    [Address(RVA = "0x383520", Offset = "0x382320", VA = "0x10383520")]
    public bool CheckEnableEntrySubMembers() => new bool();

    [Token(Token = "0x60074AD")]
    [Address(RVA = "0x383300", Offset = "0x382100", VA = "0x10383300")]
    public bool CheckAllowedAutoBattle() => new bool();

    [Token(Token = "0x60074AE")]
    [Address(RVA = "0x3833D0", Offset = "0x3821D0", VA = "0x103833D0")]
    public bool CheckAllowedRetreat() => new bool();

    [Token(Token = "0x60074AF")]
    [Address(RVA = "0x383400", Offset = "0x382200", VA = "0x10383400")]
    public bool CheckDisableAbilities() => new bool();

    [Token(Token = "0x60074B0")]
    [Address(RVA = "0x383460", Offset = "0x382260", VA = "0x10383460")]
    public bool CheckDisableItems() => new bool();

    [Token(Token = "0x60074B1")]
    [Address(RVA = "0x383430", Offset = "0x382230", VA = "0x10383430")]
    public bool CheckDisableContinue() => new bool();

    [Token(Token = "0x60074B2")]
    [Address(RVA = "0x383580", Offset = "0x382380", VA = "0x10383580")]
    public bool CheckEnableQuestResult() => new bool();

    [Token(Token = "0x60074B3")]
    [Address(RVA = "0x383570", Offset = "0x382370", VA = "0x10383570")]
    public bool CheckEnableGainedItem() => new bool();

    [Token(Token = "0x60074B4")]
    [Address(RVA = "0x383570", Offset = "0x382370", VA = "0x10383570")]
    public bool CheckEnableGainedGold() => new bool();

    [Token(Token = "0x60074B5")]
    [Address(RVA = "0x383570", Offset = "0x382370", VA = "0x10383570")]
    public bool CheckEnableGainedExp() => new bool();

    [Token(Token = "0x60074B6")]
    [Address(RVA = "0x3835C0", Offset = "0x3823C0", VA = "0x103835C0")]
    public bool CheckEnableSuspendStart() => new bool();

    [Token(Token = "0x60074B7")]
    [Address(RVA = "0x38B110", Offset = "0x389F10", VA = "0x1038B110")]
    public void SetChallangeCount(int count)
    {
    }

    [Token(Token = "0x60074B8")]
    [Address(RVA = "0x385580", Offset = "0x384380", VA = "0x10385580")]
    public int GetChallangeCount() => new int();

    [Token(Token = "0x60074B9")]
    [Address(RVA = "0x385670", Offset = "0x384470", VA = "0x10385670")]
    public int GetChapterChallangeCount() => new int();

    [Token(Token = "0x60074BA")]
    [Address(RVA = "0x3855D0", Offset = "0x3843D0", VA = "0x103855D0")]
    public int GetChallangeLimit() => new int();

    [Token(Token = "0x60074BB")]
    [Address(RVA = "0x3856D0", Offset = "0x3844D0", VA = "0x103856D0")]
    public int GetChapterChallangeLimit() => new int();

    [Token(Token = "0x60074BC")]
    [Address(RVA = "0x383490", Offset = "0x382290", VA = "0x10383490")]
    public bool CheckEnableChallange() => new bool();

    [Token(Token = "0x60074BD")]
    [Address(RVA = "0x3835A0", Offset = "0x3823A0", VA = "0x103835A0")]
    public bool CheckEnableReset() => new bool();

    [Token(Token = "0x60074BE")]
    [Address(RVA = "0x387EB0", Offset = "0x386CB0", VA = "0x10387EB0")]
    public int GetRestResetCount() => new int();

    [Token(Token = "0x60074BF")]
    [Address(RVA = "0x38B020", Offset = "0x389E20", VA = "0x1038B020")]
    public int RequiredApWithPlayerLv(int playerLv, bool campaign = true) => new int();

    [Token(Token = "0x60074C0")]
    [Address(RVA = "0x38B1E0", Offset = "0x389FE0", VA = "0x1038B1E0")]
    public static QuestTypes ToQuestType(string name) => new QuestTypes();

    [Token(Token = "0x60074C1")]
    [Address(RVA = "0x389540", Offset = "0x388340", VA = "0x10389540")]
    public bool IsCharacterQuest() => new bool();

    [Token(Token = "0x60074C2")]
    [Address(RVA = "0x38AED0", Offset = "0x389CD0", VA = "0x1038AED0")]
    public static PlayerPartyTypes QuestToPartyIndex(QuestTypes type) => new PlayerPartyTypes();

    [Token(Token = "0x60074C3")]
    [Address(RVA = "0x38A540", Offset = "0x389340", VA = "0x1038A540")]
    public bool IsKeyUnlock(long serverTime = -1) => new bool();

    [Token(Token = "0x60074C4")]
    [Address(RVA = "0x387720", Offset = "0x386520", VA = "0x10387720")]
    public void GetPartyTypes(
      out PlayerPartyTypes playerPartyType,
      out PlayerPartyTypes enemyPartyType)
    {
    }

    [Token(Token = "0x60074C5")]
    [Address(RVA = "0x3894F0", Offset = "0x3882F0", VA = "0x103894F0")]
    public bool IsAvailable() => new bool();

    [Token(Token = "0x60074C6")]
    [Address(RVA = "0x38C870", Offset = "0x38B670", VA = "0x1038C870")]
    public static bool TransSectionGotoQuest(
      string questID,
      out QuestTypes quest_type,
      UIUtility.DialogResultEvent callback)
    {
      return new bool();
    }

    [Token(Token = "0x60074C7")]
    [Address(RVA = "0x38C4F0", Offset = "0x38B2F0", VA = "0x1038C4F0")]
    public static bool TransSectionGotoNormal() => new bool();

    [Token(Token = "0x60074C8")]
    [Address(RVA = "0x38BCF0", Offset = "0x38AAF0", VA = "0x1038BCF0")]
    public static bool TransSectionGotoElite(UIUtility.DialogResultEvent callback) => new bool();

    [Token(Token = "0x60074C9")]
    [Address(RVA = "0x38CBF0", Offset = "0x38B9F0", VA = "0x1038CBF0")]
    public static bool TransSectionGotoStoryExtra(UIUtility.DialogResultEvent callback)
    {
      return new bool();
    }

    [Token(Token = "0x60074CA")]
    [Address(RVA = "0x38CEB0", Offset = "0x38BCB0", VA = "0x1038CEB0")]
    public static bool TransSectionGotoStory(string questID, UIUtility.DialogResultEvent callback)
    {
      return new bool();
    }

    [Token(Token = "0x60074CB")]
    [Address(RVA = "0x383690", Offset = "0x382490", VA = "0x10383690")]
    public static void ClearGenesisIsBossLiberation()
    {
    }

    [Token(Token = "0x60074CC")]
    [Address(RVA = "0x38C190", Offset = "0x38AF90", VA = "0x1038C190")]
    public static bool TransSectionGotoGenesis(string questID, UIUtility.DialogResultEvent callback)
    {
      return new bool();
    }

    [Token(Token = "0x60074CD")]
    [Address(RVA = "0x383630", Offset = "0x382430", VA = "0x10383630")]
    public static void ClearAdvanceIsBossLiberation()
    {
    }

    [Token(Token = "0x60074CE")]
    [Address(RVA = "0x38B7B0", Offset = "0x38A5B0", VA = "0x1038B7B0")]
    public static bool TransSectionGotoAdvance(string questID, UIUtility.DialogResultEvent callback)
    {
      return new bool();
    }

    [Token(Token = "0x60074CF")]
    [Address(RVA = "0x38D170", Offset = "0x38BF70", VA = "0x1038D170")]
    public static bool TransSectionGotoTower(string questID, out QuestTypes quest_type)
    {
      return new bool();
    }

    [Token(Token = "0x60074D0")]
    [Address(RVA = "0x38BFC0", Offset = "0x38ADC0", VA = "0x1038BFC0")]
    public static bool TransSectionGotoEvent(string questID, UIUtility.DialogResultEvent callback)
    {
      return new bool();
    }

    [Token(Token = "0x60074D1")]
    [Address(RVA = "0x38D340", Offset = "0x38C140", VA = "0x1038D340")]
    public static bool TransSelectionGotoCharacter(
      string questID,
      UIUtility.DialogResultEvent callback)
    {
      return new bool();
    }

    [Token(Token = "0x60074D2")]
    [Address(RVA = "0x38BAC0", Offset = "0x38A8C0", VA = "0x1038BAC0")]
    public static bool TransSectionGotoCombatPowerQuest(
      string questID,
      UIUtility.DialogResultEvent callback)
    {
      return new bool();
    }

    [Token(Token = "0x60074D3")]
    [Address(RVA = "0x38C500", Offset = "0x38B300", VA = "0x1038C500")]
    public static bool TransSectionGotoPointQuest(
      string questID,
      UIUtility.DialogResultEvent callback)
    {
      return new bool();
    }

    [Token(Token = "0x60074D4")]
    [Address(RVA = "0x38A6B0", Offset = "0x3894B0", VA = "0x1038A6B0")]
    public static bool IsOutOfPeriodPointQuestRanking(QuestParam quest) => new bool();

    [Token(Token = "0x60074D5")]
    [Address(RVA = "0x388480", Offset = "0x387280", VA = "0x10388480")]
    public static void GotoEventListChapter()
    {
    }

    [Token(Token = "0x60074D6")]
    [Address(RVA = "0x3885D0", Offset = "0x3873D0", VA = "0x103885D0")]
    public static void GotoEventListQuest(string questId)
    {
    }

    [Token(Token = "0x60074D7")]
    [Address(RVA = "0x388160", Offset = "0x386F60", VA = "0x10388160")]
    public static void GotoAdvanceListQuest(ChapterParam chapter)
    {
    }

    [Token(Token = "0x60074D8")]
    [Address(RVA = "0x3890D0", Offset = "0x387ED0", VA = "0x103890D0")]
    public static void GotoGenesisListQuest(ChapterParam chapter)
    {
    }

    [Token(Token = "0x60074D9")]
    [Address(RVA = "0x388380", Offset = "0x387180", VA = "0x10388380")]
    public static void GotoDragonGodListQuest(QuestParam quest, ChapterParam chapter)
    {
    }

    [Token(Token = "0x60074DA")]
    [Address(RVA = "0x389250", Offset = "0x388050", VA = "0x10389250")]
    public static void GotoPointEventListQuest(QuestParam quest, ChapterParam chapter)
    {
    }

    [Token(Token = "0x60074DB")]
    [Address(RVA = "0x38A960", Offset = "0x389760", VA = "0x1038A960")]
    public static bool IsRankingPeriodPointQuest(QuestParam quest) => new bool();

    [Token(Token = "0x60074DC")]
    [Address(RVA = "0x388B50", Offset = "0x387950", VA = "0x10388B50")]
    public static void GotoEventListQuest(QuestParam quest)
    {
    }

    [Token(Token = "0x60074DD")]
    [Address(RVA = "0x388660", Offset = "0x387460", VA = "0x10388660")]
    public static void GotoEventListQuest(ChapterParam chapter)
    {
    }

    [Token(Token = "0x60074DE")]
    [Address(RVA = "0x3875F0", Offset = "0x3863F0", VA = "0x103875F0")]
    public PartyCondType GetPartyCondType() => new PartyCondType();

    [Token(Token = "0x60074DF")]
    [Address(RVA = "0x387C90", Offset = "0x386A90", VA = "0x10387C90")]
    public QuestCondParam GetQuestCondParam() => (QuestCondParam) null;

    [Token(Token = "0x60074E0")]
    [Address(RVA = "0x38A630", Offset = "0x389430", VA = "0x1038A630")]
    public bool IsOpenUnitHave() => new bool();

    [Token(Token = "0x60074E1")]
    [Address(RVA = "0x385AB0", Offset = "0x3848B0", VA = "0x10385AB0")]
    public static CollaboSkillParam.Pair GetCollaboSkillQuest(string quest_id)
    {
      return (CollaboSkillParam.Pair) null;
    }

    [Token(Token = "0x60074E2")]
    [Address(RVA = "0x387F10", Offset = "0x386D10", VA = "0x10387F10")]
    public static List<QuestParam> GetSameChapterIDQuestParam(string chapter_id)
    {
      return (List<QuestParam>) null;
    }

    [Token(Token = "0x60074E3")]
    [Address(RVA = "0x387D50", Offset = "0x386B50", VA = "0x10387D50")]
    public static int GetRaidTicketCount_LimitMax(QuestParam quest, int ini_max) => new int();

    [Token(Token = "0x60074E4")]
    [Address(RVA = "0x389350", Offset = "0x388150", VA = "0x10389350")]
    public bool HasMission() => new bool();

    [Token(Token = "0x60074E5")]
    [Address(RVA = "0x38A5C0", Offset = "0x3893C0", VA = "0x1038A5C0")]
    public bool IsMissionClear(int index) => new bool();

    [Token(Token = "0x60074E6")]
    [Address(RVA = "0x38A5E0", Offset = "0x3893E0", VA = "0x1038A5E0")]
    public bool IsMissionCompleteALL() => new bool();

    [Token(Token = "0x60074E7")]
    [Address(RVA = "0x385A60", Offset = "0x384860", VA = "0x10385A60")]
    public int GetClearMissionNum() => new int();

    [Token(Token = "0x60074E8")]
    [Address(RVA = "0x38B170", Offset = "0x389F70", VA = "0x1038B170")]
    public void SetMissionFlag(int index, bool isClear)
    {
    }

    [Token(Token = "0x60074E9")]
    [Address(RVA = "0x38B1B0", Offset = "0x389FB0", VA = "0x1038B1B0")]
    public void SetMissionValue(int index, int value)
    {
    }

    [Token(Token = "0x60074EA")]
    [Address(RVA = "0x387520", Offset = "0x386320", VA = "0x10387520")]
    public int GetMissionValue(int index) => new int();

    [Token(Token = "0x60074EB")]
    [Address(RVA = "0x3835F0", Offset = "0x3823F0", VA = "0x103835F0")]
    public bool CheckMissionValueIsDefault(int index) => new bool();

    [Token(Token = "0x60074EC")]
    [Address(RVA = "0x387CB0", Offset = "0x386AB0", VA = "0x10387CB0")]
    public static QuestDifficulties GetQuestDifficulties(string value) => new QuestDifficulties();

    [Token(Token = "0x60074ED")]
    [Address(RVA = "0x385730", Offset = "0x384530", VA = "0x10385730")]
    public string GetClearBestTime() => (string) null;

    [Token(Token = "0x60074EE")]
    [Address(RVA = "0x387420", Offset = "0x386220", VA = "0x10387420")]
    public static QuestParam GetLatestAvailableNewQuest(
      QuestParam last_quest,
      QuestStates last_quest_state,
      List<QuestParam> available_quests)
    {
      return (QuestParam) null;
    }

    [Token(Token = "0x60074EF")]
    [Address(RVA = "0x38A860", Offset = "0x389660", VA = "0x1038A860")]
    public static bool IsPlayQuestFirstClear(QuestParam quest, QuestStates state) => new bool();

    [Token(Token = "0x60074F0")]
    [Address(RVA = "0x387550", Offset = "0x386350", VA = "0x10387550")]
    public static QuestParam GetOpenNewQuest(QuestParam quest, List<QuestParam> avaliable_quests)
    {
      return (QuestParam) null;
    }

    [Token(Token = "0x60074F1")]
    [Address(RVA = "0x38D630", Offset = "0x38C430", VA = "0x1038D630")]
    public bool UnLockCombatPowerQuest() => new bool();

    [Token(Token = "0x60074F2")]
    [Address(RVA = "0x387860", Offset = "0x386660", VA = "0x10387860")]
    public static List<QuestParam> GetPortPointQuestEvents() => (List<QuestParam>) null;

    [Token(Token = "0x60074F3")]
    [Address(RVA = "0x38D6F0", Offset = "0x38C4F0", VA = "0x1038D6F0")]
    public QuestParam()
    {
    }

    [Token(Token = "0x60074F4")]
    [Address(RVA = "0x38D660", Offset = "0x38C460", VA = "0x1038D660")]
    static QuestParam()
    {
    }

    [Token(Token = "0x2001C51")]
    private enum BitType
    {
      [Token(Token = "0x4006F32")] ShowReviewPopup,
      [Token(Token = "0x4006F33")] notSearch,
      [Token(Token = "0x4006F34")] IsBeginner,
      [Token(Token = "0x4006F35")] hidden,
      [Token(Token = "0x4006F36")] replayLimit,
      [Token(Token = "0x4006F37")] AllowRetreat,
      [Token(Token = "0x4006F38")] AllowAutoPlay,
      [Token(Token = "0x4006F39")] Silent,
      [Token(Token = "0x4006F3A")] DisableAbilities,
      [Token(Token = "0x4006F3B")] DisableItems,
      [Token(Token = "0x4006F3C")] DisableContinue,
      [Token(Token = "0x4006F3D")] UseFixEditor,
      [Token(Token = "0x4006F3E")] IsNoStartVoice,
      [Token(Token = "0x4006F3F")] UseSupportUnit,
      [Token(Token = "0x4006F40")] UnitChange,
      [Token(Token = "0x4006F41")] IsMultiLeaderSkill,
      [Token(Token = "0x4006F42")] FirstAutoPlayProbihit,
      [Token(Token = "0x4006F43")] IsWeatherNoChange,
      [Token(Token = "0x4006F44")] IsAutoRepeatQuest,
      [Token(Token = "0x4006F45")] MAX_BIT_ARRAY,
    }

    [Token(Token = "0x2001C52")]
    [Flags]
    public enum Tags : byte
    {
      [Token(Token = "0x4006F47")] MAL = 1,
      [Token(Token = "0x4006F48")] FEM = 2,
      [Token(Token = "0x4006F49")] HERO = 4,
    }
  }
}
