// Decompiled with JetBrains decompiler
// Type: SRPG.SkillAutoHpJudgeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E30")]
  [MessagePackObject(true)]
  public class SkillAutoHpJudgeParam
  {
    [Token(Token = "0x4007AEB")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4007AEC")]
    [FieldOffset(Offset = "0xC")]
    private bool mSkillSkip;
    [Token(Token = "0x4007AED")]
    [FieldOffset(Offset = "0x10")]
    private List<SkillAutoHpJudgeSkill> mSkills;

    [Token(Token = "0x1700111A")]
    public string Iname
    {
      [Token(Token = "0x6007BDF"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700111B")]
    public bool SkillSkip
    {
      [Token(Token = "0x6007BE0"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700111C")]
    public List<SkillAutoHpJudgeSkill> Skills
    {
      [Token(Token = "0x6007BE1"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<SkillAutoHpJudgeSkill>) null;
      }
    }

    [Token(Token = "0x6007BE2")]
    [Address(RVA = "0x3E5FA0", Offset = "0x3E4DA0", VA = "0x103E5FA0")]
    public List<SkillParam> GetAddSkillParamList() => (List<SkillParam>) null;

    [Token(Token = "0x6007BE3")]
    [Address(RVA = "0x3E5C10", Offset = "0x3E4A10", VA = "0x103E5C10")]
    public bool Deserialize(JSON_SkillAutoHpJudgeParam json) => new bool();

    [Token(Token = "0x6007BE4")]
    [Address(RVA = "0x3E5E60", Offset = "0x3E4C60", VA = "0x103E5E60")]
    public static void Deserialize(
      ref List<SkillAutoHpJudgeParam> list,
      JSON_SkillAutoHpJudgeParam[] json)
    {
    }

    [Token(Token = "0x6007BE5")]
    [Address(RVA = "0x3E6120", Offset = "0x3E4F20", VA = "0x103E6120")]
    public static SkillAutoHpJudgeParam GetSkillAutoHpJudgeParam(string iname)
    {
      return (SkillAutoHpJudgeParam) null;
    }

    [Token(Token = "0x6007BE6")]
    [Address(RVA = "0x3E6260", Offset = "0x3E5060", VA = "0x103E6260")]
    public List<SkillAutoHpJudgeSkill> GetSkillByHp(int hp, int max)
    {
      return (List<SkillAutoHpJudgeSkill>) null;
    }

    [Token(Token = "0x6007BE7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkillAutoHpJudgeParam()
    {
    }
  }
}
