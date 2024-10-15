// Decompiled with JetBrains decompiler
// Type: SRPG.TobiraUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200116A")]
  public class TobiraUtility
  {
    [Token(Token = "0x6004A3C")]
    [Address(RVA = "0x1209AE0", Offset = "0x12088E0", VA = "0x11209AE0")]
    public static int GetUnlockTobiraNum(Json_Tobira[] json) => new int();

    [Token(Token = "0x6004A3D")]
    [Address(RVA = "0x12099C0", Offset = "0x12087C0", VA = "0x112099C0")]
    public static int GetTobiraUnlockLevel(string unit_iname) => new int();

    [Token(Token = "0x6004A3E")]
    [Address(RVA = "0x1209480", Offset = "0x1208280", VA = "0x11209480")]
    public static List<string> GetOverwrittenAbilitys(UnitData unitData, bool _isJobOver = false)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x6004A3F")]
    [Address(RVA = "0x120A210", Offset = "0x1209010", VA = "0x1120A210")]
    public static List<ConditionsResult> TobiraConditionsCheck(
      UnitData unitData,
      TobiraConditionParam[] conds)
    {
      return (List<ConditionsResult>) null;
    }

    [Token(Token = "0x6004A40")]
    [Address(RVA = "0x120A5A0", Offset = "0x12093A0", VA = "0x1120A5A0")]
    public static List<ConditionsResult> TobiraRecipeCheck(
      UnitData unitData,
      TobiraParam.Category category,
      int targetLevel)
    {
      return (List<ConditionsResult>) null;
    }

    [Token(Token = "0x6004A41")]
    [Address(RVA = "0x1209BD0", Offset = "0x12089D0", VA = "0x11209BD0")]
    public static bool IsClearAllTobiraMaster(UnitData unitData) => new bool();

    [Token(Token = "0x6004A42")]
    [Address(RVA = "0x1209D80", Offset = "0x1208B80", VA = "0x11209D80")]
    public static bool IsClearAllToboraConditions(
      UnitData unit_data,
      TobiraParam.Category tobira_category)
    {
      return new bool();
    }

    [Token(Token = "0x6004A43")]
    [Address(RVA = "0x1209E50", Offset = "0x1208C50", VA = "0x11209E50")]
    public static bool IsClearAllToboraRecipe(
      UnitData unit_data,
      TobiraParam.Category tobira_category,
      int tobiraLv)
    {
      return new bool();
    }

    [Token(Token = "0x6004A44")]
    [Address(RVA = "0x1209EE0", Offset = "0x1208CE0", VA = "0x11209EE0")]
    public static bool IsHaveTobiraAllMasterUnit() => new bool();

    [Token(Token = "0x6004A45")]
    [Address(RVA = "0x120A0D0", Offset = "0x1208ED0", VA = "0x1120A0D0")]
    public static string ToJsonString(List<TobiraData> list) => (string) null;

    [Token(Token = "0x6004A46")]
    [Address(RVA = "0x1208BC0", Offset = "0x12079C0", VA = "0x11208BC0")]
    public static void CalcTobiraParameter(
      string unit_iname,
      TobiraParam.Category category,
      int lv,
      ref BaseStatus add,
      ref BaseStatus scale)
    {
    }

    [Token(Token = "0x6004A47")]
    [Address(RVA = "0x12098A0", Offset = "0x12086A0", VA = "0x112098A0")]
    public static List<SkillData> GetParameterBuffSkills(List<TobiraData> list)
    {
      return (List<SkillData>) null;
    }

    [Token(Token = "0x6004A48")]
    [Address(RVA = "0x1209090", Offset = "0x1207E90", VA = "0x11209090")]
    public static int GetAdditionalUnitLevelCapWithTobira(List<TobiraData> list) => new int();

    [Token(Token = "0x6004A49")]
    [Address(RVA = "0x12091C0", Offset = "0x1207FC0", VA = "0x112091C0")]
    public static int GetAdditionalUnitLevelCapWithUnlockNum(int unlockNum) => new int();

    [Token(Token = "0x6004A4A")]
    [Address(RVA = "0x1209250", Offset = "0x1208050", VA = "0x11209250")]
    public static int GetAdditionalUnitWithUnlockNum(int _level, int maxLevel) => new int();

    [Token(Token = "0x6004A4B")]
    [Address(RVA = "0x12092D0", Offset = "0x12080D0", VA = "0x112092D0")]
    public static string GetOverwriteLeaderSkill(List<TobiraData> list) => (string) null;

    [Token(Token = "0x6004A4C")]
    [Address(RVA = "0x1208380", Offset = "0x1207180", VA = "0x11208380")]
    public static List<StatusList.ParamTypeData> CalcResonanceBuffRate(
      string _unit_iname,
      TobiraParam.Category _category,
      int _tobira_level,
      int _awake_level,
      ref BaseStatus _add_status,
      ref BaseStatus _scale_status)
    {
      return (List<StatusList.ParamTypeData>) null;
    }

    [Token(Token = "0x6004A4D")]
    [Address(RVA = "0x1208FD0", Offset = "0x1207DD0", VA = "0x11208FD0")]
    public static SkillData CreateParameterBuffSkill(TobiraParam tobiraParam, int currentLv)
    {
      return (SkillData) null;
    }

    [Token(Token = "0x6004A4E")]
    [Address(RVA = "0x120B0A0", Offset = "0x1209EA0", VA = "0x1120B0A0")]
    public static void TryCraeteLeaderSkill(
      TobiraParam tobiraParam,
      int currentLv,
      ref SkillData skillData,
      bool isJust = false)
    {
    }

    [Token(Token = "0x6004A4F")]
    [Address(RVA = "0x120AAD0", Offset = "0x12098D0", VA = "0x1120AAD0")]
    public static void TryCraeteAbilityData(
      UnitData unitData,
      TobiraParam tobiraParam,
      int currentLv,
      List<AbilityData> newAbilitys,
      List<AbilityData> oldAbilitys,
      bool isJust = false)
    {
    }

    [Token(Token = "0x6004A50")]
    [Address(RVA = "0x1208E50", Offset = "0x1207C50", VA = "0x11208E50")]
    public static List<TobiraData> CreateDummyData(UnitData unit) => (List<TobiraData>) null;

    [Token(Token = "0x6004A51")]
    [Address(RVA = "0x1208C80", Offset = "0x1207A80", VA = "0x11208C80")]
    public static void CreateDummyData(Json_Unit[] units)
    {
    }

    [Token(Token = "0x6004A52")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TobiraUtility()
    {
    }
  }
}
