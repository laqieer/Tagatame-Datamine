// Decompiled with JetBrains decompiler
// Type: SRPG.WeatherData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011E1")]
  public class WeatherData
  {
    [Token(Token = "0x400410D")]
    private const int WEATHER_CHANGE_ETERNAL = 999;
    [Token(Token = "0x400410E")]
    private const int MAP_WEATHER_RELEASE_ETERNAL = 0;
    [Token(Token = "0x400410F")]
    private const int CONDITION_RESIST_MAX = 999;
    [Token(Token = "0x4004110")]
    [FieldOffset(Offset = "0x8")]
    private WeatherParam mWeatherParam;
    [Token(Token = "0x4004111")]
    [FieldOffset(Offset = "0xC")]
    private List<BuffEffect> mBuffEffectLists;
    [Token(Token = "0x4004112")]
    [FieldOffset(Offset = "0x10")]
    private List<CondEffect> mCondEffectLists;
    [Token(Token = "0x4004113")]
    [FieldOffset(Offset = "0x14")]
    private int mModifyUnitIndex;
    [Token(Token = "0x4004114")]
    [FieldOffset(Offset = "0x18")]
    private Unit mModifyUnit;
    [Token(Token = "0x4004115")]
    [FieldOffset(Offset = "0x1C")]
    private OInt mRank;
    [Token(Token = "0x4004116")]
    [FieldOffset(Offset = "0x30")]
    private OInt mRankCap;
    [Token(Token = "0x4004117")]
    [FieldOffset(Offset = "0x44")]
    private OInt mFinishClock;
    [Token(Token = "0x4004118")]
    [FieldOffset(Offset = "0x0")]
    private static WeatherSetParam mCurrentWeatherSet;
    [Token(Token = "0x4004119")]
    [FieldOffset(Offset = "0x4")]
    private static bool mIsAllowWeatherChange;
    [Token(Token = "0x400411A")]
    [FieldOffset(Offset = "0x8")]
    private static WeatherData mCurrentWeatherData;
    [Token(Token = "0x400411B")]
    [FieldOffset(Offset = "0xC")]
    private static WeatherData mBattleWeatherData;
    [Token(Token = "0x400411C")]
    [FieldOffset(Offset = "0x10")]
    private static bool mIsEntryConditionLog;
    [Token(Token = "0x400411D")]
    [FieldOffset(Offset = "0x11")]
    private static bool mIsExecuteUpdate;
    [Token(Token = "0x400411E")]
    [FieldOffset(Offset = "0x14")]
    private static List<WeatherData> mRestoreWeatherDatas;
    [Token(Token = "0x400411F")]
    [FieldOffset(Offset = "0x18")]
    private static int mReleaseWeatherFinishClock;

    [Token(Token = "0x17000860")]
    private bool IsEternalWeather
    {
      [Token(Token = "0x6004BCA"), Address(RVA = "0x12276B0", Offset = "0x12264B0", VA = "0x112276B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000861")]
    public WeatherParam WeatherParam
    {
      [Token(Token = "0x6004BCB"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (WeatherParam) null;
      }
    }

    [Token(Token = "0x17000862")]
    public List<BuffEffect> BuffEffectLists
    {
      [Token(Token = "0x6004BCC"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<BuffEffect>) null;
      }
    }

    [Token(Token = "0x17000863")]
    public List<CondEffect> CondEffectLists
    {
      [Token(Token = "0x6004BCD"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<CondEffect>) null;
      }
    }

    [Token(Token = "0x17000864")]
    public Unit ModifyUnit
    {
      [Token(Token = "0x6004BCE"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (Unit) null;
      }
    }

    [Token(Token = "0x17000865")]
    public OInt Rank
    {
      [Token(Token = "0x6004BCF"), Address(RVA = "0x1227710", Offset = "0x1226510", VA = "0x11227710")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17000866")]
    public OInt RankCap
    {
      [Token(Token = "0x6004BD0"), Address(RVA = "0x4791D0", Offset = "0x477FD0", VA = "0x104791D0")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17000867")]
    public OInt FinishClock
    {
      [Token(Token = "0x6004BD1"), Address(RVA = "0x10EEC20", Offset = "0x10EDA20", VA = "0x110EEC20")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17000868")]
    public static WeatherSetParam CurrentWeatherSet
    {
      [Token(Token = "0x6004BD2"), Address(RVA = "0x12275F0", Offset = "0x12263F0", VA = "0x112275F0")] get
      {
        return (WeatherSetParam) null;
      }
    }

    [Token(Token = "0x17000869")]
    public static bool IsAllowWeatherChange
    {
      [Token(Token = "0x6004BD3"), Address(RVA = "0x1227630", Offset = "0x1226430", VA = "0x11227630")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700086A")]
    public static WeatherData CurrentWeatherData
    {
      [Token(Token = "0x6004BD4"), Address(RVA = "0x12275B0", Offset = "0x12263B0", VA = "0x112275B0")] get
      {
        return (WeatherData) null;
      }
    }

    [Token(Token = "0x1700086B")]
    public static bool IsEntryConditionLog
    {
      [Token(Token = "0x6004BD5"), Address(RVA = "0x1227670", Offset = "0x1226470", VA = "0x11227670")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004BD6"), Address(RVA = "0x1227840", Offset = "0x1226640", VA = "0x11227840")] set
      {
      }
    }

    [Token(Token = "0x1700086C")]
    public static bool IsExecuteUpdate
    {
      [Token(Token = "0x6004BD7"), Address(RVA = "0x12276D0", Offset = "0x12264D0", VA = "0x112276D0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004BD8"), Address(RVA = "0x1227890", Offset = "0x1226690", VA = "0x11227890")] set
      {
      }
    }

    [Token(Token = "0x1700086D")]
    public List<WeatherData> RestoreWeatherDatas
    {
      [Token(Token = "0x6004BD9"), Address(RVA = "0x12277A0", Offset = "0x12265A0", VA = "0x112277A0")] get
      {
        return (List<WeatherData>) null;
      }
      [Token(Token = "0x6004BDA"), Address(RVA = "0x12278E0", Offset = "0x12266E0", VA = "0x112278E0")] set
      {
      }
    }

    [Token(Token = "0x1700086E")]
    public static WeatherData BattleWeatherData
    {
      [Token(Token = "0x6004BDB"), Address(RVA = "0x1227550", Offset = "0x1226350", VA = "0x11227550")] get
      {
        return (WeatherData) null;
      }
      [Token(Token = "0x6004BDC"), Address(RVA = "0x12277E0", Offset = "0x12265E0", VA = "0x112277E0")] set
      {
      }
    }

    [Token(Token = "0x1700086F")]
    public static int ReleaseWeatherFinishClock
    {
      [Token(Token = "0x6004BDD"), Address(RVA = "0x1227730", Offset = "0x1226530", VA = "0x11227730")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6004BDE")]
    [Address(RVA = "0x1227940", Offset = "0x1226740", VA = "0x11227940")]
    private void setup(string iname, Unit modify_unit, int rank, int rankcap, int index = -1)
    {
    }

    [Token(Token = "0x6004BDF")]
    [Address(RVA = "0x1226040", Offset = "0x1224E40", VA = "0x11226040")]
    private void updatePassive(Unit target, RandXorshift rand, bool is_disable_trans = false)
    {
    }

    [Token(Token = "0x6004BE0")]
    [Address(RVA = "0x12270F0", Offset = "0x1225EF0", VA = "0x112270F0")]
    private void detachPassive(Unit target)
    {
    }

    [Token(Token = "0x6004BE1")]
    [Address(RVA = "0x12242A0", Offset = "0x12230A0", VA = "0x112242A0")]
    private bool IsWeatherBuffCond(Unit _target) => new bool();

    [Token(Token = "0x6004BE2")]
    [Address(RVA = "0x1226690", Offset = "0x1225490", VA = "0x11226690")]
    private bool attachBuffPassive(Unit target, bool is_predict = false) => new bool();

    [Token(Token = "0x6004BE3")]
    [Address(RVA = "0x1226AA0", Offset = "0x12258A0", VA = "0x11226AA0")]
    private bool attachCond(
      WeatherData.eCondAttachType cond_at_type,
      Unit target,
      RandXorshift rand = null)
    {
      return new bool();
    }

    [Token(Token = "0x6004BE4")]
    [Address(RVA = "0x1224D60", Offset = "0x1223B60", VA = "0x11224D60")]
    private bool SetWeatherCondAttachment(
      CondEffect effect,
      WeatherData.eCondAttachType cond_at_type,
      Unit target,
      RandXorshift rand = null,
      bool is_weather_passive = false)
    {
      return new bool();
    }

    [Token(Token = "0x6004BE5")]
    [Address(RVA = "0x1226E50", Offset = "0x1225C50", VA = "0x11226E50")]
    private bool checkFailCond(
      Unit target,
      int val,
      int resist,
      EUnitCondition condition,
      RandXorshift rand,
      bool is_weather_passive)
    {
      return new bool();
    }

    [Token(Token = "0x6004BE6")]
    [Address(RVA = "0x12270C0", Offset = "0x1225EC0", VA = "0x112270C0")]
    private void cureCond(Unit target, EUnitCondition condition)
    {
    }

    [Token(Token = "0x6004BE7")]
    [Address(RVA = "0x1227280", Offset = "0x1226080", VA = "0x11227280")]
    private void failCond(
      Unit target,
      CondEffect effect,
      ConditionEffectTypes effect_type,
      EUnitCondition condition)
    {
    }

    [Token(Token = "0x6004BE8")]
    [Address(RVA = "0x1226F10", Offset = "0x1225D10", VA = "0x11226F10")]
    private CondAttachment createCondAttachment(
      Unit target,
      CondEffect effect,
      ConditionEffectTypes type,
      EUnitCondition condition)
    {
      return (CondAttachment) null;
    }

    [Token(Token = "0x6004BE9")]
    [Address(RVA = "0x1227440", Offset = "0x1226240", VA = "0x11227440")]
    private CondAttachment getSameCondAttachment(Unit target, CondAttachment new_cond)
    {
      return (CondAttachment) null;
    }

    [Token(Token = "0x6004BEA")]
    [Address(RVA = "0x1223F60", Offset = "0x1222D60", VA = "0x11223F60")]
    private bool IsPassiveBuffTarget(WeatherDetailParam param, Unit target) => new bool();

    [Token(Token = "0x6004BEB")]
    [Address(RVA = "0x12235D0", Offset = "0x12223D0", VA = "0x112235D0")]
    private List<WeatherDetailParam> GetOneTimeWeatherEffectList(
      Unit target_unit,
      SkillData skill_data)
    {
      return (List<WeatherDetailParam>) null;
    }

    [Token(Token = "0x6004BEC")]
    [Address(RVA = "0x1223A30", Offset = "0x1222830", VA = "0x11223A30")]
    private bool IsCheckAttackTypeElement(
      Unit target,
      WeatherDetailParam weather_detail,
      SkillData skill_data,
      bool is_custom_target = false)
    {
      return new bool();
    }

    [Token(Token = "0x6004BED")]
    [Address(RVA = "0x1224340", Offset = "0x1223140", VA = "0x11224340")]
    private bool IsWeatherTarget(Unit target_unit, EWeatherTarget target) => new bool();

    [Token(Token = "0x6004BEE")]
    [Address(RVA = "0x1224230", Offset = "0x1223030", VA = "0x11224230")]
    private bool IsUnitDeadReleaseWeather() => new bool();

    [Token(Token = "0x6004BEF")]
    [Address(RVA = "0x1223320", Offset = "0x1222120", VA = "0x11223320")]
    private static bool ExecuteRestoreWeather(List<Unit> units, int now_clock, RandXorshift rand)
    {
      return new bool();
    }

    [Token(Token = "0x6004BF0")]
    [Address(RVA = "0x12260A0", Offset = "0x1224EA0", VA = "0x112260A0")]
    public void UpdateModifyUnit(Unit new_unit)
    {
    }

    [Token(Token = "0x6004BF1")]
    [Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0")]
    public int GetResistRate(int now_clock) => new int();

    [Token(Token = "0x6004BF2")]
    [Address(RVA = "0x1226040", Offset = "0x1224E40", VA = "0x11226040")]
    public void UnitUpdatePassive(Unit target, RandXorshift rand, bool is_disable_trans = false)
    {
    }

    [Token(Token = "0x6004BF3")]
    [Address(RVA = "0x1223BC0", Offset = "0x12229C0", VA = "0x11223BC0")]
    public bool IsCheckWeatherHit(Unit target_unit, SkillData skill_data, bool is_force_hit)
    {
      return new bool();
    }

    [Token(Token = "0x6004BF4")]
    [Address(RVA = "0x1223230", Offset = "0x1222030", VA = "0x11223230")]
    public bool DetachOneTimeBuff(Unit target) => new bool();

    [Token(Token = "0x6004BF5")]
    [Address(RVA = "0x1221BD0", Offset = "0x12209D0", VA = "0x11221BD0")]
    public bool AttachBuffBySkill(Unit target, SkillData skill_data) => new bool();

    [Token(Token = "0x6004BF6")]
    [Address(RVA = "0x1221F70", Offset = "0x1220D70", VA = "0x11221F70")]
    public bool AttachCondBySkill(Unit self, Unit target, SkillData skill_data, RandXorshift rand = null)
    {
      return new bool();
    }

    [Token(Token = "0x6004BF7")]
    [Address(RVA = "0x1222980", Offset = "0x1221780", VA = "0x11222980")]
    public void CondBySkillPredictResult(
      Unit self,
      Unit target,
      SkillData skill_data,
      RandXorshift rand,
      LogSkill log)
    {
    }

    [Token(Token = "0x6004BF8")]
    [Address(RVA = "0x1225C70", Offset = "0x1224A70", VA = "0x11225C70")]
    public void UnitDeadWeatherRelease(List<Unit> units, int now_clock, RandXorshift rand)
    {
    }

    [Token(Token = "0x6004BF9")]
    [Address(RVA = "0x1223900", Offset = "0x1222700", VA = "0x11223900")]
    public static void Initialize(WeatherSetParam weather_set = null, bool is_allow_weather_change = false)
    {
    }

    [Token(Token = "0x6004BFA")]
    [Address(RVA = "0x12260F0", Offset = "0x1224EF0", VA = "0x112260F0")]
    public static bool UpdateWeather(List<Unit> units, int now_clock, RandXorshift rand = null)
    {
      return new bool();
    }

    [Token(Token = "0x6004BFB")]
    [Address(RVA = "0x1222300", Offset = "0x1221100", VA = "0x11222300")]
    public static WeatherData ChangeWeather(
      string iname,
      List<Unit> units,
      int now_clock,
      RandXorshift rand,
      Unit modify_unit = null,
      int rank = 1,
      int rankcap = 1,
      SkillData skill_data = null,
      int finish_clock = -1)
    {
      return (WeatherData) null;
    }

    [Token(Token = "0x6004BFC")]
    [Address(RVA = "0x1225A90", Offset = "0x1224890", VA = "0x11225A90")]
    public static void SuspendWeather(
      string iname,
      int modify_unit_index,
      Unit modify_unit,
      int rank,
      int rankcap,
      int change_clock,
      int weatherset_finish_clock,
      bool is_restore = false)
    {
    }

    [Token(Token = "0x6004BFD")]
    [Address(RVA = "0x1225590", Offset = "0x1224390", VA = "0x11225590")]
    public static void SuspendDeleteWeatherSet(int weatherset_finish_clock)
    {
    }

    [Token(Token = "0x6004BFE")]
    [Address(RVA = "0x12258A0", Offset = "0x12246A0", VA = "0x112258A0")]
    public static void SuspendWeatherModifyUnit(BattleCore battle)
    {
    }

    [Token(Token = "0x6004BFF")]
    [Address(RVA = "0x1222F10", Offset = "0x1221D10", VA = "0x11222F10")]
    public static void DeleteWeather(List<Unit> units, bool is_restore_delete = false)
    {
    }

    [Token(Token = "0x6004C00")]
    [Address(RVA = "0x1223DD0", Offset = "0x1222BD0", VA = "0x11223DD0")]
    public static bool IsExistWeather(string iname) => new bool();

    [Token(Token = "0x6004C01")]
    [Address(RVA = "0x1225240", Offset = "0x1224040", VA = "0x11225240")]
    public void SkillReleaseWeather(
      SkillData skill,
      List<Unit> units,
      int now_clock,
      RandXorshift rand)
    {
    }

    [Token(Token = "0x6004C02")]
    [Address(RVA = "0x1224600", Offset = "0x1223400", VA = "0x11224600")]
    public WeatherData PredictSkillReleaseWeather(SkillData skill, List<Unit> units, int now_clock)
    {
      return (WeatherData) null;
    }

    [Token(Token = "0x6004C03")]
    [Address(RVA = "0x1223850", Offset = "0x1222650", VA = "0x11223850")]
    private List<WeatherReleaseParam> GetTargetWeatherReleaseList(string skill_iname)
    {
      return (List<WeatherReleaseParam>) null;
    }

    [Token(Token = "0x6004C04")]
    [Address(RVA = "0x1224020", Offset = "0x1222E20", VA = "0x11224020")]
    private bool IsReleaseWeatherCheck(WeatherData weather_data, WeatherReleaseParam reset_param)
    {
      return new bool();
    }

    [Token(Token = "0x6004C05")]
    [Address(RVA = "0x12265A0", Offset = "0x12253A0", VA = "0x112265A0")]
    public WeatherData()
    {
    }

    [Token(Token = "0x6004C06")]
    [Address(RVA = "0x1226570", Offset = "0x1225370", VA = "0x11226570")]
    static WeatherData()
    {
    }

    [Token(Token = "0x20011E2")]
    private enum eCondAttachType
    {
      [Token(Token = "0x4004121")] PASSIVE,
      [Token(Token = "0x4004122")] TURN,
    }
  }
}
