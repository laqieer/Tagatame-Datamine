// Decompiled with JetBrains decompiler
// Type: SRPG.TrickData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011DA")]
  public class TrickData
  {
    [Token(Token = "0x40040E0")]
    [FieldOffset(Offset = "0x8")]
    private TrickParam mTrickParam;
    [Token(Token = "0x40040E1")]
    [FieldOffset(Offset = "0xC")]
    private BuffEffect mBuffEffect;
    [Token(Token = "0x40040E2")]
    [FieldOffset(Offset = "0x10")]
    private CondEffect mCondEffect;
    [Token(Token = "0x40040E3")]
    [FieldOffset(Offset = "0x14")]
    private OBool mValid;
    [Token(Token = "0x40040E4")]
    [FieldOffset(Offset = "0x20")]
    private Unit mCreateUnit;
    [Token(Token = "0x40040E5")]
    [FieldOffset(Offset = "0x24")]
    private OInt mRank;
    [Token(Token = "0x40040E6")]
    [FieldOffset(Offset = "0x38")]
    private OInt mRankCap;
    [Token(Token = "0x40040E7")]
    [FieldOffset(Offset = "0x4C")]
    private OInt mGridX;
    [Token(Token = "0x40040E8")]
    [FieldOffset(Offset = "0x60")]
    private OInt mGridY;
    [Token(Token = "0x40040E9")]
    [FieldOffset(Offset = "0x74")]
    private OInt mRestActionCount;
    [Token(Token = "0x40040EA")]
    [FieldOffset(Offset = "0x88")]
    private OInt mCreateClock;
    [Token(Token = "0x40040EB")]
    [FieldOffset(Offset = "0x9C")]
    private string mTag;
    [Token(Token = "0x40040EC")]
    [FieldOffset(Offset = "0x0")]
    private static List<TrickData> mTrickDataLists;
    [Token(Token = "0x40040ED")]
    [FieldOffset(Offset = "0x4")]
    private static Dictionary<TrickData, GameObject> mTrickMarkerLists;
    [Token(Token = "0x40040EE")]
    [FieldOffset(Offset = "0xA0")]
    private EUnitDirection[] reverseDirection;

    [Token(Token = "0x17000853")]
    public TrickParam TrickParam
    {
      [Token(Token = "0x6004B87"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (TrickParam) null;
      }
    }

    [Token(Token = "0x17000854")]
    public BuffEffect BuffEffect
    {
      [Token(Token = "0x6004B88"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (BuffEffect) null;
      }
    }

    [Token(Token = "0x17000855")]
    public CondEffect CondEffect
    {
      [Token(Token = "0x6004B89"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (CondEffect) null;
      }
    }

    [Token(Token = "0x17000856")]
    public OBool Valid
    {
      [Token(Token = "0x6004B8A"), Address(RVA = "0x1212250", Offset = "0x1211050", VA = "0x11212250")] get
      {
        return new OBool();
      }
    }

    [Token(Token = "0x17000857")]
    public Unit CreateUnit
    {
      [Token(Token = "0x6004B8B"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (Unit) null;
      }
    }

    [Token(Token = "0x17000858")]
    public OInt Rank
    {
      [Token(Token = "0x6004B8C"), Address(RVA = "0x1212230", Offset = "0x1211030", VA = "0x11212230")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17000859")]
    public OInt RankCap
    {
      [Token(Token = "0x6004B8D"), Address(RVA = "0x3A6630", Offset = "0x3A5430", VA = "0x103A6630")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x1700085A")]
    public OInt GridX
    {
      [Token(Token = "0x6004B8E"), Address(RVA = "0x3A6650", Offset = "0x3A5450", VA = "0x103A6650")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x1700085B")]
    public OInt GridY
    {
      [Token(Token = "0x6004B8F"), Address(RVA = "0x1212210", Offset = "0x1211010", VA = "0x11212210")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x1700085C")]
    public OInt RestActionCount
    {
      [Token(Token = "0x6004B90"), Address(RVA = "0xFC51D0", Offset = "0xFC3FD0", VA = "0x10FC51D0")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x1700085D")]
    public OInt CreateClock
    {
      [Token(Token = "0x6004B91"), Address(RVA = "0xFC49A0", Offset = "0xFC37A0", VA = "0x10FC49A0")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x1700085E")]
    public string Tag
    {
      [Token(Token = "0x6004B92"), Address(RVA = "0x37DBB0", Offset = "0x37C9B0", VA = "0x1037DBB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6004B93")]
    [Address(RVA = "0x1212270", Offset = "0x1211070", VA = "0x11212270")]
    private void setup(
      string iname,
      int grid_x,
      int grid_y,
      string tag,
      Unit creator,
      int create_clock,
      int rank,
      int rankcap)
    {
    }

    [Token(Token = "0x6004B94")]
    [Address(RVA = "0x1210550", Offset = "0x120F350", VA = "0x11210550")]
    private bool actionEffectTurnStart(List<Unit> target_lists, RandXorshift rand) => new bool();

    [Token(Token = "0x6004B95")]
    [Address(RVA = "0x120F830", Offset = "0x120E630", VA = "0x1120F830")]
    private bool actionBuff(Unit target, EffectCheckTimings chk_timing, RandXorshift rand = null)
    {
      return new bool();
    }

    [Token(Token = "0x6004B96")]
    [Address(RVA = "0x1211300", Offset = "0x1210100", VA = "0x11211300")]
    private BuffAttachment createBuffAttachment(
      Unit target,
      BuffTypes buff_type,
      bool is_negative_value_is_buff,
      SkillParamCalcTypes calc_type,
      BaseStatus status,
      EffectCheckTimings chk_timing)
    {
      return (BuffAttachment) null;
    }

    [Token(Token = "0x6004B97")]
    [Address(RVA = "0x1210330", Offset = "0x120F130", VA = "0x11210330")]
    private bool actionEffectTurnEnd(
      List<Unit> target_lists,
      RandXorshift rand,
      LogMapTrick log_mt)
    {
      return new bool();
    }

    [Token(Token = "0x6004B98")]
    [Address(RVA = "0x1210F40", Offset = "0x120FD40", VA = "0x11210F40")]
    public int calcHeal(Unit target) => new int();

    [Token(Token = "0x6004B99")]
    [Address(RVA = "0x1210680", Offset = "0x120F480", VA = "0x11210680")]
    private bool actionHeal(Unit target, LogMapTrick.TargetInfo log_mt_ti) => new bool();

    [Token(Token = "0x6004B9A")]
    [Address(RVA = "0x1210C30", Offset = "0x120FA30", VA = "0x11210C30")]
    public int calcDamage(Unit target) => new int();

    [Token(Token = "0x6004B9B")]
    [Address(RVA = "0x1210210", Offset = "0x120F010", VA = "0x11210210")]
    private bool actionDamage(Unit target, LogMapTrick.TargetInfo log_mt_ti) => new bool();

    [Token(Token = "0x6004B9C")]
    [Address(RVA = "0x12120D0", Offset = "0x1210ED0", VA = "0x112120D0")]
    private int getRateDamageElement(Unit target) => new int();

    [Token(Token = "0x6004B9D")]
    [Address(RVA = "0x1211F90", Offset = "0x1210D90", VA = "0x11211F90")]
    private int getRateDamageAttackDetail(Unit target) => new int();

    [Token(Token = "0x6004B9E")]
    [Address(RVA = "0x1212120", Offset = "0x1210F20", VA = "0x11212120")]
    private int getRateDamageUnitDefense(Unit target) => new int();

    [Token(Token = "0x6004B9F")]
    [Address(RVA = "0x120FCC0", Offset = "0x120EAC0", VA = "0x1120FCC0")]
    private bool actionCond(Unit target, RandXorshift rand, LogMapTrick.TargetInfo log_mt_ti)
    {
      return new bool();
    }

    [Token(Token = "0x6004BA0")]
    [Address(RVA = "0x1211020", Offset = "0x120FE20", VA = "0x11211020")]
    private bool checkFailCond(
      Unit target,
      int val,
      int resist,
      EUnitCondition condition,
      RandXorshift rand)
    {
      return new bool();
    }

    [Token(Token = "0x6004BA1")]
    [Address(RVA = "0x1211620", Offset = "0x1210420", VA = "0x11211620")]
    private void cureCond(Unit target, EUnitCondition condition, LogMapTrick.TargetInfo log_mt_ti)
    {
    }

    [Token(Token = "0x6004BA2")]
    [Address(RVA = "0x1211D00", Offset = "0x1210B00", VA = "0x11211D00")]
    private void failCond(
      Unit target,
      CondEffect effect,
      ConditionEffectTypes effect_type,
      EUnitCondition condition,
      LogMapTrick.TargetInfo log_mt_ti)
    {
    }

    [Token(Token = "0x6004BA3")]
    [Address(RVA = "0x1211450", Offset = "0x1210250", VA = "0x11211450")]
    private CondAttachment createCondAttachment(
      Unit target,
      CondEffect effect,
      ConditionEffectTypes type,
      EUnitCondition condition,
      EffectCheckTimings chk_timing,
      int damage = 0,
      int cost_jewel = 0,
      int heal_count = 0,
      int mp_damage = 0,
      int jewel_max = 0)
    {
      return (CondAttachment) null;
    }

    [Token(Token = "0x6004BA4")]
    [Address(RVA = "0x12107D0", Offset = "0x120F5D0", VA = "0x112107D0")]
    private bool actionKnockBack(Unit target, RandXorshift rand, LogMapTrick.TargetInfo log_mt_ti)
    {
      return new bool();
    }

    [Token(Token = "0x6004BA5")]
    [Address(RVA = "0x1211070", Offset = "0x120FE70", VA = "0x11211070")]
    private bool checkKnockBack(Unit target, RandXorshift rand) => new bool();

    [Token(Token = "0x6004BA6")]
    [Address(RVA = "0x1211130", Offset = "0x120FF30", VA = "0x11211130")]
    private bool checkTarget(Unit target, bool is_eff = false) => new bool();

    [Token(Token = "0x6004BA7")]
    [Address(RVA = "0x1211280", Offset = "0x1210080", VA = "0x11211280")]
    private bool checkTiming(EffectCheckTimings chk_timing) => new bool();

    [Token(Token = "0x6004BA8")]
    [Address(RVA = "0x12116A0", Offset = "0x12104A0", VA = "0x112116A0")]
    private void decActionCount()
    {
    }

    [Token(Token = "0x6004BA9")]
    [Address(RVA = "0x120E7C0", Offset = "0x120D5C0", VA = "0x1120E7C0")]
    public bool IsVisualized() => new bool();

    [Token(Token = "0x6004BAA")]
    [Address(RVA = "0x120E400", Offset = "0x120D200", VA = "0x1120E400")]
    public static void ClearEffect()
    {
    }

    [Token(Token = "0x6004BAB")]
    [Address(RVA = "0x120E650", Offset = "0x120D450", VA = "0x1120E650")]
    public static List<TrickData> GetEffectAll() => (List<TrickData>) null;

    [Token(Token = "0x6004BAC")]
    [Address(RVA = "0x120EE70", Offset = "0x120DC70", VA = "0x1120EE70")]
    public static TrickData SearchEffect(int grid_x, int grid_y, bool is_reinforcement = false)
    {
      return (TrickData) null;
    }

    [Token(Token = "0x6004BAD")]
    [Address(RVA = "0x120E690", Offset = "0x120D490", VA = "0x1120E690")]
    public static bool IsOnEffect(Unit unit, bool is_reinforcement) => new bool();

    [Token(Token = "0x6004BAE")]
    [Address(RVA = "0x120E470", Offset = "0x120D270", VA = "0x1120E470")]
    public static TrickData EntryEffect(
      string iname,
      int grid_x,
      int grid_y,
      string tag,
      Unit creator = null,
      int create_clock = 0,
      int rank = 1,
      int rankcap = 1)
    {
      return (TrickData) null;
    }

    [Token(Token = "0x6004BAF")]
    [Address(RVA = "0x120EF80", Offset = "0x120DD80", VA = "0x1120EF80")]
    public static TrickData SuspendEffect(
      string iname,
      int grid_x,
      int grid_y,
      string tag,
      Unit creator,
      int create_clock,
      int rank,
      int rankcap,
      int rest_count)
    {
      return (TrickData) null;
    }

    [Token(Token = "0x6004BB0")]
    [Address(RVA = "0x120E930", Offset = "0x120D730", VA = "0x1120E930")]
    public static bool RemoveEffect(TrickData trick_data) => new bool();

    [Token(Token = "0x6004BB1")]
    [Address(RVA = "0x120EA60", Offset = "0x120D860", VA = "0x1120EA60")]
    public static void RemoveEffect(int grid_x, int grid_y)
    {
    }

    [Token(Token = "0x6004BB2")]
    [Address(RVA = "0x120DF40", Offset = "0x120CD40", VA = "0x1120DF40")]
    public static bool CheckClock(int now_clock) => new bool();

    [Token(Token = "0x6004BB3")]
    [Address(RVA = "0x120D230", Offset = "0x120C030", VA = "0x1120D230")]
    public static void ActionEffect(
      eTrickActionTiming action_timing,
      Unit target,
      int grid_x,
      int grid_y,
      RandXorshift rand,
      LogMapTrick log_mt = null)
    {
    }

    [Token(Token = "0x6004BB4")]
    [Address(RVA = "0x1210A30", Offset = "0x120F830", VA = "0x11210A30")]
    private static void addTargetAreaEff(
      int grid_x,
      int grid_y,
      TrickData trick_data,
      List<Unit> target_lists)
    {
    }

    [Token(Token = "0x6004BB5")]
    [Address(RVA = "0x120E830", Offset = "0x120D630", VA = "0x1120E830")]
    public static bool MomentBuff(
      Unit target,
      int grid_x,
      int grid_y,
      EffectCheckTimings chk_timing = EffectCheckTimings.Moment)
    {
      return new bool();
    }

    [Token(Token = "0x6004BB6")]
    [Address(RVA = "0x120F010", Offset = "0x120DE10", VA = "0x1120F010")]
    public static void UpdateMarker()
    {
    }

    [Token(Token = "0x6004BB7")]
    [Address(RVA = "0x120D9A0", Offset = "0x120C7A0", VA = "0x1120D9A0")]
    public static void AddMarker()
    {
    }

    [Token(Token = "0x6004BB8")]
    [Address(RVA = "0x1211770", Offset = "0x1210570", VA = "0x11211770")]
    private static void entryMarker(SceneBattle sb, TrickData td)
    {
    }

    [Token(Token = "0x6004BB9")]
    [Address(RVA = "0x120E250", Offset = "0x120D050", VA = "0x1120E250")]
    public static bool CheckRemoveMarker(TrickData trick_data) => new bool();

    [Token(Token = "0x6004BBA")]
    [Address(RVA = "0x120F350", Offset = "0x120E150", VA = "0x1120F350")]
    public static void UpdateMarker(
      Transform parent,
      Dictionary<string, GameObject> trickObj,
      GameObject baseObj)
    {
    }

    [Token(Token = "0x6004BBB")]
    [Address(RVA = "0x120D490", Offset = "0x120C290", VA = "0x1120D490")]
    public static void AddMarker(
      Transform parent,
      Dictionary<string, GameObject> trickObj,
      GameObject baseObj)
    {
    }

    [Token(Token = "0x6004BBC")]
    [Address(RVA = "0x12119F0", Offset = "0x12107F0", VA = "0x112119F0")]
    private static void entryMarker(
      Transform parent,
      TrickData td,
      Dictionary<string, GameObject> dic,
      GameObject baseObj)
    {
    }

    [Token(Token = "0x6004BBD")]
    [Address(RVA = "0x120F760", Offset = "0x120E560", VA = "0x1120F760")]
    public TrickData()
    {
    }

    [Token(Token = "0x6004BBE")]
    [Address(RVA = "0x120F690", Offset = "0x120E490", VA = "0x1120F690")]
    static TrickData()
    {
    }
  }
}
