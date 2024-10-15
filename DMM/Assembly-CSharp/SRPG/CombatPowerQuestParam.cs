// Decompiled with JetBrains decompiler
// Type: SRPG.CombatPowerQuestParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A5D")]
  public class CombatPowerQuestParam
  {
    [Token(Token = "0x4006145")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4006146")]
    [FieldOffset(Offset = "0xC")]
    private CombatPowerQuestParam.eQuestInameType mQuestInameType;
    [Token(Token = "0x4006147")]
    [FieldOffset(Offset = "0x10")]
    private string mQuestIname;
    [Token(Token = "0x4006148")]
    [FieldOffset(Offset = "0x14")]
    private CombatPowerQuestParam.eCombatPowerType mType;
    [Token(Token = "0x4006149")]
    [FieldOffset(Offset = "0x18")]
    private int mNum;
    [Token(Token = "0x400614A")]
    [FieldOffset(Offset = "0x1C")]
    private string mUnitGroupId;
    [Token(Token = "0x400614B")]
    [FieldOffset(Offset = "0x20")]
    private string mUnitId;
    [Token(Token = "0x400614C")]
    [FieldOffset(Offset = "0x24")]
    private UnitGroupParam mUnitGroupParam;

    [Token(Token = "0x17000BD9")]
    public string Iname
    {
      [Token(Token = "0x6006C63"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BDA")]
    public CombatPowerQuestParam.eQuestInameType QuestInameType
    {
      [Token(Token = "0x6006C64"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new CombatPowerQuestParam.eQuestInameType();
      }
    }

    [Token(Token = "0x17000BDB")]
    public string QuestIname
    {
      [Token(Token = "0x6006C65"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BDC")]
    public CombatPowerQuestParam.eCombatPowerType Type
    {
      [Token(Token = "0x6006C66"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new CombatPowerQuestParam.eCombatPowerType();
      }
    }

    [Token(Token = "0x17000BDD")]
    public int Num
    {
      [Token(Token = "0x6006C67"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000BDE")]
    public string UnitGroupId
    {
      [Token(Token = "0x6006C68"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BDF")]
    public string UnitId
    {
      [Token(Token = "0x6006C69"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BE0")]
    public UnitGroupParam UnitGroupParam
    {
      [Token(Token = "0x6006C6A"), Address(RVA = "0x353F50", Offset = "0x352D50", VA = "0x10353F50")] get
      {
        return (UnitGroupParam) null;
      }
    }

    [Token(Token = "0x6006C6B")]
    [Address(RVA = "0x353860", Offset = "0x352660", VA = "0x10353860")]
    public bool Deserialize(JSON_CombatPowerQuestParam json) => new bool();

    [Token(Token = "0x6006C6C")]
    [Address(RVA = "0x3536D0", Offset = "0x3524D0", VA = "0x103536D0")]
    public static void Deserialize(
      ref List<CombatPowerQuestParam> ref_params,
      JSON_CombatPowerQuestParam[] json)
    {
    }

    [Token(Token = "0x6006C6D")]
    [Address(RVA = "0x3539E0", Offset = "0x3527E0", VA = "0x103539E0")]
    public static CombatPowerQuestParam GetCombatPowerQuestParamByIname(string _iname)
    {
      return (CombatPowerQuestParam) null;
    }

    [Token(Token = "0x6006C6E")]
    [Address(RVA = "0x3538D0", Offset = "0x3526D0", VA = "0x103538D0")]
    public static CombatPowerQuestParam GetCombatPowerQuestParamByArea(string _area_iname)
    {
      return (CombatPowerQuestParam) null;
    }

    [Token(Token = "0x6006C6F")]
    [Address(RVA = "0x353AF0", Offset = "0x3528F0", VA = "0x10353AF0")]
    public static CombatPowerQuestParam GetCombatPowerQuestParamByQuest(string _quest_iname)
    {
      return (CombatPowerQuestParam) null;
    }

    [Token(Token = "0x6006C70")]
    [Address(RVA = "0x353DF0", Offset = "0x352BF0", VA = "0x10353DF0")]
    public static List<CombatPowerQuestConditionResult> JudgeUnlockTargetQuests()
    {
      return (List<CombatPowerQuestConditionResult>) null;
    }

    [Token(Token = "0x6006C71")]
    [Address(RVA = "0x353C90", Offset = "0x352A90", VA = "0x10353C90")]
    public static List<CombatPowerQuestConditionResult> JudgeUnlockTargetAreas()
    {
      return (List<CombatPowerQuestConditionResult>) null;
    }

    [Token(Token = "0x6006C72")]
    [Address(RVA = "0x3533A0", Offset = "0x3521A0", VA = "0x103533A0")]
    public int CalcTargetCombatPower() => new int();

    [Token(Token = "0x6006C73")]
    [Address(RVA = "0x3535E0", Offset = "0x3523E0", VA = "0x103535E0")]
    private int CalcTargetUnitsCombatPower() => new int();

    [Token(Token = "0x6006C74")]
    [Address(RVA = "0x353C70", Offset = "0x352A70", VA = "0x10353C70")]
    public bool IsUnlockConditionsMet(int combatPower) => new bool();

    [Token(Token = "0x6006C75")]
    [Address(RVA = "0x353C00", Offset = "0x352A00", VA = "0x10353C00")]
    public bool IsUnlockChapterConditions(
      ChapterParam _param,
      bool _is_check_parent,
      CombatPowerQuestConditionResult _result)
    {
      return new bool();
    }

    [Token(Token = "0x6006C76")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CombatPowerQuestParam()
    {
    }

    [Token(Token = "0x2001A5E")]
    public enum eQuestInameType
    {
      [Token(Token = "0x400614E")] None,
      [Token(Token = "0x400614F")] Area,
      [Token(Token = "0x4006150")] Quest,
    }

    [Token(Token = "0x2001A5F")]
    public enum eCombatPowerType
    {
      [Token(Token = "0x4006152")] None,
      [Token(Token = "0x4006153")] Total,
      [Token(Token = "0x4006154")] Fire,
      [Token(Token = "0x4006155")] Water,
      [Token(Token = "0x4006156")] Thunder,
      [Token(Token = "0x4006157")] Wind,
      [Token(Token = "0x4006158")] Shine,
      [Token(Token = "0x4006159")] Dark,
      [Token(Token = "0x400615A")] Unit,
    }
  }
}
