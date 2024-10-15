// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactStoneEffectParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001993")]
  public class ArtifactStoneEffectParam
  {
    [Token(Token = "0x4005DA4")]
    [FieldOffset(Offset = "0x24")]
    private List<SkillData> PassiveSkill;
    [Token(Token = "0x4005DA5")]
    [FieldOffset(Offset = "0x28")]
    private List<AbilityParam> StoneAbility;

    [Token(Token = "0x17000AD5")]
    public string Iname
    {
      [Token(Token = "0x6006837"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006838"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000AD6")]
    public string Name
    {
      [Token(Token = "0x6006839"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600683A"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000AD7")]
    public string Expr
    {
      [Token(Token = "0x600683B"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600683C"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17000AD8")]
    public int IconFrame
    {
      [Token(Token = "0x600683D"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
      [Token(Token = "0x600683E"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x17000AD9")]
    public string IconName
    {
      [Token(Token = "0x600683F"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006840"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x17000ADA")]
    public string[] AbilityInames
    {
      [Token(Token = "0x6006841"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string[]) null;
      }
      [Token(Token = "0x6006842"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] private set
      {
      }
    }

    [Token(Token = "0x17000ADB")]
    public string[] SkillInames
    {
      [Token(Token = "0x6006843"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string[]) null;
      }
      [Token(Token = "0x6006844"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] private set
      {
      }
    }

    [Token(Token = "0x6006845")]
    [Address(RVA = "0x349670", Offset = "0x348470", VA = "0x10349670")]
    public bool Deserialize(JSON_ArtifactStoneEffectParam json) => new bool();

    [Token(Token = "0x6006846")]
    [Address(RVA = "0x349700", Offset = "0x348500", VA = "0x10349700")]
    public static void Deserialize(
      ref List<ArtifactStoneEffectParam> param,
      JSON_ArtifactStoneEffectParam[] json)
    {
    }

    [Token(Token = "0x6006847")]
    [Address(RVA = "0x349890", Offset = "0x348690", VA = "0x10349890")]
    public List<SkillData> GetStatusSkill() => (List<SkillData>) null;

    [Token(Token = "0x6006848")]
    [Address(RVA = "0x3499F0", Offset = "0x3487F0", VA = "0x103499F0")]
    public List<AbilityParam> GetStoneAbility() => (List<AbilityParam>) null;

    [Token(Token = "0x6006849")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ArtifactStoneEffectParam()
    {
    }
  }
}
