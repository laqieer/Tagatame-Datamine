// Decompiled with JetBrains decompiler
// Type: SRPG.BattleCore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000B5D")]
  public class BattleCore
  {
    [Token(Token = "0x4001BAB")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int MAX_MAP;
    [Token(Token = "0x4001BAC")]
    [FieldOffset(Offset = "0x4")]
    public static readonly int MAX_PARTY;
    [Token(Token = "0x4001BAD")]
    [FieldOffset(Offset = "0x8")]
    public static readonly int MAX_ENEMY;
    [Token(Token = "0x4001BAE")]
    [FieldOffset(Offset = "0xC")]
    public static readonly int MAX_ORDER;
    [Token(Token = "0x4001BAF")]
    [FieldOffset(Offset = "0x10")]
    public static readonly int MAX_UNITS;
    [Token(Token = "0x4001BB0")]
    public const int DTU_NEST_MAX = 256;
    [Token(Token = "0x4001BB1")]
    [FieldOffset(Offset = "0x8")]
    private QuestParam mQuestParam;
    [Token(Token = "0x4001BB2")]
    [FieldOffset(Offset = "0x10")]
    private long mBtlID;
    [Token(Token = "0x4001BB3")]
    [FieldOffset(Offset = "0x18")]
    private int mBtlFlags;
    [Token(Token = "0x4001BB4")]
    [FieldOffset(Offset = "0x1C")]
    private int mWinTriggerCount;
    [Token(Token = "0x4001BB5")]
    [FieldOffset(Offset = "0x20")]
    private int mLoseTriggerCount;
    [Token(Token = "0x4001BB6")]
    [FieldOffset(Offset = "0x24")]
    public int[] mActionCounts;
    [Token(Token = "0x4001BB7")]
    [FieldOffset(Offset = "0x28")]
    private int mKillstreak;
    [Token(Token = "0x4001BB8")]
    [FieldOffset(Offset = "0x2C")]
    private int mMaxKillstreak;
    [Token(Token = "0x4001BB9")]
    [FieldOffset(Offset = "0x30")]
    private Dictionary<string, int> mTargetKillstreakDict;
    [Token(Token = "0x4001BBA")]
    [FieldOffset(Offset = "0x34")]
    private Dictionary<string, int> mMaxTargetKillstreakDict;
    [Token(Token = "0x4001BBB")]
    [FieldOffset(Offset = "0x38")]
    private bool mPlayByManually;
    [Token(Token = "0x4001BBC")]
    [FieldOffset(Offset = "0x39")]
    private bool mIsUseAutoPlayMode;
    [Token(Token = "0x4001BBD")]
    [FieldOffset(Offset = "0x3C")]
    private int mTotalHeal;
    [Token(Token = "0x4001BBE")]
    [FieldOffset(Offset = "0x40")]
    private int mTotalDamagesTaken;
    [Token(Token = "0x4001BBF")]
    [FieldOffset(Offset = "0x44")]
    private int mTotalDamages;
    [Token(Token = "0x4001BC0")]
    [FieldOffset(Offset = "0x48")]
    private int mTotalDamagesTakenCount;
    [Token(Token = "0x4001BC1")]
    [FieldOffset(Offset = "0x4C")]
    private bool mIsDamageTakenCurrentSkill;
    [Token(Token = "0x4001BC2")]
    [FieldOffset(Offset = "0x50")]
    private int mMaxDamage;
    [Token(Token = "0x4001BC3")]
    [FieldOffset(Offset = "0x54")]
    private int mNumUsedItems;
    [Token(Token = "0x4001BC4")]
    [FieldOffset(Offset = "0x58")]
    private int mNumUsedSkills;
    [Token(Token = "0x4001BC5")]
    [FieldOffset(Offset = "0x5C")]
    private List<Unit> mAllUnits;
    [Token(Token = "0x4001BC6")]
    [FieldOffset(Offset = "0x60")]
    private int mNpcStartIndex;
    [Token(Token = "0x4001BC7")]
    [FieldOffset(Offset = "0x64")]
    private int mEntryUnitMax;
    [Token(Token = "0x4001BC8")]
    [FieldOffset(Offset = "0x68")]
    private List<Unit> mUnits;
    [Token(Token = "0x4001BC9")]
    [FieldOffset(Offset = "0x6C")]
    private List<Unit> mPlayer;
    [Token(Token = "0x4001BCA")]
    [FieldOffset(Offset = "0x70")]
    private List<Unit>[] mEnemys;
    [Token(Token = "0x4001BCB")]
    [FieldOffset(Offset = "0x74")]
    private OInt mLeaderIndex;
    [Token(Token = "0x4001BCC")]
    [FieldOffset(Offset = "0x88")]
    private OInt mEnemyLeaderIndex;
    [Token(Token = "0x4001BCD")]
    [FieldOffset(Offset = "0x9C")]
    private OInt mFriendIndex;
    [Token(Token = "0x4001BCE")]
    [FieldOffset(Offset = "0xB0")]
    private List<int> mMtLeaderIndexList;
    [Token(Token = "0x4001BCF")]
    [FieldOffset(Offset = "0xB4")]
    private FriendStates mFriendStates;
    [Token(Token = "0x4001BD0")]
    [FieldOffset(Offset = "0xB8")]
    private List<Unit> mStartingMembers;
    [Token(Token = "0x4001BD1")]
    [FieldOffset(Offset = "0xBC")]
    private List<Unit> mHelperUnits;
    [Token(Token = "0x4001BD2")]
    [FieldOffset(Offset = "0xC0")]
    private List<Unit> mProtectUnits;
    [Token(Token = "0x4001BD3")]
    [FieldOffset(Offset = "0xC4")]
    private List<Unit> mGuardUnits;
    [Token(Token = "0x4001BD4")]
    [FieldOffset(Offset = "0xC8")]
    private List<BattleCore.SkillManipulateTarget> mSkillManipulateList;
    [Token(Token = "0x4001BD5")]
    [FieldOffset(Offset = "0xCC")]
    private List<Unit> mSkillManipulateUnits;
    [Token(Token = "0x4001BD6")]
    [FieldOffset(Offset = "0xD0")]
    private List<Unit> mForceAlchemyTargetList;
    [Token(Token = "0x4001BD7")]
    [FieldOffset(Offset = "0xD4")]
    private List<BattleMap> mMap;
    [Token(Token = "0x4001BD8")]
    [FieldOffset(Offset = "0xD8")]
    private int mMapIndex;
    [Token(Token = "0x4001BD9")]
    [FieldOffset(Offset = "0xDC")]
    private OInt mClockTime;
    [Token(Token = "0x4001BDA")]
    [FieldOffset(Offset = "0xF0")]
    private OInt mClockTimeTotal;
    [Token(Token = "0x4001BDB")]
    [FieldOffset(Offset = "0x104")]
    private int mContinueCount;
    [Token(Token = "0x4001BDC")]
    [FieldOffset(Offset = "0x108")]
    private int mCurrentTeamId;
    [Token(Token = "0x4001BDD")]
    [FieldOffset(Offset = "0x10C")]
    private int mMaxTeamId;
    [Token(Token = "0x4001BDE")]
    [FieldOffset(Offset = "0x110")]
    private string mFinisherIname;
    [Token(Token = "0x4001BDF")]
    [FieldOffset(Offset = "0x114")]
    public bool mRequestAutoBattle;
    [Token(Token = "0x4001BE0")]
    [FieldOffset(Offset = "0x118")]
    public ItemData[] mInventory;
    [Token(Token = "0x4001BE1")]
    [FieldOffset(Offset = "0x11C")]
    public int AddBtlTrun;
    [Token(Token = "0x4001BE2")]
    public const int GUILDRAID_ADDTURN_MAX = 255;
    [Token(Token = "0x4001BE3")]
    [FieldOffset(Offset = "0x120")]
    private bool mIsBossContinue;
    [Token(Token = "0x4001BE4")]
    [FieldOffset(Offset = "0x124")]
    private List<BattleCore.OrderData> mOrder;
    [Token(Token = "0x4001BE5")]
    [FieldOffset(Offset = "0x128")]
    private BattleLogServer mLogs;
    [Token(Token = "0x4001BE6")]
    [FieldOffset(Offset = "0x12C")]
    private string mUniqueKey;
    [Token(Token = "0x4001BE7")]
    [FieldOffset(Offset = "0x130")]
    private uint mSeed;
    [Token(Token = "0x4001BE8")]
    [FieldOffset(Offset = "0x134")]
    private RandXorshift mRand;
    [Token(Token = "0x4001BE9")]
    [FieldOffset(Offset = "0x138")]
    private uint mSeedDamage;
    [Token(Token = "0x4001BEA")]
    [FieldOffset(Offset = "0x13C")]
    private RandXorshift mRandDamage;
    [Token(Token = "0x4001BEB")]
    [FieldOffset(Offset = "0x140")]
    private RandXorshift CurrentRand;
    [Token(Token = "0x4001BEC")]
    [FieldOffset(Offset = "0x144")]
    private Dictionary<string, BattleCore.SkillExecLog> mSkillExecLogs;
    [Token(Token = "0x4001BED")]
    [FieldOffset(Offset = "0x148")]
    private BattleCore.Record mRecord;
    [Token(Token = "0x4001BEE")]
    [FieldOffset(Offset = "0x14C")]
    private List<Grid> mGridLines;
    [Token(Token = "0x4001BEF")]
    [FieldOffset(Offset = "0x150")]
    private List<Unit> mTreasures;
    [Token(Token = "0x4001BF0")]
    [FieldOffset(Offset = "0x154")]
    private List<Unit> mGems;
    [Token(Token = "0x4001BF1")]
    [FieldOffset(Offset = "0x158")]
    private string[] mQuestCampaignIds;
    [Token(Token = "0x4001BF2")]
    [FieldOffset(Offset = "0x15C")]
    private List<GimmickEvent> mGimmickEvents;
    [Token(Token = "0x4001BF3")]
    [FieldOffset(Offset = "0x160")]
    private RankingQuestParam mRankingQuestParam;
    [Token(Token = "0x4001BF4")]
    [FieldOffset(Offset = "0x164")]
    private BattlePreCalcLogData mBattlePreCalcData;
    [Token(Token = "0x4001BF5")]
    [FieldOffset(Offset = "0x168")]
    private int mMyPlayerIndex;
    [Token(Token = "0x4001BF7")]
    [FieldOffset(Offset = "0x16D")]
    private bool mMultiFinishLoad;
    [Token(Token = "0x4001BFF")]
    [FieldOffset(Offset = "0x178")]
    private BattleCore.RESUME_STATE mResumeState;
    [Token(Token = "0x4001C00")]
    [FieldOffset(Offset = "0x17C")]
    public BattleCore.LogCallback LogHandler;
    [Token(Token = "0x4001C01")]
    [FieldOffset(Offset = "0x180")]
    public BattleCore.LogCallback WarningHandler;
    [Token(Token = "0x4001C02")]
    [FieldOffset(Offset = "0x184")]
    public BattleCore.LogCallback ErrorHandler;
    [Token(Token = "0x4001C03")]
    [FieldOffset(Offset = "0x188")]
    private bool mIsAutoBattle;
    [Token(Token = "0x4001C06")]
    [FieldOffset(Offset = "0x14")]
    private static BaseStatus BuffWorkStatus;
    [Token(Token = "0x4001C07")]
    [FieldOffset(Offset = "0x18")]
    private static BaseStatus DebuffWorkStatus;
    [Token(Token = "0x4001C08")]
    [FieldOffset(Offset = "0x1C")]
    private static BaseStatus BuffNegativeWorkStatus;
    [Token(Token = "0x4001C09")]
    [FieldOffset(Offset = "0x20")]
    private static BaseStatus DebuffNegativeWorkStatus;
    [Token(Token = "0x4001C0A")]
    [FieldOffset(Offset = "0x24")]
    private static BaseStatus BuffWorkScaleStatus;
    [Token(Token = "0x4001C0B")]
    [FieldOffset(Offset = "0x28")]
    private static BaseStatus DebuffWorkScaleStatus;
    [Token(Token = "0x4001C0C")]
    [FieldOffset(Offset = "0x2C")]
    private static readonly int[] BuffStatusTypesToBattleBonusTbl;
    [Token(Token = "0x4001C0D")]
    [FieldOffset(Offset = "0x30")]
    private static readonly int[] DebuffStatusTypesToBattleBonusTbl;
    [Token(Token = "0x4001C0E")]
    [FieldOffset(Offset = "0x34")]
    private static IntVector2[] mBigUnitOfsPos5x5;
    [Token(Token = "0x4001C0F")]
    [FieldOffset(Offset = "0x18C")]
    private List<Unit> ProtectTargetList;
    [Token(Token = "0x4001C10")]
    [FieldOffset(Offset = "0x190")]
    private List<Unit> ChangeTargetList;
    [Token(Token = "0x4001C11")]
    [FieldOffset(Offset = "0x194")]
    public bool IsUnitRestart;
    [Token(Token = "0x4001C15")]
    [FieldOffset(Offset = "0x198")]
    public bool[] EventTriggers;
    [Token(Token = "0x4001C16")]
    [FieldOffset(Offset = "0x19C")]
    private bool mIsArenaSkip;
    [Token(Token = "0x4001C17")]
    [FieldOffset(Offset = "0x1A0")]
    private uint mArenaActionCountMax;
    [Token(Token = "0x4001C18")]
    [FieldOffset(Offset = "0x1A4")]
    private uint mArenaActionCount;
    [Token(Token = "0x4001C19")]
    [FieldOffset(Offset = "0x1A8")]
    private int mArenaEnemyActionCount;
    [Token(Token = "0x4001C1A")]
    [FieldOffset(Offset = "0x1AC")]
    private string mArenaQuestID;
    [Token(Token = "0x4001C1B")]
    [FieldOffset(Offset = "0x1B0")]
    private BattleCore.Json_Battle mArenaQuestJsonBtl;
    [Token(Token = "0x4001C1C")]
    [FieldOffset(Offset = "0x1B4")]
    private bool mIsArenaCalc;
    [Token(Token = "0x4001C1D")]
    [FieldOffset(Offset = "0x1B8")]
    private BattleCore.QuestResult mArenaCalcResult;
    [Token(Token = "0x4001C1E")]
    [FieldOffset(Offset = "0x1BC")]
    private List<int> mPrCalcResultPlayerHp;
    [Token(Token = "0x4001C1F")]
    [FieldOffset(Offset = "0x1C0")]
    private List<int> mPrCalcResultEnemyHp;
    [Token(Token = "0x4001C20")]
    [FieldOffset(Offset = "0x1C4")]
    private BattleCore.eArenaCalcType mArenaCalcTypeNext;
    [Token(Token = "0x4001C24")]
    [FieldOffset(Offset = "0x1D4")]
    private List<Unit> KbDeadUnitLists;
    [Token(Token = "0x4001C25")]
    [FieldOffset(Offset = "0x38")]
    private static BaseStatus BuffAagWorkStatus;
    [Token(Token = "0x4001C26")]
    [FieldOffset(Offset = "0x3C")]
    private static BaseStatus DebuffAagWorkStatus;
    [Token(Token = "0x4001C27")]
    [FieldOffset(Offset = "0x40")]
    private static BaseStatus BuffAagNegativeWorkStatus;
    [Token(Token = "0x4001C28")]
    [FieldOffset(Offset = "0x44")]
    private static BaseStatus DebuffAagNegativeWorkStatus;
    [Token(Token = "0x4001C29")]
    [FieldOffset(Offset = "0x48")]
    private static BaseStatus AagWorkStatus;
    [Token(Token = "0x4001C2A")]
    [FieldOffset(Offset = "0x1D8")]
    private bool IsEnableAagBuff;
    [Token(Token = "0x4001C2B")]
    [FieldOffset(Offset = "0x1D9")]
    private bool IsEnableAagDebuff;
    [Token(Token = "0x4001C2C")]
    [FieldOffset(Offset = "0x1DA")]
    private bool IsEnableAagBuffNegative;
    [Token(Token = "0x4001C2D")]
    [FieldOffset(Offset = "0x1DB")]
    private bool IsEnableAagDebuffNegative;
    [Token(Token = "0x4001C2E")]
    [FieldOffset(Offset = "0x1DC")]
    private List<BuffAttachment> AagBuffAttachmentLists;
    [Token(Token = "0x4001C2F")]
    [FieldOffset(Offset = "0x1E0")]
    private List<Unit> AagTargetLists;
    [Token(Token = "0x4001C30")]
    [FieldOffset(Offset = "0x1E4")]
    private Unit FtgtUnit;
    [Token(Token = "0x4001C31")]
    [FieldOffset(Offset = "0x1E8")]
    private string FtgtSkillID;
    [Token(Token = "0x4001C32")]
    [FieldOffset(Offset = "0x1EC")]
    private IntVector2 FtgtPos;
    [Token(Token = "0x4001C33")]
    [FieldOffset(Offset = "0x1F4")]
    private bool IsValidFtgt;
    [Token(Token = "0x4001C34")]
    [FieldOffset(Offset = "0x4C")]
    private static List<BattleCore.SkillResult> mSkillResults;
    [Token(Token = "0x4001C35")]
    [FieldOffset(Offset = "0x1F8")]
    private List<Unit> mEnemyPriorities;
    [Token(Token = "0x4001C36")]
    [FieldOffset(Offset = "0x1FC")]
    private List<Unit> mGimmickPriorities;
    [Token(Token = "0x4001C37")]
    [FieldOffset(Offset = "0x200")]
    private GridMap<int> mMoveMap;
    [Token(Token = "0x4001C38")]
    [FieldOffset(Offset = "0x204")]
    private GridMap<bool> mRangeMap;
    [Token(Token = "0x4001C39")]
    [FieldOffset(Offset = "0x208")]
    private GridMap<bool> mScopeMap;
    [Token(Token = "0x4001C3A")]
    [FieldOffset(Offset = "0x20C")]
    private GridMap<bool> mSearchMap;
    [Token(Token = "0x4001C3B")]
    [FieldOffset(Offset = "0x210")]
    private GridMap<int> mSafeMap;
    [Token(Token = "0x4001C3C")]
    [FieldOffset(Offset = "0x214")]
    private GridMap<int> mSafeMapEx;
    [Token(Token = "0x4001C3D")]
    [FieldOffset(Offset = "0x218")]
    private SkillMap mSkillMap;
    [Token(Token = "0x4001C3E")]
    [FieldOffset(Offset = "0x21C")]
    private TrickMap mTrickMap;
    [Token(Token = "0x4001C3F")]
    [FieldOffset(Offset = "0x220")]
    private bool mIsEnableInvalidSkill;
    [Token(Token = "0x4001C40")]
    [FieldOffset(Offset = "0x224")]
    private List<int> mDamageList;
    [Token(Token = "0x4001C41")]
    [FieldOffset(Offset = "0x228")]
    private int mDamageListMax;

    [Token(Token = "0x17000221")]
    public string UniqueKey
    {
      [Token(Token = "0x6002B77"), Address(RVA = "0x349280", Offset = "0x348080", VA = "0x10349280")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6002B78")]
    [Address(RVA = "0xF80D90", Offset = "0xF7FB90", VA = "0x10F80D90")]
    public RandXorshift CloneRand() => (RandXorshift) null;

    [Token(Token = "0x6002B79")]
    [Address(RVA = "0xF80D50", Offset = "0xF7FB50", VA = "0x10F80D50")]
    public RandXorshift CloneRandDamage() => (RandXorshift) null;

    [Token(Token = "0x17000222")]
    public uint Seed
    {
      [Token(Token = "0x6002B7A"), Address(RVA = "0x349290", Offset = "0x348090", VA = "0x10349290")] get
      {
        return new uint();
      }
      [Token(Token = "0x6002B7B"), Address(RVA = "0x9AD960", Offset = "0x9AC760", VA = "0x109AD960")] set
      {
      }
    }

    [Token(Token = "0x17000223")]
    public RandXorshift Rand
    {
      [Token(Token = "0x6002B7C"), Address(RVA = "0xFC5440", Offset = "0xFC4240", VA = "0x10FC5440")] get
      {
        return (RandXorshift) null;
      }
    }

    [Token(Token = "0x17000224")]
    public uint DamageSeed
    {
      [Token(Token = "0x6002B7D"), Address(RVA = "0x349630", Offset = "0x348430", VA = "0x10349630")] get
      {
        return new uint();
      }
      [Token(Token = "0x6002B7E"), Address(RVA = "0x685850", Offset = "0x684650", VA = "0x10685850")] set
      {
      }
    }

    [Token(Token = "0x6002B7F")]
    [Address(RVA = "0xFB7F50", Offset = "0xFB6D50", VA = "0x10FB7F50")]
    public void SetRandSeed(int index, uint seed)
    {
    }

    [Token(Token = "0x6002B80")]
    [Address(RVA = "0xFB7F20", Offset = "0xFB6D20", VA = "0x10FB7F20")]
    public void SetRandDamageSeed(int index, uint seed)
    {
    }

    [Token(Token = "0x17000225")]
    public Dictionary<string, BattleCore.SkillExecLog> SkillExecLogs
    {
      [Token(Token = "0x6002B81"), Address(RVA = "0x349070", Offset = "0x347E70", VA = "0x10349070")] get
      {
        return (Dictionary<string, BattleCore.SkillExecLog>) null;
      }
    }

    [Token(Token = "0x17000226")]
    public BattlePreCalcLogData BattlePreCalcData
    {
      [Token(Token = "0x6002B82"), Address(RVA = "0xFC6090", Offset = "0xFC4E90", VA = "0x10FC6090")] set
      {
      }
      [Token(Token = "0x6002B83"), Address(RVA = "0xFC4810", Offset = "0xFC3610", VA = "0x10FC4810")] get
      {
        return (BattlePreCalcLogData) null;
      }
    }

    [Token(Token = "0x17000227")]
    public bool SyncStart
    {
      [Token(Token = "0x6002B84"), Address(RVA = "0xFC5540", Offset = "0xFC4340", VA = "0x10FC5540")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002B85"), Address(RVA = "0xFC63E0", Offset = "0xFC51E0", VA = "0x10FC63E0")] set
      {
      }
    }

    [Token(Token = "0x17000228")]
    public int MyPlayerIndex
    {
      [Token(Token = "0x6002B86"), Address(RVA = "0xFC53A0", Offset = "0xFC41A0", VA = "0x10FC53A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000229")]
    public bool IsMultiPlay
    {
      [Token(Token = "0x6002B87"), Address(RVA = "0xFC4F40", Offset = "0xFC3D40", VA = "0x10FC4F40")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002B88"), Address(RVA = "0xFC6210", Offset = "0xFC5010", VA = "0x10FC6210")] private set
      {
      }
    }

    [Token(Token = "0x1700022A")]
    public bool IsMultiVersus
    {
      [Token(Token = "0x6002B89"), Address(RVA = "0xFC4F70", Offset = "0xFC3D70", VA = "0x10FC4F70")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002B8A"), Address(RVA = "0xFC6270", Offset = "0xFC5070", VA = "0x10FC6270")] private set
      {
      }
    }

    [Token(Token = "0x1700022B")]
    public bool IsRankMatch
    {
      [Token(Token = "0x6002B8B"), Address(RVA = "0xA45C70", Offset = "0xA44A70", VA = "0x10A45C70")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002B8C"), Address(RVA = "0xA464F0", Offset = "0xA452F0", VA = "0x10A464F0")] private set
      {
      }
    }

    [Token(Token = "0x1700022C")]
    public bool IsMultiTower
    {
      [Token(Token = "0x6002B8D"), Address(RVA = "0xFC4F50", Offset = "0xFC3D50", VA = "0x10FC4F50")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002B8E"), Address(RVA = "0xFC6230", Offset = "0xFC5030", VA = "0x10FC6230")] private set
      {
      }
    }

    [Token(Token = "0x1700022D")]
    public bool IsTower
    {
      [Token(Token = "0x6002B8F"), Address(RVA = "0xFC5130", Offset = "0xFC3F30", VA = "0x10FC5130")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700022E")]
    public bool IsOrdeal
    {
      [Token(Token = "0x6002B90"), Address(RVA = "0xFC4F80", Offset = "0xFC3D80", VA = "0x10FC4F80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700022F")]
    public bool IsRaidQuest
    {
      [Token(Token = "0x6002B91"), Address(RVA = "0xFC4FF0", Offset = "0xFC3DF0", VA = "0x10FC4FF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000230")]
    public bool IsGuildRaidQuest
    {
      [Token(Token = "0x6002B92"), Address(RVA = "0xFC4EB0", Offset = "0xFC3CB0", VA = "0x10FC4EB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000231")]
    public bool IsGenesisStory
    {
      [Token(Token = "0x6002B93"), Address(RVA = "0xFC4E90", Offset = "0xFC3C90", VA = "0x10FC4E90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000232")]
    public bool IsGenesisBoss
    {
      [Token(Token = "0x6002B94"), Address(RVA = "0xFC4E70", Offset = "0xFC3C70", VA = "0x10FC4E70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000233")]
    public bool IsAdvanceStory
    {
      [Token(Token = "0x6002B95"), Address(RVA = "0xFC4CE0", Offset = "0xFC3AE0", VA = "0x10FC4CE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000234")]
    public bool IsAdvanceBoss
    {
      [Token(Token = "0x6002B96"), Address(RVA = "0xFC4CC0", Offset = "0xFC3AC0", VA = "0x10FC4CC0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000235")]
    public bool IsGvGQuest
    {
      [Token(Token = "0x6002B97"), Address(RVA = "0xFC4ED0", Offset = "0xFC3CD0", VA = "0x10FC4ED0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000236")]
    public bool IsWorldRaid
    {
      [Token(Token = "0x6002B98"), Address(RVA = "0xFC51A0", Offset = "0xFC3FA0", VA = "0x10FC51A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000237")]
    public bool IsDragonGod
    {
      [Token(Token = "0x6002B99"), Address(RVA = "0xFC4DE0", Offset = "0xFC3BE0", VA = "0x10FC4DE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000238")]
    public bool IsPointEvent
    {
      [Token(Token = "0x6002B9A"), Address(RVA = "0xFC4FA0", Offset = "0xFC3DA0", VA = "0x10FC4FA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000239")]
    public bool IsPointQuest
    {
      [Token(Token = "0x6002B9B"), Address(RVA = "0xFC4FC0", Offset = "0xFC3DC0", VA = "0x10FC4FC0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700023A")]
    public bool IsVSForceWin
    {
      [Token(Token = "0x6002B9C"), Address(RVA = "0xFC5190", Offset = "0xFC3F90", VA = "0x10FC5190")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002B9D"), Address(RVA = "0xFC62C0", Offset = "0xFC50C0", VA = "0x10FC62C0")] set
      {
      }
    }

    [Token(Token = "0x1700023B")]
    public bool IsVSForceWinComfirm
    {
      [Token(Token = "0x6002B9E"), Address(RVA = "0xFC5180", Offset = "0xFC3F80", VA = "0x10FC5180")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002B9F"), Address(RVA = "0xFC62A0", Offset = "0xFC50A0", VA = "0x10FC62A0")] set
      {
      }
    }

    [Token(Token = "0x1700023C")]
    public bool IsForcedParty
    {
      [Token(Token = "0x6002BA0"), Address(RVA = "0xFC4E30", Offset = "0xFC3C30", VA = "0x10FC4E30")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002BA1"), Address(RVA = "0xFC61F0", Offset = "0xFC4FF0", VA = "0x10FC61F0")] private set
      {
      }
    }

    [Token(Token = "0x1700023D")]
    public bool IsRankingQuest
    {
      [Token(Token = "0x6002BA2"), Address(RVA = "0xFC5010", Offset = "0xFC3E10", VA = "0x10FC5010")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700023E")]
    public bool MultiFinishLoad
    {
      [Token(Token = "0x6002BA3"), Address(RVA = "0xFC5380", Offset = "0xFC4180", VA = "0x10FC5380")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002BA4"), Address(RVA = "0xFC6320", Offset = "0xFC5120", VA = "0x10FC6320")] set
      {
      }
    }

    [Token(Token = "0x1700023F")]
    public BattleCore.RESUME_STATE ResumeState
    {
      [Token(Token = "0x6002BA5"), Address(RVA = "0xA45570", Offset = "0xA44370", VA = "0x10A45570")] get
      {
        return new BattleCore.RESUME_STATE();
      }
      [Token(Token = "0x6002BA6"), Address(RVA = "0xFC63A0", Offset = "0xFC51A0", VA = "0x10FC63A0")] set
      {
      }
    }

    [Token(Token = "0x17000240")]
    public bool IsResume
    {
      [Token(Token = "0x6002BA7"), Address(RVA = "0xFC5030", Offset = "0xFC3E30", VA = "0x10FC5030")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6002BA8")]
    [Address(RVA = "0xFB7F80", Offset = "0xFB6D80", VA = "0x10FB7F80")]
    public void SetResumeWait()
    {
    }

    [Token(Token = "0x6002BA9")]
    [Address(RVA = "0xF897C0", Offset = "0xF885C0", VA = "0x10F897C0")]
    private void DebugAssert(bool condition, string msg)
    {
    }

    [Token(Token = "0x6002BAA")]
    [Address(RVA = "0xF89880", Offset = "0xF88680", VA = "0x10F89880")]
    private void DebugLog(string s)
    {
    }

    [Token(Token = "0x6002BAB")]
    [Address(RVA = "0xF898B0", Offset = "0xF886B0", VA = "0x10F898B0")]
    private void DebugWarn(string s)
    {
    }

    [Token(Token = "0x6002BAC")]
    [Address(RVA = "0xF89850", Offset = "0xF88650", VA = "0x10F89850")]
    private void DebugErr(string s)
    {
    }

    [Token(Token = "0x17000241")]
    public string QuestID
    {
      [Token(Token = "0x6002BAD"), Address(RVA = "0x368E20", Offset = "0x367C20", VA = "0x10368E20")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000242")]
    public string QuestName
    {
      [Token(Token = "0x6002BAE"), Address(RVA = "0xFC53D0", Offset = "0xFC41D0", VA = "0x10FC53D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000243")]
    public string QuestTerms
    {
      [Token(Token = "0x6002BAF"), Address(RVA = "0xFC53F0", Offset = "0xFC41F0", VA = "0x10FC53F0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000244")]
    public QuestTypes QuestType
    {
      [Token(Token = "0x6002BB0"), Address(RVA = "0xFC5420", Offset = "0xFC4220", VA = "0x10FC5420")] get
      {
        return new QuestTypes();
      }
    }

    [Token(Token = "0x17000245")]
    public string QuestClearEventName
    {
      [Token(Token = "0x6002BB1"), Address(RVA = "0xFC53B0", Offset = "0xFC41B0", VA = "0x10FC53B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000246")]
    public bool IsUnitChange
    {
      [Token(Token = "0x6002BB2"), Address(RVA = "0xFC5150", Offset = "0xFC3F50", VA = "0x10FC5150")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000247")]
    public bool IsMultiLeaderSkill
    {
      [Token(Token = "0x6002BB3"), Address(RVA = "0xFC4F10", Offset = "0xFC3D10", VA = "0x10FC4F10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000248")]
    public List<BattleMap> Map
    {
      [Token(Token = "0x6002BB4"), Address(RVA = "0xFC5370", Offset = "0xFC4170", VA = "0x10FC5370")] get
      {
        return (List<BattleMap>) null;
      }
    }

    [Token(Token = "0x17000249")]
    public List<Unit> AllUnits
    {
      [Token(Token = "0x6002BB5"), Address(RVA = "0x288090", Offset = "0x286E90", VA = "0x10288090")] get
      {
        return (List<Unit>) null;
      }
    }

    [Token(Token = "0x1700024A")]
    public int NpcStartIndex
    {
      [Token(Token = "0x6002BB6"), Address(RVA = "0x2B5EA0", Offset = "0x2B4CA0", VA = "0x102B5EA0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700024B")]
    public List<Unit> Units
    {
      [Token(Token = "0x6002BB7"), Address(RVA = "0x349350", Offset = "0x348150", VA = "0x10349350")] get
      {
        return (List<Unit>) null;
      }
    }

    [Token(Token = "0x1700024C")]
    public List<BattleCore.OrderData> Order
    {
      [Token(Token = "0x6002BB8"), Address(RVA = "0x3490E0", Offset = "0x347EE0", VA = "0x103490E0")] get
      {
        return (List<BattleCore.OrderData>) null;
      }
    }

    [Token(Token = "0x1700024D")]
    public List<Unit> StartingMembers
    {
      [Token(Token = "0x6002BB9"), Address(RVA = "0x3E1690", Offset = "0x3E0490", VA = "0x103E1690")] get
      {
        return (List<Unit>) null;
      }
    }

    [Token(Token = "0x1700024E")]
    public List<Unit> HelperUnits
    {
      [Token(Token = "0x6002BBA"), Address(RVA = "0x36AA10", Offset = "0x369810", VA = "0x1036AA10")] get
      {
        return (List<Unit>) null;
      }
    }

    [Token(Token = "0x1700024F")]
    public List<Unit> ProtectUnits
    {
      [Token(Token = "0x6002BBB"), Address(RVA = "0x5FC060", Offset = "0x5FAE60", VA = "0x105FC060")] get
      {
        return (List<Unit>) null;
      }
    }

    [Token(Token = "0x17000250")]
    public List<Unit> GuardUnits
    {
      [Token(Token = "0x6002BBC"), Address(RVA = "0x5FBFF0", Offset = "0x5FADF0", VA = "0x105FBFF0")] get
      {
        return (List<Unit>) null;
      }
    }

    [Token(Token = "0x17000251")]
    public List<BattleCore.SkillManipulateTarget> SkillManipulateList
    {
      [Token(Token = "0x6002BBD"), Address(RVA = "0x36A9E0", Offset = "0x3697E0", VA = "0x1036A9E0")] get
      {
        return (List<BattleCore.SkillManipulateTarget>) null;
      }
    }

    [Token(Token = "0x17000252")]
    public List<Unit> SkillManipulateUnits
    {
      [Token(Token = "0x6002BBE"), Address(RVA = "0x319830", Offset = "0x318630", VA = "0x10319830")] get
      {
        return (List<Unit>) null;
      }
    }

    [Token(Token = "0x17000253")]
    public List<Unit> ForceAlchemyTargetList
    {
      [Token(Token = "0x6002BBF"), Address(RVA = "0xFC4BA0", Offset = "0xFC39A0", VA = "0x10FC4BA0")] get
      {
        return (List<Unit>) null;
      }
    }

    [Token(Token = "0x17000254")]
    public int MapIndex
    {
      [Token(Token = "0x6002BC0"), Address(RVA = "0x6854B0", Offset = "0x6842B0", VA = "0x106854B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000255")]
    public BattleMap CurrentMap
    {
      [Token(Token = "0x6002BC1"), Address(RVA = "0xFC4880", Offset = "0xFC3680", VA = "0x10FC4880")] get
      {
        return (BattleMap) null;
      }
    }

    [Token(Token = "0x17000256")]
    public Unit CurrentUnit
    {
      [Token(Token = "0x6002BC2"), Address(RVA = "0xFC4940", Offset = "0xFC3740", VA = "0x10FC4940")] get
      {
        return (Unit) null;
      }
    }

    [Token(Token = "0x17000257")]
    public BattleCore.OrderData CurrentOrderData
    {
      [Token(Token = "0x6002BC3"), Address(RVA = "0xFC48E0", Offset = "0xFC36E0", VA = "0x10FC48E0")] get
      {
        return (BattleCore.OrderData) null;
      }
    }

    [Token(Token = "0x17000258")]
    public BattleLogServer Logs
    {
      [Token(Token = "0x6002BC4"), Address(RVA = "0xFC5360", Offset = "0xFC4160", VA = "0x10FC5360")] get
      {
        return (BattleLogServer) null;
      }
    }

    [Token(Token = "0x17000259")]
    public List<Unit> Player
    {
      [Token(Token = "0x6002BC5"), Address(RVA = "0x288AC0", Offset = "0x2878C0", VA = "0x10288AC0")] get
      {
        return (List<Unit>) null;
      }
    }

    [Token(Token = "0x1700025A")]
    public List<Unit> Enemys
    {
      [Token(Token = "0x6002BC6"), Address(RVA = "0xFC4B60", Offset = "0xFC3960", VA = "0x10FC4B60")] get
      {
        return (List<Unit>) null;
      }
    }

    [Token(Token = "0x1700025B")]
    public Unit Leader
    {
      [Token(Token = "0x6002BC7"), Address(RVA = "0xFC51F0", Offset = "0xFC3FF0", VA = "0x10FC51F0")] get
      {
        return (Unit) null;
      }
    }

    [Token(Token = "0x1700025C")]
    public Unit Friend
    {
      [Token(Token = "0x6002BC8"), Address(RVA = "0xFC4BB0", Offset = "0xFC39B0", VA = "0x10FC4BB0")] get
      {
        return (Unit) null;
      }
    }

    [Token(Token = "0x1700025D")]
    public Unit EnemyLeader
    {
      [Token(Token = "0x6002BC9"), Address(RVA = "0xFC49C0", Offset = "0xFC37C0", VA = "0x10FC49C0")] get
      {
        return (Unit) null;
      }
    }

    [Token(Token = "0x1700025E")]
    public OInt LeaderIndex
    {
      [Token(Token = "0x6002BCA"), Address(RVA = "0xFC51D0", Offset = "0xFC3FD0", VA = "0x10FC51D0")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x1700025F")]
    public OInt EnemyLeaderIndex
    {
      [Token(Token = "0x6002BCB"), Address(RVA = "0xFC49A0", Offset = "0xFC37A0", VA = "0x10FC49A0")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17000260")]
    public OInt FriendIndex
    {
      [Token(Token = "0x6002BCC"), Address(RVA = "0x3A6480", Offset = "0x3A5280", VA = "0x103A6480")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17000261")]
    public List<int> MtLeaderIndexList
    {
      [Token(Token = "0x6002BCD"), Address(RVA = "0x5FC000", Offset = "0x5FAE00", VA = "0x105FC000")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x17000262")]
    public bool IsFriendStatus
    {
      [Token(Token = "0x6002BCE"), Address(RVA = "0xFC4E40", Offset = "0xFC3C40", VA = "0x10FC4E40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000263")]
    public long BtlID
    {
      [Token(Token = "0x6002BCF"), Address(RVA = "0x361230", Offset = "0x360030", VA = "0x10361230")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000264")]
    public int WinTriggerCount
    {
      [Token(Token = "0x6002BD0"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6002BD1"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] set
      {
      }
    }

    [Token(Token = "0x17000265")]
    public int LoseTriggerCount
    {
      [Token(Token = "0x6002BD2"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
      [Token(Token = "0x6002BD3"), Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")] set
      {
      }
    }

    [Token(Token = "0x17000266")]
    public int ActionCountTotal
    {
      [Token(Token = "0x6002BD4"), Address(RVA = "0xFC47F0", Offset = "0xFC35F0", VA = "0x10FC47F0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000267")]
    public int Killstreak
    {
      [Token(Token = "0x6002BD5"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
      [Token(Token = "0x6002BD6"), Address(RVA = "0x36F650", Offset = "0x36E450", VA = "0x1036F650")] set
      {
      }
    }

    [Token(Token = "0x17000268")]
    public int MaxKillstreak
    {
      [Token(Token = "0x6002BD7"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
      [Token(Token = "0x6002BD8"), Address(RVA = "0x2A09E0", Offset = "0x29F7E0", VA = "0x102A09E0")] set
      {
      }
    }

    [Token(Token = "0x17000269")]
    public Dictionary<string, int> TargetKillstreak
    {
      [Token(Token = "0x6002BD9"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (Dictionary<string, int>) null;
      }
      [Token(Token = "0x6002BDA"), Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")] set
      {
      }
    }

    [Token(Token = "0x1700026A")]
    public Dictionary<string, int> MaxTargetKillstreak
    {
      [Token(Token = "0x6002BDB"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (Dictionary<string, int>) null;
      }
      [Token(Token = "0x6002BDC"), Address(RVA = "0x34C030", Offset = "0x34AE30", VA = "0x1034C030")] set
      {
      }
    }

    [Token(Token = "0x1700026B")]
    public bool PlayByManually
    {
      [Token(Token = "0x6002BDD"), Address(RVA = "0x2836F0", Offset = "0x2824F0", VA = "0x102836F0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002BDE"), Address(RVA = "0xAAFB50", Offset = "0xAAE950", VA = "0x10AAFB50")] set
      {
      }
    }

    [Token(Token = "0x1700026C")]
    public bool IsUseAutoPlayMode
    {
      [Token(Token = "0x6002BDF"), Address(RVA = "0x34AF90", Offset = "0x349D90", VA = "0x1034AF90")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002BE0"), Address(RVA = "0xFC6290", Offset = "0xFC5090", VA = "0x10FC6290")] set
      {
      }
    }

    [Token(Token = "0x1700026D")]
    public int TotalHeal
    {
      [Token(Token = "0x6002BE1"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return new int();
      }
      [Token(Token = "0x6002BE2"), Address(RVA = "0x373920", Offset = "0x372720", VA = "0x10373920")] set
      {
      }
    }

    [Token(Token = "0x1700026E")]
    public int TotalDamagesTaken
    {
      [Token(Token = "0x6002BE3"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return new int();
      }
      [Token(Token = "0x6002BE4"), Address(RVA = "0x56B300", Offset = "0x56A100", VA = "0x1056B300")] set
      {
      }
    }

    [Token(Token = "0x1700026F")]
    public int TotalDamages
    {
      [Token(Token = "0x6002BE5"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6002BE6"), Address(RVA = "0x56B2E0", Offset = "0x56A0E0", VA = "0x1056B2E0")] set
      {
      }
    }

    [Token(Token = "0x17000270")]
    public int TotalDamagesTakenCount
    {
      [Token(Token = "0x6002BE7"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return new int();
      }
      [Token(Token = "0x6002BE8"), Address(RVA = "0x370680", Offset = "0x36F480", VA = "0x10370680")] set
      {
      }
    }

    [Token(Token = "0x17000271")]
    public int MaxDamage
    {
      [Token(Token = "0x6002BE9"), Address(RVA = "0x3490F0", Offset = "0x347EF0", VA = "0x103490F0")] get
      {
        return new int();
      }
      [Token(Token = "0x6002BEA"), Address(RVA = "0x34FD00", Offset = "0x34EB00", VA = "0x1034FD00")] set
      {
      }
    }

    [Token(Token = "0x17000272")]
    public int NumUsedItems
    {
      [Token(Token = "0x6002BEB"), Address(RVA = "0x349170", Offset = "0x347F70", VA = "0x10349170")] get
      {
        return new int();
      }
      [Token(Token = "0x6002BEC"), Address(RVA = "0x374A40", Offset = "0x373840", VA = "0x10374A40")] set
      {
      }
    }

    [Token(Token = "0x17000273")]
    public int NumUsedSkills
    {
      [Token(Token = "0x6002BED"), Address(RVA = "0x349160", Offset = "0x347F60", VA = "0x10349160")] get
      {
        return new int();
      }
      [Token(Token = "0x6002BEE"), Address(RVA = "0x374A60", Offset = "0x373860", VA = "0x10374A60")] set
      {
      }
    }

    [Token(Token = "0x17000274")]
    public int ClockTime
    {
      [Token(Token = "0x6002BEF"), Address(RVA = "0xFC4850", Offset = "0xFC3650", VA = "0x10FC4850")] get
      {
        return new int();
      }
      [Token(Token = "0x6002BF0"), Address(RVA = "0xFC60F0", Offset = "0xFC4EF0", VA = "0x10FC60F0")] set
      {
      }
    }

    [Token(Token = "0x17000275")]
    public int ClockTimeTotal
    {
      [Token(Token = "0x6002BF1"), Address(RVA = "0xFC4820", Offset = "0xFC3620", VA = "0x10FC4820")] get
      {
        return new int();
      }
      [Token(Token = "0x6002BF2"), Address(RVA = "0xFC60B0", Offset = "0xFC4EB0", VA = "0x10FC60B0")] set
      {
      }
    }

    [Token(Token = "0x17000276")]
    public int ContinueCount
    {
      [Token(Token = "0x6002BF3"), Address(RVA = "0x33B040", Offset = "0x339E40", VA = "0x1033B040")] get
      {
        return new int();
      }
      [Token(Token = "0x6002BF4"), Address(RVA = "0xFC6130", Offset = "0xFC4F30", VA = "0x10FC6130")] set
      {
      }
    }

    [Token(Token = "0x17000277")]
    public int CurrentTeamId
    {
      [Token(Token = "0x6002BF5"), Address(RVA = "0x6718E0", Offset = "0x6706E0", VA = "0x106718E0")] get
      {
        return new int();
      }
      [Token(Token = "0x6002BF6"), Address(RVA = "0xFC6150", Offset = "0xFC4F50", VA = "0x10FC6150")] set
      {
      }
    }

    [Token(Token = "0x17000278")]
    public int MaxTeamId
    {
      [Token(Token = "0x6002BF7"), Address(RVA = "0x628750", Offset = "0x627550", VA = "0x10628750")] get
      {
        return new int();
      }
      [Token(Token = "0x6002BF8"), Address(RVA = "0xFC62E0", Offset = "0xFC50E0", VA = "0x10FC62E0")] set
      {
      }
    }

    [Token(Token = "0x17000279")]
    public string FinisherIname
    {
      [Token(Token = "0x6002BF9"), Address(RVA = "0x349390", Offset = "0x348190", VA = "0x10349390")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6002BFA"), Address(RVA = "0xFC6190", Offset = "0xFC4F90", VA = "0x10FC6190")] set
      {
      }
    }

    [Token(Token = "0x1700027A")]
    public bool RequestAutoBattle
    {
      [Token(Token = "0x6002BFB"), Address(RVA = "0xFC5470", Offset = "0xFC4270", VA = "0x10FC5470")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002BFC"), Address(RVA = "0xFC6380", Offset = "0xFC5180", VA = "0x10FC6380")] set
      {
      }
    }

    [Token(Token = "0x1700027B")]
    public bool IsAutoBattle
    {
      [Token(Token = "0x6002BFD"), Address(RVA = "0xFC4D20", Offset = "0xFC3B20", VA = "0x10FC4D20")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002BFE"), Address(RVA = "0xFC61D0", Offset = "0xFC4FD0", VA = "0x10FC61D0")] set
      {
      }
    }

    [Token(Token = "0x1700027C")]
    public bool StartIsAutoMulti
    {
      [Token(Token = "0x6002BFF"), Address(RVA = "0xFC5530", Offset = "0xFC4330", VA = "0x10FC5530")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002C00"), Address(RVA = "0xFC63C0", Offset = "0xFC51C0", VA = "0x10FC63C0")] set
      {
      }
    }

    [Token(Token = "0x1700027D")]
    public bool IsMultiUnitEnd
    {
      [Token(Token = "0x6002C01"), Address(RVA = "0xFC4F60", Offset = "0xFC3D60", VA = "0x10FC4F60")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002C02"), Address(RVA = "0xFC6250", Offset = "0xFC5050", VA = "0x10FC6250")] set
      {
      }
    }

    [Token(Token = "0x6002C03")]
    [Address(RVA = "0xFB7970", Offset = "0xFB6770", VA = "0x10FB7970")]
    public void SetManualPlayFlag()
    {
    }

    [Token(Token = "0x1700027E")]
    public bool IsSkillDirection
    {
      [Token(Token = "0x6002C04"), Address(RVA = "0xFC5050", Offset = "0xFC3E50", VA = "0x10FC5050")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700027F")]
    public string[] QuestCampaignIds
    {
      [Token(Token = "0x6002C05"), Address(RVA = "0x3405B0", Offset = "0x33F3B0", VA = "0x103405B0")] get
      {
        return (string[]) null;
      }
    }

    [Token(Token = "0x17000280")]
    public List<GimmickEvent> GimmickEventList
    {
      [Token(Token = "0x6002C06"), Address(RVA = "0x3B12F0", Offset = "0x3B00F0", VA = "0x103B12F0")] get
      {
        return (List<GimmickEvent>) null;
      }
    }

    [Token(Token = "0x6002C07")]
    [Address(RVA = "0xF96E20", Offset = "0xF95C20", VA = "0x10F96E20", Slot = "1")]
    ~BattleCore()
    {
    }

    [Token(Token = "0x6002C08")]
    [Address(RVA = "0xFB5000", Offset = "0xFB3E00", VA = "0x10FB5000")]
    public void Release()
    {
    }

    [Token(Token = "0x6002C09")]
    [Address(RVA = "0xFB8570", Offset = "0xFB7370", VA = "0x10FB8570")]
    public bool SetupMultiPlayUnit(
      UnitData[] units,
      int[] ownerPlayerIndex,
      int[] placementIndex,
      bool[] sub)
    {
      return new bool();
    }

    [Token(Token = "0x6002C0A")]
    [Address(RVA = "0xF89EF0", Offset = "0xF88CF0", VA = "0x10F89EF0")]
    public bool Deserialize(
      string questID,
      BattleCore.Json_Battle jsonBtl,
      int myPlayerIndex,
      UnitData[] units,
      int[] ownerPlayerIndex,
      bool is_restart = false,
      int[] placementIndex = null,
      bool[] sub = null)
    {
      return new bool();
    }

    [Token(Token = "0x6002C0B")]
    [Address(RVA = "0xF828E0", Offset = "0xF816E0", VA = "0x10F828E0")]
    private List<Unit> CreateBreakObjectUnit(List<NPCSetting> npcs) => (List<Unit>) null;

    [Token(Token = "0x6002C0C")]
    [Address(RVA = "0xFB6CA0", Offset = "0xFB5AA0", VA = "0x10FB6CA0")]
    private void SetFriendPlayerBuffAttach(UnitData unit_data, Json_Support json_support)
    {
    }

    [Token(Token = "0x6002C0D")]
    [Address(RVA = "0xF9FE20", Offset = "0xF9EC20", VA = "0x10F9FE20")]
    public int GetLeaguMatchSelfPlacementIndex(int idx) => new int();

    [Token(Token = "0x6002C0E")]
    [Address(RVA = "0xFA0C80", Offset = "0xF9FA80", VA = "0x10FA0C80")]
    public uint GetRandom() => new uint();

    [Token(Token = "0x6002C0F")]
    [Address(RVA = "0xFC0430", Offset = "0xFBF230", VA = "0x10FC0430")]
    private void UpdateUnitName()
    {
    }

    [Token(Token = "0x6002C10")]
    [Address(RVA = "0xFA0C20", Offset = "0xF9FA20", VA = "0x10FA0C20")]
    public QuestParam GetQuest() => (QuestParam) null;

    [Token(Token = "0x6002C11")]
    [Address(RVA = "0xF970B0", Offset = "0xF95EB0", VA = "0x10F970B0")]
    public ItemData FindInventoryByItemID(string iname) => (ItemData) null;

    [Token(Token = "0x6002C12")]
    [Address(RVA = "0xF729E0", Offset = "0xF717E0", VA = "0x10F729E0")]
    private void BeginBattlePassiveSkill()
    {
    }

    [Token(Token = "0x6002C13")]
    [Address(RVA = "0xF73590", Offset = "0xF72390", VA = "0x10F73590")]
    private void BeginLeagueMatchBattlePassiveSkill()
    {
    }

    [Token(Token = "0x6002C14")]
    [Address(RVA = "0xF71CF0", Offset = "0xF70AF0", VA = "0x10F71CF0")]
    private void ApplyConceptCardLS(Unit leader_unit, SkillData leader_skill)
    {
    }

    [Token(Token = "0x6002C15")]
    [Address(RVA = "0xFABC70", Offset = "0xFAAA70", VA = "0x10FABC70")]
    private bool IsConceptCardLsSkill(Unit unit) => new bool();

    [Token(Token = "0x6002C16")]
    [Address(RVA = "0xF731C0", Offset = "0xF71FC0", VA = "0x10F731C0")]
    private void BeginBattlePassiveSkill(Unit unit)
    {
    }

    [Token(Token = "0x6002C17")]
    [Address(RVA = "0xFBBC20", Offset = "0xFBAA20", VA = "0x10FBBC20")]
    private void UpdateBattlePassiveSkill()
    {
    }

    [Token(Token = "0x6002C18")]
    [Address(RVA = "0xFA7F10", Offset = "0xFA6D10", VA = "0x10FA7F10")]
    private void InternalBattlePassiveSkill(
      Unit self,
      SkillData skill,
      bool is_duplicate = false,
      BuffEffect[] buff_effects = null)
    {
    }

    [Token(Token = "0x6002C19")]
    [Address(RVA = "0xFA8120", Offset = "0xFA6F20", VA = "0x10FA8120")]
    private void InternalBattlePassiveSkill(
      Unit self,
      Unit target,
      SkillData skill,
      bool is_duplicate = false,
      BuffEffect[] buff_effects = null)
    {
    }

    [Token(Token = "0x6002C1A")]
    [Address(RVA = "0xFB6360", Offset = "0xFB5160", VA = "0x10FB6360")]
    private void SetBattleFlag(EBattleFlag tgt, bool sw)
    {
    }

    [Token(Token = "0x6002C1B")]
    [Address(RVA = "0xFA91E0", Offset = "0xFA7FE0", VA = "0x10FA91E0")]
    public bool IsBattleFlag(EBattleFlag tgt) => new bool();

    [Token(Token = "0x17000281")]
    public bool IsInitialized
    {
      [Token(Token = "0x6002C1C"), Address(RVA = "0xFC4EF0", Offset = "0xFC3CF0", VA = "0x10FC4EF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000282")]
    public bool IsMapCommand
    {
      [Token(Token = "0x6002C1D"), Address(RVA = "0xFC4F00", Offset = "0xFC3D00", VA = "0x10FC4F00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000283")]
    public bool IsBattle
    {
      [Token(Token = "0x6002C1E"), Address(RVA = "0xFC4DD0", Offset = "0xFC3BD0", VA = "0x10FC4DD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6002C1F")]
    [Address(RVA = "0xFAEF50", Offset = "0xFADD50", VA = "0x10FAEF50")]
    public bool IsUnitAuto(Unit unit) => new bool();

    [Token(Token = "0x6002C20")]
    [Address(RVA = "0xFB54F0", Offset = "0xFB42F0", VA = "0x10FB54F0")]
    public void RemoveLog()
    {
    }

    [Token(Token = "0x6002C21")]
    public LogType Log<LogType>() where LogType : BattleLog, new() => (LogType) null;

    [Token(Token = "0x6002C22")]
    [Address(RVA = "0xF791D0", Offset = "0xF77FD0", VA = "0x10F791D0")]
    private void CalcOrder()
    {
    }

    [Token(Token = "0x6002C23")]
    [Address(RVA = "0xFC55F0", Offset = "0xFC43F0", VA = "0x10FC55F0")]
    private int judgeSortOrder(BattleCore.OrderData src, BattleCore.OrderData dst) => new int();

    [Token(Token = "0x6002C24")]
    [Address(RVA = "0xFB9A30", Offset = "0xFB8830", VA = "0x10FB9A30")]
    public void StartOrder(bool sync = true, bool force = true, bool judge = true)
    {
    }

    [Token(Token = "0x6002C25")]
    [Address(RVA = "0xFA6CE0", Offset = "0xFA5AE0", VA = "0x10FA6CE0")]
    private void GimmickEventStart()
    {
    }

    [Token(Token = "0x6002C26")]
    [Address(RVA = "0xFB1E80", Offset = "0xFB0C80", VA = "0x10FB1E80")]
    private void NextOrder(bool is_skip_update_et = false, bool sync = true, bool forceSync = false, bool judge = true)
    {
    }

    [Token(Token = "0x6002C27")]
    [Address(RVA = "0xFC0CF0", Offset = "0xFBFAF0", VA = "0x10FC0CF0")]
    private bool UseAutoSkills() => new bool();

    [Token(Token = "0x6002C28")]
    [Address(RVA = "0xFC0B40", Offset = "0xFBF940", VA = "0x10FC0B40")]
    private bool UseAutoSkills(Unit unit) => new bool();

    [Token(Token = "0x6002C29")]
    [Address(RVA = "0xF7CF70", Offset = "0xF7BD70", VA = "0x10F7CF70")]
    private bool CheckEnableNextClockTime() => new bool();

    [Token(Token = "0x6002C2A")]
    [Address(RVA = "0xFB1C20", Offset = "0xFB0A20", VA = "0x10FB1C20")]
    private void NextClockTime()
    {
    }

    [Token(Token = "0x6002C2B")]
    [Address(RVA = "0xF82E50", Offset = "0xF81C50", VA = "0x10F82E50")]
    private void CreateGimmickEvents()
    {
    }

    [Token(Token = "0x6002C2C")]
    [Address(RVA = "0xFB5220", Offset = "0xFB4020", VA = "0x10FB5220")]
    public void RelinkTrickGimmickEvents()
    {
    }

    [Token(Token = "0x6002C2D")]
    [Address(RVA = "0xF9B570", Offset = "0xF9A370", VA = "0x10F9B570")]
    public void GetConditionUnitByUnitID(List<Unit> results, string inames)
    {
    }

    [Token(Token = "0x6002C2E")]
    [Address(RVA = "0xF9B3C0", Offset = "0xF9A1C0", VA = "0x10F9B3C0")]
    public void GetConditionUnitByUniqueName(List<Unit> results, string tags, out bool is_starter)
    {
    }

    [Token(Token = "0x6002C2F")]
    [Address(RVA = "0xF9B190", Offset = "0xF99F90", VA = "0x10F9B190")]
    public void GetConditionTrickByTrickID(List<TrickData> results, string inames)
    {
    }

    [Token(Token = "0x6002C30")]
    [Address(RVA = "0xF9AF50", Offset = "0xF99D50", VA = "0x10F9AF50")]
    public void GetConditionTrickByTag(List<TrickData> results, string tags)
    {
    }

    [Token(Token = "0x6002C31")]
    [Address(RVA = "0xFA63C0", Offset = "0xFA51C0", VA = "0x10FA63C0")]
    private void GimmickEventDamageCount(Unit attacker, Unit defender)
    {
    }

    [Token(Token = "0x6002C32")]
    [Address(RVA = "0xFA65C0", Offset = "0xFA53C0", VA = "0x10FA65C0")]
    private void GimmickEventDeadCount(Unit self, Unit target)
    {
    }

    [Token(Token = "0x6002C33")]
    [Address(RVA = "0xFA67E0", Offset = "0xFA55E0", VA = "0x10FA67E0")]
    public void GimmickEventHpLower(Unit defender)
    {
    }

    [Token(Token = "0x6002C34")]
    [Address(RVA = "0xFA6D40", Offset = "0xFA5B40", VA = "0x10FA6D40")]
    public void GimmickEventTrickKillCount(TrickData trick_data)
    {
    }

    [Token(Token = "0x6002C35")]
    [Address(RVA = "0xFA6A20", Offset = "0xFA5820", VA = "0x10FA6A20")]
    private void GimmickEventOnGrid()
    {
    }

    [Token(Token = "0x6002C36")]
    [Address(RVA = "0xF7CD00", Offset = "0xF7BB00", VA = "0x10F7CD00")]
    private bool CheckEnableGimmickEvent(GimmickEvent gimmick) => new bool();

    [Token(Token = "0x6002C37")]
    [Address(RVA = "0xFBC9F0", Offset = "0xFBB7F0", VA = "0x10FBC9F0")]
    private void UpdateGimmickEventStart()
    {
    }

    [Token(Token = "0x6002C38")]
    [Address(RVA = "0xFBD0B0", Offset = "0xFBBEB0", VA = "0x10FBD0B0")]
    private void UpdateGimmickEventTrick()
    {
    }

    [Token(Token = "0x6002C39")]
    [Address(RVA = "0xF7DF10", Offset = "0xF7CD10", VA = "0x10F7DF10")]
    private bool CheckMatchUniqueName(Unit self, string tag) => new bool();

    [Token(Token = "0x6002C3A")]
    [Address(RVA = "0xFAD1E0", Offset = "0xFABFE0", VA = "0x10FAD1E0")]
    private bool IsMatchTrickTag(TrickData td, string tag) => new bool();

    [Token(Token = "0x6002C3B")]
    [Address(RVA = "0xFBC220", Offset = "0xFBB020", VA = "0x10FBC220")]
    private void UpdateEntryTriggers(UnitEntryTypes type, Unit target, SkillParam skill = null)
    {
    }

    [Token(Token = "0x6002C3C")]
    [Address(RVA = "0xFA8F30", Offset = "0xFA7D30", VA = "0x10FA8F30")]
    public bool IsAllDead(EUnitSide side) => new bool();

    [Token(Token = "0x6002C3D")]
    [Address(RVA = "0xFA0B60", Offset = "0xF9F960", VA = "0x10FA0B60")]
    public BattleCore.QuestResult GetQuestResult() => new BattleCore.QuestResult();

    [Token(Token = "0x6002C3E")]
    [Address(RVA = "0xFA04E0", Offset = "0xF9F2E0", VA = "0x10FA04E0")]
    public BattleCore.QuestResult GetQuestResultConfirm() => new BattleCore.QuestResult();

    [Token(Token = "0x6002C3F")]
    [Address(RVA = "0xF9FC40", Offset = "0xF9EA40", VA = "0x10F9FC40")]
    private int GetHpRate(EUnitSide side) => new int();

    [Token(Token = "0x6002C40")]
    [Address(RVA = "0xF9E980", Offset = "0xF9D780", VA = "0x10F9E980")]
    public List<int> GetFinishHp(EUnitSide side) => (List<int>) null;

    [Token(Token = "0x6002C41")]
    [Address(RVA = "0xF9F440", Offset = "0xF9E240", VA = "0x10F9F440")]
    public int GetGvGFinishHp(EUnitSide side, GvGPartyUnit unit) => new int();

    [Token(Token = "0x6002C42")]
    [Address(RVA = "0xFB79B0", Offset = "0xFB67B0", VA = "0x10FB79B0")]
    public void SetPreBattleResultFinishHp()
    {
    }

    [Token(Token = "0x6002C43")]
    [Address(RVA = "0xFA02A0", Offset = "0xF9F0A0", VA = "0x10FA02A0")]
    public List<int> GetPreBattleResultFinishHp(EUnitSide side) => (List<int>) null;

    [Token(Token = "0x6002C44")]
    [Address(RVA = "0xF9C4B0", Offset = "0xF9B2B0", VA = "0x10F9C4B0")]
    public int GetDeadCount(EUnitSide side) => new int();

    [Token(Token = "0x6002C45")]
    [Address(RVA = "0xFA0090", Offset = "0xF9EE90", VA = "0x10FA0090")]
    public List<string> GetPlayerName() => (List<string>) null;

    [Token(Token = "0x6002C46")]
    [Address(RVA = "0xF98C40", Offset = "0xF97A40", VA = "0x10F98C40")]
    private int GetAddBtlTrun(int turn) => new int();

    [Token(Token = "0x6002C47")]
    [Address(RVA = "0xF7E0A0", Offset = "0xF7CEA0", VA = "0x10F7E0A0")]
    public bool CheckMonitorActionCount(QuestMonitorCondition cond) => new bool();

    [Token(Token = "0x6002C48")]
    [Address(RVA = "0xF7E040", Offset = "0xF7CE40", VA = "0x10F7E040")]
    private bool CheckMonitorActionCountCondition(Unit unit, UnitMonitorCondition monitor)
    {
      return new bool();
    }

    [Token(Token = "0x6002C49")]
    [Address(RVA = "0xF9FF20", Offset = "0xF9ED20", VA = "0x10F9FF20")]
    public int GetMonitorAllActionCount(EUnitSide eUnitSide, bool allFlag = false) => new int();

    [Token(Token = "0x6002C4A")]
    [Address(RVA = "0xF7D000", Offset = "0xF7BE00", VA = "0x10F7D000")]
    public bool CheckEnableRemainingActionCount(QuestMonitorCondition cond) => new bool();

    [Token(Token = "0x6002C4B")]
    [Address(RVA = "0xFA0CC0", Offset = "0xF9FAC0", VA = "0x10FA0CC0")]
    public int GetRemainingActionCount(QuestMonitorCondition cond) => new int();

    [Token(Token = "0x6002C4C")]
    [Address(RVA = "0xF7E6B0", Offset = "0xF7D4B0", VA = "0x10F7E6B0")]
    private bool CheckMonitorGoalUnit(QuestMonitorCondition cond) => new bool();

    [Token(Token = "0x6002C4D")]
    [Address(RVA = "0xF7E630", Offset = "0xF7D430", VA = "0x10F7E630")]
    private bool CheckMonitorGoalCondition(Unit unit, UnitMonitorCondition monitor) => new bool();

    [Token(Token = "0x6002C4E")]
    [Address(RVA = "0xF7EA70", Offset = "0xF7D870", VA = "0x10F7EA70")]
    private bool CheckMonitorWithdrawUnit(QuestMonitorCondition cond) => new bool();

    [Token(Token = "0x6002C4F")]
    [Address(RVA = "0xF7EA30", Offset = "0xF7D830", VA = "0x10F7EA30")]
    private bool CheckMonitorWithdrawCondition(Unit unit) => new bool();

    [Token(Token = "0x6002C50")]
    [Address(RVA = "0xFA9210", Offset = "0xFA8010", VA = "0x10FA9210")]
    public bool IsBonusObjectiveComplete(QuestBonusObjective bonus, ref int takeoverProgress)
    {
      return new bool();
    }

    [Token(Token = "0x6002C51")]
    [Address(RVA = "0xFABDC0", Offset = "0xFAABC0", VA = "0x10FABDC0")]
    private bool IsDefeatBossOneBattle() => new bool();

    [Token(Token = "0x6002C52")]
    [Address(RVA = "0xFAF0C0", Offset = "0xFADEC0", VA = "0x10FAF0C0")]
    private bool IsUnit(Unit unit) => new bool();

    [Token(Token = "0x6002C53")]
    [Address(RVA = "0xFAEC50", Offset = "0xFADA50", VA = "0x10FAEC50")]
    private bool IsTeamPartySizeMax(int max_num, bool is_inc_mercenary) => new bool();

    [Token(Token = "0x6002C54")]
    [Address(RVA = "0xFA8E40", Offset = "0xFA7C40", VA = "0x10FA8E40")]
    public bool IsAllAlive() => new bool();

    [Token(Token = "0x6002C55")]
    [Address(RVA = "0xFAE040", Offset = "0xFACE40", VA = "0x10FAE040")]
    public bool IsNPCAllAlive() => new bool();

    [Token(Token = "0x6002C56")]
    [Address(RVA = "0xFADE10", Offset = "0xFACC10", VA = "0x10FADE10")]
    public bool IsNPCAlive(string[] target_unit_inames) => new bool();

    [Token(Token = "0x6002C57")]
    [Address(RVA = "0xFAD640", Offset = "0xFAC440", VA = "0x10FAD640")]
    private bool IsMissionClearOnlyTargetUnitsConditions(
      QuestBonusObjective bonus,
      bool check_main_member_only = false)
    {
      return new bool();
    }

    [Token(Token = "0x6002C58")]
    [Address(RVA = "0xFAD220", Offset = "0xFAC020", VA = "0x10FAD220")]
    private bool IsMissionClearArtifactTypeConditions(
      QuestBonusObjective bonus,
      bool check_main_member_only = false)
    {
      return new bool();
    }

    [Token(Token = "0x6002C59")]
    [Address(RVA = "0xFAD840", Offset = "0xFAC640", VA = "0x10FAD840")]
    private bool IsMissionClearPartyMemberJobConditions(
      QuestBonusObjective bonus,
      bool check_main_member_only = false)
    {
      return new bool();
    }

    [Token(Token = "0x6002C5A")]
    [Address(RVA = "0xFAD480", Offset = "0xFAC280", VA = "0x10FAD480")]
    private bool IsMissionClearOnlyHeroConditions(bool check_main_member_only = false)
    {
      return new bool();
    }

    [Token(Token = "0x6002C5B")]
    [Address(RVA = "0xFADA50", Offset = "0xFAC850", VA = "0x10FADA50")]
    private bool IsMissionClearUnitBirthplaceConditions(
      QuestBonusObjective bonus,
      bool check_main_member_only = false)
    {
      return new bool();
    }

    [Token(Token = "0x6002C5C")]
    [Address(RVA = "0xFADC30", Offset = "0xFACA30", VA = "0x10FADC30")]
    private bool IsMissionClearUnitSexConditions(
      QuestBonusObjective bonus,
      bool check_main_member_only = false)
    {
      return new bool();
    }

    [Token(Token = "0x6002C5D")]
    [Address(RVA = "0xFAD040", Offset = "0xFABE40", VA = "0x10FAD040")]
    private bool IsKillAllEnemyOnceBattle() => new bool();

    [Token(Token = "0x6002C5E")]
    [Address(RVA = "0xFC4650", Offset = "0xFC3450", VA = "0x10FC4650")]
    private int getUnitDeadCount(string unit_iname) => new int();

    [Token(Token = "0x6002C5F")]
    [Address(RVA = "0xFA54A0", Offset = "0xFA42A0", VA = "0x10FA54A0")]
    private int GetTotalKillCount() => new int();

    [Token(Token = "0x6002C60")]
    [Address(RVA = "0xFA01B0", Offset = "0xF9EFB0", VA = "0x10FA01B0")]
    public int GetPlayerUnitDeadCount() => new int();

    [Token(Token = "0x6002C61")]
    [Address(RVA = "0xF7A2D0", Offset = "0xF790D0", VA = "0x10F7A2D0")]
    private void CalcQuestRecord()
    {
    }

    [Token(Token = "0x6002C62")]
    [Address(RVA = "0xF71670", Offset = "0xF70470", VA = "0x10F71670")]
    public void AddReward(RewardType rewardType, string iname)
    {
    }

    [Token(Token = "0x6002C63")]
    [Address(RVA = "0xF71270", Offset = "0xF70070", VA = "0x10F71270")]
    public void AddDisassemble(Json_Disassemble[] _disassemble)
    {
    }

    [Token(Token = "0x6002C64")]
    [Address(RVA = "0xFB7FA0", Offset = "0xFB6DA0", VA = "0x10FB7FA0")]
    private void SetReward(QuestBonusObjective bonus)
    {
    }

    [Token(Token = "0x6002C65")]
    [Address(RVA = "0xF985A0", Offset = "0xF973A0", VA = "0x10F985A0")]
    public void GainUnitDrop(BattleCore.Record record, bool waitDirection = false)
    {
    }

    [Token(Token = "0x6002C66")]
    [Address(RVA = "0xF98960", Offset = "0xF97760", VA = "0x10F98960")]
    public void GainUnitSteal(BattleCore.Record record)
    {
    }

    [Token(Token = "0x6002C67")]
    [Address(RVA = "0xF97990", Offset = "0xF96790", VA = "0x10F97990")]
    private void GainConvertedGold()
    {
    }

    [Token(Token = "0x6002C68")]
    [Address(RVA = "0xF98370", Offset = "0xF97170", VA = "0x10F98370")]
    private void GainRankMatchItem()
    {
    }

    [Token(Token = "0x6002C69")]
    [Address(RVA = "0xF97D70", Offset = "0xF96B70", VA = "0x10F97D70")]
    private void GainFreeVersusItem()
    {
    }

    [Token(Token = "0x6002C6A")]
    [Address(RVA = "0xFB83C0", Offset = "0xFB71C0", VA = "0x10FB83C0")]
    private void SetVersusReward(VersusWinBonusRewardParam[] rewards)
    {
    }

    [Token(Token = "0x6002C6B")]
    [Address(RVA = "0xFB6EB0", Offset = "0xFB5CB0", VA = "0x10FB6EB0")]
    public void SetGiftReward(GiftData gift)
    {
    }

    [Token(Token = "0x6002C6C")]
    [Address(RVA = "0xFB82A0", Offset = "0xFB70A0", VA = "0x10FB82A0")]
    public void SetRuneReward(List<RuneData> _datas)
    {
    }

    [Token(Token = "0x6002C6D")]
    [Address(RVA = "0xF97F10", Offset = "0xF96D10", VA = "0x10F97F10")]
    private void GainInspSkill()
    {
    }

    [Token(Token = "0x6002C6E")]
    [Address(RVA = "0xFB7270", Offset = "0xFB6070", VA = "0x10FB7270")]
    public void SetInspSkillIns(BattleCore.Json_BtlInspSlot[] sins)
    {
    }

    [Token(Token = "0x6002C6F")]
    [Address(RVA = "0xFB7560", Offset = "0xFB6360", VA = "0x10FB7560")]
    public void SetInspSkillLvUp(BattleCore.Json_BtlInsp[] levelup_sins)
    {
    }

    [Token(Token = "0x6002C70")]
    [Address(RVA = "0xF973D0", Offset = "0xF961D0", VA = "0x10F973D0")]
    public Unit FindPlayerUnitByUniqueID(long uiid) => (Unit) null;

    [Token(Token = "0x6002C71")]
    [Address(RVA = "0xFB6E60", Offset = "0xFB5C60", VA = "0x10FB6E60")]
    public void SetGenesisBossResult(Json_Gift[] gifts)
    {
    }

    [Token(Token = "0x6002C72")]
    [Address(RVA = "0xFB6310", Offset = "0xFB5110", VA = "0x10FB6310")]
    public void SetAdvanceBossResult(Json_Gift[] gifts)
    {
    }

    [Token(Token = "0x6002C73")]
    [Address(RVA = "0x5E0360", Offset = "0x5DF160", VA = "0x105E0360")]
    public BattleCore.Record GetQuestRecord() => (BattleCore.Record) null;

    [Token(Token = "0x6002C74")]
    [Address(RVA = "0xF7DEC0", Offset = "0xF7CCC0", VA = "0x10F7DEC0")]
    private bool CheckJudgeBattle() => new bool();

    [Token(Token = "0x6002C75")]
    [Address(RVA = "0xF7DE60", Offset = "0xF7CC60", VA = "0x10F7DE60")]
    private bool CheckJudgeBattleActionCount() => new bool();

    [Token(Token = "0x6002C76")]
    [Address(RVA = "0xF7F230", Offset = "0xF7E030", VA = "0x10F7F230")]
    public bool CheckNextMap() => new bool();

    [Token(Token = "0x6002C77")]
    [Address(RVA = "0xF9EB60", Offset = "0xF9D960", VA = "0x10F9EB60")]
    public int GetGems(Unit unit) => new int();

    [Token(Token = "0x6002C78")]
    [Address(RVA = "0xFB6DC0", Offset = "0xFB5BC0", VA = "0x10FB6DC0")]
    public void SetGems(Unit unit, int gems)
    {
    }

    [Token(Token = "0x6002C79")]
    [Address(RVA = "0xF71390", Offset = "0xF70190", VA = "0x10F71390")]
    private int AddGems(Unit unit, int gems) => new int();

    [Token(Token = "0x6002C7A")]
    [Address(RVA = "0xFB9BB0", Offset = "0xFB89B0", VA = "0x10FB9BB0")]
    private int SubGems(Unit unit, int gems) => new int();

    [Token(Token = "0x6002C7B")]
    [Address(RVA = "0xFA55B0", Offset = "0xFA43B0", VA = "0x10FA55B0")]
    public Grid GetUnitGridPosition(Unit unit) => (Grid) null;

    [Token(Token = "0x6002C7C")]
    [Address(RVA = "0xFA5580", Offset = "0xFA4380", VA = "0x10FA5580")]
    public Grid GetUnitGridPosition(int x, int y) => (Grid) null;

    [Token(Token = "0x6002C7D")]
    [Address(RVA = "0xF97690", Offset = "0xF96490", VA = "0x10F97690")]
    public Unit FindUnitByUniqueName(string uniqname) => (Unit) null;

    [Token(Token = "0x6002C7E")]
    [Address(RVA = "0xF97570", Offset = "0xF96370", VA = "0x10F97570")]
    public Unit FindUnitAtGrid(int x, int y) => (Unit) null;

    [Token(Token = "0x6002C7F")]
    [Address(RVA = "0xF975B0", Offset = "0xF963B0", VA = "0x10F975B0")]
    public Unit FindUnitAtGrid(Grid grid) => (Unit) null;

    [Token(Token = "0x6002C80")]
    [Address(RVA = "0xF8E3E0", Offset = "0xF8D1E0", VA = "0x10F8E3E0")]
    public Unit DirectFindUnitAtGrid(Grid grid) => (Unit) null;

    [Token(Token = "0x6002C81")]
    [Address(RVA = "0xFAEB20", Offset = "0xFAD920", VA = "0x10FAEB20")]
    public bool IsTargetUnitForGridMap(Unit unit, GridMap<bool> grid_map) => new bool();

    [Token(Token = "0x6002C82")]
    [Address(RVA = "0xF97460", Offset = "0xF96260", VA = "0x10F97460")]
    public Unit FindUnitAtGridIgnoreSide(Grid grid, EUnitSide ignoreSide) => (Unit) null;

    [Token(Token = "0x6002C83")]
    [Address(RVA = "0xF96EC0", Offset = "0xF95CC0", VA = "0x10F96EC0")]
    public Unit FindGimmickAtGrid(int x, int y, bool is_valid_disable = false) => (Unit) null;

    [Token(Token = "0x6002C84")]
    [Address(RVA = "0xF96F00", Offset = "0xF95D00", VA = "0x10F96F00")]
    public Unit FindGimmickAtGrid(Grid grid, bool is_valid_disable = false, Unit ignore_unit = null)
    {
      return (Unit) null;
    }

    [Token(Token = "0x6002C85")]
    [Address(RVA = "0xF80E80", Offset = "0xF7FC80", VA = "0x10F80E80")]
    public bool CommandWait(EUnitDirection dir) => new bool();

    [Token(Token = "0x6002C86")]
    [Address(RVA = "0xF80DC0", Offset = "0xF7FBC0", VA = "0x10F80DC0")]
    public bool CommandWait(bool is_skip_event = false) => new bool();

    [Token(Token = "0x6002C87")]
    [Address(RVA = "0xFA83A0", Offset = "0xFA71A0", VA = "0x10FA83A0")]
    private void InternalLogUnitEnd()
    {
    }

    [Token(Token = "0x6002C88")]
    [Address(RVA = "0xFBB120", Offset = "0xFB9F20", VA = "0x10FBB120")]
    public static EUnitDirection UnitDirectionFromVector(Unit self, int x, int y)
    {
      return new EUnitDirection();
    }

    [Token(Token = "0x6002C89")]
    [Address(RVA = "0xFB0BA0", Offset = "0xFAF9A0", VA = "0x10FB0BA0")]
    public bool Move(Unit self, Grid goal, bool forceAI = false) => new bool();

    [Token(Token = "0x6002C8A")]
    [Address(RVA = "0xF7F100", Offset = "0xF7DF00", VA = "0x10F7F100")]
    public bool CheckMove(Unit self, Grid goal) => new bool();

    [Token(Token = "0x6002C8B")]
    [Address(RVA = "0xFB0690", Offset = "0xFAF490", VA = "0x10FB0690")]
    public bool MoveMultiPlayer(Unit self, int x, int y, EUnitDirection direction) => new bool();

    [Token(Token = "0x6002C8C")]
    [Address(RVA = "0xFB0BC0", Offset = "0xFAF9C0", VA = "0x10FB0BC0")]
    public bool Move(
      Unit self,
      Grid goal,
      EUnitDirection direction,
      bool isStickControl = false,
      bool forceAI = false)
    {
      return new bool();
    }

    [Token(Token = "0x6002C8D")]
    [Address(RVA = "0xFB04A0", Offset = "0xFAF2A0", VA = "0x10FB04A0")]
    private void MoveEnd(Unit self, int step, bool isMultiPlayer = false)
    {
    }

    [Token(Token = "0x6002C8E")]
    [Address(RVA = "0xFAF590", Offset = "0xFAE390", VA = "0x10FAF590")]
    public void MapCommandEnd(Unit self)
    {
    }

    [Token(Token = "0x6002C8F")]
    [Address(RVA = "0xFB9970", Offset = "0xFB8770", VA = "0x10FB9970")]
    public static int Sqrt(int v) => new int();

    [Token(Token = "0x6002C90")]
    [Address(RVA = "0xFB99B0", Offset = "0xFB87B0", VA = "0x10FB99B0")]
    public static long Sqrt(long v) => new long();

    [Token(Token = "0x6002C91")]
    [Address(RVA = "0xFB9430", Offset = "0xFB8230", VA = "0x10FB9430")]
    public static int Sin(int v) => new int();

    [Token(Token = "0x6002C92")]
    [Address(RVA = "0xF72790", Offset = "0xF71590", VA = "0x10F72790")]
    public static int Atan(int x) => new int();

    [Token(Token = "0x6002C93")]
    [Address(RVA = "0xFB3B60", Offset = "0xFB2960", VA = "0x10FB3B60")]
    public static int Pow(int val, int n) => new int();

    [Token(Token = "0x6002C94")]
    [Address(RVA = "0xFA3760", Offset = "0xFA2560", VA = "0x10FA3760")]
    public void GetSkillGridLines(
      Unit self,
      int ex,
      int ey,
      SkillData skill,
      ref List<Grid> results)
    {
    }

    [Token(Token = "0x6002C95")]
    [Address(RVA = "0xFA2790", Offset = "0xFA1590", VA = "0x10FA2790")]
    public void GetSkillGridLines(
      int sx,
      int sy,
      int ex,
      int ey,
      int range_min,
      int range_max,
      int attack_height,
      ELineType line_type,
      bool bHeightBonus,
      ref List<Grid> results)
    {
    }

    [Token(Token = "0x6002C96")]
    [Address(RVA = "0xF9BC90", Offset = "0xF9AA90", VA = "0x10F9BC90")]
    private int GetCriticalRate(Unit self, Unit target, SkillData skill) => new int();

    [Token(Token = "0x6002C97")]
    [Address(RVA = "0xF7CBA0", Offset = "0xF7B9A0", VA = "0x10F7CBA0")]
    private bool CheckCritical(Unit self, Unit target, SkillData skill) => new bool();

    [Token(Token = "0x6002C98")]
    [Address(RVA = "0xF9BB40", Offset = "0xF9A940", VA = "0x10F9BB40")]
    public int GetCriticalDamage(Unit self, int damage, uint rand) => new int();

    [Token(Token = "0x6002C99")]
    [Address(RVA = "0xF99540", Offset = "0xF98340", VA = "0x10F99540")]
    private int GetAvoidRate(Unit self, Unit target, SkillData skill) => new int();

    [Token(Token = "0x6002C9A")]
    [Address(RVA = "0xF7C610", Offset = "0xF7B410", VA = "0x10F7C610")]
    private bool CheckAvoid(Unit self, Unit target, SkillData skill) => new bool();

    [Token(Token = "0x6002C9B")]
    [Address(RVA = "0xF7DC80", Offset = "0xF7CA80", VA = "0x10F7DC80")]
    private bool CheckGuts(Unit self) => new bool();

    [Token(Token = "0x6002C9C")]
    [Address(RVA = "0xFA21E0", Offset = "0xFA0FE0", VA = "0x10FA21E0")]
    private int GetSkillEffectValue(Unit self, Unit target, SkillData skill, LogSkill log = null)
    {
      return new int();
    }

    [Token(Token = "0x6002C9D")]
    [Address(RVA = "0xF804F0", Offset = "0xF7F2F0", VA = "0x10F804F0")]
    private bool CheckWeakPoint(Unit self, Unit target, SkillData skill) => new bool();

    [Token(Token = "0x6002C9E")]
    [Address(RVA = "0xF78450", Offset = "0xF77250", VA = "0x10F78450")]
    private int CalcHeal(Unit self, Unit target, SkillData skill, LogSkill log) => new int();

    [Token(Token = "0x6002C9F")]
    [Address(RVA = "0xFA7AB0", Offset = "0xFA68B0", VA = "0x10FA7AB0")]
    private void Heal(Unit target, int value)
    {
    }

    [Token(Token = "0x6002CA0")]
    [Address(RVA = "0xF77E00", Offset = "0xF76C00", VA = "0x10F77E00")]
    private int CalcGainedGems(
      Unit self,
      Unit target,
      SkillData skill,
      int damage,
      bool bCritical,
      bool bWeakPoint)
    {
      return new int();
    }

    [Token(Token = "0x6002CA1")]
    [Address(RVA = "0xF87440", Offset = "0xF86240", VA = "0x10F87440")]
    private void DamageCureCondition(Unit target, LogSkill log = null)
    {
    }

    [Token(Token = "0x6002CA2")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void HealCureCondition(Unit target, LogSkill log = null)
    {
    }

    [Token(Token = "0x6002CA3")]
    [Address(RVA = "0xFA4D20", Offset = "0xFA3B20", VA = "0x10FA4D20")]
    private Unit GetSubMemberFirst(int owner = -1) => (Unit) null;

    [Token(Token = "0x6002CA4")]
    [Address(RVA = "0xFB5850", Offset = "0xFB4650", VA = "0x10FB5850")]
    public void ResumeDead(Unit target)
    {
    }

    [Token(Token = "0x6002CA5")]
    [Address(RVA = "0xF888C0", Offset = "0xF876C0", VA = "0x10F888C0")]
    private void Dead(Unit self, Unit target, DeadTypes type, LogSkill logSkill = null, bool is_resume = false)
    {
    }

    [Token(Token = "0x6002CA6")]
    [Address(RVA = "0xFB5870", Offset = "0xFB4670", VA = "0x10FB5870")]
    private void Revive(Unit target, int hp)
    {
    }

    [Token(Token = "0x6002CA7")]
    [Address(RVA = "0xF90780", Offset = "0xF8F580", VA = "0x10F90780")]
    private void EntryUnit(Unit self)
    {
    }

    [Token(Token = "0x6002CA8")]
    [Address(RVA = "0xF86E90", Offset = "0xF85C90", VA = "0x10F86E90")]
    private void CureCondition(
      Unit target,
      EUnitCondition condition,
      LogSkill logskl,
      bool is_damage = false)
    {
    }

    [Token(Token = "0x6002CA9")]
    [Address(RVA = "0xF969E0", Offset = "0xF957E0", VA = "0x10F969E0")]
    private void FailCondition(
      Unit self,
      Unit target,
      SkillData skill,
      SkillEffectTargets skilltarget,
      CondEffectParam param,
      ConditionEffectTypes type,
      ESkillCondition cond,
      EUnitCondition condition,
      EffectCheckTargets chk_target,
      EffectCheckTimings chk_timing,
      int turn,
      bool is_passive,
      bool is_curse,
      LogSkill logskl,
      bool is_same_ow)
    {
    }

    [Token(Token = "0x6002CAA")]
    [Address(RVA = "0xF73C80", Offset = "0xF72A80", VA = "0x10F73C80")]
    private void BuffSkill(
      ESkillTiming timing,
      Unit self,
      Unit target,
      SkillData skill,
      bool is_passive = false,
      LogSkill log = null,
      SkillEffectTargets buff_target = SkillEffectTargets.Target,
      bool is_duplicate = false,
      BuffEffect[] add_buff_effects = null,
      List<Unit> dsse_target_lists = null)
    {
    }

    [Token(Token = "0x6002CAB")]
    [Address(RVA = "0xFABA90", Offset = "0xFAA890", VA = "0x10FABA90")]
    public bool IsBuffDisableAndResist(Unit eff_target, BuffEffect buff_effect) => new bool();

    [Token(Token = "0x6002CAC")]
    [Address(RVA = "0xFABCC0", Offset = "0xFAAAC0", VA = "0x10FABCC0")]
    public bool IsDebuffDisableAndResist(Unit eff_target, BuffEffect buff_effect) => new bool();

    [Token(Token = "0x6002CAD")]
    [Address(RVA = "0xFA18D0", Offset = "0xFA06D0", VA = "0x10FA18D0")]
    private void GetResistStatus(Unit eff_target, ref int[] statuses, int[] st_to_bb_tbl)
    {
    }

    [Token(Token = "0x6002CAE")]
    [Address(RVA = "0xFA1810", Offset = "0xFA0610", VA = "0x10FA1810")]
    public void GetResistStatusBuff(Unit eff_target, ref int[] status_buffs)
    {
    }

    [Token(Token = "0x6002CAF")]
    [Address(RVA = "0xFA1870", Offset = "0xFA0670", VA = "0x10FA1870")]
    public void GetResistStatusDebuff(Unit eff_target, ref int[] status_debuffs)
    {
    }

    [Token(Token = "0x6002CB0")]
    [Address(RVA = "0xFB6390", Offset = "0xFB5190", VA = "0x10FB6390")]
    public static void SetBuffBits(BaseStatus status, ref BuffBit buff, ref BuffBit debuff)
    {
    }

    [Token(Token = "0x6002CB1")]
    [Address(RVA = "0xF829D0", Offset = "0xF817D0", VA = "0x10F829D0")]
    public BuffAttachment CreateBuffAttachment(
      Unit user,
      Unit target,
      SkillData skill,
      SkillEffectTargets skilltarget,
      BuffEffect buff_effect,
      BuffTypes buffType,
      bool is_negative_value_is_buff,
      SkillParamCalcTypes calcType,
      BaseStatus status,
      ESkillCondition cond,
      int turn,
      EffectCheckTargets chktgt,
      EffectCheckTimings timing,
      bool is_passive,
      int dupli)
    {
      return (BuffAttachment) null;
    }

    [Token(Token = "0x6002CB2")]
    [Address(RVA = "0xF81270", Offset = "0xF80070", VA = "0x10F81270")]
    private void CondSkill(
      ESkillTiming timing,
      Unit self,
      Unit target,
      SkillData skill,
      bool is_passive = false,
      LogSkill log = null,
      SkillEffectTargets cond_target = SkillEffectTargets.Target,
      bool is_same_ow = false,
      List<Unit> dsse_target_lists = null)
    {
    }

    [Token(Token = "0x6002CB3")]
    [Address(RVA = "0xF80EE0", Offset = "0xF7FCE0", VA = "0x10F80EE0")]
    private void CondSkillSetRateLog(
      ESkillTiming timing,
      Unit self,
      Unit target,
      SkillData skill,
      LogSkill log)
    {
    }

    [Token(Token = "0x6002CB4")]
    [Address(RVA = "0xF82C70", Offset = "0xF81A70", VA = "0x10F82C70")]
    public CondAttachment CreateCondAttachment(
      Unit user,
      Unit target,
      SkillData skill,
      SkillEffectTargets skilltarget,
      CondEffectParam param,
      ConditionEffectTypes type,
      ESkillCondition cond,
      EUnitCondition condition,
      EffectCheckTargets chktgt,
      EffectCheckTimings timing,
      int turn,
      bool is_passive,
      bool is_curse,
      int damage = 0,
      int cost_jewel = 0,
      int heal_count = 0,
      int mp_damage = 0,
      int jewel_max = 0)
    {
      return (CondAttachment) null;
    }

    [Token(Token = "0x6002CB5")]
    [Address(RVA = "0xF7D5F0", Offset = "0xF7C3F0", VA = "0x10F7D5F0")]
    private bool CheckFailCondition(Unit target, int val, int resist, EUnitCondition condition)
    {
      return new bool();
    }

    [Token(Token = "0x6002CB6")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void EndMoveSkill(Unit self, int step)
    {
    }

    [Token(Token = "0x6002CB7")]
    [Address(RVA = "0xF7D370", Offset = "0xF7C170", VA = "0x10F7D370")]
    private bool CheckEnableUseSkill(Unit self, SkillData skill, bool bCheckCondOnly = false)
    {
      return new bool();
    }

    [Token(Token = "0x6002CB8")]
    [Address(RVA = "0xF7D4B0", Offset = "0xF7C2B0", VA = "0x10F7D4B0")]
    public bool CheckEnemySide(Unit self, Unit target) => new bool();

    [Token(Token = "0x6002CB9")]
    [Address(RVA = "0xF7D890", Offset = "0xF7C690", VA = "0x10F7D890")]
    public bool CheckGimmickEnemySide(Unit self, Unit target) => new bool();

    [Token(Token = "0x6002CBA")]
    [Address(RVA = "0xF7FC90", Offset = "0xF7EA90", VA = "0x10F7FC90")]
    public bool CheckSkillTarget(Unit self, Unit target, SkillData skill) => new bool();

    [Token(Token = "0x6002CBB")]
    [Address(RVA = "0xF994A0", Offset = "0xF982A0", VA = "0x10F994A0")]
    public int GetAttackRangeBonus(int selfHeight, int targetHeight) => new int();

    [Token(Token = "0x6002CBC")]
    [Address(RVA = "0xF86260", Offset = "0xF85060", VA = "0x10F86260")]
    public GridMap<bool> CreateSelectGridMap(Unit self, int targetX, int targetY, SkillData skill)
    {
      return (GridMap<bool>) null;
    }

    [Token(Token = "0x6002CBD")]
    [Address(RVA = "0xF857B0", Offset = "0xF845B0", VA = "0x10F857B0")]
    public GridMap<bool> CreateSelectGridMap(
      Unit self,
      int targetX,
      int targetY,
      SkillData skill,
      ref GridMap<bool> result,
      bool keeped = false)
    {
      return (GridMap<bool>) null;
    }

    [Token(Token = "0x6002CBE")]
    [Address(RVA = "0xF85880", Offset = "0xF84680", VA = "0x10F85880")]
    private GridMap<bool> CreateSelectGridMap(
      Unit self,
      int targetX,
      int targetY,
      int range_min,
      int range_max,
      ESelectType rangetype,
      ELineType linetype,
      int scope,
      bool bCheckGridLine,
      bool bHeightBonus,
      int attack_height,
      bool bSelfEffect,
      ref GridMap<bool> result,
      bool keeped = false)
    {
      return (GridMap<bool>) null;
    }

    [Token(Token = "0x6002CBF")]
    [Address(RVA = "0xF7DB40", Offset = "0xF7C940", VA = "0x10F7DB40")]
    private bool CheckGridOnLine(
      int x1,
      int y1,
      int x2,
      int y2,
      int sx,
      int sy,
      int tx,
      int ty)
    {
      return new bool();
    }

    [Token(Token = "0x6002CC0")]
    [Address(RVA = "0xF9F0B0", Offset = "0xF9DEB0", VA = "0x10F9F0B0")]
    private void GetGridOnLine(Grid start, Grid target, ref List<Grid> results)
    {
    }

    [Token(Token = "0x6002CC1")]
    [Address(RVA = "0xF9F0E0", Offset = "0xF9DEE0", VA = "0x10F9F0E0")]
    private void GetGridOnLine(Grid start, int tx, int ty, ref List<Grid> results)
    {
    }

    [Token(Token = "0x6002CC2")]
    [Address(RVA = "0xF84D30", Offset = "0xF83B30", VA = "0x10F84D30")]
    public GridMap<bool> CreateScopeGridMap(
      Unit self,
      int selfX,
      int selfY,
      int targetX,
      int targetY,
      SkillData skill)
    {
      return (GridMap<bool>) null;
    }

    [Token(Token = "0x6002CC3")]
    [Address(RVA = "0xF84C80", Offset = "0xF83A80", VA = "0x10F84C80")]
    public GridMap<bool> CreateScopeGridMap(
      Unit self,
      int selfX,
      int selfY,
      int targetX,
      int targetY,
      SkillData skill,
      ref GridMap<bool> result,
      bool keeped = false)
    {
      return (GridMap<bool>) null;
    }

    [Token(Token = "0x6002CC4")]
    [Address(RVA = "0xF855A0", Offset = "0xF843A0", VA = "0x10F855A0")]
    public GridMap<bool> CreateScopeGridMap(
      int gx,
      int gy,
      ESelectType shape,
      int scope,
      int height)
    {
      return (GridMap<bool>) null;
    }

    [Token(Token = "0x6002CC5")]
    [Address(RVA = "0xF84E60", Offset = "0xF83C60", VA = "0x10F84E60")]
    public GridMap<bool> CreateScopeGridMap(
      Unit self,
      int selfX,
      int selfY,
      int targetX,
      int targetY,
      int range_min,
      int range_max,
      int scope,
      int enable_height,
      ESelectType scopetype,
      ref GridMap<bool> result,
      bool keeped,
      eTeleportType teleport_type)
    {
      return (GridMap<bool>) null;
    }

    [Token(Token = "0x6002CC6")]
    [Address(RVA = "0xF83440", Offset = "0xF82240", VA = "0x10F83440")]
    public void CreateGridMapCross(
      Grid target,
      int range_min,
      int range_max,
      ref GridMap<bool> result)
    {
    }

    [Token(Token = "0x6002CC7")]
    [Address(RVA = "0xF83530", Offset = "0xF82330", VA = "0x10F83530")]
    private void CreateGridMapDiamond(
      Grid target,
      int range_min,
      int range_max,
      ref GridMap<bool> result)
    {
    }

    [Token(Token = "0x6002CC8")]
    [Address(RVA = "0xF84370", Offset = "0xF83170", VA = "0x10F84370")]
    private void CreateGridMapSquare(
      Grid target,
      int range_min,
      int range_max,
      ref GridMap<bool> result)
    {
    }

    [Token(Token = "0x6002CC9")]
    [Address(RVA = "0xF84140", Offset = "0xF82F40", VA = "0x10F84140")]
    private void CreateGridMapLaser(
      Grid self,
      Grid target,
      int range_min,
      int range_max,
      int scope,
      ref GridMap<bool> result)
    {
    }

    [Token(Token = "0x6002CCA")]
    [Address(RVA = "0xFC6440", Offset = "0xFC5240", VA = "0x10FC6440")]
    private EUnitDirection unitDirectionFromPos(int src_gx, int src_gy, int dst_gx, int dst_gy)
    {
      return new EUnitDirection();
    }

    [Token(Token = "0x6002CCB")]
    [Address(RVA = "0xFBB070", Offset = "0xFB9E70", VA = "0x10FBB070")]
    public EUnitDirection UnitDirectionFromGrid(Grid self, Grid target) => new EUnitDirection();

    [Token(Token = "0x6002CCC")]
    [Address(RVA = "0xFBAFB0", Offset = "0xFB9DB0", VA = "0x10FBAFB0")]
    public EUnitDirection UnitDirectionFromGridLaserTwin(Grid self, Grid target)
    {
      return new EUnitDirection();
    }

    [Token(Token = "0x6002CCD")]
    [Address(RVA = "0xF847D0", Offset = "0xF835D0", VA = "0x10F847D0")]
    private void CreateGridMapWall(
      Grid self,
      Grid target,
      int range_min,
      int range_max,
      ref GridMap<bool> result)
    {
    }

    [Token(Token = "0x6002CCE")]
    [Address(RVA = "0xF84620", Offset = "0xF83420", VA = "0x10F84620")]
    private void CreateGridMapWallPlus(
      Grid self,
      Grid target,
      int range_min,
      int range_max,
      ref GridMap<bool> result)
    {
    }

    [Token(Token = "0x6002CCF")]
    [Address(RVA = "0xF83300", Offset = "0xF82100", VA = "0x10F83300")]
    private void CreateGridMapBishop(
      Grid target,
      int range_min,
      int range_max,
      ref GridMap<bool> result)
    {
    }

    [Token(Token = "0x6002CD0")]
    [Address(RVA = "0xF84480", Offset = "0xF83280", VA = "0x10F84480")]
    private void CreateGridMapVictory(
      Grid self,
      Grid target,
      int range_min,
      int range_max,
      ref GridMap<bool> result)
    {
    }

    [Token(Token = "0x6002CD1")]
    [Address(RVA = "0xF837C0", Offset = "0xF825C0", VA = "0x10F837C0")]
    private void CreateGridMapLaserSpread(
      Grid self,
      Grid target,
      int range_min,
      int range_max,
      ref GridMap<bool> result,
      bool is_chk_clear = true)
    {
    }

    [Token(Token = "0x6002CD2")]
    [Address(RVA = "0xF83F30", Offset = "0xF82D30", VA = "0x10F83F30")]
    private void CreateGridMapLaserWide(
      Grid self,
      Grid target,
      int range_min,
      int range_max,
      ref GridMap<bool> result,
      bool is_chk_clear = true)
    {
    }

    [Token(Token = "0x6002CD3")]
    [Address(RVA = "0xF83640", Offset = "0xF82440", VA = "0x10F83640")]
    private void CreateGridMapHorse(
      Grid target,
      int range_min,
      int range_max,
      ref GridMap<bool> result)
    {
    }

    [Token(Token = "0x6002CD4")]
    [Address(RVA = "0xF83D40", Offset = "0xF82B40", VA = "0x10F83D40")]
    private void CreateGridMapLaserTwin(
      Grid self,
      Grid target,
      int range_min,
      int range_max,
      ref GridMap<bool> result,
      bool is_chk_clear = true)
    {
    }

    [Token(Token = "0x6002CD5")]
    [Address(RVA = "0xF839D0", Offset = "0xF827D0", VA = "0x10F839D0")]
    private void CreateGridMapLaserTriple(
      Grid self,
      Grid target,
      int range_min,
      int range_max,
      ref GridMap<bool> result,
      bool is_chk_clear = true)
    {
    }

    [Token(Token = "0x6002CD6")]
    [Address(RVA = "0xF7CC90", Offset = "0xF7BA90", VA = "0x10F7CC90")]
    private bool CheckEnableAttackHeight(Grid start, Grid goal, int diff_ok) => new bool();

    [Token(Token = "0x6002CD7")]
    [Address(RVA = "0xFB71F0", Offset = "0xFB5FF0", VA = "0x10FB71F0")]
    private void SetGridMap(ref GridMap<bool> gridmap, Grid start, Grid goal)
    {
    }

    [Token(Token = "0x6002CD8")]
    [Address(RVA = "0xF86300", Offset = "0xF85100", VA = "0x10F86300")]
    private GridMap<bool> CreateSkillRangeMapAll(Unit self, SkillData skill, bool is_move)
    {
      return (GridMap<bool>) null;
    }

    [Token(Token = "0x6002CD9")]
    [Address(RVA = "0xF86540", Offset = "0xF85340", VA = "0x10F86540")]
    private GridMap<bool> CreateSkillScopeMapAll(
      Unit self,
      SkillData skill,
      bool is_move,
      bool is_scope = false)
    {
      return (GridMap<bool>) null;
    }

    [Token(Token = "0x6002CDA")]
    [Address(RVA = "0xF82780", Offset = "0xF81580", VA = "0x10F82780")]
    public List<Unit> CreateAttackTargets(Unit self, SkillData skill, bool is_move)
    {
      return (List<Unit>) null;
    }

    [Token(Token = "0x6002CDB")]
    [Address(RVA = "0xFB5D10", Offset = "0xFB4B10", VA = "0x10FB5D10")]
    public List<Unit> SearchTargetsInGridMap(Unit self, SkillData skill, GridMap<bool> areamap)
    {
      return (List<Unit>) null;
    }

    [Token(Token = "0x6002CDC")]
    [Address(RVA = "0xFB59F0", Offset = "0xFB47F0", VA = "0x10FB59F0")]
    public List<Unit> SearchTargetsInGridMap(
      Unit self,
      SkillData skill,
      GridMap<bool> areamap,
      List<Unit> targets)
    {
      return (List<Unit>) null;
    }

    [Token(Token = "0x6002CDD")]
    [Address(RVA = "0xF9D130", Offset = "0xF9BF30", VA = "0x10F9D130")]
    private void GetExecuteSkillLineTarget(
      Unit self,
      int target_x,
      int target_y,
      SkillData skill,
      ref List<Unit> targets,
      ref BattleCore.ShotTarget shot)
    {
    }

    [Token(Token = "0x6002CDE")]
    [Address(RVA = "0xF99BD0", Offset = "0xF989D0", VA = "0x10F99BD0")]
    public IntVector2 GetBigUnitOffsetPos(Unit unit, int idx) => new IntVector2();

    [Token(Token = "0x6002CDF")]
    [Address(RVA = "0xFA6020", Offset = "0xFA4E20", VA = "0x10FA6020")]
    public IntVector2 GetValidGridForSkillRange(
      Unit unit,
      int sx,
      int sy,
      SkillData skill,
      int gx,
      int gy)
    {
      return new IntVector2();
    }

    [Token(Token = "0x6002CE0")]
    [Address(RVA = "0xF99CD0", Offset = "0xF98AD0", VA = "0x10F99CD0")]
    public BattleCore.CommandResult GetCommandResult(
      Unit self,
      int x,
      int y,
      int tx,
      int ty,
      SkillData skill,
      bool isProtect = false)
    {
      return (BattleCore.CommandResult) null;
    }

    [Token(Token = "0x6002CE1")]
    [Address(RVA = "0xFC1530", Offset = "0xFC0330", VA = "0x10FC1530")]
    public bool UseSkill(
      Unit self,
      int gx,
      int gy,
      SkillData skill,
      bool bUnitLockTarget = false,
      int ux = 0,
      int uy = 0,
      bool is_call_auto_skill = false)
    {
      return new bool();
    }

    [Token(Token = "0x6002CE2")]
    [Address(RVA = "0xF90610", Offset = "0xF8F410", VA = "0x10F90610")]
    private void EndUseSkill(SkillData _skill)
    {
    }

    [Token(Token = "0x6002CE3")]
    [Address(RVA = "0xFB9660", Offset = "0xFB8460", VA = "0x10FB9660")]
    private void SkillUseJewelAndDecCount(Unit self, SkillData skill, int cost, bool is_use_after)
    {
    }

    [Token(Token = "0x6002CE4")]
    [Address(RVA = "0xF93020", Offset = "0xF91E20", VA = "0x10F93020")]
    private void ExecuteSkill(ESkillTiming timing, LogSkill log, SkillData skill)
    {
    }

    [Token(Token = "0x6002CE5")]
    [Address(RVA = "0xFB7840", Offset = "0xFB6640", VA = "0x10FB7840")]
    private void SetJumpCancelLog(
      Unit jump_unit,
      ref List<Unit> req_gimmick_unit_lists,
      bool IsPlayDamageMotionReset = false,
      bool IsPlayIdolMotionLoop = false)
    {
    }

    [Token(Token = "0x6002CE6")]
    [Address(RVA = "0xFAF2C0", Offset = "0xFAE0C0", VA = "0x10FAF2C0")]
    private void JudgeInspSkill(Unit self, List<UnitData> ud_targets, SkillData skill)
    {
    }

    [Token(Token = "0x6002CE7")]
    [Address(RVA = "0xF7B840", Offset = "0xF7A640", VA = "0x10F7B840")]
    private void CastStart(Unit self, int gx, int gy, SkillData skill, bool bUnitLockTarget)
    {
    }

    [Token(Token = "0x6002CE8")]
    [Address(RVA = "0xFABC10", Offset = "0xFAAA10", VA = "0x10FABC10")]
    private bool IsCombinationAttack(SkillData skill) => new bool();

    [Token(Token = "0x6002CE9")]
    [Address(RVA = "0xFA6250", Offset = "0xFA5050", VA = "0x10FA6250")]
    private void GetYuragiDamage(ref int damage)
    {
    }

    [Token(Token = "0x6002CEA")]
    [Address(RVA = "0xF714B0", Offset = "0xF702B0", VA = "0x10F714B0")]
    public void AddProtect(LogSkill log, SkillData skill)
    {
    }

    [Token(Token = "0x6002CEB")]
    [Address(RVA = "0xFB58D0", Offset = "0xFB46D0", VA = "0x10FB58D0")]
    private bool SameUnitListUniqueName(List<Unit> src, List<Unit> dest) => new bool();

    [Token(Token = "0x6002CEC")]
    [Address(RVA = "0xFA7B30", Offset = "0xFA6930", VA = "0x10FA7B30")]
    private void InitProtect()
    {
    }

    [Token(Token = "0x6002CED")]
    [Address(RVA = "0xF7BAD0", Offset = "0xF7A8D0", VA = "0x10F7BAD0")]
    public void ChangeProtectTarget(ref List<Unit> targets, SkillData skill)
    {
    }

    [Token(Token = "0x6002CEE")]
    [Address(RVA = "0xFA0320", Offset = "0xF9F120", VA = "0x10FA0320")]
    public Unit GetProtectTarget(Unit target, SkillData skill) => (Unit) null;

    [Token(Token = "0x6002CEF")]
    [Address(RVA = "0xF7A100", Offset = "0xF78F00", VA = "0x10F7A100")]
    private void CalcProtectDamage(SkillData skill, LogSkill log)
    {
    }

    [Token(Token = "0x6002CF0")]
    [Address(RVA = "0xFB7BF0", Offset = "0xFB69F0", VA = "0x10FB7BF0")]
    private void SetProtectPassiveSkill(Unit target)
    {
    }

    [Token(Token = "0x6002CF1")]
    [Address(RVA = "0xF7FA20", Offset = "0xF7E820", VA = "0x10F7FA20")]
    private bool CheckSkillCondition(Unit self, SkillData skill) => new bool();

    [Token(Token = "0x6002CF2")]
    [Address(RVA = "0xF87540", Offset = "0xF86340", VA = "0x10F87540")]
    private void DamageSkill(
      Unit self,
      Unit target,
      SkillData skill,
      LogSkill log,
      bool is_last_hit)
    {
    }

    [Token(Token = "0x6002CF3")]
    [Address(RVA = "0xFB2780", Offset = "0xFB1580", VA = "0x10FB2780")]
    private void NotifyDamagedActionStart(Unit attacker, Unit defender)
    {
    }

    [Token(Token = "0x6002CF4")]
    [Address(RVA = "0xF9FB60", Offset = "0xF9E960", VA = "0x10F9FB60")]
    private int GetHpCost(Unit self, SkillData skill) => new int();

    [Token(Token = "0x6002CF5")]
    [Address(RVA = "0xF898E0", Offset = "0xF886E0", VA = "0x10F898E0")]
    private void DefendSkill(Unit attacker, Unit defender, SkillData atkskl, LogSkill log)
    {
    }

    [Token(Token = "0x6002CF6")]
    [Address(RVA = "0xF7F280", Offset = "0xF7E080", VA = "0x10F7F280")]
    private bool CheckPerfectAvoidSkill(
      Unit attacker,
      Unit defender,
      SkillData atkskl,
      LogSkill log)
    {
      return new bool();
    }

    [Token(Token = "0x6002CF7")]
    [Address(RVA = "0xF86F90", Offset = "0xF85D90", VA = "0x10F86F90")]
    private void DamageControlSkill(
      Unit attacker,
      Unit defender,
      SkillData atkskl,
      ref int damage,
      LogSkill log)
    {
    }

    [Token(Token = "0x6002CF8")]
    [Address(RVA = "0xFA15B0", Offset = "0xFA03B0", VA = "0x10FA15B0")]
    private int GetResistDamageForMhmDamage(
      Unit attacker,
      Unit defender,
      SkillData skill,
      int damage)
    {
      return new int();
    }

    [Token(Token = "0x6002CF9")]
    [Address(RVA = "0xFA7940", Offset = "0xFA6740", VA = "0x10FA7940")]
    private void HealSkill(Unit self, Unit target, SkillData skill, LogSkill log)
    {
    }

    [Token(Token = "0x6002CFA")]
    [Address(RVA = "0xF91E30", Offset = "0xF90C30", VA = "0x10F91E30")]
    private void ExecuteHeal(Unit self, Unit target, int heal, int gems, LogSkill log)
    {
    }

    [Token(Token = "0x6002CFB")]
    [Address(RVA = "0xF72820", Offset = "0xF71620", VA = "0x10F72820")]
    private void AutoHealSkill(Unit self)
    {
    }

    [Token(Token = "0x6002CFC")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void StealSkill(Unit self, Unit target, SkillData skill, LogSkill log)
    {
    }

    [Token(Token = "0x6002CFD")]
    [Address(RVA = "0xFB9390", Offset = "0xFB8190", VA = "0x10FB9390")]
    private void ShieldSkill(Unit target, SkillData skill)
    {
    }

    [Token(Token = "0x6002CFE")]
    [Address(RVA = "0xFAE200", Offset = "0xFAD000", VA = "0x10FAE200")]
    private bool IsObstReaction(Unit attacker, Unit defender, SkillData skill) => new bool();

    [Token(Token = "0x6002CFF")]
    [Address(RVA = "0xF91BF0", Offset = "0xF909F0", VA = "0x10F91BF0")]
    private void ExecuteFirstReactionSkill(
      Unit attacker,
      List<Unit> targets,
      SkillData skill,
      int tx,
      int ty,
      List<LogSkill> results = null)
    {
    }

    [Token(Token = "0x6002D00")]
    [Address(RVA = "0xF92200", Offset = "0xF91000", VA = "0x10F92200")]
    private void ExecuteReactionSkill(LogSkill log, List<LogSkill> results = null)
    {
    }

    [Token(Token = "0x6002D01")]
    [Address(RVA = "0xFA8440", Offset = "0xFA7240", VA = "0x10FA8440")]
    private void InternalReactionSkill(
      ESkillTiming timing,
      Unit attacker,
      Unit defender,
      Unit main_target,
      SkillData received_skill,
      int damage,
      bool is_forced,
      List<LogSkill> results,
      bool is_main_target,
      int px,
      int py)
    {
    }

    [Token(Token = "0x6002D02")]
    [Address(RVA = "0xFAE460", Offset = "0xFAD260", VA = "0x10FAE460")]
    private bool IsReactionCondition(
      SkillData _skill,
      Unit _attacker,
      Unit _defender,
      int _px,
      int _py,
      SkillData _received_skill)
    {
      return new bool();
    }

    [Token(Token = "0x6002D03")]
    [Address(RVA = "0xF88700", Offset = "0xF87500", VA = "0x10F88700")]
    private bool DeadSkill(Unit self, Unit target) => new bool();

    [Token(Token = "0x6002D04")]
    [Address(RVA = "0xFC0F40", Offset = "0xFBFD40", VA = "0x10FC0F40")]
    public bool UseItem(Unit self, int gx, int gy, ItemData item) => new bool();

    [Token(Token = "0x6002D05")]
    [Address(RVA = "0xF81DD0", Offset = "0xF80BD0", VA = "0x10F81DD0")]
    public List<Unit> ContinueStart(long btlid, int seed) => (List<Unit>) null;

    [Token(Token = "0x6002D06")]
    [Address(RVA = "0xF90AC0", Offset = "0xF8F8C0", VA = "0x10F90AC0")]
    private bool EventTriggerWithdrawContinue(Unit unit) => new bool();

    [Token(Token = "0x6002D07")]
    [Address(RVA = "0xFAF6A0", Offset = "0xFAE4A0", VA = "0x10FAF6A0")]
    public void MapStart()
    {
    }

    [Token(Token = "0x6002D08")]
    [Address(RVA = "0xFBBF00", Offset = "0xFBAD00", VA = "0x10FBBF00")]
    private void UpdateCancelCastSkill()
    {
    }

    [Token(Token = "0x6002D09")]
    [Address(RVA = "0xFBFDF0", Offset = "0xFBEBF0", VA = "0x10FBFDF0")]
    private void UpdateUnitCondition(Unit self)
    {
    }

    [Token(Token = "0x6002D0A")]
    [Address(RVA = "0xFA8C60", Offset = "0xFA7A60", VA = "0x10FA8C60")]
    private void InvokeSkillBuffCond(Unit unit, SkillData skill, ESkillTiming timing)
    {
    }

    [Token(Token = "0x6002D0B")]
    [Address(RVA = "0xFBFE70", Offset = "0xFBEC70", VA = "0x10FBFE70")]
    private void UpdateUnitDyingTurn()
    {
    }

    [Token(Token = "0x6002D0C")]
    [Address(RVA = "0xFC0150", Offset = "0xFBEF50", VA = "0x10FC0150")]
    private void UpdateUnitJudgeHPTurn()
    {
    }

    [Token(Token = "0x6002D0D")]
    [Address(RVA = "0xFBB820", Offset = "0xFBA620", VA = "0x10FBB820")]
    public bool UnitStart() => new bool();

    [Token(Token = "0x6002D0E")]
    [Address(RVA = "0xFBB7C0", Offset = "0xFBA5C0", VA = "0x10FBB7C0")]
    public IEnumerator UnitStartAsync() => (IEnumerator) null;

    [Token(Token = "0x6002D0F")]
    [Address(RVA = "0xFBF840", Offset = "0xFBE640", VA = "0x10FBF840")]
    private void UpdateSkillUseCondition()
    {
    }

    [Token(Token = "0x6002D10")]
    [Address(RVA = "0xFBBB00", Offset = "0xFBA900", VA = "0x10FBBB00")]
    private void UpdateAIActionUseCondition(Unit self)
    {
    }

    [Token(Token = "0x6002D11")]
    [Address(RVA = "0xFBFAF0", Offset = "0xFBE8F0", VA = "0x10FBFAF0")]
    private void UpdateSkillUseCondition(
      Unit unit,
      SkillLockCondition condition,
      int p_count,
      int e_count)
    {
    }

    [Token(Token = "0x6002D12")]
    [Address(RVA = "0xF70F30", Offset = "0xF6FD30", VA = "0x10F70F30")]
    private void ActuatedSneaking(Unit unit)
    {
    }

    [Token(Token = "0x6002D13")]
    [Address(RVA = "0xFB2EB0", Offset = "0xFB1CB0", VA = "0x10FB2EB0")]
    public void NotifyMapCommand()
    {
    }

    [Token(Token = "0x6002D14")]
    [Address(RVA = "0xF81C50", Offset = "0xF80A50", VA = "0x10F81C50")]
    public bool ConditionalUnitEnd(bool ignoreMoveAndAction) => new bool();

    [Token(Token = "0x6002D15")]
    [Address(RVA = "0xF874B0", Offset = "0xF862B0", VA = "0x10F874B0")]
    private void DamageReflectMission(Unit target, int damage)
    {
    }

    [Token(Token = "0x6002D16")]
    [Address(RVA = "0xFBB1C0", Offset = "0xFB9FC0", VA = "0x10FBB1C0")]
    public void UnitEnd()
    {
    }

    [Token(Token = "0x6002D17")]
    [Address(RVA = "0xF7B760", Offset = "0xF7A560", VA = "0x10F7B760")]
    public void CastSkillStart()
    {
    }

    [Token(Token = "0x6002D18")]
    [Address(RVA = "0xF7B730", Offset = "0xF7A530", VA = "0x10F7B730")]
    public void CastSkillEnd()
    {
    }

    [Token(Token = "0x6002D19")]
    [Address(RVA = "0xFAF5D0", Offset = "0xFAE3D0", VA = "0x10FAF5D0")]
    private void MapEnd(bool is_delay = false)
    {
    }

    [Token(Token = "0x6002D1A")]
    [Address(RVA = "0xFA7AE0", Offset = "0xFA68E0", VA = "0x10FA7AE0")]
    public void IncrementMap()
    {
    }

    [Token(Token = "0x6002D1B")]
    [Address(RVA = "0xF781B0", Offset = "0xF76FB0", VA = "0x10F781B0")]
    public int CalcGridDistance(Grid start, Grid goal) => new int();

    [Token(Token = "0x6002D1C")]
    [Address(RVA = "0xF78230", Offset = "0xF77030", VA = "0x10F78230")]
    public int CalcGridDistance(Unit self, Unit target) => new int();

    [Token(Token = "0x6002D1D")]
    [Address(RVA = "0xF78320", Offset = "0xF77120", VA = "0x10F78320")]
    public int CalcGridHeight(Unit self, Unit target) => new int();

    [Token(Token = "0x6002D1E")]
    [Address(RVA = "0xF97150", Offset = "0xF95F50", VA = "0x10F97150")]
    private int FindNearGridAndDistance(
      Unit self,
      Unit target,
      out Grid self_grid,
      out Grid target_grid)
    {
      return new int();
    }

    [Token(Token = "0x6002D1F")]
    [Address(RVA = "0xF78FC0", Offset = "0xF77DC0", VA = "0x10F78FC0")]
    public int CalcNearGridDistance(Unit self, Unit target) => new int();

    [Token(Token = "0x6002D20")]
    [Address(RVA = "0xF79000", Offset = "0xF77E00", VA = "0x10F79000")]
    public int CalcNearGridDistance(Unit self, Grid target) => new int();

    [Token(Token = "0x6002D21")]
    [Address(RVA = "0xFA5600", Offset = "0xFA4400", VA = "0x10FA5600")]
    public int GetUnitMaxAttackHeight(Unit self, SkillData skill) => new int();

    [Token(Token = "0x6002D22")]
    [Address(RVA = "0xFBD340", Offset = "0xFBC140", VA = "0x10FBD340")]
    private void UpdateHelperUnits(Unit self)
    {
    }

    [Token(Token = "0x6002D23")]
    [Address(RVA = "0xF7CB20", Offset = "0xF7B920", VA = "0x10F7CB20")]
    private bool CheckCombination(Unit self, Unit other) => new bool();

    [Token(Token = "0x6002D24")]
    [Address(RVA = "0xF7DAA0", Offset = "0xF7C8A0", VA = "0x10F7DAA0")]
    public bool CheckGridEventTrigger(Unit self, Grid grid, EEventTrigger trigger) => new bool();

    [Token(Token = "0x6002D25")]
    [Address(RVA = "0xF7D9B0", Offset = "0xF7C7B0", VA = "0x10F7D9B0")]
    public bool CheckGridEventTrigger(Unit self, EEventTrigger trigger) => new bool();

    [Token(Token = "0x6002D26")]
    [Address(RVA = "0xF91AA0", Offset = "0xF908A0", VA = "0x10F91AA0")]
    public bool ExecuteEventTriggerOnGrid(Unit self, EEventTrigger trigger) => new bool();

    [Token(Token = "0x6002D27")]
    [Address(RVA = "0xFA6EC0", Offset = "0xFA5CC0", VA = "0x10FA6EC0")]
    private bool GridEventStart(
      Unit self,
      Unit target,
      EEventTrigger type,
      SkillParam skill_param = null)
    {
      return new bool();
    }

    [Token(Token = "0x6002D28")]
    [Address(RVA = "0xF80540", Offset = "0xF7F340", VA = "0x10F80540")]
    private void CheckWithDrawUnit(Unit target)
    {
    }

    [Token(Token = "0x6002D29")]
    [Address(RVA = "0xF993E0", Offset = "0xF981E0", VA = "0x10F993E0")]
    private EUnitDirection GetAttackDirection(
      EUnitDirection sdir,
      int sx,
      int sy,
      int tx,
      int ty)
    {
      return new EUnitDirection();
    }

    [Token(Token = "0x6002D2A")]
    [Address(RVA = "0xFA4E60", Offset = "0xFA3C60", VA = "0x10FA4E60")]
    private EUnitTargetDirection GetTargetDirection(Unit _self, Unit _target)
    {
      return new EUnitTargetDirection();
    }

    [Token(Token = "0x6002D2B")]
    [Address(RVA = "0xFA4EA0", Offset = "0xFA3CA0", VA = "0x10FA4EA0")]
    private EUnitTargetDirection GetTargetDirection(int _sx, int _sy, Unit _target)
    {
      return new EUnitTargetDirection();
    }

    [Token(Token = "0x6002D2C")]
    [Address(RVA = "0xF7C6B0", Offset = "0xF7B4B0", VA = "0x10F7C6B0")]
    private bool CheckBackAttack(Unit self, Unit target, SkillData skill) => new bool();

    [Token(Token = "0x6002D2D")]
    [Address(RVA = "0xF7C840", Offset = "0xF7B640", VA = "0x10F7C840")]
    private bool CheckBackAttack(int sx, int sy, Unit target, SkillData skill) => new bool();

    [Token(Token = "0x6002D2E")]
    [Address(RVA = "0xF7F730", Offset = "0xF7E530", VA = "0x10F7F730")]
    private bool CheckSideAttack(Unit self, Unit target, SkillData skill) => new bool();

    [Token(Token = "0x6002D2F")]
    [Address(RVA = "0xF7F8C0", Offset = "0xF7E6C0", VA = "0x10F7F8C0")]
    private bool CheckSideAttack(int sx, int sy, Unit target, SkillData skill) => new bool();

    [Token(Token = "0x6002D30")]
    [Address(RVA = "0xF7CC30", Offset = "0xF7BA30", VA = "0x10F7CC30")]
    public bool CheckDisableAbilities(Unit self) => new bool();

    [Token(Token = "0x6002D31")]
    [Address(RVA = "0xF7CC60", Offset = "0xF7BA60", VA = "0x10F7CC60")]
    public bool CheckDisableItems(Unit self) => new bool();

    [Token(Token = "0x6002D32")]
    [Address(RVA = "0xF9B700", Offset = "0xF9A500", VA = "0x10F9B700")]
    public Grid GetCorrectDuplicatePosition(Unit self, List<Unit> exceptUnits = null)
    {
      return (Grid) null;
    }

    [Token(Token = "0x17000284")]
    public bool EntryBattleMultiPlayTimeUp
    {
      [Token(Token = "0x6002D33"), Address(RVA = "0x66A590", Offset = "0x669390", VA = "0x1066A590")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002D34"), Address(RVA = "0xFC6170", Offset = "0xFC4F70", VA = "0x10FC6170")] set
      {
      }
    }

    [Token(Token = "0x17000285")]
    public bool MultSendUnitEnd
    {
      [Token(Token = "0x6002D35"), Address(RVA = "0x66A580", Offset = "0x669380", VA = "0x1066A580")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002D36"), Address(RVA = "0xFC6300", Offset = "0xFC5100", VA = "0x10FC6300")] set
      {
      }
    }

    [Token(Token = "0x17000286")]
    public bool MultiPlayDisconnectAutoBattle
    {
      [Token(Token = "0x6002D37"), Address(RVA = "0xFC5390", Offset = "0xFC4190", VA = "0x10FC5390")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002D38"), Address(RVA = "0xFC6340", Offset = "0xFC5140", VA = "0x10FC6340")] set
      {
      }
    }

    [Token(Token = "0x6002D39")]
    [Address(RVA = "0xF906C0", Offset = "0xF8F4C0", VA = "0x10F906C0")]
    public bool EntryBattleMultiPlay(
      EBattleCommand type,
      Unit current,
      Unit enemy,
      SkillData skill,
      ItemData item,
      int gx,
      int gy,
      bool unitLockTarget)
    {
      return new bool();
    }

    [Token(Token = "0x6002D3A")]
    [Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0")]
    public bool CheckSkillScopeMultiPlay(Unit self, Unit target, int gx, int gy, SkillData skill)
    {
      return new bool();
    }

    [Token(Token = "0x6002D3B")]
    [Address(RVA = "0xF906C0", Offset = "0xF8F4C0", VA = "0x10F906C0")]
    private bool ExecMultiPlayerCommandCore(
      EBattleCommand type,
      Unit current,
      Unit enemy,
      SkillData skill,
      ItemData item,
      int gx,
      int gy,
      bool unitLockTarget)
    {
      return new bool();
    }

    [Token(Token = "0x6002D3C")]
    [Address(RVA = "0xF7D280", Offset = "0xF7C080", VA = "0x10F7D280")]
    public bool CheckEnableSuspendSave() => new bool();

    [Token(Token = "0x6002D3D")]
    [Address(RVA = "0xF7D2C0", Offset = "0xF7C0C0", VA = "0x10F7D2C0")]
    public bool CheckEnableSuspendStart() => new bool();

    [Token(Token = "0x6002D3E")]
    [Address(RVA = "0xFB5520", Offset = "0xFB4320", VA = "0x10FB5520")]
    public static void RemoveSuspendData()
    {
    }

    [Token(Token = "0x6002D3F")]
    [Address(RVA = "0xFB59E0", Offset = "0xFB47E0", VA = "0x10FB59E0")]
    public bool SaveSuspendData() => new bool();

    [Token(Token = "0x6002D40")]
    [Address(RVA = "0xFAF420", Offset = "0xFAE220", VA = "0x10FAF420")]
    public bool LoadSuspendData() => new bool();

    [Token(Token = "0x6002D41")]
    [Address(RVA = "0x374A90", Offset = "0x373890", VA = "0x10374A90")]
    public void SetBattleID(long btlid)
    {
    }

    [Token(Token = "0x17000287")]
    public bool IsArenaSkip
    {
      [Token(Token = "0x6002D42"), Address(RVA = "0xFC4D10", Offset = "0xFC3B10", VA = "0x10FC4D10")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002D43"), Address(RVA = "0xFC61B0", Offset = "0xFC4FB0", VA = "0x10FC61B0")] set
      {
      }
    }

    [Token(Token = "0x17000288")]
    public uint ArenaActionCount
    {
      [Token(Token = "0x6002D44"), Address(RVA = "0x349500", Offset = "0x348300", VA = "0x10349500")] get
      {
        return new uint();
      }
    }

    [Token(Token = "0x17000289")]
    public int ArenaEnemyActionCount
    {
      [Token(Token = "0x6002D45"), Address(RVA = "0x349590", Offset = "0x348390", VA = "0x10349590")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6002D46")]
    [Address(RVA = "0xF726F0", Offset = "0xF714F0", VA = "0x10F726F0")]
    private uint ArenaSubActionCount(uint count = 1) => new uint();

    [Token(Token = "0x6002D47")]
    [Address(RVA = "0xF710A0", Offset = "0xF6FEA0", VA = "0x10F710A0")]
    private int AddArenaEnemyActionCount(int add = 1) => new int();

    [Token(Token = "0x6002D48")]
    [Address(RVA = "0xF72570", Offset = "0xF71370", VA = "0x10F72570")]
    public void ArenaKeepQuestData(
      string quest_id,
      BattleCore.Json_Battle json_btl,
      int max_action_num)
    {
    }

    [Token(Token = "0x6002D49")]
    [Address(RVA = "0xF725B0", Offset = "0xF713B0", VA = "0x10F725B0")]
    public bool ArenaResetQuestData() => new bool();

    [Token(Token = "0x1700028A")]
    public bool IsArenaCalc
    {
      [Token(Token = "0x6002D4A"), Address(RVA = "0xFC4D00", Offset = "0xFC3B00", VA = "0x10FC4D00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700028B")]
    public BattleCore.QuestResult ArenaCalcResult
    {
      [Token(Token = "0x6002D4B"), Address(RVA = "0xA22140", Offset = "0xA20F40", VA = "0x10A22140")] get
      {
        return new BattleCore.QuestResult();
      }
    }

    [Token(Token = "0x6002D4C")]
    [Address(RVA = "0xF72160", Offset = "0xF70F60", VA = "0x10F72160")]
    public void ArenaCalcStart()
    {
    }

    [Token(Token = "0x6002D4D")]
    [Address(RVA = "0xF72120", Offset = "0xF70F20", VA = "0x10F72120")]
    public void ArenaCalcSkipStart()
    {
    }

    [Token(Token = "0x6002D4E")]
    [Address(RVA = "0xF72110", Offset = "0xF70F10", VA = "0x10F72110")]
    public void ArenaCalcFinish()
    {
    }

    [Token(Token = "0x6002D4F")]
    [Address(RVA = "0xFC58E0", Offset = "0xFC46E0", VA = "0x10FC58E0")]
    private void judgeStartTypeArenaCalc()
    {
    }

    [Token(Token = "0x6002D50")]
    [Address(RVA = "0xF72720", Offset = "0xF71520", VA = "0x10F72720")]
    private bool ArenaUnitCalcJudge() => new bool();

    [Token(Token = "0x6002D51")]
    [Address(RVA = "0xF72190", Offset = "0xF70F90", VA = "0x10F72190")]
    public bool ArenaCalcStep() => new bool();

    [Token(Token = "0x1700028C")]
    public uint VersusTurnMax
    {
      [Token(Token = "0x6002D52"), Address(RVA = "0x349230", Offset = "0x348030", VA = "0x10349230")] get
      {
        return new uint();
      }
      [Token(Token = "0x6002D53"), Address(RVA = "0xFC6420", Offset = "0xFC5220", VA = "0x10FC6420")] set
      {
      }
    }

    [Token(Token = "0x1700028D")]
    public uint VersusTurnCount
    {
      [Token(Token = "0x6002D54"), Address(RVA = "0x349220", Offset = "0x348020", VA = "0x10349220")] get
      {
        return new uint();
      }
      [Token(Token = "0x6002D55"), Address(RVA = "0xFC6360", Offset = "0xFC5160", VA = "0x10FC6360")] set
      {
      }
    }

    [Token(Token = "0x1700028E")]
    public uint VersusOnceAgainTurnCount
    {
      [Token(Token = "0x6002D56"), Address(RVA = "0xFC5560", Offset = "0xFC4360", VA = "0x10FC5560")] get
      {
        return new uint();
      }
      [Token(Token = "0x6002D57"), Address(RVA = "0xFC6400", Offset = "0xFC5200", VA = "0x10FC6400")] set
      {
      }
    }

    [Token(Token = "0x1700028F")]
    public uint RemainVersusTurnCount
    {
      [Token(Token = "0x6002D58"), Address(RVA = "0xFC5450", Offset = "0xFC4250", VA = "0x10FC5450")] get
      {
        return new uint();
      }
      [Token(Token = "0x6002D59"), Address(RVA = "0xFC6360", Offset = "0xFC5160", VA = "0x10FC6360")] set
      {
      }
    }

    [Token(Token = "0x6002D5A")]
    [Address(RVA = "0xFA5630", Offset = "0xFA4430", VA = "0x10FA5630")]
    public Unit GetUnitUseCollaboSkill(Unit unit, SkillData skill) => (Unit) null;

    [Token(Token = "0x6002D5B")]
    [Address(RVA = "0xFAF100", Offset = "0xFADF00", VA = "0x10FAF100")]
    public bool IsUseSkillCollabo(Unit unit, SkillData skill) => new bool();

    [Token(Token = "0x6002D5C")]
    [Address(RVA = "0xF9C200", Offset = "0xF9B000", VA = "0x10F9C200")]
    public int GetDeadCountEnemy(EUnitSide side = EUnitSide.Player) => new int();

    [Token(Token = "0x6002D5D")]
    [Address(RVA = "0xFB5530", Offset = "0xFB4330", VA = "0x10FB5530")]
    public void RemoveUnitsByUnitFlag(EUnitFlag unit_flag)
    {
    }

    [Token(Token = "0x6002D5E")]
    [Address(RVA = "0xFC5570", Offset = "0xFC4370", VA = "0x10FC5570")]
    private bool isKnockBack(SkillData skill) => new bool();

    [Token(Token = "0x6002D5F")]
    [Address(RVA = "0xFC4220", Offset = "0xFC3020", VA = "0x10FC4220")]
    private bool checkKnockBack(Unit self, Unit target, SkillData skill) => new bool();

    [Token(Token = "0x6002D60")]
    [Address(RVA = "0xFC4350", Offset = "0xFC3150", VA = "0x10FC4350")]
    private Grid getGridKnockBack(
      Unit unit_att,
      Unit unit_def,
      SkillData skill,
      int gx,
      int gy,
      int kb_val = 0,
      int kb_dir = -1)
    {
      return (Grid) null;
    }

    [Token(Token = "0x6002D61")]
    [Address(RVA = "0xF9ECF0", Offset = "0xF9DAF0", VA = "0x10F9ECF0")]
    public Grid GetGridKnockBack(
      Unit target,
      EUnitDirection dir,
      int kb_val,
      SkillData skill = null,
      int gx = 0,
      int gy = 0)
    {
      return (Grid) null;
    }

    [Token(Token = "0x6002D62")]
    [Address(RVA = "0xFC5920", Offset = "0xFC4720", VA = "0x10FC5920")]
    private void procKnockBack(
      Unit self,
      SkillData skill,
      int gx,
      int gy,
      List<LogSkill.Target> ls_target_lists,
      List<LogSkill.Target> sk_target_lists)
    {
    }

    [Token(Token = "0x6002D63")]
    [Address(RVA = "0xFA50A0", Offset = "0xFA3EA0", VA = "0x10FA50A0")]
    public Grid GetTeleportGrid(
      Unit self,
      int gx,
      int gy,
      Unit target,
      SkillData skill,
      ref bool is_teleport)
    {
      return (Grid) null;
    }

    [Token(Token = "0x6002D64")]
    [Address(RVA = "0xFAE900", Offset = "0xFAD700", VA = "0x10FAE900")]
    public bool IsTargetBreakUnit(Unit self, Unit target, SkillData skill = null) => new bool();

    [Token(Token = "0x6002D65")]
    [Address(RVA = "0xF73A20", Offset = "0xF72820", VA = "0x10F73A20")]
    public Unit BreakObjCreate(
      string bo_id,
      int gx,
      int gy,
      Unit self = null,
      LogSkill log = null,
      int owner_index = 0)
    {
      return (Unit) null;
    }

    [Token(Token = "0x6002D66")]
    [Address(RVA = "0xF7C9A0", Offset = "0xF7B7A0", VA = "0x10F7C9A0")]
    private void CheckBreakObjKill()
    {
    }

    [Token(Token = "0x6002D67")]
    [Address(RVA = "0xFA90B0", Offset = "0xFA7EB0", VA = "0x10FA90B0")]
    public bool IsAllowBreakObjEntryMax() => new bool();

    [Token(Token = "0x6002D68")]
    [Address(RVA = "0xFBA300", Offset = "0xFB9100", VA = "0x10FBA300")]
    public void TrickCreateForSkill(Unit self, int gx, int gy, SkillData skill)
    {
    }

    [Token(Token = "0x6002D69")]
    [Address(RVA = "0xFAEE10", Offset = "0xFADC10", VA = "0x10FAEE10")]
    private bool IsTrickExistUnit(int gx, int gy) => new bool();

    [Token(Token = "0x6002D6A")]
    [Address(RVA = "0xFB9D20", Offset = "0xFB8B20", VA = "0x10FB9D20")]
    public void TrickActionEndEffect(Unit self, bool is_update_buff = true, bool is_reinforcement = false)
    {
    }

    [Token(Token = "0x6002D6B")]
    [Address(RVA = "0xFBA900", Offset = "0xFB9700", VA = "0x10FBA900")]
    public void UnitChange(Unit self, int gx, int gy, EUnitDirection dir, Unit target)
    {
    }

    [Token(Token = "0x6002D6C")]
    [Address(RVA = "0xFBA850", Offset = "0xFB9650", VA = "0x10FBA850")]
    public void UnitChangeReturn()
    {
    }

    [Token(Token = "0x6002D6D")]
    [Address(RVA = "0xFB5DA0", Offset = "0xFB4BA0", VA = "0x10FB5DA0")]
    public Unit SearchTransformUnit(Unit self) => (Unit) null;

    [Token(Token = "0x6002D6E")]
    [Address(RVA = "0xFB5DF0", Offset = "0xFB4BF0", VA = "0x10FB5DF0")]
    public static Unit SearchTransformUnit(List<Unit> units, Unit targetUnit) => (Unit) null;

    [Token(Token = "0x6002D6F")]
    [Address(RVA = "0xF90360", Offset = "0xF8F160", VA = "0x10F90360")]
    private Unit DtuTransformForSkill(Unit from_unit, SkillData skill) => (Unit) null;

    [Token(Token = "0x6002D70")]
    [Address(RVA = "0xF8F8D0", Offset = "0xF8E6D0", VA = "0x10F8F8D0")]
    public Unit DtuCreateUnit(Unit from_unit, string dtu_id) => (Unit) null;

    [Token(Token = "0x6002D71")]
    [Address(RVA = "0xF8FF00", Offset = "0xF8ED00", VA = "0x10F8FF00")]
    private Unit DtuFindCreatedUnit(Unit from_unit, DynamicTransformUnitParam dtu_param)
    {
      return (Unit) null;
    }

    [Token(Token = "0x6002D72")]
    [Address(RVA = "0xF8F330", Offset = "0xF8E130", VA = "0x10F8F330")]
    private void DtuAttachLeaderFriendSkill(Unit unit)
    {
    }

    [Token(Token = "0x6002D73")]
    [Address(RVA = "0xF8E680", Offset = "0xF8D480", VA = "0x10F8E680")]
    public void DtuActivateUnit(Unit from_unit, Unit new_unit, bool is_cancel = false, bool is_suspend = false)
    {
    }

    [Token(Token = "0x6002D74")]
    [Address(RVA = "0xFABE50", Offset = "0xFAAC50", VA = "0x10FABE50")]
    private bool IsDtuCheckLeaderFriendSkill(SkillData skill) => new bool();

    [Token(Token = "0x6002D75")]
    [Address(RVA = "0xF903E0", Offset = "0xF8F1E0", VA = "0x10F903E0")]
    private bool DtuUpdateTurn(Unit self) => new bool();

    [Token(Token = "0x6002D76")]
    [Address(RVA = "0xF8F860", Offset = "0xF8E660", VA = "0x10F8F860")]
    private Unit DtuCancelTransform(Unit from_unit) => (Unit) null;

    [Token(Token = "0x6002D77")]
    [Address(RVA = "0xF8F7C0", Offset = "0xF8E5C0", VA = "0x10F8F7C0")]
    private Unit DtuCancelTransformReset(Unit from_unit) => (Unit) null;

    [Token(Token = "0x6002D78")]
    [Address(RVA = "0xF8FCC0", Offset = "0xF8EAC0", VA = "0x10F8FCC0")]
    public Unit DtuDead(Unit unit) => (Unit) null;

    [Token(Token = "0x6002D79")]
    [Address(RVA = "0xF90270", Offset = "0xF8F070", VA = "0x10F90270")]
    public void DtuReturn()
    {
    }

    [Token(Token = "0x6002D7A")]
    [Address(RVA = "0xF90020", Offset = "0xF8EE20", VA = "0x10F90020")]
    public Unit DtuFindOrgUnit(Unit unit) => (Unit) null;

    [Token(Token = "0x6002D7B")]
    [Address(RVA = "0xF8FDD0", Offset = "0xF8EBD0", VA = "0x10F8FDD0")]
    public Unit DtuFindActUnit(Unit unit) => (Unit) null;

    [Token(Token = "0x6002D7C")]
    [Address(RVA = "0xF90070", Offset = "0xF8EE70", VA = "0x10F90070")]
    public bool DtuGetHpMpRate(Unit unit, ref int hp, ref int mp) => new bool();

    [Token(Token = "0x6002D7D")]
    [Address(RVA = "0xFBB900", Offset = "0xFBA700", VA = "0x10FBB900")]
    public void UnitWithdraw(Unit self)
    {
    }

    [Token(Token = "0x6002D7E")]
    [Address(RVA = "0xFA7E60", Offset = "0xFA6C60", VA = "0x10FA7E60")]
    private void InitWeather()
    {
    }

    [Token(Token = "0x6002D7F")]
    [Address(RVA = "0xFC0AC0", Offset = "0xFBF8C0", VA = "0x10FC0AC0")]
    private bool UpdateWeather() => new bool();

    [Token(Token = "0x6002D80")]
    [Address(RVA = "0xF7BFC0", Offset = "0xF7ADC0", VA = "0x10F7BFC0")]
    private bool ChangeWeatherForSkill(Unit self, SkillData skill) => new bool();

    [Token(Token = "0x6002D81")]
    [Address(RVA = "0xF71810", Offset = "0xF70610", VA = "0x10F71810")]
    private void AddSkillExecLogForQuestMission(LogSkill log)
    {
    }

    [Token(Token = "0x6002D82")]
    [Address(RVA = "0xFBA620", Offset = "0xFB9420", VA = "0x10FBA620")]
    private bool TrySetBattleFinisher(Unit _unit) => new bool();

    [Token(Token = "0x6002D83")]
    [Address(RVA = "0xFA0CB0", Offset = "0xF9FAB0", VA = "0x10FA0CB0")]
    public RankingQuestParam GetRankingQuestParam() => (RankingQuestParam) null;

    [Token(Token = "0x6002D84")]
    [Address(RVA = "0xF79E60", Offset = "0xF78C60", VA = "0x10F79E60")]
    public int CalcPlayerUnitsTotalParameter() => new int();

    [Token(Token = "0x6002D85")]
    [Address(RVA = "0xFAE2E0", Offset = "0xFAD0E0", VA = "0x10FAE2E0")]
    public bool IsOrdealValidNext() => new bool();

    [Token(Token = "0x6002D86")]
    [Address(RVA = "0xFB2F40", Offset = "0xFB1D40", VA = "0x10FB2F40")]
    public void OrdealChangeNext()
    {
    }

    [Token(Token = "0x6002D87")]
    [Address(RVA = "0xFB3770", Offset = "0xFB2570", VA = "0x10FB3770")]
    public void OrdealRestore(int team_id)
    {
    }

    [Token(Token = "0x6002D88")]
    [Address(RVA = "0xF706A0", Offset = "0xF6F4A0", VA = "0x10F706A0")]
    private bool AbilityChange(Unit self, Unit target, SkillData skill) => new bool();

    [Token(Token = "0x17000290")]
    public bool IsEnableAag
    {
      [Token(Token = "0x6002D89"), Address(RVA = "0xFC4E00", Offset = "0xFC3C00", VA = "0x10FC4E00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6002D8A")]
    [Address(RVA = "0xF70E00", Offset = "0xF6FC00", VA = "0x10F70E00")]
    private void AbsorbAndGiveClear()
    {
    }

    [Token(Token = "0x6002D8B")]
    [Address(RVA = "0xF70C00", Offset = "0xF6FA00", VA = "0x10F70C00")]
    private void AbsorbAndGiveApply(Unit self, SkillData skill, LogSkill log)
    {
    }

    [Token(Token = "0x6002D8C")]
    [Address(RVA = "0xF707E0", Offset = "0xF6F5E0", VA = "0x10F707E0")]
    private void AbsorbAndGiveApplySetBuff(Unit self, Unit target, SkillData skill, LogSkill log = null)
    {
    }

    [Token(Token = "0x6002D8D")]
    [Address(RVA = "0xFBC020", Offset = "0xFBAE20", VA = "0x10FBC020")]
    private bool UpdateEntryByInfinitySpawn(List<Unit> units) => new bool();

    [Token(Token = "0x6002D8E")]
    [Address(RVA = "0xF848F0", Offset = "0xF836F0", VA = "0x10F848F0")]
    public Unit CreateInfinitySpawnUnit(
      string unit_name,
      int x,
      int y,
      int dir,
      int group,
      int deck_index,
      bool dont_add = false)
    {
      return (Unit) null;
    }

    [Token(Token = "0x6002D8F")]
    [Address(RVA = "0xF7D680", Offset = "0xF7C480", VA = "0x10F7D680")]
    private bool CheckForcedTargeting(Unit attacker, Unit defender, SkillData skill) => new bool();

    [Token(Token = "0x6002D90")]
    [Address(RVA = "0xF97750", Offset = "0xF96550", VA = "0x10F97750")]
    private void ForcedTargetingForSkill(
      Unit user,
      SkillData skill,
      LogSkill log,
      List<Unit> manipulate_unit_list)
    {
    }

    [Token(Token = "0x6002D91")]
    [Address(RVA = "0xF75440", Offset = "0xF74240", VA = "0x10F75440")]
    public void CacheClearForcedTargeting()
    {
    }

    [Token(Token = "0x6002D92")]
    [Address(RVA = "0xFAF170", Offset = "0xFADF70", VA = "0x10FAF170")]
    public bool IsValidForcedTargeting(Unit self, int sx, int sy, SkillData skill) => new bool();

    [Token(Token = "0x6002D93")]
    [Address(RVA = "0xFB3C00", Offset = "0xFB2A00", VA = "0x10FB3C00")]
    public bool ReflectForcedTargeting(
      Unit self,
      int sx,
      int sy,
      SkillData skill,
      ref List<Unit> targets)
    {
      return new bool();
    }

    [Token(Token = "0x6002D94")]
    [Address(RVA = "0xF90C00", Offset = "0xF8FA00", VA = "0x10F90C00")]
    private void ExecuteAdditionalSkill(LogSkill base_log, List<LogSkill> log_results = null)
    {
    }

    [Token(Token = "0x6002D95")]
    [Address(RVA = "0xF7C1E0", Offset = "0xF7AFE0", VA = "0x10F7C1E0")]
    private bool CheckAdditionalCondition(LogSkill base_log, SkillAdditionalParam sap)
    {
      return new bool();
    }

    [Token(Token = "0x6002D96")]
    [Address(RVA = "0xFAEEA0", Offset = "0xFADCA0", VA = "0x10FAEEA0")]
    private bool IsTrickSkillCondition(SkillData skill, IntVector2 pos, List<Unit> targets)
    {
      return new bool();
    }

    [Token(Token = "0x6002D97")]
    [Address(RVA = "0xFACFE0", Offset = "0xFABDE0", VA = "0x10FACFE0")]
    private bool IsIgnoreAntiShield(SkillData skill) => new bool();

    [Token(Token = "0x6002D98")]
    [Address(RVA = "0xFACF80", Offset = "0xFABD80", VA = "0x10FACF80")]
    private bool IsIgnoreAntiShield(Unit self, SkillData skill) => new bool();

    [Token(Token = "0x6002D99")]
    [Address(RVA = "0xFABDF0", Offset = "0xFAABF0", VA = "0x10FABDF0")]
    private bool IsDestroyAntiShield(SkillData skill) => new bool();

    [Token(Token = "0x6002D9A")]
    [Address(RVA = "0xF71C50", Offset = "0xF70A50", VA = "0x10F71C50")]
    private void AntiShieldSkill(Unit self, Unit target, SkillData skill, LogSkill log)
    {
    }

    [Token(Token = "0x6002D9B")]
    [Address(RVA = "0xFABB90", Offset = "0xFAA990", VA = "0x10FABB90")]
    public bool IsCanUseAutoSkill(Unit unit, SkillData skill) => new bool();

    [Token(Token = "0x6002D9C")]
    [Address(RVA = "0xFA49A0", Offset = "0xFA37A0", VA = "0x10FA49A0")]
    private SkillData GetSkillRevival(Unit unit) => (SkillData) null;

    [Token(Token = "0x6002D9D")]
    [Address(RVA = "0xFAE800", Offset = "0xFAD600", VA = "0x10FAE800")]
    private bool IsSkillRevivalCondition(Unit unit) => new bool();

    [Token(Token = "0x6002D9E")]
    [Address(RVA = "0xFB9550", Offset = "0xFB8350", VA = "0x10FB9550")]
    private void SkillRevivalExecute(SkillData revivalSkill, Unit target)
    {
    }

    [Token(Token = "0x6002D9F")]
    [Address(RVA = "0xFAF070", Offset = "0xFADE70", VA = "0x10FAF070")]
    private bool IsUnitHaveRevivalSkill(Unit target) => new bool();

    [Token(Token = "0x6002DA0")]
    [Address(RVA = "0xFC1120", Offset = "0xFBFF20", VA = "0x10FC1120")]
    private void UseRevivalSkill(Unit target, SkillData revivalSkill, SkillData skill)
    {
    }

    [Token(Token = "0x6002DA1")]
    [Address(RVA = "0xFBE9A0", Offset = "0xFBD7A0", VA = "0x10FBE9A0")]
    private bool UpdateSkillAutoHpJudge() => new bool();

    [Token(Token = "0x6002DA2")]
    [Address(RVA = "0xF86710", Offset = "0xF85510", VA = "0x10F86710")]
    private void CriticalHeal(Unit self, SkillData skill, int maxhit, LogSkill log)
    {
    }

    [Token(Token = "0x6002DA3")]
    [Address(RVA = "0xF779D0", Offset = "0xF767D0", VA = "0x10F779D0")]
    private int CalcCriticalHealValue(Unit self, SkillCriticalHealParam sch_param) => new int();

    [Token(Token = "0x6002DA4")]
    [Address(RVA = "0xF91380", Offset = "0xF90180", VA = "0x10F91380")]
    private bool ExecuteCondBomb(Unit self) => new bool();

    [Token(Token = "0x6002DA5")]
    [Address(RVA = "0xF913C0", Offset = "0xF901C0", VA = "0x10F913C0")]
    private bool ExecuteCondInternal(Unit self, EUnitCondition cond, bool isForce = false)
    {
      return new bool();
    }

    [Token(Token = "0x6002DA6")]
    [Address(RVA = "0xF80C90", Offset = "0xF7FA90", VA = "0x10F80C90")]
    private void ClearForceAlchemyTarget()
    {
    }

    [Token(Token = "0x6002DA7")]
    [Address(RVA = "0xFB67F0", Offset = "0xFB55F0", VA = "0x10FB67F0")]
    private void SetForceAlchemyTarget(
      LogSkill log,
      SkillData skill,
      List<Unit> manipulate_unit_list)
    {
    }

    [Token(Token = "0x6002DA8")]
    [Address(RVA = "0xF91D70", Offset = "0xF90B70", VA = "0x10F91D70")]
    private void ExecuteForceBomb()
    {
    }

    [Token(Token = "0x6002DA9")]
    [Address(RVA = "0xF91A80", Offset = "0xF90880", VA = "0x10F91A80")]
    private bool ExecuteCondSlip(Unit self) => new bool();

    [Token(Token = "0x6002DAA")]
    [Address(RVA = "0xF913A0", Offset = "0xF901A0", VA = "0x10F913A0")]
    private bool ExecuteCondDown(Unit self) => new bool();

    [Token(Token = "0x6002DAB")]
    [Address(RVA = "0xF7F560", Offset = "0xF7E360", VA = "0x10F7F560")]
    private void CheckReleaseCondDown(Unit unit, int gems = 0)
    {
    }

    [Token(Token = "0x6002DAC")]
    [Address(RVA = "0xFBECA0", Offset = "0xFBDAA0", VA = "0x10FBECA0")]
    private void UpdateSkillDuplicateReset(SkillData skill, Unit self)
    {
    }

    [Token(Token = "0x6002DAD")]
    [Address(RVA = "0xFB9D00", Offset = "0xFB8B00", VA = "0x10FB9D00")]
    private void SuccessfulReaction(SkillData skill, Unit unit)
    {
    }

    [Token(Token = "0x6002DAE")]
    [Address(RVA = "0xF80CF0", Offset = "0xF7FAF0", VA = "0x10F80CF0")]
    private void ClearSkillManipulateList()
    {
    }

    [Token(Token = "0x6002DAF")]
    [Address(RVA = "0xFB94D0", Offset = "0xFB82D0", VA = "0x10FB94D0")]
    private void SkillManipulate(Unit target, SkillData skill)
    {
    }

    [Token(Token = "0x6002DB0")]
    [Address(RVA = "0xFB82F0", Offset = "0xFB70F0", VA = "0x10FB82F0")]
    private void SetSkillManipulateBreakEffect(SkillData skill, Unit target)
    {
    }

    [Token(Token = "0x6002DB1")]
    [Address(RVA = "0xF91F80", Offset = "0xF90D80", VA = "0x10F91F80")]
    private void ExecuteManipulateBreak(SkillData skill, LogSkill log)
    {
    }

    [Token(Token = "0x6002DB2")]
    [Address(RVA = "0xF92030", Offset = "0xF90E30", VA = "0x10F92030")]
    private void ExecuteManipulateDamage(
      Unit self,
      List<Unit> targets,
      int damage,
      int dropgems,
      LogSkill log,
      LogDamageManipulate log_manipulate)
    {
    }

    [Token(Token = "0x6002DB3")]
    [Address(RVA = "0xF929F0", Offset = "0xF917F0", VA = "0x10F929F0")]
    private List<Unit> ExecuteSkillManipulate(LogSkill log) => (List<Unit>) null;

    [Token(Token = "0x6002DB4")]
    [Address(RVA = "0xF71AE0", Offset = "0xF708E0", VA = "0x10F71AE0")]
    private bool AddSkillManipulate(
      Unit self,
      Unit target,
      Unit.UnitManipulate unitManipulate,
      int damage,
      int dropgems,
      ManipulateTypes type,
      DamageTypes damageType,
      int elem,
      string effect,
      bool isBreak)
    {
      return new bool();
    }

    [Token(Token = "0x6002DB5")]
    [Address(RVA = "0xFAD190", Offset = "0xFABF90", VA = "0x10FAD190")]
    private bool IsManipulateTarget(Unit unit, List<Unit> target_list) => new bool();

    [Token(Token = "0x6002DB6")]
    [Address(RVA = "0xFBEF90", Offset = "0xFBDD90", VA = "0x10FBEF90")]
    private void UpdateSkillManipulate()
    {
    }

    [Token(Token = "0x6002DB7")]
    [Address(RVA = "0xF92650", Offset = "0xF91450", VA = "0x10F92650")]
    private void ExecuteSkillDistance(Unit self, LogSkill log, SkillData skill)
    {
    }

    [Token(Token = "0x6002DB8")]
    [Address(RVA = "0xF7B0D0", Offset = "0xF79ED0", VA = "0x10F7B0D0")]
    private int CalcSkillDistanceDamage(int damage, Unit self, Unit target, SkillData skill_data)
    {
      return new int();
    }

    [Token(Token = "0x6002DB9")]
    [Address(RVA = "0xFB6240", Offset = "0xFB5040", VA = "0x10FB6240")]
    public void SendBattleActionLog()
    {
    }

    [Token(Token = "0x17000291")]
    public GridMap<int> MoveMap
    {
      [Token(Token = "0x6002DBA"), Address(RVA = "0x4782D0", Offset = "0x4770D0", VA = "0x104782D0")] get
      {
        return (GridMap<int>) null;
      }
    }

    [Token(Token = "0x17000292")]
    public GridMap<bool> RangeMap
    {
      [Token(Token = "0x6002DBB"), Address(RVA = "0x4782E0", Offset = "0x4770E0", VA = "0x104782E0")] get
      {
        return (GridMap<bool>) null;
      }
    }

    [Token(Token = "0x17000293")]
    public GridMap<bool> ScopeMap
    {
      [Token(Token = "0x6002DBC"), Address(RVA = "0xA22130", Offset = "0xA20F30", VA = "0x10A22130")] get
      {
        return (GridMap<bool>) null;
      }
    }

    [Token(Token = "0x17000294")]
    public GridMap<bool> SearchMap
    {
      [Token(Token = "0x6002DBD"), Address(RVA = "0xFC5520", Offset = "0xFC4320", VA = "0x10FC5520")] get
      {
        return (GridMap<bool>) null;
      }
    }

    [Token(Token = "0x17000295")]
    public SkillMap SkillMap
    {
      [Token(Token = "0x6002DBE"), Address(RVA = "0x6287A0", Offset = "0x6275A0", VA = "0x106287A0")] get
      {
        return (SkillMap) null;
      }
    }

    [Token(Token = "0x17000296")]
    public TrickMap TrickMap
    {
      [Token(Token = "0x6002DBF"), Address(RVA = "0xFC5550", Offset = "0xFC4350", VA = "0x10FC5550")] get
      {
        return (TrickMap) null;
      }
    }

    [Token(Token = "0x6002DC0")]
    [Address(RVA = "0xF805A0", Offset = "0xF7F3A0", VA = "0x10F805A0")]
    private void ClearAI()
    {
    }

    [Token(Token = "0x6002DC1")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void ReleaseAi()
    {
    }

    [Token(Token = "0x6002DC2")]
    [Address(RVA = "0xFBDD40", Offset = "0xFBCB40", VA = "0x10FBDD40")]
    public bool UpdateMapAI(bool forceAI) => new bool();

    [Token(Token = "0x6002DC3")]
    [Address(RVA = "0xFBD520", Offset = "0xFBC320", VA = "0x10FBD520")]
    private bool UpdateMapAI_Impl(bool forceAI) => new bool();

    [Token(Token = "0x6002DC4")]
    [Address(RVA = "0xF84BC0", Offset = "0xF839C0", VA = "0x10F84BC0")]
    public GridMap<int> CreateMoveMap(Unit self, int movcount = 0) => (GridMap<int>) null;

    [Token(Token = "0x6002DC5")]
    [Address(RVA = "0xFBDD50", Offset = "0xFBCB50", VA = "0x10FBDD50")]
    private void UpdateMoveMap(Unit self, GridMap<int> movmap, int movcount)
    {
    }

    [Token(Token = "0x6002DC6")]
    [Address(RVA = "0xFBDF50", Offset = "0xFBCD50", VA = "0x10FBDF50")]
    private void UpdateMoveMap(Unit self)
    {
    }

    [Token(Token = "0x6002DC7")]
    [Address(RVA = "0xFBDF00", Offset = "0xFBCD00", VA = "0x10FBDF00")]
    private void UpdateMoveMap(Unit self, GridMap<int> movmap)
    {
    }

    [Token(Token = "0x6002DC8")]
    [Address(RVA = "0xFBDFC0", Offset = "0xFBCDC0", VA = "0x10FBDFC0")]
    private void UpdateSafeMap(Unit self)
    {
    }

    [Token(Token = "0x6002DC9")]
    [Address(RVA = "0xFA1990", Offset = "0xFA0790", VA = "0x10FA1990")]
    private Grid GetSafePositionAI(Unit self) => (Grid) null;

    [Token(Token = "0x6002DCA")]
    [Address(RVA = "0xFA1E70", Offset = "0xFA0C70", VA = "0x10FA1E70")]
    private bool GetSafePositionEx(
      Unit self,
      GridMap<bool> rangeMap,
      ref BattleCore.SVector2 result)
    {
      return new bool();
    }

    [Token(Token = "0x6002DCB")]
    [Address(RVA = "0xFA1D70", Offset = "0xFA0B70", VA = "0x10FA1D70")]
    private bool GetSafePositionEx(Unit self, List<Grid> move_targets, ref Grid result)
    {
      return new bool();
    }

    [Token(Token = "0x6002DCC")]
    [Address(RVA = "0xFA1F50", Offset = "0xFA0D50", VA = "0x10FA1F50")]
    private int GetSafeValue(Unit self, Grid target) => new int();

    [Token(Token = "0x6002DCD")]
    [Address(RVA = "0xFA7C00", Offset = "0xFA6A00", VA = "0x10FA7C00")]
    public void InitSkillMap(Unit self)
    {
    }

    [Token(Token = "0x6002DCE")]
    [Address(RVA = "0xFBF0C0", Offset = "0xFBDEC0", VA = "0x10FBF0C0")]
    private void UpdateSkillMap(Unit self, List<SkillData> skills)
    {
    }

    [Token(Token = "0x6002DCF")]
    [Address(RVA = "0xFB8F10", Offset = "0xFB7D10", VA = "0x10FB8F10")]
    private bool SetupSkillMapScore(Unit self, Grid goal, SkillData skill, SkillMap.Score score)
    {
      return new bool();
    }

    [Token(Token = "0x6002DD0")]
    [Address(RVA = "0xFA3860", Offset = "0xFA2660", VA = "0x10FA3860")]
    public BattleCore.SkillResult GetSkillResult(
      BattleCore.AiCache cache,
      Unit self,
      SkillData skill,
      SkillMap.Score score)
    {
      return (BattleCore.SkillResult) null;
    }

    [Token(Token = "0x6002DD1")]
    [Address(RVA = "0xFB9880", Offset = "0xFB8680", VA = "0x10FB9880")]
    public void SortSkillResult(Unit self, List<BattleCore.SkillResult> results)
    {
    }

    [Token(Token = "0x6002DD2")]
    [Address(RVA = "0xFB4540", Offset = "0xFB3340", VA = "0x10FB4540")]
    private void RefreshUseSkillMap(Unit self, bool is_add_act = false)
    {
    }

    [Token(Token = "0x6002DD3")]
    [Address(RVA = "0xF90830", Offset = "0xF8F630", VA = "0x10F90830")]
    private bool EntryUseSkill(Unit self, SkillData skill, bool forced, bool is_no_add_rate)
    {
      return new bool();
    }

    [Token(Token = "0x6002DD4")]
    [Address(RVA = "0xFB3B80", Offset = "0xFB2980", VA = "0x10FB3B80")]
    private void ReflectEnableInvalidSkill()
    {
    }

    [Token(Token = "0x6002DD5")]
    [Address(RVA = "0xF7FEE0", Offset = "0xF7ECE0", VA = "0x10F7FEE0")]
    private bool CheckUseSkill(Unit self, SkillData skill, bool is_no_add_rate) => new bool();

    [Token(Token = "0x6002DD6")]
    [Address(RVA = "0xFAF120", Offset = "0xFADF20", VA = "0x10FAF120")]
    private bool IsUseSkillForSkillParam(SkillParam skill_param) => new bool();

    [Token(Token = "0x6002DD7")]
    [Address(RVA = "0xFA91C0", Offset = "0xFA7FC0", VA = "0x10FA91C0")]
    private bool IsArenaUseSkillForSkillParam(SkillParam skill_param) => new bool();

    [Token(Token = "0x6002DD8")]
    [Address(RVA = "0xF7B330", Offset = "0xF7A130", VA = "0x10F7B330")]
    public bool CalcUseActionAI(
      Unit self,
      AIAction action,
      Func<List<BattleCore.SkillResult>, bool> useskill)
    {
      return new bool();
    }

    [Token(Token = "0x6002DD9")]
    [Address(RVA = "0xF7B590", Offset = "0xF7A390", VA = "0x10F7B590")]
    public bool CalcUseSkillsAI(
      Unit self,
      List<SkillData> skills,
      Func<List<BattleCore.SkillResult>, bool> useskill)
    {
      return new bool();
    }

    [Token(Token = "0x6002DDA")]
    [Address(RVA = "0xFC13B0", Offset = "0xFC01B0", VA = "0x10FC13B0")]
    private bool UseSkillAI(Unit self, BattleCore.SkillResult result, bool forceAI) => new bool();

    [Token(Token = "0x6002DDB")]
    [Address(RVA = "0xF7D760", Offset = "0xF7C560", VA = "0x10F7D760")]
    public bool CheckFriendlyFireOnGridMap(Unit self, Grid grid) => new bool();

    [Token(Token = "0x6002DDC")]
    [Address(RVA = "0xF7FA80", Offset = "0xF7E880", VA = "0x10F7FA80")]
    private bool CheckSkillTargetAI(Unit self, Unit target, SkillData skill) => new bool();

    [Token(Token = "0x6002DDD")]
    [Address(RVA = "0xFA5650", Offset = "0xFA4450", VA = "0x10FA5650")]
    private void GetUsedSkillResultAllEx(
      Unit self,
      SkillData skill,
      List<BattleCore.SkillResult> results)
    {
    }

    [Token(Token = "0x6002DDE")]
    [Address(RVA = "0xFA5B60", Offset = "0xFA4960", VA = "0x10FA5B60")]
    private void GetUsedTeleportSkillResult(
      Unit self,
      SkillData skill,
      List<BattleCore.SkillResult> results)
    {
    }

    [Token(Token = "0x6002DDF")]
    [Address(RVA = "0xF85680", Offset = "0xF84480", VA = "0x10F85680")]
    private GridMap<bool> CreateSelectGridMapAI(
      Unit self,
      int targetX,
      int targetY,
      SkillData skill)
    {
      return (GridMap<bool>) null;
    }

    [Token(Token = "0x6002DE0")]
    [Address(RVA = "0xFB5410", Offset = "0xFB4210", VA = "0x10FB5410")]
    private GridMap<bool> RemoveCantMove(Unit self, GridMap<bool> rangeMap, SkillData skill)
    {
      return (GridMap<bool>) null;
    }

    [Token(Token = "0x6002DE1")]
    [Address(RVA = "0xFA49F0", Offset = "0xFA37F0", VA = "0x10FA49F0")]
    private int GetSkillTargetsHighestPriority(Unit self, SkillData skill, LogSkill log)
    {
      return new int();
    }

    [Token(Token = "0x6002DE2")]
    [Address(RVA = "0xFA4C70", Offset = "0xFA3A70", VA = "0x10FA4C70")]
    private int GetSkillTargetsProtectPriority(Unit self, SkillData skill, LogSkill log)
    {
      return new int();
    }

    [Token(Token = "0x6002DE3")]
    [Address(RVA = "0xFA4BC0", Offset = "0xFA39C0", VA = "0x10FA4BC0")]
    private int GetSkillTargetsManipulatePriority(Unit self, SkillData skill, LogSkill log)
    {
      return new int();
    }

    [Token(Token = "0x6002DE4")]
    [Address(RVA = "0xFABFF0", Offset = "0xFAADF0", VA = "0x10FABFF0")]
    private bool IsEnableUseSkillEffect(Unit self, SkillData skill, LogSkill log) => new bool();

    [Token(Token = "0x6002DE5")]
    [Address(RVA = "0xFBFCB0", Offset = "0xFBEAB0", VA = "0x10FBFCB0")]
    private void UpdateTrickMap(Unit self)
    {
    }

    [Token(Token = "0x6002DE6")]
    [Address(RVA = "0xFACEA0", Offset = "0xFABCA0", VA = "0x10FACEA0")]
    private bool IsFailTrickData(Unit unit, int x, int y) => new bool();

    [Token(Token = "0x6002DE7")]
    [Address(RVA = "0xFACF10", Offset = "0xFABD10", VA = "0x10FACF10")]
    private bool IsGoodTrickData(Unit unit, int x, int y) => new bool();

    [Token(Token = "0x6002DE8")]
    [Address(RVA = "0xF9E860", Offset = "0xF9D660", VA = "0x10F9E860")]
    private int GetFailTrickPriority(Unit self, Grid movpos) => new int();

    [Token(Token = "0x6002DE9")]
    [Address(RVA = "0xF9EB80", Offset = "0xF9D980", VA = "0x10F9EB80")]
    private int GetGoodTrickPriority(Unit self, Grid movpos, ref int heal_trick) => new int();

    [Token(Token = "0x6002DEA")]
    [Address(RVA = "0xF78570", Offset = "0xF77370", VA = "0x10F78570")]
    private bool CalcMoveTargetAI(Unit self, bool forceAI) => new bool();

    [Token(Token = "0x6002DEB")]
    [Address(RVA = "0xF98D10", Offset = "0xF97B10", VA = "0x10F98D10")]
    private Grid[] GetAroundGrids(Unit unit, int gx, int gy) => (Grid[]) null;

    [Token(Token = "0x6002DEC")]
    [Address(RVA = "0xF9C680", Offset = "0xF9B480", VA = "0x10F9C680")]
    private List<Grid> GetEnableMoveGridList(
      Unit self,
      bool is_move = true,
      bool is_friendlyfire = true,
      bool is_sneaked = false,
      bool is_treasure = false,
      bool is_trickpanel = false)
    {
      return (List<Grid>) null;
    }

    [Token(Token = "0x6002DED")]
    [Address(RVA = "0xF7D550", Offset = "0xF7C350", VA = "0x10F7D550")]
    private bool CheckEscapeAI(Unit self) => new bool();

    [Token(Token = "0x6002DEE")]
    [Address(RVA = "0xF9CEA0", Offset = "0xF9BCA0", VA = "0x10F9CEA0")]
    private Grid GetEscapePositionAI(Unit self) => (Grid) null;

    [Token(Token = "0x6002DEF")]
    [Address(RVA = "0xF7ADD0", Offset = "0xF79BD0", VA = "0x10F7ADD0")]
    private bool CalcSearchingAI(Unit self) => new bool();

    [Token(Token = "0x6002DF0")]
    [Address(RVA = "0xFB6070", Offset = "0xFB4E70", VA = "0x10FB6070")]
    private bool Searching(Unit self) => new bool();

    [Token(Token = "0x6002DF1")]
    [Address(RVA = "0xFBE730", Offset = "0xFBD530", VA = "0x10FBE730")]
    private void UpdateSearchMap(Unit self)
    {
    }

    [Token(Token = "0x6002DF2")]
    [Address(RVA = "0xF7F5C0", Offset = "0xF7E3C0", VA = "0x10F7F5C0")]
    private bool CheckSearchMap(Unit self) => new bool();

    [Token(Token = "0x6002DF3")]
    [Address(RVA = "0xF7D3A0", Offset = "0xF7C1A0", VA = "0x10F7D3A0")]
    private bool CheckEnemyIntercept(Unit self) => new bool();

    [Token(Token = "0x6002DF4")]
    [Address(RVA = "0xF9C020", Offset = "0xF9AE20", VA = "0x10F9C020")]
    private int GetCurrentEnemyNum(Unit self) => new int();

    [Token(Token = "0x6002DF5")]
    [Address(RVA = "0xF9CB20", Offset = "0xF9B920", VA = "0x10F9CB20")]
    private void GetEnemyPriorities(Unit self, List<Unit> enemyTargets, List<Unit> gimmickTargets)
    {
    }

    [Token(Token = "0x6002DF6")]
    [Address(RVA = "0xFB9760", Offset = "0xFB8560", VA = "0x10FB9760")]
    private void SortAttackTargets(Unit unit, List<Unit> targets)
    {
    }

    [Token(Token = "0x6002DF7")]
    [Address(RVA = "0xF98C60", Offset = "0xF97A60", VA = "0x10F98C60")]
    private int GetAliveUnitCount(Unit self) => new int();

    [Token(Token = "0x6002DF8")]
    [Address(RVA = "0xF9C5D0", Offset = "0xF9B3D0", VA = "0x10F9C5D0")]
    private int GetDeadUnitCount(Unit self) => new int();

    [Token(Token = "0x6002DF9")]
    [Address(RVA = "0xF9E6D0", Offset = "0xF9D4D0", VA = "0x10F9E6D0")]
    private int GetFailCondSelfSideUnitCount(Unit self, EUnitCondition condition) => new int();

    [Token(Token = "0x6002DFA")]
    [Address(RVA = "0xF9F5D0", Offset = "0xF9E3D0", VA = "0x10F9F5D0")]
    private int GetHealUnitCount(Unit self) => new int();

    [Token(Token = "0x6002DFB")]
    [Address(RVA = "0xF9F7E0", Offset = "0xF9E5E0", VA = "0x10F9F7E0")]
    private List<Unit> GetHealer(Unit self) => (List<Unit>) null;

    [Token(Token = "0x6002DFC")]
    [Address(RVA = "0xFB3E50", Offset = "0xFB2C50", VA = "0x10FB3E50")]
    private void RefreshTreasureTargetAI()
    {
    }

    [Token(Token = "0x6002DFD")]
    [Address(RVA = "0xFAB9A0", Offset = "0xFAA7A0", VA = "0x10FAB9A0")]
    private bool IsBuffDebuffEffectiveEnemies(Unit self, BuffTypes type) => new bool();

    [Token(Token = "0x6002DFE")]
    [Address(RVA = "0xFACBF0", Offset = "0xFAB9F0", VA = "0x10FACBF0")]
    private bool IsFailCondSkillUseEnemies(Unit self, EUnitCondition condition) => new bool();

    [Token(Token = "0x6002DFF")]
    [Address(RVA = "0xFAE840", Offset = "0xFAD640", VA = "0x10FAE840")]
    private bool IsTargetBreakUnitAI(Unit self, Unit target) => new bool();

    [Token(Token = "0x6002E00")]
    [Address(RVA = "0xF990B0", Offset = "0xF97EB0", VA = "0x10F990B0")]
    private int GetAtkBonusForAttackDetailType(Unit self, SkillData skill) => new int();

    [Token(Token = "0x6002E01")]
    [Address(RVA = "0xFA13A0", Offset = "0xFA01A0", VA = "0x10FA13A0")]
    private int GetResistDamageForAttackDetailType(Unit defender, SkillData skill, int damage)
    {
      return new int();
    }

    [Token(Token = "0x6002E02")]
    [Address(RVA = "0xFA16C0", Offset = "0xFA04C0", VA = "0x10FA16C0")]
    private int GetResistDamageForUnitDefense(Unit defender, SkillData skill, int damage)
    {
      return new int();
    }

    [Token(Token = "0x6002E03")]
    [Address(RVA = "0xF75470", Offset = "0xF74270", VA = "0x10F75470")]
    private int CalcAtkPointSkillBase(Unit attacker, Unit defender, SkillData skill) => new int();

    [Token(Token = "0x6002E04")]
    [Address(RVA = "0xF76440", Offset = "0xF75240", VA = "0x10F76440")]
    private int CalcAtkPointSkill(Unit attacker, Unit defender, SkillData skill, LogSkill log)
    {
      return new int();
    }

    [Token(Token = "0x6002E05")]
    [Address(RVA = "0xF77AF0", Offset = "0xF768F0", VA = "0x10F77AF0")]
    private int CalcDefPointSkill(Unit attacker, Unit defender, SkillData skill, LogSkill log)
    {
      return new int();
    }

    [Token(Token = "0x6002E06")]
    [Address(RVA = "0xF9C0F0", Offset = "0xF9AEF0", VA = "0x10F9C0F0")]
    private int GetDamageSkill(Unit attacker, Unit defender, SkillData skill, LogSkill log)
    {
      return new int();
    }

    [Token(Token = "0x6002E07")]
    [Address(RVA = "0xF7DD50", Offset = "0xF7CB50", VA = "0x10F7DD50")]
    private long CheckIntOverFlow(long result, int damage, long rate) => new long();

    [Token(Token = "0x6002E08")]
    [Address(RVA = "0xF80BA0", Offset = "0xF7F9A0", VA = "0x10F80BA0")]
    private void ClearDamageList()
    {
    }

    [Token(Token = "0x6002E09")]
    [Address(RVA = "0xF710C0", Offset = "0xF6FEC0", VA = "0x10F710C0")]
    private bool AddDamageList(Unit unit, Unit target, int damage) => new bool();

    [Token(Token = "0x6002E0A")]
    [Address(RVA = "0x349100", Offset = "0x347F00", VA = "0x10349100")]
    public List<int> GetDamageList() => (List<int>) null;

    [Token(Token = "0x6002E0B")]
    [Address(RVA = "0xFB5780", Offset = "0xFB4580", VA = "0x10FB5780")]
    public void RestoreDamageList(int[] dmgs)
    {
    }

    [Token(Token = "0x6002E0C")]
    [Address(RVA = "0xFC3830", Offset = "0xFC2630", VA = "0x10FC3830")]
    public BattleCore()
    {
    }

    [Token(Token = "0x6002E0D")]
    [Address(RVA = "0xFC2E70", Offset = "0xFC1C70", VA = "0x10FC2E70")]
    static BattleCore()
    {
    }

    [Token(Token = "0x2000B5E")]
    public class OrderData
    {
      [Token(Token = "0x4001C42")]
      [FieldOffset(Offset = "0x8")]
      public Unit Unit;
      [Token(Token = "0x4001C43")]
      [FieldOffset(Offset = "0xC")]
      public bool IsCastSkill;
      [Token(Token = "0x4001C44")]
      [FieldOffset(Offset = "0xD")]
      public bool IsCharged;

      [Token(Token = "0x6002E0F")]
      [Address(RVA = "0xFCB3F0", Offset = "0xFCA1F0", VA = "0x10FCB3F0")]
      public OInt GetChargeTime() => new OInt();

      [Token(Token = "0x6002E10")]
      [Address(RVA = "0xFCB390", Offset = "0xFCA190", VA = "0x10FCB390")]
      public OInt GetChargeTimeMax() => new OInt();

      [Token(Token = "0x6002E11")]
      [Address(RVA = "0xFCB330", Offset = "0xFCA130", VA = "0x10FCB330")]
      public OInt GetChargeSpeed() => new OInt();

      [Token(Token = "0x6002E12")]
      [Address(RVA = "0xFCB2F0", Offset = "0xFCA0F0", VA = "0x10FCB2F0")]
      public bool CheckChargeTimeFullOver() => new bool();

      [Token(Token = "0x6002E13")]
      [Address(RVA = "0xFCB440", Offset = "0xFCA240", VA = "0x10FCB440")]
      public bool UpdateChargeTime() => new bool();

      [Token(Token = "0x6002E14")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public OrderData()
      {
      }
    }

    [Token(Token = "0x2000B5F")]
    public class DropItemParam
    {
      [Token(Token = "0x4001C45")]
      [FieldOffset(Offset = "0x8")]
      private ItemParam mItemParam;
      [Token(Token = "0x4001C46")]
      [FieldOffset(Offset = "0xC")]
      private ConceptCardParam mConceptCardParam;
      [Token(Token = "0x4001C47")]
      [FieldOffset(Offset = "0x10")]
      public bool mIsSecret;

      [Token(Token = "0x17000297")]
      public string Name
      {
        [Token(Token = "0x6002E15"), Address(RVA = "0xFC8B40", Offset = "0xFC7940", VA = "0x10FC8B40")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000298")]
      public string Iname
      {
        [Token(Token = "0x6002E16"), Address(RVA = "0xFC8AF0", Offset = "0xFC78F0", VA = "0x10FC8AF0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000299")]
      public bool IsItem
      {
        [Token(Token = "0x6002E17"), Address(RVA = "0x39EF50", Offset = "0x39DD50", VA = "0x1039EF50")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x1700029A")]
      public bool IsConceptCard
      {
        [Token(Token = "0x6002E18"), Address(RVA = "0x2B0090", Offset = "0x2AEE90", VA = "0x102B0090")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x1700029B")]
      public ItemParam itemParam
      {
        [Token(Token = "0x6002E19"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (ItemParam) null;
        }
      }

      [Token(Token = "0x1700029C")]
      public ConceptCardParam conceptCardParam
      {
        [Token(Token = "0x6002E1A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (ConceptCardParam) null;
        }
      }

      [Token(Token = "0x6002E1B")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public DropItemParam(ItemParam ip)
      {
      }

      [Token(Token = "0x6002E1C")]
      [Address(RVA = "0xFC8AC0", Offset = "0xFC78C0", VA = "0x10FC8AC0")]
      public DropItemParam(ConceptCardParam ccp)
      {
      }
    }

    [Token(Token = "0x2000B60")]
    public class SkillExecLog
    {
      [Token(Token = "0x4001C48")]
      [FieldOffset(Offset = "0x8")]
      public string skill_iname;
      [Token(Token = "0x4001C49")]
      [FieldOffset(Offset = "0xC")]
      public int use_count;
      [Token(Token = "0x4001C4A")]
      [FieldOffset(Offset = "0x10")]
      public int kill_count;

      [Token(Token = "0x6002E1D")]
      [Address(RVA = "0xFCC850", Offset = "0xFCB650", VA = "0x10FCC850")]
      public void Restore(BattleSuspend.Data.SkillExecLogInfo _log_info)
      {
      }

      [Token(Token = "0x6002E1E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public SkillExecLog()
      {
      }
    }

    [Token(Token = "0x2000B61")]
    public class Record
    {
      [Token(Token = "0x4001C4B")]
      [FieldOffset(Offset = "0x8")]
      public BattleCore.QuestResult result;
      [Token(Token = "0x4001C4C")]
      [FieldOffset(Offset = "0xC")]
      public OInt playerexp;
      [Token(Token = "0x4001C4D")]
      [FieldOffset(Offset = "0x20")]
      public OInt unitexp;
      [Token(Token = "0x4001C4E")]
      [FieldOffset(Offset = "0x34")]
      public OInt gold;
      [Token(Token = "0x4001C4F")]
      [FieldOffset(Offset = "0x48")]
      public OInt chain;
      [Token(Token = "0x4001C50")]
      [FieldOffset(Offset = "0x5C")]
      public OInt multicoin;
      [Token(Token = "0x4001C51")]
      [FieldOffset(Offset = "0x70")]
      public OInt pvpcoin;
      [Token(Token = "0x4001C52")]
      [FieldOffset(Offset = "0x84")]
      public List<UnitParam> units;
      [Token(Token = "0x4001C53")]
      [FieldOffset(Offset = "0x88")]
      public List<BattleCore.DropItemParam> items;
      [Token(Token = "0x4001C54")]
      [FieldOffset(Offset = "0x8C")]
      public List<ArtifactParam> artifacts;
      [Token(Token = "0x4001C55")]
      [FieldOffset(Offset = "0x90")]
      public int bonusFlags;
      [Token(Token = "0x4001C56")]
      [FieldOffset(Offset = "0x94")]
      public int allBonusFlags;
      [Token(Token = "0x4001C57")]
      [FieldOffset(Offset = "0x98")]
      public int bonusCount;
      [Token(Token = "0x4001C58")]
      [FieldOffset(Offset = "0x9C")]
      public List<int> takeoverProgressList;
      [Token(Token = "0x4001C59")]
      [FieldOffset(Offset = "0xA0")]
      public OInt[] drops;
      [Token(Token = "0x4001C5A")]
      [FieldOffset(Offset = "0xA4")]
      public OInt[] item_steals;
      [Token(Token = "0x4001C5B")]
      [FieldOffset(Offset = "0xA8")]
      public OInt[] gold_steals;
      [Token(Token = "0x4001C5C")]
      [FieldOffset(Offset = "0xAC")]
      public Dictionary<OString, OInt> used_items;
      [Token(Token = "0x4001C5D")]
      [FieldOffset(Offset = "0xB0")]
      public List<RuneData> runes_detail;
      [Token(Token = "0x4001C5E")]
      [FieldOffset(Offset = "0xB4")]
      public List<Json_Disassemble> disassemble;
      [Token(Token = "0x4001C5F")]
      [FieldOffset(Offset = "0xB8")]
      public List<BattleCore.Record.InspSkill> mInspSkillInsList;
      [Token(Token = "0x4001C60")]
      [FieldOffset(Offset = "0xBC")]
      public List<BattleCore.Record.InspSkill> mInspSkillUseList;
      [Token(Token = "0x4001C61")]
      [FieldOffset(Offset = "0xC0")]
      public List<BattleCore.Record.InspResult> mInspResultInspList;
      [Token(Token = "0x4001C62")]
      [FieldOffset(Offset = "0xC4")]
      public List<BattleCore.Record.InspResult> mInspResultLvUpList;
      [Token(Token = "0x4001C63")]
      [FieldOffset(Offset = "0xC8")]
      public Json_Gift[] mGenesisBossResultRewards;
      [Token(Token = "0x4001C64")]
      [FieldOffset(Offset = "0xCC")]
      public Json_Gift[] mAdvanceBossResultRewards;
      [Token(Token = "0x4001C65")]
      [FieldOffset(Offset = "0xD0")]
      public bool mIsUseAutoPlayMode;

      [Token(Token = "0x1700029D")]
      public bool IsZero
      {
        [Token(Token = "0x6002E1F"), Address(RVA = "0xFCBEF0", Offset = "0xFCACF0", VA = "0x10FCBEF0")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x6002E20")]
      [Address(RVA = "0xFCBAD0", Offset = "0xFCA8D0", VA = "0x10FCBAD0")]
      public bool IsMissionClearAll(bool onlyCurrentBattle) => new bool();

      [Token(Token = "0x6002E21")]
      [Address(RVA = "0xFCBB20", Offset = "0xFCA920", VA = "0x10FCBB20")]
      public Record()
      {
      }

      [Token(Token = "0x2000B62")]
      public class InspSkill
      {
        [Token(Token = "0x4001C66")]
        [FieldOffset(Offset = "0x8")]
        public UnitData mUnitData;
        [Token(Token = "0x4001C67")]
        [FieldOffset(Offset = "0xC")]
        public List<Unit.UnitInsp> mUnitInspList;

        [Token(Token = "0x6002E22")]
        [Address(RVA = "0xFC8C90", Offset = "0xFC7A90", VA = "0x10FC8C90")]
        public InspSkill(UnitData unit_data, Unit.UnitInsp unit_insp)
        {
        }
      }

      [Token(Token = "0x2000B63")]
      public class InspResult
      {
        [Token(Token = "0x4001C68")]
        [FieldOffset(Offset = "0x8")]
        public UnitData mUnitData;
        [Token(Token = "0x4001C69")]
        [FieldOffset(Offset = "0xC")]
        public ArtifactData mArtifactData;
        [Token(Token = "0x4001C6A")]
        [FieldOffset(Offset = "0x10")]
        public AbilityData mAbilityData;
        [Token(Token = "0x4001C6B")]
        [FieldOffset(Offset = "0x14")]
        public InspirationSkillData mInspirationSkillData;

        [Token(Token = "0x6002E23")]
        [Address(RVA = "0xFC8C30", Offset = "0xFC7A30", VA = "0x10FC8C30")]
        public InspResult(
          UnitData unit_data,
          ArtifactData artifact,
          InspirationSkillData insp_data,
          AbilityData ability)
        {
        }
      }
    }

    [Token(Token = "0x2000B64")]
    public class SkillManipulateTarget
    {
      [Token(Token = "0x4001C6C")]
      [FieldOffset(Offset = "0x8")]
      public Unit self;
      [Token(Token = "0x4001C6D")]
      [FieldOffset(Offset = "0xC")]
      public Unit target;
      [Token(Token = "0x4001C6E")]
      [FieldOffset(Offset = "0x10")]
      public ManipulateTypes manipulateType;
      [Token(Token = "0x4001C6F")]
      [FieldOffset(Offset = "0x11")]
      public DamageTypes damageType;
      [Token(Token = "0x4001C70")]
      [FieldOffset(Offset = "0x14")]
      public int elem;
      [Token(Token = "0x4001C71")]
      [FieldOffset(Offset = "0x18")]
      public int damage;
      [Token(Token = "0x4001C72")]
      [FieldOffset(Offset = "0x1C")]
      public int dropgems;
      [Token(Token = "0x4001C73")]
      [FieldOffset(Offset = "0x20")]
      public string effect;
      [Token(Token = "0x4001C74")]
      [FieldOffset(Offset = "0x24")]
      public bool isBreak;
      [Token(Token = "0x4001C75")]
      [FieldOffset(Offset = "0x28")]
      public Unit.UnitManipulate unitManipulate;

      [Token(Token = "0x6002E24")]
      [Address(RVA = "0xFCC890", Offset = "0xFCB690", VA = "0x10FCC890")]
      public bool IsManipulate() => new bool();

      [Token(Token = "0x6002E25")]
      [Address(RVA = "0xFCC8B0", Offset = "0xFCB6B0", VA = "0x10FCC8B0")]
      public SkillManipulateTarget()
      {
      }
    }

    [Token(Token = "0x2000B65")]
    public enum RESUME_STATE
    {
      [Token(Token = "0x4001C77")] NONE,
      [Token(Token = "0x4001C78")] REQUEST,
      [Token(Token = "0x4001C79")] WAIT,
    }

    [Token(Token = "0x2000B66")]
    public delegate void LogCallback(string s);

    [Token(Token = "0x2000B67")]
    public class Json_BattleCont
    {
      [Token(Token = "0x4001C7A")]
      [FieldOffset(Offset = "0x8")]
      public long btlid;
      [Token(Token = "0x4001C7B")]
      [FieldOffset(Offset = "0x10")]
      public BattleCore.Json_BtlInfo btlinfo;
      [Token(Token = "0x4001C7C")]
      [FieldOffset(Offset = "0x14")]
      public Json_PlayerData player;

      [Token(Token = "0x6002E2A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_BattleCont()
      {
      }
    }

    [Token(Token = "0x2000B68")]
    public class Json_Battle
    {
      [Token(Token = "0x4001C7D")]
      [FieldOffset(Offset = "0x8")]
      public long btlid;
      [Token(Token = "0x4001C7E")]
      [FieldOffset(Offset = "0x10")]
      public BattleCore.Json_BtlInfo btlinfo;
      [Token(Token = "0x4001C7F")]
      [FieldOffset(Offset = "0x14")]
      public Json_Unit[] coloenemyunits;
      [Token(Token = "0x4001C80")]
      [FieldOffset(Offset = "0x18")]
      public JSON_GuildRaidDeck forced_deck;
      [Token(Token = "0x4001C81")]
      [FieldOffset(Offset = "0x1C")]
      public int is_rehash;
      [Token(Token = "0x4001C82")]
      [FieldOffset(Offset = "0x20")]
      public int is_timeover;
      [Token(Token = "0x4001C83")]
      [FieldOffset(Offset = "0x24")]
      public int rescue_member_relation;
      [Token(Token = "0x4001C84")]
      [FieldOffset(Offset = "0x28")]
      public int maxActionNum;
      [Token(Token = "0x4001C85")]
      [FieldOffset(Offset = "0x2C")]
      public JSON_TrophyProgress[] guild_trophies;
      [Token(Token = "0x4001C86")]
      [FieldOffset(Offset = "0x30")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x4001C87")]
      [FieldOffset(Offset = "0x34")]
      public JSON_TrophyProgress[] bingoprogs;

      [Token(Token = "0x6002E2B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_Battle()
      {
      }
    }

    [Token(Token = "0x2000B69")]
    public class Json_BtlReward
    {
      [Token(Token = "0x4001C88")]
      [FieldOffset(Offset = "0x8")]
      public int gold;

      [Token(Token = "0x6002E2C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_BtlReward()
      {
      }
    }

    [Token(Token = "0x2000B6A")]
    public class Json_BtlInfo
    {
      [Token(Token = "0x4001C89")]
      [FieldOffset(Offset = "0x8")]
      public string qid;
      [Token(Token = "0x4001C8A")]
      [FieldOffset(Offset = "0xC")]
      public BattleCore.Json_BtlUnit[] units;
      [Token(Token = "0x4001C8B")]
      [FieldOffset(Offset = "0x10")]
      public Json_Support help;
      [Token(Token = "0x4001C8C")]
      [FieldOffset(Offset = "0x14")]
      public BattleCore.Json_BtlDrop[] drops;
      [Token(Token = "0x4001C8D")]
      [FieldOffset(Offset = "0x18")]
      public BattleCore.Json_BtlSteal[] steals;
      [Token(Token = "0x4001C8E")]
      [FieldOffset(Offset = "0x1C")]
      public BattleCore.Json_BtlReward[] rewards;
      [Token(Token = "0x4001C8F")]
      [FieldOffset(Offset = "0x20")]
      public string key;
      [Token(Token = "0x4001C90")]
      [FieldOffset(Offset = "0x24")]
      public int seed;
      [Token(Token = "0x4001C91")]
      [FieldOffset(Offset = "0x28")]
      public int[] atkmags;
      [Token(Token = "0x4001C92")]
      [FieldOffset(Offset = "0x2C")]
      public string[] campaigns;
      [Token(Token = "0x4001C93")]
      [FieldOffset(Offset = "0x30")]
      public long start_at;
      [Token(Token = "0x4001C94")]
      [FieldOffset(Offset = "0x38")]
      public int multi_floor;
      [Token(Token = "0x4001C95")]
      [FieldOffset(Offset = "0x3C")]
      public int roomid;
      [Token(Token = "0x4001C96")]
      [FieldOffset(Offset = "0x40")]
      public BattleCore.Json_BtlInfoRankingQuest quest_ranking;
      [Token(Token = "0x4001C97")]
      [FieldOffset(Offset = "0x44")]
      public BattleCore.Json_BtlOrdeal[] ordeals;
      [Token(Token = "0x4001C98")]
      [FieldOffset(Offset = "0x48")]
      public BattleCore.JSON_RankMatchRank myRank;
      [Token(Token = "0x4001C99")]
      [FieldOffset(Offset = "0x4C")]
      public BattleCore.JSON_RankMatchRank enemyRank;
      [Token(Token = "0x4001C9A")]
      [FieldOffset(Offset = "0x50")]
      public RandDeckResult[] lot_enemies;
      [Token(Token = "0x4001C9B")]
      [FieldOffset(Offset = "0x54")]
      public int area_id;
      [Token(Token = "0x4001C9C")]
      [FieldOffset(Offset = "0x58")]
      public int boss_id;
      [Token(Token = "0x4001C9D")]
      [FieldOffset(Offset = "0x5C")]
      public int round;
      [Token(Token = "0x4001C9E")]
      [FieldOffset(Offset = "0x60")]
      public JSON_RaidBossInfo boss_info;
      [Token(Token = "0x4001C9F")]
      [FieldOffset(Offset = "0x64")]
      public BattleCore.Json_BtlInspSlot[] sins;
      [Token(Token = "0x4001CA0")]
      [FieldOffset(Offset = "0x68")]
      public BattleCore.Json_BaseEnemy[] enemies;
      [Token(Token = "0x4001CA1")]
      [FieldOffset(Offset = "0x6C")]
      public Json_Item[] items;
      [Token(Token = "0x4001CA2")]
      [FieldOffset(Offset = "0x70")]
      public int auto_repeat_check;
      [Token(Token = "0x4001CA3")]
      [FieldOffset(Offset = "0x74")]
      public int battle_type;
      [Token(Token = "0x4001CA4")]
      [FieldOffset(Offset = "0x78")]
      public int turn;
      [Token(Token = "0x4001CA5")]
      [FieldOffset(Offset = "0x7C")]
      public string[] expansions;
      [Token(Token = "0x4001CA6")]
      [FieldOffset(Offset = "0x80")]
      public JSON_WorldRaidBossReqData worldraid;
      [Token(Token = "0x4001CA7")]
      [FieldOffset(Offset = "0x84")]
      public JSON_DuelBattleMapData map_data;
      [Token(Token = "0x4001CA8")]
      [FieldOffset(Offset = "0x88")]
      public JSON_DuelSelfData my_data;
      [Token(Token = "0x4001CA9")]
      [FieldOffset(Offset = "0x8C")]
      public BattleCore.JSON_EnemyData enemy_data;
      [Token(Token = "0x4001CAA")]
      [FieldOffset(Offset = "0x90")]
      public JSON_PlayerBuff player_buff;

      [Token(Token = "0x6002E2D")]
      [Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "4")]
      public virtual RandDeckResult[] GetDeck() => (RandDeckResult[]) null;

      [Token(Token = "0x1700029E")]
      public bool IsMultiTowerQuest
      {
        [Token(Token = "0x6002E2E"), Address(RVA = "0xFCAE30", Offset = "0xFC9C30", VA = "0x10FCAE30")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x1700029F")]
      public bool IsRaidQuest
      {
        [Token(Token = "0x6002E2F"), Address(RVA = "0xFCAE60", Offset = "0xFC9C60", VA = "0x10FCAE60")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x170002A0")]
      public bool IsOrdeal
      {
        [Token(Token = "0x6002E30"), Address(RVA = "0xFCAE40", Offset = "0xFC9C40", VA = "0x10FCAE40")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x170002A1")]
      public bool IsDuelorLeagueMatch
      {
        [Token(Token = "0x6002E31"), Address(RVA = "0xFCAE00", Offset = "0xFC9C00", VA = "0x10FCAE00")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x170002A2")]
      public bool IsAutoRepeatQuestMeasuring
      {
        [Token(Token = "0x6002E32"), Address(RVA = "0xFCADF0", Offset = "0xFC9BF0", VA = "0x10FCADF0")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x6002E33")]
      [Address(RVA = "0xFCAB70", Offset = "0xFC9970", VA = "0x10FCAB70", Slot = "5")]
      public virtual QuestParam GetQuestParam() => (QuestParam) null;

      [Token(Token = "0x6002E34")]
      [Address(RVA = "0xFCA700", Offset = "0xFC9500", VA = "0x10FCA700")]
      public List<UnitData> GetPlayerSideUnits() => (List<UnitData>) null;

      [Token(Token = "0x6002E35")]
      [Address(RVA = "0xFCA350", Offset = "0xFC9150", VA = "0x10FCA350")]
      public List<UnitData> GetOwnUnits() => (List<UnitData>) null;

      [Token(Token = "0x6002E36")]
      [Address(RVA = "0xFCAD70", Offset = "0xFC9B70", VA = "0x10FCAD70")]
      public UnitData GetSupportUnit() => (UnitData) null;

      [Token(Token = "0x6002E37")]
      [Address(RVA = "0xFCA060", Offset = "0xFC8E60", VA = "0x10FCA060")]
      public List<UnitData> GetOdealOwnUnits() => (List<UnitData>) null;

      [Token(Token = "0x6002E38")]
      [Address(RVA = "0xFCA1F0", Offset = "0xFC8FF0", VA = "0x10FCA1F0")]
      public List<UnitData> GetOrdealSupportUnits() => (List<UnitData>) null;

      [Token(Token = "0x6002E39")]
      [Address(RVA = "0xFC8DD0", Offset = "0xFC7BD0", VA = "0x10FC8DD0")]
      public List<UnitData> GetAudienceModeUnits() => (List<UnitData>) null;

      [Token(Token = "0x6002E3A")]
      [Address(RVA = "0xFC9320", Offset = "0xFC8120", VA = "0x10FC9320")]
      public static List<UnitData> GetCPUBattleUnits() => (List<UnitData>) null;

      [Token(Token = "0x6002E3B")]
      [Address(RVA = "0xFC9750", Offset = "0xFC8550", VA = "0x10FC9750")]
      public List<UnitData> GetMultiPlayUnits() => (List<UnitData>) null;

      [Token(Token = "0x6002E3C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_BtlInfo()
      {
      }
    }

    [Token(Token = "0x2000B6C")]
    public class Json_BtlUnit
    {
      [Token(Token = "0x4001CAE")]
      [FieldOffset(Offset = "0x8")]
      public long iid;

      [Token(Token = "0x6002E41")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_BtlUnit()
      {
      }
    }

    [Token(Token = "0x2000B6D")]
    [MessagePackObject(true)]
    public class Json_BtlDrop
    {
      [Token(Token = "0x4001CAF")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x4001CB0")]
      [FieldOffset(Offset = "0xC")]
      public string itype;
      [Token(Token = "0x4001CB1")]
      [FieldOffset(Offset = "0x10")]
      public int gold;
      [Token(Token = "0x4001CB2")]
      [FieldOffset(Offset = "0x14")]
      public int num;
      [Token(Token = "0x4001CB3")]
      [FieldOffset(Offset = "0x18")]
      public int secret;

      [Token(Token = "0x170002A3")]
      public EBattleRewardType dropItemType
      {
        [Token(Token = "0x6002E42"), Address(RVA = "0xFC8D40", Offset = "0xFC7B40", VA = "0x10FC8D40")] get
        {
          return new EBattleRewardType();
        }
      }

      [Token(Token = "0x6002E43")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_BtlDrop()
      {
      }
    }

    [Token(Token = "0x2000B6E")]
    public class Json_BtlSteal
    {
      [Token(Token = "0x4001CB4")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x4001CB5")]
      [FieldOffset(Offset = "0xC")]
      public int gold;
      [Token(Token = "0x4001CB6")]
      [FieldOffset(Offset = "0x10")]
      public int num;

      [Token(Token = "0x6002E44")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_BtlSteal()
      {
      }
    }

    [Token(Token = "0x2000B6F")]
    public class Json_BtlInfoRankingQuest
    {
      [Token(Token = "0x4001CB7")]
      [FieldOffset(Offset = "0x8")]
      public int type;
      [Token(Token = "0x4001CB8")]
      [FieldOffset(Offset = "0xC")]
      public int schedule_id;

      [Token(Token = "0x6002E45")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_BtlInfoRankingQuest()
      {
      }
    }

    [Token(Token = "0x2000B70")]
    public class Json_BtlOrdeal
    {
      [Token(Token = "0x4001CB9")]
      [FieldOffset(Offset = "0x8")]
      public BattleCore.Json_BtlUnit[] units;
      [Token(Token = "0x4001CBA")]
      [FieldOffset(Offset = "0xC")]
      public Json_Support help;

      [Token(Token = "0x6002E46")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_BtlOrdeal()
      {
      }
    }

    [Token(Token = "0x2000B71")]
    public class JSON_RankMatchRank
    {
      [Token(Token = "0x4001CBB")]
      [FieldOffset(Offset = "0x8")]
      public int score;
      [Token(Token = "0x4001CBC")]
      [FieldOffset(Offset = "0xC")]
      public int type;

      [Token(Token = "0x6002E47")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_RankMatchRank()
      {
      }
    }

    [Token(Token = "0x2000B72")]
    public class Json_BtlInspSlot
    {
      [Token(Token = "0x4001CBD")]
      [FieldOffset(Offset = "0x8")]
      public long uiid;
      [Token(Token = "0x4001CBE")]
      [FieldOffset(Offset = "0x10")]
      public BattleCore.Json_BtlInspArtifactSlot[] artifact;

      [Token(Token = "0x6002E48")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_BtlInspSlot()
      {
      }
    }

    [Token(Token = "0x2000B73")]
    public class Json_BtlInspArtifactSlot
    {
      [Token(Token = "0x4001CBF")]
      [FieldOffset(Offset = "0x8")]
      public int iid;
      [Token(Token = "0x4001CC0")]
      [FieldOffset(Offset = "0xC")]
      public int slot;

      [Token(Token = "0x6002E49")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_BtlInspArtifactSlot()
      {
      }
    }

    [Token(Token = "0x2000B74")]
    public class Json_BtlInsp
    {
      [Token(Token = "0x4001CC1")]
      [FieldOffset(Offset = "0x8")]
      public int uiid;
      [Token(Token = "0x4001CC2")]
      [FieldOffset(Offset = "0xC")]
      public BattleCore.Json_BtlInspArtifact[] artifact;

      [Token(Token = "0x6002E4A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_BtlInsp()
      {
      }
    }

    [Token(Token = "0x2000B75")]
    public class Json_BtlInspArtifact
    {
      [Token(Token = "0x4001CC3")]
      [FieldOffset(Offset = "0x8")]
      public int iid;

      [Token(Token = "0x6002E4B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_BtlInspArtifact()
      {
      }
    }

    [Token(Token = "0x2000B76")]
    [Serializable]
    public class Json_BaseEnemy
    {
      [Token(Token = "0x4001CC4")]
      [FieldOffset(Offset = "0x8")]
      public int eid;
      [Token(Token = "0x4001CC5")]
      [FieldOffset(Offset = "0xC")]
      public int boss_flg;
      [Token(Token = "0x4001CC6")]
      [FieldOffset(Offset = "0x10")]
      public int hp;

      [Token(Token = "0x6002E4C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_BaseEnemy()
      {
      }
    }

    [Token(Token = "0x2000B77")]
    [Serializable]
    public class Json_GenesisEnemy : BattleCore.Json_BaseEnemy
    {
      [Token(Token = "0x6002E4D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_GenesisEnemy()
      {
      }
    }

    [Token(Token = "0x2000B78")]
    [Serializable]
    public class Json_AdvanceEnemy : BattleCore.Json_BaseEnemy
    {
      [Token(Token = "0x6002E4E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_AdvanceEnemy()
      {
      }
    }

    [Token(Token = "0x2000B79")]
    [Serializable]
    public class JSON_EnemyData
    {
      [Token(Token = "0x4001CC7")]
      [FieldOffset(Offset = "0x8")]
      public string enemy_data;
      [Token(Token = "0x4001CC8")]
      [FieldOffset(Offset = "0xC")]
      public Json_Unit[] party;
      [Token(Token = "0x4001CC9")]
      [FieldOffset(Offset = "0x10")]
      public int is_npc;
      [Token(Token = "0x4001CCA")]
      [FieldOffset(Offset = "0x14")]
      public int id;
      [Token(Token = "0x4001CCB")]
      [FieldOffset(Offset = "0x18")]
      public string map;
      [Token(Token = "0x4001CCC")]
      [FieldOffset(Offset = "0x1C")]
      public string[] buffs;
      [Token(Token = "0x4001CCD")]
      [FieldOffset(Offset = "0x20")]
      public JSON_LeagueMatchSet[] placement;
      [Token(Token = "0x4001CCE")]
      [FieldOffset(Offset = "0x24")]
      public JSON_PlayerBuff player_buff;

      [Token(Token = "0x6002E4F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_EnemyData()
      {
      }
    }

    [Token(Token = "0x2000B7A")]
    private class UnitCoef
    {
      [Token(Token = "0x4001CCF")]
      [FieldOffset(Offset = "0x8")]
      public Unit mUnit;
      [Token(Token = "0x4001CD0")]
      [FieldOffset(Offset = "0xC")]
      public int mCoef;

      [Token(Token = "0x6002E50")]
      [Address(RVA = "0x3217D0", Offset = "0x3205D0", VA = "0x103217D0")]
      public UnitCoef(Unit unit, int coef)
      {
      }
    }

    [Token(Token = "0x2000B7B")]
    public enum QuestResult
    {
      [Token(Token = "0x4001CD2")] Pending,
      [Token(Token = "0x4001CD3")] Win,
      [Token(Token = "0x4001CD4")] Lose,
      [Token(Token = "0x4001CD5")] Retreat,
      [Token(Token = "0x4001CD6")] Draw,
      [Token(Token = "0x4001CD7")] ReplayErr,
    }

    [Token(Token = "0x2000B7C")]
    public struct SVector2
    {
      [Token(Token = "0x4001CD8")]
      [FieldOffset(Offset = "0x0")]
      public int x;
      [Token(Token = "0x4001CD9")]
      [FieldOffset(Offset = "0x4")]
      public int y;

      [Token(Token = "0x6002E51")]
      [Address(RVA = "0x290D40", Offset = "0x28FB40", VA = "0x10290D40")]
      public SVector2(int _x_, int _y_)
      {
      }

      [Token(Token = "0x6002E52")]
      [Address(RVA = "0x290D40", Offset = "0x28FB40", VA = "0x10290D40")]
      public SVector2(BattleCore.SVector2 v)
      {
      }

      [Token(Token = "0x6002E53")]
      [Address(RVA = "0xFCC6E0", Offset = "0xFCB4E0", VA = "0x10FCC6E0")]
      public static BattleCore.SVector2 operator +(BattleCore.SVector2 a, BattleCore.SVector2 b)
      {
        return new BattleCore.SVector2();
      }

      [Token(Token = "0x6002E54")]
      [Address(RVA = "0xFCC740", Offset = "0xFCB540", VA = "0x10FCC740")]
      public static BattleCore.SVector2 operator -(BattleCore.SVector2 a, BattleCore.SVector2 b)
      {
        return new BattleCore.SVector2();
      }

      [Token(Token = "0x6002E55")]
      [Address(RVA = "0xFCC700", Offset = "0xFCB500", VA = "0x10FCC700")]
      public static BattleCore.SVector2 operator *(BattleCore.SVector2 a, BattleCore.SVector2 b)
      {
        return new BattleCore.SVector2();
      }

      [Token(Token = "0x6002E56")]
      [Address(RVA = "0xFCC720", Offset = "0xFCB520", VA = "0x10FCC720")]
      public static BattleCore.SVector2 operator *(BattleCore.SVector2 a, int mul)
      {
        return new BattleCore.SVector2();
      }

      [Token(Token = "0x6002E57")]
      [Address(RVA = "0xD5A740", Offset = "0xD59540", VA = "0x10D5A740")]
      public static bool operator ==(BattleCore.SVector2 a, BattleCore.SVector2 b) => new bool();

      [Token(Token = "0x6002E58")]
      [Address(RVA = "0xD5A760", Offset = "0xD59560", VA = "0x10D5A760")]
      public static bool operator !=(BattleCore.SVector2 a, BattleCore.SVector2 b) => new bool();

      [Token(Token = "0x6002E59")]
      [Address(RVA = "0xFCC680", Offset = "0xFCB480", VA = "0x10FCC680")]
      public int Length() => new int();

      [Token(Token = "0x6002E5A")]
      [Address(RVA = "0xFCC5E0", Offset = "0xFCB3E0", VA = "0x10FCC5E0")]
      public static int DotProduct(ref BattleCore.SVector2 s, ref BattleCore.SVector2 t)
      {
        return new int();
      }

      [Token(Token = "0x6002E5B")]
      [Address(RVA = "0xFCC600", Offset = "0xFCB400", VA = "0x10FCC600", Slot = "0")]
      public override bool Equals(object obj) => new bool();

      [Token(Token = "0x6002E5C")]
      [Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "2")]
      public override int GetHashCode() => new int();
    }

    [Token(Token = "0x2000B7D")]
    public class HitData
    {
      [Token(Token = "0x4001CDA")]
      [FieldOffset(Offset = "0x8")]
      public int hp_damage;
      [Token(Token = "0x4001CDB")]
      [FieldOffset(Offset = "0xC")]
      public int mp_damage;
      [Token(Token = "0x4001CDC")]
      [FieldOffset(Offset = "0x10")]
      public int ch_damage;
      [Token(Token = "0x4001CDD")]
      [FieldOffset(Offset = "0x14")]
      public int ca_damage;
      [Token(Token = "0x4001CDE")]
      [FieldOffset(Offset = "0x18")]
      public int hp_heal;
      [Token(Token = "0x4001CDF")]
      [FieldOffset(Offset = "0x1C")]
      public int mp_heal;
      [Token(Token = "0x4001CE0")]
      [FieldOffset(Offset = "0x20")]
      public int ch_heal;
      [Token(Token = "0x4001CE1")]
      [FieldOffset(Offset = "0x24")]
      public int ca_heal;
      [Token(Token = "0x4001CE2")]
      [FieldOffset(Offset = "0x28")]
      public bool is_critical;
      [Token(Token = "0x4001CE3")]
      [FieldOffset(Offset = "0x29")]
      public bool is_avoid;
      [Token(Token = "0x4001CE4")]
      [FieldOffset(Offset = "0x2A")]
      public bool is_pf_avoid;
      [Token(Token = "0x4001CE5")]
      [FieldOffset(Offset = "0x2C")]
      public int critical_rate;
      [Token(Token = "0x4001CE6")]
      [FieldOffset(Offset = "0x30")]
      public int avoid_rate;

      [Token(Token = "0x6002E5D")]
      [Address(RVA = "0xFC8BC0", Offset = "0xFC79C0", VA = "0x10FC8BC0")]
      public HitData(
        int _hp_damage_,
        int _mp_damage_,
        int _ch_damage_,
        int _ca_damage_,
        int _hp_heal_,
        int _mp_heal_,
        int _ch_heal_,
        int _ca_heal_,
        bool _critical_,
        bool _avoid_,
        bool _pf_avoid_,
        int _critical_rate_,
        int _avoid_rate_)
      {
      }
    }

    [Token(Token = "0x2000B7E")]
    public class ChainUnit
    {
      [Token(Token = "0x4001CE7")]
      [FieldOffset(Offset = "0x8")]
      public Unit self;
      [Token(Token = "0x4001CE8")]
      [FieldOffset(Offset = "0xC")]
      public List<BattleCore.HitData> hits;

      [Token(Token = "0x6002E5E")]
      [Address(RVA = "0xFC7DB0", Offset = "0xFC6BB0", VA = "0x10FC7DB0")]
      public ChainUnit()
      {
      }
    }

    [Token(Token = "0x2000B7F")]
    public class UnitResult
    {
      [Token(Token = "0x4001CE9")]
      [FieldOffset(Offset = "0x8")]
      public Unit react_unit;
      [Token(Token = "0x4001CEA")]
      [FieldOffset(Offset = "0xC")]
      public Unit unit;
      [Token(Token = "0x4001CEB")]
      [FieldOffset(Offset = "0x10")]
      public int hp_damage;
      [Token(Token = "0x4001CEC")]
      [FieldOffset(Offset = "0x14")]
      public int mp_damage;
      [Token(Token = "0x4001CED")]
      [FieldOffset(Offset = "0x18")]
      public int hp_heal;
      [Token(Token = "0x4001CEE")]
      [FieldOffset(Offset = "0x1C")]
      public int mp_heal;
      [Token(Token = "0x4001CEF")]
      [FieldOffset(Offset = "0x20")]
      public int avoid;
      [Token(Token = "0x4001CF0")]
      [FieldOffset(Offset = "0x24")]
      public int critical;
      [Token(Token = "0x4001CF1")]
      [FieldOffset(Offset = "0x28")]
      public int reaction;
      [Token(Token = "0x4001CF2")]
      [FieldOffset(Offset = "0x2C")]
      public List<LogSkill.Target.CondHit> cond_hit_lists;

      [Token(Token = "0x6002E5F")]
      [Address(RVA = "0xFD7030", Offset = "0xFD5E30", VA = "0x10FD7030")]
      public UnitResult()
      {
      }
    }

    [Token(Token = "0x2000B80")]
    public class CommandResult
    {
      [Token(Token = "0x4001CF3")]
      [FieldOffset(Offset = "0x8")]
      public Unit self;
      [Token(Token = "0x4001CF4")]
      [FieldOffset(Offset = "0xC")]
      public SkillData skill;
      [Token(Token = "0x4001CF5")]
      [FieldOffset(Offset = "0x10")]
      public BattleCore.UnitResult self_effect;
      [Token(Token = "0x4001CF6")]
      [FieldOffset(Offset = "0x14")]
      public List<BattleCore.UnitResult> targets;
      [Token(Token = "0x4001CF7")]
      [FieldOffset(Offset = "0x18")]
      public List<BattleCore.UnitResult> reactions;
      [Token(Token = "0x4001CF8")]
      [FieldOffset(Offset = "0x1C")]
      public List<Unit> protect_units;

      [Token(Token = "0x6002E60")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public CommandResult()
      {
      }
    }

    [Token(Token = "0x2000B81")]
    private class ShotTarget
    {
      [Token(Token = "0x4001CF9")]
      [FieldOffset(Offset = "0x8")]
      public List<Unit> piercers;
      [Token(Token = "0x4001CFA")]
      [FieldOffset(Offset = "0xC")]
      public Grid end;
      [Token(Token = "0x4001CFB")]
      [FieldOffset(Offset = "0x10")]
      public double rad;
      [Token(Token = "0x4001CFC")]
      [FieldOffset(Offset = "0x18")]
      public double height;

      [Token(Token = "0x6002E61")]
      [Address(RVA = "0xFCC7E0", Offset = "0xFCB5E0", VA = "0x10FCC7E0")]
      public ShotTarget()
      {
      }
    }

    [Token(Token = "0x2000B82")]
    private class ReactionTarget
    {
      [Token(Token = "0x4001CFD")]
      [FieldOffset(Offset = "0x8")]
      public SkillData mSkill;
      [Token(Token = "0x4001CFE")]
      [FieldOffset(Offset = "0xC")]
      public List<LogSkill.Target> mLogTargets;

      [Token(Token = "0x6002E62")]
      [Address(RVA = "0x3C0020", Offset = "0x3BEE20", VA = "0x103C0020")]
      public ReactionTarget(SkillData skill, List<LogSkill.Target> log_targets)
      {
      }
    }

    [Token(Token = "0x2000B83")]
    public enum eArenaCalcType
    {
      [Token(Token = "0x4001D00")] UNKNOWN,
      [Token(Token = "0x4001D01")] MAP_START,
      [Token(Token = "0x4001D02")] UNIT_START,
      [Token(Token = "0x4001D03")] AI,
      [Token(Token = "0x4001D04")] UNIT_END,
      [Token(Token = "0x4001D05")] CAST_SKILL_START,
      [Token(Token = "0x4001D06")] CAST_SKILL_END,
      [Token(Token = "0x4001D07")] MAP_END,
    }

    [Token(Token = "0x2000B84")]
    private class KnockBackTarget
    {
      [Token(Token = "0x4001D08")]
      [FieldOffset(Offset = "0x8")]
      public LogSkill.Target mLsTarget;
      [Token(Token = "0x4001D09")]
      [FieldOffset(Offset = "0xC")]
      public int mUnitGx;
      [Token(Token = "0x4001D0A")]
      [FieldOffset(Offset = "0x10")]
      public int mUnitGy;
      [Token(Token = "0x4001D0B")]
      [FieldOffset(Offset = "0x14")]
      public int mMoveLen;
      [Token(Token = "0x4001D0C")]
      [FieldOffset(Offset = "0x18")]
      public int mMoveDir;

      [Token(Token = "0x6002E63")]
      [Address(RVA = "0xFCAE70", Offset = "0xFC9C70", VA = "0x10FCAE70")]
      public KnockBackTarget(LogSkill.Target ls_target, int gx, int gy)
      {
      }
    }

    [Token(Token = "0x2000B85")]
    private class TdTarget
    {
      [Token(Token = "0x4001D0D")]
      [FieldOffset(Offset = "0x8")]
      public Unit mUnit;
      [Token(Token = "0x4001D0E")]
      [FieldOffset(Offset = "0xC")]
      public int mX;
      [Token(Token = "0x4001D0F")]
      [FieldOffset(Offset = "0x10")]
      public int mY;

      [Token(Token = "0x6002E64")]
      [Address(RVA = "0xFD2E00", Offset = "0xFD1C00", VA = "0x10FD2E00")]
      public TdTarget(Unit unit, int x, int y)
      {
      }
    }

    [Token(Token = "0x2000B86")]
    private class ManipulateCalcData
    {
      [Token(Token = "0x4001D10")]
      [FieldOffset(Offset = "0x8")]
      public Unit self;
      [Token(Token = "0x4001D11")]
      [FieldOffset(Offset = "0xC")]
      public Unit target;
      [Token(Token = "0x4001D12")]
      [FieldOffset(Offset = "0x10")]
      public int value;
      [Token(Token = "0x4001D13")]
      [FieldOffset(Offset = "0x14")]
      public BattleCore.SkillManipulateTarget manipulate;

      [Token(Token = "0x6002E65")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ManipulateCalcData()
      {
      }
    }

    [Token(Token = "0x2000B87")]
    public class AiCache
    {
      [Token(Token = "0x4001D14")]
      [FieldOffset(Offset = "0x8")]
      public BattleMap map;
      [Token(Token = "0x4001D15")]
      [FieldOffset(Offset = "0xC")]
      public FixParam fixparam;
      [Token(Token = "0x4001D16")]
      [FieldOffset(Offset = "0x10")]
      public BattleCore.SVector2 pos;
      [Token(Token = "0x4001D17")]
      [FieldOffset(Offset = "0x18")]
      public int cond_prio;
      [Token(Token = "0x4001D18")]
      [FieldOffset(Offset = "0x1C")]
      public int cost_jewel;
      [Token(Token = "0x4001D19")]
      [FieldOffset(Offset = "0x20")]
      public Grid goal;
      [Token(Token = "0x4001D1A")]
      [FieldOffset(Offset = "0x24")]
      public GridMap<bool> baseRangeMap;

      [Token(Token = "0x6002E66")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public AiCache()
      {
      }
    }

    [Token(Token = "0x2000B88")]
    public class SkillResult
    {
      [Token(Token = "0x4001D1B")]
      [FieldOffset(Offset = "0x8")]
      public SkillData skill;
      [Token(Token = "0x4001D1C")]
      [FieldOffset(Offset = "0xC")]
      public Grid movpos;
      [Token(Token = "0x4001D1D")]
      [FieldOffset(Offset = "0x10")]
      public Grid usepos;
      [Token(Token = "0x4001D1E")]
      [FieldOffset(Offset = "0x14")]
      public LogSkill log;
      [Token(Token = "0x4001D1F")]
      [FieldOffset(Offset = "0x18")]
      public bool locked;
      [Token(Token = "0x4001D20")]
      [FieldOffset(Offset = "0x1C")]
      public int score_prio;
      [Token(Token = "0x4001D21")]
      [FieldOffset(Offset = "0x20")]
      public int ftgt_prio;
      [Token(Token = "0x4001D22")]
      [FieldOffset(Offset = "0x24")]
      public int unit_prio;
      [Token(Token = "0x4001D23")]
      [FieldOffset(Offset = "0x28")]
      public int cost_jewel;
      [Token(Token = "0x4001D24")]
      [FieldOffset(Offset = "0x2C")]
      public int gain_jewel;
      [Token(Token = "0x4001D25")]
      [FieldOffset(Offset = "0x30")]
      public int heal;
      [Token(Token = "0x4001D26")]
      [FieldOffset(Offset = "0x34")]
      public int heal_num;
      [Token(Token = "0x4001D27")]
      [FieldOffset(Offset = "0x38")]
      public int cure_num;
      [Token(Token = "0x4001D28")]
      [FieldOffset(Offset = "0x3C")]
      public int fail_num;
      [Token(Token = "0x4001D29")]
      [FieldOffset(Offset = "0x40")]
      public int disable_num;
      [Token(Token = "0x4001D2A")]
      [FieldOffset(Offset = "0x44")]
      public int cond_prio;
      [Token(Token = "0x4001D2B")]
      [FieldOffset(Offset = "0x48")]
      public int buff;
      [Token(Token = "0x4001D2C")]
      [FieldOffset(Offset = "0x4C")]
      public int buff_num;
      [Token(Token = "0x4001D2D")]
      [FieldOffset(Offset = "0x50")]
      public int buff_prio;
      [Token(Token = "0x4001D2E")]
      [FieldOffset(Offset = "0x54")]
      public int buff_dup;
      [Token(Token = "0x4001D2F")]
      [FieldOffset(Offset = "0x58")]
      public int unit_damage_t;
      [Token(Token = "0x4001D30")]
      [FieldOffset(Offset = "0x5C")]
      public int unit_damage;
      [Token(Token = "0x4001D31")]
      [FieldOffset(Offset = "0x60")]
      public int unit_dead_num;
      [Token(Token = "0x4001D32")]
      [FieldOffset(Offset = "0x64")]
      public int ext_damage;
      [Token(Token = "0x4001D33")]
      [FieldOffset(Offset = "0x68")]
      public int ext_dead_num;
      [Token(Token = "0x4001D34")]
      [FieldOffset(Offset = "0x6C")]
      public int nockback_prio;
      [Token(Token = "0x4001D35")]
      [FieldOffset(Offset = "0x70")]
      public int distance;
      [Token(Token = "0x4001D36")]
      [FieldOffset(Offset = "0x74")]
      public int teleport;
      [Token(Token = "0x4001D37")]
      [FieldOffset(Offset = "0x78")]
      public int ct;
      [Token(Token = "0x4001D38")]
      [FieldOffset(Offset = "0x7C")]
      public int fail_trick;
      [Token(Token = "0x4001D39")]
      [FieldOffset(Offset = "0x80")]
      public int good_trick;
      [Token(Token = "0x4001D3A")]
      [FieldOffset(Offset = "0x84")]
      public int heal_trick;
      [Token(Token = "0x4001D3B")]
      [FieldOffset(Offset = "0x88")]
      public int protect_prio;
      [Token(Token = "0x4001D3C")]
      [FieldOffset(Offset = "0x8C")]
      public int manipulate_prio;

      [Token(Token = "0x6002E67")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public SkillResult()
      {
      }
    }

    [Token(Token = "0x2000B89")]
    public class MoveGoalTarget
    {
      [Token(Token = "0x4001D3D")]
      [FieldOffset(Offset = "0x8")]
      public Unit unit;
      [Token(Token = "0x4001D3E")]
      [FieldOffset(Offset = "0xC")]
      public Vector2 goal;
      [Token(Token = "0x4001D3F")]
      [FieldOffset(Offset = "0x14")]
      public float step;

      [Token(Token = "0x6002E68")]
      [Address(RVA = "0xFCAEC0", Offset = "0xFC9CC0", VA = "0x10FCAEC0")]
      public static List<BattleCore.MoveGoalTarget> Create(List<Unit> targets)
      {
        return (List<BattleCore.MoveGoalTarget>) null;
      }

      [Token(Token = "0x6002E69")]
      [Address(RVA = "0xFCB000", Offset = "0xFC9E00", VA = "0x10FCB000", Slot = "3")]
      public override string ToString() => (string) null;

      [Token(Token = "0x6002E6A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public MoveGoalTarget()
      {
      }
    }
  }
}
