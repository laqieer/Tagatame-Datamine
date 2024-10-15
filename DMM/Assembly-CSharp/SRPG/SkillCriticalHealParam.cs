// Decompiled with JetBrains decompiler
// Type: SRPG.SkillCriticalHealParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E34")]
  [MessagePackObject(true)]
  public class SkillCriticalHealParam
  {
    [Token(Token = "0x4007AF4")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4007AF5")]
    [FieldOffset(Offset = "0xC")]
    private SkillCriticalHealParam.eHealType mHealType;
    [Token(Token = "0x4007AF6")]
    [FieldOffset(Offset = "0x10")]
    private int mEffectValue;

    [Token(Token = "0x1700111D")]
    public string Iname
    {
      [Token(Token = "0x6007BEE"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700111E")]
    public SkillCriticalHealParam.eHealType HealType
    {
      [Token(Token = "0x6007BEF"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new SkillCriticalHealParam.eHealType();
      }
    }

    [Token(Token = "0x1700111F")]
    public int EffectValue
    {
      [Token(Token = "0x6007BF0"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007BF1")]
    [Address(RVA = "0x3E6380", Offset = "0x3E5180", VA = "0x103E6380")]
    public void Deserialize(JSON_SkillCriticalHealParam json)
    {
    }

    [Token(Token = "0x6007BF2")]
    [Address(RVA = "0x3E63C0", Offset = "0x3E51C0", VA = "0x103E63C0")]
    public static void Deserialize(
      ref List<SkillCriticalHealParam> list,
      JSON_SkillCriticalHealParam[] json)
    {
    }

    [Token(Token = "0x6007BF3")]
    [Address(RVA = "0x3E6510", Offset = "0x3E5310", VA = "0x103E6510")]
    public static SkillCriticalHealParam GetParam(string iname, MasterParam master = null)
    {
      return (SkillCriticalHealParam) null;
    }

    [Token(Token = "0x6007BF4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkillCriticalHealParam()
    {
    }

    [Token(Token = "0x2001E35")]
    public enum eHealType : byte
    {
      [Token(Token = "0x4007AF8")] Fix,
      [Token(Token = "0x4007AF9")] HpRate,
      [Token(Token = "0x4007AFA")] MaRate,
    }
  }
}
