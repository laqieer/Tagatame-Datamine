// Decompiled with JetBrains decompiler
// Type: SRPG.TrophyParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D9C")]
  public class TrophyParam
  {
    [Token(Token = "0x40075E5")]
    [FieldOffset(Offset = "0x8")]
    public int category_hash_code;
    [Token(Token = "0x40075E6")]
    [FieldOffset(Offset = "0xC")]
    public bool is_none_category_hash;
    [Token(Token = "0x40075E7")]
    [FieldOffset(Offset = "0x10")]
    public string iname;
    [Token(Token = "0x40075E8")]
    [FieldOffset(Offset = "0x14")]
    public string Name;
    [Token(Token = "0x40075E9")]
    [FieldOffset(Offset = "0x18")]
    public string Expr;
    [Token(Token = "0x40075EA")]
    [FieldOffset(Offset = "0x1C")]
    public string Category;
    [Token(Token = "0x40075EB")]
    [FieldOffset(Offset = "0x20")]
    public TrophyCategoryParam CategoryParam;
    [Token(Token = "0x40075EC")]
    [FieldOffset(Offset = "0x24")]
    public ChallengeCategoryParam ChallengeCategoryParam;
    [Token(Token = "0x40075ED")]
    [FieldOffset(Offset = "0x28")]
    public TrophyDispType DispType;
    [Token(Token = "0x40075EE")]
    [FieldOffset(Offset = "0x2C")]
    public string[] RequiredTrophies;
    [Token(Token = "0x40075EF")]
    [FieldOffset(Offset = "0x30")]
    public TrophyObjective[] Objectives;
    [Token(Token = "0x40075F0")]
    [FieldOffset(Offset = "0x34")]
    public int Gold;
    [Token(Token = "0x40075F1")]
    [FieldOffset(Offset = "0x38")]
    public int Coin;
    [Token(Token = "0x40075F2")]
    [FieldOffset(Offset = "0x3C")]
    public int Exp;
    [Token(Token = "0x40075F3")]
    [FieldOffset(Offset = "0x40")]
    public int Stamina;
    [Token(Token = "0x40075F4")]
    [FieldOffset(Offset = "0x44")]
    public TrophyParam.RewardItem[] Items;
    [Token(Token = "0x40075F5")]
    [FieldOffset(Offset = "0x48")]
    public TrophyParam.RewardItem[] Artifacts;
    [Token(Token = "0x40075F6")]
    [FieldOffset(Offset = "0x4C")]
    public int Challenge;
    [Token(Token = "0x40075F7")]
    [FieldOffset(Offset = "0x50")]
    public string ParentTrophy;
    [Token(Token = "0x40075F8")]
    [FieldOffset(Offset = "0x54")]
    public int help;
    [Token(Token = "0x40075F9")]
    [FieldOffset(Offset = "0x58")]
    public TrophyParam.RewardItem[] ConceptCards;
    [Token(Token = "0x40075FA")]
    [FieldOffset(Offset = "0x5C")]
    public TrophyRewardPriority RewardPriority;
    [Token(Token = "0x40075FB")]
    [FieldOffset(Offset = "0x60")]
    public int StarNum;
    [Token(Token = "0x40075FC")]
    [FieldOffset(Offset = "0x64")]
    public bool IsEnded;

    [Token(Token = "0x1700104F")]
    public bool IsBeginner
    {
      [Token(Token = "0x6007926"), Address(RVA = "0x3B0380", Offset = "0x3AF180", VA = "0x103B0380")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001050")]
    public bool IsChallengeMission
    {
      [Token(Token = "0x6007927"), Address(RVA = "0x3B03C0", Offset = "0x3AF1C0", VA = "0x103B03C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001051")]
    public bool IsChallengeMissionRoot
    {
      [Token(Token = "0x6007928"), Address(RVA = "0x3B03A0", Offset = "0x3AF1A0", VA = "0x103B03A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001052")]
    public bool IsDaily
    {
      [Token(Token = "0x6007929"), Address(RVA = "0x3B03D0", Offset = "0x3AF1D0", VA = "0x103B03D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600792A")]
    [Address(RVA = "0x3AF650", Offset = "0x3AE450", VA = "0x103AF650")]
    public bool IsExternalType() => new bool();

    [Token(Token = "0x600792B")]
    [Address(RVA = "0x3AFDE0", Offset = "0x3AEBE0", VA = "0x103AFDE0")]
    public bool IsRewardUnit() => new bool();

    [Token(Token = "0x600792C")]
    [Address(RVA = "0x3AFD70", Offset = "0x3AEB70", VA = "0x103AFD70")]
    public bool IsRewardUnitConceptCard() => new bool();

    [Token(Token = "0x600792D")]
    [Address(RVA = "0x3AE720", Offset = "0x3AD520", VA = "0x103AE720")]
    public bool ContainsCondition(TrophyConditionTypes c) => new bool();

    [Token(Token = "0x600792E")]
    [Address(RVA = "0x3AF560", Offset = "0x3AE360", VA = "0x103AF560")]
    public bool IsChallengeMissionCompleted() => new bool();

    [Token(Token = "0x600792F")]
    [Address(RVA = "0x3AE780", Offset = "0x3AD580", VA = "0x103AE780")]
    public bool Deserialize(JSON_TrophyParam json) => new bool();

    [Token(Token = "0x6007930")]
    [Address(RVA = "0x3B0000", Offset = "0x3AEE00", VA = "0x103B0000", Slot = "4")]
    public virtual void SetTrophyObjectives(
      ref TrophyObjective[] trophy_objectives,
      JSON_TrophyParam json,
      int objective_length)
    {
    }

    [Token(Token = "0x6007931")]
    [Address(RVA = "0x3AF210", Offset = "0x3AE010", VA = "0x103AF210")]
    private static TrophyParam.RewardItem[] InitializeItems(JSON_TrophyParam json)
    {
      return (TrophyParam.RewardItem[]) null;
    }

    [Token(Token = "0x6007932")]
    [Address(RVA = "0x3AEF80", Offset = "0x3ADD80", VA = "0x103AEF80")]
    private static TrophyParam.RewardItem[] InitializeArtifacts(JSON_TrophyParam json)
    {
      return (TrophyParam.RewardItem[]) null;
    }

    [Token(Token = "0x6007933")]
    [Address(RVA = "0x3AF0F0", Offset = "0x3ADEF0", VA = "0x103AF0F0")]
    private static TrophyParam.RewardItem[] InitializeConceptCards(JSON_TrophyParam json)
    {
      return (TrophyParam.RewardItem[]) null;
    }

    [Token(Token = "0x6007934")]
    [Address(RVA = "0x3AE550", Offset = "0x3AD350", VA = "0x103AE550")]
    public static bool CheckRequiredTrophies(
      GameManager gm,
      TrophyParam tp,
      bool is_end_check,
      bool is_beginner_check = true)
    {
      return new bool();
    }

    [Token(Token = "0x6007935")]
    [Address(RVA = "0x3AE6D0", Offset = "0x3AD4D0", VA = "0x103AE6D0")]
    public bool CheckRequiredTrophies(bool is_end_check, bool is_beginner_check = true)
    {
      return new bool();
    }

    [Token(Token = "0x6007936")]
    [Address(RVA = "0x3AFE90", Offset = "0x3AEC90", VA = "0x103AFE90")]
    public bool IsShowBadge(TrophyState state) => new bool();

    [Token(Token = "0x6007937")]
    [Address(RVA = "0x3AFB30", Offset = "0x3AE930", VA = "0x103AFB30")]
    public bool IsInvisibleVip() => new bool();

    [Token(Token = "0x6007938")]
    [Address(RVA = "0x3AF6C0", Offset = "0x3AE4C0", VA = "0x103AF6C0")]
    public bool IsInvisibleCard() => new bool();

    [Token(Token = "0x6007939")]
    [Address(RVA = "0x3AF830", Offset = "0x3AE630", VA = "0x103AF830")]
    public bool IsInvisibleStamina(bool _isEnd = false) => new bool();

    [Token(Token = "0x600793A")]
    [Address(RVA = "0x3A83F0", Offset = "0x3A71F0", VA = "0x103A83F0")]
    private TimeSpan GetGraceRewardSpan() => new TimeSpan();

    [Token(Token = "0x600793B")]
    [Address(RVA = "0x3AED40", Offset = "0x3ADB40", VA = "0x103AED40")]
    private TimeSpan GetAvailableSpan() => new TimeSpan();

    [Token(Token = "0x600793C")]
    [Address(RVA = "0x3AE3F0", Offset = "0x3AD1F0", VA = "0x103AE3F0")]
    private DateTime AddTimeSpan(DateTime times, TimeSpan span) => new DateTime();

    [Token(Token = "0x600793D")]
    [Address(RVA = "0x3B0220", Offset = "0x3AF020", VA = "0x103B0220")]
    private DateTime SubTimeSpan(DateTime times, TimeSpan span) => new DateTime();

    [Token(Token = "0x600793E")]
    [Address(RVA = "0x3AF380", Offset = "0x3AE180", VA = "0x103AF380")]
    public bool IsAvailablePeriod(DateTime now, bool is_grace) => new bool();

    [Token(Token = "0x600793F")]
    [Address(RVA = "0x3AFC60", Offset = "0x3AEA60", VA = "0x103AFC60")]
    public bool IsPlanningToUse(DateTime now) => new bool();

    [Token(Token = "0x6007940")]
    [Address(RVA = "0x3AED70", Offset = "0x3ADB70", VA = "0x103AED70")]
    public DateTime GetGraceRewardTime() => new DateTime();

    [Token(Token = "0x6007941")]
    [Address(RVA = "0x3AEF20", Offset = "0x3ADD20", VA = "0x103AEF20", Slot = "5")]
    public virtual TrophyState GetTrophyCounter() => (TrophyState) null;

    [Token(Token = "0x6007942")]
    [Address(RVA = "0x3A2EF0", Offset = "0x3A1CF0", VA = "0x103A2EF0")]
    public TrophyParam()
    {
    }

    [Token(Token = "0x2001D9D")]
    public struct RewardItem
    {
      [Token(Token = "0x40075FD")]
      [FieldOffset(Offset = "0x0")]
      public string iname;
      [Token(Token = "0x40075FE")]
      [FieldOffset(Offset = "0x4")]
      public int Num;
    }
  }
}
