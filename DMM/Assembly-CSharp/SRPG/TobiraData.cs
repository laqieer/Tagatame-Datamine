// Decompiled with JetBrains decompiler
// Type: SRPG.TobiraData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001169")]
  [MessagePackObject(true)]
  public class TobiraData
  {
    [Token(Token = "0x4003EFF")]
    [FieldOffset(Offset = "0x8")]
    private int mLv;
    [Token(Token = "0x4003F00")]
    [FieldOffset(Offset = "0xC")]
    private SkillData mParameterBuffSkill;
    [Token(Token = "0x4003F01")]
    [FieldOffset(Offset = "0x10")]
    private TobiraParam mTobiraParam;
    [Token(Token = "0x4003F02")]
    [FieldOffset(Offset = "0x14")]
    private string mLearnedLeaderSkillIname;

    [Token(Token = "0x17000819")]
    public int Lv
    {
      [Token(Token = "0x6004A2F"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6004A30"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] set
      {
      }
    }

    [Token(Token = "0x1700081A")]
    public int ViewLv
    {
      [Token(Token = "0x6004A31"), Address(RVA = "0x1208370", Offset = "0x1207170", VA = "0x11208370")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700081B")]
    public SkillData ParameterBuffSkill
    {
      [Token(Token = "0x6004A32"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (SkillData) null;
      }
    }

    [Token(Token = "0x1700081C")]
    public string LearnedLeaderSkillIname
    {
      [Token(Token = "0x6004A33"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700081D")]
    public bool IsUnlocked
    {
      [Token(Token = "0x6004A34"), Address(RVA = "0x319770", Offset = "0x318570", VA = "0x10319770")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700081E")]
    public TobiraParam Param
    {
      [Token(Token = "0x6004A35"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (TobiraParam) null;
      }
    }

    [Token(Token = "0x1700081F")]
    public bool IsLearnedLeaderSkill
    {
      [Token(Token = "0x6004A36"), Address(RVA = "0x3B2FA0", Offset = "0x3B1DA0", VA = "0x103B2FA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000820")]
    public bool IsMaxLv
    {
      [Token(Token = "0x6004A37"), Address(RVA = "0x12082F0", Offset = "0x12070F0", VA = "0x112082F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004A38")]
    [Address(RVA = "0x1208000", Offset = "0x1206E00", VA = "0x11208000")]
    public bool Setup(string unit_iname, TobiraParam.Category category, int lv) => new bool();

    [Token(Token = "0x6004A39")]
    [Address(RVA = "0x1208280", Offset = "0x1207080", VA = "0x11208280")]
    public Json_Tobira ToJson() => (Json_Tobira) null;

    [Token(Token = "0x6004A3A")]
    [Address(RVA = "0x1208190", Offset = "0x1206F90", VA = "0x11208190")]
    public string ToJsonString() => (string) null;

    [Token(Token = "0x6004A3B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TobiraData()
    {
    }
  }
}
