// Decompiled with JetBrains decompiler
// Type: SRPG.CollaboSkillParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DE2")]
  public class CollaboSkillParam
  {
    [Token(Token = "0x4007835")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4007836")]
    [FieldOffset(Offset = "0xC")]
    private string mUnitIname;
    [Token(Token = "0x4007837")]
    [FieldOffset(Offset = "0x10")]
    private string mAbilityIname;
    [Token(Token = "0x4007838")]
    [FieldOffset(Offset = "0x14")]
    private List<CollaboSkillParam.LearnSkill> mLearnSkillLists;

    [Token(Token = "0x17001097")]
    public string Iname
    {
      [Token(Token = "0x6007A4D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001098")]
    public string UnitIname
    {
      [Token(Token = "0x6007A4E"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001099")]
    public string AbilityIname
    {
      [Token(Token = "0x6007A4F"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700109A")]
    public List<CollaboSkillParam.LearnSkill> LearnSkillLists
    {
      [Token(Token = "0x6007A50"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<CollaboSkillParam.LearnSkill>) null;
      }
    }

    [Token(Token = "0x6007A51")]
    [Address(RVA = "0x3BBF40", Offset = "0x3BAD40", VA = "0x103BBF40")]
    public void Deserialize(JSON_CollaboSkillParam json)
    {
    }

    [Token(Token = "0x6007A52")]
    [Address(RVA = "0x3BCE40", Offset = "0x3BBC40", VA = "0x103BCE40")]
    public static void UpdateCollaboSkill(List<CollaboSkillParam> csp_lists)
    {
    }

    [Token(Token = "0x6007A53")]
    [Address(RVA = "0x3BC820", Offset = "0x3BB620", VA = "0x103BC820")]
    public static string GetPartnerIname(string unit_iname, string skill_iname) => (string) null;

    [Token(Token = "0x6007A54")]
    [Address(RVA = "0x3BC070", Offset = "0x3BAE70", VA = "0x103BC070")]
    public static List<string> GetLearnSkill(string quest_iname, string unit_iname)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x6007A55")]
    [Address(RVA = "0x3BC390", Offset = "0x3BB190", VA = "0x103BC390")]
    public static List<CollaboSkillParam.Pair> GetPairLists()
    {
      return (List<CollaboSkillParam.Pair>) null;
    }

    [Token(Token = "0x6007A56")]
    [Address(RVA = "0x3BCA50", Offset = "0x3BB850", VA = "0x103BCA50")]
    public static CollaboSkillParam.Pair IsLearnQuest(string quest_id)
    {
      return (CollaboSkillParam.Pair) null;
    }

    [Token(Token = "0x6007A57")]
    [Address(RVA = "0x3BD310", Offset = "0x3BC110", VA = "0x103BD310")]
    public CollaboSkillParam()
    {
    }

    [Token(Token = "0x2001DE3")]
    public class LearnSkill
    {
      [Token(Token = "0x4007839")]
      [FieldOffset(Offset = "0x8")]
      public string QuestIname;
      [Token(Token = "0x400783A")]
      [FieldOffset(Offset = "0xC")]
      public string SkillIname;
      [Token(Token = "0x400783B")]
      [FieldOffset(Offset = "0x10")]
      public string PartnerUnitIname;

      [Token(Token = "0x6007A58")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public LearnSkill(string q_iname)
      {
      }
    }

    [Token(Token = "0x2001DE4")]
    public class Pair
    {
      [Token(Token = "0x400783C")]
      [FieldOffset(Offset = "0x8")]
      public UnitParam UnitParam1;
      [Token(Token = "0x400783D")]
      [FieldOffset(Offset = "0xC")]
      public UnitParam UnitParam2;

      [Token(Token = "0x6007A59")]
      [Address(RVA = "0x3C0020", Offset = "0x3BEE20", VA = "0x103C0020")]
      public Pair(UnitParam u_param1, UnitParam u_param2)
      {
      }
    }
  }
}
