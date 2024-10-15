// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeaderSkillSelectWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200334E")]
  public class LeaderSkillSelectWindowModel
  {
    [Token(Token = "0x400F21A")]
    [FieldOffset(Offset = "0x8")]
    private string mUnitLeaderSkill;
    [Token(Token = "0x400F21B")]
    [FieldOffset(Offset = "0xC")]
    private string mUnitLeaderSkillExplanation;
    [Token(Token = "0x400F21C")]
    [FieldOffset(Offset = "0x10")]
    private string mConceptCardLeaderSkill;
    [Token(Token = "0x400F21D")]
    [FieldOffset(Offset = "0x14")]
    private string mConceptCardLeaderSkillExplanation;
    [Token(Token = "0x400F21E")]
    [FieldOffset(Offset = "0x18")]
    private LeaderSkillSelectWindowModel.SelectLeaderSkill nowSelect;
    [Token(Token = "0x400F21F")]
    [FieldOffset(Offset = "0x1C")]
    private LeaderSkillSelectWindowModel.SelectLeaderSkill BeforeSelect;

    [Token(Token = "0x17001E6C")]
    public string UnitLeaderSkill
    {
      [Token(Token = "0x600E303"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001E6D")]
    public string UnitLeaderSkillExplanation
    {
      [Token(Token = "0x600E304"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001E6E")]
    public string ConceptCardLeaderSkill
    {
      [Token(Token = "0x600E305"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001E6F")]
    public string ConceptCardLeaderSkillExplanation
    {
      [Token(Token = "0x600E306"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001E70")]
    public bool isUnitSkillUnSelect
    {
      [Token(Token = "0x600E307"), Address(RVA = "0x3B3010", Offset = "0x3B1E10", VA = "0x103B3010")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E71")]
    public bool isConceptCardSkillUnSelect
    {
      [Token(Token = "0x600E308"), Address(RVA = "0xAB2300", Offset = "0xAB1100", VA = "0x10AB2300")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E72")]
    public bool IsButtonEnable
    {
      [Token(Token = "0x600E309"), Address(RVA = "0xAB22E0", Offset = "0xAB10E0", VA = "0x10AB22E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E30A")]
    [Address(RVA = "0xAB2170", Offset = "0xAB0F70", VA = "0x10AB2170")]
    public void Initialize(UnitData unitData)
    {
    }

    [Token(Token = "0x600E30B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeaderSkillSelectWindowModel()
    {
    }

    [Token(Token = "0x200334F")]
    public enum SelectLeaderSkill
    {
      [Token(Token = "0x400F221")] Unit,
      [Token(Token = "0x400F222")] ConceptCard,
    }
  }
}
