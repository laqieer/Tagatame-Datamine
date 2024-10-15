// Decompiled with JetBrains decompiler
// Type: SRPG.UnitData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002DCF")]
  [MessagePackObject(true)]
  public class UnitData
  {
    [Token(Token = "0x400E4F6")]
    private const int SEARCH_FROM_ABILITY_MAX = 5;
    [Token(Token = "0x400E4F7")]
    public const int MAX_JOB = 4;
    [Token(Token = "0x400E4F8")]
    public const int MAX_MASTER_ABILITY = 1;
    [Token(Token = "0x400E4F9")]
    public const int MAX_JOB_ABILITY = 5;
    [Token(Token = "0x400E4FA")]
    public const int MAX_EQUIP_ABILITY = 5;
    [Token(Token = "0x400E4FB")]
    public const int MAX_USED_ABILITY = 11;
    [Token(Token = "0x400E4FC")]
    public const int COMBAT_POWER_SPD_MUL_VALUE = 5;
    [Token(Token = "0x400E4FD")]
    public const int COMBAT_POWER_HP_DIV_VALUE = 10;
    [Token(Token = "0x400E4FE")]
    public const int ABILITY_DEFAULT_RANK = 1;
    [Token(Token = "0x400E4FF")]
    [FieldOffset(Offset = "0x8")]
    private long mUniqueID;
    [Token(Token = "0x400E500")]
    [FieldOffset(Offset = "0x10")]
    private long mDtuFromUniqueID;
    [Token(Token = "0x400E501")]
    [FieldOffset(Offset = "0x18")]
    private UnitParam mUnitParam;
    [Token(Token = "0x400E502")]
    [FieldOffset(Offset = "0x1C")]
    private string mDtuFromOriginalUnitID;
    [Token(Token = "0x400E503")]
    [FieldOffset(Offset = "0x20")]
    private BaseStatus mStatus;
    [Token(Token = "0x400E504")]
    [FieldOffset(Offset = "0x24")]
    public float LastSyncTime;
    [Token(Token = "0x400E505")]
    [FieldOffset(Offset = "0x28")]
    private OInt mLv;
    [Token(Token = "0x400E506")]
    [FieldOffset(Offset = "0x3C")]
    private OInt mExp;
    [Token(Token = "0x400E507")]
    [FieldOffset(Offset = "0x50")]
    private OInt mRarity;
    [Token(Token = "0x400E508")]
    [FieldOffset(Offset = "0x64")]
    private OInt mAwakeLv;
    [Token(Token = "0x400E509")]
    [FieldOffset(Offset = "0x78")]
    private OInt mElement;
    [Token(Token = "0x400E50A")]
    [FieldOffset(Offset = "0x8C")]
    private int mElementPlus;
    [Token(Token = "0x400E50B")]
    [FieldOffset(Offset = "0x90")]
    private bool mFavorite;
    [Token(Token = "0x400E50C")]
    [FieldOffset(Offset = "0x91")]
    private EElement mSupportElement;
    [Token(Token = "0x400E50D")]
    [FieldOffset(Offset = "0x94")]
    private OBool mIsRental;
    [Token(Token = "0x400E50E")]
    [FieldOffset(Offset = "0xA0")]
    private OInt mRentalFavoritePoint;
    [Token(Token = "0x400E50F")]
    [FieldOffset(Offset = "0xB4")]
    private string mRentalIname;
    [Token(Token = "0x400E510")]
    [FieldOffset(Offset = "0xB8")]
    private UnitRentalParam mUnitRentalParam;
    [Token(Token = "0x400E511")]
    [FieldOffset(Offset = "0xBC")]
    private bool mIsNotFindUniqueID;
    [Token(Token = "0x400E512")]
    [FieldOffset(Offset = "0xC0")]
    private List<AdventureDataBase> mAdvDataBaseList;
    [Token(Token = "0x400E513")]
    [FieldOffset(Offset = "0xC4")]
    private string mBondFromUnitIname;
    [Token(Token = "0x400E514")]
    [FieldOffset(Offset = "0xC8")]
    private List<BondData> mBondDataList;
    [Token(Token = "0x400E515")]
    [FieldOffset(Offset = "0xCC")]
    private JobData[] mJobs;
    [Token(Token = "0x400E516")]
    [FieldOffset(Offset = "0xD0")]
    private OInt mJobIndex;
    [Token(Token = "0x400E517")]
    [FieldOffset(Offset = "0xE4")]
    private long[] mPartyJobs;
    [Token(Token = "0x400E518")]
    [FieldOffset(Offset = "0xE8")]
    private bool mIsAllJobMaster;
    [Token(Token = "0x400E519")]
    [FieldOffset(Offset = "0xEC")]
    public UnitData.TemporaryFlags TempFlags;
    [Token(Token = "0x400E51A")]
    [FieldOffset(Offset = "0xF0")]
    private List<ArtifactParam> mUnlockedSkins;
    [Token(Token = "0x400E51B")]
    [FieldOffset(Offset = "0xF4")]
    private SkillData mLeaderSkill;
    [Token(Token = "0x400E51C")]
    [FieldOffset(Offset = "0xF8")]
    private AbilityData mMasterAbility;
    [Token(Token = "0x400E51D")]
    [FieldOffset(Offset = "0xFC")]
    private AbilityData mCollaboAbility;
    [Token(Token = "0x400E51E")]
    [FieldOffset(Offset = "0x100")]
    private AbilityData mMapEffectAbility;
    [Token(Token = "0x400E51F")]
    [FieldOffset(Offset = "0x104")]
    private List<AbilityData> mLearnAbilitys;
    [Token(Token = "0x400E520")]
    [FieldOffset(Offset = "0x108")]
    private List<AbilityData> mBattleAbilitys;
    [Token(Token = "0x400E521")]
    [FieldOffset(Offset = "0x10C")]
    private List<SkillData> mBattleSkills;
    [Token(Token = "0x400E522")]
    [FieldOffset(Offset = "0x110")]
    private List<AbilityData> mTobiraMasterAbilitys;
    [Token(Token = "0x400E523")]
    [FieldOffset(Offset = "0x114")]
    private SkillData mNormalAttackSkill;
    [Token(Token = "0x400E524")]
    [FieldOffset(Offset = "0x118")]
    private QuestClearUnlockUnitDataParam mUnlockedLeaderSkill;
    [Token(Token = "0x400E525")]
    [FieldOffset(Offset = "0x11C")]
    private List<QuestClearUnlockUnitDataParam> mUnlockedAbilitys;
    [Token(Token = "0x400E526")]
    [FieldOffset(Offset = "0x120")]
    private List<QuestClearUnlockUnitDataParam> mUnlockedSkills;
    [Token(Token = "0x400E527")]
    [FieldOffset(Offset = "0x124")]
    private List<QuestClearUnlockUnitDataParam> mSkillUnlocks;
    [Token(Token = "0x400E528")]
    [FieldOffset(Offset = "0x128")]
    private Dictionary<string, UnitJobOverwriteParam> mUnitJobOverwriteParams;
    [Token(Token = "0x400E529")]
    [FieldOffset(Offset = "0x12C")]
    private ConceptCardData[] mConceptCards;
    [Token(Token = "0x400E52A")]
    [FieldOffset(Offset = "0x130")]
    private List<SRPG.TobiraData> mTobiraData;
    [Token(Token = "0x400E52B")]
    [FieldOffset(Offset = "0x134")]
    private TobiraParam[] mTobiraParam;
    [Token(Token = "0x400E52C")]
    [FieldOffset(Offset = "0x138")]
    private OInt mUnlockTobiraNum;
    [Token(Token = "0x400E52D")]
    [FieldOffset(Offset = "0x14C")]
    private int mMasterTobiraNum;
    [Token(Token = "0x400E52E")]
    [FieldOffset(Offset = "0x150")]
    private RuneData[] mEquipRunes;
    [Token(Token = "0x400E52F")]
    [FieldOffset(Offset = "0x154")]
    private Dictionary<string, SkillAbilityDeriveData> mJobSkillAbilityDeriveData;
    [Token(Token = "0x400E530")]
    [FieldOffset(Offset = "0x158")]
    private InvalidSkillData mInvalidSkill;
    [Token(Token = "0x400E531")]
    [FieldOffset(Offset = "0x15C")]
    private TruthEquipmentData mTruthEquipmentData;
    [Token(Token = "0x400E532")]
    [FieldOffset(Offset = "0x160")]
    private bool mIsResonanceParent;
    [Token(Token = "0x400E533")]
    [FieldOffset(Offset = "0x168")]
    private long mResonanceUnitID;
    [Token(Token = "0x400E534")]
    [FieldOffset(Offset = "0x170")]
    private bool mIsResonanceInvisible;
    [Token(Token = "0x400E535")]
    [FieldOffset(Offset = "0x174")]
    private int mResonanceBeforePlus;
    [Token(Token = "0x400E536")]
    [FieldOffset(Offset = "0x178")]
    private List<CrystalData> mCrystals;
    [Token(Token = "0x400E537")]
    [FieldOffset(Offset = "0x17C")]
    private bool mLeaderSkillIsConceptCard;
    [Token(Token = "0x400E538")]
    [FieldOffset(Offset = "0x180")]
    private int mNumJobsAvailable;
    [Token(Token = "0x400E539")]
    [FieldOffset(Offset = "0x184")]
    public UnitBadgeTypes BadgeState;
    [Token(Token = "0x400E53A")]
    [FieldOffset(Offset = "0x0")]
    private static BaseStatus UnitScaleStatus;
    [Token(Token = "0x400E53B")]
    [FieldOffset(Offset = "0x4")]
    private static BaseStatus WorkScaleStatus;
    [Token(Token = "0x400E53C")]
    [FieldOffset(Offset = "0x8")]
    private static readonly Dictionary<string, string[]> CONDITIONS_TARGET_NAMES;
    [Token(Token = "0x400E53D")]
    [FieldOffset(Offset = "0x188")]
    private List<QuestParam> mCharacterQuests;
    [Token(Token = "0x400E53E")]
    [FieldOffset(Offset = "0x18C")]
    private bool mIsOpen;
    [Token(Token = "0x400E53F")]
    [FieldOffset(Offset = "0x190")]
    private RunePrideData mRunePride;
    [Token(Token = "0x400E540")]
    [FieldOffset(Offset = "0x194")]
    private int mStatusAwakeHP;
    [Token(Token = "0x400E541")]
    [FieldOffset(Offset = "0x198")]
    private List<StatusAwakeData> mStatusAwakeDatas;

    [Token(Token = "0x17001C7C")]
    public QuestClearUnlockUnitDataParam QuestUnlockedLeaderSkill
    {
      [Token(Token = "0x600D762"), Address(RVA = "0x3495C0", Offset = "0x3483C0", VA = "0x103495C0")] get
      {
        return (QuestClearUnlockUnitDataParam) null;
      }
    }

    [Token(Token = "0x17001C7D")]
    public List<QuestClearUnlockUnitDataParam> QuestUnlockedAbilitys
    {
      [Token(Token = "0x600D763"), Address(RVA = "0x685580", Offset = "0x684380", VA = "0x10685580")] get
      {
        return (List<QuestClearUnlockUnitDataParam>) null;
      }
    }

    [Token(Token = "0x17001C7E")]
    public List<QuestClearUnlockUnitDataParam> QuestUnlockedSkills
    {
      [Token(Token = "0x600D764"), Address(RVA = "0xA45FE0", Offset = "0xA44DE0", VA = "0x10A45FE0")] get
      {
        return (List<QuestClearUnlockUnitDataParam>) null;
      }
    }

    [Token(Token = "0x17001C7F")]
    public List<QuestClearUnlockUnitDataParam> SkillUnlocks
    {
      [Token(Token = "0x600D765"), Address(RVA = "0x3490E0", Offset = "0x347EE0", VA = "0x103490E0")] get
      {
        return (List<QuestClearUnlockUnitDataParam>) null;
      }
    }

    [Token(Token = "0x17001C80")]
    public bool IsMyUnit
    {
      [Token(Token = "0x600D766"), Address(RVA = "0xA45B60", Offset = "0xA44960", VA = "0x10A45B60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001C81")]
    public long UniqueID
    {
      [Token(Token = "0x600D767"), Address(RVA = "0x305C20", Offset = "0x304A20", VA = "0x10305C20")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17001C82")]
    public long DtuFromUniqueID
    {
      [Token(Token = "0x600D768"), Address(RVA = "0x361230", Offset = "0x360030", VA = "0x10361230")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17001C83")]
    public UnitParam UnitParam
    {
      [Token(Token = "0x600D769"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (UnitParam) null;
      }
    }

    [Token(Token = "0x17001C84")]
    public string UnitID
    {
      [Token(Token = "0x600D76A"), Address(RVA = "0x3C1AD0", Offset = "0x3C08D0", VA = "0x103C1AD0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001C85")]
    public BaseStatus Status
    {
      [Token(Token = "0x600D76B"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (BaseStatus) null;
      }
    }

    [Token(Token = "0x17001C86")]
    public int Lv
    {
      [Token(Token = "0x600D76C"), Address(RVA = "0xA45F50", Offset = "0xA44D50", VA = "0x10A45F50")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001C87")]
    public int Exp
    {
      [Token(Token = "0x600D76D"), Address(RVA = "0xA457E0", Offset = "0xA445E0", VA = "0x10A457E0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001C88")]
    public int Rarity
    {
      [Token(Token = "0x600D76E"), Address(RVA = "0xA45FF0", Offset = "0xA44DF0", VA = "0x10A45FF0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001C89")]
    public int AwakeLv
    {
      [Token(Token = "0x600D76F"), Address(RVA = "0xA45500", Offset = "0xA44300", VA = "0x10A45500")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001C8A")]
    public EquipData[] CurrentEquips
    {
      [Token(Token = "0x600D770"), Address(RVA = "0xA455C0", Offset = "0xA443C0", VA = "0x10A455C0")] get
      {
        return (EquipData[]) null;
      }
    }

    [Token(Token = "0x17001C8B")]
    public SkillData LeaderSkill
    {
      [Token(Token = "0x600D771"), Address(RVA = "0x6085E0", Offset = "0x6073E0", VA = "0x106085E0")] get
      {
        return (SkillData) null;
      }
    }

    [Token(Token = "0x17001C8C")]
    public AbilityData MasterAbility
    {
      [Token(Token = "0x600D772"), Address(RVA = "0x38D8F0", Offset = "0x38C6F0", VA = "0x1038D8F0")] get
      {
        return (AbilityData) null;
      }
    }

    [Token(Token = "0x17001C8D")]
    public AbilityData CollaboAbility
    {
      [Token(Token = "0x600D773"), Address(RVA = "0x685590", Offset = "0x684390", VA = "0x10685590")] get
      {
        return (AbilityData) null;
      }
    }

    [Token(Token = "0x17001C8E")]
    public AbilityData MapEffectAbility
    {
      [Token(Token = "0x600D774"), Address(RVA = "0xA45FB0", Offset = "0xA44DB0", VA = "0x10A45FB0")] get
      {
        return (AbilityData) null;
      }
    }

    [Token(Token = "0x17001C8F")]
    public List<AbilityData> TobiraMasterAbilitys
    {
      [Token(Token = "0x600D775"), Address(RVA = "0x349390", Offset = "0x348190", VA = "0x10349390")] get
      {
        return (List<AbilityData>) null;
      }
    }

    [Token(Token = "0x17001C90")]
    public long[] CurrentAbilitySlots
    {
      [Token(Token = "0x600D776"), Address(RVA = "0xA45580", Offset = "0xA44380", VA = "0x10A45580")] get
      {
        return (long[]) null;
      }
    }

    [Token(Token = "0x17001C91")]
    public List<AbilityData> LearnAbilitys
    {
      [Token(Token = "0x600D777"), Address(RVA = "0x33B040", Offset = "0x339E40", VA = "0x1033B040")] get
      {
        return (List<AbilityData>) null;
      }
    }

    [Token(Token = "0x17001C92")]
    public List<AbilityData> BattleAbilitys
    {
      [Token(Token = "0x600D778"), Address(RVA = "0x6718E0", Offset = "0x6706E0", VA = "0x106718E0")] get
      {
        return (List<AbilityData>) null;
      }
    }

    [Token(Token = "0x17001C93")]
    public List<SkillData> BattleSkills
    {
      [Token(Token = "0x600D779"), Address(RVA = "0x628750", Offset = "0x627550", VA = "0x10628750")] get
      {
        return (List<SkillData>) null;
      }
    }

    [Token(Token = "0x17001C94")]
    public InvalidSkillData InvalidSkill
    {
      [Token(Token = "0x600D77A"), Address(RVA = "0x3405B0", Offset = "0x33F3B0", VA = "0x103405B0")] get
      {
        return (InvalidSkillData) null;
      }
    }

    [Token(Token = "0x17001C95")]
    public int MasterTobiraNum
    {
      [Token(Token = "0x600D77B"), Address(RVA = "0xA45FC0", Offset = "0xA44DC0", VA = "0x10A45FC0")] get
      {
        return new int();
      }
      [Token(Token = "0x600D77C"), Address(RVA = "0xA46510", Offset = "0xA45310", VA = "0x10A46510")] set
      {
      }
    }

    [Token(Token = "0x17001C96")]
    public SkillData CurrentLeaderSkill
    {
      [Token(Token = "0x600D77D"), Address(RVA = "0xA45730", Offset = "0xA44530", VA = "0x10A45730")] get
      {
        return (SkillData) null;
      }
    }

    [Token(Token = "0x17001C97")]
    public EElement Element
    {
      [Token(Token = "0x600D77E"), Address(RVA = "0xA457B0", Offset = "0xA445B0", VA = "0x10A457B0")] get
      {
        return new EElement();
      }
    }

    [Token(Token = "0x17001C98")]
    public int ElementPlus
    {
      [Token(Token = "0x600D77F"), Address(RVA = "0x2B5F90", Offset = "0x2B4D90", VA = "0x102B5F90")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001C99")]
    public JobTypes JobType
    {
      [Token(Token = "0x600D780"), Address(RVA = "0xA45EF0", Offset = "0xA44CF0", VA = "0x10A45EF0")] get
      {
        return new JobTypes();
      }
    }

    [Token(Token = "0x17001C9A")]
    public RoleTypes RoleType
    {
      [Token(Token = "0x600D781"), Address(RVA = "0xA462D0", Offset = "0xA450D0", VA = "0x10A462D0")] get
      {
        return new RoleTypes();
      }
    }

    [Token(Token = "0x17001C9B")]
    public ConceptCardData[] ConceptCards
    {
      [Token(Token = "0x600D782"), Address(RVA = "0x349280", Offset = "0x348080", VA = "0x10349280")] get
      {
        return (ConceptCardData[]) null;
      }
      [Token(Token = "0x600D783"), Address(RVA = "0xA46470", Offset = "0xA45270", VA = "0x10A46470")] set
      {
      }
    }

    [Token(Token = "0x17001C9C")]
    public ConceptCardData MainConceptCard
    {
      [Token(Token = "0x600D784"), Address(RVA = "0xA45F80", Offset = "0xA44D80", VA = "0x10A45F80")] get
      {
        return (ConceptCardData) null;
      }
    }

    [Token(Token = "0x17001C9D")]
    public ConceptCardData SubConceptCard
    {
      [Token(Token = "0x600D785"), Address(RVA = "0xA46370", Offset = "0xA45170", VA = "0x10A46370")] get
      {
        return (ConceptCardData) null;
      }
    }

    [Token(Token = "0x17001C9E")]
    public RuneData[] EquipRunes
    {
      [Token(Token = "0x600D786"), Address(RVA = "0xA23400", Offset = "0xA22200", VA = "0x10A23400")] get
      {
        return (RuneData[]) null;
      }
      [Token(Token = "0x600D787"), Address(RVA = "0xA464B0", Offset = "0xA452B0", VA = "0x10A464B0")] set
      {
      }
    }

    [Token(Token = "0x600D788")]
    [Address(RVA = "0xA2FA30", Offset = "0xA2E830", VA = "0x10A2FA30")]
    public RuneData EquipRune(int index) => (RuneData) null;

    [Token(Token = "0x600D789")]
    [Address(RVA = "0xA2D530", Offset = "0xA2C330", VA = "0x10A2D530")]
    public long[] CreateRuneIds() => (long[]) null;

    [Token(Token = "0x600D78A")]
    [Address(RVA = "0xA38990", Offset = "0xA37790", VA = "0x10A38990")]
    public bool IsEquipRune(OLong iid) => new bool();

    [Token(Token = "0x17001C9F")]
    public bool IsRiding
    {
      [Token(Token = "0x600D78B"), Address(RVA = "0xA45CB0", Offset = "0xA44AB0", VA = "0x10A45CB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001CA0")]
    public int NumJobsAvailable
    {
      [Token(Token = "0x600D78C"), Address(RVA = "0xA45FD0", Offset = "0xA44DD0", VA = "0x10A45FD0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600D78D")]
    [Address(RVA = "0xA38BD0", Offset = "0xA379D0", VA = "0x10A38BD0")]
    public bool IsJobAvailable(int jobNo) => new bool();

    [Token(Token = "0x600D78E")]
    [Address(RVA = "0xA385C0", Offset = "0xA373C0", VA = "0x10A385C0")]
    public bool IsEquipConceptLeaderSkill() => new bool();

    [Token(Token = "0x17001CA1")]
    public JobData CurrentJob
    {
      [Token(Token = "0x600D78F"), Address(RVA = "0xA45670", Offset = "0xA44470", VA = "0x10A45670")] get
      {
        return (JobData) null;
      }
    }

    [Token(Token = "0x17001CA2")]
    public string CurrentJobId
    {
      [Token(Token = "0x600D790"), Address(RVA = "0xA45600", Offset = "0xA44400", VA = "0x10A45600")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001CA3")]
    public bool IsUnlockTobira
    {
      [Token(Token = "0x600D791"), Address(RVA = "0xA45D40", Offset = "0xA44B40", VA = "0x10A45D40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001CA4")]
    public bool IsAllJobMaster
    {
      [Token(Token = "0x600D792"), Address(RVA = "0xA459C0", Offset = "0xA447C0", VA = "0x10A459C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001CA5")]
    public List<SRPG.TobiraData> TobiraData
    {
      [Token(Token = "0x600D793"), Address(RVA = "0x349290", Offset = "0x348090", VA = "0x10349290")] get
      {
        return (List<SRPG.TobiraData>) null;
      }
    }

    [Token(Token = "0x17001CA6")]
    public int UnlockTobiraNum
    {
      [Token(Token = "0x600D794"), Address(RVA = "0xA463F0", Offset = "0xA451F0", VA = "0x10A463F0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001CA7")]
    public int GetTobiraMasterCount
    {
      [Token(Token = "0x600D795"), Address(RVA = "0xA45810", Offset = "0xA44610", VA = "0x10A45810")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600D796")]
    [Address(RVA = "0xA31BB0", Offset = "0xA309B0", VA = "0x10A31BB0")]
    public JobData GetBaseJob(string jobID) => (JobData) null;

    [Token(Token = "0x600D797")]
    [Address(RVA = "0xA31CF0", Offset = "0xA30AF0", VA = "0x10A31CF0")]
    public List<JobData> GetBaseJobs(bool onlyActivated) => (List<JobData>) null;

    [Token(Token = "0x600D798")]
    [Address(RVA = "0xA301E0", Offset = "0xA2EFE0", VA = "0x10A301E0")]
    public JobData FindJobDataBySkillData(SkillParam param) => (JobData) null;

    [Token(Token = "0x600D799")]
    [Address(RVA = "0xA2FAB0", Offset = "0xA2E8B0", VA = "0x10A2FAB0")]
    public ArtifactData FindArtifactDataBySkillParam(SkillParam param) => (ArtifactData) null;

    [Token(Token = "0x17001CA8")]
    public JobData[] Jobs
    {
      [Token(Token = "0x600D79A"), Address(RVA = "0x319830", Offset = "0x318630", VA = "0x10319830")] get
      {
        return (JobData[]) null;
      }
    }

    [Token(Token = "0x17001CA9")]
    public int JobCount
    {
      [Token(Token = "0x600D79B"), Address(RVA = "0xA45EA0", Offset = "0xA44CA0", VA = "0x10A45EA0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001CAA")]
    public int JobIndex
    {
      [Token(Token = "0x600D79C"), Address(RVA = "0xA45EC0", Offset = "0xA44CC0", VA = "0x10A45EC0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001CAB")]
    public string SexPrefix
    {
      [Token(Token = "0x600D79D"), Address(RVA = "0xA46330", Offset = "0xA45130", VA = "0x10A46330")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001CAC")]
    public bool IsFavorite
    {
      [Token(Token = "0x600D79E"), Address(RVA = "0xA464D0", Offset = "0xA452D0", VA = "0x10A464D0")] set
      {
      }
      [Token(Token = "0x600D79F"), Address(RVA = "0x5622B0", Offset = "0x5610B0", VA = "0x105622B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001CAD")]
    public EElement SupportElement
    {
      [Token(Token = "0x600D7A0"), Address(RVA = "0xA463A0", Offset = "0xA451A0", VA = "0x10A463A0")] get
      {
        return new EElement();
      }
    }

    [Token(Token = "0x17001CAE")]
    public bool IsRental
    {
      [Token(Token = "0x600D7A1"), Address(RVA = "0xA45C10", Offset = "0xA44A10", VA = "0x10A45C10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001CAF")]
    public int RentalFavoritePoint
    {
      [Token(Token = "0x600D7A2"), Address(RVA = "0xA46020", Offset = "0xA44E20", VA = "0x10A46020")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001CB0")]
    public string RentalIname
    {
      [Token(Token = "0x600D7A3"), Address(RVA = "0x305C10", Offset = "0x304A10", VA = "0x10305C10")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001CB1")]
    private UnitRentalParam UnitRentalParam
    {
      [Token(Token = "0x600D7A4"), Address(RVA = "0xA463B0", Offset = "0xA451B0", VA = "0x10A463B0")] get
      {
        return (UnitRentalParam) null;
      }
    }

    [Token(Token = "0x17001CB2")]
    public string BondFromUnitIname
    {
      [Token(Token = "0x600D7A5"), Address(RVA = "0x5FBFF0", Offset = "0x5FADF0", VA = "0x105FBFF0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600D7A6"), Address(RVA = "0x5FC070", Offset = "0x5FAE70", VA = "0x105FC070")] set
      {
      }
    }

    [Token(Token = "0x17001CB3")]
    public List<BondData> BondDataList
    {
      [Token(Token = "0x600D7A7"), Address(RVA = "0x36A9E0", Offset = "0x3697E0", VA = "0x1036A9E0")] get
      {
        return (List<BondData>) null;
      }
      [Token(Token = "0x600D7A8"), Address(RVA = "0x45A300", Offset = "0x459100", VA = "0x1045A300")] set
      {
      }
    }

    [Token(Token = "0x17001CB4")]
    public bool IsNotFindUniqueID
    {
      [Token(Token = "0x600D7A9"), Address(RVA = "0x690E70", Offset = "0x68FC70", VA = "0x10690E70")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D7AA"), Address(RVA = "0x690EE0", Offset = "0x68FCE0", VA = "0x10690EE0")] set
      {
      }
    }

    [Token(Token = "0x17001CB5")]
    public List<AdventureDataBase> AdvDataBaseList
    {
      [Token(Token = "0x600D7AB"), Address(RVA = "0x5FC060", Offset = "0x5FAE60", VA = "0x105FC060")] get
      {
        return (List<AdventureDataBase>) null;
      }
      [Token(Token = "0x600D7AC"), Address(RVA = "0x7D9580", Offset = "0x7D8380", VA = "0x107D9580")] set
      {
      }
    }

    [Token(Token = "0x17001CB6")]
    public bool IsIntoUnit
    {
      [Token(Token = "0x600D7AD"), Address(RVA = "0xA45B00", Offset = "0xA44900", VA = "0x10A45B00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D7AE")]
    [Address(RVA = "0xA39320", Offset = "0xA38120", VA = "0x10A39320")]
    public bool IsSkinUnlocked() => new bool();

    [Token(Token = "0x600D7AF")]
    [Address(RVA = "0xA39250", Offset = "0xA38050", VA = "0x10A39250")]
    public bool IsSetSkin(int jobIndex = -1) => new bool();

    [Token(Token = "0x600D7B0")]
    [Address(RVA = "0xA35C50", Offset = "0xA34A50", VA = "0x10A35C50")]
    public ArtifactParam GetSelectedSkinData(int jobIndex = -1) => (ArtifactParam) null;

    [Token(Token = "0x600D7B1")]
    [Address(RVA = "0xA35DD0", Offset = "0xA34BD0", VA = "0x10A35DD0")]
    public ArtifactParam GetSelectedSkin(int jobIndex = -1) => (ArtifactParam) null;

    [Token(Token = "0x600D7B2")]
    [Address(RVA = "0xA35E10", Offset = "0xA34C10", VA = "0x10A35E10")]
    public ArtifactParam[] GetSelectedSkins() => (ArtifactParam[]) null;

    [Token(Token = "0x600D7B3")]
    [Address(RVA = "0xA41930", Offset = "0xA40730", VA = "0x10A41930")]
    public void SetJobSkin(string afName, int jobIndex = -1, bool is_need_check = true)
    {
    }

    [Token(Token = "0x600D7B4")]
    [Address(RVA = "0xA41740", Offset = "0xA40540", VA = "0x10A41740")]
    public void SetJobSkinAll(string afName, bool isSelf = true)
    {
    }

    [Token(Token = "0x600D7B5")]
    [Address(RVA = "0xA3CCB0", Offset = "0xA3BAB0", VA = "0x10A3CCB0")]
    public void ResetJobSkin(int jobIndex = -1)
    {
    }

    [Token(Token = "0x600D7B6")]
    [Address(RVA = "0xA3CC40", Offset = "0xA3BA40", VA = "0x10A3CC40")]
    public void ResetJobSkinAll()
    {
    }

    [Token(Token = "0x600D7B7")]
    [Address(RVA = "0xA35A30", Offset = "0xA34830", VA = "0x10A35A30")]
    public ArtifactParam[] GetSelectableSkins(JobParam jobParam) => (ArtifactParam[]) null;

    [Token(Token = "0x600D7B8")]
    [Address(RVA = "0xA358B0", Offset = "0xA346B0", VA = "0x10A358B0")]
    public ArtifactParam[] GetSelectableSkins(int jobIndex = -1) => (ArtifactParam[]) null;

    [Token(Token = "0x600D7B9")]
    [Address(RVA = "0xA31250", Offset = "0xA30050", VA = "0x10A31250")]
    public ArtifactParam[] GetAllSkins(int jobIndex = -1) => (ArtifactParam[]) null;

    [Token(Token = "0x600D7BA")]
    [Address(RVA = "0xA332F0", Offset = "0xA320F0", VA = "0x10A332F0")]
    public ArtifactParam[] GetEnableConceptCardSkins(int jobIndex = -1) => (ArtifactParam[]) null;

    [Token(Token = "0x17001CB7")]
    public QuestClearUnlockUnitDataParam[] UnlockedSkills
    {
      [Token(Token = "0x600D7BB"), Address(RVA = "0xA46420", Offset = "0xA45220", VA = "0x10A46420")] get
      {
        return (QuestClearUnlockUnitDataParam[]) null;
      }
    }

    [Token(Token = "0x600D7BC")]
    [Address(RVA = "0xA43700", Offset = "0xA42500", VA = "0x10A43700")]
    public string UnlockedSkillIds() => (string) null;

    [Token(Token = "0x600D7BD")]
    [Address(RVA = "0xA43490", Offset = "0xA42290", VA = "0x10A43490")]
    public QuestClearUnlockUnitDataParam[] UnlockedSkillDiff(string oldIds)
    {
      return (QuestClearUnlockUnitDataParam[]) null;
    }

    [Token(Token = "0x600D7BE")]
    [Address(RVA = "0xA38D90", Offset = "0xA37B90", VA = "0x10A38D90")]
    public bool IsQuestClearUnlocked(string id, QuestClearUnlockUnitDataParam.EUnlockTypes type)
    {
      return new bool();
    }

    [Token(Token = "0x600D7BF")]
    [Address(RVA = "0xA34DA0", Offset = "0xA33BA0", VA = "0x10A34DA0")]
    public List<string> GetQuestUnlockConditions(QuestParam quest) => (List<string>) null;

    [Token(Token = "0x17001CB8")]
    public TruthEquipmentData TruthEquipmentData
    {
      [Token(Token = "0x600D7C0"), Address(RVA = "0x3B12F0", Offset = "0x3B00F0", VA = "0x103B12F0")] get
      {
        return (TruthEquipmentData) null;
      }
    }

    [Token(Token = "0x600D7C1")]
    [Address(RVA = "0xA2A330", Offset = "0xA29130", VA = "0x10A2A330")]
    public void CopyToTruthEquipmentData(TruthEquipmentData _data)
    {
    }

    [Token(Token = "0x17001CB9")]
    public bool IsResonance
    {
      [Token(Token = "0x600D7C2"), Address(RVA = "0xA45C90", Offset = "0xA44A90", VA = "0x10A45C90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001CBA")]
    public long ResonanceUnitID
    {
      [Token(Token = "0x600D7C3"), Address(RVA = "0xA462B0", Offset = "0xA450B0", VA = "0x10A462B0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17001CBB")]
    public bool IsResonanceParent
    {
      [Token(Token = "0x600D7C4"), Address(RVA = "0xA45C80", Offset = "0xA44A80", VA = "0x10A45C80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001CBC")]
    public bool IsResonanceChild
    {
      [Token(Token = "0x600D7C5"), Address(RVA = "0xA45C40", Offset = "0xA44A40", VA = "0x10A45C40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001CBD")]
    public int ResonanceBeforePlus
    {
      [Token(Token = "0x600D7C6"), Address(RVA = "0xA462A0", Offset = "0xA450A0", VA = "0x10A462A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001CBE")]
    public bool IsUpdateTrophy
    {
      [Token(Token = "0x600D7C7"), Address(RVA = "0xA45E40", Offset = "0xA44C40", VA = "0x10A45E40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001CBF")]
    public bool IsResonanceInvisible
    {
      [Token(Token = "0x600D7C8"), Address(RVA = "0xA45C70", Offset = "0xA44A70", VA = "0x10A45C70")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D7C9"), Address(RVA = "0xA464F0", Offset = "0xA452F0", VA = "0x10A464F0")] set
      {
      }
    }

    [Token(Token = "0x17001CC0")]
    public List<CrystalData> Crystals
    {
      [Token(Token = "0x600D7CA"), Address(RVA = "0xA45570", Offset = "0xA44370", VA = "0x10A45570")] get
      {
        return (List<CrystalData>) null;
      }
      [Token(Token = "0x600D7CB"), Address(RVA = "0xA46490", Offset = "0xA45290", VA = "0x10A46490")] set
      {
      }
    }

    [Token(Token = "0x600D7CC")]
    [Address(RVA = "0xA26180", Offset = "0xA24F80", VA = "0x10A26180")]
    private Json_Job[] AppendUnlockedJobs(Json_Job[] jobs) => (Json_Job[]) null;

    [Token(Token = "0x600D7CD")]
    [Address(RVA = "0xA41C80", Offset = "0xA40A80", VA = "0x10A41C80")]
    private void SetSkinLockedJob(Json_Job[] jobs)
    {
    }

    [Token(Token = "0x600D7CE")]
    [Address(RVA = "0xA29BE0", Offset = "0xA289E0", VA = "0x10A29BE0")]
    public bool CheckUsedSkin(string afName) => new bool();

    [Token(Token = "0x600D7CF")]
    [Address(RVA = "0xA2DD60", Offset = "0xA2CB60", VA = "0x10A2DD60")]
    public void Deserialize(Json_Unit _json, JSON_PlayerBuff _buff = null)
    {
    }

    [Token(Token = "0x600D7D0")]
    [Address(RVA = "0xA3E060", Offset = "0xA3CE60", VA = "0x10A3E060")]
    public string Serialize() => (string) null;

    [Token(Token = "0x600D7D1")]
    [Address(RVA = "0xA2A2B0", Offset = "0xA290B0", VA = "0x10A2A2B0")]
    public Json_Unit ConvertJsonUnitData() => (Json_Unit) null;

    [Token(Token = "0x600D7D2")]
    [Address(RVA = "0xA34320", Offset = "0xA33120", VA = "0x10A34320")]
    public Json_Equip[] GetJsonJobMaxEquip(string _jobIname) => (Json_Equip[]) null;

    [Token(Token = "0x600D7D3")]
    [Address(RVA = "0xA341E0", Offset = "0xA32FE0", VA = "0x10A341E0")]
    private string GetJobUpGradeMax(string _jobset) => (string) null;

    [Token(Token = "0x600D7D4")]
    [Address(RVA = "0xA2D100", Offset = "0xA2BF00", VA = "0x10A2D100")]
    private void CreateNPCTobira(string selectJobName)
    {
    }

    [Token(Token = "0x600D7D5")]
    [Address(RVA = "0xA3A2F0", Offset = "0xA390F0", VA = "0x10A3A2F0")]
    public bool NPCSetup(
      string unit_iname,
      int exp,
      int rare,
      int awakeLv,
      string job_iname = null,
      int jobrank = 1,
      EElement elem = EElement.None,
      int unlockTobiraNum = 0,
      long fromUniqueID = 0,
      NPCSetting _npc = null)
    {
      return new bool();
    }

    [Token(Token = "0x600D7D6")]
    [Address(RVA = "0xA42970", Offset = "0xA41770", VA = "0x10A42970")]
    public void Setup(UnitData src)
    {
    }

    [Token(Token = "0x600D7D7")]
    [Address(RVA = "0xA3CA20", Offset = "0xA3B820", VA = "0x10A3CA20")]
    public void Release()
    {
    }

    [Token(Token = "0x600D7D8")]
    [Address(RVA = "0xA42A00", Offset = "0xA41800", VA = "0x10A42A00")]
    public void ShowTooltip(
      GameObject targetGO,
      bool allowJobChange = false,
      UnitJobDropdown.ParentObjectEvent updateValue = null)
    {
    }

    [Token(Token = "0x600D7D9")]
    [Address(RVA = "0xA35060", Offset = "0xA33E60", VA = "0x10A35060")]
    public int GetRarityCap() => new int();

    [Token(Token = "0x600D7DA")]
    [Address(RVA = "0xA35080", Offset = "0xA33E80", VA = "0x10A35080")]
    public int GetRarityLevelCap(int rarity) => new int();

    [Token(Token = "0x600D7DB")]
    [Address(RVA = "0xA346D0", Offset = "0xA334D0", VA = "0x10A346D0")]
    public int GetLevelCap() => new int();

    [Token(Token = "0x600D7DC")]
    [Address(RVA = "0xA269A0", Offset = "0xA257A0", VA = "0x10A269A0")]
    public int CalcLevel() => new int();

    [Token(Token = "0x600D7DD")]
    [Address(RVA = "0xA33800", Offset = "0xA32600", VA = "0x10A33800")]
    public int GetExp() => new int();

    [Token(Token = "0x600D7DE")]
    [Address(RVA = "0xA348C0", Offset = "0xA336C0", VA = "0x10A348C0")]
    public int GetNextLevel() => new int();

    [Token(Token = "0x600D7DF")]
    [Address(RVA = "0xA347C0", Offset = "0xA335C0", VA = "0x10A347C0")]
    public int GetNextExp() => new int();

    [Token(Token = "0x600D7E0")]
    [Address(RVA = "0xA29370", Offset = "0xA28170", VA = "0x10A29370")]
    public bool CheckGainExp() => new bool();

    [Token(Token = "0x600D7E1")]
    [Address(RVA = "0xA338C0", Offset = "0xA326C0", VA = "0x10A338C0")]
    public int GetGainExpCap() => new int();

    [Token(Token = "0x600D7E2")]
    [Address(RVA = "0xA30800", Offset = "0xA2F600", VA = "0x10A30800")]
    public void GainExp(int exp)
    {
    }

    [Token(Token = "0x600D7E3")]
    [Address(RVA = "0xA28700", Offset = "0xA27500", VA = "0x10A28700")]
    public void CalcStatus()
    {
    }

    [Token(Token = "0x600D7E4")]
    [Address(RVA = "0xA26E80", Offset = "0xA25C80", VA = "0x10A26E80")]
    public void CalcStatus(int lv, int jobNo, ref BaseStatus status, int disableJobMasterJobNo = -1)
    {
    }

    [Token(Token = "0x600D7E5")]
    [Address(RVA = "0xA26AD0", Offset = "0xA258D0", VA = "0x10A26AD0")]
    public void CalcStatus_ArtifactStoneAbility(JobData _job, ref BaseStatus _status)
    {
    }

    [Token(Token = "0x600D7E6")]
    [Address(RVA = "0xA32460", Offset = "0xA31260", VA = "0x10A32460")]
    public int GetCombination() => new int();

    [Token(Token = "0x600D7E7")]
    [Address(RVA = "0xA32400", Offset = "0xA31200", VA = "0x10A32400")]
    public int GetCombinationRange() => new int();

    [Token(Token = "0x600D7E8")]
    [Address(RVA = "0xA34690", Offset = "0xA33490", VA = "0x10A34690")]
    public string GetLeaderSkillIname(int rarity) => (string) null;

    [Token(Token = "0x600D7E9")]
    [Address(RVA = "0xA319F0", Offset = "0xA307F0", VA = "0x10A319F0")]
    public SkillData GetAttackSkill() => (SkillData) null;

    [Token(Token = "0x600D7EA")]
    [Address(RVA = "0xA319B0", Offset = "0xA307B0", VA = "0x10A319B0")]
    public SkillData GetAttackSkill(int jobNo) => (SkillData) null;

    [Token(Token = "0x600D7EB")]
    [Address(RVA = "0xA317F0", Offset = "0xA305F0", VA = "0x10A317F0")]
    public int GetAttackRangeMin(SkillData skill) => new int();

    [Token(Token = "0x600D7EC")]
    [Address(RVA = "0xA31770", Offset = "0xA30570", VA = "0x10A31770")]
    public int GetAttackRangeMin(int jobNo, SkillData skill) => new int();

    [Token(Token = "0x600D7ED")]
    [Address(RVA = "0xA31650", Offset = "0xA30450", VA = "0x10A31650")]
    public int GetAttackRangeMax(SkillData skill) => new int();

    [Token(Token = "0x600D7EE")]
    [Address(RVA = "0xA316F0", Offset = "0xA304F0", VA = "0x10A316F0")]
    public int GetAttackRangeMax(int jobNo, SkillData skill) => new int();

    [Token(Token = "0x600D7EF")]
    [Address(RVA = "0xA31910", Offset = "0xA30710", VA = "0x10A31910")]
    public int GetAttackScope(SkillData skill) => new int();

    [Token(Token = "0x600D7F0")]
    [Address(RVA = "0xA31890", Offset = "0xA30690", VA = "0x10A31890")]
    public int GetAttackScope(int jobNo, SkillData skill) => new int();

    [Token(Token = "0x600D7F1")]
    [Address(RVA = "0xA31580", Offset = "0xA30380", VA = "0x10A31580")]
    public int GetAttackHeight(SkillData skill = null, bool is_range = false) => new int();

    [Token(Token = "0x600D7F2")]
    [Address(RVA = "0xA314D0", Offset = "0xA302D0", VA = "0x10A314D0")]
    public int GetAttackHeight(int jobNo, SkillData skill, bool is_range) => new int();

    [Token(Token = "0x600D7F3")]
    [Address(RVA = "0xA34760", Offset = "0xA33560", VA = "0x10A34760")]
    public int GetMoveCount() => new int();

    [Token(Token = "0x600D7F4")]
    [Address(RVA = "0xA34790", Offset = "0xA33590", VA = "0x10A34790")]
    public int GetMoveHeight() => new int();

    [Token(Token = "0x600D7F5")]
    [Address(RVA = "0xA352A0", Offset = "0xA340A0", VA = "0x10A352A0")]
    public RecipeParam GetRarityUpRecipe() => (RecipeParam) null;

    [Token(Token = "0x600D7F6")]
    [Address(RVA = "0xA35270", Offset = "0xA34070", VA = "0x10A35270")]
    public RecipeParam GetRarityUpRecipe(int rarity) => (RecipeParam) null;

    [Token(Token = "0x600D7F7")]
    [Address(RVA = "0xA431E0", Offset = "0xA41FE0", VA = "0x10A431E0")]
    public bool UnitRarityUp() => new bool();

    [Token(Token = "0x600D7F8")]
    [Address(RVA = "0xA29A30", Offset = "0xA28830", VA = "0x10A29A30")]
    public bool CheckUnitRarityUp() => new bool();

    [Token(Token = "0x600D7F9")]
    [Address(RVA = "0xA351A0", Offset = "0xA33FA0", VA = "0x10A351A0")]
    public int GetRarityUpCost() => new int();

    [Token(Token = "0x600D7FA")]
    [Address(RVA = "0xA38B40", Offset = "0xA37940", VA = "0x10A38B40")]
    public bool IsExistsTobiraUnlockParamInMaster() => new bool();

    [Token(Token = "0x600D7FB")]
    [Address(RVA = "0xA376A0", Offset = "0xA364A0", VA = "0x10A376A0")]
    public int GetTobiraCount() => new int();

    [Token(Token = "0x600D7FC")]
    [Address(RVA = "0xA28950", Offset = "0xA27750", VA = "0x10A28950")]
    public bool CanUnlockTobira() => new bool();

    [Token(Token = "0x600D7FD")]
    [Address(RVA = "0xA3A270", Offset = "0xA39070", VA = "0x10A3A270")]
    public bool MeetsTobiraConditions(TobiraParam.Category category) => new bool();

    [Token(Token = "0x600D7FE")]
    [Address(RVA = "0xA39D80", Offset = "0xA38B80", VA = "0x10A39D80")]
    public bool MeetsTobiraConditions(
      TobiraParam.Category category,
      out List<UnitData.TobiraConditioError> errors)
    {
      return new bool();
    }

    [Token(Token = "0x600D7FF")]
    [Address(RVA = "0xA43110", Offset = "0xA41F10", VA = "0x10A43110")]
    public bool UnitAwaking() => new bool();

    [Token(Token = "0x600D800")]
    [Address(RVA = "0xA29810", Offset = "0xA28610", VA = "0x10A29810")]
    public bool CheckUnitAwaking() => new bool();

    [Token(Token = "0x600D801")]
    [Address(RVA = "0xA29930", Offset = "0xA28730", VA = "0x10A29930")]
    public bool CheckUnitAwaking(int awakelv) => new bool();

    [Token(Token = "0x600D802")]
    [Address(RVA = "0xA34940", Offset = "0xA33740", VA = "0x10A34940")]
    public int GetPieces() => new int();

    [Token(Token = "0x600D803")]
    [Address(RVA = "0xA331B0", Offset = "0xA31FB0", VA = "0x10A331B0")]
    public ItemParam GetElementPieceParam() => (ItemParam) null;

    [Token(Token = "0x600D804")]
    [Address(RVA = "0xA33050", Offset = "0xA31E50", VA = "0x10A33050")]
    public ItemData GetElementPieceData() => (ItemData) null;

    [Token(Token = "0x600D805")]
    [Address(RVA = "0xA33290", Offset = "0xA32090", VA = "0x10A33290")]
    public int GetElementPieces() => new int();

    [Token(Token = "0x600D806")]
    [Address(RVA = "0xA325F0", Offset = "0xA313F0", VA = "0x10A325F0")]
    public ItemParam GetCommonPieceParam() => (ItemParam) null;

    [Token(Token = "0x600D807")]
    [Address(RVA = "0xA32490", Offset = "0xA31290", VA = "0x10A32490")]
    public ItemData GetCommonPieceData() => (ItemData) null;

    [Token(Token = "0x600D808")]
    [Address(RVA = "0xA326D0", Offset = "0xA314D0", VA = "0x10A326D0")]
    public int GetCommonPieces() => new int();

    [Token(Token = "0x600D809")]
    [Address(RVA = "0xA37FA0", Offset = "0xA36DA0", VA = "0x10A37FA0")]
    public string GetUnlockTobiraElementID() => (string) null;

    [Token(Token = "0x600D80A")]
    [Address(RVA = "0xA37EB0", Offset = "0xA36CB0", VA = "0x10A37EB0")]
    public string GetUnlockTobiraBirthID() => (string) null;

    [Token(Token = "0x600D80B")]
    [Address(RVA = "0xA31DF0", Offset = "0xA30BF0", VA = "0x10A31DF0")]
    public int GetChangePieces() => new int();

    [Token(Token = "0x600D80C")]
    [Address(RVA = "0xA31B10", Offset = "0xA30910", VA = "0x10A31B10")]
    public int GetAwakeNeedPieces() => new int();

    [Token(Token = "0x600D80D")]
    [Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0")]
    public int GetAwakeCost() => new int();

    [Token(Token = "0x600D80E")]
    [Address(RVA = "0xA31A50", Offset = "0xA30850", VA = "0x10A31A50")]
    public int GetAwakeLevelCap() => new int();

    [Token(Token = "0x600D80F")]
    [Address(RVA = "0xA33A40", Offset = "0xA32840", VA = "0x10A33A40")]
    public JobParam GetJobParam(int jobNo) => (JobParam) null;

    [Token(Token = "0x600D810")]
    [Address(RVA = "0xA33950", Offset = "0xA32750", VA = "0x10A33950")]
    public JobData GetJobData(int jobNo) => (JobData) null;

    [Token(Token = "0x600D811")]
    [Address(RVA = "0xA32160", Offset = "0xA30F60", VA = "0x10A32160")]
    public JobData GetClassChangeJobData(int jobNo) => (JobData) null;

    [Token(Token = "0x600D812")]
    [Address(RVA = "0xA35020", Offset = "0xA33E20", VA = "0x10A35020")]
    public EquipData[] GetRankupEquips(int jobNo) => (EquipData[]) null;

    [Token(Token = "0x600D813")]
    [Address(RVA = "0xA34FD0", Offset = "0xA33DD0", VA = "0x10A34FD0")]
    public EquipData GetRankupEquipData(int jobNo, int slot) => (EquipData) null;

    [Token(Token = "0x600D814")]
    [Address(RVA = "0xA29050", Offset = "0xA27E50", VA = "0x10A29050")]
    public bool CheckEnableEquipSlot(int jobNo, int slot) => new bool();

    [Token(Token = "0x600D815")]
    [Address(RVA = "0xA28F40", Offset = "0xA27D40", VA = "0x10A28F40")]
    public bool CheckEnableEnhanceEquipment() => new bool();

    [Token(Token = "0x600D816")]
    [Address(RVA = "0xA34190", Offset = "0xA32F90", VA = "0x10A34190")]
    public JobSetParam GetJobSetParam(int jobNo) => (JobSetParam) null;

    [Token(Token = "0x600D817")]
    [Address(RVA = "0xA34020", Offset = "0xA32E20", VA = "0x10A34020")]
    public JobSetParam GetJobSetParam(string jobID) => (JobSetParam) null;

    [Token(Token = "0x600D818")]
    [Address(RVA = "0xA33DC0", Offset = "0xA32BC0", VA = "0x10A33DC0")]
    public JobSetParam GetJobSetParam2(string jobID) => (JobSetParam) null;

    [Token(Token = "0x600D819")]
    [Address(RVA = "0xA33A80", Offset = "0xA32880", VA = "0x10A33A80")]
    public int GetJobRankCap() => new int();

    [Token(Token = "0x600D81A")]
    [Address(RVA = "0xA339A0", Offset = "0xA327A0", VA = "0x10A339A0")]
    public int GetJobLevelByJobID(string iname) => new int();

    [Token(Token = "0x600D81B")]
    [Address(RVA = "0xA29600", Offset = "0xA28400", VA = "0x10A29600")]
    public bool CheckJobUnlockable(int jobNo) => new bool();

    [Token(Token = "0x600D81C")]
    [Address(RVA = "0xA295A0", Offset = "0xA283A0", VA = "0x10A295A0")]
    public bool CheckJobUnlock(int jobNo, bool canCreate) => new bool();

    [Token(Token = "0x600D81D")]
    [Address(RVA = "0xA29560", Offset = "0xA28360", VA = "0x10A29560")]
    public bool CheckJobRankUp() => new bool();

    [Token(Token = "0x600D81E")]
    [Address(RVA = "0xA29540", Offset = "0xA28340", VA = "0x10A29540")]
    public bool CheckJobRankUp(int jobNo) => new bool();

    [Token(Token = "0x600D81F")]
    [Address(RVA = "0xA29430", Offset = "0xA28230", VA = "0x10A29430")]
    public bool CheckJobRankUpAllEquip() => new bool();

    [Token(Token = "0x600D820")]
    [Address(RVA = "0xA29470", Offset = "0xA28270", VA = "0x10A29470")]
    public bool CheckJobRankUpAllEquip(int jobNo, bool useCommon = true) => new bool();

    [Token(Token = "0x600D821")]
    [Address(RVA = "0xA29490", Offset = "0xA28290", VA = "0x10A29490")]
    private bool CheckJobRankUpInternal(int jobNo, bool canCreate, bool useCommon = true)
    {
      return new bool();
    }

    [Token(Token = "0x600D822")]
    [Address(RVA = "0xA32270", Offset = "0xA31070", VA = "0x10A32270")]
    public JobParam GetClassChangeJobParam() => (JobParam) null;

    [Token(Token = "0x600D823")]
    [Address(RVA = "0xA321E0", Offset = "0xA30FE0", VA = "0x10A321E0")]
    public JobParam GetClassChangeJobParam(int jobNo) => (JobParam) null;

    [Token(Token = "0x600D824")]
    [Address(RVA = "0xA3CA60", Offset = "0xA3B860", VA = "0x10A3CA60")]
    public void ReserveTemporaryJobs()
    {
    }

    [Token(Token = "0x600D825")]
    [Address(RVA = "0xA322B0", Offset = "0xA310B0", VA = "0x10A322B0")]
    public JobSetParam GetClassChangeJobSet(int jobNo) => (JobSetParam) null;

    [Token(Token = "0x600D826")]
    [Address(RVA = "0xA293B0", Offset = "0xA281B0", VA = "0x10A293B0")]
    public bool CheckJobClassChange(int jobNo) => new bool();

    [Token(Token = "0x600D827")]
    [Address(RVA = "0xA28B70", Offset = "0xA27970", VA = "0x10A28B70")]
    public bool CheckClassChangeJobExist() => new bool();

    [Token(Token = "0x600D828")]
    [Address(RVA = "0xA28BB0", Offset = "0xA279B0", VA = "0x10A28BB0")]
    public bool CheckClassChangeJobExist(int jobNo) => new bool();

    [Token(Token = "0x600D829")]
    [Address(RVA = "0xA41BF0", Offset = "0xA409F0", VA = "0x10A41BF0")]
    public void SetJob(PlayerPartyTypes type)
    {
    }

    [Token(Token = "0x600D82A")]
    [Address(RVA = "0xA41BA0", Offset = "0xA409A0", VA = "0x10A41BA0")]
    public void SetJob(JobData job)
    {
    }

    [Token(Token = "0x600D82B")]
    [Address(RVA = "0xA416B0", Offset = "0xA404B0", VA = "0x10A416B0")]
    public void SetJobIndex(int jobNo)
    {
    }

    [Token(Token = "0x600D82C")]
    [Address(RVA = "0xA39820", Offset = "0xA38620", VA = "0x10A39820")]
    public void JobUnlock(int jobNo)
    {
    }

    [Token(Token = "0x600D82D")]
    [Address(RVA = "0xA39550", Offset = "0xA38350", VA = "0x10A39550")]
    public void JobClassChange(int jobNo)
    {
    }

    [Token(Token = "0x600D82E")]
    [Address(RVA = "0xA39760", Offset = "0xA38560", VA = "0x10A39760")]
    public void JobRankUp(int jobNo)
    {
    }

    [Token(Token = "0x600D82F")]
    [Address(RVA = "0xA33AF0", Offset = "0xA328F0", VA = "0x10A33AF0")]
    public List<ItemData> GetJobRankUpReturnItemData(int jobNo, bool ignoreEquiped = false)
    {
      return (List<ItemData>) null;
    }

    [Token(Token = "0x600D830")]
    [Address(RVA = "0xA2CE30", Offset = "0xA2BC30", VA = "0x10A2CE30")]
    private ItemData CreateItemData(string iname, int num) => (ItemData) null;

    [Token(Token = "0x600D831")]
    [Address(RVA = "0xA439F0", Offset = "0xA427F0", VA = "0x10A439F0")]
    private void UpdateAvailableJobs()
    {
    }

    [Token(Token = "0x600D832")]
    [Address(RVA = "0xA2FFC0", Offset = "0xA2EDC0", VA = "0x10A2FFC0")]
    private JobSetParam FindClassChangeBase2(string jobID) => (JobSetParam) null;

    [Token(Token = "0x600D833")]
    [Address(RVA = "0xA2FC90", Offset = "0xA2EA90", VA = "0x10A2FC90")]
    private List<JobSetParam> FindBaseJobs(string jobID) => (List<JobSetParam>) null;

    [Token(Token = "0x600D834")]
    [Address(RVA = "0xA41410", Offset = "0xA40210", VA = "0x10A41410")]
    public void SetEquipAbility(int slot, long iid)
    {
    }

    [Token(Token = "0x600D835")]
    [Address(RVA = "0xA413A0", Offset = "0xA401A0", VA = "0x10A413A0")]
    public void SetEquipAbility(int jobIndex, int slot, long iid)
    {
    }

    [Token(Token = "0x600D836")]
    [Address(RVA = "0xA442E0", Offset = "0xA430E0", VA = "0x10A442E0")]
    private void UpdateUnitLearnAbilityAll()
    {
    }

    [Token(Token = "0x600D837")]
    [Address(RVA = "0xA44320", Offset = "0xA43120", VA = "0x10A44320")]
    private void UpdateUnitLearnAbilityAll(int jobIndex)
    {
    }

    [Token(Token = "0x600D838")]
    [Address(RVA = "0xA26050", Offset = "0xA24E50", VA = "0x10A26050")]
    public void AddUnitBattleAbilityTransform()
    {
    }

    [Token(Token = "0x600D839")]
    [Address(RVA = "0xA442A0", Offset = "0xA430A0", VA = "0x10A442A0")]
    public void UpdateUnitBattleAbilityAll()
    {
    }

    [Token(Token = "0x600D83A")]
    [Address(RVA = "0xA43EC0", Offset = "0xA42CC0", VA = "0x10A43EC0")]
    private void UpdateUnitBattleAbilityAll(int jobIndex)
    {
    }

    [Token(Token = "0x600D83B")]
    [Address(RVA = "0xA24590", Offset = "0xA23390", VA = "0x10A24590")]
    private void AddBattleAbilityArtifacts(
      List<AbilityData> ability_list,
      List<SkillData> skill_list,
      int jobIndex)
    {
    }

    [Token(Token = "0x600D83C")]
    [Address(RVA = "0xA25180", Offset = "0xA23F80", VA = "0x10A25180")]
    private void AddBattleAbilitySkin(
      List<AbilityData> ability_list,
      List<SkillData> skill_list,
      int jobIndex)
    {
    }

    [Token(Token = "0x600D83D")]
    [Address(RVA = "0xA24920", Offset = "0xA23720", VA = "0x10A24920")]
    private void AddBattleAbilityConceptCard(
      List<AbilityData> ability_list,
      List<SkillData> skill_list,
      int jobIndex)
    {
    }

    [Token(Token = "0x600D83E")]
    [Address(RVA = "0xA24CD0", Offset = "0xA23AD0", VA = "0x10A24CD0")]
    private void AddBattleAbilityOther(List<AbilityData> ability_list, List<SkillData> skill_list)
    {
    }

    [Token(Token = "0x600D83F")]
    [Address(RVA = "0xA25390", Offset = "0xA24190", VA = "0x10A25390")]
    private void AddBattleAbilityTobira(
      List<AbilityData> ability_list,
      List<SkillData> skill_list,
      bool transform = false)
    {
    }

    [Token(Token = "0x600D840")]
    [Address(RVA = "0xA255F0", Offset = "0xA243F0", VA = "0x10A255F0")]
    private void AddBattleAbilityTruthEquipment(
      List<AbilityData> ability_list,
      List<SkillData> skill_list,
      bool transform = false)
    {
    }

    [Token(Token = "0x600D841")]
    [Address(RVA = "0xA3A2A0", Offset = "0xA390A0", VA = "0x10A3A2A0")]
    public void NPCRefrectionSkillAndAbility()
    {
    }

    [Token(Token = "0x600D842")]
    [Address(RVA = "0xA3C740", Offset = "0xA3B540", VA = "0x10A3C740")]
    public void RefrectionSkillAndAbility(
      List<AbilityData> ability_list,
      List<SkillData> skill_list,
      int jobIndex = -1)
    {
    }

    [Token(Token = "0x600D843")]
    [Address(RVA = "0xA3DE30", Offset = "0xA3CC30", VA = "0x10A3DE30")]
    public string SearchReplacementSkill(string skill_id, List<SkillData> skill_data = null)
    {
      return (string) null;
    }

    [Token(Token = "0x600D844")]
    [Address(RVA = "0xA3CEA0", Offset = "0xA3BCA0", VA = "0x10A3CEA0")]
    public string SearchAbilityReplacementSkill(string ability_id) => (string) null;

    [Token(Token = "0x600D845")]
    [Address(RVA = "0xA3D0C0", Offset = "0xA3BEC0", VA = "0x10A3D0C0")]
    public List<AbilityData> SearchDerivedAbilitys(AbilityData baseAbility)
    {
      return (List<AbilityData>) null;
    }

    [Token(Token = "0x600D846")]
    [Address(RVA = "0xA3D750", Offset = "0xA3C550", VA = "0x10A3D750")]
    public List<SkillData> SearchDerivedSkills(SkillData baseSkill) => (List<SkillData>) null;

    [Token(Token = "0x600D847")]
    [Address(RVA = "0xA35F90", Offset = "0xA34D90", VA = "0x10A35F90")]
    public SkillAbilityDeriveData GetSkillAbilityDeriveData(
      JobData target_job = null,
      ArtifactTypes replace_target_slot = ArtifactTypes.None,
      ArtifactParam new_artifact = null)
    {
      return (SkillAbilityDeriveData) null;
    }

    [Token(Token = "0x600D848")]
    [Address(RVA = "0xA3BE20", Offset = "0xA3AC20", VA = "0x10A3BE20")]
    private static void RefrectionDeriveSkillAndAbility(
      SkillAbilityDeriveData skillAbilityDeriveData,
      List<AbilityData> refAbilitys,
      List<SkillData> refSkills)
    {
    }

    [Token(Token = "0x600D849")]
    [Address(RVA = "0xA438C0", Offset = "0xA426C0", VA = "0x10A438C0")]
    public void UpdateAbilityRankUp()
    {
    }

    [Token(Token = "0x600D84A")]
    [Address(RVA = "0xA438C0", Offset = "0xA426C0", VA = "0x10A438C0")]
    public void UpdateConceptCardChanged()
    {
    }

    [Token(Token = "0x600D84B")]
    [Address(RVA = "0xA438C0", Offset = "0xA426C0", VA = "0x10A438C0")]
    public void UpdateRuneChanged()
    {
    }

    [Token(Token = "0x600D84C")]
    [Address(RVA = "0xA2D0C0", Offset = "0xA2BEC0", VA = "0x10A2D0C0")]
    public List<AbilityData> CreateLearnAbilitys() => (List<AbilityData>) null;

    [Token(Token = "0x600D84D")]
    [Address(RVA = "0xA2CED0", Offset = "0xA2BCD0", VA = "0x10A2CED0")]
    public List<AbilityData> CreateLearnAbilitys(int jobIndex) => (List<AbilityData>) null;

    [Token(Token = "0x600D84E")]
    [Address(RVA = "0xA30C70", Offset = "0xA2FA70", VA = "0x10A30C70")]
    public List<AbilityData> GetAllLearnedAbilities(bool enableDerive = false, bool truth_ignore_overwrite = false)
    {
      return (List<AbilityData>) null;
    }

    [Token(Token = "0x600D84F")]
    [Address(RVA = "0xA2AC30", Offset = "0xA29A30", VA = "0x10A2AC30")]
    public AbilityData[] CreateEquipAbilitys() => (AbilityData[]) null;

    [Token(Token = "0x600D850")]
    [Address(RVA = "0xA2AB00", Offset = "0xA29900", VA = "0x10A2AB00")]
    public AbilityData[] CreateEquipAbilitys(int jobIndex) => (AbilityData[]) null;

    [Token(Token = "0x600D851")]
    [Address(RVA = "0xA2AD80", Offset = "0xA29B80", VA = "0x10A2AD80")]
    public List<SkillData> CreateEquipSkills() => (List<SkillData>) null;

    [Token(Token = "0x600D852")]
    [Address(RVA = "0xA2ADC0", Offset = "0xA29BC0", VA = "0x10A2ADC0")]
    public List<SkillData> CreateEquipSkills(int jobIndex) => (List<SkillData>) null;

    [Token(Token = "0x600D853")]
    [Address(RVA = "0xA30A80", Offset = "0xA2F880", VA = "0x10A30A80")]
    public AbilityData GetAbilityData(long iid) => (AbilityData) null;

    [Token(Token = "0x600D854")]
    [Address(RVA = "0xA36B70", Offset = "0xA35970", VA = "0x10A36B70")]
    public SkillData GetSkillData(string iname) => (SkillData) null;

    [Token(Token = "0x600D855")]
    [Address(RVA = "0xA36160", Offset = "0xA34F60", VA = "0x10A36160")]
    public SkillData GetSkillData(string iname, ref int jobIndex) => (SkillData) null;

    [Token(Token = "0x600D856")]
    [Address(RVA = "0xA36CC0", Offset = "0xA35AC0", VA = "0x10A36CC0")]
    public int GetSkillUsedCost(SkillData skill) => new int();

    [Token(Token = "0x600D857")]
    [Address(RVA = "0xA36B90", Offset = "0xA35990", VA = "0x10A36B90")]
    public int GetSkillUsedCost(SkillParam skill) => new int();

    [Token(Token = "0x600D858")]
    [Address(RVA = "0xA37950", Offset = "0xA36750", VA = "0x10A37950")]
    public UnitJobOverwriteParam GetUnitJobOverwriteParam(string job_iname)
    {
      return (UnitJobOverwriteParam) null;
    }

    [Token(Token = "0x600D859")]
    [Address(RVA = "0xA43090", Offset = "0xA41E90", VA = "0x10A43090", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600D85A")]
    [Address(RVA = "0xA42940", Offset = "0xA41740", VA = "0x10A42940")]
    public void SetVirtualAwakeLv(int target_awake_lv)
    {
    }

    [Token(Token = "0x600D85B")]
    [Address(RVA = "0xA29240", Offset = "0xA28040", VA = "0x10A29240")]
    public bool CheckEnableEquipment(ItemParam item) => new bool();

    [Token(Token = "0x600D85C")]
    [Address(RVA = "0xA43B60", Offset = "0xA42960", VA = "0x10A43B60")]
    public void UpdateBadge()
    {
    }

    [Token(Token = "0x600D85D")]
    [Address(RVA = "0xA41090", Offset = "0xA3FE90", VA = "0x10A41090")]
    private void SetBadgeState(UnitBadgeTypes type, bool flag)
    {
    }

    [Token(Token = "0x600D85E")]
    [Address(RVA = "0xA29090", Offset = "0xA27E90", VA = "0x10A29090")]
    private bool CheckEnableEquipmentBadge() => new bool();

    [Token(Token = "0x600D85F")]
    [Address(RVA = "0xA336A0", Offset = "0xA324A0", VA = "0x10A336A0")]
    public ArtifactParam GetEquipArmArtifact() => (ArtifactParam) null;

    [Token(Token = "0x600D860")]
    [Address(RVA = "0xA33740", Offset = "0xA32540", VA = "0x10A33740")]
    public ArtifactParam GetEquipArtifactParam(int slot, JobData job = null)
    {
      return (ArtifactParam) null;
    }

    [Token(Token = "0x600D861")]
    [Address(RVA = "0xA336E0", Offset = "0xA324E0", VA = "0x10A336E0")]
    public ArtifactData GetEquipArtifactData(int slot, JobData job = null) => (ArtifactData) null;

    [Token(Token = "0x600D862")]
    [Address(RVA = "0xA36ED0", Offset = "0xA35CD0", VA = "0x10A36ED0")]
    public ArtifactData[] GetSortedArtifactDatas(ArtifactData[] artifacts) => (ArtifactData[]) null;

    [Token(Token = "0x600D863")]
    [Address(RVA = "0xA41520", Offset = "0xA40320", VA = "0x10A41520")]
    public bool SetEquipArtifactData(int slot, ArtifactData artifact) => new bool();

    [Token(Token = "0x600D864")]
    [Address(RVA = "0xA41450", Offset = "0xA40250", VA = "0x10A41450")]
    public bool SetEquipArtifactData(int job_index, int slot, ArtifactData artifact, bool is_calc = true)
    {
      return new bool();
    }

    [Token(Token = "0x600D865")]
    [Address(RVA = "0xA43930", Offset = "0xA42730", VA = "0x10A43930")]
    public void UpdateArtifact(int job_index, bool is_calc = true, bool refreshSkillAbilityDeriveData = false)
    {
    }

    [Token(Token = "0x600D866")]
    [Address(RVA = "0x2E2BB0", Offset = "0x2E19B0", VA = "0x102E2BB0")]
    public void SetUniqueID(long uniqueID)
    {
    }

    [Token(Token = "0x600D867")]
    [Address(RVA = "0xA43EA0", Offset = "0xA42CA0", VA = "0x10A43EA0")]
    private void UpdateSyncTime()
    {
    }

    [Token(Token = "0x600D868")]
    [Address(RVA = "0xA37DB0", Offset = "0xA36BB0", VA = "0x10A37DB0")]
    public string GetUnitSkinVoiceSheetName(int jobIndex = -1) => (string) null;

    [Token(Token = "0x600D869")]
    [Address(RVA = "0xA37D50", Offset = "0xA36B50", VA = "0x10A37D50")]
    public string GetUnitSkinVoiceCueName(int jobIndex = -1) => (string) null;

    [Token(Token = "0x600D86A")]
    [Address(RVA = "0xA379B0", Offset = "0xA367B0", VA = "0x10A379B0")]
    public string GetUnitJobVoiceSheetName(int jobIndex = -1) => (string) null;

    [Token(Token = "0x600D86B")]
    [Address(RVA = "0xA37AA0", Offset = "0xA368A0", VA = "0x10A37AA0")]
    public UnitData.UnitPlaybackVoiceData GetUnitPlaybackVoiceData()
    {
      return (UnitData.UnitPlaybackVoiceData) null;
    }

    [Token(Token = "0x600D86C")]
    [Address(RVA = "0xA29BB0", Offset = "0xA289B0", VA = "0x10A29BB0")]
    public bool CheckUnlockPlaybackVoice() => new bool();

    [Token(Token = "0x600D86D")]
    [Address(RVA = "0xA3CDD0", Offset = "0xA3BBD0", VA = "0x10A3CDD0")]
    public UnitData.CharacterQuestUnlockProgress SaveUnlockProgress()
    {
      return (UnitData.CharacterQuestUnlockProgress) null;
    }

    [Token(Token = "0x600D86E")]
    [Address(RVA = "0xA38EE0", Offset = "0xA37CE0", VA = "0x10A38EE0")]
    public bool IsQuestUnlocked(UnitData.CharacterQuestUnlockProgress progress) => new bool();

    [Token(Token = "0x17001CC1")]
    public int CharacterQuestRarity
    {
      [Token(Token = "0x600D86F"), Address(RVA = "0xA45530", Offset = "0xA44330", VA = "0x10A45530")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600D870")]
    [Address(RVA = "0xA38BF0", Offset = "0xA379F0", VA = "0x10A38BF0")]
    public bool IsOpenCharacterQuest() => new bool();

    [Token(Token = "0x600D871")]
    [Address(RVA = "0xA30130", Offset = "0xA2EF30", VA = "0x10A30130")]
    public List<QuestParam> FindCondQuests() => (List<QuestParam>) null;

    [Token(Token = "0x600D872")]
    [Address(RVA = "0xA32FC0", Offset = "0xA31DC0", VA = "0x10A32FC0")]
    public UnitData.CharacterQuestParam GetCurrentCharaEpisodeData()
    {
      return (UnitData.CharacterQuestParam) null;
    }

    [Token(Token = "0x600D873")]
    [Address(RVA = "0xA31F30", Offset = "0xA30D30", VA = "0x10A31F30")]
    public UnitData.CharacterQuestParam[] GetCharaEpisodeList()
    {
      return (UnitData.CharacterQuestParam[]) null;
    }

    [Token(Token = "0x600D874")]
    [Address(RVA = "0xA3B360", Offset = "0xA3A160", VA = "0x10A3B360")]
    public bool OpenNewCharacterEpisodeOnLevelUp(
      int beforeLv,
      UnitData.CharacterQuestParam targetQuset = null)
    {
      return new bool();
    }

    [Token(Token = "0x600D875")]
    [Address(RVA = "0xA3B000", Offset = "0xA39E00", VA = "0x10A3B000")]
    public bool OpenCharacterQuestOnLevelUp(int beforeLv) => new bool();

    [Token(Token = "0x600D876")]
    [Address(RVA = "0xA3B140", Offset = "0xA39F40", VA = "0x10A3B140")]
    public bool OpenCharacterQuestOnQuestResult(QuestParam startParam, int beforeLv) => new bool();

    [Token(Token = "0x600D877")]
    [Address(RVA = "0xA3B240", Offset = "0xA3A040", VA = "0x10A3B240")]
    public bool OpenCharacterQuestOnRarityUp(int beforeRarity) => new bool();

    [Token(Token = "0x600D878")]
    [Address(RVA = "0xA39210", Offset = "0xA38010", VA = "0x10A39210")]
    public bool IsSetCharacterQuest() => new bool();

    [Token(Token = "0x600D879")]
    [Address(RVA = "0xA2FE40", Offset = "0xA2EC40", VA = "0x10A2FE40")]
    public void FindCharacterQuestParams()
    {
    }

    [Token(Token = "0x600D87A")]
    [Address(RVA = "0xA3CC10", Offset = "0xA3BA10", VA = "0x10A3CC10")]
    public void ResetCharacterQuestParams()
    {
    }

    [Token(Token = "0x600D87B")]
    [Address(RVA = "0xA38150", Offset = "0xA36F50", VA = "0x10A38150")]
    public bool IsChQuestParentUnlocked(QuestParam quest) => new bool();

    [Token(Token = "0x600D87C")]
    [Address(RVA = "0xA33980", Offset = "0xA32780", VA = "0x10A33980")]
    public JobData GetJobFor(PlayerPartyTypes type) => (JobData) null;

    [Token(Token = "0x600D87D")]
    [Address(RVA = "0xA41610", Offset = "0xA40410", VA = "0x10A41610")]
    public void SetJobFor(PlayerPartyTypes type, JobData job)
    {
    }

    [Token(Token = "0x600D87E")]
    [Address(RVA = "0xA28D70", Offset = "0xA27B70", VA = "0x10A28D70")]
    public bool CheckCommon(int index, int slot) => new bool();

    [Token(Token = "0x600D87F")]
    [Address(RVA = "0xA43380", Offset = "0xA42180", VA = "0x10A43380")]
    public string UnlockedCollaboSkillIds() => (string) null;

    [Token(Token = "0x17001CC2")]
    public bool IsThrow
    {
      [Token(Token = "0x600D880"), Address(RVA = "0xA45D10", Offset = "0xA44B10", VA = "0x10A45D10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D881")]
    [Address(RVA = "0xA29D30", Offset = "0xA28B30", VA = "0x10A29D30")]
    public static int CompareTo_Iname(UnitData unit1, UnitData unit2) => new int();

    [Token(Token = "0x600D882")]
    [Address(RVA = "0xA29DE0", Offset = "0xA28BE0", VA = "0x10A29DE0")]
    public static int CompareTo_Lv(UnitData unit1, UnitData unit2) => new int();

    [Token(Token = "0x600D883")]
    [Address(RVA = "0xA29D80", Offset = "0xA28B80", VA = "0x10A29D80")]
    public static int CompareTo_JobRank(UnitData unit1, UnitData unit2) => new int();

    [Token(Token = "0x600D884")]
    [Address(RVA = "0xA29EA0", Offset = "0xA28CA0", VA = "0x10A29EA0")]
    public static int CompareTo_Rarity(UnitData unit1, UnitData unit2) => new int();

    [Token(Token = "0x600D885")]
    [Address(RVA = "0xA29E40", Offset = "0xA28C40", VA = "0x10A29E40")]
    public static int CompareTo_RarityInit(UnitData unit1, UnitData unit2) => new int();

    [Token(Token = "0x600D886")]
    [Address(RVA = "0xA29E70", Offset = "0xA28C70", VA = "0x10A29E70")]
    public static int CompareTo_RarityMax(UnitData unit1, UnitData unit2) => new int();

    [Token(Token = "0x600D887")]
    [Address(RVA = "0xA29F00", Offset = "0xA28D00", VA = "0x10A29F00")]
    public bool Compareto_UnitOverWrite(UnitData unit, EInvalidSkillApplyType apply_type)
    {
      return new bool();
    }

    [Token(Token = "0x17001CC3")]
    public bool IsKnockBack
    {
      [Token(Token = "0x600D888"), Address(RVA = "0xA45B30", Offset = "0xA44930", VA = "0x10A45B30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001CC4")]
    public bool IsChanging
    {
      [Token(Token = "0x600D889"), Address(RVA = "0xA45AD0", Offset = "0xA448D0", VA = "0x10A45AD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D88A")]
    [Address(RVA = "0xA28780", Offset = "0xA27580", VA = "0x10A28780")]
    public int CalcTotalParameter() => new int();

    [Token(Token = "0x600D88B")]
    [Address(RVA = "0xA37890", Offset = "0xA36690", VA = "0x10A37890")]
    public SRPG.TobiraData GetTobiraData(TobiraParam.Category category) => (SRPG.TobiraData) null;

    [Token(Token = "0x600D88C")]
    [Address(RVA = "0xA297E0", Offset = "0xA285E0", VA = "0x10A297E0")]
    public bool CheckTobiraIsUnlocked(TobiraParam.Category category) => new bool();

    [Token(Token = "0x600D88D")]
    [Address(RVA = "0xA42310", Offset = "0xA41110", VA = "0x10A42310")]
    public void SetTobiraData(List<SRPG.TobiraData> tobiraData)
    {
    }

    [Token(Token = "0x600D88E")]
    [Address(RVA = "0xA2F9A0", Offset = "0xA2E7A0", VA = "0x10A2F9A0")]
    public void DtuTobiraCopyTo(UnitData from_unit_data)
    {
    }

    [Token(Token = "0x600D88F")]
    [Address(RVA = "0xA2F8D0", Offset = "0xA2E6D0", VA = "0x10A2F8D0")]
    public void DtuSetupSkillAbilityDerive()
    {
    }

    [Token(Token = "0x600D890")]
    [Address(RVA = "0xA2FA00", Offset = "0xA2E800", VA = "0x10A2FA00")]
    public void DtuTruthEquipmentCopy(UnitData _from_unit_data)
    {
    }

    [Token(Token = "0x600D891")]
    [Address(RVA = "0xA2F880", Offset = "0xA2E680", VA = "0x10A2F880")]
    public void DtuResonanceCopyTo(UnitData from_unit_data)
    {
    }

    [Token(Token = "0x600D892")]
    [Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")]
    public void DtuDtuFromOriginUnitId(string _iname)
    {
    }

    [Token(Token = "0x600D893")]
    [Address(RVA = "0xA3B410", Offset = "0xA3A210", VA = "0x10A3B410")]
    public void OverWrite(UnitOverWriteData over_write_data, eOverWritePartyType ow_party_type)
    {
    }

    [Token(Token = "0x600D894")]
    [Address(RVA = "0xA39830", Offset = "0xA38630", VA = "0x10A39830")]
    public void LeagueMatchApply()
    {
    }

    [Token(Token = "0x600D895")]
    [Address(RVA = "0xA38520", Offset = "0xA37320", VA = "0x10A38520")]
    public bool IsEquipConceptCard(long iid) => new bool();

    [Token(Token = "0x600D896")]
    [Address(RVA = "0xA30140", Offset = "0xA2EF40", VA = "0x10A30140")]
    public int FindIndexOfConceptCard(long iid) => new int();

    [Token(Token = "0x600D897")]
    [Address(RVA = "0xA32730", Offset = "0xA31530", VA = "0x10A32730")]
    public ConceptCardData GetConceptCardByIndex(int index) => (ConceptCardData) null;

    [Token(Token = "0x600D898")]
    [Address(RVA = "0xA410C0", Offset = "0xA3FEC0", VA = "0x10A410C0")]
    public void SetConceptCardByIndex(int index, ConceptCardData conceptCard)
    {
    }

    [Token(Token = "0x600D899")]
    [Address(RVA = "0xA2F7D0", Offset = "0xA2E5D0", VA = "0x10A2F7D0")]
    public void DetachConceptCard(long iid)
    {
    }

    [Token(Token = "0x600D89A")]
    [Address(RVA = "0xA41C60", Offset = "0xA40A60", VA = "0x10A41C60")]
    public void SetNpcConceptCardLeaderSkill(NPCSetting _npc)
    {
    }

    [Token(Token = "0x600D89B")]
    [Address(RVA = "0xA41170", Offset = "0xA3FF70", VA = "0x10A41170")]
    public void SetConceptCardMainSlot(ConceptCardData conceptCard)
    {
    }

    [Token(Token = "0x600D89C")]
    [Address(RVA = "0xA2F760", Offset = "0xA2E560", VA = "0x10A2F760")]
    public void DetachConceptCardMainSlot()
    {
    }

    [Token(Token = "0x600D89D")]
    [Address(RVA = "0xA39380", Offset = "0xA38180", VA = "0x10A39380")]
    public bool IsUnlockConceptCardSlot(int slotIndex) => new bool();

    [Token(Token = "0x600D89E")]
    [Address(RVA = "0xA2DBD0", Offset = "0xA2C9D0", VA = "0x10A2DBD0")]
    public static UnitData CreateUnitDataForDisplay(string iname) => (UnitData) null;

    [Token(Token = "0x600D89F")]
    [Address(RVA = "0xA2D8A0", Offset = "0xA2C6A0", VA = "0x10A2D8A0")]
    public static UnitData CreateUnitDataForDisplay(UnitParam uparam) => (UnitData) null;

    [Token(Token = "0x600D8A0")]
    [Address(RVA = "0xA39190", Offset = "0xA37F90", VA = "0x10A39190")]
    public bool IsSameUnit(string unit_iname) => new bool();

    [Token(Token = "0x600D8A1")]
    [Address(RVA = "0xA2B530", Offset = "0xA2A330", VA = "0x10A2B530")]
    public UnitData.InvalidSkillList CreateInvalidSkillList() => (UnitData.InvalidSkillList) null;

    [Token(Token = "0x600D8A2")]
    [Address(RVA = "0xA25C80", Offset = "0xA24A80", VA = "0x10A25C80")]
    private bool AddSkillSetList(
      UnitData unit_data,
      List<UnitData.InvalidSkillList.Data.SkillSet> skill_set_list,
      SkillParam skill_param,
      List<SkillData> initial_skill_list,
      List<SkillDeriveParam> skill_derive_param_list)
    {
      return new bool();
    }

    [Token(Token = "0x600D8A3")]
    [Address(RVA = "0xA38A70", Offset = "0xA37870", VA = "0x10A38A70")]
    private bool IsExistBattleSkills(SkillParam skill_param) => new bool();

    [Token(Token = "0x600D8A4")]
    [Address(RVA = "0xA2AF70", Offset = "0xA29D70", VA = "0x10A2AF70")]
    private bool CreateInitialSkillList(
      int job_index,
      ref List<AbilityData> ability_list,
      ref List<SkillData> skill_list)
    {
      return new bool();
    }

    [Token(Token = "0x600D8A5")]
    [Address(RVA = "0xA2A480", Offset = "0xA29280", VA = "0x10A2A480")]
    private bool CreateDynamicSkillParam(
      UnitData unit_data,
      List<SkillData> initial_skill_list,
      List<SkillDeriveParam> skill_derive_param_list,
      SkillParam skill_org,
      ref List<SkillParam> skill_param_list)
    {
      return new bool();
    }

    [Token(Token = "0x600D8A6")]
    [Address(RVA = "0xA3DA70", Offset = "0xA3C870", VA = "0x10A3DA70")]
    private AbilityData SearchFromAbiliry(UnitData unit_data, SkillParam skill_org)
    {
      return (AbilityData) null;
    }

    [Token(Token = "0x600D8A7")]
    [Address(RVA = "0xA258F0", Offset = "0xA246F0", VA = "0x10A258F0")]
    private bool AddDynamicSkillParam(
      UnitData unit_data,
      List<SkillData> initial_skill_list,
      List<SkillDeriveParam> skill_derive_param_list,
      SkillParam sp,
      ref List<SkillParam> skill_param_list)
    {
      return new bool();
    }

    [Token(Token = "0x600D8A8")]
    [Address(RVA = "0xA41210", Offset = "0xA40010", VA = "0x10A41210")]
    private void SetCurrentBaseAbility()
    {
    }

    [Token(Token = "0x600D8A9")]
    [Address(RVA = "0xA41D70", Offset = "0xA40B70", VA = "0x10A41D70")]
    private void SetSlotSupportReactionAbility(
      ref List<AbilityData> all_ability_list,
      ref List<SkillData> initial_skill_list)
    {
    }

    [Token(Token = "0x600D8AA")]
    [Address(RVA = "0xA2D660", Offset = "0xA2C460", VA = "0x10A2D660")]
    public SkillDeriveParam CreateSkillDeriveParam(SkillParam skill_param, int job_index)
    {
      return (SkillDeriveParam) null;
    }

    [Token(Token = "0x600D8AB")]
    [Address(RVA = "0xA2A310", Offset = "0xA29110", VA = "0x10A2A310")]
    public void CopyDtuInvalidSkillDatas(InvalidSkillData _invalid_skill_data)
    {
    }

    [Token(Token = "0x600D8AC")]
    [Address(RVA = "0xA32760", Offset = "0xA31560", VA = "0x10A32760")]
    public CrystalData GetCrystalBySlot(int slot_no) => (CrystalData) null;

    [Token(Token = "0x600D8AD")]
    [Address(RVA = "0xA36E00", Offset = "0xA35C00", VA = "0x10A36E00")]
    public CrystalData.ESlotIndex GetSlotIndex(string _iname) => new CrystalData.ESlotIndex();

    [Token(Token = "0x600D8AE")]
    [Address(RVA = "0xA388C0", Offset = "0xA376C0", VA = "0x10A388C0")]
    public bool IsEquipCrystal(long iid) => new bool();

    [Token(Token = "0x600D8AF")]
    [Address(RVA = "0xA387E0", Offset = "0xA375E0", VA = "0x10A387E0")]
    public bool IsEquipCrystal(string _iname) => new bool();

    [Token(Token = "0x600D8B0")]
    [Address(RVA = "0xA38610", Offset = "0xA37410", VA = "0x10A38610")]
    public bool IsEquipCrystalByEquipSelect(CrystalData _data) => new bool();

    [Token(Token = "0x600D8B1")]
    [Address(RVA = "0xA35ED0", Offset = "0xA34CD0", VA = "0x10A35ED0")]
    public void GetSetBonusData()
    {
    }

    [Token(Token = "0x600D8B2")]
    [Address(RVA = "0xA39470", Offset = "0xA38270", VA = "0x10A39470")]
    public bool IsUnlockCrystalSlot(int _slot_index) => new bool();

    [Token(Token = "0x600D8B3")]
    [Address(RVA = "0xA2A350", Offset = "0xA29150", VA = "0x10A2A350")]
    public long[] CreateCrystalIds() => (long[]) null;

    [Token(Token = "0x600D8B4")]
    [Address(RVA = "0xA37410", Offset = "0xA36210", VA = "0x10A37410")]
    public int GetSubCrystalRate(CrystalData _data) => new int();

    [Token(Token = "0x600D8B5")]
    [Address(RVA = "0xA32820", Offset = "0xA31620", VA = "0x10A32820")]
    public int GetCrystalLimitParam(ParamTypes _type, List<CrystalData> _list) => new int();

    [Token(Token = "0x600D8B6")]
    [Address(RVA = "0xA371B0", Offset = "0xA35FB0", VA = "0x10A371B0")]
    public short GetStartGems(bool isMax = false) => new short();

    [Token(Token = "0x600D8B7")]
    [Address(RVA = "0xA43C90", Offset = "0xA42A90", VA = "0x10A43C90")]
    public void UpdatePlayerBuffs(JSON_PlayerBuff _buff)
    {
    }

    [Token(Token = "0x600D8B8")]
    [Address(RVA = "0xA29CA0", Offset = "0xA28AA0", VA = "0x10A29CA0")]
    public void ClearPlayerBuffs()
    {
    }

    [Token(Token = "0x600D8B9")]
    [Address(RVA = "0xA349F0", Offset = "0xA337F0", VA = "0x10A349F0")]
    public JSON_PlayerBuff GetPlayerBuffSerialze() => (JSON_PlayerBuff) null;

    [Token(Token = "0x600D8BA")]
    [Address(RVA = "0xA42820", Offset = "0xA41620", VA = "0x10A42820")]
    public void SetUpTobiraLeaderSkill()
    {
    }

    [Token(Token = "0x600D8BB")]
    [Address(RVA = "0xA42330", Offset = "0xA41130", VA = "0x10A42330")]
    public void SetUpMasterAbility(Json_MasterAbility _abi)
    {
    }

    [Token(Token = "0x600D8BC")]
    [Address(RVA = "0xA423F0", Offset = "0xA411F0", VA = "0x10A423F0")]
    public void SetUpQuestClearUnlock(string[] quest_clear_unlocks)
    {
    }

    [Token(Token = "0x17001CC5")]
    public bool IsOpen
    {
      [Token(Token = "0x600D8BD"), Address(RVA = "0xA39180", Offset = "0xA37F80", VA = "0x10A39180")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001CC6")]
    public RunePrideData RunePride
    {
      [Token(Token = "0x600D8BE"), Address(RVA = "0x66A5A0", Offset = "0x6693A0", VA = "0x1066A5A0")] get
      {
        return (RunePrideData) null;
      }
      [Token(Token = "0x600D8BF"), Address(RVA = "0xA46530", Offset = "0xA45330", VA = "0x10A46530")] set
      {
      }
    }

    [Token(Token = "0x600D8C0")]
    [Address(RVA = "0xA2DCC0", Offset = "0xA2CAC0", VA = "0x10A2DCC0")]
    public void DeserializeRunePride(Json_Unit json)
    {
    }

    [Token(Token = "0x600D8C1")]
    [Address(RVA = "0xA38FE0", Offset = "0xA37DE0", VA = "0x10A38FE0")]
    public bool IsReleased(string panelIname, int squareId) => new bool();

    [Token(Token = "0x600D8C2")]
    [Address(RVA = "0xA39180", Offset = "0xA37F80", VA = "0x10A39180")]
    public bool IsRunePrideReleased() => new bool();

    [Token(Token = "0x600D8C3")]
    [Address(RVA = "0xA354E0", Offset = "0xA342E0", VA = "0x10A354E0")]
    public int GetRunePrideBonusSumNum() => new int();

    [Token(Token = "0x600D8C4")]
    [Address(RVA = "0xA352E0", Offset = "0xA340E0", VA = "0x10A352E0")]
    public int GetRunPrideDecreaseEffectRate() => new int();

    [Token(Token = "0x600D8C5")]
    [Address(RVA = "0xA353E0", Offset = "0xA341E0", VA = "0x10A353E0")]
    public int GetRunPrideSubCrystalRate() => new int();

    [Token(Token = "0x17001CC7")]
    public int StatusAwakeHP
    {
      [Token(Token = "0x600D8C6"), Address(RVA = "0x9A04B0", Offset = "0x99F2B0", VA = "0x109A04B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600D8C7"), Address(RVA = "0xA46550", Offset = "0xA45350", VA = "0x10A46550")] set
      {
      }
    }

    [Token(Token = "0x17001CC8")]
    public List<StatusAwakeData> StatusAwakeDatas
    {
      [Token(Token = "0x600D8C8"), Address(RVA = "0xA46360", Offset = "0xA45160", VA = "0x10A46360")] get
      {
        return (List<StatusAwakeData>) null;
      }
    }

    [Token(Token = "0x600D8C9")]
    [Address(RVA = "0xA26A50", Offset = "0xA25850", VA = "0x10A26A50")]
    private void CalcStatusAwake(ref BaseStatus _status)
    {
    }

    [Token(Token = "0x600D8CA")]
    [Address(RVA = "0xA37330", Offset = "0xA36130", VA = "0x10A37330")]
    public int GetStatusAwakeUseItemNum(string iname) => new int();

    [Token(Token = "0x600D8CB")]
    [Address(RVA = "0xA42110", Offset = "0xA40F10", VA = "0x10A42110")]
    public void SetStatusAwakeData(Json_StatusAwakeData[] use_datas)
    {
    }

    [Token(Token = "0x600D8CC")]
    [Address(RVA = "0xA3CD20", Offset = "0xA3BB20", VA = "0x10A3CD20")]
    public void ResetStatusAwakeData()
    {
    }

    [Token(Token = "0x600D8CD")]
    [Address(RVA = "0xA450F0", Offset = "0xA43EF0", VA = "0x10A450F0")]
    public UnitData()
    {
    }

    [Token(Token = "0x600D8CE")]
    [Address(RVA = "0xA444E0", Offset = "0xA432E0", VA = "0x10A444E0")]
    static UnitData()
    {
    }

    [Token(Token = "0x2002DD0")]
    [Flags]
    public enum TemporaryFlags
    {
      [Token(Token = "0x400E543")] TemporaryUnitData = 1,
      [Token(Token = "0x400E544")] AllowJobChange = 2,
    }

    [Token(Token = "0x2002DD1")]
    public class TobiraConditioError
    {
      [Token(Token = "0x400E545")]
      [FieldOffset(Offset = "0x8")]
      public UnitData.TobiraConditioError.ErrorType Type;

      [Token(Token = "0x600D8D0")]
      [Address(RVA = "0x28EFD0", Offset = "0x28DDD0", VA = "0x1028EFD0")]
      public TobiraConditioError(UnitData.TobiraConditioError.ErrorType type)
      {
      }

      [Token(Token = "0x2002DD2")]
      public enum ErrorType
      {
        [Token(Token = "0x400E547")] None,
        [Token(Token = "0x400E548")] Quest,
        [Token(Token = "0x400E549")] UnitNone,
        [Token(Token = "0x400E54A")] UnitLevel,
        [Token(Token = "0x400E54B")] UnitAwakeLevel,
        [Token(Token = "0x400E54C")] UnitJobLevel,
        [Token(Token = "0x400E54D")] UnitTobiraLevel,
        [Token(Token = "0x400E54E")] UnitOpenAllJobs,
      }
    }

    [Token(Token = "0x2002DD3")]
    public class Json_PlaybackVoiceData
    {
      [Token(Token = "0x400E54F")]
      [FieldOffset(Offset = "0x8")]
      public int playback_voice_unlocked;
      [Token(Token = "0x400E550")]
      [FieldOffset(Offset = "0xC")]
      public List<string> cue_names;

      [Token(Token = "0x600D8D1")]
      [Address(RVA = "0xA49ED0", Offset = "0xA48CD0", VA = "0x10A49ED0")]
      public Json_PlaybackVoiceData()
      {
      }
    }

    [Token(Token = "0x2002DD4")]
    public class UnitVoiceCueInfo
    {
      [Token(Token = "0x400E551")]
      [FieldOffset(Offset = "0x8")]
      public CriAtomEx.CueInfo cueInfo;
      [Token(Token = "0x400E552")]
      [FieldOffset(Offset = "0x88")]
      public string voice_name;
      [Token(Token = "0x400E553")]
      [FieldOffset(Offset = "0x8C")]
      public bool has_conditions;
      [Token(Token = "0x400E554")]
      [FieldOffset(Offset = "0x8D")]
      public bool is_locked;
      [Token(Token = "0x400E555")]
      [FieldOffset(Offset = "0x8E")]
      public bool is_new;
      [Token(Token = "0x400E556")]
      [FieldOffset(Offset = "0x90")]
      public string unlock_conditions_text;
      [Token(Token = "0x400E557")]
      [FieldOffset(Offset = "0x94")]
      public int number;

      [Token(Token = "0x600D8D2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public UnitVoiceCueInfo()
      {
      }
    }

    [Token(Token = "0x2002DD5")]
    public class UnitPlaybackVoiceData
    {
      [Token(Token = "0x400E558")]
      [FieldOffset(Offset = "0x8")]
      private UnitData unit;
      [Token(Token = "0x400E559")]
      [FieldOffset(Offset = "0xC")]
      private MySound.Voice voice;
      [Token(Token = "0x400E55A")]
      [FieldOffset(Offset = "0x10")]
      private List<UnitData.UnitVoiceCueInfo> voice_cue_list;

      [Token(Token = "0x17001CC9")]
      public MySound.Voice Voice
      {
        [Token(Token = "0x600D8D3"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (MySound.Voice) null;
        }
      }

      [Token(Token = "0x17001CCA")]
      public List<UnitData.UnitVoiceCueInfo> VoiceCueList
      {
        [Token(Token = "0x600D8D4"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (List<UnitData.UnitVoiceCueInfo>) null;
        }
      }

      [Token(Token = "0x600D8D5")]
      [Address(RVA = "0xA588D0", Offset = "0xA576D0", VA = "0x10A588D0")]
      public void Init(
        UnitData _unit,
        MySound.Voice _voice,
        CriAtomEx.CueInfo[] _cueInfo,
        string _voice_name)
      {
      }

      [Token(Token = "0x600D8D6")]
      [Address(RVA = "0xA58620", Offset = "0xA57420", VA = "0x10A58620")]
      public void Cleanup()
      {
      }

      [Token(Token = "0x600D8D7")]
      [Address(RVA = "0xA591E0", Offset = "0xA57FE0", VA = "0x10A591E0")]
      private void SetConditions(string _tmp_name, ref UnitData.UnitVoiceCueInfo _info)
      {
      }

      [Token(Token = "0x600D8D8")]
      [Address(RVA = "0xA586D0", Offset = "0xA574D0", VA = "0x10A586D0")]
      private string GetUnlockConditionsText(string _dictionary_key) => (string) null;

      [Token(Token = "0x600D8D9")]
      [Address(RVA = "0xA58480", Offset = "0xA57280", VA = "0x10A58480")]
      private bool CheckConditions(UnitData _unit, string _tmp_name) => new bool();

      [Token(Token = "0x600D8DA")]
      [Address(RVA = "0xA58390", Offset = "0xA57190", VA = "0x10A58390")]
      private bool CheckConditionsUnitLevel(string _tmp_name, int _level) => new bool();

      [Token(Token = "0x600D8DB")]
      [Address(RVA = "0xA58260", Offset = "0xA57060", VA = "0x10A58260")]
      private bool CheckConditionsJobMaster1(string _tmp_name) => new bool();

      [Token(Token = "0x600D8DC")]
      [Address(RVA = "0xA58670", Offset = "0xA57470", VA = "0x10A58670")]
      private bool ContainsArray(string[] _array, string _target) => new bool();

      [Token(Token = "0x600D8DD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public UnitPlaybackVoiceData()
      {
      }
    }

    [Token(Token = "0x2002DD7")]
    public class CharacterQuestUnlockProgress
    {
      [Token(Token = "0x400E560")]
      [FieldOffset(Offset = "0x8")]
      public int Level;
      [Token(Token = "0x400E561")]
      [FieldOffset(Offset = "0xC")]
      public int Rarity;
      [Token(Token = "0x400E562")]
      [FieldOffset(Offset = "0x10")]
      public QuestParam CondQuest;
      [Token(Token = "0x400E563")]
      [FieldOffset(Offset = "0x14")]
      public bool ClearUnlocksCond;

      [Token(Token = "0x600D8E4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public CharacterQuestUnlockProgress()
      {
      }
    }

    [Token(Token = "0x2002DD8")]
    public class CharacterQuestParam
    {
      [Token(Token = "0x400E564")]
      [FieldOffset(Offset = "0x8")]
      public int EpisodeNum;
      [Token(Token = "0x400E565")]
      [FieldOffset(Offset = "0xC")]
      public string EpisodeTitle;
      [Token(Token = "0x400E566")]
      [FieldOffset(Offset = "0x10")]
      public bool IsNew;
      [Token(Token = "0x400E567")]
      [FieldOffset(Offset = "0x11")]
      public bool IsAvailable;
      [Token(Token = "0x400E568")]
      [FieldOffset(Offset = "0x14")]
      public QuestParam Param;

      [Token(Token = "0x600D8E5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public CharacterQuestParam()
      {
      }
    }

    [Token(Token = "0x2002DD9")]
    public class InvalidSkillList
    {
      [Token(Token = "0x400E569")]
      [FieldOffset(Offset = "0x8")]
      public UnitData.InvalidSkillList.Data[] SkillSet;

      [Token(Token = "0x600D8E6")]
      [Address(RVA = "0xA46FA0", Offset = "0xA45DA0", VA = "0x10A46FA0")]
      public InvalidSkillList()
      {
      }

      [Token(Token = "0x2002DDA")]
      public class Data
      {
        [Token(Token = "0x400E56A")]
        [FieldOffset(Offset = "0x8")]
        public List<UnitData.InvalidSkillList.Data.SkillSet> FixSkillList;
        [Token(Token = "0x400E56B")]
        [FieldOffset(Offset = "0xC")]
        public List<UnitData.InvalidSkillList.Data.SkillSet> BaseSkillList;
        [Token(Token = "0x400E56C")]
        [FieldOffset(Offset = "0x10")]
        public List<UnitData.InvalidSkillList.Data.SkillSet> OtherSkillList;

        [Token(Token = "0x600D8E7")]
        [Address(RVA = "0xA46CB0", Offset = "0xA45AB0", VA = "0x10A46CB0")]
        public static bool IsExistSkillList(
          List<UnitData.InvalidSkillList.Data.SkillSet> skill_set_list,
          SkillParam skill_param)
        {
          return new bool();
        }

        [Token(Token = "0x600D8E8")]
        [Address(RVA = "0xA46C70", Offset = "0xA45A70", VA = "0x10A46C70")]
        public bool IsExistFixSkillList(SkillParam skill_param) => new bool();

        [Token(Token = "0x600D8E9")]
        [Address(RVA = "0xA46C50", Offset = "0xA45A50", VA = "0x10A46C50")]
        public bool IsExistBaseSkillList(SkillParam skill_param) => new bool();

        [Token(Token = "0x600D8EA")]
        [Address(RVA = "0xA46C90", Offset = "0xA45A90", VA = "0x10A46C90")]
        public bool IsExistOtherSkillList(SkillParam skill_param) => new bool();

        [Token(Token = "0x600D8EB")]
        [Address(RVA = "0xA46C00", Offset = "0xA45A00", VA = "0x10A46C00")]
        public bool IsExistAllSkillList(SkillParam skill_param) => new bool();

        [Token(Token = "0x600D8EC")]
        [Address(RVA = "0xA46D70", Offset = "0xA45B70", VA = "0x10A46D70")]
        public Data()
        {
        }

        [Token(Token = "0x2002DDB")]
        public class SkillSet
        {
          [Token(Token = "0x400E56D")]
          [FieldOffset(Offset = "0x8")]
          private SkillParam mSkillParam;
          [Token(Token = "0x400E56E")]
          [FieldOffset(Offset = "0xC")]
          private bool mIsLock;

          [Token(Token = "0x17001CCB")]
          public SkillParam SkillParam
          {
            [Token(Token = "0x600D8ED"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
            {
              return (SkillParam) null;
            }
          }

          [Token(Token = "0x17001CCC")]
          public bool IsLock
          {
            [Token(Token = "0x600D8EE"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
            {
              return new bool();
            }
          }

          [Token(Token = "0x600D8EF")]
          [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
          public SkillSet()
          {
          }

          [Token(Token = "0x600D8F0")]
          [Address(RVA = "0x305760", Offset = "0x304560", VA = "0x10305760")]
          public SkillSet(SkillParam skill_param, bool is_lock = false)
          {
          }
        }
      }
    }
  }
}
