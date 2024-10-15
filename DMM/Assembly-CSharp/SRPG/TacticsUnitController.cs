// Decompiled with JetBrains decompiler
// Type: SRPG.TacticsUnitController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000DC4")]
  public class TacticsUnitController : UnitController
  {
    [Token(Token = "0x4002814")]
    [FieldOffset(Offset = "0x0")]
    public static List<TacticsUnitController> Instances;
    [Token(Token = "0x4002815")]
    private const string ID_IDLE = "IDLE";
    [Token(Token = "0x4002816")]
    private const string ID_RUN = "RUN";
    [Token(Token = "0x4002817")]
    private const string ID_STEP = "STEP";
    [Token(Token = "0x4002818")]
    private const string ID_PICKUP = "PICK";
    [Token(Token = "0x4002819")]
    private const string ID_BADSTATUS = "BAD";
    [Token(Token = "0x400281A")]
    private const string ID_CUSTOMRUN = "RUN_";
    [Token(Token = "0x400281B")]
    private const string ID_FALL_LOOP = "FLLP";
    [Token(Token = "0x400281C")]
    private const string ID_FALL_END = "FLEN";
    [Token(Token = "0x400281D")]
    private const string ID_CLIMBUP = "CLMB";
    [Token(Token = "0x400281E")]
    private const string ID_GENKIDAMA = "GENK";
    [Token(Token = "0x400281F")]
    [FieldOffset(Offset = "0x128")]
    public List<string> mCustomRunAnimations;
    [Token(Token = "0x4002820")]
    [FieldOffset(Offset = "0x12C")]
    private GameObject mRenkeiAuraEffect;
    [Token(Token = "0x4002821")]
    [FieldOffset(Offset = "0x130")]
    private GameObject mDrainEffect;
    [Token(Token = "0x4002822")]
    [FieldOffset(Offset = "0x134")]
    private GameObject mChargeGrnTargetUnitEffect;
    [Token(Token = "0x4002823")]
    [FieldOffset(Offset = "0x138")]
    private GameObject mChargeRedTargetUnitEffect;
    [Token(Token = "0x4002824")]
    [FieldOffset(Offset = "0x13C")]
    private GameObject mVersusCursor;
    [Token(Token = "0x4002825")]
    [FieldOffset(Offset = "0x140")]
    private Transform mVersusCursorRoot;
    [Token(Token = "0x4002826")]
    [FieldOffset(Offset = "0x144")]
    private bool mEnableStaticLight;
    [Token(Token = "0x4002827")]
    [FieldOffset(Offset = "0x148")]
    public TacticsUnitController.PostureTypes Posture;
    [Token(Token = "0x4002828")]
    [FieldOffset(Offset = "0x14C")]
    public Color ColorMod;
    [Token(Token = "0x4002829")]
    [FieldOffset(Offset = "0x15C")]
    private Texture2D mIconSmall;
    [Token(Token = "0x400282A")]
    [FieldOffset(Offset = "0x160")]
    private Texture2D mIconMedium;
    [Token(Token = "0x400282B")]
    [FieldOffset(Offset = "0x164")]
    private Texture2D mJobIcon;
    [Token(Token = "0x400282C")]
    [FieldOffset(Offset = "0x168")]
    private string mRunAnimation;
    [Token(Token = "0x400282D")]
    [FieldOffset(Offset = "0x170")]
    private long mCachedHP;
    [Token(Token = "0x400282E")]
    [FieldOffset(Offset = "0x178")]
    private UnitGauge mHPGauge;
    [Token(Token = "0x400282F")]
    [FieldOffset(Offset = "0x17C")]
    private UnitGaugeMark mAddIconGauge;
    [Token(Token = "0x4002830")]
    [FieldOffset(Offset = "0x180")]
    private float mKeepHPGaugeVisible;
    [Token(Token = "0x4002831")]
    [FieldOffset(Offset = "0x188")]
    private long mCachedHpMax;
    [Token(Token = "0x4002832")]
    [FieldOffset(Offset = "0x190")]
    private ChargeIcon mChargeIcon;
    [Token(Token = "0x4002833")]
    [FieldOffset(Offset = "0x194")]
    private DeathSentenceIcon mDeathSentenceIcon;
    [Token(Token = "0x4002834")]
    [FieldOffset(Offset = "0x198")]
    private GameObject mOwnerIndexUI;
    [Token(Token = "0x4002835")]
    [FieldOffset(Offset = "0x19C")]
    private UnitGaugeMark.EMarkType mKeepUnitGaugeMarkType;
    [Token(Token = "0x4002836")]
    [FieldOffset(Offset = "0x1A0")]
    private UnitGaugeMark.EGemIcon mKeepUnitGaugeMarkGemIconType;
    [Token(Token = "0x4002837")]
    [FieldOffset(Offset = "0x1A4")]
    private TacticsUnitController.HideGimmickAnimation mHideGimmickAnim;
    [Token(Token = "0x4002838")]
    [FieldOffset(Offset = "0x1A8")]
    public string UniqueName;
    [Token(Token = "0x4002839")]
    [FieldOffset(Offset = "0x1AC")]
    [NonSerialized]
    public int PlayerMemberIndex;
    [Token(Token = "0x400283A")]
    [FieldOffset(Offset = "0x1B0")]
    private Unit mUnit;
    [Token(Token = "0x400283B")]
    [FieldOffset(Offset = "0x1B4")]
    private Projector mShadow;
    [Token(Token = "0x400283C")]
    [FieldOffset(Offset = "0x1B8")]
    public UnitCursor UnitCursorTemplate;
    [Token(Token = "0x400283D")]
    [FieldOffset(Offset = "0x1BC")]
    private UnitCursor mUnitCursor;
    [Token(Token = "0x400283E")]
    [FieldOffset(Offset = "0x1C0")]
    public bool AutoUpdateRotation;
    [Token(Token = "0x400283F")]
    [FieldOffset(Offset = "0x1C4")]
    private StateMachine<TacticsUnitController> mStateMachine;
    [Token(Token = "0x4002840")]
    [FieldOffset(Offset = "0x1C8")]
    private bool mCancelAction;
    [Token(Token = "0x4002841")]
    [FieldOffset(Offset = "0x1CC")]
    private EUnitDirection mFieldActionDir;
    [Token(Token = "0x4002842")]
    [FieldOffset(Offset = "0x1D0")]
    private Vector2 mFieldActionPoint;
    [Token(Token = "0x4002843")]
    public const float ADJUST_MOVE_DIST = 0.3f;
    [Token(Token = "0x4002844")]
    [FieldOffset(Offset = "0x1D8")]
    private Color mBlendColor;
    [Token(Token = "0x4002845")]
    [FieldOffset(Offset = "0x1E8")]
    private TacticsUnitController.ColorBlendModes mBlendMode;
    [Token(Token = "0x4002846")]
    [FieldOffset(Offset = "0x1EC")]
    private float mBlendColorTime;
    [Token(Token = "0x4002847")]
    [FieldOffset(Offset = "0x1F0")]
    private float mBlendColorTimeMax;
    [Token(Token = "0x4002848")]
    [FieldOffset(Offset = "0x1F4")]
    private bool mEnableColorBlending;
    [Token(Token = "0x4002849")]
    [FieldOffset(Offset = "0x1F8")]
    private PetController mPet;
    [Token(Token = "0x400284A")]
    [FieldOffset(Offset = "0x4")]
    public static readonly string ANIM_IDLE_FIELD;
    [Token(Token = "0x400284B")]
    [FieldOffset(Offset = "0x8")]
    public static readonly string ANIM_IDLE_DEMO;
    [Token(Token = "0x400284C")]
    [FieldOffset(Offset = "0xC")]
    public static readonly string ANIM_RUN_FIELD;
    [Token(Token = "0x400284D")]
    [FieldOffset(Offset = "0x10")]
    public static readonly string ANIM_STEP;
    [Token(Token = "0x400284E")]
    [FieldOffset(Offset = "0x14")]
    public static readonly string ANIM_FALL_LOOP;
    [Token(Token = "0x400284F")]
    [FieldOffset(Offset = "0x18")]
    public static readonly string ANIM_CLIMBUP;
    [Token(Token = "0x4002850")]
    [FieldOffset(Offset = "0x1C")]
    public static readonly string ANIM_PICKUP;
    [Token(Token = "0x4002851")]
    [FieldOffset(Offset = "0x20")]
    public static readonly string ANIM_GENKIDAMA;
    [Token(Token = "0x4002852")]
    [FieldOffset(Offset = "0x24")]
    public static readonly string ANIM_DOWN_STAND;
    [Token(Token = "0x4002853")]
    [FieldOffset(Offset = "0x28")]
    public static readonly string ANIM_DODGE;
    [Token(Token = "0x4002854")]
    [FieldOffset(Offset = "0x2C")]
    public static readonly string ANIM_DAMAGE;
    [Token(Token = "0x4002855")]
    [FieldOffset(Offset = "0x30")]
    public static readonly string ANIM_DOWN;
    [Token(Token = "0x4002856")]
    [FieldOffset(Offset = "0x34")]
    public static readonly string ANIM_ITEM_USE;
    [Token(Token = "0x4002857")]
    [FieldOffset(Offset = "0x38")]
    public static readonly string ANIM_GROGGY;
    [Token(Token = "0x4002858")]
    [FieldOffset(Offset = "0x1FC")]
    private Dictionary<string, GameObject> mDefendSkillEffects;
    [Token(Token = "0x4002859")]
    [FieldOffset(Offset = "0x200")]
    private GameObject mPickupObject;
    [Token(Token = "0x400285A")]
    [FieldOffset(Offset = "0x204")]
    private IntVector2 mCachedXY;
    [Token(Token = "0x400285B")]
    [FieldOffset(Offset = "0x20C")]
    private float mFlyingPosToY;
    [Token(Token = "0x400285C")]
    [FieldOffset(Offset = "0x210")]
    private float mFlyingPosNowY;
    [Token(Token = "0x400285D")]
    [FieldOffset(Offset = "0x214")]
    private bool mIsFlyingUp;
    [Token(Token = "0x400285E")]
    [FieldOffset(Offset = "0x218")]
    private Vector3[] mRoute;
    [Token(Token = "0x400285F")]
    [FieldOffset(Offset = "0x21C")]
    private int mRoutePos;
    [Token(Token = "0x4002860")]
    [FieldOffset(Offset = "0x220")]
    private float mRunSpeed;
    [Token(Token = "0x4002861")]
    [FieldOffset(Offset = "0x224")]
    private Vector3 mVelocity;
    [Token(Token = "0x4002862")]
    [FieldOffset(Offset = "0x230")]
    private GridMap<int> mWalkableField;
    [Token(Token = "0x4002863")]
    [FieldOffset(Offset = "0x234")]
    private bool mCollideGround;
    [Token(Token = "0x4002864")]
    [FieldOffset(Offset = "0x235")]
    public bool IgnoreMove;
    [Token(Token = "0x4002865")]
    [FieldOffset(Offset = "0x238")]
    private float mPostMoveAngle;
    [Token(Token = "0x4002866")]
    [FieldOffset(Offset = "0x23C")]
    private float mIdleInterpTime;
    [Token(Token = "0x4002867")]
    [FieldOffset(Offset = "0x240")]
    private bool mLoadedPartially;
    [Token(Token = "0x4002868")]
    [FieldOffset(Offset = "0x244")]
    private Vector3 mLookAtTarget;
    [Token(Token = "0x4002869")]
    [FieldOffset(Offset = "0x250")]
    private float mSpinCount;
    [Token(Token = "0x400286A")]
    [FieldOffset(Offset = "0x254")]
    private TacticsUnitController.FieldActionEndEvent mOnFieldActionEnd;
    [Token(Token = "0x400286B")]
    [FieldOffset(Offset = "0x258")]
    private Vector3 mStepStart;
    [Token(Token = "0x400286C")]
    [FieldOffset(Offset = "0x264")]
    private Vector3 mStepEnd;
    [Token(Token = "0x400286D")]
    [FieldOffset(Offset = "0x270")]
    private float mMoveAnimInterpTime;
    [Token(Token = "0x400286E")]
    [FieldOffset(Offset = "0x274")]
    private BadStatusEffects.Desc mBadStatus;
    [Token(Token = "0x400286F")]
    [FieldOffset(Offset = "0x278")]
    private GameObject mBadStatusEffect;
    [Token(Token = "0x4002870")]
    [FieldOffset(Offset = "0x27C")]
    private string mLoadedBadStatusAnimation;
    [Token(Token = "0x4002871")]
    [FieldOffset(Offset = "0x280")]
    private GameObject mCurseEffect;
    [Token(Token = "0x4002872")]
    [FieldOffset(Offset = "0x284")]
    private string mLoadedCurseAnimation;
    [Token(Token = "0x4002873")]
    [FieldOffset(Offset = "0x288")]
    private bool IsCursed;
    [Token(Token = "0x4002874")]
    [FieldOffset(Offset = "0x290")]
    private long mBadStatusLocks;
    [Token(Token = "0x4002875")]
    [FieldOffset(Offset = "0x298")]
    private bool mIsProhibitedUpdateBadStatus;
    [Token(Token = "0x4002876")]
    [FieldOffset(Offset = "0x299")]
    private bool mIsDispOffBadStatus;
    [Token(Token = "0x4002877")]
    private const string ID_BATTLE_RUN = "B_RUN";
    [Token(Token = "0x4002878")]
    private const string ID_BATTLE_SKILL = "B_SKL";
    [Token(Token = "0x4002879")]
    private const string ID_BATTLE_BACKSTEP = "B_BS";
    [Token(Token = "0x400287A")]
    private const string ID_BATTLE_DAMAGE_NORMAL = "B_DMG0";
    [Token(Token = "0x400287B")]
    private const string ID_BATTLE_DODGE = "B_DGE";
    [Token(Token = "0x400287C")]
    private const string ID_BATTLE_DOWN = "B_DOWN";
    [Token(Token = "0x400287D")]
    private const string ID_BATTLE_CHANT = "B_CHA";
    [Token(Token = "0x400287E")]
    private const string ID_BATTLE_RUNLOOP = "B_RUNL";
    [Token(Token = "0x400287F")]
    private const string ID_BATTLE_DEAD = "B_DEAD";
    [Token(Token = "0x4002880")]
    private const string ID_BATTLE_PRESKILL = "B_PRS";
    [Token(Token = "0x4002881")]
    private const string ID_BATTLE_TOSS_LIFT = "B_TOSS_LIFT";
    [Token(Token = "0x4002882")]
    private const string ID_BATTLE_TOSS_THROW = "B_TOSS_THROW";
    [Token(Token = "0x4002883")]
    private const string ID_BATTLE_TRANSFORM = "B_TRANSFORM";
    [Token(Token = "0x4002884")]
    private const string ID_BATTLE_PRE_TRANSFORM = "B_PRE_TRANSFORM";
    [Token(Token = "0x4002885")]
    private const string ID_BATTLE_BIGUNIT_BS_IDLE = "B_BU_BS_IDLE";
    [Token(Token = "0x4002886")]
    private const string ID_BATTLE_BIGUNIT_BS_DAMAGE = "B_BU_BS_DAMAGE";
    [Token(Token = "0x4002887")]
    public const string ANIM_BATTLE_TOSS_LIFT = "cmn_toss_lift0";
    [Token(Token = "0x4002888")]
    public const string ANIM_BATTLE_TOSS_THROW = "cmn_toss_throw0";
    [Token(Token = "0x4002889")]
    public const string ANIM_BATTLE_BIGUNIT_BS_IDLE = "idleBattleScene0";
    [Token(Token = "0x400288A")]
    public const string ANIM_BATTLE_BIGUNIT_BS_DAMAGE = "damageBattleScene0";
    [Token(Token = "0x400288B")]
    [FieldOffset(Offset = "0x29C")]
    public int DrainGemsOnHit;
    [Token(Token = "0x400288C")]
    [FieldOffset(Offset = "0x2A0")]
    public GemParticle[] GemDrainEffects;
    [Token(Token = "0x400288D")]
    [FieldOffset(Offset = "0x2A4")]
    public GameObject GemDrainHitEffect;
    [Token(Token = "0x400288E")]
    [FieldOffset(Offset = "0x2A8")]
    public bool ShowCriticalEffectOnHit;
    [Token(Token = "0x400288F")]
    [FieldOffset(Offset = "0x2A9")]
    public bool ShowBackstabEffectOnHit;
    [Token(Token = "0x4002890")]
    [FieldOffset(Offset = "0x2AC")]
    public TacticsUnitController.EElementEffectTypes ShowElementEffectOnHit;
    [Token(Token = "0x4002891")]
    [FieldOffset(Offset = "0x2B0")]
    private int mDamageDispCounter;
    [Token(Token = "0x4002892")]
    [FieldOffset(Offset = "0x2B4")]
    private int mHealDispCounter;
    [Token(Token = "0x4002893")]
    [FieldOffset(Offset = "0x2B8")]
    private bool mIsReqVisibleEquipmentsPlaySkill;
    [Token(Token = "0x4002894")]
    [FieldOffset(Offset = "0x2BC")]
    public int AttackedCounter;
    [Token(Token = "0x4002895")]
    [FieldOffset(Offset = "0x2C0")]
    public List<TacticsUnitController.ShieldState> ShieldStates;
    [Token(Token = "0x4002896")]
    [FieldOffset(Offset = "0x2C4")]
    private TacticsUnitController.ShakeUnit mShaker;
    [Token(Token = "0x4002897")]
    [FieldOffset(Offset = "0x2C8")]
    private float mMapTrajectoryHeight;
    [Token(Token = "0x4002898")]
    [FieldOffset(Offset = "0x2CC")]
    private TacticsUnitController.SkillVars mSkillVars;
    [Token(Token = "0x4002899")]
    [FieldOffset(Offset = "0x2D0")]
    public bool ShouldDodgeHits;
    [Token(Token = "0x400289A")]
    [FieldOffset(Offset = "0x2D1")]
    public bool ShouldPerfectDodge;
    [Token(Token = "0x400289B")]
    [FieldOffset(Offset = "0x2D2")]
    public bool ShouldDefendHits;
    [Token(Token = "0x400289C")]
    [FieldOffset(Offset = "0x3C")]
    private static string CameraAnimationDir;
    [Token(Token = "0x400289D")]
    public const string COLLABO_SKILL_NAME_SUB = "_sub";
    [Token(Token = "0x400289E")]
    [FieldOffset(Offset = "0x2D4")]
    private GameObject mLastHitEffect;
    [Token(Token = "0x400289F")]
    [FieldOffset(Offset = "0x2D8")]
    private LogSkill.Target mHitInfo;
    [Token(Token = "0x40028A0")]
    [FieldOffset(Offset = "0x2DC")]
    private LogSkill.Target mHitInfoSelf;
    [Token(Token = "0x40028A1")]
    private const float CameraInterpRate = 4f;
    [Token(Token = "0x40028A2")]
    [FieldOffset(Offset = "0x2E0")]
    private float mCastJumpOffsetY;
    [Token(Token = "0x40028A3")]
    [FieldOffset(Offset = "0x2E4")]
    private bool mCastJumpStartComplete;
    [Token(Token = "0x40028A4")]
    [FieldOffset(Offset = "0x2E5")]
    private bool mCastJumpFallComplete;
    [Token(Token = "0x40028A5")]
    [FieldOffset(Offset = "0x2E8")]
    public Vector3 JumpFallPos;
    [Token(Token = "0x40028A6")]
    [FieldOffset(Offset = "0x2F4")]
    public IntVector2 JumpMapFallPos;
    [Token(Token = "0x40028A7")]
    [FieldOffset(Offset = "0x2FC")]
    private bool mFinishedCastJumpFall;
    [Token(Token = "0x40028A8")]
    [FieldOffset(Offset = "0x2FD")]
    private bool mIsPlayDamageMotion;
    [Token(Token = "0x40028A9")]
    [FieldOffset(Offset = "0x2FE")]
    private bool mIsPlayIdleLoopMotion;
    [Token(Token = "0x40028AA")]
    [FieldOffset(Offset = "0x300")]
    private TacticsUnitController.eKnockBackMode mKnockBackMode;
    [Token(Token = "0x40028AB")]
    [FieldOffset(Offset = "0x304")]
    private Grid mKnockBackGrid;
    [Token(Token = "0x40028AC")]
    private const float KNOCK_BACK_SEC = 0.4f;
    [Token(Token = "0x40028AD")]
    [FieldOffset(Offset = "0x308")]
    private Vector3 mKbPosStart;
    [Token(Token = "0x40028AE")]
    [FieldOffset(Offset = "0x314")]
    private Vector3 mKbPosEnd;
    [Token(Token = "0x40028AF")]
    [FieldOffset(Offset = "0x320")]
    private float mKbPassedSec;
    [Token(Token = "0x40028B0")]
    public const string TRANSFORM_SKILL_NAME_SUB = "_chg";

    [Token(Token = "0x60037A6")]
    [Address(RVA = "0x1090950", Offset = "0x108F750", VA = "0x11090950")]
    public void EnableStaticLight(bool enable)
    {
    }

    [Token(Token = "0x60037A7")]
    [Address(RVA = "0x1099010", Offset = "0x1097E10", VA = "0x11099010")]
    public void ResetColorMod()
    {
    }

    [Token(Token = "0x60037A8")]
    [Address(RVA = "0x108D910", Offset = "0x108C710", VA = "0x1108D910")]
    public void CacheIcons()
    {
    }

    [Token(Token = "0x60037A9")]
    [Address(RVA = "0x108D8B0", Offset = "0x108C6B0", VA = "0x1108D8B0")]
    private IEnumerator CacheIconsAsync() => (IEnumerator) null;

    [Token(Token = "0x60037AA")]
    [Address(RVA = "0x1090AC0", Offset = "0x108F8C0", VA = "0x11090AC0")]
    public static TacticsUnitController FindByUnitID(string unitID) => (TacticsUnitController) null;

    [Token(Token = "0x60037AB")]
    [Address(RVA = "0x10909B0", Offset = "0x108F7B0", VA = "0x110909B0")]
    public static TacticsUnitController FindByUniqueName(string uniqueName)
    {
      return (TacticsUnitController) null;
    }

    [Token(Token = "0x60037AC")]
    [Address(RVA = "0x1093F40", Offset = "0x1092D40", VA = "0x11093F40")]
    public void LoadRunAnimation(string animationName)
    {
    }

    [Token(Token = "0x60037AD")]
    [Address(RVA = "0x1093EE0", Offset = "0x1092CE0", VA = "0x11093EE0")]
    public void LoadRunAnimation(string animationName, string path)
    {
    }

    [Token(Token = "0x60037AE")]
    [Address(RVA = "0x109E120", Offset = "0x109CF20", VA = "0x1109E120")]
    public void UnloadRunAnimation(string animationName)
    {
    }

    [Token(Token = "0x60037AF")]
    [Address(RVA = "0x109AB30", Offset = "0x1099930", VA = "0x1109AB30")]
    public void SetRunAnimation(string animationName)
    {
    }

    [Token(Token = "0x170003D3")]
    public int HPPercentage
    {
      [Token(Token = "0x60037B0"), Address(RVA = "0x10A0D20", Offset = "0x109FB20", VA = "0x110A0D20")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170003D4")]
    public long VisibleHPValue
    {
      [Token(Token = "0x60037B1"), Address(RVA = "0x10A1410", Offset = "0x10A0210", VA = "0x110A1410")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x170003D5")]
    public ChargeIcon ChargeIcon
    {
      [Token(Token = "0x60037B2"), Address(RVA = "0x66A5A0", Offset = "0x6693A0", VA = "0x1066A5A0")] get
      {
        return (ChargeIcon) null;
      }
      [Token(Token = "0x60037B3"), Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")] set
      {
      }
    }

    [Token(Token = "0x170003D6")]
    public DeathSentenceIcon DeathSentenceIcon
    {
      [Token(Token = "0x60037B4"), Address(RVA = "0x9A04B0", Offset = "0x99F2B0", VA = "0x109A04B0")] get
      {
        return (DeathSentenceIcon) null;
      }
      [Token(Token = "0x60037B5"), Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")] set
      {
      }
    }

    [Token(Token = "0x60037B6")]
    [Address(RVA = "0x1092340", Offset = "0x1091140", VA = "0x11092340")]
    public void InitHPGauge(Canvas canvas, UnitGauge gaugeTemplate)
    {
    }

    [Token(Token = "0x60037B7")]
    [Address(RVA = "0x109A520", Offset = "0x1099320", VA = "0x1109A520")]
    public void SetHPGaugeMode(
      TacticsUnitController.HPGaugeModes mode,
      SkillData skill = null,
      Unit attacker = null)
    {
    }

    [Token(Token = "0x60037B8")]
    [Address(RVA = "0x1097650", Offset = "0x1096450", VA = "0x11097650")]
    public void OnUnitGaugeModeChange(TacticsUnitController.HPGaugeModes Mode)
    {
    }

    [Token(Token = "0x60037B9")]
    [Address(RVA = "0x1099E30", Offset = "0x1098C30", VA = "0x11099E30")]
    public void SetHPChangeYosou(long newHP, int hpmax_damage = 0)
    {
    }

    [Token(Token = "0x170003D7")]
    public bool IsHPGaugeChanging
    {
      [Token(Token = "0x60037BA"), Address(RVA = "0x10A0FD0", Offset = "0x109FDD0", VA = "0x110A0FD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170003D8")]
    public RectTransform HPGaugeTransform
    {
      [Token(Token = "0x60037BB"), Address(RVA = "0x10A0C90", Offset = "0x109FA90", VA = "0x110A0C90")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x60037BC")]
    [Address(RVA = "0x109B440", Offset = "0x109A240", VA = "0x1109B440")]
    public void ShowHPGauge(bool visible)
    {
    }

    [Token(Token = "0x60037BD")]
    [Address(RVA = "0x1099060", Offset = "0x1097E60", VA = "0x11099060")]
    public void ResetHPGauge()
    {
    }

    [Token(Token = "0x60037BE")]
    [Address(RVA = "0x109F390", Offset = "0x109E190", VA = "0x1109F390")]
    public void UpdateHPRelative(int delta, float duration = 0.5f, bool is_hpmax_damage = false)
    {
    }

    [Token(Token = "0x60037BF")]
    [Address(RVA = "0x109F210", Offset = "0x109E010", VA = "0x1109F210")]
    private void UpdateGauges()
    {
    }

    [Token(Token = "0x60037C0")]
    [Address(RVA = "0x1096A70", Offset = "0x1095870", VA = "0x11096A70")]
    private void OnHitGaugeWeakRegist(Unit attacker)
    {
    }

    [Token(Token = "0x60037C1")]
    [Address(RVA = "0x109B600", Offset = "0x109A400", VA = "0x1109B600")]
    public void ShowOwnerIndexUI(bool show)
    {
    }

    [Token(Token = "0x60037C2")]
    [Address(RVA = "0x108EC70", Offset = "0x108DA70", VA = "0x1108EC70")]
    public bool CreateOwnerIndexUI(
      Canvas canvas,
      GameObject templeteUI,
      PhotonPlayerParameter param)
    {
      return new bool();
    }

    [Token(Token = "0x60037C3")]
    [Address(RVA = "0x109B690", Offset = "0x109A490", VA = "0x1109B690")]
    public void ShowVersusCursor(bool show)
    {
    }

    [Token(Token = "0x60037C4")]
    [Address(RVA = "0x10981D0", Offset = "0x1096FD0", VA = "0x110981D0")]
    public void PlayVersusCursor(bool play)
    {
    }

    [Token(Token = "0x60037C5")]
    [Address(RVA = "0x108EE60", Offset = "0x108DC60", VA = "0x1108EE60")]
    public bool CreateVersusCursor(GameObject templeteUI) => new bool();

    [Token(Token = "0x60037C6")]
    [Address(RVA = "0x1099CA0", Offset = "0x1098AA0", VA = "0x11099CA0")]
    public void SetGimmickIcon(Unit TargetUnit)
    {
    }

    [Token(Token = "0x60037C7")]
    [Address(RVA = "0x1091490", Offset = "0x1090290", VA = "0x11091490")]
    public void HideGimmickIcon(EUnitType Type)
    {
    }

    [Token(Token = "0x60037C8")]
    [Address(RVA = "0x108F220", Offset = "0x108E020", VA = "0x1108F220")]
    public void DeleteGimmickIconAll()
    {
    }

    [Token(Token = "0x170003D9")]
    private TacticsUnitController.HideGimmickAnimation HideGimmickAnim
    {
      [Token(Token = "0x60037C9"), Address(RVA = "0x10A0EA0", Offset = "0x109FCA0", VA = "0x110A0EA0")] get
      {
        return (TacticsUnitController.HideGimmickAnimation) null;
      }
      [Token(Token = "0x60037CA"), Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")] set
      {
      }
    }

    [Token(Token = "0x60037CB")]
    [Address(RVA = "0x10998B0", Offset = "0x10986B0", VA = "0x110998B0")]
    public void ScaleHide()
    {
    }

    [Token(Token = "0x60037CC")]
    [Address(RVA = "0x10998F0", Offset = "0x10986F0", VA = "0x110998F0")]
    public void ScaleShow()
    {
    }

    [Token(Token = "0x60037CD")]
    [Address(RVA = "0x1099300", Offset = "0x1098100", VA = "0x11099300")]
    public void ResetScale()
    {
    }

    [Token(Token = "0x60037CE")]
    [Address(RVA = "0x1093200", Offset = "0x1092000", VA = "0x11093200")]
    public bool IsA(string id) => new bool();

    [Token(Token = "0x170003DA")]
    public Unit Unit
    {
      [Token(Token = "0x60037CF"), Address(RVA = "0xA21B70", Offset = "0xA20970", VA = "0x10A21B70")] get
      {
        return (Unit) null;
      }
    }

    [Token(Token = "0x170003DB")]
    public Vector2 FieldActionPoint
    {
      [Token(Token = "0x60037D0"), Address(RVA = "0x10A0C60", Offset = "0x109FA60", VA = "0x110A0C60")] get
      {
        return new Vector2();
      }
    }

    [Token(Token = "0x60037D1")]
    [Address(RVA = "0x109D720", Offset = "0x109C520", VA = "0x1109D720")]
    public bool TriggerFieldAction(Vector3 velocity, bool resetToMove = false) => new bool();

    [Token(Token = "0x60037D2")]
    [Address(RVA = "0x108C950", Offset = "0x108B750", VA = "0x1108C950")]
    public bool AdjustMovePos(EUnitDirection edir, ref Vector3 pos) => new bool();

    [Token(Token = "0x170003DC")]
    public bool IsPlayingFieldAction
    {
      [Token(Token = "0x60037D3"), Address(RVA = "0x10A1200", Offset = "0x10A0000", VA = "0x110A1200")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60037D4")]
    [Address(RVA = "0x108D3C0", Offset = "0x108C1C0", VA = "0x1108D3C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x60037D5")]
    [Address(RVA = "0x109A800", Offset = "0x1099600", VA = "0x1109A800")]
    private void SetMonochrome(bool enable)
    {
    }

    [Token(Token = "0x60037D6")]
    [Address(RVA = "0x108FDD0", Offset = "0x108EBD0", VA = "0x1108FDD0")]
    private void DisableColorBlending()
    {
    }

    [Token(Token = "0x60037D7")]
    [Address(RVA = "0x108D000", Offset = "0x108BE00", VA = "0x1108D000")]
    private void ApplyColorBlending(Color color)
    {
    }

    [Token(Token = "0x60037D8")]
    [Address(RVA = "0x1090970", Offset = "0x108F770", VA = "0x11090970")]
    public void FadeBlendColor(Color color, float time)
    {
    }

    [Token(Token = "0x60037D9")]
    [Address(RVA = "0x109EA70", Offset = "0x109D870", VA = "0x1109EA70")]
    private void UpdateColorBlending()
    {
    }

    [Token(Token = "0x170003DD")]
    public bool HasCursor
    {
      [Token(Token = "0x60037DA"), Address(RVA = "0x10A0DF0", Offset = "0x109FBF0", VA = "0x110A0DF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60037DB")]
    private void GotoState<T>() where T : TacticsUnitController.State, new()
    {
    }

    [Token(Token = "0x60037DC")]
    [Address(RVA = "0x1094730", Offset = "0x1093530", VA = "0x11094730", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x60037DD")]
    [Address(RVA = "0x109B190", Offset = "0x1099F90", VA = "0x1109B190")]
    public void ShowCursor(UnitCursor prefab, Color color)
    {
    }

    [Token(Token = "0x60037DE")]
    [Address(RVA = "0x108E380", Offset = "0x108D180", VA = "0x1108E380")]
    public void CancelAction()
    {
    }

    [Token(Token = "0x60037DF")]
    [Address(RVA = "0x1091260", Offset = "0x1090060", VA = "0x11091260")]
    public void HideCursor(bool immediate = false)
    {
    }

    [Token(Token = "0x60037E0")]
    [Address(RVA = "0x109AEC0", Offset = "0x1099CC0", VA = "0x1109AEC0")]
    public void SetupUnit(Unit unit)
    {
    }

    [Token(Token = "0x60037E1")]
    [Address(RVA = "0x109ACD0", Offset = "0x1099AD0", VA = "0x1109ACD0")]
    private void SetupPet()
    {
    }

    [Token(Token = "0x60037E2")]
    [Address(RVA = "0x109D2A0", Offset = "0x109C0A0", VA = "0x1109D2A0")]
    protected new void Start()
    {
    }

    [Token(Token = "0x60037E3")]
    [Address(RVA = "0x1093CF0", Offset = "0x1092AF0", VA = "0x11093CF0")]
    public void LoadDefendSkillEffect(string skillEffectName)
    {
    }

    [Token(Token = "0x60037E4")]
    [Address(RVA = "0x1093C80", Offset = "0x1092A80", VA = "0x11093C80")]
    private IEnumerator LoadDefendSkillEffectAsync(string skillEffectName) => (IEnumerator) null;

    [Token(Token = "0x60037E5")]
    [Address(RVA = "0x10982C0", Offset = "0x10970C0", VA = "0x110982C0", Slot = "21")]
    protected override void PostSetup()
    {
    }

    [Token(Token = "0x60037E6")]
    [Address(RVA = "0x109A960", Offset = "0x1099760", VA = "0x1109A960")]
    public void SetRenkeiAura(GameObject eff)
    {
    }

    [Token(Token = "0x60037E7")]
    [Address(RVA = "0x109D680", Offset = "0x109C480", VA = "0x1109D680")]
    public void StopRenkeiAura()
    {
    }

    [Token(Token = "0x60037E8")]
    [Address(RVA = "0x1090770", Offset = "0x108F570", VA = "0x11090770")]
    public void EnableChargeTargetUnit(GameObject eff, bool is_grn)
    {
    }

    [Token(Token = "0x60037E9")]
    [Address(RVA = "0x108FCB0", Offset = "0x108EAB0", VA = "0x1108FCB0")]
    public void DisableChargeTargetUnit()
    {
    }

    [Token(Token = "0x60037EA")]
    [Address(RVA = "0x1099AA0", Offset = "0x10988A0", VA = "0x11099AA0")]
    public void SetDrainEffect(GameObject eff)
    {
    }

    [Token(Token = "0x60037EB")]
    [Address(RVA = "0x108D4A0", Offset = "0x108C2A0", VA = "0x1108D4A0")]
    public void BeginLoadPickupAnimation()
    {
    }

    [Token(Token = "0x60037EC")]
    [Address(RVA = "0x109E0E0", Offset = "0x109CEE0", VA = "0x1109E0E0")]
    public void UnloadPickupAnimation()
    {
    }

    [Token(Token = "0x60037ED")]
    [Address(RVA = "0x1093E50", Offset = "0x1092C50", VA = "0x11093E50")]
    public void LoadGenkidamaAnimation(bool load)
    {
    }

    [Token(Token = "0x60037EE")]
    [Address(RVA = "0x1097DC0", Offset = "0x1096BC0", VA = "0x11097DC0")]
    public void PlayGenkidama()
    {
    }

    [Token(Token = "0x60037EF")]
    [Address(RVA = "0x1097FE0", Offset = "0x1096DE0", VA = "0x11097FE0")]
    public void PlayPickup(GameObject pickupObject)
    {
    }

    [Token(Token = "0x60037F0")]
    [Address(RVA = "0x109FBE0", Offset = "0x109E9E0", VA = "0x1109FBE0", Slot = "15")]
    protected override void Update()
    {
    }

    [Token(Token = "0x60037F1")]
    [Address(RVA = "0x108E2C0", Offset = "0x108D0C0", VA = "0x1108E2C0")]
    public static EUnitDirection CalcUnitDirection(float x, float y) => new EUnitDirection();

    [Token(Token = "0x60037F2")]
    [Address(RVA = "0x108E180", Offset = "0x108CF80", VA = "0x1108E180")]
    public EUnitDirection CalcUnitDirectionFromRotation() => new EUnitDirection();

    [Token(Token = "0x60037F3")]
    [Address(RVA = "0x108E420", Offset = "0x108D220", VA = "0x1108E420")]
    private bool CheckCollision(int x0, int y0, int x1, int y1) => new bool();

    [Token(Token = "0x60037F4")]
    [Address(RVA = "0x108CF80", Offset = "0x108BD80", VA = "0x1108CF80")]
    private void AnimationUpdated(GameObject go)
    {
    }

    [Token(Token = "0x170003DE")]
    public bool CollideGround
    {
      [Token(Token = "0x60037F5"), Address(RVA = "0x10A0C50", Offset = "0x109FA50", VA = "0x110A0C50")] get
      {
        return new bool();
      }
      [Token(Token = "0x60037F6"), Address(RVA = "0x10A1550", Offset = "0x10A0350", VA = "0x110A1550")] set
      {
      }
    }

    [Token(Token = "0x60037F7")]
    [Address(RVA = "0x1099030", Offset = "0x1097E30", VA = "0x11099030")]
    private void ResetFlyingUp()
    {
    }

    [Token(Token = "0x60037F8")]
    [Address(RVA = "0x108E550", Offset = "0x108D350", VA = "0x1108E550")]
    private Unit CheckFlyingUp(SceneBattle sb, IntVector2 co) => (Unit) null;

    [Token(Token = "0x60037F9")]
    [Address(RVA = "0x109C0E0", Offset = "0x109AEE0", VA = "0x1109C0E0")]
    private void SnapToGround()
    {
    }

    [Token(Token = "0x60037FA")]
    [Address(RVA = "0x1093890", Offset = "0x1092690", VA = "0x11093890", Slot = "16")]
    protected override void LateUpdate()
    {
    }

    [Token(Token = "0x170003DF")]
    public GridMap<int> WalkableField
    {
      [Token(Token = "0x60037FB"), Address(RVA = "0x10A15C0", Offset = "0x10A03C0", VA = "0x110A15C0")] set
      {
      }
    }

    [Token(Token = "0x60037FC")]
    [Address(RVA = "0x109CEE0", Offset = "0x109BCE0", VA = "0x1109CEE0")]
    public float StartMove(Vector3[] route, float directionAngle = -1f) => new float();

    [Token(Token = "0x60037FD")]
    [Address(RVA = "0x109AC00", Offset = "0x1099A00", VA = "0x1109AC00")]
    public void SetRunningSpeed(float speed)
    {
    }

    [Token(Token = "0x60037FE")]
    [Address(RVA = "0x109D0F0", Offset = "0x109BEF0", VA = "0x1109D0F0")]
    public void StartRunning()
    {
    }

    [Token(Token = "0x60037FF")]
    [Address(RVA = "0x1097E50", Offset = "0x1096C50", VA = "0x11097E50")]
    public void PlayIdle(float interpTime = 0.0f)
    {
    }

    [Token(Token = "0x6003800")]
    [Address(RVA = "0x109D6A0", Offset = "0x109C4A0", VA = "0x1109D6A0")]
    public void StopRunning()
    {
    }

    [Token(Token = "0x6003801")]
    [Address(RVA = "0x1098160", Offset = "0x1096F60", VA = "0x11098160")]
    public void PlayTakenAnimation()
    {
    }

    [Token(Token = "0x170003E0")]
    public bool isIdle
    {
      [Token(Token = "0x6003802"), Address(RVA = "0x10A1430", Offset = "0x10A0230", VA = "0x110A1430")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170003E1")]
    public bool isMoving
    {
      [Token(Token = "0x6003803"), Address(RVA = "0x10A14D0", Offset = "0x10A02D0", VA = "0x110A14D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170003E2")]
    public bool IsInitLoading
    {
      [Token(Token = "0x6003804"), Address(RVA = "0x10A1180", Offset = "0x109FF80", VA = "0x110A1180")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003805")]
    [Address(RVA = "0x1097700", Offset = "0x1096500", VA = "0x11097700", Slot = "20")]
    protected override void OnVisibilityChange(bool visible)
    {
    }

    [Token(Token = "0x170003E3")]
    public bool IsLoadedPartially
    {
      [Token(Token = "0x6003806"), Address(RVA = "0x10A11F0", Offset = "0x109FFF0", VA = "0x110A11F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003807")]
    [Address(RVA = "0x1099270", Offset = "0x1098070", VA = "0x11099270")]
    public void ResetRotation()
    {
    }

    [Token(Token = "0x6003808")]
    [Address(RVA = "0x109F700", Offset = "0x109E500", VA = "0x1109F700")]
    private void UpdateRotation()
    {
    }

    [Token(Token = "0x6003809")]
    [Address(RVA = "0x10945A0", Offset = "0x10933A0", VA = "0x110945A0")]
    public void LookAt(Vector3 position)
    {
    }

    [Token(Token = "0x600380A")]
    [Address(RVA = "0x1094690", Offset = "0x1093490", VA = "0x11094690")]
    public void LookAt(Component target)
    {
    }

    [Token(Token = "0x600380B")]
    [Address(RVA = "0x1097F40", Offset = "0x1096D40", VA = "0x11097F40")]
    public void PlayLookAt(Component target, float spin = 2f)
    {
    }

    [Token(Token = "0x600380C")]
    [Address(RVA = "0x1097EE0", Offset = "0x1096CE0", VA = "0x11097EE0")]
    public void PlayLookAt(Vector3 target, float spin = 2f)
    {
    }

    [Token(Token = "0x600380D")]
    [Address(RVA = "0x1097E10", Offset = "0x1096C10", VA = "0x11097E10")]
    private void PlayIdleSmooth()
    {
    }

    [Token(Token = "0x600380E")]
    [Address(RVA = "0x10946F0", Offset = "0x10934F0", VA = "0x110946F0")]
    private void MoveAgain()
    {
    }

    [Token(Token = "0x600380F")]
    [Address(RVA = "0x109D3C0", Offset = "0x109C1C0", VA = "0x1109D3C0")]
    public void StepTo(Vector3 dest)
    {
    }

    [Token(Token = "0x6003810")]
    [Address(RVA = "0x1094450", Offset = "0x1093250", VA = "0x11094450")]
    public void LockUpdateBadStatus(EUnitCondition condition, bool is_force = false)
    {
    }

    [Token(Token = "0x6003811")]
    [Address(RVA = "0x109E170", Offset = "0x109CF70", VA = "0x1109E170")]
    public void UnlockUpdateBadStatus(EUnitCondition condition)
    {
    }

    [Token(Token = "0x6003812")]
    [Address(RVA = "0x108E6D0", Offset = "0x108D4D0", VA = "0x1108E6D0")]
    public void ClearBadStatusLocks()
    {
    }

    [Token(Token = "0x6003813")]
    [Address(RVA = "0x1090930", Offset = "0x108F730", VA = "0x11090930")]
    public void EnableProhibitedUpdateBadStatus(bool is_prohibited)
    {
    }

    [Token(Token = "0x6003814")]
    [Address(RVA = "0x10908F0", Offset = "0x108F6F0", VA = "0x110908F0")]
    public void EnableDispOffBadStatus(bool is_disp_off)
    {
    }

    [Token(Token = "0x6003815")]
    [Address(RVA = "0x109E190", Offset = "0x109CF90", VA = "0x1109E190")]
    public void UpdateBadStatus()
    {
    }

    [Token(Token = "0x6003816")]
    [Address(RVA = "0x10A02B0", Offset = "0x109F0B0", VA = "0x110A02B0")]
    private void attachBadStatusEffect(GameObject go_effect, string attach_target = null, bool is_use_cs = false)
    {
    }

    [Token(Token = "0x6003817")]
    [Address(RVA = "0x1093280", Offset = "0x1092080", VA = "0x11093280")]
    public bool IsDeathSentenceCountDownPlaying() => new bool();

    [Token(Token = "0x6003818")]
    [Address(RVA = "0x108F0E0", Offset = "0x108DEE0", VA = "0x1108F0E0")]
    public void DeathSentenceCountDown(bool isShow, float LifeTime = 0.0f)
    {
    }

    [Token(Token = "0x6003819")]
    [Address(RVA = "0x109F810", Offset = "0x109E610", VA = "0x1109F810")]
    public void UpdateShields(bool is_update_turn = true, bool is_check_dirty = true)
    {
    }

    [Token(Token = "0x600381A")]
    [Address(RVA = "0x1098F30", Offset = "0x1097D30", VA = "0x11098F30")]
    public void RemoveObsoleteShieldStates()
    {
    }

    [Token(Token = "0x600381B")]
    [Address(RVA = "0x109AFC0", Offset = "0x1099DC0", VA = "0x1109AFC0")]
    private void ShowCriticalEffect(Vector3 position, float yOffset)
    {
    }

    [Token(Token = "0x600381C")]
    [Address(RVA = "0x108FEA0", Offset = "0x108ECA0", VA = "0x1108FEA0")]
    private void DrainGems(TacticsUnitController goal)
    {
    }

    [Token(Token = "0x600381D")]
    [Address(RVA = "0x10925A0", Offset = "0x10913A0", VA = "0x110925A0")]
    public void InitShake(Vector3 basePosition, Vector3 direction)
    {
    }

    [Token(Token = "0x170003E4")]
    public bool ShakeStart
    {
      [Token(Token = "0x600381E"), Address(RVA = "0x10A15A0", Offset = "0x10A03A0", VA = "0x110A15A0")] set
      {
      }
      [Token(Token = "0x600381F"), Address(RVA = "0x10A13F0", Offset = "0x10A01F0", VA = "0x110A13F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003820")]
    [Address(RVA = "0x1093430", Offset = "0x1092230", VA = "0x11093430")]
    public bool IsShakeEnd() => new bool();

    [Token(Token = "0x6003821")]
    [Address(RVA = "0x1090F90", Offset = "0x108FD90", VA = "0x11090F90")]
    public float GetShakeProgress() => new float();

    [Token(Token = "0x6003822")]
    [Address(RVA = "0x108CB50", Offset = "0x108B950", VA = "0x1108CB50")]
    public void AdvanceShake()
    {
    }

    [Token(Token = "0x6003823")]
    [Address(RVA = "0x109BD30", Offset = "0x109AB30", VA = "0x1109BD30")]
    public void SkillTurn(LogSkill Act, EUnitDirection AxisDirection)
    {
    }

    [Token(Token = "0x6003824")]
    [Address(RVA = "0x10999A0", Offset = "0x10987A0", VA = "0x110999A0")]
    public void SetArrowTrajectoryHeight(float Height)
    {
    }

    [Token(Token = "0x6003825")]
    [Address(RVA = "0x1092270", Offset = "0x1091070", VA = "0x11092270")]
    private bool HitTimerExists(TacticsUnitController target) => new bool();

    [Token(Token = "0x6003826")]
    [Address(RVA = "0x1093500", Offset = "0x1092300", VA = "0x11093500")]
    public bool IsStartSkill() => new bool();

    [Token(Token = "0x6003827")]
    [Address(RVA = "0x1090FD0", Offset = "0x108FDD0", VA = "0x11090FD0")]
    public SkillSequence.MapCameraTypes GetSkillCameraType() => new SkillSequence.MapCameraTypes();

    [Token(Token = "0x6003828")]
    [Address(RVA = "0x10934B0", Offset = "0x10922B0", VA = "0x110934B0")]
    public bool IsSkillMirror() => new bool();

    [Token(Token = "0x6003829")]
    [Address(RVA = "0x1093BB0", Offset = "0x10929B0", VA = "0x11093BB0")]
    public void LoadDeathAnimation(TacticsUnitController.DeathAnimationTypes mask)
    {
    }

    [Token(Token = "0x600382A")]
    [Address(RVA = "0x1097B20", Offset = "0x1096920", VA = "0x11097B20")]
    public void PlayDead(TacticsUnitController.DeathAnimationTypes type)
    {
    }

    [Token(Token = "0x600382B")]
    [Address(RVA = "0x108D980", Offset = "0x108C780", VA = "0x1108D980")]
    private void CalcCameraPos(
      AnimationClip clip,
      float normalizedTime,
      int cameraIndex,
      out Vector3 pos,
      out Quaternion rotation)
    {
    }

    [Token(Token = "0x600382C")]
    [Address(RVA = "0x1099930", Offset = "0x1098730", VA = "0x11099930")]
    private void SetActiveCameraPosition(Vector3 position, Quaternion rotation)
    {
    }

    [Token(Token = "0x600382D")]
    [Address(RVA = "0x108CE70", Offset = "0x108BC70", VA = "0x1108CE70")]
    private void AnimateCamera(AnimationClip cameraClip, float normalizedTime, int cameraIndex = 0)
    {
    }

    [Token(Token = "0x600382E")]
    [Address(RVA = "0x108CBB0", Offset = "0x108B9B0", VA = "0x1108CBB0")]
    private void AnimateCameraInterpolated(
      AnimationClip cameraClip,
      float normalizedTime,
      float interpRate,
      TacticsUnitController.CameraState startState,
      int cameraIndex = 0)
    {
    }

    [Token(Token = "0x600382F")]
    [Address(RVA = "0x1097960", Offset = "0x1096760", VA = "0x11097960")]
    public void PlayDamageReaction(int damage, HitReactionTypes hitType = HitReactionTypes.Normal)
    {
    }

    [Token(Token = "0x6003830")]
    [Address(RVA = "0x109B550", Offset = "0x109A350", VA = "0x1109B550")]
    private IEnumerator ShowHitPopup(
      TacticsUnitController target,
      bool critical,
      bool backstab,
      bool guard,
      bool weak,
      bool resist,
      bool hpDamage,
      int hpDamageValue,
      bool mpDamage,
      int mpDamageValue,
      bool absorb,
      bool is_guts)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003831")]
    [Address(RVA = "0x109B4D0", Offset = "0x109A2D0", VA = "0x1109B4D0")]
    private IEnumerator ShowHealPopup(
      TacticsUnitController target,
      int hpHeal,
      int mpHeal,
      float offs_y = 0.0f,
      float delay = 0.0f)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003832")]
    [Address(RVA = "0x108E6F0", Offset = "0x108D4F0", VA = "0x1108E6F0")]
    private IEnumerator ComboShowHealPopup(TacticsUnitController target, int hpHeal, int mpHeal)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003833")]
    [Address(RVA = "0x10917E0", Offset = "0x10905E0", VA = "0x110917E0")]
    private void HitTarget(
      TacticsUnitController target,
      HitReactionTypes hitReaction = HitReactionTypes.None,
      bool doReaction = true)
    {
    }

    [Token(Token = "0x6003834")]
    [Address(RVA = "0x108D680", Offset = "0x108C480", VA = "0x1108D680")]
    public void BuffEffectTarget()
    {
    }

    [Token(Token = "0x6003835")]
    [Address(RVA = "0x108D520", Offset = "0x108C320", VA = "0x1108D520")]
    public void BuffEffectSelf()
    {
    }

    [Token(Token = "0x6003836")]
    [Address(RVA = "0x109B720", Offset = "0x109A520", VA = "0x1109B720")]
    public void SkillEffectSelf()
    {
    }

    [Token(Token = "0x6003837")]
    [Address(RVA = "0x1098A60", Offset = "0x1097860", VA = "0x11098A60")]
    private bool ReflectTargetTypeToPos(ref Vector3 pos) => new bool();

    [Token(Token = "0x6003838")]
    [Address(RVA = "0x10947F0", Offset = "0x10935F0", VA = "0x110947F0", Slot = "8")]
    protected override void OnEventStart(AnimEvent e, float weight)
    {
    }

    [Token(Token = "0x6003839")]
    [Address(RVA = "0x1093400", Offset = "0x1092200", VA = "0x11093400")]
    private bool IsRangedSkillType() => new bool();

    [Token(Token = "0x600383A")]
    [Address(RVA = "0x10933C0", Offset = "0x10921C0", VA = "0x110933C0")]
    private bool IsRangedRaySkillType() => new bool();

    [Token(Token = "0x600383B")]
    [Address(RVA = "0x10969A0", Offset = "0x10957A0", VA = "0x110969A0", Slot = "9")]
    protected override void OnEvent(AnimEvent e, float time, float weight)
    {
    }

    [Token(Token = "0x600383C")]
    [Address(RVA = "0x108CEE0", Offset = "0x108BCE0", VA = "0x1108CEE0")]
    private IEnumerator AnimateProjectile(
      AnimationClip clip,
      float length,
      Vector3 basePosition,
      Quaternion baseRotation,
      TacticsUnitController.ProjectileStopEvent callback,
      TacticsUnitController.ProjectileData pd)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600383D")]
    [Address(RVA = "0x108DD90", Offset = "0x108CB90", VA = "0x1108DD90")]
    private void CalcEnemyPos(
      AnimationClip clip,
      float normalizedTime,
      out Vector3 pos,
      out Quaternion rotation)
    {
    }

    [Token(Token = "0x600383E")]
    [Address(RVA = "0x109D550", Offset = "0x109C350", VA = "0x1109D550")]
    private void StopAura()
    {
    }

    [Token(Token = "0x600383F")]
    [Address(RVA = "0x10980C0", Offset = "0x1096EC0", VA = "0x110980C0")]
    public void PlayPreSkillAnimation(UnityEngine.Camera cam, Vector3 targetPos)
    {
    }

    [Token(Token = "0x6003840")]
    [Address(RVA = "0x1097990", Offset = "0x1096790", VA = "0x11097990")]
    public void PlayDamage(HitReactionTypes hitType)
    {
    }

    [Token(Token = "0x6003841")]
    [Address(RVA = "0x1097B60", Offset = "0x1096960", VA = "0x11097B60")]
    public void PlayDodge(bool perfectAvoid, bool is_disp_popup = true)
    {
    }

    [Token(Token = "0x6003842")]
    [Address(RVA = "0x1093DC0", Offset = "0x1092BC0", VA = "0x11093DC0")]
    public void LoadDodgeAnimation()
    {
    }

    [Token(Token = "0x6003843")]
    [Address(RVA = "0x1093AF0", Offset = "0x10928F0", VA = "0x11093AF0")]
    public void LoadDamageAnimations()
    {
    }

    [Token(Token = "0x6003844")]
    [Address(RVA = "0x10941B0", Offset = "0x1092FB0", VA = "0x110941B0")]
    public void LoadSkillSequence(
      SkillParam skillParam,
      SkillMotion skill_motion,
      bool loadJobAnimation,
      bool useBattleScene,
      bool is_cs = false,
      bool is_cs_sub = false)
    {
    }

    [Token(Token = "0x170003E5")]
    public bool HasPreSkillAnimation
    {
      [Token(Token = "0x6003845"), Address(RVA = "0x10A0E40", Offset = "0x109FC40", VA = "0x110A0E40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170003E6")]
    public bool IsSkillParentPosZero
    {
      [Token(Token = "0x6003846"), Address(RVA = "0x10A12D0", Offset = "0x10A00D0", VA = "0x110A12D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170003E7")]
    public bool IsPreSkillParentPosZero
    {
      [Token(Token = "0x6003847"), Address(RVA = "0x10A1250", Offset = "0x10A0050", VA = "0x110A1250")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170003E8")]
    public bool IsSkillRidingUnitCHM
    {
      [Token(Token = "0x6003848"), Address(RVA = "0x10A1350", Offset = "0x10A0150", VA = "0x110A1350")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003849")]
    [Address(RVA = "0x1094130", Offset = "0x1092F30", VA = "0x11094130")]
    private IEnumerator LoadSkillSequenceAsync(SkillParam skillParam, bool loadJobAnimation)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600384A")]
    [Address(RVA = "0x1094020", Offset = "0x1092E20", VA = "0x11094020")]
    public void LoadSkillEffect(string skillEffectName, bool is_cs_sub = false)
    {
    }

    [Token(Token = "0x600384B")]
    [Address(RVA = "0x1093300", Offset = "0x1092100", VA = "0x11093300")]
    public bool IsFinishedLoadSkillEffect() => new bool();

    [Token(Token = "0x600384C")]
    [Address(RVA = "0x1093FB0", Offset = "0x1092DB0", VA = "0x11093FB0")]
    private IEnumerator LoadSkillEffectAsync(string skillEffectName) => (IEnumerator) null;

    [Token(Token = "0x600384D")]
    [Address(RVA = "0x1094290", Offset = "0x1093090", VA = "0x11094290")]
    private IEnumerator LoadTargetBuffEffectAsync(
      string _effect_name,
      bool _is_target_effect,
      bool _is_big_unit_effect)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600384E")]
    [Address(RVA = "0x108EB00", Offset = "0x108D900", VA = "0x1108EB00")]
    private string CreateLoadBuffEffectPath(string _effect_name, bool _is_big_unit)
    {
      return (string) null;
    }

    [Token(Token = "0x170003E9")]
    public SkillEffect LoadedSkillEffect
    {
      [Token(Token = "0x600384F"), Address(RVA = "0x10A13D0", Offset = "0x10A01D0", VA = "0x110A13D0")] get
      {
        return (SkillEffect) null;
      }
    }

    [Token(Token = "0x6003850")]
    [Address(RVA = "0x109DF30", Offset = "0x109CD30", VA = "0x1109DF30")]
    public void UnloadBattleAnimations()
    {
    }

    [Token(Token = "0x6003851")]
    [Address(RVA = "0x1099330", Offset = "0x1098130", VA = "0x11099330")]
    private void ResetSkill()
    {
    }

    [Token(Token = "0x6003852")]
    [Address(RVA = "0x1090C30", Offset = "0x108FA30", VA = "0x11090C30")]
    private void FinishSkill()
    {
    }

    [Token(Token = "0x6003853")]
    [Address(RVA = "0x108E9D0", Offset = "0x108D7D0", VA = "0x1108E9D0")]
    private int CountSkillUnitVoice() => new int();

    [Token(Token = "0x6003854")]
    [Address(RVA = "0x109A7E0", Offset = "0x10995E0", VA = "0x1109A7E0")]
    public void SetLastHitEffect(GameObject effect)
    {
    }

    [Token(Token = "0x6003855")]
    [Address(RVA = "0x109A770", Offset = "0x1099570", VA = "0x1109A770")]
    public void SetHitInfo(LogSkill.Target target)
    {
    }

    [Token(Token = "0x6003856")]
    [Address(RVA = "0x109A750", Offset = "0x1099550", VA = "0x1109A750")]
    public void SetHitInfoSelf(LogSkill.Target selfTarget)
    {
    }

    [Token(Token = "0x6003857")]
    [Address(RVA = "0x108E770", Offset = "0x108D570", VA = "0x1108E770")]
    public int CountSkillHits() => new int();

    [Token(Token = "0x6003858")]
    [Address(RVA = "0x109CAC0", Offset = "0x109B8C0", VA = "0x1109CAC0")]
    private void SpawnHitEffect(TacticsUnitController target, bool isLast)
    {
    }

    [Token(Token = "0x6003859")]
    [Address(RVA = "0x109C8A0", Offset = "0x109B6A0", VA = "0x1109C8A0")]
    private void SpawnDefendHitEffect(SkillData defSkill, int useCount, int useCountMax)
    {
    }

    [Token(Token = "0x600385A")]
    [Address(RVA = "0x109C3C0", Offset = "0x109B1C0", VA = "0x1109C3C0")]
    public void SpawnBuffDebuffEffect(bool _is_self, TacticsUnitController _controller = null)
    {
    }

    [Token(Token = "0x600385B")]
    [Address(RVA = "0x1091500", Offset = "0x1090300", VA = "0x11091500")]
    private void HitDelayed(TacticsUnitController target)
    {
    }

    [Token(Token = "0x600385C")]
    [Address(RVA = "0x108D130", Offset = "0x108BF30", VA = "0x1108D130")]
    private IEnumerator AsyncHitTimer() => (IEnumerator) null;

    [Token(Token = "0x600385D")]
    [Address(RVA = "0x1092640", Offset = "0x1091440", VA = "0x11092640")]
    private void InternalStartSkill(
      TacticsUnitController[] targets,
      Vector3 targetPosition,
      UnityEngine.Camera activeCamera,
      bool doStateChange = true,
      bool _is_direction_off = false)
    {
    }

    [Token(Token = "0x600385E")]
    [Address(RVA = "0x109D160", Offset = "0x109BF60", VA = "0x1109D160")]
    public void StartSkill(
      Vector3 targetPosition,
      UnityEngine.Camera activeCamera,
      TacticsUnitController[] targets,
      Vector3[] hitGrids,
      SkillParam skill)
    {
    }

    [Token(Token = "0x600385F")]
    [Address(RVA = "0x109D1C0", Offset = "0x109BFC0", VA = "0x1109D1C0")]
    public void StartSkill(TacticsUnitController target, UnityEngine.Camera activeCamera, SkillParam skill)
    {
    }

    [Token(Token = "0x6003860")]
    [Address(RVA = "0x109A7B0", Offset = "0x10995B0", VA = "0x1109A7B0")]
    public void SetLandingGrid(Grid landing)
    {
    }

    [Token(Token = "0x6003861")]
    [Address(RVA = "0x109AC50", Offset = "0x1099A50", VA = "0x1109AC50")]
    public void SetTeleportGrid(Grid teleport)
    {
    }

    [Token(Token = "0x6003862")]
    [Address(RVA = "0x1097EA0", Offset = "0x1096CA0", VA = "0x11097EA0")]
    public void PlayKirimomi()
    {
    }

    [Token(Token = "0x6003863")]
    [Address(RVA = "0x1097D80", Offset = "0x1096B80", VA = "0x11097D80")]
    public void PlayDown()
    {
    }

    [Token(Token = "0x6003864")]
    [Address(RVA = "0x109A790", Offset = "0x1099590", VA = "0x1109A790")]
    public void SetHpCostSkill(int SkillHpCost)
    {
    }

    [Token(Token = "0x6003865")]
    [Address(RVA = "0x1096BA0", Offset = "0x10959A0", VA = "0x11096BA0")]
    private void OnProjectileDistanceChange(GameObject go, float distance)
    {
    }

    [Token(Token = "0x6003866")]
    [Address(RVA = "0x1090500", Offset = "0x108F300", VA = "0x11090500")]
    public void DrawSpawnEffect()
    {
    }

    [Token(Token = "0x6003867")]
    [Address(RVA = "0x1096E40", Offset = "0x1095C40", VA = "0x11096E40")]
    private void OnProjectileHit(TacticsUnitController.ProjectileData pd = null)
    {
    }

    [Token(Token = "0x6003868")]
    [Address(RVA = "0x1093380", Offset = "0x1092180", VA = "0x11093380")]
    public bool IsJumpCant() => new bool();

    [Token(Token = "0x6003869")]
    [Address(RVA = "0x1093270", Offset = "0x1092070", VA = "0x11093270")]
    public bool IsCastJumpStartComplete() => new bool();

    [Token(Token = "0x600386A")]
    [Address(RVA = "0x1093260", Offset = "0x1092060", VA = "0x11093260")]
    public bool IsCastJumpFallComplete() => new bool();

    [Token(Token = "0x600386B")]
    [Address(RVA = "0x108E3E0", Offset = "0x108D1E0", VA = "0x1108E3E0")]
    public void CastJump()
    {
    }

    [Token(Token = "0x600386C")]
    [Address(RVA = "0x108E390", Offset = "0x108D190", VA = "0x1108E390")]
    public void CastJumpFall(bool is_play_damage_motion = false, bool is_play_idol_motion_loop = false)
    {
    }

    [Token(Token = "0x600386D")]
    [Address(RVA = "0x10932F0", Offset = "0x10920F0", VA = "0x110932F0")]
    public bool IsFinishedCastJumpFall() => new bool();

    [Token(Token = "0x600386E")]
    [Address(RVA = "0x1099A00", Offset = "0x1098800", VA = "0x11099A00")]
    public void SetCastJump()
    {
    }

    [Token(Token = "0x600386F")]
    [Address(RVA = "0x1091310", Offset = "0x1090110", VA = "0x11091310")]
    public void HideGimmickForTargetGrid(TacticsUnitController target)
    {
    }

    [Token(Token = "0x6003870")]
    [Address(RVA = "0x10A05F0", Offset = "0x109F3F0", VA = "0x110A05F0")]
    private void createEffect(TacticsUnitController target, GameObject go_effect)
    {
    }

    [Token(Token = "0x6003871")]
    [Address(RVA = "0x10A0430", Offset = "0x109F230", VA = "0x110A0430")]
    private void createEffect(
      TacticsUnitController target,
      SkillEffect.EffectElement[] effects,
      bool set_rotation = false,
      float rotationY = 0.0f)
    {
    }

    [Token(Token = "0x6003872")]
    [Address(RVA = "0x10911E0", Offset = "0x108FFE0", VA = "0x110911E0")]
    public List<TacticsUnitController> GetTargetTucLists() => (List<TacticsUnitController>) null;

    [Token(Token = "0x170003EA")]
    public Grid KnockBackGrid
    {
      [Token(Token = "0x6003873"), Address(RVA = "0x10A1570", Offset = "0x10A0370", VA = "0x110A1570")] set
      {
      }
    }

    [Token(Token = "0x170003EB")]
    public bool IsBusy
    {
      [Token(Token = "0x6003874"), Address(RVA = "0x10A0F20", Offset = "0x109FD20", VA = "0x110A0F20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003875")]
    [Address(RVA = "0x10A0750", Offset = "0x109F550", VA = "0x110A0750")]
    private void execKnockBack()
    {
    }

    [Token(Token = "0x6003876")]
    [Address(RVA = "0x10910A0", Offset = "0x108FEA0", VA = "0x110910A0")]
    public Vector3 GetTargetPos() => new Vector3();

    [Token(Token = "0x6003877")]
    [Address(RVA = "0x109AC20", Offset = "0x1099A20", VA = "0x1109AC20")]
    public void SetStartPos(Vector3 pos)
    {
    }

    [Token(Token = "0x6003878")]
    [Address(RVA = "0x10944A0", Offset = "0x10932A0", VA = "0x110944A0")]
    public void LookAtTarget()
    {
    }

    [Token(Token = "0x6003879")]
    [Address(RVA = "0x1098950", Offset = "0x1097750", VA = "0x11098950")]
    public void ReflectDispModel()
    {
    }

    [Token(Token = "0x600387A")]
    [Address(RVA = "0x10981A0", Offset = "0x1096FA0", VA = "0x110981A0")]
    public void PlayTrickKnockBack(bool is_dmg_anm = false)
    {
    }

    [Token(Token = "0x600387B")]
    [Address(RVA = "0x1091000", Offset = "0x108FE00", VA = "0x11091000")]
    public SkillSequence GetSkillSequence() => (SkillSequence) null;

    [Token(Token = "0x600387C")]
    [Address(RVA = "0x1094310", Offset = "0x1093110", VA = "0x11094310")]
    public void LoadTransformAnimation(SkillSequence ss)
    {
    }

    [Token(Token = "0x600387D")]
    [Address(RVA = "0x10977B0", Offset = "0x10965B0", VA = "0x110977B0")]
    private void PlayAfterTransform()
    {
    }

    [Token(Token = "0x600387E")]
    [Address(RVA = "0x1098030", Offset = "0x1096E30", VA = "0x11098030")]
    public void PlayPreAfterTransform()
    {
    }

    [Token(Token = "0x600387F")]
    [Address(RVA = "0x1091020", Offset = "0x108FE20", VA = "0x11091020")]
    public List<TacticsUnitController> GetSkillTargets() => (List<TacticsUnitController>) null;

    [Token(Token = "0x6003880")]
    [Address(RVA = "0x10939F0", Offset = "0x10927F0", VA = "0x110939F0")]
    public void LoadBigUnitBsAnimation()
    {
    }

    [Token(Token = "0x6003881")]
    [Address(RVA = "0x10978D0", Offset = "0x10966D0", VA = "0x110978D0")]
    private void PlayBigUnitBsIdle()
    {
    }

    [Token(Token = "0x6003882")]
    [Address(RVA = "0x1097840", Offset = "0x1096640", VA = "0x11097840")]
    private void PlayBigUnitBsDamage()
    {
    }

    [Token(Token = "0x6003883")]
    [Address(RVA = "0x1093520", Offset = "0x1092320", VA = "0x11093520")]
    public bool IsUseCommonAnim(SkillParam _skill_param) => new bool();

    [Token(Token = "0x6003884")]
    [Address(RVA = "0x109AC80", Offset = "0x1099A80", VA = "0x1109AC80")]
    public void SethealPopUp(int hpHeal, int mpHeal)
    {
    }

    [Token(Token = "0x6003885")]
    [Address(RVA = "0x1099DC0", Offset = "0x1098BC0", VA = "0x11099DC0")]
    public void SetGutsPopUp()
    {
    }

    [Token(Token = "0x6003886")]
    [Address(RVA = "0x109B3E0", Offset = "0x109A1E0", VA = "0x1109B3E0")]
    private IEnumerator ShowGutsPopup(TacticsUnitController target) => (IEnumerator) null;

    [Token(Token = "0x6003887")]
    [Address(RVA = "0x108D190", Offset = "0x108BF90", VA = "0x1108D190")]
    private void AvoidDisplayBuffEffect(TacticsUnitController _target)
    {
    }

    [Token(Token = "0x6003888")]
    [Address(RVA = "0x108F2C0", Offset = "0x108E0C0", VA = "0x1108F2C0")]
    public void DirectionOff_LoadSkill(
      SkillParam skillParam,
      SkillMotion skill_motion,
      bool is_cs = false,
      bool is_cs_sub = false)
    {
    }

    [Token(Token = "0x6003889")]
    [Address(RVA = "0x108F2A0", Offset = "0x108E0A0", VA = "0x1108F2A0")]
    public void DirectionOff_EndSkill()
    {
    }

    [Token(Token = "0x600388A")]
    [Address(RVA = "0x108FC50", Offset = "0x108EA50", VA = "0x1108FC50")]
    public void DirectionOff_StartSkill(
      Vector3 targetPosition,
      UnityEngine.Camera activeCamera,
      TacticsUnitController[] targets,
      Vector3[] hitGrids,
      SkillParam skill)
    {
    }

    [Token(Token = "0x600388B")]
    [Address(RVA = "0x108F490", Offset = "0x108E290", VA = "0x1108F490")]
    public bool DirectionOff_OnEventStart() => new bool();

    [Token(Token = "0x600388C")]
    [Address(RVA = "0x10A0130", Offset = "0x109EF30", VA = "0x110A0130")]
    public TacticsUnitController()
    {
    }

    [Token(Token = "0x600388D")]
    [Address(RVA = "0x109FDC0", Offset = "0x109EBC0", VA = "0x1109FDC0")]
    static TacticsUnitController()
    {
    }

    [Token(Token = "0x2000DC5")]
    public enum PostureTypes
    {
      [Token(Token = "0x40028B2")] Combat,
      [Token(Token = "0x40028B3")] NonCombat,
    }

    [Token(Token = "0x2000DC6")]
    public enum HPGaugeModes
    {
      [Token(Token = "0x40028B5")] Normal,
      [Token(Token = "0x40028B6")] Attack,
      [Token(Token = "0x40028B7")] Target,
      [Token(Token = "0x40028B8")] Change,
    }

    [Token(Token = "0x2000DC7")]
    private class HideGimmickAnimation
    {
      [Token(Token = "0x40028B9")]
      [FieldOffset(Offset = "0x8")]
      private Vector3 mBaseScale;
      [Token(Token = "0x40028BA")]
      [FieldOffset(Offset = "0x14")]
      private TacticsUnitController mGimmickController;
      [Token(Token = "0x40028BB")]
      [FieldOffset(Offset = "0x18")]
      public bool IsHide;
      [Token(Token = "0x40028BC")]
      [FieldOffset(Offset = "0x19")]
      public bool Enable;
      [Token(Token = "0x40028BD")]
      [FieldOffset(Offset = "0x1C")]
      private float mWait;
      [Token(Token = "0x40028BE")]
      [FieldOffset(Offset = "0x20")]
      private float mCurrentWait;
      [Token(Token = "0x40028BF")]
      [FieldOffset(Offset = "0x24")]
      private float mSpeed;

      [Token(Token = "0x600388E")]
      [Address(RVA = "0x10A17F0", Offset = "0x10A05F0", VA = "0x110A17F0")]
      public void Init(TacticsUnitController GimmickController)
      {
      }

      [Token(Token = "0x600388F")]
      [Address(RVA = "0x10A18E0", Offset = "0x10A06E0", VA = "0x110A18E0")]
      public void ResetScale()
      {
      }

      [Token(Token = "0x6003890")]
      [Address(RVA = "0x10A1940", Offset = "0x10A0740", VA = "0x110A1940")]
      public void Update()
      {
      }

      [Token(Token = "0x6003891")]
      [Address(RVA = "0x10A1BC0", Offset = "0x10A09C0", VA = "0x110A1BC0")]
      public HideGimmickAnimation()
      {
      }
    }

    [Token(Token = "0x2000DC8")]
    private class State : SRPG.State<TacticsUnitController>
    {
      [Token(Token = "0x6003892")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State()
      {
      }
    }

    [Token(Token = "0x2000DC9")]
    private enum ColorBlendModes
    {
      [Token(Token = "0x40028C1")] None,
      [Token(Token = "0x40028C2")] Fade,
      [Token(Token = "0x40028C3")] Blink,
    }

    [Token(Token = "0x2000DCA")]
    private class State_WaitResources : TacticsUnitController.State
    {
      [Token(Token = "0x6003893")]
      [Address(RVA = "0x10AC7C0", Offset = "0x10AB5C0", VA = "0x110AC7C0", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x6003894")]
      [Address(RVA = "0x10AC770", Offset = "0x10AB570", VA = "0x110AC770", Slot = "6")]
      public override void End(TacticsUnitController self)
      {
      }

      [Token(Token = "0x6003895")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_WaitResources()
      {
      }
    }

    [Token(Token = "0x2000DCB")]
    private class State_Idle : TacticsUnitController.State
    {
      [Token(Token = "0x6003896")]
      [Address(RVA = "0x10A7070", Offset = "0x10A5E70", VA = "0x110A7070", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x6003897")]
      [Address(RVA = "0x10A71C0", Offset = "0x10A5FC0", VA = "0x110A71C0", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x6003898")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_Idle()
      {
      }
    }

    [Token(Token = "0x2000DCC")]
    private class State_LookAt : TacticsUnitController.State
    {
      [Token(Token = "0x40028C4")]
      [FieldOffset(Offset = "0xC")]
      private float mTime;
      [Token(Token = "0x40028C5")]
      [FieldOffset(Offset = "0x10")]
      private float mSpinTime;
      [Token(Token = "0x40028C6")]
      [FieldOffset(Offset = "0x14")]
      private float mSpinCount;
      [Token(Token = "0x40028C7")]
      [FieldOffset(Offset = "0x18")]
      private Transform mTransform;
      [Token(Token = "0x40028C8")]
      [FieldOffset(Offset = "0x1C")]
      private Vector3 mStartPosition;
      [Token(Token = "0x40028C9")]
      [FieldOffset(Offset = "0x28")]
      private Quaternion mEndRotation;
      [Token(Token = "0x40028CA")]
      [FieldOffset(Offset = "0x38")]
      private float mJumpHeight;

      [Token(Token = "0x6003899")]
      [Address(RVA = "0x10A8E50", Offset = "0x10A7C50", VA = "0x110A8E50", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x600389A")]
      [Address(RVA = "0x10A8F80", Offset = "0x10A7D80", VA = "0x110A8F80", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x600389B")]
      [Address(RVA = "0x10A9220", Offset = "0x10A8020", VA = "0x110A9220")]
      public State_LookAt()
      {
      }
    }

    [Token(Token = "0x2000DCD")]
    private delegate void FieldActionEndEvent();

    [Token(Token = "0x2000DCE")]
    private class State_FieldAction : TacticsUnitController.State
    {
      [Token(Token = "0x60038A0")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_FieldAction()
      {
      }
    }

    [Token(Token = "0x2000DCF")]
    private class State_FieldActionClimpUp : TacticsUnitController.State_FieldAction
    {
      [Token(Token = "0x60038A1")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_FieldActionClimpUp()
      {
      }
    }

    [Token(Token = "0x2000DD0")]
    private class State_FieldActionJumpUp : TacticsUnitController.State_FieldAction
    {
      [Token(Token = "0x40028CB")]
      [FieldOffset(Offset = "0xC")]
      private Vector3 mStartPosition;
      [Token(Token = "0x40028CC")]
      [FieldOffset(Offset = "0x18")]
      private Vector3 mEndPosition;
      [Token(Token = "0x40028CD")]
      [FieldOffset(Offset = "0x24")]
      private float mTime;
      [Token(Token = "0x40028CE")]
      [FieldOffset(Offset = "0x28")]
      private float mDuration;
      [Token(Token = "0x40028CF")]
      [FieldOffset(Offset = "0x2C")]
      private bool mFalling;
      [Token(Token = "0x40028D0")]
      [FieldOffset(Offset = "0x30")]
      private float mLastY;

      [Token(Token = "0x60038A2")]
      [Address(RVA = "0x10A6930", Offset = "0x10A5730", VA = "0x110A6930", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038A3")]
      [Address(RVA = "0x10A6A50", Offset = "0x10A5850", VA = "0x110A6A50", Slot = "6")]
      public override void End(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038A4")]
      [Address(RVA = "0x10A6A80", Offset = "0x10A5880", VA = "0x110A6A80", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038A5")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_FieldActionJumpUp()
      {
      }
    }

    [Token(Token = "0x2000DD1")]
    private class State_FieldActionJump : TacticsUnitController.State_FieldAction
    {
      [Token(Token = "0x40028D1")]
      [FieldOffset(Offset = "0xC")]
      private Vector3 mStartPosition;
      [Token(Token = "0x40028D2")]
      [FieldOffset(Offset = "0x18")]
      private Vector3 mEndPosition;
      [Token(Token = "0x40028D3")]
      [FieldOffset(Offset = "0x24")]
      private float mTime;
      [Token(Token = "0x40028D4")]
      [FieldOffset(Offset = "0x28")]
      private float mAnimRate;
      [Token(Token = "0x40028D5")]
      [FieldOffset(Offset = "0x2C")]
      private float mJumpHeight;

      [Token(Token = "0x60038A6")]
      [Address(RVA = "0x10A6CD0", Offset = "0x10A5AD0", VA = "0x110A6CD0", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038A7")]
      [Address(RVA = "0x10A6EC0", Offset = "0x10A5CC0", VA = "0x110A6EC0", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038A8")]
      [Address(RVA = "0x10A66F0", Offset = "0x10A54F0", VA = "0x110A66F0", Slot = "6")]
      public override void End(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038A9")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_FieldActionJump()
      {
      }
    }

    [Token(Token = "0x2000DD2")]
    private class State_FieldActionFall : TacticsUnitController.State_FieldAction
    {
      [Token(Token = "0x40028D6")]
      [FieldOffset(Offset = "0xC")]
      private Vector3 mStartPosition;
      [Token(Token = "0x40028D7")]
      [FieldOffset(Offset = "0x18")]
      private Vector3 mEndPosition;
      [Token(Token = "0x40028D8")]
      [FieldOffset(Offset = "0x24")]
      private float mTime;
      [Token(Token = "0x40028D9")]
      [FieldOffset(Offset = "0x28")]
      private float mDuration;

      [Token(Token = "0x60038AA")]
      [Address(RVA = "0x10A6530", Offset = "0x10A5330", VA = "0x110A6530", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038AB")]
      [Address(RVA = "0x10A6710", Offset = "0x10A5510", VA = "0x110A6710", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038AC")]
      [Address(RVA = "0x10A66F0", Offset = "0x10A54F0", VA = "0x110A66F0", Slot = "6")]
      public override void End(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038AD")]
      [Address(RVA = "0x10A68F0", Offset = "0x10A56F0", VA = "0x110A68F0")]
      public State_FieldActionFall()
      {
      }
    }

    [Token(Token = "0x2000DD3")]
    private class State_RunLoop : TacticsUnitController.State
    {
      [Token(Token = "0x60038AE")]
      [Address(RVA = "0x10AB0C0", Offset = "0x10A9EC0", VA = "0x110AB0C0", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038AF")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038B0")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public override void End(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038B1")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_RunLoop()
      {
      }
    }

    [Token(Token = "0x2000DD4")]
    private class State_StepNoAnimation : TacticsUnitController.State
    {
      [Token(Token = "0x60038B2")]
      [Address(RVA = "0x10ABE50", Offset = "0x10AAC50", VA = "0x110ABE50", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038B3")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_StepNoAnimation()
      {
      }
    }

    [Token(Token = "0x2000DD5")]
    private class State_Step : TacticsUnitController.State
    {
      [Token(Token = "0x40028DA")]
      [FieldOffset(Offset = "0xC")]
      private float mLandTime;

      [Token(Token = "0x60038B4")]
      [Address(RVA = "0x10AC030", Offset = "0x10AAE30", VA = "0x110AC030", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038B5")]
      [Address(RVA = "0x10AC160", Offset = "0x10AAF60", VA = "0x110AC160", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038B6")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_Step()
      {
      }
    }

    [Token(Token = "0x2000DD6")]
    private class State_Move : TacticsUnitController.State
    {
      [Token(Token = "0x40028DB")]
      [FieldOffset(Offset = "0xC")]
      private Vector3 mStartPos;
      [Token(Token = "0x40028DC")]
      [FieldOffset(Offset = "0x18")]
      private bool mAdjustDirection;
      [Token(Token = "0x40028DD")]
      [FieldOffset(Offset = "0x1C")]
      private Quaternion mDesiredRotation;
      [Token(Token = "0x40028DE")]
      [FieldOffset(Offset = "0x2C")]
      private float mRotationRate;

      [Token(Token = "0x60038B7")]
      [Address(RVA = "0x10A9270", Offset = "0x10A8070", VA = "0x110A9270", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038B8")]
      [Address(RVA = "0x10A9560", Offset = "0x10A8360", VA = "0x110A9560", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038B9")]
      [Address(RVA = "0x10A9470", Offset = "0x10A8270", VA = "0x110A9470")]
      private void LookToward(TacticsUnitController self, Vector3 v)
      {
      }

      [Token(Token = "0x60038BA")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_Move()
      {
      }
    }

    [Token(Token = "0x2000DD7")]
    private class State_Pickup : TacticsUnitController.State
    {
      [Token(Token = "0x40028DF")]
      [FieldOffset(Offset = "0xC")]
      private Vector3 mObjectStartPos;
      [Token(Token = "0x40028E0")]
      [FieldOffset(Offset = "0x18")]
      private Vector3 mTopPos;
      [Token(Token = "0x40028E1")]
      [FieldOffset(Offset = "0x24")]
      private bool mPickedUp;
      [Token(Token = "0x40028E2")]
      [FieldOffset(Offset = "0x28")]
      private float mPostPickupDelay;

      [Token(Token = "0x60038BB")]
      [Address(RVA = "0x10A9FA0", Offset = "0x10A8DA0", VA = "0x110A9FA0", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038BC")]
      [Address(RVA = "0x10AA1A0", Offset = "0x10A8FA0", VA = "0x110AA1A0", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038BD")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_Pickup()
      {
      }
    }

    [Token(Token = "0x2000DD8")]
    private class State_PostPickup : TacticsUnitController.State
    {
      [Token(Token = "0x60038BE")]
      [Address(RVA = "0x10AA420", Offset = "0x10A9220", VA = "0x110AA420", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038BF")]
      [Address(RVA = "0x10AA530", Offset = "0x10A9330", VA = "0x110AA530", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038C0")]
      [Address(RVA = "0x10AA4F0", Offset = "0x10A92F0", VA = "0x110AA4F0", Slot = "6")]
      public override void End(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038C1")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_PostPickup()
      {
      }
    }

    [Token(Token = "0x2000DD9")]
    private class State_Taken : TacticsUnitController.State
    {
      [Token(Token = "0x60038C2")]
      [Address(RVA = "0x10AC300", Offset = "0x10AB100", VA = "0x110AC300", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038C3")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_Taken()
      {
      }
    }

    [Token(Token = "0x2000DDA")]
    private struct CameraState
    {
      [Token(Token = "0x40028E3")]
      [FieldOffset(Offset = "0x0")]
      public Vector3 Position;
      [Token(Token = "0x40028E4")]
      [FieldOffset(Offset = "0xC")]
      public Quaternion Rotation;
      [Token(Token = "0x40028E5")]
      [FieldOffset(Offset = "0x0")]
      public static TacticsUnitController.CameraState Default;

      [Token(Token = "0x60038C4")]
      [Address(RVA = "0x10A16D0", Offset = "0x10A04D0", VA = "0x110A16D0")]
      public void CacheCurrent(UnityEngine.Camera camera)
      {
      }
    }

    [Token(Token = "0x2000DDB")]
    public enum PointType
    {
      [Token(Token = "0x40028E7")] Damage,
      [Token(Token = "0x40028E8")] Heal,
    }

    [Token(Token = "0x2000DDC")]
    public struct OutputPoint
    {
      [Token(Token = "0x40028E9")]
      [FieldOffset(Offset = "0x0")]
      public int Value;
      [Token(Token = "0x40028EA")]
      [FieldOffset(Offset = "0x4")]
      public TacticsUnitController.PointType PointType;
      [Token(Token = "0x40028EB")]
      [FieldOffset(Offset = "0x8")]
      public bool Critical;
    }

    [Token(Token = "0x2000DDD")]
    public class ProjectileData
    {
      [Token(Token = "0x40028EC")]
      [FieldOffset(Offset = "0x8")]
      public GameObject mProjectile;
      [Token(Token = "0x40028ED")]
      [FieldOffset(Offset = "0xC")]
      public Coroutine mProjectileThread;
      [Token(Token = "0x40028EE")]
      [FieldOffset(Offset = "0x10")]
      public bool mProjectileHitsTarget;
      [Token(Token = "0x40028EF")]
      [FieldOffset(Offset = "0x11")]
      public bool mProjStartAnimEnded;
      [Token(Token = "0x40028F0")]
      [FieldOffset(Offset = "0x12")]
      public bool mIsHitOnly;
      [Token(Token = "0x40028F1")]
      [FieldOffset(Offset = "0x13")]
      public bool mIsNotSpawnLandingEffect;

      [Token(Token = "0x60038C5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ProjectileData()
      {
      }
    }

    [Token(Token = "0x2000DDE")]
    private class SkillVars
    {
      [Token(Token = "0x40028F2")]
      [FieldOffset(Offset = "0x8")]
      private int mDefaultLayer;
      [Token(Token = "0x40028F3")]
      [FieldOffset(Offset = "0xC")]
      public bool SuppressDamageOutput;
      [Token(Token = "0x40028F4")]
      [FieldOffset(Offset = "0x10")]
      public int HpCostDamage;
      [Token(Token = "0x40028F5")]
      [FieldOffset(Offset = "0x14")]
      public SkillParam Skill;
      [Token(Token = "0x40028F6")]
      [FieldOffset(Offset = "0x18")]
      public bool mIsCollaboSkill;
      [Token(Token = "0x40028F7")]
      [FieldOffset(Offset = "0x19")]
      public bool mIsCollaboSkillSub;
      [Token(Token = "0x40028F8")]
      [FieldOffset(Offset = "0x1C")]
      public List<TacticsUnitController> Targets;
      [Token(Token = "0x40028F9")]
      [FieldOffset(Offset = "0x20")]
      public Vector3 mStartPosition;
      [Token(Token = "0x40028FA")]
      [FieldOffset(Offset = "0x2C")]
      public Vector3 mTargetPosition;
      [Token(Token = "0x40028FB")]
      [FieldOffset(Offset = "0x38")]
      public Vector3 mTargetControllerPosition;
      [Token(Token = "0x40028FC")]
      [FieldOffset(Offset = "0x44")]
      public TacticsUnitController mTargetController;
      [Token(Token = "0x40028FD")]
      [FieldOffset(Offset = "0x48")]
      public bool mAuraEnable;
      [Token(Token = "0x40028FE")]
      [FieldOffset(Offset = "0x4C")]
      public List<GameObject> mAuras;
      [Token(Token = "0x40028FF")]
      [FieldOffset(Offset = "0x50")]
      public UnityEngine.Camera mActiveCamera;
      [Token(Token = "0x4002900")]
      [FieldOffset(Offset = "0x54")]
      public StatusParam Param;
      [Token(Token = "0x4002901")]
      [FieldOffset(Offset = "0x58")]
      public int mCameraID;
      [Token(Token = "0x4002902")]
      [FieldOffset(Offset = "0x5C")]
      public int mChantCameraID;
      [Token(Token = "0x4002903")]
      [FieldOffset(Offset = "0x60")]
      public int mSkillCameraID;
      [Token(Token = "0x4002904")]
      [FieldOffset(Offset = "0x64")]
      public Quaternion mCameraShakeOffset;
      [Token(Token = "0x4002905")]
      [FieldOffset(Offset = "0x74")]
      public float mCameraShakeSeedX;
      [Token(Token = "0x4002906")]
      [FieldOffset(Offset = "0x78")]
      public float mCameraShakeSeedY;
      [Token(Token = "0x4002907")]
      [FieldOffset(Offset = "0x7C")]
      public int MaxPlayVoice;
      [Token(Token = "0x4002908")]
      [FieldOffset(Offset = "0x80")]
      public int NumPlayVoice;
      [Token(Token = "0x4002909")]
      [FieldOffset(Offset = "0x84")]
      public int TotalHits;
      [Token(Token = "0x400290A")]
      [FieldOffset(Offset = "0x88")]
      public int NumHitsLeft;
      [Token(Token = "0x400290B")]
      [FieldOffset(Offset = "0x8C")]
      public SkillSequence mSkillSequence;
      [Token(Token = "0x400290C")]
      [FieldOffset(Offset = "0x90")]
      public AnimDef mSkillChantAnimation;
      [Token(Token = "0x400290D")]
      [FieldOffset(Offset = "0x94")]
      public AnimDef mSkillAnimation;
      [Token(Token = "0x400290E")]
      [FieldOffset(Offset = "0x98")]
      public AnimDef mSkillEndAnimation;
      [Token(Token = "0x400290F")]
      [FieldOffset(Offset = "0x9C")]
      public AnimDef mSkillStartAnimation;
      [Token(Token = "0x4002910")]
      [FieldOffset(Offset = "0xA0")]
      public AnimationClip mSkillChantCameraClip;
      [Token(Token = "0x4002911")]
      [FieldOffset(Offset = "0xA4")]
      public AnimationClip mSkillCameraClip;
      [Token(Token = "0x4002912")]
      [FieldOffset(Offset = "0xA8")]
      public AnimationClip mSkillEndCameraClip;
      [Token(Token = "0x4002913")]
      [FieldOffset(Offset = "0xAC")]
      public GameObject mChantEffect;
      [Token(Token = "0x4002914")]
      [FieldOffset(Offset = "0xB0")]
      public List<TacticsUnitController.ProjectileData> mProjectileDataLists;
      [Token(Token = "0x4002915")]
      [FieldOffset(Offset = "0xB4")]
      public int mNumShotCount;
      [Token(Token = "0x4002916")]
      [FieldOffset(Offset = "0xB8")]
      public bool mProjectileTriggered;
      [Token(Token = "0x4002917")]
      [FieldOffset(Offset = "0xBC")]
      public SkillEffect mSkillEffect;
      [Token(Token = "0x4002918")]
      [FieldOffset(Offset = "0xC0")]
      public List<TacticsUnitController.OutputPoint> mOutputPoints;
      [Token(Token = "0x4002919")]
      [FieldOffset(Offset = "0xC4")]
      public bool UseBattleScene;
      [Token(Token = "0x400291A")]
      [FieldOffset(Offset = "0xC8")]
      public Vector3[] HitGrids;
      [Token(Token = "0x400291B")]
      [FieldOffset(Offset = "0xCC")]
      public List<TacticsUnitController.HitTimer> HitTimers;
      [Token(Token = "0x400291C")]
      [FieldOffset(Offset = "0xD0")]
      public Coroutine HitTimerThread;
      [Token(Token = "0x400291D")]
      [FieldOffset(Offset = "0xD4")]
      public List<TacticsUnitController> HitTargets;
      [Token(Token = "0x400291E")]
      [FieldOffset(Offset = "0xD8")]
      public Grid mLandingGrid;
      [Token(Token = "0x400291F")]
      [FieldOffset(Offset = "0xDC")]
      public Grid mTeleportGrid;
      [Token(Token = "0x4002920")]
      [FieldOffset(Offset = "0xE0")]
      public bool mIsFinishedBuffEffectTarget;
      [Token(Token = "0x4002921")]
      [FieldOffset(Offset = "0xE1")]
      public bool mIsFinishedBuffEffectSelf;
      [Token(Token = "0x4002922")]
      [FieldOffset(Offset = "0xE4")]
      public SkillMotion mSkillMotion;
      [Token(Token = "0x4002923")]
      [FieldOffset(Offset = "0xE8")]
      public List<GameObject> mTargetEffectList;
      [Token(Token = "0x4002924")]
      [FieldOffset(Offset = "0xEC")]
      public List<GameObject> mTargetEffectListForBigUnit;
      [Token(Token = "0x4002925")]
      [FieldOffset(Offset = "0xF0")]
      public List<GameObject> mSelfEffectList;
      [Token(Token = "0x4002926")]
      [FieldOffset(Offset = "0xF4")]
      public SkillBuffEffectParam mBuffEffectParam;

      [Token(Token = "0x60038C6")]
      [Address(RVA = "0x10A54E0", Offset = "0x10A42E0", VA = "0x110A54E0")]
      public SkillVars()
      {
      }
    }

    [Token(Token = "0x2000DDF")]
    public enum EElementEffectTypes
    {
      [Token(Token = "0x4002928")] NotEffective,
      [Token(Token = "0x4002929")] Normal,
      [Token(Token = "0x400292A")] Effective,
    }

    [Token(Token = "0x2000DE0")]
    public class ShieldState
    {
      [Token(Token = "0x400292B")]
      [FieldOffset(Offset = "0x8")]
      public Unit.UnitShield Target;
      [Token(Token = "0x400292C")]
      [FieldOffset(Offset = "0xC")]
      public int LastHP;
      [Token(Token = "0x400292D")]
      [FieldOffset(Offset = "0x10")]
      public int LastTurn;
      [Token(Token = "0x400292E")]
      [FieldOffset(Offset = "0x14")]
      public bool Dirty;

      [Token(Token = "0x60038C7")]
      [Address(RVA = "0x10A4D10", Offset = "0x10A3B10", VA = "0x110A4D10")]
      public void ClearDirty()
      {
      }

      [Token(Token = "0x60038C8")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ShieldState()
      {
      }
    }

    [Token(Token = "0x2000DE1")]
    private class ShakeUnit
    {
      [Token(Token = "0x400292F")]
      [FieldOffset(Offset = "0x8")]
      private Vector3 mShakeBasePos;
      [Token(Token = "0x4002930")]
      [FieldOffset(Offset = "0x14")]
      private Vector3 mShakeOffset;
      [Token(Token = "0x4002931")]
      [FieldOffset(Offset = "0x20")]
      private float mShakeSpeed;
      [Token(Token = "0x4002932")]
      [FieldOffset(Offset = "0x24")]
      private int mShakeMaxCount;
      [Token(Token = "0x4002933")]
      [FieldOffset(Offset = "0x28")]
      private int mShakeCount;
      [Token(Token = "0x4002934")]
      [FieldOffset(Offset = "0x2C")]
      private bool mIsShakeStart;

      [Token(Token = "0x170003EC")]
      public bool ShakeStart
      {
        [Token(Token = "0x60038C9"), Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", VA = "0x104A9DB0")] set
        {
        }
        [Token(Token = "0x60038CA"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x170003ED")]
      public int ShakeMaxCount
      {
        [Token(Token = "0x60038CB"), Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")] set
        {
        }
        [Token(Token = "0x60038CC"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x170003EE")]
      public int ShakeCount
      {
        [Token(Token = "0x60038CD"), Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")] set
        {
        }
        [Token(Token = "0x60038CE"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x60038CF")]
      [Address(RVA = "0x10A4BF0", Offset = "0x10A39F0", VA = "0x110A4BF0")]
      public void Init(Vector3 basePosition, Vector3 direction)
      {
      }

      [Token(Token = "0x60038D0")]
      [Address(RVA = "0x10A4B10", Offset = "0x10A3910", VA = "0x110A4B10")]
      public Vector3 AdvanceShake() => new Vector3();

      [Token(Token = "0x60038D1")]
      [Address(RVA = "0x10A4CE0", Offset = "0x10A3AE0", VA = "0x110A4CE0")]
      public ShakeUnit()
      {
      }
    }

    [Token(Token = "0x2000DE2")]
    private struct HitTimer
    {
      [Token(Token = "0x4002935")]
      [FieldOffset(Offset = "0x0")]
      public TacticsUnitController Target;
      [Token(Token = "0x4002936")]
      [FieldOffset(Offset = "0x4")]
      public float HitTime;

      [Token(Token = "0x60038D2")]
      [Address(RVA = "0x10A1BF0", Offset = "0x10A09F0", VA = "0x110A1BF0")]
      public HitTimer(TacticsUnitController target, float hitTime)
      {
      }
    }

    [Token(Token = "0x2000DE3")]
    [Flags]
    public enum DeathAnimationTypes
    {
      [Token(Token = "0x4002938")] Normal = 1,
    }

    [Token(Token = "0x2000DE4")]
    private class State_Dead : TacticsUnitController.State
    {
      [Token(Token = "0x60038D3")]
      [Address(RVA = "0x10A6230", Offset = "0x10A5030", VA = "0x110A6230", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038D4")]
      [Address(RVA = "0x10A6300", Offset = "0x10A5100", VA = "0x110A6300", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038D5")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_Dead()
      {
      }
    }

    [Token(Token = "0x2000DE5")]
    private delegate void ProjectileStopEvent(TacticsUnitController.ProjectileData pd);

    [Token(Token = "0x2000DE6")]
    private class State_Kirimomi : TacticsUnitController.State
    {
      [Token(Token = "0x4002939")]
      [FieldOffset(Offset = "0xC")]
      private Quaternion mRotationOld;

      [Token(Token = "0x60038DA")]
      [Address(RVA = "0x10A8CE0", Offset = "0x10A7AE0", VA = "0x110A8CE0", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038DB")]
      [Address(RVA = "0x10A8D80", Offset = "0x10A7B80", VA = "0x110A8D80", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038DC")]
      [Address(RVA = "0x10A8D30", Offset = "0x10A7B30", VA = "0x110A8D30", Slot = "6")]
      public override void End(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038DD")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_Kirimomi()
      {
      }
    }

    [Token(Token = "0x2000DE7")]
    private class State_Down : TacticsUnitController.State
    {
      [Token(Token = "0x60038DE")]
      [Address(RVA = "0x10A64E0", Offset = "0x10A52E0", VA = "0x110A64E0", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038DF")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public override void End(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038E0")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_Down()
      {
      }
    }

    [Token(Token = "0x2000DE8")]
    private class State_Dodge : TacticsUnitController.State
    {
      [Token(Token = "0x60038E1")]
      [Address(RVA = "0x10A63F0", Offset = "0x10A51F0", VA = "0x110A63F0", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038E2")]
      [Address(RVA = "0x10A6470", Offset = "0x10A5270", VA = "0x110A6470", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038E3")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_Dodge()
      {
      }
    }

    [Token(Token = "0x2000DE9")]
    private class State_NormalDamage : TacticsUnitController.State
    {
      [Token(Token = "0x60038E4")]
      [Address(RVA = "0x10A9ED0", Offset = "0x10A8CD0", VA = "0x110A9ED0", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038E5")]
      [Address(RVA = "0x10A9F30", Offset = "0x10A8D30", VA = "0x110A9F30", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038E6")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_NormalDamage()
      {
      }
    }

    [Token(Token = "0x2000DEA")]
    private class State_SkillChant : TacticsUnitController.State
    {
      [Token(Token = "0x400293A")]
      [FieldOffset(Offset = "0xC")]
      private TacticsUnitController.CameraState mStartCameraState;

      [Token(Token = "0x60038E7")]
      [Address(RVA = "0x10AB0F0", Offset = "0x10A9EF0", VA = "0x110AB0F0", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038E8")]
      [Address(RVA = "0x10AB2E0", Offset = "0x10AA0E0", VA = "0x110AB2E0", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038E9")]
      [Address(RVA = "0x10AB2A0", Offset = "0x10AA0A0", VA = "0x110AB2A0", Slot = "6")]
      public override void End(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038EA")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_SkillChant()
      {
      }
    }

    [Token(Token = "0x2000DEB")]
    private class State_Skill : TacticsUnitController.State
    {
      [Token(Token = "0x400293B")]
      [FieldOffset(Offset = "0xC")]
      private TacticsUnitController.CameraState mStartCameraState;
      [Token(Token = "0x400293C")]
      [FieldOffset(Offset = "0x28")]
      private Quaternion mTargetRotation;
      [Token(Token = "0x400293D")]
      [FieldOffset(Offset = "0x38")]
      private float mWaitTime;
      [Token(Token = "0x400293E")]
      [FieldOffset(Offset = "0x3C")]
      private bool mIsProcessed;

      [Token(Token = "0x60038EB")]
      [Address(RVA = "0x10AB7D0", Offset = "0x10AA5D0", VA = "0x110AB7D0", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038EC")]
      [Address(RVA = "0x10AB980", Offset = "0x10AA780", VA = "0x110AB980", Slot = "6")]
      public override void End(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038ED")]
      [Address(RVA = "0x10AB9C0", Offset = "0x10AA7C0", VA = "0x110AB9C0", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038EE")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_Skill()
      {
      }
    }

    [Token(Token = "0x2000DEC")]
    private class State_SkillEnd : TacticsUnitController.State
    {
      [Token(Token = "0x60038EF")]
      [Address(RVA = "0x10AB6C0", Offset = "0x10AA4C0", VA = "0x110AB6C0", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038F0")]
      [Address(RVA = "0x10AB760", Offset = "0x10AA560", VA = "0x110AB760", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038F1")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_SkillEnd()
      {
      }
    }

    [Token(Token = "0x2000DED")]
    private class State_RangedSkillEnd : TacticsUnitController.State
    {
      [Token(Token = "0x400293F")]
      [FieldOffset(Offset = "0xC")]
      private float mAnimationLength;
      [Token(Token = "0x4002940")]
      [FieldOffset(Offset = "0x10")]
      private float mStateTime;
      [Token(Token = "0x4002941")]
      [FieldOffset(Offset = "0x14")]
      private bool mUnitAnimationEnded;
      [Token(Token = "0x4002942")]
      [FieldOffset(Offset = "0x15")]
      private bool mHit;
      [Token(Token = "0x4002943")]
      [FieldOffset(Offset = "0x16")]
      private bool mProjEndAnimEnded;

      [Token(Token = "0x60038F2")]
      [Address(RVA = "0x10AA6E0", Offset = "0x10A94E0", VA = "0x110AA6E0", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038F3")]
      [Address(RVA = "0x10AA7C0", Offset = "0x10A95C0", VA = "0x110AA7C0", Slot = "6")]
      public override void End(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038F4")]
      [Address(RVA = "0x10AA7F0", Offset = "0x10A95F0", VA = "0x110AA7F0")]
      private void OnHit(TacticsUnitController.ProjectileData pd)
      {
      }

      [Token(Token = "0x60038F5")]
      [Address(RVA = "0x10AA820", Offset = "0x10A9620", VA = "0x110AA820", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038F6")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_RangedSkillEnd()
      {
      }
    }

    [Token(Token = "0x2000DEE")]
    private class State_PreSkill : TacticsUnitController.State
    {
      [Token(Token = "0x60038F7")]
      [Address(RVA = "0x10AA580", Offset = "0x10A9380", VA = "0x110AA580", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038F8")]
      [Address(RVA = "0x10AA5E0", Offset = "0x10A93E0", VA = "0x110AA5E0", Slot = "6")]
      public override void End(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038F9")]
      [Address(RVA = "0x10AA610", Offset = "0x10A9410", VA = "0x110AA610", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038FA")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_PreSkill()
      {
      }
    }

    [Token(Token = "0x2000DEF")]
    private class State_JumpCast : TacticsUnitController.State
    {
      [Token(Token = "0x4002944")]
      [FieldOffset(Offset = "0xC")]
      private float mBasePosY;
      [Token(Token = "0x4002945")]
      [FieldOffset(Offset = "0x10")]
      private float mCastTime;
      [Token(Token = "0x4002946")]
      [FieldOffset(Offset = "0x14")]
      private float mElapsed;

      [Token(Token = "0x60038FB")]
      [Address(RVA = "0x10A8AC0", Offset = "0x10A78C0", VA = "0x110A8AC0", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038FC")]
      [Address(RVA = "0x10A8BE0", Offset = "0x10A79E0", VA = "0x110A8BE0", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038FD")]
      [Address(RVA = "0x10A8BB0", Offset = "0x10A79B0", VA = "0x110A8BB0", Slot = "6")]
      public override void End(TacticsUnitController self)
      {
      }

      [Token(Token = "0x60038FE")]
      [Address(RVA = "0x10A8A80", Offset = "0x10A7880", VA = "0x110A8A80")]
      public State_JumpCast()
      {
      }
    }

    [Token(Token = "0x2000DF0")]
    private class State_JumpCastFall : TacticsUnitController.State
    {
      [Token(Token = "0x4002947")]
      [FieldOffset(Offset = "0xC")]
      private float mBasePosY;
      [Token(Token = "0x4002948")]
      [FieldOffset(Offset = "0x10")]
      private float mCastTime;
      [Token(Token = "0x4002949")]
      [FieldOffset(Offset = "0x14")]
      private float mElapsed;
      [Token(Token = "0x400294A")]
      [FieldOffset(Offset = "0x18")]
      private TacticsUnitController.State_JumpCastFall.eMotionMode mMotionMode;

      [Token(Token = "0x60038FF")]
      [Address(RVA = "0x10A8700", Offset = "0x10A7500", VA = "0x110A8700", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x6003900")]
      [Address(RVA = "0x10A8820", Offset = "0x10A7620", VA = "0x110A8820", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x6003901")]
      [Address(RVA = "0x10A8800", Offset = "0x10A7600", VA = "0x110A8800", Slot = "6")]
      public override void End(TacticsUnitController self)
      {
      }

      [Token(Token = "0x6003902")]
      [Address(RVA = "0x10A8A80", Offset = "0x10A7880", VA = "0x110A8A80")]
      public State_JumpCastFall()
      {
      }

      [Token(Token = "0x2000DF1")]
      private enum eMotionMode
      {
        [Token(Token = "0x400294C")] Fall,
        [Token(Token = "0x400294D")] Damage,
      }
    }

    [Token(Token = "0x2000DF2")]
    private class State_JumpCastComplete : TacticsUnitController.State
    {
      [Token(Token = "0x400294E")]
      [FieldOffset(Offset = "0xC")]
      private TacticsUnitController.State_JumpCastComplete.MotionMode Mode;
      [Token(Token = "0x400294F")]
      [FieldOffset(Offset = "0x10")]
      private GameObject mFallEffect;
      [Token(Token = "0x4002950")]
      [FieldOffset(Offset = "0x14")]
      private GameObject mHitEffect;
      [Token(Token = "0x4002951")]
      [FieldOffset(Offset = "0x18")]
      private Vector3 mBasePos;
      [Token(Token = "0x4002952")]
      [FieldOffset(Offset = "0x24")]
      private IntVector2 mBaseMapPos;
      [Token(Token = "0x4002953")]
      [FieldOffset(Offset = "0x2C")]
      private float mCastTime;
      [Token(Token = "0x4002954")]
      [FieldOffset(Offset = "0x30")]
      private float mElapsed;
      [Token(Token = "0x4002955")]
      [FieldOffset(Offset = "0x34")]
      private TacticsUnitController[] mExcludes;
      [Token(Token = "0x4002956")]
      [FieldOffset(Offset = "0x0")]
      private static readonly Color SceneFadeColor;
      [Token(Token = "0x4002957")]
      [FieldOffset(Offset = "0x38")]
      private float mFallStartWait;
      [Token(Token = "0x4002958")]
      [FieldOffset(Offset = "0x3C")]
      private float TransStartTime;
      [Token(Token = "0x4002959")]
      [FieldOffset(Offset = "0x40")]
      private float TransWaitTime;
      [Token(Token = "0x400295A")]
      [FieldOffset(Offset = "0x44")]
      private bool beforeVisible;
      [Token(Token = "0x400295B")]
      [FieldOffset(Offset = "0x48")]
      private float ReturnTime;
      [Token(Token = "0x400295C")]
      [FieldOffset(Offset = "0x4C")]
      private bool isDirect;

      [Token(Token = "0x6003903")]
      [Address(RVA = "0x10A7560", Offset = "0x10A6360", VA = "0x110A7560", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x6003904")]
      [Address(RVA = "0x10A8330", Offset = "0x10A7130", VA = "0x110A8330")]
      private void FallWaitUpdate(TacticsUnitController self)
      {
      }

      [Token(Token = "0x6003905")]
      [Address(RVA = "0x10A78E0", Offset = "0x10A66E0", VA = "0x110A78E0")]
      private void EnterFall()
      {
      }

      [Token(Token = "0x6003906")]
      [Address(RVA = "0x10A7F70", Offset = "0x10A6D70", VA = "0x110A7F70")]
      private void FallUpdate(TacticsUnitController self)
      {
      }

      [Token(Token = "0x6003907")]
      [Address(RVA = "0x10A7B40", Offset = "0x10A6940", VA = "0x110A7B40")]
      private void EnterReturn()
      {
      }

      [Token(Token = "0x6003908")]
      [Address(RVA = "0x10A8380", Offset = "0x10A7180", VA = "0x110A8380")]
      private void ReturnUpdate(TacticsUnitController self)
      {
      }

      [Token(Token = "0x6003909")]
      [Address(RVA = "0x10A85E0", Offset = "0x10A73E0", VA = "0x110A85E0", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x600390A")]
      [Address(RVA = "0x10A7880", Offset = "0x10A6680", VA = "0x110A7880", Slot = "6")]
      public override void End(TacticsUnitController self)
      {
      }

      [Token(Token = "0x600390B")]
      [Address(RVA = "0x10A86A0", Offset = "0x10A74A0", VA = "0x110A86A0")]
      public State_JumpCastComplete()
      {
      }

      [Token(Token = "0x600390C")]
      [Address(RVA = "0x10A8670", Offset = "0x10A7470", VA = "0x110A8670")]
      static State_JumpCastComplete()
      {
      }

      [Token(Token = "0x2000DF3")]
      private enum MotionMode
      {
        [Token(Token = "0x400295E")] FALL_WAIT,
        [Token(Token = "0x400295F")] FALL,
        [Token(Token = "0x4002960")] RETURN,
      }
    }

    [Token(Token = "0x2000DF4")]
    private class State_ChangeGrid : TacticsUnitController.State
    {
      [Token(Token = "0x4002961")]
      [FieldOffset(Offset = "0xC")]
      private bool mChanged;
      [Token(Token = "0x4002962")]
      [FieldOffset(Offset = "0xD")]
      private bool mStartEffect;
      [Token(Token = "0x4002963")]
      [FieldOffset(Offset = "0x10")]
      private GameObject mSelfEffect;
      [Token(Token = "0x4002964")]
      [FieldOffset(Offset = "0x14")]
      private GameObject mTargetEffect;
      [Token(Token = "0x4002965")]
      [FieldOffset(Offset = "0x18")]
      private ParticleSystem mSelfParticle;

      [Token(Token = "0x600390D")]
      [Address(RVA = "0x10A5A60", Offset = "0x10A4860", VA = "0x110A5A60")]
      private GameObject CreateEffect(GameObject EffectPrefab, TacticsUnitController Parent)
      {
        return (GameObject) null;
      }

      [Token(Token = "0x600390E")]
      [Address(RVA = "0x10A5800", Offset = "0x10A4600", VA = "0x110A5800")]
      private DelayedEffectSpawner CreateEffect(
        SkillEffect.EffectElement[] effects,
        TacticsUnitController Parent,
        bool set_rotation = false,
        float rotationY = 0.0f)
      {
        return (DelayedEffectSpawner) null;
      }

      [Token(Token = "0x600390F")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
      private void ChangePosition()
      {
      }

      [Token(Token = "0x6003910")]
      [Address(RVA = "0x10A5740", Offset = "0x10A4540", VA = "0x110A5740", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x6003911")]
      [Address(RVA = "0x10A6170", Offset = "0x10A4F70", VA = "0x110A6170")]
      private IEnumerator Wait(float Seconds, TacticsUnitController self) => (IEnumerator) null;

      [Token(Token = "0x6003912")]
      [Address(RVA = "0x10A5BB0", Offset = "0x10A49B0", VA = "0x110A5BB0")]
      private IEnumerator EffectEndWait(float Seconds, TacticsUnitController self)
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x6003913")]
      [Address(RVA = "0x10A5C20", Offset = "0x10A4A20", VA = "0x110A5C20", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x6003914")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public override void End(TacticsUnitController self)
      {
      }

      [Token(Token = "0x6003915")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_ChangeGrid()
      {
      }
    }

    [Token(Token = "0x2000DF7")]
    private enum eKnockBackMode
    {
      [Token(Token = "0x4002970")] IDLE,
      [Token(Token = "0x4002971")] START,
      [Token(Token = "0x4002972")] EXEC,
    }

    [Token(Token = "0x2000DF8")]
    private class State_Throw : TacticsUnitController.State
    {
      [Token(Token = "0x4002973")]
      private const float START_WAIT_TIME = 0.1f;
      [Token(Token = "0x4002974")]
      private const float TURN_WAIT_TIME = 0.1f;
      [Token(Token = "0x4002975")]
      private const float ACC_WAIT_TIME = 0.3f;
      [Token(Token = "0x4002976")]
      private const float FINISH_WAIT_TIME = 0.2f;
      [Token(Token = "0x4002977")]
      [FieldOffset(Offset = "0xC")]
      private SceneBattle mSceneBattle;
      [Token(Token = "0x4002978")]
      [FieldOffset(Offset = "0x10")]
      private TacticsUnitController mTargetTuc;

      [Token(Token = "0x6003922")]
      [Address(RVA = "0x10AC350", Offset = "0x10AB150", VA = "0x110AC350", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x6003923")]
      [Address(RVA = "0x10AC550", Offset = "0x10AB350", VA = "0x110AC550")]
      private IEnumerator execPerformance(TacticsUnitController self) => (IEnumerator) null;

      [Token(Token = "0x6003924")]
      [Address(RVA = "0x10AC700", Offset = "0x10AB500", VA = "0x110AC700")]
      private IEnumerator lerpTurn(TacticsUnitController target, Vector3 target_pos)
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x6003925")]
      [Address(RVA = "0x10AC620", Offset = "0x10AB420", VA = "0x110AC620")]
      private IEnumerator lerpPickUp(TacticsUnitController self, TacticsUnitController target)
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x6003926")]
      [Address(RVA = "0x10AC690", Offset = "0x10AB490", VA = "0x110AC690")]
      private IEnumerator lerpThrow(TacticsUnitController target, Vector3 target_pos)
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x6003927")]
      [Address(RVA = "0x10AC5C0", Offset = "0x10AB3C0", VA = "0x110AC5C0")]
      private IEnumerator lerpBound(TacticsUnitController target) => (IEnumerator) null;

      [Token(Token = "0x6003928")]
      [Address(RVA = "0x10A61F0", Offset = "0x10A4FF0", VA = "0x110A61F0")]
      public State_Throw()
      {
      }
    }

    [Token(Token = "0x2000DFE")]
    private class State_AfterTransform : TacticsUnitController.State
    {
      [Token(Token = "0x6003947")]
      [Address(RVA = "0x10B7A10", Offset = "0x10B6810", VA = "0x110B7A10", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x6003948")]
      [Address(RVA = "0x10B7A60", Offset = "0x10B6860", VA = "0x110B7A60", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x6003949")]
      [Address(RVA = "0x10B7AD0", Offset = "0x10B68D0", VA = "0x110B7AD0")]
      public State_AfterTransform()
      {
      }
    }

    [Token(Token = "0x2000DFF")]
    private class State_PreAfterTransform : TacticsUnitController.State
    {
      [Token(Token = "0x600394A")]
      [Address(RVA = "0x10B7BE0", Offset = "0x10B69E0", VA = "0x110B7BE0", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x600394B")]
      [Address(RVA = "0x10B7C30", Offset = "0x10B6A30", VA = "0x110B7C30", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x600394C")]
      [Address(RVA = "0x10B7AD0", Offset = "0x10B68D0", VA = "0x110B7AD0")]
      public State_PreAfterTransform()
      {
      }
    }

    [Token(Token = "0x2000E00")]
    private class State_BigUnitBsIdle : TacticsUnitController.State
    {
      [Token(Token = "0x600394D")]
      [Address(RVA = "0x10B7B90", Offset = "0x10B6990", VA = "0x110B7B90", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x600394E")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x600394F")]
      [Address(RVA = "0x10B7AD0", Offset = "0x10B68D0", VA = "0x110B7AD0")]
      public State_BigUnitBsIdle()
      {
      }
    }

    [Token(Token = "0x2000E01")]
    private class State_BigUnitBsDamage : TacticsUnitController.State
    {
      [Token(Token = "0x6003950")]
      [Address(RVA = "0x10B7AE0", Offset = "0x10B68E0", VA = "0x110B7AE0", Slot = "4")]
      public override void Begin(TacticsUnitController self)
      {
      }

      [Token(Token = "0x6003951")]
      [Address(RVA = "0x10B7B30", Offset = "0x10B6930", VA = "0x110B7B30", Slot = "5")]
      public override void Update(TacticsUnitController self)
      {
      }

      [Token(Token = "0x6003952")]
      [Address(RVA = "0x10B7AD0", Offset = "0x10B68D0", VA = "0x110B7AD0")]
      public State_BigUnitBsDamage()
      {
      }
    }
  }
}
