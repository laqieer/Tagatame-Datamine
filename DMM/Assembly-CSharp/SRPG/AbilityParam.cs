// Decompiled with JetBrains decompiler
// Type: SRPG.AbilityParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DC6")]
  [MessagePackObject(true)]
  public class AbilityParam
  {
    [Token(Token = "0x40076B6")]
    public const int ABILITY_ICON_INDEX_ACTION = 0;
    [Token(Token = "0x40076B7")]
    public const int ABILITY_ICON_INDEX_SUPPORT = 1;
    [Token(Token = "0x40076B8")]
    public const int ABILITY_ICON_INDEX_REACTION = 2;
    [Token(Token = "0x40076B9")]
    public const int ABILITY_ICON_INDEX_OTHER = 3;
    [Token(Token = "0x40076BA")]
    public const int ABILITY_ICON_INDEX_TRUTH_EQUIPMENT_ACTION = 4;
    [Token(Token = "0x40076BB")]
    public const int ABILITY_ICON_INDEX_TRUTH_EQUIPMENT_SUPPORT = 5;
    [Token(Token = "0x40076BC")]
    public const int ABILITY_ICON_INDEX_TRUTH_EQUIPMENT_REACTION = 6;
    [Token(Token = "0x40076BD")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40076BE")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x40076BF")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x40076C0")]
    [FieldOffset(Offset = "0x14")]
    public string icon;
    [Token(Token = "0x40076C1")]
    [FieldOffset(Offset = "0x18")]
    public EAbilityType type;
    [Token(Token = "0x40076C2")]
    [FieldOffset(Offset = "0x1C")]
    public EAbilitySlot slot;
    [Token(Token = "0x40076C3")]
    [FieldOffset(Offset = "0x20")]
    public OInt lvcap;
    [Token(Token = "0x40076C4")]
    [FieldOffset(Offset = "0x34")]
    public bool is_fixed;
    [Token(Token = "0x40076C5")]
    [FieldOffset(Offset = "0x38")]
    public LearningSkill[] skills;
    [Token(Token = "0x40076C6")]
    [FieldOffset(Offset = "0x3C")]
    public string[] condition_units;
    [Token(Token = "0x40076C7")]
    [FieldOffset(Offset = "0x40")]
    public EUseConditionsType units_conditions_type;
    [Token(Token = "0x40076C8")]
    [FieldOffset(Offset = "0x44")]
    public string[] condition_jobs;
    [Token(Token = "0x40076C9")]
    [FieldOffset(Offset = "0x48")]
    public EUseConditionsType jobs_conditions_type;
    [Token(Token = "0x40076CA")]
    [FieldOffset(Offset = "0x4C")]
    public string condition_birth;
    [Token(Token = "0x40076CB")]
    [FieldOffset(Offset = "0x50")]
    public ESex condition_sex;
    [Token(Token = "0x40076CC")]
    [FieldOffset(Offset = "0x54")]
    public EElement condition_element;
    [Token(Token = "0x40076CD")]
    [FieldOffset(Offset = "0x58")]
    public OInt condition_raremin;
    [Token(Token = "0x40076CE")]
    [FieldOffset(Offset = "0x6C")]
    public OInt condition_raremax;
    [Token(Token = "0x40076CF")]
    [FieldOffset(Offset = "0x80")]
    public EAbilityTypeDetail type_detail;

    [Token(Token = "0x60079C7")]
    [Address(RVA = "0x3B3490", Offset = "0x3B2290", VA = "0x103B3490")]
    public bool Deserialize(JSON_AbilityParam json) => new bool();

    [Token(Token = "0x60079C8")]
    [Address(RVA = "0x3B4040", Offset = "0x3B2E40", VA = "0x103B4040")]
    public int GetRankCap() => new int();

    [Token(Token = "0x60079C9")]
    [Address(RVA = "0x3B3060", Offset = "0x3B1E60", VA = "0x103B3060")]
    public bool CheckEnableUseAbility(UnitData self, int job_index) => new bool();

    [Token(Token = "0x60079CA")]
    [Address(RVA = "0x3B3E60", Offset = "0x3B2C60", VA = "0x103B3E60")]
    public List<UnitParam> FindConditionUnitParams(MasterParam masterParam = null)
    {
      return (List<UnitParam>) null;
    }

    [Token(Token = "0x60079CB")]
    [Address(RVA = "0x3B3CE0", Offset = "0x3B2AE0", VA = "0x103B3CE0")]
    public List<JobParam> FindConditionJobParams(MasterParam masterParam = null)
    {
      return (List<JobParam>) null;
    }

    [Token(Token = "0x60079CC")]
    [Address(RVA = "0x3B4070", Offset = "0x3B2E70", VA = "0x103B4070")]
    public static string TypeDetailToSpriteSheetKey(EAbilityTypeDetail typeDetail) => (string) null;

    [Token(Token = "0x60079CD")]
    [Address(RVA = "0x3B3FE0", Offset = "0x3B2DE0", VA = "0x103B3FE0")]
    public int GetAbilityIconIndex() => new int();

    [Token(Token = "0x60079CE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AbilityParam()
    {
    }
  }
}
