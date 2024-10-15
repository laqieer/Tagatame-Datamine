// Decompiled with JetBrains decompiler
// Type: SRPG.Unit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D91")]
  [MessagePackObject(true)]
  public class Unit : BaseObject
  {
    [Token(Token = "0x400E3CC")]
    [FieldOffset(Offset = "0x0")]
    private static string[] mStrNameUnitConds;
    [Token(Token = "0x400E3CD")]
    [FieldOffset(Offset = "0x4")]
    private static string[] mStrDescUnitConds;
    [Token(Token = "0x400E3CE")]
    [FieldOffset(Offset = "0x8")]
    public static readonly int MAX_AI;
    [Token(Token = "0x400E3CF")]
    [FieldOffset(Offset = "0xC")]
    public static OInt MAX_UNIT_CONDITION;
    [Token(Token = "0x400E3D0")]
    [FieldOffset(Offset = "0x20")]
    private static OInt UNIT_INDEX;
    [Token(Token = "0x400E3D1")]
    [FieldOffset(Offset = "0x34")]
    public static OInt UNIT_CAST_INDEX;
    [Token(Token = "0x400E3D2")]
    public const int DIRECTION_MAX = 4;
    [Token(Token = "0x400E3D3")]
    [FieldOffset(Offset = "0x48")]
    public static readonly int[,] DIRECTION_OFFSETS;
    [Token(Token = "0x400E3D4")]
    [FieldOffset(Offset = "0x4C")]
    public static EUnitDirection[] ReverseDirection;
    [Token(Token = "0x400E3D5")]
    [FieldOffset(Offset = "0x50")]
    public static EUnitDirection[] LeftDirection;
    [Token(Token = "0x400E3D6")]
    [FieldOffset(Offset = "0x54")]
    public static EUnitDirection[] RightDirection;
    [Token(Token = "0x400E3D7")]
    [FieldOffset(Offset = "0x58")]
    public static EUnitDirection[] ForwardDirection;
    [Token(Token = "0x400E3D8")]
    [FieldOffset(Offset = "0xC")]
    private string mUnitName;
    [Token(Token = "0x400E3D9")]
    [FieldOffset(Offset = "0x10")]
    private string mUniqueName;
    [Token(Token = "0x400E3DA")]
    [FieldOffset(Offset = "0x14")]
    private UnitData mUnitData;
    [Token(Token = "0x400E3DB")]
    [FieldOffset(Offset = "0x18")]
    private EUnitSide mSide;
    [Token(Token = "0x400E3DC")]
    [FieldOffset(Offset = "0x20")]
    private OLong mUnitFlag;
    [Token(Token = "0x400E3DD")]
    [FieldOffset(Offset = "0x48")]
    private int mUseSkillFlag;
    [Token(Token = "0x400E3DE")]
    [FieldOffset(Offset = "0x4C")]
    private OInt mCommandFlag;
    [Token(Token = "0x400E3DF")]
    [FieldOffset(Offset = "0x60")]
    private OIntVector2 mGridPosition;
    [Token(Token = "0x400E3E0")]
    [FieldOffset(Offset = "0x88")]
    private OIntVector2 mGridPositionTurnStart;
    [Token(Token = "0x400E3E1")]
    [FieldOffset(Offset = "0xB0")]
    private OIntVector2 mGridPositionInit;
    [Token(Token = "0x400E3E2")]
    [FieldOffset(Offset = "0xD8")]
    private OInt mTurnStartDir;
    [Token(Token = "0x400E3E3")]
    [FieldOffset(Offset = "0xEC")]
    public EUnitDirection SkillStartDirection;
    [Token(Token = "0x400E3E4")]
    [FieldOffset(Offset = "0xF0")]
    public OIntVector2 TeleportStartPosition;
    [Token(Token = "0x400E3E5")]
    [FieldOffset(Offset = "0x118")]
    private NPCSetting mSettingNPC;
    [Token(Token = "0x400E3E6")]
    [FieldOffset(Offset = "0x11C")]
    private OInt mUnitIndex;
    [Token(Token = "0x400E3E7")]
    [FieldOffset(Offset = "0x130")]
    private OInt mSearched;
    [Token(Token = "0x400E3E8")]
    [FieldOffset(Offset = "0x144")]
    private BaseStatus mMaximumStatus;
    [Token(Token = "0x400E3E9")]
    [FieldOffset(Offset = "0x148")]
    private int mMaximumStatusHp;
    [Token(Token = "0x400E3EA")]
    [FieldOffset(Offset = "0x14C")]
    private BaseStatus mCurrentStatus;
    [Token(Token = "0x400E3EB")]
    [FieldOffset(Offset = "0x150")]
    private int mUnitChangedHp;
    [Token(Token = "0x400E3EC")]
    [FieldOffset(Offset = "0x154")]
    private List<AIParam> mAI;
    [Token(Token = "0x400E3ED")]
    [FieldOffset(Offset = "0x158")]
    private OInt mAITop;
    [Token(Token = "0x400E3EE")]
    [FieldOffset(Offset = "0x16C")]
    private AIActionTable mAIActionTable;
    [Token(Token = "0x400E3EF")]
    [FieldOffset(Offset = "0x170")]
    private OInt mAIActionIndex;
    [Token(Token = "0x400E3F0")]
    [FieldOffset(Offset = "0x184")]
    private OInt mAIActionTurnCount;
    [Token(Token = "0x400E3F1")]
    [FieldOffset(Offset = "0x198")]
    private AIPatrolTable mAIPatrolTable;
    [Token(Token = "0x400E3F2")]
    [FieldOffset(Offset = "0x19C")]
    private OInt mAIPatrolIndex;
    [Token(Token = "0x400E3F3")]
    [FieldOffset(Offset = "0x1B0")]
    private SkillData mAIForceSkill;
    [Token(Token = "0x400E3F4")]
    [FieldOffset(Offset = "0x1B4")]
    private MapBreakObj mBreakObj;
    [Token(Token = "0x400E3F5")]
    [FieldOffset(Offset = "0x1B8")]
    private string mCreateBreakObjId;
    [Token(Token = "0x400E3F6")]
    [FieldOffset(Offset = "0x1BC")]
    private int mCreateBreakObjClock;
    [Token(Token = "0x400E3F7")]
    [FieldOffset(Offset = "0x1C0")]
    private int mTeamId;
    [Token(Token = "0x400E3F8")]
    [FieldOffset(Offset = "0x1C4")]
    private FriendStates mFriendStates;
    [Token(Token = "0x400E3F9")]
    [FieldOffset(Offset = "0x1C8")]
    private OInt mKeepHp;
    [Token(Token = "0x400E3FA")]
    [FieldOffset(Offset = "0x1DC")]
    private int mInfinitySpawnTag;
    [Token(Token = "0x400E3FB")]
    [FieldOffset(Offset = "0x1E0")]
    private int mInfinitySpawnDeck;
    [Token(Token = "0x400E3FC")]
    [FieldOffset(Offset = "0x1E4")]
    private BaseStatus mMaximumStatusWithMap;
    [Token(Token = "0x400E3FD")]
    [FieldOffset(Offset = "0x1E8")]
    private OBool mNeedDead;
    [Token(Token = "0x400E3FE")]
    [FieldOffset(Offset = "0x1F4")]
    private DynamicTransformUnitParam mDtuParam;
    [Token(Token = "0x400E3FF")]
    [FieldOffset(Offset = "0x1F8")]
    private Unit mDtuFromUnit;
    [Token(Token = "0x400E400")]
    [FieldOffset(Offset = "0x1FC")]
    private int mDtuRemainTurn;
    [Token(Token = "0x400E401")]
    [FieldOffset(Offset = "0x200")]
    private int mOverKillDamage;
    [Token(Token = "0x400E402")]
    [FieldOffset(Offset = "0x204")]
    private List<BuffAttachment> mBuffAttachments;
    [Token(Token = "0x400E403")]
    [FieldOffset(Offset = "0x208")]
    private List<CondAttachment> mCondAttachments;
    [Token(Token = "0x400E404")]
    [FieldOffset(Offset = "0x210")]
    private OLong mCurrentCondition;
    [Token(Token = "0x400E405")]
    [FieldOffset(Offset = "0x238")]
    private OLong mDisableCondition;
    [Token(Token = "0x400E406")]
    [FieldOffset(Offset = "0x260")]
    public Unit Target;
    [Token(Token = "0x400E407")]
    [FieldOffset(Offset = "0x264")]
    public Grid TreasureGainTarget;
    [Token(Token = "0x400E408")]
    [FieldOffset(Offset = "0x268")]
    public EUnitDirection Direction;
    [Token(Token = "0x400E409")]
    [FieldOffset(Offset = "0x26C")]
    public bool IsPartyMember;
    [Token(Token = "0x400E40A")]
    [FieldOffset(Offset = "0x26D")]
    public bool IsSub;
    [Token(Token = "0x400E40B")]
    [FieldOffset(Offset = "0x26E")]
    private bool mIsRaidBoss;
    [Token(Token = "0x400E40C")]
    [FieldOffset(Offset = "0x270")]
    private Unit.UnitDrop mDrop;
    [Token(Token = "0x400E40D")]
    [FieldOffset(Offset = "0x274")]
    private bool mIsWithdrawDrop;
    [Token(Token = "0x400E40E")]
    [FieldOffset(Offset = "0x278")]
    private Unit.UnitSteal mSteal;
    [Token(Token = "0x400E40F")]
    [FieldOffset(Offset = "0x27C")]
    private List<Unit.UnitShield> mShields;
    [Token(Token = "0x400E410")]
    [FieldOffset(Offset = "0x280")]
    private List<Unit.UnitMhmDamage> mMhmDamageLists;
    [Token(Token = "0x400E411")]
    [FieldOffset(Offset = "0x284")]
    private List<Unit.UnitInsp> mInspInsList;
    [Token(Token = "0x400E412")]
    [FieldOffset(Offset = "0x288")]
    private List<Unit.UnitInsp> mInspUseList;
    [Token(Token = "0x400E413")]
    [FieldOffset(Offset = "0x28C")]
    private List<Unit.UnitForcedTargeting> mFtgtTargetList;
    [Token(Token = "0x400E414")]
    [FieldOffset(Offset = "0x290")]
    private List<Unit.UnitForcedTargeting> mFtgtFromList;
    [Token(Token = "0x400E415")]
    [FieldOffset(Offset = "0x294")]
    private EventTrigger mEventTrigger;
    [Token(Token = "0x400E416")]
    [FieldOffset(Offset = "0x298")]
    private List<UnitEntryTrigger> mEntryTriggers;
    [Token(Token = "0x400E417")]
    [FieldOffset(Offset = "0x29C")]
    private OBool mEntryTriggerAndCheck;
    [Token(Token = "0x400E418")]
    [FieldOffset(Offset = "0x2A8")]
    private OInt mWaitEntryClock;
    [Token(Token = "0x400E419")]
    [FieldOffset(Offset = "0x2BC")]
    private OInt mMoveWaitTurn;
    [Token(Token = "0x400E41A")]
    [FieldOffset(Offset = "0x2D0")]
    private OInt mActionCount;
    [Token(Token = "0x400E41B")]
    [FieldOffset(Offset = "0x2E4")]
    private OInt mDeathCount;
    [Token(Token = "0x400E41C")]
    [FieldOffset(Offset = "0x2F8")]
    private OInt mAutoJewel;
    [Token(Token = "0x400E41D")]
    [FieldOffset(Offset = "0x30C")]
    private OInt mChargeTime;
    [Token(Token = "0x400E41E")]
    [FieldOffset(Offset = "0x320")]
    private SkillData mCastSkill;
    [Token(Token = "0x400E41F")]
    [FieldOffset(Offset = "0x324")]
    private OInt mCastTime;
    [Token(Token = "0x400E420")]
    [FieldOffset(Offset = "0x338")]
    private OInt mCastIndex;
    [Token(Token = "0x400E421")]
    [FieldOffset(Offset = "0x34C")]
    private Unit mUnitTarget;
    [Token(Token = "0x400E422")]
    [FieldOffset(Offset = "0x350")]
    private Grid mGridTarget;
    [Token(Token = "0x400E423")]
    [FieldOffset(Offset = "0x354")]
    private GridMap<bool> mCastSkillGridMap;
    [Token(Token = "0x400E424")]
    [FieldOffset(Offset = "0x358")]
    private List<Unit.UnitProtect> mProtects;
    [Token(Token = "0x400E425")]
    [FieldOffset(Offset = "0x35C")]
    private List<Unit.UnitProtect> mGuards;
    [Token(Token = "0x400E426")]
    [FieldOffset(Offset = "0x360")]
    private int mProtectDamageCount;
    [Token(Token = "0x400E427")]
    [FieldOffset(Offset = "0x364")]
    private Dictionary<SkillData, OInt> mSkillUseCount;
    [Token(Token = "0x400E428")]
    [FieldOffset(Offset = "0x368")]
    private List<SkillData> mJudgeHpLists;
    [Token(Token = "0x400E429")]
    [FieldOffset(Offset = "0x36C")]
    private string mParentUniqueName;
    [Token(Token = "0x400E42A")]
    [FieldOffset(Offset = "0x370")]
    private int mTowerStartHP;
    [Token(Token = "0x400E42B")]
    [FieldOffset(Offset = "0x374")]
    public List<OString> mNotifyUniqueNames;
    [Token(Token = "0x400E42C")]
    [FieldOffset(Offset = "0x378")]
    private int mKillCount;
    [Token(Token = "0x400E42D")]
    [FieldOffset(Offset = "0x37C")]
    private bool mDropDirection;
    [Token(Token = "0x400E42E")]
    [FieldOffset(Offset = "0x380")]
    private string[] mTags;
    [Token(Token = "0x400E42F")]
    [FieldOffset(Offset = "0x384")]
    private List<Unit.AbilityChange> mAbilityChangeLists;
    [Token(Token = "0x400E430")]
    [FieldOffset(Offset = "0x388")]
    private List<AbilityData> mBattleAbilitys;
    [Token(Token = "0x400E431")]
    [FieldOffset(Offset = "0x38C")]
    private List<SkillData> mBattleSkills;
    [Token(Token = "0x400E432")]
    [FieldOffset(Offset = "0x390")]
    private List<AbilityData> mAddedAbilitys;
    [Token(Token = "0x400E433")]
    [FieldOffset(Offset = "0x394")]
    private List<SkillData> mAddedSkills;
    [Token(Token = "0x400E434")]
    [FieldOffset(Offset = "0x398")]
    private List<SkillData> mAdditionalSkills;
    [Token(Token = "0x400E435")]
    [FieldOffset(Offset = "0x39C")]
    private List<SkillData> mRevivalAddSkills;
    [Token(Token = "0x400E436")]
    [FieldOffset(Offset = "0x3A0")]
    private List<SkillData> mAutoHpJudgeAddSkills;
    [Token(Token = "0x400E437")]
    [FieldOffset(Offset = "0x3A4")]
    private List<Unit.UnitRevival> mSkillRevivalList;
    [Token(Token = "0x400E438")]
    [FieldOffset(Offset = "0x3A8")]
    private List<Unit.UnitAutoHpJudge> mSkillAutoHpJudgeList;
    [Token(Token = "0x400E439")]
    [FieldOffset(Offset = "0x3AC")]
    private List<Unit.UnitManipulate> mSkillManipulateList;
    [Token(Token = "0x400E43A")]
    [FieldOffset(Offset = "0x3B0")]
    private List<SkillManipulatePierceParam> mSkillManipulatePierceSaveList;
    [Token(Token = "0x400E43B")]
    [FieldOffset(Offset = "0x3B4")]
    private List<Unit.UnitSkillDistance> mSkillDistanceList;
    [Token(Token = "0x400E43C")]
    [FieldOffset(Offset = "0x3B8")]
    public int OwnerPlayerIndex;
    [Token(Token = "0x400E43D")]
    [FieldOffset(Offset = "0x3BC")]
    private int mTurnCount;
    [Token(Token = "0x400E43E")]
    [FieldOffset(Offset = "0x3C0")]
    private bool mEntryUnit;
    [Token(Token = "0x400E43F")]
    [FieldOffset(Offset = "0x5C")]
    private static BaseStatus LapBossBuffAdd;
    [Token(Token = "0x400E440")]
    [FieldOffset(Offset = "0x60")]
    private static BaseStatus LapBossBuffNad;
    [Token(Token = "0x400E441")]
    [FieldOffset(Offset = "0x64")]
    private static BaseStatus LapBossBuffScl;
    [Token(Token = "0x400E442")]
    [FieldOffset(Offset = "0x68")]
    private static BaseStatus LapBossDebuffAdd;
    [Token(Token = "0x400E443")]
    [FieldOffset(Offset = "0x6C")]
    private static BaseStatus LapBossDebuffNad;
    [Token(Token = "0x400E444")]
    [FieldOffset(Offset = "0x70")]
    private static BaseStatus LapBossDebuffScl;
    [Token(Token = "0x400E445")]
    [FieldOffset(Offset = "0x74")]
    private static uint mCondLinkageID;
    [Token(Token = "0x400E446")]
    [FieldOffset(Offset = "0x3C4")]
    public BuffBit CondLinkageBuff;
    [Token(Token = "0x400E447")]
    [FieldOffset(Offset = "0x3C8")]
    public BuffBit CondLinkageDebuff;
    [Token(Token = "0x400E448")]
    [FieldOffset(Offset = "0x3CC")]
    private SkillData mPushCastSkill;
    [Token(Token = "0x400E449")]
    [FieldOffset(Offset = "0x78")]
    private static readonly Dictionary<ParamTypes, BattleBonus> ResistStatusBuffDic;
    [Token(Token = "0x400E44A")]
    [FieldOffset(Offset = "0x7C")]
    private static readonly Dictionary<ParamTypes, BattleBonus> ResistStatusDebuffDic;
    [Token(Token = "0x400E44C")]
    [FieldOffset(Offset = "0x3D4")]
    private MySound.Voice mBattleVoice;
    [Token(Token = "0x400E44D")]
    public const int BOSS_PROVISIONAL_HP = 1000000000;
    [Token(Token = "0x400E44E")]
    [FieldOffset(Offset = "0x3D8")]
    private long mBossLongBaseMaxHP;
    [Token(Token = "0x400E44F")]
    [FieldOffset(Offset = "0x3E0")]
    private long mBossLongMaxHP;
    [Token(Token = "0x400E450")]
    [FieldOffset(Offset = "0x3E8")]
    private long mBossLongCurHP;
    [Token(Token = "0x400E451")]
    [FieldOffset(Offset = "0x80")]
    private static BaseStatus BuffWorkStatus;
    [Token(Token = "0x400E452")]
    [FieldOffset(Offset = "0x84")]
    private static BaseStatus BuffWorkScaleStatus;
    [Token(Token = "0x400E453")]
    [FieldOffset(Offset = "0x88")]
    private static BaseStatus DebuffWorkScaleStatus;
    [Token(Token = "0x400E454")]
    [FieldOffset(Offset = "0x8C")]
    private static BaseStatus PassiveWorkScaleStatus;
    [Token(Token = "0x400E455")]
    [FieldOffset(Offset = "0x90")]
    private static BaseStatus BuffDupliScaleStatus;
    [Token(Token = "0x400E456")]
    [FieldOffset(Offset = "0x94")]
    private static BaseStatus DebuffDupliScaleStatus;
    [Token(Token = "0x400E457")]
    [FieldOffset(Offset = "0x98")]
    private static BaseStatus BuffConceptCardStatus;
    [Token(Token = "0x400E458")]
    [FieldOffset(Offset = "0x9C")]
    private static BaseStatus DebuffConceptCardStatus;
    [Token(Token = "0x400E459")]
    [FieldOffset(Offset = "0xA0")]
    private static BaseStatus BuffConceptCardScaleStatus;
    [Token(Token = "0x400E45A")]
    [FieldOffset(Offset = "0xA4")]
    private static BaseStatus DebuffConceptCardScaleStatus;
    [Token(Token = "0x400E45B")]
    [FieldOffset(Offset = "0xA8")]
    private static BaseStatus DupliConceptCardStatus;
    [Token(Token = "0x400E45C")]
    [FieldOffset(Offset = "0x3F0")]
    private Unit mRageTarget;

    [Token(Token = "0x17001BE9")]
    public static string[] StrNameUnitConds
    {
      [Token(Token = "0x600D4B9"), Address(RVA = "0xA23160", Offset = "0xA21F60", VA = "0x10A23160")] get
      {
        return (string[]) null;
      }
    }

    [Token(Token = "0x17001BEA")]
    public static string[] StrDescUnitConds
    {
      [Token(Token = "0x600D4BA"), Address(RVA = "0xA23120", Offset = "0xA21F20", VA = "0x10A23120")] get
      {
        return (string[]) null;
      }
    }

    [Token(Token = "0x17001BEB")]
    public OInt AIActionIndex
    {
      [Token(Token = "0x600D4BB"), Address(RVA = "0xA21B30", Offset = "0xA20930", VA = "0x10A21B30")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17001BEC")]
    public OInt AIActionTurnCount
    {
      [Token(Token = "0x600D4BC"), Address(RVA = "0xA21B50", Offset = "0xA20950", VA = "0x10A21B50")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17001BED")]
    public OInt AIPatrolIndex
    {
      [Token(Token = "0x600D4BD"), Address(RVA = "0xA21B80", Offset = "0xA20980", VA = "0x10A21B80")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17001BEE")]
    public bool IsNPC
    {
      [Token(Token = "0x600D4BE"), Address(RVA = "0xA22B90", Offset = "0xA21990", VA = "0x10A22B90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001BEF")]
    public bool IsRaidBoss
    {
      [Token(Token = "0x600D4BF"), Address(RVA = "0xA22C70", Offset = "0xA21A70", VA = "0x10A22C70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001BF0")]
    public bool IsWithdrawDrop
    {
      [Token(Token = "0x600D4C0"), Address(RVA = "0xA22D30", Offset = "0xA21B30", VA = "0x10A22D30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001BF1")]
    private string[] Tags
    {
      [Token(Token = "0x600D4C1"), Address(RVA = "0xA231A0", Offset = "0xA21FA0", VA = "0x10A231A0")] get
      {
        return (string[]) null;
      }
    }

    [Token(Token = "0x17001BF2")]
    public int Gems
    {
      [Token(Token = "0x600D4C2"), Address(RVA = "0xA24110", Offset = "0xA22F10", VA = "0x10A24110")] set
      {
      }
      [Token(Token = "0x600D4C3"), Address(RVA = "0xA223D0", Offset = "0xA211D0", VA = "0x10A223D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001BF3")]
    public int WaitClock
    {
      [Token(Token = "0x600D4C4"), Address(RVA = "0xA24370", Offset = "0xA23170", VA = "0x10A24370")] set
      {
      }
      [Token(Token = "0x600D4C5"), Address(RVA = "0xA234B0", Offset = "0xA222B0", VA = "0x10A234B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001BF4")]
    public int WaitMoveTurn
    {
      [Token(Token = "0x600D4C6"), Address(RVA = "0xA243B0", Offset = "0xA231B0", VA = "0x10A243B0")] set
      {
      }
      [Token(Token = "0x600D4C7"), Address(RVA = "0xA234E0", Offset = "0xA222E0", VA = "0x10A234E0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600D4C8")]
    [Address(RVA = "0x3494B0", Offset = "0x3482B0", VA = "0x103494B0")]
    public Dictionary<SkillData, OInt> GetSkillUseCount() => (Dictionary<SkillData, OInt>) null;

    [Token(Token = "0x17001BF5")]
    public List<SkillData> JudgeHpLists
    {
      [Token(Token = "0x600D4C9"), Address(RVA = "0x3494C0", Offset = "0x3482C0", VA = "0x103494C0")] get
      {
        return (List<SkillData>) null;
      }
    }

    [Token(Token = "0x17001BF6")]
    public int TurnCount
    {
      [Token(Token = "0x600D4CA"), Address(RVA = "0x349560", Offset = "0x348360", VA = "0x10349560")] get
      {
        return new int();
      }
      [Token(Token = "0x600D4CB"), Address(RVA = "0xA242D0", Offset = "0xA230D0", VA = "0x10A242D0")] set
      {
      }
    }

    [Token(Token = "0x17001BF7")]
    public bool EntryUnit
    {
      [Token(Token = "0x600D4CC"), Address(RVA = "0xA22310", Offset = "0xA21110", VA = "0x10A22310")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001BF8")]
    public string UniqueName
    {
      [Token(Token = "0x600D4CD"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001BF9")]
    public string UnitName
    {
      [Token(Token = "0x600D4CE"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600D4CF"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] set
      {
      }
    }

    [Token(Token = "0x17001BFA")]
    public UnitData UnitData
    {
      [Token(Token = "0x600D4D0"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001BFB")]
    public UnitParam UnitParam
    {
      [Token(Token = "0x600D4D1"), Address(RVA = "0xA23460", Offset = "0xA22260", VA = "0x10A23460")] get
      {
        return (UnitParam) null;
      }
    }

    [Token(Token = "0x17001BFC")]
    public EUnitType UnitType
    {
      [Token(Token = "0x600D4D2"), Address(RVA = "0xA23480", Offset = "0xA22280", VA = "0x10A23480")] get
      {
        return new EUnitType();
      }
    }

    [Token(Token = "0x17001BFD")]
    public int Lv
    {
      [Token(Token = "0x600D4D3"), Address(RVA = "0xA22DF0", Offset = "0xA21BF0", VA = "0x10A22DF0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001BFE")]
    public JobData Job
    {
      [Token(Token = "0x600D4D4"), Address(RVA = "0xA22D70", Offset = "0xA21B70", VA = "0x10A22D70")] get
      {
        return (JobData) null;
      }
    }

    [Token(Token = "0x17001BFF")]
    public SkillData LeaderSkill
    {
      [Token(Token = "0x600D4D5"), Address(RVA = "0xA22DC0", Offset = "0xA21BC0", VA = "0x10A22DC0")] get
      {
        return (SkillData) null;
      }
    }

    [Token(Token = "0x17001C00")]
    public List<AbilityData> BattleAbilitys
    {
      [Token(Token = "0x600D4D6"), Address(RVA = "0xA21CB0", Offset = "0xA20AB0", VA = "0x10A21CB0")] get
      {
        return (List<AbilityData>) null;
      }
    }

    [Token(Token = "0x17001C01")]
    public List<SkillData> BattleSkills
    {
      [Token(Token = "0x600D4D7"), Address(RVA = "0xA21CE0", Offset = "0xA20AE0", VA = "0x10A21CE0")] get
      {
        return (List<SkillData>) null;
      }
    }

    [Token(Token = "0x17001C02")]
    public List<BuffAttachment> BuffAttachments
    {
      [Token(Token = "0x600D4D8"), Address(RVA = "0x4782E0", Offset = "0x4770E0", VA = "0x104782E0")] get
      {
        return (List<BuffAttachment>) null;
      }
    }

    [Token(Token = "0x17001C03")]
    public List<CondAttachment> CondAttachments
    {
      [Token(Token = "0x600D4D9"), Address(RVA = "0xA22130", Offset = "0xA20F30", VA = "0x10A22130")] get
      {
        return (List<CondAttachment>) null;
      }
    }

    [Token(Token = "0x17001C04")]
    public EquipData[] CurrentEquips
    {
      [Token(Token = "0x600D4DA"), Address(RVA = "0xA22150", Offset = "0xA20F50", VA = "0x10A22150")] get
      {
        return (EquipData[]) null;
      }
    }

    [Token(Token = "0x17001C05")]
    public AIParam AI
    {
      [Token(Token = "0x600D4DB"), Address(RVA = "0xA21BA0", Offset = "0xA209A0", VA = "0x10A21BA0")] get
      {
        return (AIParam) null;
      }
    }

    [Token(Token = "0x17001C06")]
    public SkillData AIForceSkill
    {
      [Token(Token = "0x600D4DC"), Address(RVA = "0xA21B70", Offset = "0xA20970", VA = "0x10A21B70")] get
      {
        return (SkillData) null;
      }
    }

    [Token(Token = "0x17001C07")]
    public BaseStatus MaximumStatus
    {
      [Token(Token = "0x600D4DD"), Address(RVA = "0x349070", Offset = "0x347E70", VA = "0x10349070")] get
      {
        return (BaseStatus) null;
      }
    }

    [Token(Token = "0x17001C08")]
    public int MaximumStatusHp
    {
      [Token(Token = "0x600D4DE"), Address(RVA = "0x5E0360", Offset = "0x5DF160", VA = "0x105E0360")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001C09")]
    public BaseStatus CurrentStatus
    {
      [Token(Token = "0x600D4DF"), Address(RVA = "0x3B1300", Offset = "0x3B0100", VA = "0x103B1300")] get
      {
        return (BaseStatus) null;
      }
    }

    [Token(Token = "0x17001C0A")]
    public int UnitChangedHp
    {
      [Token(Token = "0x600D4E0"), Address(RVA = "0xA23400", Offset = "0xA22200", VA = "0x10A23400")] get
      {
        return new int();
      }
      [Token(Token = "0x600D4E1"), Address(RVA = "0xA242F0", Offset = "0xA230F0", VA = "0x10A242F0")] set
      {
      }
    }

    [Token(Token = "0x17001C0B")]
    public bool IsDead
    {
      [Token(Token = "0x600D4E2"), Address(RVA = "0xA225C0", Offset = "0xA213C0", VA = "0x10A225C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C0C")]
    public bool IsEntry
    {
      [Token(Token = "0x600D4E3"), Address(RVA = "0xA22620", Offset = "0xA21420", VA = "0x10A22620")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C0D")]
    public bool NeedDead
    {
      [Token(Token = "0x600D4E4"), Address(RVA = "0xA22FB0", Offset = "0xA21DB0", VA = "0x10A22FB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C0E")]
    public bool IsControl
    {
      [Token(Token = "0x600D4E5"), Address(RVA = "0xA22490", Offset = "0xA21290", VA = "0x10A22490")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C0F")]
    public bool IsGimmick
    {
      [Token(Token = "0x600D4E6"), Address(RVA = "0xA22AD0", Offset = "0xA218D0", VA = "0x10A22AD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C10")]
    public bool IsIntoUnit
    {
      [Token(Token = "0x600D4E7"), Address(RVA = "0xA22B00", Offset = "0xA21900", VA = "0x10A22B00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C11")]
    public bool IsJump
    {
      [Token(Token = "0x600D4E8"), Address(RVA = "0xA22B30", Offset = "0xA21930", VA = "0x10A22B30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C12")]
    public EUnitSide Side
    {
      [Token(Token = "0x600D4E9"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new EUnitSide();
      }
      [Token(Token = "0x600D4EA"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] set
      {
      }
    }

    [Token(Token = "0x17001C13")]
    public long UnitFlag
    {
      [Token(Token = "0x600D4EB"), Address(RVA = "0xA23410", Offset = "0xA22210", VA = "0x10A23410")] get
      {
        return new long();
      }
      [Token(Token = "0x600D4EC"), Address(RVA = "0xA24310", Offset = "0xA23110", VA = "0x10A24310")] set
      {
      }
    }

    [Token(Token = "0x17001C14")]
    public Unit.UnitDrop Drop
    {
      [Token(Token = "0x600D4ED"), Address(RVA = "0x349440", Offset = "0x348240", VA = "0x10349440")] get
      {
        return (Unit.UnitDrop) null;
      }
    }

    [Token(Token = "0x17001C15")]
    public Unit.UnitSteal Steal
    {
      [Token(Token = "0x600D4EE"), Address(RVA = "0xA23110", Offset = "0xA21F10", VA = "0x10A23110")] get
      {
        return (Unit.UnitSteal) null;
      }
    }

    [Token(Token = "0x17001C16")]
    public List<Unit.UnitShield> Shields
    {
      [Token(Token = "0x600D4EF"), Address(RVA = "0xA23070", Offset = "0xA21E70", VA = "0x10A23070")] get
      {
        return (List<Unit.UnitShield>) null;
      }
    }

    [Token(Token = "0x17001C17")]
    public List<Unit.UnitProtect> Protects
    {
      [Token(Token = "0x600D4F0"), Address(RVA = "0x349480", Offset = "0x348280", VA = "0x10349480")] get
      {
        return (List<Unit.UnitProtect>) null;
      }
    }

    [Token(Token = "0x17001C18")]
    public List<Unit.UnitProtect> Guards
    {
      [Token(Token = "0x600D4F1"), Address(RVA = "0x349450", Offset = "0x348250", VA = "0x10349450")] get
      {
        return (List<Unit.UnitProtect>) null;
      }
    }

    [Token(Token = "0x17001C19")]
    public int ProtectDamageCount
    {
      [Token(Token = "0x600D4F2"), Address(RVA = "0x349460", Offset = "0x348260", VA = "0x10349460")] get
      {
        return new int();
      }
      [Token(Token = "0x600D4F3"), Address(RVA = "0xA24250", Offset = "0xA23050", VA = "0x10A24250")] set
      {
      }
    }

    [Token(Token = "0x17001C1A")]
    public List<Unit.UnitMhmDamage> MhmDamageLists
    {
      [Token(Token = "0x600D4F4"), Address(RVA = "0x319810", Offset = "0x318610", VA = "0x10319810")] get
      {
        return (List<Unit.UnitMhmDamage>) null;
      }
    }

    [Token(Token = "0x17001C1B")]
    public List<Unit.UnitInsp> InspInsList
    {
      [Token(Token = "0x600D4F5"), Address(RVA = "0x349430", Offset = "0x348230", VA = "0x10349430")] get
      {
        return (List<Unit.UnitInsp>) null;
      }
    }

    [Token(Token = "0x17001C1C")]
    public List<Unit.UnitInsp> InspUseList
    {
      [Token(Token = "0x600D4F6"), Address(RVA = "0x349330", Offset = "0x348130", VA = "0x10349330")] get
      {
        return (List<Unit.UnitInsp>) null;
      }
    }

    [Token(Token = "0x17001C1D")]
    public List<Unit.UnitForcedTargeting> FtgtTargetList
    {
      [Token(Token = "0x600D4F7"), Address(RVA = "0x349340", Offset = "0x348140", VA = "0x10349340")] get
      {
        return (List<Unit.UnitForcedTargeting>) null;
      }
    }

    [Token(Token = "0x17001C1E")]
    public List<Unit.UnitForcedTargeting> FtgtFromList
    {
      [Token(Token = "0x600D4F8"), Address(RVA = "0xA223C0", Offset = "0xA211C0", VA = "0x10A223C0")] get
      {
        return (List<Unit.UnitForcedTargeting>) null;
      }
    }

    [Token(Token = "0x17001C1F")]
    private Unit.UnitForcedTargeting FtgtFromActive
    {
      [Token(Token = "0x600D4F9"), Address(RVA = "0xA22360", Offset = "0xA21160", VA = "0x10A22360")] get
      {
        return (Unit.UnitForcedTargeting) null;
      }
    }

    [Token(Token = "0x17001C20")]
    public Unit FtgtFromActiveUnit
    {
      [Token(Token = "0x600D4FA"), Address(RVA = "0xA22320", Offset = "0xA21120", VA = "0x10A22320")] get
      {
        return (Unit) null;
      }
    }

    [Token(Token = "0x17001C21")]
    public List<Unit.UnitRevival> RevivalList
    {
      [Token(Token = "0x600D4FB"), Address(RVA = "0x7446C0", Offset = "0x7434C0", VA = "0x107446C0")] get
      {
        return (List<Unit.UnitRevival>) null;
      }
    }

    [Token(Token = "0x17001C22")]
    public bool IsFindRevivalList
    {
      [Token(Token = "0x600D4FC"), Address(RVA = "0xA226B0", Offset = "0xA214B0", VA = "0x10A226B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C23")]
    public List<Unit.UnitAutoHpJudge> AutoHpJudgeSkillList
    {
      [Token(Token = "0x600D4FD"), Address(RVA = "0xA21C70", Offset = "0xA20A70", VA = "0x10A21C70")] get
      {
        return (List<Unit.UnitAutoHpJudge>) null;
      }
    }

    [Token(Token = "0x17001C24")]
    public bool IsFindAutoHpJudgeList
    {
      [Token(Token = "0x600D4FE"), Address(RVA = "0xA22670", Offset = "0xA21470", VA = "0x10A22670")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C25")]
    public List<Unit.UnitManipulate> SkillManipulate
    {
      [Token(Token = "0x600D4FF"), Address(RVA = "0x7446D0", Offset = "0x7434D0", VA = "0x107446D0")] get
      {
        return (List<Unit.UnitManipulate>) null;
      }
    }

    [Token(Token = "0x17001C26")]
    public bool IsFindSkillManipulateList
    {
      [Token(Token = "0x600D500"), Address(RVA = "0xA22950", Offset = "0xA21750", VA = "0x10A22950")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C27")]
    public List<SkillManipulatePierceParam> SkillManipulateBreak
    {
      [Token(Token = "0x600D501"), Address(RVA = "0x3493B0", Offset = "0x3481B0", VA = "0x103493B0")] get
      {
        return (List<SkillManipulatePierceParam>) null;
      }
    }

    [Token(Token = "0x17001C28")]
    public bool IsFindSkillManipulateBreakList
    {
      [Token(Token = "0x600D502"), Address(RVA = "0xA22910", Offset = "0xA21710", VA = "0x10A22910")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C29")]
    public List<Unit.UnitSkillDistance> SkillDistanceList
    {
      [Token(Token = "0x600D503"), Address(RVA = "0x349510", Offset = "0x348310", VA = "0x10349510")] get
      {
        return (List<Unit.UnitSkillDistance>) null;
      }
    }

    [Token(Token = "0x17001C2A")]
    public bool IsFindSkillDistanceList
    {
      [Token(Token = "0x600D504"), Address(RVA = "0xA228D0", Offset = "0xA216D0", VA = "0x10A228D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C2B")]
    public bool IsFindSkillDistanceListBuff
    {
      [Token(Token = "0x600D505"), Address(RVA = "0xA226F0", Offset = "0xA214F0", VA = "0x10A226F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C2C")]
    public bool IsFindSkillDistanceListDebuff
    {
      [Token(Token = "0x600D506"), Address(RVA = "0xA227E0", Offset = "0xA215E0", VA = "0x10A227E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C2D")]
    public int DisableMoveGridHeight
    {
      [Token(Token = "0x600D507"), Address(RVA = "0xA221B0", Offset = "0xA20FB0", VA = "0x10A221B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001C2E")]
    public EElement Element
    {
      [Token(Token = "0x600D508"), Address(RVA = "0xA222E0", Offset = "0xA210E0", VA = "0x10A222E0")] get
      {
        return new EElement();
      }
    }

    [Token(Token = "0x17001C2F")]
    public int ElementPlus
    {
      [Token(Token = "0x600D509"), Address(RVA = "0xA222C0", Offset = "0xA210C0", VA = "0x10A222C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001C30")]
    public JobTypes JobType
    {
      [Token(Token = "0x600D50A"), Address(RVA = "0xA22D40", Offset = "0xA21B40", VA = "0x10A22D40")] get
      {
        return new JobTypes();
      }
    }

    [Token(Token = "0x17001C31")]
    public RoleTypes RoleType
    {
      [Token(Token = "0x600D50B"), Address(RVA = "0xA23040", Offset = "0xA21E40", VA = "0x10A23040")] get
      {
        return new RoleTypes();
      }
    }

    [Token(Token = "0x17001C32")]
    public int x
    {
      [Token(Token = "0x600D50C"), Address(RVA = "0xA23600", Offset = "0xA22400", VA = "0x10A23600")] get
      {
        return new int();
      }
      [Token(Token = "0x600D50D"), Address(RVA = "0xA24530", Offset = "0xA23330", VA = "0x10A24530")] set
      {
      }
    }

    [Token(Token = "0x17001C33")]
    public int y
    {
      [Token(Token = "0x600D50E"), Address(RVA = "0xA23630", Offset = "0xA22430", VA = "0x10A23630")] get
      {
        return new int();
      }
      [Token(Token = "0x600D50F"), Address(RVA = "0xA24560", Offset = "0xA23360", VA = "0x10A24560")] set
      {
      }
    }

    [Token(Token = "0x17001C34")]
    public int initX
    {
      [Token(Token = "0x600D510"), Address(RVA = "0xA23510", Offset = "0xA22310", VA = "0x10A23510")] get
      {
        return new int();
      }
      [Token(Token = "0x600D511"), Address(RVA = "0xA243F0", Offset = "0xA231F0", VA = "0x10A243F0")] set
      {
      }
    }

    [Token(Token = "0x17001C35")]
    public int initY
    {
      [Token(Token = "0x600D512"), Address(RVA = "0xA23540", Offset = "0xA22340", VA = "0x10A23540")] get
      {
        return new int();
      }
      [Token(Token = "0x600D513"), Address(RVA = "0xA24430", Offset = "0xA23230", VA = "0x10A24430")] set
      {
      }
    }

    [Token(Token = "0x17001C36")]
    public int startX
    {
      [Token(Token = "0x600D514"), Address(RVA = "0xA235A0", Offset = "0xA223A0", VA = "0x10A235A0")] get
      {
        return new int();
      }
      [Token(Token = "0x600D515"), Address(RVA = "0xA244B0", Offset = "0xA232B0", VA = "0x10A244B0")] set
      {
      }
    }

    [Token(Token = "0x17001C37")]
    public int startY
    {
      [Token(Token = "0x600D516"), Address(RVA = "0xA235D0", Offset = "0xA223D0", VA = "0x10A235D0")] get
      {
        return new int();
      }
      [Token(Token = "0x600D517"), Address(RVA = "0xA244F0", Offset = "0xA232F0", VA = "0x10A244F0")] set
      {
      }
    }

    [Token(Token = "0x17001C38")]
    public EUnitDirection startDir
    {
      [Token(Token = "0x600D518"), Address(RVA = "0xA23570", Offset = "0xA22370", VA = "0x10A23570")] get
      {
        return new EUnitDirection();
      }
      [Token(Token = "0x600D519"), Address(RVA = "0xA24470", Offset = "0xA23270", VA = "0x10A24470")] set
      {
      }
    }

    [Token(Token = "0x17001C39")]
    public NPCSetting SettingNPC
    {
      [Token(Token = "0x600D51A"), Address(RVA = "0x3495C0", Offset = "0x3483C0", VA = "0x103495C0")] get
      {
        return (NPCSetting) null;
      }
    }

    [Token(Token = "0x17001C3A")]
    public int SizeX
    {
      [Token(Token = "0x600D51B"), Address(RVA = "0xA23080", Offset = "0xA21E80", VA = "0x10A23080")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001C3B")]
    public int SizeY
    {
      [Token(Token = "0x600D51C"), Address(RVA = "0xA230B0", Offset = "0xA21EB0", VA = "0x10A230B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001C3C")]
    public int SizeZ
    {
      [Token(Token = "0x600D51D"), Address(RVA = "0xA230E0", Offset = "0xA21EE0", VA = "0x10A230E0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001C3D")]
    public float OffsZ
    {
      [Token(Token = "0x600D51E"), Address(RVA = "0xA22FE0", Offset = "0xA21DE0", VA = "0x10A22FE0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001C3E")]
    public int MinColX
    {
      [Token(Token = "0x600D51F"), Address(RVA = "0xA22EC0", Offset = "0xA21CC0", VA = "0x10A22EC0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001C3F")]
    public int MaxColX
    {
      [Token(Token = "0x600D520"), Address(RVA = "0xA22E20", Offset = "0xA21C20", VA = "0x10A22E20")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001C40")]
    public int MinColY
    {
      [Token(Token = "0x600D521"), Address(RVA = "0xA22F00", Offset = "0xA21D00", VA = "0x10A22F00")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001C41")]
    public int MaxColY
    {
      [Token(Token = "0x600D522"), Address(RVA = "0xA22E70", Offset = "0xA21C70", VA = "0x10A22E70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001C42")]
    public EventTrigger EventTrigger
    {
      [Token(Token = "0x600D523"), Address(RVA = "0x349030", Offset = "0x347E30", VA = "0x10349030")] get
      {
        return (EventTrigger) null;
      }
    }

    [Token(Token = "0x17001C43")]
    public List<UnitEntryTrigger> EntryTriggers
    {
      [Token(Token = "0x600D524"), Address(RVA = "0x349250", Offset = "0x348050", VA = "0x10349250")] get
      {
        return (List<UnitEntryTrigger>) null;
      }
    }

    [Token(Token = "0x17001C44")]
    public OBool IsEntryTriggerAndCheck
    {
      [Token(Token = "0x600D525"), Address(RVA = "0xA22600", Offset = "0xA21400", VA = "0x10A22600")] get
      {
        return new OBool();
      }
    }

    [Token(Token = "0x17001C45")]
    public int ActionCount
    {
      [Token(Token = "0x600D526"), Address(RVA = "0xA21C30", Offset = "0xA20A30", VA = "0x10A21C30")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001C46")]
    public int DeathCount
    {
      [Token(Token = "0x600D527"), Address(RVA = "0xA22180", Offset = "0xA20F80", VA = "0x10A22180")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001C47")]
    public int AutoJewel
    {
      [Token(Token = "0x600D528"), Address(RVA = "0xA21C80", Offset = "0xA20A80", VA = "0x10A21C80")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001C48")]
    public OInt ChargeTime
    {
      [Token(Token = "0x600D529"), Address(RVA = "0xA22110", Offset = "0xA20F10", VA = "0x10A22110")] get
      {
        return new OInt();
      }
      [Token(Token = "0x600D52A"), Address(RVA = "0xA24070", Offset = "0xA22E70", VA = "0x10A24070")] set
      {
      }
    }

    [Token(Token = "0x17001C49")]
    public OInt ChargeTimeMax
    {
      [Token(Token = "0x600D52B"), Address(RVA = "0xA21FA0", Offset = "0xA20DA0", VA = "0x10A21FA0")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17001C4A")]
    public SkillData CastSkill
    {
      [Token(Token = "0x600D52C"), Address(RVA = "0x6DA850", Offset = "0x6D9650", VA = "0x106DA850")] get
      {
        return (SkillData) null;
      }
    }

    [Token(Token = "0x17001C4B")]
    public OInt CastTimeMax
    {
      [Token(Token = "0x600D52D"), Address(RVA = "0xA21E10", Offset = "0xA20C10", VA = "0x10A21E10")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17001C4C")]
    public OInt CastTime
    {
      [Token(Token = "0x600D52E"), Address(RVA = "0xA21F80", Offset = "0xA20D80", VA = "0x10A21F80")] get
      {
        return new OInt();
      }
      [Token(Token = "0x600D52F"), Address(RVA = "0xA24050", Offset = "0xA22E50", VA = "0x10A24050")] set
      {
      }
    }

    [Token(Token = "0x17001C4D")]
    public OInt CastIndex
    {
      [Token(Token = "0x600D530"), Address(RVA = "0xA21DF0", Offset = "0xA20BF0", VA = "0x10A21DF0")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17001C4E")]
    public Unit UnitTarget
    {
      [Token(Token = "0x600D531"), Address(RVA = "0x349060", Offset = "0x347E60", VA = "0x10349060")] get
      {
        return (Unit) null;
      }
      [Token(Token = "0x600D532"), Address(RVA = "0xA24350", Offset = "0xA23150", VA = "0x10A24350")] set
      {
      }
    }

    [Token(Token = "0x17001C4F")]
    public Grid GridTarget
    {
      [Token(Token = "0x600D533"), Address(RVA = "0x349490", Offset = "0x348290", VA = "0x10349490")] get
      {
        return (Grid) null;
      }
      [Token(Token = "0x600D534"), Address(RVA = "0xA241B0", Offset = "0xA22FB0", VA = "0x10A241B0")] set
      {
      }
    }

    [Token(Token = "0x17001C50")]
    public GridMap<bool> CastSkillGridMap
    {
      [Token(Token = "0x600D535"), Address(RVA = "0x3494A0", Offset = "0x3482A0", VA = "0x103494A0")] get
      {
        return (GridMap<bool>) null;
      }
      [Token(Token = "0x600D536"), Address(RVA = "0xA24030", Offset = "0xA22E30", VA = "0x10A24030")] set
      {
      }
    }

    [Token(Token = "0x17001C51")]
    public OInt UnitIndex
    {
      [Token(Token = "0x600D537"), Address(RVA = "0xA23440", Offset = "0xA22240", VA = "0x10A23440")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17001C52")]
    public string ParentUniqueName
    {
      [Token(Token = "0x600D538"), Address(RVA = "0x3494F0", Offset = "0x3482F0", VA = "0x103494F0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001C53")]
    public List<OString> NotifyUniqueNames
    {
      [Token(Token = "0x600D539"), Address(RVA = "0x3494D0", Offset = "0x3482D0", VA = "0x103494D0")] get
      {
        return (List<OString>) null;
      }
    }

    [Token(Token = "0x17001C54")]
    public int TowerStartHP
    {
      [Token(Token = "0x600D53A"), Address(RVA = "0x349470", Offset = "0x348270", VA = "0x10349470")] get
      {
        return new int();
      }
      [Token(Token = "0x600D53B"), Address(RVA = "0xA242B0", Offset = "0xA230B0", VA = "0x10A242B0")] set
      {
      }
    }

    [Token(Token = "0x17001C55")]
    public int KillCount
    {
      [Token(Token = "0x600D53C"), Address(RVA = "0x3494E0", Offset = "0x3482E0", VA = "0x103494E0")] get
      {
        return new int();
      }
      [Token(Token = "0x600D53D"), Address(RVA = "0xA24230", Offset = "0xA23030", VA = "0x10A24230")] set
      {
      }
    }

    [Token(Token = "0x17001C56")]
    public bool IsBreakObj
    {
      [Token(Token = "0x600D53E"), Address(RVA = "0xA22430", Offset = "0xA21230", VA = "0x10A22430")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C57")]
    public eMapBreakClashType BreakObjClashType
    {
      [Token(Token = "0x600D53F"), Address(RVA = "0xA21D90", Offset = "0xA20B90", VA = "0x10A21D90")] get
      {
        return new eMapBreakClashType();
      }
    }

    [Token(Token = "0x17001C58")]
    public eMapBreakAIType BreakObjAIType
    {
      [Token(Token = "0x600D540"), Address(RVA = "0xA21D70", Offset = "0xA20B70", VA = "0x10A21D70")] get
      {
        return new eMapBreakAIType();
      }
    }

    [Token(Token = "0x17001C59")]
    public eMapBreakSideType BreakObjSideType
    {
      [Token(Token = "0x600D541"), Address(RVA = "0xA21DD0", Offset = "0xA20BD0", VA = "0x10A21DD0")] get
      {
        return new eMapBreakSideType();
      }
    }

    [Token(Token = "0x17001C5A")]
    public eMapBreakRayType BreakObjRayType
    {
      [Token(Token = "0x600D542"), Address(RVA = "0xA21DB0", Offset = "0xA20BB0", VA = "0x10A21DB0")] get
      {
        return new eMapBreakRayType();
      }
    }

    [Token(Token = "0x17001C5B")]
    public bool IsBreakDispUI
    {
      [Token(Token = "0x600D543"), Address(RVA = "0xA22410", Offset = "0xA21210", VA = "0x10A22410")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C5C")]
    public string CreateBreakObjId
    {
      [Token(Token = "0x600D544"), Address(RVA = "0xA22140", Offset = "0xA20F40", VA = "0x10A22140")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001C5D")]
    public int CreateBreakObjClock
    {
      [Token(Token = "0x600D545"), Address(RVA = "0x33F220", Offset = "0x33E020", VA = "0x1033F220")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001C5E")]
    public int TeamId
    {
      [Token(Token = "0x600D546"), Address(RVA = "0x349240", Offset = "0x348040", VA = "0x10349240")] get
      {
        return new int();
      }
      [Token(Token = "0x600D547"), Address(RVA = "0xA24290", Offset = "0xA23090", VA = "0x10A24290")] set
      {
      }
    }

    [Token(Token = "0x17001C5F")]
    public FriendStates FriendStates
    {
      [Token(Token = "0x600D548"), Address(RVA = "0x33F3B0", Offset = "0x33E1B0", VA = "0x1033F3B0")] get
      {
        return new FriendStates();
      }
      [Token(Token = "0x600D549"), Address(RVA = "0xA240F0", Offset = "0xA22EF0", VA = "0x10A240F0")] set
      {
      }
    }

    [Token(Token = "0x17001C60")]
    public OInt KeepHp
    {
      [Token(Token = "0x600D54A"), Address(RVA = "0xA22DA0", Offset = "0xA21BA0", VA = "0x10A22DA0")] get
      {
        return new OInt();
      }
      [Token(Token = "0x600D54B"), Address(RVA = "0xA24210", Offset = "0xA23010", VA = "0x10A24210")] set
      {
      }
    }

    [Token(Token = "0x17001C61")]
    public int InfinitySpawnTag
    {
      [Token(Token = "0x600D54C"), Address(RVA = "0xA22400", Offset = "0xA21200", VA = "0x10A22400")] get
      {
        return new int();
      }
      [Token(Token = "0x600D54D"), Address(RVA = "0xA241F0", Offset = "0xA22FF0", VA = "0x10A241F0")] set
      {
      }
    }

    [Token(Token = "0x17001C62")]
    public int InfinitySpawnDeck
    {
      [Token(Token = "0x600D54E"), Address(RVA = "0x341890", Offset = "0x340690", VA = "0x10341890")] get
      {
        return new int();
      }
      [Token(Token = "0x600D54F"), Address(RVA = "0xA241D0", Offset = "0xA22FD0", VA = "0x10A241D0")] set
      {
      }
    }

    [Token(Token = "0x17001C63")]
    public List<Unit.AbilityChange> AbilityChangeLists
    {
      [Token(Token = "0x600D550"), Address(RVA = "0xA21C20", Offset = "0xA20A20", VA = "0x10A21C20")] get
      {
        return (List<Unit.AbilityChange>) null;
      }
    }

    [Token(Token = "0x17001C64")]
    public List<AbilityData> AddedAbilitys
    {
      [Token(Token = "0x600D551"), Address(RVA = "0xA21C60", Offset = "0xA20A60", VA = "0x10A21C60")] get
      {
        return (List<AbilityData>) null;
      }
    }

    [Token(Token = "0x17001C65")]
    public DynamicTransformUnitParam DtuParam
    {
      [Token(Token = "0x600D552"), Address(RVA = "0xA222A0", Offset = "0xA210A0", VA = "0x10A222A0")] get
      {
        return (DynamicTransformUnitParam) null;
      }
      [Token(Token = "0x600D553"), Address(RVA = "0xA240B0", Offset = "0xA22EB0", VA = "0x10A240B0")] set
      {
      }
    }

    [Token(Token = "0x17001C66")]
    public Unit DtuFromUnit
    {
      [Token(Token = "0x600D554"), Address(RVA = "0x78D510", Offset = "0x78C310", VA = "0x1078D510")] get
      {
        return (Unit) null;
      }
      [Token(Token = "0x600D555"), Address(RVA = "0xA24090", Offset = "0xA22E90", VA = "0x10A24090")] set
      {
      }
    }

    [Token(Token = "0x17001C67")]
    public int DtuRemainTurn
    {
      [Token(Token = "0x600D556"), Address(RVA = "0xA222B0", Offset = "0xA210B0", VA = "0x10A222B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600D557"), Address(RVA = "0xA240D0", Offset = "0xA22ED0", VA = "0x10A240D0")] set
      {
      }
    }

    [Token(Token = "0x17001C68")]
    public int OverKillDamage
    {
      [Token(Token = "0x600D558"), Address(RVA = "0x4782D0", Offset = "0x4770D0", VA = "0x104782D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001C69")]
    public eMovType MovType
    {
      [Token(Token = "0x600D559"), Address(RVA = "0xA22F40", Offset = "0xA21D40", VA = "0x10A22F40")] get
      {
        return new eMovType();
      }
    }

    [Token(Token = "0x17001C6A")]
    public bool IsPassMovType
    {
      [Token(Token = "0x600D55A"), Address(RVA = "0xA22BF0", Offset = "0xA219F0", VA = "0x10A22BF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C6B")]
    public bool IsRiding
    {
      [Token(Token = "0x600D55B"), Address(RVA = "0xA22C80", Offset = "0xA21A80", VA = "0x10A22C80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C6C")]
    private bool IsFlyingPassJob
    {
      [Token(Token = "0x600D55C"), Address(RVA = "0xA22990", Offset = "0xA21790", VA = "0x10A22990")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C6D")]
    private bool IsFlyingPassUnit
    {
      [Token(Token = "0x600D55D"), Address(RVA = "0xA22A10", Offset = "0xA21810", VA = "0x10A22A10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C6E")]
    public bool IsFlyingPass
    {
      [Token(Token = "0x600D55E"), Address(RVA = "0xA22A40", Offset = "0xA21840", VA = "0x10A22A40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D55F")]
    [Address(RVA = "0xA157C0", Offset = "0xA145C0", VA = "0x10A157C0")]
    private void SetupStatus()
    {
    }

    [Token(Token = "0x600D560")]
    [Address(RVA = "0xA12230", Offset = "0xA11030", VA = "0x10A12230")]
    private void SetupRaidBuffStatus(NPCSetting npc)
    {
    }

    [Token(Token = "0x600D561")]
    [Address(RVA = "0xA11EF0", Offset = "0xA10CF0", VA = "0x10A11EF0")]
    private void SetupGvGBuffStatus(int round, int nodeID)
    {
    }

    [Token(Token = "0x600D562")]
    [Address(RVA = "0xA119F0", Offset = "0xA107F0", VA = "0x10A119F0")]
    private void SetupGenAdvLapBossBuff(QuestParam quest_param, NPCSetting npc)
    {
    }

    [Token(Token = "0x600D563")]
    [Address(RVA = "0xA18B80", Offset = "0xA17980", VA = "0x10A18B80")]
    private void SetupWorldRaidBossBuff(QuestParam quest_param, NPCSetting npc)
    {
    }

    [Token(Token = "0x600D564")]
    [Address(RVA = "0xA0E260", Offset = "0xA0D060", VA = "0x10A0E260")]
    private void SetNPCChangeAbilitySkills(NPCSetting _npc, ref AbilityData aab)
    {
    }

    [Token(Token = "0x600D565")]
    [Address(RVA = "0xA0E5F0", Offset = "0xA0D3F0", VA = "0x10A0E5F0")]
    private void SetNPCDtuAbilitySkills(NPCSetting _npc, ref AbilityData aab)
    {
    }

    [Token(Token = "0x600D566")]
    [Address(RVA = "0x9FD1B0", Offset = "0x9FBFB0", VA = "0x109FD1B0")]
    private List<EquipAbilitySetting> GetAddAbilityUseRate(NPCSetting _npc)
    {
      return (List<EquipAbilitySetting>) null;
    }

    [Token(Token = "0x600D567")]
    [Address(RVA = "0xA0E960", Offset = "0xA0D760", VA = "0x10A0E960")]
    private void SetNPCForceCtrlSkills(NPCSetting _npc, ref AbilityData aab)
    {
    }

    [Token(Token = "0x600D568")]
    [Address(RVA = "0xA0DFA0", Offset = "0xA0CDA0", VA = "0x10A0DFA0")]
    private void SetNPCAddAbilityUseRateSkills(
      NPCSetting _npc,
      List<EquipAbilitySetting> easList,
      ref AbilityData aab)
    {
    }

    [Token(Token = "0x600D569")]
    [Address(RVA = "0xA0FA50", Offset = "0xA0E850", VA = "0x10A0FA50")]
    private void SetupAbility(NPCSetting npc, EquipAbilitySetting ability)
    {
    }

    [Token(Token = "0x600D56A")]
    [Address(RVA = "0xA19300", Offset = "0xA18100", VA = "0x10A19300")]
    public bool Setup(
      UnitData unitdata = null,
      UnitSetting setting = null,
      Unit.DropItem dropitem = null,
      Unit.DropItem stealitem = null)
    {
      return new bool();
    }

    [Token(Token = "0x600D56B")]
    [Address(RVA = "0xA103B0", Offset = "0xA0F1B0", VA = "0x10A103B0")]
    public bool SetupDummy(
      EUnitSide side,
      string iname,
      int lv = 1,
      int rare = 0,
      int awake = 0,
      string job_iname = null,
      int job_rank = 1)
    {
      return new bool();
    }

    [Token(Token = "0x600D56C")]
    [Address(RVA = "0xA00870", Offset = "0x9FF670", VA = "0x10A00870")]
    public EquipAbilitySetting GetDtuAbiRank(Unit _unit, string _dtuIname, string _abi)
    {
      return (EquipAbilitySetting) null;
    }

    [Token(Token = "0x600D56D")]
    [Address(RVA = "0xA109C0", Offset = "0xA0F7C0", VA = "0x10A109C0")]
    public bool SetupDynamicTransform(
      Unit org_unit,
      DynamicTransformUnitParam dtu_param,
      bool is_no_art_cc = false)
    {
      return new bool();
    }

    [Token(Token = "0x600D56E")]
    [Address(RVA = "0xA10670", Offset = "0xA0F470", VA = "0x10A10670")]
    private void SetupDynamicTransformEntryAbilityAndSkill(string ab_id, int ab_rank)
    {
    }

    [Token(Token = "0x600D56F")]
    [Address(RVA = "0xA12810", Offset = "0xA11610", VA = "0x10A12810")]
    public bool SetupResume(
      MultiPlayResumeUnitData data,
      Unit target,
      Unit rage,
      Unit casttarget,
      List<MultiPlayResumeSkillData> buffskill,
      List<MultiPlayResumeSkillData> condskill)
    {
      return new bool();
    }

    [Token(Token = "0x600D570")]
    [Address(RVA = "0xA07EC0", Offset = "0xA06CC0", VA = "0x10A07EC0")]
    public void MultiSuspendResumeAddedAbility(MultiPlayResumeUnitData data)
    {
    }

    [Token(Token = "0x600D571")]
    [Address(RVA = "0xA0C980", Offset = "0xA0B780", VA = "0x10A0C980")]
    public SkillData SearchArtifactSkill(string skill_id) => (SkillData) null;

    [Token(Token = "0x600D572")]
    [Address(RVA = "0xA0CBC0", Offset = "0xA0B9C0", VA = "0x10A0CBC0")]
    public SkillData SearchItemSkill(BattleCore bc, string skill_id) => (SkillData) null;

    [Token(Token = "0x600D573")]
    [Address(RVA = "0xA1AA90", Offset = "0xA19890", VA = "0x10A1AA90")]
    public void SuspendClearBuffCondEffects(bool is_multi = false)
    {
    }

    [Token(Token = "0x600D574")]
    [Address(RVA = "0xA15BA0", Offset = "0xA149A0", VA = "0x10A15BA0")]
    public bool SetupSuspend(BattleCore bc, BattleSuspend.Data.UnitInfo unit_info) => new bool();

    [Token(Token = "0x600D575")]
    [Address(RVA = "0xA1AD20", Offset = "0xA19B20", VA = "0x10A1AD20")]
    public void SuspendResumeAddedAbility(BattleSuspend.Data.UnitInfo unit_info)
    {
    }

    [Token(Token = "0x600D576")]
    [Address(RVA = "0x9F19B0", Offset = "0x9F07B0", VA = "0x109F19B0")]
    public void ApplyStatusResistBuff(int[] statuses, ref BaseStatus status)
    {
    }

    [Token(Token = "0x600D577")]
    [Address(RVA = "0xA03950", Offset = "0xA02750", VA = "0x10A03950")]
    public string[] GetTags() => (string[]) null;

    [Token(Token = "0x600D578")]
    [Address(RVA = "0x9F73A0", Offset = "0x9F61A0", VA = "0x109F73A0")]
    public bool CheckExistMap() => new bool();

    [Token(Token = "0x600D579")]
    [Address(RVA = "0x9F65B0", Offset = "0x9F53B0", VA = "0x109F65B0")]
    public bool CheckCollision(Grid grid, bool is_check_exist = true) => new bool();

    [Token(Token = "0x600D57A")]
    [Address(RVA = "0x9F6800", Offset = "0x9F5600", VA = "0x109F6800")]
    public bool CheckCollision(int cx, int cy, bool is_check_exist = true) => new bool();

    [Token(Token = "0x600D57B")]
    [Address(RVA = "0x9F66F0", Offset = "0x9F54F0", VA = "0x109F66F0")]
    public bool CheckCollision(int x0, int y0, int x1, int y1) => new bool();

    [Token(Token = "0x600D57C")]
    [Address(RVA = "0x9F64B0", Offset = "0x9F52B0", VA = "0x109F64B0")]
    public bool CheckCollisionDirect(int tx, int ty, int cx, int cy, bool is_check_exist = true)
    {
      return new bool();
    }

    [Token(Token = "0x600D57D")]
    [Address(RVA = "0xA23660", Offset = "0xA22460", VA = "0x10A23660")]
    private bool isSameBuffAttachment(BuffAttachment sba, BuffAttachment dba) => new bool();

    [Token(Token = "0x600D57E")]
    [Address(RVA = "0x9FF520", Offset = "0x9FE320", VA = "0x109FF520")]
    public int GetBuffAttachmentDuplicateCount(BuffAttachment buff) => new int();

    [Token(Token = "0x600D57F")]
    [Address(RVA = "0x9FF5B0", Offset = "0x9FE3B0", VA = "0x109FF5B0")]
    public List<BaseStatus> GetBuffAttachmentStatuses(BuffAttachment buff)
    {
      return (List<BaseStatus>) null;
    }

    [Token(Token = "0x600D580")]
    [Address(RVA = "0xA06520", Offset = "0xA05320", VA = "0x10A06520")]
    public bool IsIncludeBuffAttachmentResistStatusBuff(BuffAttachment buff) => new bool();

    [Token(Token = "0x600D581")]
    [Address(RVA = "0xA0F9A0", Offset = "0xA0E7A0", VA = "0x10A0F9A0")]
    public void SetUnitFlag(EUnitFlag tgt, bool sw)
    {
    }

    [Token(Token = "0x600D582")]
    [Address(RVA = "0xA07690", Offset = "0xA06490", VA = "0x10A07690")]
    public bool IsUnitFlag(EUnitFlag tgt) => new bool();

    [Token(Token = "0x600D583")]
    [Address(RVA = "0xA0FA20", Offset = "0xA0E820", VA = "0x10A0FA20")]
    public void SetUseSkillFlag(EUseSkillFlag tgt, bool sw)
    {
    }

    [Token(Token = "0x600D584")]
    [Address(RVA = "0xA07910", Offset = "0xA06710", VA = "0x10A07910")]
    public bool IsUseSkillFlag(EUseSkillFlag tgt) => new bool();

    [Token(Token = "0x600D585")]
    [Address(RVA = "0x9F8410", Offset = "0x9F7210", VA = "0x109F8410")]
    public void ClearUseSkillFlag()
    {
    }

    [Token(Token = "0x600D586")]
    [Address(RVA = "0xA0D490", Offset = "0xA0C290", VA = "0x10A0D490")]
    public void SetCommandFlag(EUnitCommandFlag tgt, bool sw)
    {
    }

    [Token(Token = "0x600D587")]
    [Address(RVA = "0xA05010", Offset = "0xA03E10", VA = "0x10A05010")]
    public bool IsCommandFlag(EUnitCommandFlag tgt) => new bool();

    [Token(Token = "0x600D588")]
    [Address(RVA = "0xA053B0", Offset = "0xA041B0", VA = "0x10A053B0")]
    public bool IsDying() => new bool();

    [Token(Token = "0x600D589")]
    [Address(RVA = "0xA065E0", Offset = "0xA053E0", VA = "0x10A065E0")]
    public bool IsJudgeHP(SkillData skill) => new bool();

    [Token(Token = "0x600D58A")]
    [Address(RVA = "0x9FF440", Offset = "0x9FE240", VA = "0x109FF440")]
    public int GetBaseAvoidRate() => new int();

    [Token(Token = "0x600D58B")]
    [Address(RVA = "0xA03780", Offset = "0xA02580", VA = "0x10A03780")]
    public short GetStartGems(bool isMax = false) => new short();

    [Token(Token = "0x600D58C")]
    [Address(RVA = "0xA010B0", Offset = "0x9FFEB0", VA = "0x10A010B0")]
    public int GetGoodSleepHpHealValue() => new int();

    [Token(Token = "0x600D58D")]
    [Address(RVA = "0xA011F0", Offset = "0x9FFFF0", VA = "0x10A011F0")]
    public int GetGoodSleepMpHealValue() => new int();

    [Token(Token = "0x600D58E")]
    [Address(RVA = "0xA044D0", Offset = "0xA032D0", VA = "0x10A044D0")]
    public void InitializeSkillUseCount()
    {
    }

    [Token(Token = "0x600D58F")]
    [Address(RVA = "0x9F14A0", Offset = "0x9F02A0", VA = "0x109F14A0")]
    public void AddSkillUseCount(AbilityData ad)
    {
    }

    [Token(Token = "0x600D590")]
    [Address(RVA = "0x9F0D60", Offset = "0x9EFB60", VA = "0x109F0D60")]
    public void AddSkillUseCountNPCPlayer(AbilityData ad)
    {
    }

    [Token(Token = "0x600D591")]
    [Address(RVA = "0x9F1100", Offset = "0x9EFF00", VA = "0x109F1100")]
    private void AddSkillUseCount(SkillData skill, int cnt)
    {
    }

    [Token(Token = "0x600D592")]
    [Address(RVA = "0x9F6930", Offset = "0x9F5730", VA = "0x109F6930")]
    public bool CheckDamageActionStart() => new bool();

    [Token(Token = "0x600D593")]
    [Address(RVA = "0x9F6EF0", Offset = "0x9F5CF0", VA = "0x109F6EF0")]
    public bool CheckEnableSkillUseCount(SkillData skill) => new bool();

    [Token(Token = "0x600D594")]
    [Address(RVA = "0xA03570", Offset = "0xA02370", VA = "0x10A03570")]
    public OInt GetSkillUseCount(SkillData skill) => new OInt();

    [Token(Token = "0x600D595")]
    [Address(RVA = "0xA03510", Offset = "0xA02310", VA = "0x10A03510")]
    public int GetSkillUseCountMax(SkillData skill) => new int();

    [Token(Token = "0x600D596")]
    [Address(RVA = "0xA1DF30", Offset = "0xA1CD30", VA = "0x10A1DF30")]
    public void UpdateSkillUseCount(SkillData skill, int count)
    {
    }

    [Token(Token = "0x600D597")]
    [Address(RVA = "0xA1B650", Offset = "0xA1A450", VA = "0x10A1B650")]
    public void UpdateAllSkillUseCount(int count)
    {
    }

    [Token(Token = "0x600D598")]
    [Address(RVA = "0x9F7FA0", Offset = "0x9F6DA0", VA = "0x109F7FA0")]
    public void ClearJudgeHpLists()
    {
    }

    [Token(Token = "0x600D599")]
    [Address(RVA = "0xA050B0", Offset = "0xA03EB0", VA = "0x10A050B0")]
    public bool IsContainsJudgeHpLists(SkillData skill) => new bool();

    [Token(Token = "0x600D59A")]
    [Address(RVA = "0x9F0450", Offset = "0x9EF250", VA = "0x109F0450")]
    public void AddJudgeHpLists(SkillData skill)
    {
    }

    [Token(Token = "0x600D59B")]
    [Address(RVA = "0xA0BCB0", Offset = "0xA0AAB0", VA = "0x10A0BCB0")]
    public bool RemoveJudgeHpLists(SkillData skill) => new bool();

    [Token(Token = "0x600D59C")]
    [Address(RVA = "0xA05850", Offset = "0xA04650", VA = "0x10A05850")]
    public bool IsEnableBuffEffect(BuffTypes type) => new bool();

    [Token(Token = "0x600D59D")]
    [Address(RVA = "0xA06380", Offset = "0xA05180", VA = "0x10A06380")]
    public bool IsEnableSteal() => new bool();

    [Token(Token = "0x600D59E")]
    [Address(RVA = "0xA06600", Offset = "0xA05400", VA = "0x10A06600")]
    public bool IsJumpBreakCondition() => new bool();

    [Token(Token = "0x600D59F")]
    [Address(RVA = "0xA06660", Offset = "0xA05460", VA = "0x10A06660")]
    public bool IsJumpBreakNoMotionCondition() => new bool();

    [Token(Token = "0x600D5A0")]
    [Address(RVA = "0xA05900", Offset = "0xA04700", VA = "0x10A05900")]
    public bool IsEnableControlCondition() => new bool();

    [Token(Token = "0x600D5A1")]
    [Address(RVA = "0xA05C90", Offset = "0xA04A90", VA = "0x10A05C90")]
    public bool IsEnableMoveCondition(bool bCondOnly = false) => new bool();

    [Token(Token = "0x600D5A2")]
    [Address(RVA = "0xA05490", Offset = "0xA04290", VA = "0x10A05490")]
    public bool IsEnableActionCondition() => new bool();

    [Token(Token = "0x600D5A3")]
    [Address(RVA = "0xA054D0", Offset = "0xA042D0", VA = "0x10A054D0")]
    public bool IsEnableAttackCondition(bool bCondOnly = false) => new bool();

    [Token(Token = "0x600D5A4")]
    [Address(RVA = "0xA059C0", Offset = "0xA047C0", VA = "0x10A059C0")]
    public bool IsEnableHelpCondition() => new bool();

    [Token(Token = "0x600D5A5")]
    [Address(RVA = "0xA06200", Offset = "0xA05000", VA = "0x10A06200")]
    public bool IsEnableSkillCondition(bool bCondOnly = false) => new bool();

    [Token(Token = "0x600D5A6")]
    [Address(RVA = "0xA05B20", Offset = "0xA04920", VA = "0x10A05B20")]
    public bool IsEnableItemCondition(bool bCondOnly = false) => new bool();

    [Token(Token = "0x600D5A7")]
    [Address(RVA = "0xA05E70", Offset = "0xA04C70", VA = "0x10A05E70")]
    public bool IsEnableReactionCondition() => new bool();

    [Token(Token = "0x600D5A8")]
    [Address(RVA = "0xA05F70", Offset = "0xA04D70", VA = "0x10A05F70")]
    public bool IsEnableReactionSkill(SkillData skill) => new bool();

    [Token(Token = "0x600D5A9")]
    [Address(RVA = "0xA06140", Offset = "0xA04F40", VA = "0x10A06140")]
    public bool IsEnableSelectDirectionCondition() => new bool();

    [Token(Token = "0x600D5AA")]
    [Address(RVA = "0xA05600", Offset = "0xA04400", VA = "0x10A05600")]
    public bool IsEnableAutoHealCondition() => new bool();

    [Token(Token = "0x600D5AB")]
    [Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0")]
    public bool IsEnableGimmickCondition() => new bool();

    [Token(Token = "0x600D5AC")]
    [Address(RVA = "0xA05200", Offset = "0xA04000", VA = "0x10A05200")]
    public bool IsDeadCondition() => new bool();

    [Token(Token = "0x600D5AD")]
    [Address(RVA = "0xA052D0", Offset = "0xA040D0", VA = "0x10A052D0")]
    public bool IsDisableGimmick() => new bool();

    [Token(Token = "0x600D5AE")]
    [Address(RVA = "0xA05640", Offset = "0xA04440", VA = "0x10A05640")]
    public bool IsEnableAutoMode() => new bool();

    [Token(Token = "0x600D5AF")]
    [Address(RVA = "0xA05DC0", Offset = "0xA04BC0", VA = "0x10A05DC0")]
    public bool IsEnablePlayAnimCondition() => new bool();

    [Token(Token = "0x600D5B0")]
    [Address(RVA = "0x9F6110", Offset = "0x9F4F10", VA = "0x109F6110")]
    public bool CheckCancelSkillFailCondition(EUnitCondition condition) => new bool();

    [Token(Token = "0x600D5B1")]
    [Address(RVA = "0x9F6090", Offset = "0x9F4E90", VA = "0x109F6090")]
    public bool CheckCancelSkillCureCondition(EUnitCondition condition) => new bool();

    [Token(Token = "0x600D5B2")]
    [Address(RVA = "0x9F69B0", Offset = "0x9F57B0", VA = "0x109F69B0")]
    public bool CheckEnableCureCondition(EUnitCondition condition) => new bool();

    [Token(Token = "0x600D5B3")]
    [Address(RVA = "0x9F6D80", Offset = "0x9F5B80", VA = "0x109F6D80")]
    public bool CheckEnableFailCondition(EUnitCondition condition) => new bool();

    [Token(Token = "0x600D5B4")]
    [Address(RVA = "0x9F6F80", Offset = "0x9F5D80", VA = "0x109F6F80")]
    public bool CheckEnableUseSkill(SkillData skill, bool bCheckCondOnly = false) => new bool();

    [Token(Token = "0x600D5B5")]
    [Address(RVA = "0xA04AA0", Offset = "0xA038A0", VA = "0x10A04AA0")]
    public bool IsAbilityListHide(SkillData skill, bool bCheckCondOnly = false) => new bool();

    [Token(Token = "0x600D5B6")]
    [Address(RVA = "0xA04EE0", Offset = "0xA03CE0", VA = "0x10A04EE0")]
    public bool IsFirstReactionEnableAttackCondition() => new bool();

    [Token(Token = "0x600D5B7")]
    [Address(RVA = "0x9F81A0", Offset = "0x9F6FA0", VA = "0x109F81A0")]
    public void ClearProtect()
    {
    }

    [Token(Token = "0x600D5B8")]
    [Address(RVA = "0x9F7F40", Offset = "0x9F6D40", VA = "0x109F7F40")]
    public void ClearGuard()
    {
    }

    [Token(Token = "0x600D5B9")]
    [Address(RVA = "0xA0BEA0", Offset = "0xA0ACA0", VA = "0x10A0BEA0")]
    public void ResumeProtect(
      BattleSuspend.Data.UnitInfo.Protect protect,
      BattleCore btl,
      bool isGuard = false)
    {
    }

    [Token(Token = "0x600D5BA")]
    [Address(RVA = "0xA06F50", Offset = "0xA05D50", VA = "0x10A06F50")]
    public bool IsProtectCondition() => new bool();

    [Token(Token = "0x600D5BB")]
    [Address(RVA = "0xA07010", Offset = "0xA05E10", VA = "0x10A07010")]
    public bool IsProtectTargetCondition(Unit unit) => new bool();

    [Token(Token = "0x600D5BC")]
    [Address(RVA = "0xA070D0", Offset = "0xA05ED0", VA = "0x10A070D0")]
    public bool IsProtectTargetRelease(Unit unit) => new bool();

    [Token(Token = "0x600D5BD")]
    [Address(RVA = "0xA025A0", Offset = "0xA013A0", VA = "0x10A025A0")]
    public Unit.UnitProtect GetSameProtect(Unit.UnitProtect protect) => (Unit.UnitProtect) null;

    [Token(Token = "0x600D5BE")]
    [Address(RVA = "0xA024D0", Offset = "0xA012D0", VA = "0x10A024D0")]
    public Unit.UnitProtect GetSameGuard(Unit.UnitProtect protect) => (Unit.UnitProtect) null;

    [Token(Token = "0x600D5BF")]
    [Address(RVA = "0x9F9560", Offset = "0x9F8360", VA = "0x109F9560")]
    private Unit.UnitProtect CopyUnitProtect(Unit target, Unit.UnitProtect protect)
    {
      return (Unit.UnitProtect) null;
    }

    [Token(Token = "0x600D5C0")]
    [Address(RVA = "0xA02440", Offset = "0xA01240", VA = "0x10A02440")]
    private ProtectTypes GetProtectType(SkillData skill) => new ProtectTypes();

    [Token(Token = "0x600D5C1")]
    [Address(RVA = "0x9F0610", Offset = "0x9EF410", VA = "0x109F0610")]
    public void AddProtect(Unit target, SkillData skill)
    {
    }

    [Token(Token = "0x600D5C2")]
    [Address(RVA = "0x9F02B0", Offset = "0x9EF0B0", VA = "0x109F02B0")]
    public void AddGuard(Unit target, Unit.UnitProtect protect)
    {
    }

    [Token(Token = "0x600D5C3")]
    [Address(RVA = "0xA1D540", Offset = "0xA1C340", VA = "0x10A1D540")]
    private void UpdateProtectTurn()
    {
    }

    [Token(Token = "0x600D5C4")]
    [Address(RVA = "0x9F59A0", Offset = "0x9F47A0", VA = "0x109F59A0")]
    public void CancelProtect(Unit.UnitProtect protect = null)
    {
    }

    [Token(Token = "0x600D5C5")]
    [Address(RVA = "0x9F5930", Offset = "0x9F4730", VA = "0x109F5930")]
    public void CancelGuard(Unit target, Unit.UnitProtect protect)
    {
    }

    [Token(Token = "0x600D5C6")]
    [Address(RVA = "0x9F49C0", Offset = "0x9F37C0", VA = "0x109F49C0")]
    public void CalcProtectDamage(DamageTypes damageType, int damage, Unit guard)
    {
    }

    [Token(Token = "0x600D5C7")]
    [Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x10A0A9B0")]
    public void ProtectDtuCopyTo(List<Unit> units, Unit from_unit)
    {
    }

    [Token(Token = "0x600D5C8")]
    [Address(RVA = "0xA0A8A0", Offset = "0xA096A0", VA = "0x10A0A8A0")]
    public void ProtectChangeTarget(Unit newTarget, Unit oldTarget)
    {
    }

    [Token(Token = "0x600D5C9")]
    [Address(RVA = "0xA042A0", Offset = "0xA030A0", VA = "0x10A042A0")]
    public void GuardChangeTarget(Unit newTarget, Unit oldTarget)
    {
    }

    [Token(Token = "0x600D5CA")]
    [Address(RVA = "0x9F8200", Offset = "0x9F7000", VA = "0x109F8200")]
    public void ClearShield()
    {
    }

    [Token(Token = "0x600D5CB")]
    [Address(RVA = "0x9F0C40", Offset = "0x9EFA40", VA = "0x109F0C40")]
    public void AddShield(SkillData skill)
    {
    }

    [Token(Token = "0x600D5CC")]
    [Address(RVA = "0x9F0950", Offset = "0x9EF750", VA = "0x109F0950")]
    private void AddShieldSuspend(
      SkillParam skill_param,
      int hp,
      int hp_max,
      int turn,
      int turn_max,
      int damage_rate,
      int damage_value)
    {
    }

    [Token(Token = "0x600D5CD")]
    [Address(RVA = "0x9F6E20", Offset = "0x9F5C20", VA = "0x109F6E20")]
    public bool CheckEnableShieldType(DamageTypes type) => new bool();

    [Token(Token = "0x600D5CE")]
    [Address(RVA = "0x9F4D80", Offset = "0x9F3B80", VA = "0x109F4D80")]
    public void CalcShieldDamage(
      DamageTypes damageType,
      ref int damage,
      bool bEnableShieldBreak,
      AttackDetailTypes attack_detail_type,
      RandXorshift rand,
      LogSkill.Target log_target = null)
    {
    }

    [Token(Token = "0x600D5CF")]
    [Address(RVA = "0x9F51A0", Offset = "0x9F3FA0", VA = "0x109F51A0")]
    private int CalcShieldEffectValue(SkillParamCalcTypes calctype, int skillval, int target)
    {
      return new int();
    }

    [Token(Token = "0x600D5D0")]
    [Address(RVA = "0xA1DB00", Offset = "0xA1C900", VA = "0x10A1DB00")]
    private void UpdateShieldTurn()
    {
    }

    [Token(Token = "0x600D5D1")]
    [Address(RVA = "0x9FAF40", Offset = "0x9F9D40", VA = "0x109FAF40")]
    public void DestroyShield(LogSkill.Target log_target)
    {
    }

    [Token(Token = "0x600D5D2")]
    [Address(RVA = "0xA00FE0", Offset = "0x9FFDE0", VA = "0x10A00FE0")]
    public Unit.UnitForcedTargeting GetFtgtTarget(Unit unit) => (Unit.UnitForcedTargeting) null;

    [Token(Token = "0x600D5D3")]
    [Address(RVA = "0xA0BBE0", Offset = "0xA0A9E0", VA = "0x10A0BBE0")]
    public bool RemoveFtgtTarget(Unit.UnitForcedTargeting ftgt_target) => new bool();

    [Token(Token = "0x600D5D4")]
    [Address(RVA = "0xA0BC40", Offset = "0xA0AA40", VA = "0x10A0BC40")]
    public bool RemoveFtgtTarget(Unit unit) => new bool();

    [Token(Token = "0x600D5D5")]
    [Address(RVA = "0xA047A0", Offset = "0xA035A0", VA = "0x10A047A0")]
    public bool InsertFtgtTarget(Unit target, int turn) => new bool();

    [Token(Token = "0x600D5D6")]
    [Address(RVA = "0xA00F10", Offset = "0x9FFD10", VA = "0x10A00F10")]
    public Unit.UnitForcedTargeting GetFtgtFrom(Unit unit) => (Unit.UnitForcedTargeting) null;

    [Token(Token = "0x600D5D7")]
    [Address(RVA = "0xA0BB10", Offset = "0xA0A910", VA = "0x10A0BB10")]
    public bool RemoveFtgtFrom(Unit.UnitForcedTargeting ftgt_from) => new bool();

    [Token(Token = "0x600D5D8")]
    [Address(RVA = "0xA0BB70", Offset = "0xA0A970", VA = "0x10A0BB70")]
    public bool RemoveFtgtFrom(Unit unit) => new bool();

    [Token(Token = "0x600D5D9")]
    [Address(RVA = "0xA046B0", Offset = "0xA034B0", VA = "0x10A046B0")]
    public bool InsertFtgtFrom(Unit from, int turn) => new bool();

    [Token(Token = "0x600D5DA")]
    [Address(RVA = "0x9F56B0", Offset = "0x9F44B0", VA = "0x109F56B0")]
    private void CancelForcedTargeting()
    {
    }

    [Token(Token = "0x600D5DB")]
    [Address(RVA = "0xA1D270", Offset = "0xA1C070", VA = "0x10A1D270")]
    private void UpdateForcedTargetingTurn()
    {
    }

    [Token(Token = "0x600D5DC")]
    [Address(RVA = "0x9F8000", Offset = "0x9F6E00", VA = "0x109F8000")]
    public void ClearMhmDamage()
    {
    }

    [Token(Token = "0x600D5DD")]
    [Address(RVA = "0x9F0590", Offset = "0x9EF390", VA = "0x109F0590")]
    public void AddMhmDamage(Unit.eTypeMhmDamage type, int damage)
    {
    }

    [Token(Token = "0x600D5DE")]
    [Address(RVA = "0xA0AB70", Offset = "0xA09970", VA = "0x10A0AB70")]
    private void ReflectMhmDamage()
    {
    }

    [Token(Token = "0x600D5DF")]
    [Address(RVA = "0xA0ACD0", Offset = "0xA09AD0", VA = "0x10A0ACD0")]
    public void ReflectMhmDamage(Unit.eTypeMhmDamage type, int damage, bool is_allow_to_dead = false)
    {
    }

    [Token(Token = "0x600D5E0")]
    [Address(RVA = "0x9F8E10", Offset = "0x9F7C10", VA = "0x109F8E10")]
    public bool ContainsSkillBuffAttachment(SkillData skill, Unit user = null) => new bool();

    [Token(Token = "0x600D5E1")]
    [Address(RVA = "0x9F8CF0", Offset = "0x9F7AF0", VA = "0x109F8CF0")]
    public bool ContainsResumeBuffAttachment(
      SkillData skill,
      BuffTypes buffType,
      SkillParamCalcTypes calcType,
      bool isNegativeValueIsBuff,
      Unit user = null)
    {
      return new bool();
    }

    [Token(Token = "0x600D5E2")]
    [Address(RVA = "0xA0CE90", Offset = "0xA0BC90", VA = "0x10A0CE90")]
    public bool SetBuffAttachment(BuffAttachment buff, bool is_duplicate = false) => new bool();

    [Token(Token = "0x600D5E3")]
    [Address(RVA = "0x9F8060", Offset = "0x9F6E60", VA = "0x109F8060")]
    public void ClearPassiveBuffEffects()
    {
    }

    [Token(Token = "0x600D5E4")]
    [Address(RVA = "0x9F7DC0", Offset = "0x9F6BC0", VA = "0x109F7DC0")]
    public void ClearBuffEffects()
    {
    }

    [Token(Token = "0x600D5E5")]
    [Address(RVA = "0xA1BD40", Offset = "0xA1AB40", VA = "0x10A1BD40")]
    public void UpdateBuffEffectTurnCount(
      EffectCheckTimings timing,
      Unit current,
      AvoidType avoidType = AvoidType.None)
    {
    }

    [Token(Token = "0x600D5E6")]
    [Address(RVA = "0x9F5C40", Offset = "0x9F4A40", VA = "0x109F5C40")]
    public void ChangeBuffEffectCount(BuffAttachment buff, int dupliCnt)
    {
    }

    [Token(Token = "0x600D5E7")]
    [Address(RVA = "0xA1E0F0", Offset = "0xA1CEF0", VA = "0x10A1E0F0")]
    private void UpdateUpBuffEffect(
      BuffAttachment buff,
      EffectCheckTimings timing = EffectCheckTimings.ActionStart,
      bool is_count_up = false)
    {
    }

    [Token(Token = "0x600D5E8")]
    [Address(RVA = "0xA04E20", Offset = "0xA03C20", VA = "0x10A04E20")]
    private bool IsBuffConceptCardLS(BuffAttachment ba, Unit leader_unit, SkillData leader_skill)
    {
      return new bool();
    }

    [Token(Token = "0x600D5E9")]
    [Address(RVA = "0xA04C80", Offset = "0xA03A80", VA = "0x10A04C80")]
    public bool IsAttachConceptCardLS(Unit leader_unit, SkillData leader_skill) => new bool();

    [Token(Token = "0x600D5EA")]
    [Address(RVA = "0x9F15C0", Offset = "0x9F03C0", VA = "0x109F15C0")]
    public void ApplyConceptCardLS(Unit leader_unit, SkillData leader_skill, int coef)
    {
    }

    [Token(Token = "0x600D5EB")]
    [Address(RVA = "0xA0BA50", Offset = "0xA0A850", VA = "0x10A0BA50")]
    public bool RemoveBuffPrevApply() => new bool();

    [Token(Token = "0x600D5EC")]
    [Address(RVA = "0xA1BF50", Offset = "0xA1AD50", VA = "0x10A1BF50")]
    public bool UpdateBuffEffects() => new bool();

    [Token(Token = "0x600D5ED")]
    [Address(RVA = "0x9F46F0", Offset = "0x9F34F0", VA = "0x109F46F0")]
    public int CalcFailConditionNum(EUnitCondition condition) => new int();

    [Token(Token = "0x600D5EE")]
    [Address(RVA = "0x9F8EF0", Offset = "0x9F7CF0", VA = "0x109F8EF0")]
    public bool ContainsSkillCondAttachment(SkillData skill) => new bool();

    [Token(Token = "0x600D5EF")]
    [Address(RVA = "0xA07640", Offset = "0xA06440", VA = "0x10A07640")]
    public bool IsUnitCondition(EUnitCondition condition) => new bool();

    [Token(Token = "0x600D5F0")]
    [Address(RVA = "0xA05350", Offset = "0xA04150", VA = "0x10A05350")]
    public bool IsDisableUnitCondition(EUnitCondition condition) => new bool();

    [Token(Token = "0x600D5F1")]
    [Address(RVA = "0xA05100", Offset = "0xA03F00", VA = "0x10A05100")]
    public bool IsCurseUnitCondition(EUnitCondition condition) => new bool();

    [Token(Token = "0x600D5F2")]
    [Address(RVA = "0xA04DC0", Offset = "0xA03BC0", VA = "0x10A04DC0")]
    public bool IsAutoCureCondition(EUnitCondition condition) => new bool();

    [Token(Token = "0x600D5F3")]
    [Address(RVA = "0xA04FC0", Offset = "0xA03DC0", VA = "0x10A04FC0")]
    public bool IsClockCureCondition(EUnitCondition condition) => new bool();

    [Token(Token = "0x600D5F4")]
    [Address(RVA = "0xA075F0", Offset = "0xA063F0", VA = "0x10A075F0")]
    public bool IsUnitConditionDamage() => new bool();

    [Token(Token = "0x600D5F5")]
    [Address(RVA = "0xA06E80", Offset = "0xA05C80", VA = "0x10A06E80")]
    public bool IsPassiveUnitCondition(EUnitCondition condition) => new bool();

    [Token(Token = "0x600D5F6")]
    [Address(RVA = "0xA0D5D0", Offset = "0xA0C3D0", VA = "0x10A0D5D0")]
    public bool SetCondAttachment(CondAttachment cond) => new bool();

    [Token(Token = "0x600D5F7")]
    [Address(RVA = "0x9FC9B0", Offset = "0x9FB7B0", VA = "0x109FC9B0")]
    private uint GenerateCondLinkageID() => new uint();

    [Token(Token = "0x600D5F8")]
    [Address(RVA = "0x9F7F00", Offset = "0x9F6D00", VA = "0x109F7F00")]
    public void ClearCondLinkageBuffBits()
    {
    }

    [Token(Token = "0x600D5F9")]
    [Address(RVA = "0x9F8420", Offset = "0x9F7220", VA = "0x109F8420")]
    private bool CondLinkageBuffAttach(
      CondAttachment cond_attachment,
      int turn = 0,
      bool is_check_resist = false)
    {
      return new bool();
    }

    [Token(Token = "0x600D5FA")]
    [Address(RVA = "0x9F9CA0", Offset = "0x9F8AA0", VA = "0x109F9CA0")]
    private BuffAttachment CreateCondLinkageBuffAttachment(
      Unit target,
      CondAttachment cond_attachment,
      BuffTypes buff_type,
      bool is_negative_value_is_buff,
      SkillParamCalcTypes calc_type,
      BaseStatus status,
      int turn)
    {
      return (BuffAttachment) null;
    }

    [Token(Token = "0x600D5FB")]
    [Address(RVA = "0xA051C0", Offset = "0xA03FC0", VA = "0x10A051C0")]
    public bool IsDamgeCureCond(EUnitCondition target) => new bool();

    [Token(Token = "0x600D5FC")]
    [Address(RVA = "0x9FAB60", Offset = "0x9F9960", VA = "0x109FAB60")]
    public void CureCondEffects(EUnitCondition target, bool updated = true, bool forced = false, bool is_damage = false)
    {
    }

    [Token(Token = "0x600D5FD")]
    [Address(RVA = "0xA1C9B0", Offset = "0xA1B7B0", VA = "0x10A1C9B0")]
    public void UpdateCondEffects()
    {
    }

    [Token(Token = "0x600D5FE")]
    [Address(RVA = "0xA1C7C0", Offset = "0xA1B5C0", VA = "0x10A1C7C0")]
    public void UpdateCondEffectTurnCount(EffectCheckTimings timing, Unit current)
    {
    }

    [Token(Token = "0x600D5FF")]
    [Address(RVA = "0xA1D110", Offset = "0xA1BF10", VA = "0x10A1D110")]
    private void UpdateDeathSentence()
    {
    }

    [Token(Token = "0x600D600")]
    [Address(RVA = "0x9F7370", Offset = "0x9F6170", VA = "0x109F7370")]
    public bool CheckEventTrigger(EEventTrigger trigger) => new bool();

    [Token(Token = "0x600D601")]
    [Address(RVA = "0x9FAEE0", Offset = "0x9F9CE0", VA = "0x109FAEE0")]
    public void DecrementTriggerCount()
    {
    }

    [Token(Token = "0x600D602")]
    [Address(RVA = "0x9F7CF0", Offset = "0x9F6AF0", VA = "0x109F7CF0")]
    public bool CheckWinEventTrigger() => new bool();

    [Token(Token = "0x600D603")]
    [Address(RVA = "0x9F7650", Offset = "0x9F6450", VA = "0x109F7650")]
    public bool CheckLoseEventTrigger() => new bool();

    [Token(Token = "0x600D604")]
    [Address(RVA = "0x9F7720", Offset = "0x9F6520", VA = "0x109F7720")]
    public bool CheckNeedEscaped() => new bool();

    [Token(Token = "0x600D605")]
    [Address(RVA = "0x9F6B80", Offset = "0x9F5980", VA = "0x109F6B80")]
    public bool CheckEnableEntry() => new bool();

    [Token(Token = "0x600D606")]
    [Address(RVA = "0xA1C690", Offset = "0xA1B490", VA = "0x10A1C690")]
    public void UpdateClockTime()
    {
    }

    [Token(Token = "0x600D607")]
    [Address(RVA = "0x9FFB00", Offset = "0x9FE900", VA = "0x109FFB00")]
    public OInt GetChargeSpeed() => new OInt();

    [Token(Token = "0x600D608")]
    [Address(RVA = "0xA1C550", Offset = "0xA1B350", VA = "0x10A1C550")]
    public bool UpdateChargeTime() => new bool();

    [Token(Token = "0x600D609")]
    [Address(RVA = "0x9F63C0", Offset = "0x9F51C0", VA = "0x109F63C0")]
    public bool CheckChargeTimeFullOver() => new bool();

    [Token(Token = "0x600D60A")]
    [Address(RVA = "0x9FF9C0", Offset = "0x9FE7C0", VA = "0x109FF9C0")]
    public OInt GetCastSpeed() => new OInt();

    [Token(Token = "0x600D60B")]
    [Address(RVA = "0x9FF890", Offset = "0x9FE690", VA = "0x109FF890")]
    public OInt GetCastSpeed(SkillData skill) => new OInt();

    [Token(Token = "0x600D60C")]
    [Address(RVA = "0xA1C350", Offset = "0xA1B150", VA = "0x10A1C350")]
    public bool UpdateCastTime() => new bool();

    [Token(Token = "0x600D60D")]
    [Address(RVA = "0x9F6190", Offset = "0x9F4F90", VA = "0x109F6190")]
    public bool CheckCastTimeFullOver() => new bool();

    [Token(Token = "0x600D60E")]
    [Address(RVA = "0xA0D340", Offset = "0xA0C140", VA = "0x10A0D340")]
    public void SetCastSkill(SkillData skill, Unit unit, Grid grid)
    {
    }

    [Token(Token = "0x600D60F")]
    [Address(RVA = "0x9F5600", Offset = "0x9F4400", VA = "0x109F5600")]
    public void CancelCastSkill()
    {
    }

    [Token(Token = "0x600D610")]
    [Address(RVA = "0xA0AAE0", Offset = "0xA098E0", VA = "0x10A0AAE0")]
    public void PushCastSkill()
    {
    }

    [Token(Token = "0x600D611")]
    [Address(RVA = "0xA0A720", Offset = "0xA09520", VA = "0x10A0A720")]
    public void PopCastSkill()
    {
    }

    [Token(Token = "0x600D612")]
    [Address(RVA = "0xA0D450", Offset = "0xA0C250", VA = "0x10A0D450")]
    public void SetCastTime(int time)
    {
    }

    [Token(Token = "0x600D613")]
    [Address(RVA = "0xA09E60", Offset = "0xA08C60", VA = "0x10A09E60")]
    public void NotifyContinue()
    {
    }

    [Token(Token = "0x600D614")]
    [Address(RVA = "0xA0A030", Offset = "0xA08E30", VA = "0x10A0A030")]
    public void NotifyMapStart()
    {
    }

    [Token(Token = "0x600D615")]
    [Address(RVA = "0xA09300", Offset = "0xA08100", VA = "0x10A09300")]
    private void NotifyActionStartSetCommand()
    {
    }

    [Token(Token = "0x600D616")]
    [Address(RVA = "0xA09520", Offset = "0xA08320", VA = "0x10A09520")]
    public void NotifyActionStart(List<Unit> others, bool IsNotUpdateTurn = false)
    {
    }

    [Token(Token = "0x600D617")]
    [Address(RVA = "0xA092D0", Offset = "0xA080D0", VA = "0x10A092D0")]
    public void NotifyActionEnd()
    {
    }

    [Token(Token = "0x600D618")]
    [Address(RVA = "0x9F5CF0", Offset = "0x9F4AF0", VA = "0x109F5CF0")]
    public void ChargeTimeDec()
    {
    }

    [Token(Token = "0x600D619")]
    [Address(RVA = "0xA09140", Offset = "0xA07F40", VA = "0x10A09140")]
    public void NotifyActionEndAfter(List<Unit> others)
    {
    }

    [Token(Token = "0x600D61A")]
    [Address(RVA = "0xA09E40", Offset = "0xA08C40", VA = "0x10A09E40")]
    public void NotifyCommandStart()
    {
    }

    [Token(Token = "0x600D61B")]
    [Address(RVA = "0xA0B6B0", Offset = "0xA0A4B0", VA = "0x10A0B6B0")]
    public void RefreshMomentBuff(List<Unit> others, bool is_direct = false, int grid_x = -1, int grid_y = -1)
    {
    }

    [Token(Token = "0x600D61C")]
    [Address(RVA = "0xA0B5C0", Offset = "0xA0A3C0", VA = "0x10A0B5C0")]
    public void RefreshMomentBuff(bool is_direct = false, int grid_x = -1, int grid_y = -1)
    {
    }

    [Token(Token = "0x600D61D")]
    [Address(RVA = "0x9F7280", Offset = "0x9F6080", VA = "0x109F7280")]
    public bool CheckEnemySide(Unit target) => new bool();

    [Token(Token = "0x600D61E")]
    [Address(RVA = "0x9FDC50", Offset = "0x9FCA50", VA = "0x109FDC50")]
    public SkillData GetAttackSkill() => (SkillData) null;

    [Token(Token = "0x600D61F")]
    [Address(RVA = "0xA043B0", Offset = "0xA031B0", VA = "0x10A043B0")]
    public void Heal(int value)
    {
    }

    [Token(Token = "0x600D620")]
    [Address(RVA = "0x9FADB0", Offset = "0x9F9BB0", VA = "0x109FADB0")]
    public void Damage(int value, bool is_check_dying = false)
    {
    }

    [Token(Token = "0x600D621")]
    [Address(RVA = "0x9FC660", Offset = "0x9FB460", VA = "0x109FC660")]
    public void ForceDead()
    {
    }

    [Token(Token = "0x600D622")]
    [Address(RVA = "0xA0DF50", Offset = "0xA0CD50", VA = "0x10A0DF50")]
    public void SetDeathCount(int count)
    {
    }

    [Token(Token = "0x600D623")]
    [Address(RVA = "0xA01DC0", Offset = "0xA00BC0", VA = "0x10A01DC0")]
    public int GetPoisonDamage() => new int();

    [Token(Token = "0x600D624")]
    [Address(RVA = "0xA019E0", Offset = "0xA007E0", VA = "0x10A019E0")]
    public int GetParalyseRate() => new int();

    [Token(Token = "0x600D625")]
    [Address(RVA = "0x9FDA50", Offset = "0x9FC850", VA = "0x109FDA50")]
    public int GetAttackRangeMin() => new int();

    [Token(Token = "0x600D626")]
    [Address(RVA = "0x9FDA10", Offset = "0x9FC810", VA = "0x109FDA10")]
    public int GetAttackRangeMin(SkillData skill) => new int();

    [Token(Token = "0x600D627")]
    [Address(RVA = "0x9FD920", Offset = "0x9FC720", VA = "0x109FD920")]
    public int GetAttackRangeMax() => new int();

    [Token(Token = "0x600D628")]
    [Address(RVA = "0x9FD840", Offset = "0x9FC640", VA = "0x109FD840")]
    public int GetAttackRangeMax(SkillData skill) => new int();

    [Token(Token = "0x600D629")]
    [Address(RVA = "0x9FDB70", Offset = "0x9FC970", VA = "0x109FDB70")]
    public int GetAttackScope() => new int();

    [Token(Token = "0x600D62A")]
    [Address(RVA = "0x9FDAA0", Offset = "0x9FC8A0", VA = "0x109FDAA0")]
    public int GetAttackScope(SkillData skill) => new int();

    [Token(Token = "0x600D62B")]
    [Address(RVA = "0x9FD690", Offset = "0x9FC490", VA = "0x109FD690")]
    public int GetAttackHeight() => new int();

    [Token(Token = "0x600D62C")]
    [Address(RVA = "0x9FD770", Offset = "0x9FC570", VA = "0x109FD770")]
    public int GetAttackHeight(SkillData skill, bool is_range = false) => new int();

    [Token(Token = "0x600D62D")]
    [Address(RVA = "0xA0D4F0", Offset = "0xA0C2F0", VA = "0x10A0D4F0")]
    public void SetCommandMoved()
    {
    }

    [Token(Token = "0x600D62E")]
    [Address(RVA = "0xA014D0", Offset = "0xA002D0", VA = "0x10A014D0")]
    public int GetMoveCount(bool bCondOnly = false) => new int();

    [Token(Token = "0x600D62F")]
    [Address(RVA = "0xA01970", Offset = "0xA00770", VA = "0x10A01970")]
    public int GetMoveHeight() => new int();

    [Token(Token = "0x600D630")]
    [Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x10A0ECA0")]
    public void SetSearchRange(int value)
    {
    }

    [Token(Token = "0x600D631")]
    [Address(RVA = "0xA02670", Offset = "0xA01470", VA = "0x10A02670")]
    public int GetSearchRange() => new int();

    [Token(Token = "0x600D632")]
    [Address(RVA = "0xA00250", Offset = "0x9FF050", VA = "0x10A00250")]
    public int GetCombination() => new int();

    [Token(Token = "0x600D633")]
    [Address(RVA = "0xA001E0", Offset = "0x9FEFE0", VA = "0x10A001E0")]
    public int GetCombinationRange() => new int();

    [Token(Token = "0x600D634")]
    [Address(RVA = "0x9FCA60", Offset = "0x9FB860", VA = "0x109FCA60")]
    public AbilityData GetAbilityData(long iid) => (AbilityData) null;

    [Token(Token = "0x600D635")]
    [Address(RVA = "0xA027A0", Offset = "0xA015A0", VA = "0x10A027A0")]
    public SkillData GetSkillData(string iname) => (SkillData) null;

    [Token(Token = "0x600D636")]
    [Address(RVA = "0xA03610", Offset = "0xA02410", VA = "0x10A03610")]
    public int GetSkillUsedCost(SkillData skill) => new int();

    [Token(Token = "0x600D637")]
    [Address(RVA = "0xA04240", Offset = "0xA03040", VA = "0x10A04240")]
    public EElement GetWeakElement() => new EElement();

    [Token(Token = "0x600D638")]
    [Address(RVA = "0x9F4950", Offset = "0x9F3750", VA = "0x109F4950")]
    public int CalcParamRecover(int val) => new int();

    [Token(Token = "0x600D639")]
    [Address(RVA = "0x9FE030", Offset = "0x9FCE30", VA = "0x109FE030")]
    public int GetAutoHpHealValue() => new int();

    [Token(Token = "0x600D63A")]
    [Address(RVA = "0x9F6050", Offset = "0x9F4E50", VA = "0x109F6050")]
    public bool CheckAutoHpHeal() => new bool();

    [Token(Token = "0x600D63B")]
    [Address(RVA = "0x9FEC40", Offset = "0x9FDA40", VA = "0x109FEC40")]
    public int GetAutoMpHealValue() => new int();

    [Token(Token = "0x600D63C")]
    [Address(RVA = "0x9F6070", Offset = "0x9F4E70", VA = "0x109F6070")]
    public bool CheckAutoMpHeal() => new bool();

    [Token(Token = "0x600D63D")]
    [Address(RVA = "0x9F7430", Offset = "0x9F6230", VA = "0x109F7430")]
    public bool CheckItemDrop(bool waitDirection = false) => new bool();

    [Token(Token = "0x600D63E")]
    [Address(RVA = "0x9F5F60", Offset = "0x9F4D60", VA = "0x109F5F60")]
    public bool CheckActionSkillBuffAttachments(BuffTypes type) => new bool();

    [Token(Token = "0x600D63F")]
    [Address(RVA = "0xA04930", Offset = "0xA03730", VA = "0x10A04930")]
    public bool IsAIActionTable() => new bool();

    [Token(Token = "0x600D640")]
    [Address(RVA = "0xA005B0", Offset = "0x9FF3B0", VA = "0x10A005B0")]
    public AIAction GetCurrentAIAction() => (AIAction) null;

    [Token(Token = "0x600D641")]
    [Address(RVA = "0xA08F70", Offset = "0xA07D70", VA = "0x10A08F70")]
    public void NextAIAction()
    {
    }

    [Token(Token = "0x600D642")]
    [Address(RVA = "0xA0CC50", Offset = "0xA0BA50", VA = "0x10A0CC50")]
    public AIAction SetAIAction(int index) => (AIAction) null;

    [Token(Token = "0x600D643")]
    [Address(RVA = "0x9FCA40", Offset = "0x9FB840", VA = "0x109FCA40")]
    public List<AIAction> GetAIActionList() => (List<AIAction>) null;

    [Token(Token = "0x600D644")]
    [Address(RVA = "0xA049E0", Offset = "0xA037E0", VA = "0x10A049E0")]
    public bool IsAIPatrolTable() => new bool();

    [Token(Token = "0x600D645")]
    [Address(RVA = "0xA00730", Offset = "0x9FF530", VA = "0x10A00730")]
    public AIPatrolPoint GetCurrentPatrolPoint() => (AIPatrolPoint) null;

    [Token(Token = "0x600D646")]
    [Address(RVA = "0xA09080", Offset = "0xA07E80", VA = "0x10A09080")]
    public void NextPatrolPoint()
    {
    }

    [Token(Token = "0x600D647")]
    [Address(RVA = "0xA00420", Offset = "0x9FF220", VA = "0x10A00420")]
    public int GetConditionPriority(SkillData skill, SkillEffectTargets target) => new int();

    [Token(Token = "0x600D648")]
    [Address(RVA = "0x9FF6A0", Offset = "0x9FE4A0", VA = "0x109FF6A0")]
    public int GetBuffPriority(SkillData skill, SkillEffectTargets target) => new int();

    [Token(Token = "0x600D649")]
    [Address(RVA = "0x9FCB30", Offset = "0x9FB930", VA = "0x109FCB30")]
    public int GetActionSkillBuffValue(BuffTypes type, SkillParamCalcTypes calc, ParamTypes param)
    {
      return new int();
    }

    [Token(Token = "0x600D64A")]
    [Address(RVA = "0xA00A20", Offset = "0x9FF820", VA = "0x10A00A20")]
    public void GetEnableBetterBuffEffect(
      Unit self,
      SkillData skill,
      SkillEffectTargets effect_target,
      out int buff_count,
      out int buff_value,
      bool bRequestOnly = false)
    {
    }

    [Token(Token = "0x600D64B")]
    [Address(RVA = "0xA07180", Offset = "0xA05F80", VA = "0x10A07180")]
    public bool IsResistBuff(
      Unit self,
      BuffTypes buff_type,
      BuffEffect effect,
      BuffEffect.BuffTarget buff_target)
    {
      return new bool();
    }

    [Token(Token = "0x600D64C")]
    [Address(RVA = "0xA074C0", Offset = "0xA062C0", VA = "0x10A074C0")]
    private bool IsResistStatusBuff(
      BuffTypes buff_type,
      BuffEffect.BuffTarget buff_target,
      int border)
    {
      return new bool();
    }

    [Token(Token = "0x17001C6F")]
    public bool ReqRevive
    {
      [Token(Token = "0x600D64D"), Address(RVA = "0xA23030", Offset = "0xA21E30", VA = "0x10A23030")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D64E"), Address(RVA = "0xA24270", Offset = "0xA23070", VA = "0x10A24270")] set
      {
      }
    }

    [Token(Token = "0x600D64F")]
    [Address(RVA = "0xA03E20", Offset = "0xA02C20", VA = "0x10A03E20")]
    public string GetUnitSkinVoiceSheetName(int jobIndex = -1) => (string) null;

    [Token(Token = "0x600D650")]
    [Address(RVA = "0xA03DF0", Offset = "0xA02BF0", VA = "0x10A03DF0")]
    public string GetUnitSkinVoiceCueName(int jobIndex = -1) => (string) null;

    [Token(Token = "0x600D651")]
    [Address(RVA = "0xA07A30", Offset = "0xA06830", VA = "0x10A07A30")]
    public void LoadBattleVoice()
    {
    }

    [Token(Token = "0x600D652")]
    [Address(RVA = "0xA0A6F0", Offset = "0xA094F0", VA = "0x10A0A6F0")]
    public void PlayBattleVoice(string cueID)
    {
    }

    [Token(Token = "0x600D653")]
    [Address(RVA = "0x9F5360", Offset = "0x9F4160", VA = "0x109F5360")]
    public int CalcTowerDamege() => new int();

    [Token(Token = "0x600D654")]
    [Address(RVA = "0xA040C0", Offset = "0xA02EC0", VA = "0x10A040C0")]
    public Unit GetUnitUseCollaboSkill(SkillData skill, bool is_use_tuc = false) => (Unit) null;

    [Token(Token = "0x600D655")]
    [Address(RVA = "0xA03E50", Offset = "0xA02C50", VA = "0x10A03E50")]
    public Unit GetUnitUseCollaboSkill(SkillData skill, int ux, int uy) => (Unit) null;

    [Token(Token = "0x600D656")]
    [Address(RVA = "0xA07710", Offset = "0xA06510", VA = "0x10A07710")]
    public bool IsUseSkillCollabo(SkillData skill, bool is_use_tuc = false) => new bool();

    [Token(Token = "0x600D657")]
    [Address(RVA = "0xA03180", Offset = "0xA01F80", VA = "0x10A03180")]
    public SkillData GetSkillForUseCount(string skill_iname, int offs = 0) => (SkillData) null;

    [Token(Token = "0x17001C70")]
    public bool IsNormalSize
    {
      [Token(Token = "0x600D658"), Address(RVA = "0xA22BB0", Offset = "0xA219B0", VA = "0x10A22BB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C71")]
    public bool IsThrow
    {
      [Token(Token = "0x600D659"), Address(RVA = "0xA22D00", Offset = "0xA21B00", VA = "0x10A22D00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D65A")]
    [Address(RVA = "0xA23790", Offset = "0xA22590", VA = "0x10A23790")]
    private bool setRelatedBuff(int grid_x, int grid_y, bool is_direct = false) => new bool();

    [Token(Token = "0x600D65B")]
    [Address(RVA = "0x9FD3D0", Offset = "0x9FC1D0", VA = "0x109FD3D0")]
    public int GetAllyUnitNum(Unit target_unit) => new int();

    [Token(Token = "0x600D65C")]
    [Address(RVA = "0xA01420", Offset = "0xA00220", VA = "0x10A01420")]
    public int GetMapBreakNowStage(int hp) => new int();

    [Token(Token = "0x600D65D")]
    [Address(RVA = "0xA0DF20", Offset = "0xA0CD20", VA = "0x10A0DF20")]
    public void SetCreateBreakObj(string break_obj_id, int create_clock)
    {
    }

    [Token(Token = "0x600D65E")]
    [Address(RVA = "0x9F1B80", Offset = "0x9F0980", VA = "0x109F1B80")]
    public void BeginDropDirection()
    {
    }

    [Token(Token = "0x600D65F")]
    [Address(RVA = "0x9FBD50", Offset = "0x9FAB50", VA = "0x109FBD50")]
    public void EndDropDirection()
    {
    }

    [Token(Token = "0x600D660")]
    [Address(RVA = "0xA053A0", Offset = "0xA041A0", VA = "0x10A053A0")]
    public bool IsDropDirection() => new bool();

    [Token(Token = "0x17001C72")]
    public bool IsKnockBack
    {
      [Token(Token = "0x600D661"), Address(RVA = "0xA22B60", Offset = "0xA21960", VA = "0x10A22B60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C73")]
    public bool IsChanging
    {
      [Token(Token = "0x600D662"), Address(RVA = "0xA22460", Offset = "0xA21260", VA = "0x10A22460")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D663")]
    [Address(RVA = "0x9FC020", Offset = "0x9FAE20", VA = "0x109FC020")]
    public bool ExecuteAbilityChange(
      AbilityParam fr_ap,
      AbilityParam to_ap,
      int turn,
      bool is_reset)
    {
      return new bool();
    }

    [Token(Token = "0x600D664")]
    [Address(RVA = "0xA0B100", Offset = "0xA09F00", VA = "0x10A0B100")]
    public void RefreshBattleAbilitysAndSkills()
    {
    }

    [Token(Token = "0x600D665")]
    [Address(RVA = "0x9F9630", Offset = "0x9F8430", VA = "0x109F9630")]
    public bool CreateAddedAbilityAndSkills(AbilityParam ap, int ab_exp, bool is_none_category)
    {
      return new bool();
    }

    [Token(Token = "0x600D666")]
    [Address(RVA = "0xA00DF0", Offset = "0x9FFBF0", VA = "0x10A00DF0")]
    private long GetFreeAbilityIID() => new long();

    [Token(Token = "0x600D667")]
    [Address(RVA = "0xA1B150", Offset = "0xA19F50", VA = "0x10A1B150")]
    public void UpdateAbilityChange()
    {
    }

    [Token(Token = "0x600D668")]
    [Address(RVA = "0x9FB0D0", Offset = "0x9F9ED0", VA = "0x109FB0D0")]
    public void DtuCopyTo(Unit from_unit, bool is_cancel)
    {
    }

    [Token(Token = "0x600D669")]
    [Address(RVA = "0x9FBA20", Offset = "0x9FA820", VA = "0x109FBA20")]
    public void DtuSkillUseCountCopyTo(Unit from_unit)
    {
    }

    [Token(Token = "0x600D66A")]
    [Address(RVA = "0xA009E0", Offset = "0x9FF7E0", VA = "0x10A009E0")]
    public Unit GetDtuFromUnitOrigin() => (Unit) null;

    [Token(Token = "0x600D66B")]
    [Address(RVA = "0x9FBD60", Offset = "0x9FAB60", VA = "0x109FBD60")]
    public void EntryInspIns(long aiid, int slot_no, bool valid = false, int check_ctr = -1)
    {
    }

    [Token(Token = "0x600D66C")]
    [Address(RVA = "0x9F9EC0", Offset = "0x9F8CC0", VA = "0x109F9EC0")]
    public Unit.UnitInsp CreateInsp(long aiid, int slot_no = 0, bool valid = false, int check_ctr = 1)
    {
      return (Unit.UnitInsp) null;
    }

    [Token(Token = "0x600D66D")]
    [Address(RVA = "0xA012D0", Offset = "0xA000D0", VA = "0x10A012D0")]
    public bool GetInspSlotNo(ArtifactData artifact, out int slot_no) => new bool();

    [Token(Token = "0x600D66E")]
    [Address(RVA = "0x9F17E0", Offset = "0x9F05E0", VA = "0x109F17E0")]
    public bool ApplyInspIns(ArtifactData artifact) => new bool();

    [Token(Token = "0x600D66F")]
    [Address(RVA = "0x9FBEC0", Offset = "0x9FACC0", VA = "0x109FBEC0")]
    public bool EntryInspUse(long aiid) => new bool();

    [Token(Token = "0x600D670")]
    [Address(RVA = "0xA063E0", Offset = "0xA051E0", VA = "0x10A063E0")]
    public bool IsFtgtTargetValid() => new bool();

    [Token(Token = "0x600D671")]
    [Address(RVA = "0xA063C0", Offset = "0xA051C0", VA = "0x10A063C0")]
    public bool IsFtgtFromValid() => new bool();

    [Token(Token = "0x600D672")]
    [Address(RVA = "0xA1B330", Offset = "0xA1A130", VA = "0x10A1B330")]
    private bool UpdateAdditionalSkills() => new bool();

    [Token(Token = "0x600D673")]
    [Address(RVA = "0x9FC420", Offset = "0x9FB220", VA = "0x109FC420")]
    public SkillData FindAdditionalSkills(string skill_iname) => (SkillData) null;

    [Token(Token = "0x17001C74")]
    public long BossLongBaseMaxHP
    {
      [Token(Token = "0x600D674"), Address(RVA = "0xA21D10", Offset = "0xA20B10", VA = "0x10A21D10")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17001C75")]
    public long BossLongMaxHP
    {
      [Token(Token = "0x600D675"), Address(RVA = "0xA21D50", Offset = "0xA20B50", VA = "0x10A21D50")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17001C76")]
    public long BossLongCurHP
    {
      [Token(Token = "0x600D676"), Address(RVA = "0xA21D30", Offset = "0xA20B30", VA = "0x10A21D30")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x600D677")]
    [Address(RVA = "0xA04890", Offset = "0xA03690", VA = "0x10A04890")]
    private void InternalReflectBossCurrentHP()
    {
    }

    [Token(Token = "0x600D678")]
    [Address(RVA = "0xA076E0", Offset = "0xA064E0", VA = "0x10A076E0")]
    public bool IsUseBossLongHP() => new bool();

    [Token(Token = "0x600D679")]
    [Address(RVA = "0x9F01F0", Offset = "0x9EEFF0", VA = "0x109F01F0")]
    public void AddBossCurrentHP(int val)
    {
    }

    [Token(Token = "0x600D67A")]
    [Address(RVA = "0xA0AB20", Offset = "0xA09920", VA = "0x10A0AB20")]
    public void ReflectBossCurrentHP(bool is_reset = false)
    {
    }

    [Token(Token = "0x600D67B")]
    [Address(RVA = "0xA0CE50", Offset = "0xA0BC50", VA = "0x10A0CE50")]
    public void SetBossMaxHP(long max_hp)
    {
    }

    [Token(Token = "0x600D67C")]
    [Address(RVA = "0xA0CDE0", Offset = "0xA0BBE0", VA = "0x10A0CDE0")]
    public void SetBossCurrentHP(long hp)
    {
    }

    [Token(Token = "0x600D67D")]
    [Address(RVA = "0xA006E0", Offset = "0x9FF4E0", VA = "0x10A006E0")]
    public long GetCurrentHP() => new long();

    [Token(Token = "0x600D67E")]
    [Address(RVA = "0xA01480", Offset = "0xA00280", VA = "0x10A01480")]
    public long GetMaximumHP() => new long();

    [Token(Token = "0x600D67F")]
    [Address(RVA = "0x9FF4D0", Offset = "0x9FE2D0", VA = "0x109FF4D0")]
    public long GetBaseHP() => new long();

    [Token(Token = "0x600D680")]
    [Address(RVA = "0xA04F40", Offset = "0xA03D40", VA = "0x10A04F40")]
    public bool IsCanUseAutoSkill(SkillData skill, QuestTypes quest_type) => new bool();

    [Token(Token = "0x600D681")]
    [Address(RVA = "0xA04B10", Offset = "0xA03910", VA = "0x10A04B10")]
    public bool IsAddedSkill(string skill_id) => new bool();

    [Token(Token = "0x600D682")]
    [Address(RVA = "0x9FAAF0", Offset = "0x9F98F0", VA = "0x109FAAF0")]
    private bool CreateRevivalSkills() => new bool();

    [Token(Token = "0x600D683")]
    [Address(RVA = "0xA1D7E0", Offset = "0xA1C5E0", VA = "0x10A1D7E0")]
    private bool UpdateRevivalSkills() => new bool();

    [Token(Token = "0x600D684")]
    [Address(RVA = "0x9FC5A0", Offset = "0x9FB3A0", VA = "0x109FC5A0")]
    public SkillData FindRevivalSkills(string skill_iname) => (SkillData) null;

    [Token(Token = "0x600D685")]
    [Address(RVA = "0xA0C0D0", Offset = "0xA0AED0", VA = "0x10A0C0D0")]
    public void ResumeRevival(BattleSuspend.Data.UnitInfo.Revival revival)
    {
    }

    [Token(Token = "0x600D686")]
    [Address(RVA = "0x9F83B0", Offset = "0x9F71B0", VA = "0x109F83B0")]
    private void ClearSkillRevival()
    {
    }

    [Token(Token = "0x600D687")]
    [Address(RVA = "0x9FA900", Offset = "0x9F9700", VA = "0x109FA900")]
    public void CreateRevivalBuffAttachment(AttackDetailTypes type)
    {
    }

    [Token(Token = "0x600D688")]
    [Address(RVA = "0xA0F100", Offset = "0xA0DF00", VA = "0x10A0F100")]
    public void SetSkillRevivalList(SkillData skill, AttackDetailTypes type)
    {
    }

    [Token(Token = "0x600D689")]
    [Address(RVA = "0xA07930", Offset = "0xA06730", VA = "0x10A07930")]
    public bool IsUsedSkillRevival(SkillData skill) => new bool();

    [Token(Token = "0x600D68A")]
    [Address(RVA = "0xA1DE60", Offset = "0xA1CC60", VA = "0x10A1DE60")]
    public void UpdateSkillRevivalCount(SkillData skill, int cnt)
    {
    }

    [Token(Token = "0x600D68B")]
    [Address(RVA = "0xA03380", Offset = "0xA02180", VA = "0x10A03380")]
    public SkillData GetSkillRevival() => (SkillData) null;

    [Token(Token = "0x600D68C")]
    [Address(RVA = "0xA032D0", Offset = "0xA020D0", VA = "0x10A032D0")]
    public SkillData GetSkillRevivalExecute(SkillData skill) => (SkillData) null;

    [Token(Token = "0x600D68D")]
    [Address(RVA = "0xA0EA40", Offset = "0xA0D840", VA = "0x10A0EA40")]
    public void SetRevivalBuffAttachment(
      SkillData skill,
      EffectCheckTimings chk_timing,
      AttackDetailTypes type)
    {
    }

    [Token(Token = "0x600D68E")]
    [Address(RVA = "0xA0C6E0", Offset = "0xA0B4E0", VA = "0x10A0C6E0")]
    public void RevivalInit()
    {
    }

    [Token(Token = "0x600D68F")]
    [Address(RVA = "0x9F9C30", Offset = "0x9F8A30", VA = "0x109F9C30")]
    private void CreateAutoHpJudgeSkills()
    {
    }

    [Token(Token = "0x600D690")]
    [Address(RVA = "0x9F8260", Offset = "0x9F7060", VA = "0x109F8260")]
    public void ClearSkillAutoHpJudge()
    {
    }

    [Token(Token = "0x600D691")]
    [Address(RVA = "0xA1B950", Offset = "0xA1A750", VA = "0x10A1B950")]
    private bool UpdateAutoHpJudgeSkills() => new bool();

    [Token(Token = "0x600D692")]
    [Address(RVA = "0x9FC4E0", Offset = "0x9FB2E0", VA = "0x109FC4E0")]
    public SkillData FindAutoHpJudgeSkills(string skill_iname) => (SkillData) null;

    [Token(Token = "0x600D693")]
    [Address(RVA = "0xA026A0", Offset = "0xA014A0", VA = "0x10A026A0")]
    public List<SkillData> GetSkillAutoHpJudge() => (List<SkillData>) null;

    [Token(Token = "0x600D694")]
    [Address(RVA = "0x9FE850", Offset = "0x9FD650", VA = "0x109FE850")]
    public string GetAutoHpJudgeSkill(SkillData skill) => (string) null;

    [Token(Token = "0x600D695")]
    [Address(RVA = "0x9F1B10", Offset = "0x9F0910", VA = "0x109F1B10")]
    public void AutoHpJudgeSkillListCopyTo(List<Unit.UnitAutoHpJudge> list)
    {
    }

    [Token(Token = "0x600D696")]
    [Address(RVA = "0xA0BD40", Offset = "0xA0AB40", VA = "0x10A0BD40")]
    private void ResumeAutoHpJudge(
      BattleSuspend.Data.UnitInfo.AutoHpJudge autoHpJudge)
    {
    }

    [Token(Token = "0x600D697")]
    [Address(RVA = "0x9F7810", Offset = "0x9F6610", VA = "0x109F7810")]
    public void CheckReleaseCondBomb(int use_jewel)
    {
    }

    [Token(Token = "0x600D698")]
    [Address(RVA = "0x9F7BA0", Offset = "0x9F69A0", VA = "0x109F7BA0")]
    public void CheckReleaseCondSlip(int heal_hp, int heal_count = 1)
    {
    }

    [Token(Token = "0x600D699")]
    [Address(RVA = "0xA0B8C0", Offset = "0xA0A6C0", VA = "0x10A0B8C0")]
    public void ReleaseCondFreeze(int damage)
    {
    }

    [Token(Token = "0x600D69A")]
    [Address(RVA = "0xA04EE0", Offset = "0xA03CE0", VA = "0x10A04EE0")]
    public bool IsBuffCondition() => new bool();

    [Token(Token = "0x600D69B")]
    [Address(RVA = "0x9F79F0", Offset = "0x9F67F0", VA = "0x109F79F0")]
    public bool CheckReleaseCondDown(int heal_Jewel = 0) => new bool();

    [Token(Token = "0x600D69C")]
    [Address(RVA = "0xA05040", Offset = "0xA03E40", VA = "0x10A05040")]
    public bool IsCondDownReleaseJewel(CondAttachment ca, int heal_Jewel = 0) => new bool();

    [Token(Token = "0x600D69D")]
    [Address(RVA = "0xA00280", Offset = "0x9FF080", VA = "0x10A00280")]
    public int GetCondDownHealJewel(int jewel) => new int();

    [Token(Token = "0x600D69E")]
    [Address(RVA = "0xA00350", Offset = "0x9FF150", VA = "0x10A00350")]
    public int GetCondDownHealMaxJewel(int maxJewel) => new int();

    [Token(Token = "0x600D69F")]
    [Address(RVA = "0xA066C0", Offset = "0xA054C0", VA = "0x10A066C0")]
    private bool IsManipulateBreak(Unit.UnitManipulate manip) => new bool();

    [Token(Token = "0x600D6A0")]
    [Address(RVA = "0x9F9FD0", Offset = "0x9F8DD0", VA = "0x109F9FD0")]
    public Unit.UnitManipulate CreateManipulateDamage(SkillData skill, bool isCreate = true)
    {
      return (Unit.UnitManipulate) null;
    }

    [Token(Token = "0x600D6A1")]
    [Address(RVA = "0x9FA270", Offset = "0x9F9070", VA = "0x109FA270")]
    public Unit.UnitManipulate CreateManipulateElem(SkillData skill, int elem, bool isCreate = true)
    {
      return (Unit.UnitManipulate) null;
    }

    [Token(Token = "0x600D6A2")]
    [Address(RVA = "0x9F04A0", Offset = "0x9EF2A0", VA = "0x109F04A0")]
    public void AddManipulateSkill(SkillData skill)
    {
    }

    [Token(Token = "0x600D6A3")]
    [Address(RVA = "0xA03260", Offset = "0xA02060", VA = "0x10A03260")]
    public Unit.UnitManipulate GetSkillManipulateActivate(SkillData skill, int damage)
    {
      return (Unit.UnitManipulate) null;
    }

    [Token(Token = "0x600D6A4")]
    [Address(RVA = "0xA1D370", Offset = "0xA1C170", VA = "0x10A1D370")]
    private void UpdateManipulateTurn()
    {
    }

    [Token(Token = "0x600D6A5")]
    [Address(RVA = "0x9F48B0", Offset = "0x9F36B0", VA = "0x109F48B0")]
    public void CalcManipulateDamage(Unit.UnitManipulate manipulate, int damage)
    {
    }

    [Token(Token = "0x600D6A6")]
    [Address(RVA = "0x9F8320", Offset = "0x9F7120", VA = "0x109F8320")]
    public void ClearSkillManipulate()
    {
    }

    [Token(Token = "0x600D6A7")]
    [Address(RVA = "0xA0C540", Offset = "0xA0B340", VA = "0x10A0C540")]
    public void ResumeSkillManipulateBreak(
      BattleSuspend.Data.UnitInfo.SkillManipulateBreak manipulateBreak)
    {
    }

    [Token(Token = "0x600D6A8")]
    [Address(RVA = "0xA0C5B0", Offset = "0xA0B3B0", VA = "0x10A0C5B0")]
    public void ResumeSkillManipulate(
      BattleSuspend.Data.UnitInfo.SkillManipulate manipulate)
    {
    }

    [Token(Token = "0x600D6A9")]
    [Address(RVA = "0xA07E30", Offset = "0xA06C30", VA = "0x10A07E30")]
    private void ManipulatePassiveBreak(Unit.UnitManipulate ump)
    {
    }

    [Token(Token = "0x600D6AA")]
    [Address(RVA = "0x9FA450", Offset = "0x9F9250", VA = "0x109FA450")]
    public void CreateManipullatePassiveSkill()
    {
    }

    [Token(Token = "0x600D6AB")]
    [Address(RVA = "0xA07C40", Offset = "0xA06A40", VA = "0x10A07C40")]
    private bool ManipulateBreak(
      Unit.UnitManipulate manipulate,
      SkillManipulatePierceParam pierce,
      bool isPassive = false)
    {
      return new bool();
    }

    [Token(Token = "0x600D6AC")]
    [Address(RVA = "0xA07B20", Offset = "0xA06920", VA = "0x10A07B20")]
    public bool ManipulateBreakList(SkillData skill) => new bool();

    [Token(Token = "0x600D6AD")]
    [Address(RVA = "0xA03960", Offset = "0xA02760", VA = "0x10A03960")]
    public Unit.UnitManipulate GetUnitManipulateFromType(
      DamageTypes type,
      int elem,
      SkillData skill = null,
      bool is_reflect = true,
      bool is_absorpt = true)
    {
      return (Unit.UnitManipulate) null;
    }

    [Token(Token = "0x600D6AE")]
    [Address(RVA = "0xA06AD0", Offset = "0xA058D0", VA = "0x10A06AD0")]
    public bool IsManipulatePassive(Unit.UnitManipulate manip) => new bool();

    [Token(Token = "0x600D6AF")]
    [Address(RVA = "0xA06770", Offset = "0xA05570", VA = "0x10A06770")]
    public bool IsManipulateEqual(List<Unit.UnitManipulate> list) => new bool();

    [Token(Token = "0x600D6B0")]
    [Address(RVA = "0x9F9080", Offset = "0x9F7E80", VA = "0x109F9080")]
    public List<Unit.UnitManipulate> CopyToManipulate() => (List<Unit.UnitManipulate>) null;

    [Token(Token = "0x600D6B1")]
    [Address(RVA = "0xA0ECF0", Offset = "0xA0DAF0", VA = "0x10A0ECF0")]
    public void SetSkillDistanceData(string iname, SkillData skill)
    {
    }

    [Token(Token = "0x600D6B2")]
    [Address(RVA = "0xA1DCC0", Offset = "0xA1CAC0", VA = "0x10A1DCC0")]
    public void UpdateSkillDistanceDataTurn()
    {
    }

    [Token(Token = "0x600D6B3")]
    [Address(RVA = "0x9FCC60", Offset = "0x9FBA60", VA = "0x109FCC60")]
    public SkillDistanceDataParam GetActiveSkillDistanceParam(
      ESkillDistanceKind kind,
      SkillData skill,
      int distance)
    {
      return (SkillDistanceDataParam) null;
    }

    [Token(Token = "0x600D6B4")]
    [Address(RVA = "0x9FDC80", Offset = "0x9FCA80", VA = "0x109FDC80")]
    public SkillDistanceDataParam GetAttckSkillDistanceParam(
      ESkillDistanceKind kind,
      SkillData skill,
      int distance)
    {
      return (SkillDistanceDataParam) null;
    }

    [Token(Token = "0x600D6B5")]
    [Address(RVA = "0xA0C2A0", Offset = "0xA0B0A0", VA = "0x10A0C2A0")]
    public void ResumeSkillDistance(
      BattleSuspend.Data.UnitInfo.SkillDistance skillDistance)
    {
    }

    [Token(Token = "0x600D6B6")]
    [Address(RVA = "0x9F82C0", Offset = "0x9F70C0", VA = "0x109F82C0")]
    public void ClearSkillDistance()
    {
    }

    [Token(Token = "0x600D6B7")]
    [Address(RVA = "0x9F9310", Offset = "0x9F8110", VA = "0x109F9310")]
    public List<Unit.UnitSkillDistance> CopyToSkillDistance()
    {
      return (List<Unit.UnitSkillDistance>) null;
    }

    [Token(Token = "0x600D6B8")]
    [Address(RVA = "0xA0A760", Offset = "0xA09560", VA = "0x10A0A760")]
    public void PreemptBuffRemove(bool is_predict_result)
    {
    }

    [Token(Token = "0x600D6B9")]
    [Address(RVA = "0xA04420", Offset = "0xA03220", VA = "0x10A04420")]
    public bool InitPreemptBuffRemove() => new bool();

    [Token(Token = "0x600D6BA")]
    [Address(RVA = "0xA0F330", Offset = "0xA0E130", VA = "0x10A0F330")]
    public void SetSuspendWeatherBuff(string buff_id, int turn)
    {
    }

    [Token(Token = "0x600D6BB")]
    [Address(RVA = "0xA0F4E0", Offset = "0xA0E2E0", VA = "0x10A0F4E0")]
    public void SetSuspendWeatherCond(
      string cond_id,
      int tur,
      int tim,
      int cdt,
      bool ipa,
      int ucd,
      long cnd,
      bool icu,
      int dmg,
      int jwl,
      int hct,
      int mdg,
      uint lid,
      Unit unit_check,
      BattleSuspend.Data.UnitInfo unit_info = null)
    {
    }

    [Token(Token = "0x600D6BC")]
    [Address(RVA = "0x9F53E0", Offset = "0x9F41E0", VA = "0x109F53E0")]
    public int CalcWeakElementAddRate(Unit defender) => new int();

    [Token(Token = "0x600D6BD")]
    [Address(RVA = "0x9F4B60", Offset = "0x9F3960", VA = "0x109F4B60")]
    public int CalcRegistElementAddRate(Unit defender) => new int();

    [Token(Token = "0x600D6BE")]
    [Address(RVA = "0xA007D0", Offset = "0x9FF5D0", VA = "0x10A007D0")]
    public int GetDecreaseEffectRate(SkillData _skill) => new int();

    [Token(Token = "0x600D6BF")]
    [Address(RVA = "0xA007A0", Offset = "0x9FF5A0", VA = "0x10A007A0")]
    private int GetDecreaseEffectRateRunePride() => new int();

    [Token(Token = "0x600D6C0")]
    [Address(RVA = "0xA0F940", Offset = "0xA0E740", VA = "0x10A0F940")]
    public void SetTeleportStartPosition(int _x, int _y)
    {
    }

    [Token(Token = "0x600D6C1")]
    [Address(RVA = "0xA06DB0", Offset = "0xA05BB0", VA = "0x10A06DB0")]
    private bool IsNPCChgTobiraMasterAbility(UnitData _unit, string _abil) => new bool();

    [Token(Token = "0x600D6C2")]
    [Address(RVA = "0xA08C60", Offset = "0xA07A60", VA = "0x10A08C60")]
    private void NPCEquipSetup(NPCSetting _npc)
    {
    }

    [Token(Token = "0x600D6C3")]
    [Address(RVA = "0xA08280", Offset = "0xA07080", VA = "0x10A08280")]
    private void NPCEquipArtifact(NPCSetting _npc)
    {
    }

    [Token(Token = "0x600D6C4")]
    [Address(RVA = "0xA084F0", Offset = "0xA072F0", VA = "0x10A084F0")]
    private void NPCEquipConceptCard(NPCSetting _npc)
    {
    }

    [Token(Token = "0x600D6C5")]
    [Address(RVA = "0xA08E80", Offset = "0xA07C80", VA = "0x10A08E80")]
    private void NPCEquipTruth(NPCSetting _npc)
    {
    }

    [Token(Token = "0x600D6C6")]
    [Address(RVA = "0xA08E00", Offset = "0xA07C00", VA = "0x10A08E00")]
    private void NPCEquipSkin(NPCSetting _npc)
    {
    }

    [Token(Token = "0x600D6C7")]
    [Address(RVA = "0xA08870", Offset = "0xA07670", VA = "0x10A08870")]
    private void NPCEquipQuestAbility(NPCSetting _npc)
    {
    }

    [Token(Token = "0x600D6C8")]
    [Address(RVA = "0x9F2A10", Offset = "0x9F1810", VA = "0x109F2A10")]
    public void CalcCurrentStatus(bool is_initialized = false, bool is_predict = false)
    {
    }

    [Token(Token = "0x600D6C9")]
    [Address(RVA = "0x9F1B90", Offset = "0x9F0990", VA = "0x109F1B90")]
    private bool CalcBuffStatus(BuffAttachment buff, int enemy_dead_count) => new bool();

    [Token(Token = "0x17001C77")]
    public Unit RageTarget
    {
      [Token(Token = "0x600D6CA"), Address(RVA = "0xA23020", Offset = "0xA21E20", VA = "0x10A23020")] get
      {
        return (Unit) null;
      }
    }

    [Token(Token = "0x600D6CB")]
    [Address(RVA = "0xA02470", Offset = "0xA01270", VA = "0x10A02470")]
    public Unit GetRageTarget() => (Unit) null;

    [Token(Token = "0x600D6CC")]
    [Address(RVA = "0x9FAD70", Offset = "0x9F9B70", VA = "0x109FAD70")]
    public void CureRageCondition()
    {
    }

    [Token(Token = "0x600D6CD")]
    [Address(RVA = "0x9F5C90", Offset = "0x9F4A90", VA = "0x109F5C90")]
    public void ChangeRageTarget(Unit from_unit, Unit new_unit)
    {
    }

    [Token(Token = "0x600D6CE")]
    [Address(RVA = "0xA210F0", Offset = "0xA1FEF0", VA = "0x10A210F0")]
    public Unit()
    {
    }

    [Token(Token = "0x600D6CF")]
    [Address(RVA = "0xA1E2D0", Offset = "0xA1D0D0", VA = "0x10A1E2D0")]
    static Unit()
    {
    }

    [Token(Token = "0x2002D92")]
    [MessagePackObject(true)]
    public class DropItem
    {
      [Token(Token = "0x400E45D")]
      [FieldOffset(Offset = "0x8")]
      public ItemParam itemParam;
      [Token(Token = "0x400E45E")]
      [FieldOffset(Offset = "0xC")]
      public ConceptCardParam conceptCardParam;
      [Token(Token = "0x400E45F")]
      [FieldOffset(Offset = "0x10")]
      public OInt num;
      [Token(Token = "0x400E460")]
      [FieldOffset(Offset = "0x24")]
      public OBool is_secret;

      [Token(Token = "0x17001C78")]
      public bool isItem
      {
        [Token(Token = "0x600D6D1"), Address(RVA = "0x39EF50", Offset = "0x39DD50", VA = "0x1039EF50")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17001C79")]
      public bool isConceptCard
      {
        [Token(Token = "0x600D6D2"), Address(RVA = "0x2B0090", Offset = "0x2AEE90", VA = "0x102B0090")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17001C7A")]
      public string Iname
      {
        [Token(Token = "0x600D6D3"), Address(RVA = "0xA46F00", Offset = "0xA45D00", VA = "0x10A46F00")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17001C7B")]
      public EBattleRewardType BattleRewardType
      {
        [Token(Token = "0x600D6D4"), Address(RVA = "0xA46EE0", Offset = "0xA45CE0", VA = "0x10A46EE0")] get
        {
          return new EBattleRewardType();
        }
      }

      [Token(Token = "0x600D6D5")]
      [Address(RVA = "0xA46E90", Offset = "0xA45C90", VA = "0x10A46E90")]
      public static bool IsNullOrEmpty(Unit.DropItem value) => new bool();

      [Token(Token = "0x600D6D6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public DropItem()
      {
      }
    }

    [Token(Token = "0x2002D93")]
    [MessagePackObject(true)]
    public class UnitDrop
    {
      [Token(Token = "0x400E461")]
      [FieldOffset(Offset = "0x8")]
      public List<Unit.DropItem> items;
      [Token(Token = "0x400E462")]
      [FieldOffset(Offset = "0xC")]
      public OInt exp;
      [Token(Token = "0x400E463")]
      [FieldOffset(Offset = "0x20")]
      public OInt gems;
      [Token(Token = "0x400E464")]
      [FieldOffset(Offset = "0x34")]
      public OInt gold;
      [Token(Token = "0x400E465")]
      [FieldOffset(Offset = "0x48")]
      public bool gained;

      [Token(Token = "0x600D6D7")]
      [Address(RVA = "0xA4F4A0", Offset = "0xA4E2A0", VA = "0x10A4F4A0")]
      public bool IsEnableDrop() => new bool();

      [Token(Token = "0x600D6D8")]
      [Address(RVA = "0x753970", Offset = "0x752770", VA = "0x10753970")]
      public void Drop()
      {
      }

      [Token(Token = "0x600D6D9")]
      [Address(RVA = "0xA4F290", Offset = "0xA4E090", VA = "0x10A4F290")]
      public void CopyTo(Unit.UnitDrop other)
      {
      }

      [Token(Token = "0x600D6DA")]
      [Address(RVA = "0xA4F550", Offset = "0xA4E350", VA = "0x10A4F550")]
      public UnitDrop()
      {
      }
    }

    [Token(Token = "0x2002D94")]
    [MessagePackObject(true)]
    public class UnitSteal
    {
      [Token(Token = "0x400E466")]
      [FieldOffset(Offset = "0x8")]
      public List<Unit.DropItem> items;
      [Token(Token = "0x400E467")]
      [FieldOffset(Offset = "0xC")]
      public OInt gold;
      [Token(Token = "0x400E468")]
      [FieldOffset(Offset = "0x20")]
      public bool is_item_steeled;
      [Token(Token = "0x400E469")]
      [FieldOffset(Offset = "0x21")]
      public bool is_gold_steeled;

      [Token(Token = "0x600D6DB")]
      [Address(RVA = "0xA59620", Offset = "0xA58420", VA = "0x10A59620")]
      public bool IsEnableItemSteal() => new bool();

      [Token(Token = "0x600D6DC")]
      [Address(RVA = "0x61CA90", Offset = "0x61B890", VA = "0x1061CA90")]
      public bool IsEnableGoldSteal() => new bool();

      [Token(Token = "0x600D6DD")]
      [Address(RVA = "0xA59420", Offset = "0xA58220", VA = "0x10A59420")]
      public void CopyTo(Unit.UnitSteal other)
      {
      }

      [Token(Token = "0x600D6DE")]
      [Address(RVA = "0xA59670", Offset = "0xA58470", VA = "0x10A59670")]
      public UnitSteal()
      {
      }
    }

    [Token(Token = "0x2002D95")]
    [MessagePackObject(true)]
    public class UnitShield
    {
      [Token(Token = "0x400E46A")]
      [FieldOffset(Offset = "0x8")]
      public ShieldTypes shieldType;
      [Token(Token = "0x400E46B")]
      [FieldOffset(Offset = "0x9")]
      public DamageTypes damageType;
      [Token(Token = "0x400E46C")]
      [FieldOffset(Offset = "0xC")]
      public OInt hp;
      [Token(Token = "0x400E46D")]
      [FieldOffset(Offset = "0x20")]
      public OInt hpMax;
      [Token(Token = "0x400E46E")]
      [FieldOffset(Offset = "0x34")]
      public OInt turn;
      [Token(Token = "0x400E46F")]
      [FieldOffset(Offset = "0x48")]
      public OInt turnMax;
      [Token(Token = "0x400E470")]
      [FieldOffset(Offset = "0x5C")]
      public OInt damage_rate;
      [Token(Token = "0x400E471")]
      [FieldOffset(Offset = "0x70")]
      public OInt damage_value;
      [Token(Token = "0x400E472")]
      [FieldOffset(Offset = "0x84")]
      public SkillParam skill_param;
      [Token(Token = "0x400E473")]
      [FieldOffset(Offset = "0x88")]
      public bool is_efficacy;
      [Token(Token = "0x400E474")]
      [FieldOffset(Offset = "0x89")]
      public bool is_ignore_efficacy;

      [Token(Token = "0x600D6DF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public UnitShield()
      {
      }
    }

    [Token(Token = "0x2002D96")]
    public enum eTypeMhmDamage
    {
      [Token(Token = "0x400E476")] HP,
      [Token(Token = "0x400E477")] MP,
    }

    [Token(Token = "0x2002D97")]
    [MessagePackObject(true)]
    public class UnitMhmDamage
    {
      [Token(Token = "0x400E478")]
      [FieldOffset(Offset = "0x8")]
      public Unit.eTypeMhmDamage mType;
      [Token(Token = "0x400E479")]
      [FieldOffset(Offset = "0xC")]
      public OInt mDamage;

      [Token(Token = "0x600D6E0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public UnitMhmDamage()
      {
      }

      [Token(Token = "0x600D6E1")]
      [Address(RVA = "0x9DEA90", Offset = "0x9DD890", VA = "0x109DEA90")]
      public UnitMhmDamage(Unit.eTypeMhmDamage type, int damage)
      {
      }

      [Token(Token = "0x600D6E2")]
      [Address(RVA = "0xA4F640", Offset = "0xA4E440", VA = "0x10A4F640")]
      public void CopyTo(Unit.UnitMhmDamage other)
      {
      }
    }

    [Token(Token = "0x2002D98")]
    [MessagePackObject(false)]
    public class UnitInsp
    {
      [Token(Token = "0x400E47A")]
      [FieldOffset(Offset = "0x8")]
      [Key(0)]
      public ArtifactData mArtifact;
      [Token(Token = "0x400E47B")]
      [FieldOffset(Offset = "0xC")]
      [Key(1)]
      public OInt mSlotNo;
      [Token(Token = "0x400E47C")]
      [FieldOffset(Offset = "0x20")]
      [Key(2)]
      public OBool mValid;
      [Token(Token = "0x400E47D")]
      [FieldOffset(Offset = "0x2C")]
      [Key(3)]
      public OInt mCheckCtr;

      [Token(Token = "0x600D6E3")]
      [Address(RVA = "0xA4F5C0", Offset = "0xA4E3C0", VA = "0x10A4F5C0")]
      [SerializationConstructor]
      public UnitInsp(ArtifactData artifact, int slot_no, bool valid = false, int check_ctr = 1)
      {
      }
    }

    [Token(Token = "0x2002D99")]
    [MessagePackObject(true)]
    public class UnitForcedTargeting
    {
      [Token(Token = "0x400E47E")]
      [FieldOffset(Offset = "0x8")]
      public Unit mUnit;
      [Token(Token = "0x400E47F")]
      [FieldOffset(Offset = "0xC")]
      public int mTurn;

      [Token(Token = "0x600D6E4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public UnitForcedTargeting()
      {
      }

      [Token(Token = "0x600D6E5")]
      [Address(RVA = "0x3217D0", Offset = "0x3205D0", VA = "0x103217D0")]
      public UnitForcedTargeting(Unit unit, int turn)
      {
      }
    }

    [Token(Token = "0x2002D9A")]
    [MessagePackObject(true)]
    public class UnitProtect
    {
      [Token(Token = "0x400E480")]
      [FieldOffset(Offset = "0x8")]
      public Unit target;
      [Token(Token = "0x400E481")]
      [FieldOffset(Offset = "0xC")]
      public OInt value;
      [Token(Token = "0x400E482")]
      [FieldOffset(Offset = "0x20")]
      public DamageTypes damageType;
      [Token(Token = "0x400E483")]
      [FieldOffset(Offset = "0x21")]
      public ProtectTypes type;
      [Token(Token = "0x400E484")]
      [FieldOffset(Offset = "0x24")]
      public OInt range;
      [Token(Token = "0x400E485")]
      [FieldOffset(Offset = "0x38")]
      public OInt height;
      [Token(Token = "0x400E486")]
      [FieldOffset(Offset = "0x4C")]
      public bool eternal;
      [Token(Token = "0x400E487")]
      [FieldOffset(Offset = "0x4D")]
      public bool passive;
      [Token(Token = "0x400E488")]
      [FieldOffset(Offset = "0x50")]
      public string skillIname;

      [Token(Token = "0x600D6E6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public UnitProtect()
      {
      }
    }

    [Token(Token = "0x2002D9B")]
    [MessagePackObject(true)]
    public class AbilityChange
    {
      [Token(Token = "0x400E489")]
      [FieldOffset(Offset = "0x8")]
      public List<Unit.AbilityChange.Data> mDataLists;

      [Token(Token = "0x600D6E7")]
      [Address(RVA = "0xA46B90", Offset = "0xA45990", VA = "0x10A46B90")]
      public AbilityChange()
      {
      }

      [Token(Token = "0x600D6E8")]
      [Address(RVA = "0xA46A60", Offset = "0xA45860", VA = "0x10A46A60")]
      public AbilityChange(
        AbilityParam fr_ap,
        AbilityParam to_ap,
        int turn,
        bool is_reset,
        int exp,
        bool is_infinite)
      {
      }

      [Token(Token = "0x600D6E9")]
      [Address(RVA = "0xA46660", Offset = "0xA45460", VA = "0x10A46660")]
      public void Clear()
      {
      }

      [Token(Token = "0x600D6EA")]
      [Address(RVA = "0xA465B0", Offset = "0xA453B0", VA = "0x10A465B0")]
      public void Add(
        AbilityParam fr_ap,
        AbilityParam to_ap,
        int turn,
        bool is_reset,
        int exp,
        bool is_infinite)
      {
      }

      [Token(Token = "0x600D6EB")]
      [Address(RVA = "0xA46A00", Offset = "0xA45800", VA = "0x10A46A00")]
      public void RemoveLast()
      {
      }

      [Token(Token = "0x600D6EC")]
      [Address(RVA = "0xA466D0", Offset = "0xA454D0", VA = "0x10A466D0")]
      public AbilityParam GetFromAp() => (AbilityParam) null;

      [Token(Token = "0x600D6ED")]
      [Address(RVA = "0xA46790", Offset = "0xA45590", VA = "0x10A46790")]
      public AbilityParam GetToAp() => (AbilityParam) null;

      [Token(Token = "0x600D6EE")]
      [Address(RVA = "0xA46730", Offset = "0xA45530", VA = "0x10A46730")]
      public int GetLastExp() => new int();

      [Token(Token = "0x600D6EF")]
      [Address(RVA = "0xA46960", Offset = "0xA45760", VA = "0x10A46960")]
      public bool IsInclude(AbilityParam ap) => new bool();

      [Token(Token = "0x600D6F0")]
      [Address(RVA = "0xA46860", Offset = "0xA45660", VA = "0x10A46860")]
      public bool IsCancel(AbilityParam fr_ap, AbilityParam to_ap) => new bool();

      [Token(Token = "0x600D6F1")]
      [Address(RVA = "0xA467F0", Offset = "0xA455F0", VA = "0x10A467F0")]
      public bool IsBack(AbilityParam fr_ap, AbilityParam to_ap) => new bool();

      [Token(Token = "0x2002D9C")]
      [MessagePackObject(true)]
      public class Data
      {
        [Token(Token = "0x400E48A")]
        [FieldOffset(Offset = "0x8")]
        public AbilityParam mFromAp;
        [Token(Token = "0x400E48B")]
        [FieldOffset(Offset = "0xC")]
        public AbilityParam mToAp;
        [Token(Token = "0x400E48C")]
        [FieldOffset(Offset = "0x10")]
        public int mTurn;
        [Token(Token = "0x400E48D")]
        [FieldOffset(Offset = "0x14")]
        public bool mIsReset;
        [Token(Token = "0x400E48E")]
        [FieldOffset(Offset = "0x18")]
        public int mExp;
        [Token(Token = "0x400E48F")]
        [FieldOffset(Offset = "0x1C")]
        public bool mIsInfinite;

        [Token(Token = "0x600D6F2")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Data()
        {
        }

        [Token(Token = "0x600D6F3")]
        [Address(RVA = "0xA46E40", Offset = "0xA45C40", VA = "0x10A46E40")]
        public Data(
          AbilityParam fr_ap,
          AbilityParam to_ap,
          int turn,
          bool is_reset,
          int exp,
          bool is_infinite)
        {
        }
      }
    }

    [Token(Token = "0x2002D9D")]
    [MessagePackObject(true)]
    public class UnitRevival
    {
      [Token(Token = "0x400E490")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x400E491")]
      [FieldOffset(Offset = "0xC")]
      public int cnt;
      [Token(Token = "0x400E492")]
      [FieldOffset(Offset = "0x10")]
      public bool isadd;

      [Token(Token = "0x600D6F4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public UnitRevival()
      {
      }
    }

    [Token(Token = "0x2002D9E")]
    [MessagePackObject(true)]
    public class UnitAutoHpJudge
    {
      [Token(Token = "0x400E493")]
      [FieldOffset(Offset = "0x8")]
      public string skillId;
      [Token(Token = "0x400E494")]
      [FieldOffset(Offset = "0xC")]
      public List<string> usedSkills;

      [Token(Token = "0x600D6F5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public UnitAutoHpJudge()
      {
      }
    }

    [Token(Token = "0x2002D9F")]
    [MessagePackObject(true)]
    public class UnitManipulate
    {
      [Token(Token = "0x400E495")]
      [FieldOffset(Offset = "0x8")]
      public int value;
      [Token(Token = "0x400E496")]
      [FieldOffset(Offset = "0xC")]
      public ManipulateTypes manipulate;
      [Token(Token = "0x400E497")]
      [FieldOffset(Offset = "0xD")]
      public DamageTypes damageType;
      [Token(Token = "0x400E498")]
      [FieldOffset(Offset = "0xE")]
      public ProtectTypes type;
      [Token(Token = "0x400E499")]
      [FieldOffset(Offset = "0x10")]
      public int ratio;
      [Token(Token = "0x400E49A")]
      [FieldOffset(Offset = "0x14")]
      public bool eternal;
      [Token(Token = "0x400E49B")]
      [FieldOffset(Offset = "0x18")]
      public string skillIname;
      [Token(Token = "0x400E49C")]
      [FieldOffset(Offset = "0x1C")]
      public string effect;
      [Token(Token = "0x400E49D")]
      [FieldOffset(Offset = "0x20")]
      public int element;
      [Token(Token = "0x400E49E")]
      [FieldOffset(Offset = "0x24")]
      public bool passive;

      [Token(Token = "0x600D6F6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public UnitManipulate()
      {
      }
    }

    [Token(Token = "0x2002DA0")]
    [MessagePackObject(true)]
    public class UnitSkillDistance
    {
      [Token(Token = "0x400E49F")]
      [FieldOffset(Offset = "0x8")]
      public SkillDistanceParam param;
      [Token(Token = "0x400E4A0")]
      [FieldOffset(Offset = "0xC")]
      public int turn;
      [Token(Token = "0x400E4A1")]
      [FieldOffset(Offset = "0x10")]
      public bool is_passive;
      [Token(Token = "0x400E4A2")]
      [FieldOffset(Offset = "0x14")]
      public SkillParam skill;
      [Token(Token = "0x400E4A3")]
      [FieldOffset(Offset = "0x18")]
      public bool is_buff;

      [Token(Token = "0x600D6F7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public UnitSkillDistance()
      {
      }
    }

    [Token(Token = "0x2002DA1")]
    private enum eAcType
    {
      [Token(Token = "0x400E4A5")] UNKNOWN,
      [Token(Token = "0x400E4A6")] NEW,
      [Token(Token = "0x400E4A7")] CANCEL,
      [Token(Token = "0x400E4A8")] BACK,
      [Token(Token = "0x400E4A9")] ADD,
    }
  }
}
