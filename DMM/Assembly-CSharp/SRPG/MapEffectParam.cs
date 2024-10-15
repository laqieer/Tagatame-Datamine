// Decompiled with JetBrains decompiler
// Type: SRPG.MapEffectParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BD6")]
  public class MapEffectParam
  {
    [Token(Token = "0x4006AC4")]
    [FieldOffset(Offset = "0x8")]
    private int mIndex;
    [Token(Token = "0x4006AC5")]
    [FieldOffset(Offset = "0xC")]
    private string mIname;
    [Token(Token = "0x4006AC6")]
    [FieldOffset(Offset = "0x10")]
    private string mName;
    [Token(Token = "0x4006AC7")]
    [FieldOffset(Offset = "0x14")]
    private string mExpr;
    [Token(Token = "0x4006AC8")]
    [FieldOffset(Offset = "0x18")]
    private List<string> mValidSkillLists;
    [Token(Token = "0x4006AC9")]
    [FieldOffset(Offset = "0x0")]
    private static int CurrentIndex;
    [Token(Token = "0x4006ACA")]
    [FieldOffset(Offset = "0x4")]
    private static Dictionary<string, List<JobParam>> mHaveJobDict;

    [Token(Token = "0x17000E3B")]
    public int Index
    {
      [Token(Token = "0x60072EC"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E3C")]
    public string Iname
    {
      [Token(Token = "0x60072ED"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E3D")]
    public string Name
    {
      [Token(Token = "0x60072EE"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E3E")]
    public string Expr
    {
      [Token(Token = "0x60072EF"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E3F")]
    public List<string> ValidSkillLists
    {
      [Token(Token = "0x60072F0"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x60072F1")]
    [Address(RVA = "0x37B3D0", Offset = "0x37A1D0", VA = "0x1037B3D0")]
    public void Deserialize(JSON_MapEffectParam json)
    {
    }

    [Token(Token = "0x60072F2")]
    [Address(RVA = "0x37B830", Offset = "0x37A630", VA = "0x1037B830")]
    public bool IsValidSkill(string skill) => new bool();

    [Token(Token = "0x60072F3")]
    [Address(RVA = "0x37B4D0", Offset = "0x37A2D0", VA = "0x1037B4D0")]
    public static List<JobParam> GetHaveJobLists(string skill_iname) => (List<JobParam>) null;

    [Token(Token = "0x60072F4")]
    [Address(RVA = "0x37B5A0", Offset = "0x37A3A0", VA = "0x1037B5A0")]
    public static List<MapEffectParam> GetHaveMapEffectLists(string skill_iname)
    {
      return (List<MapEffectParam>) null;
    }

    [Token(Token = "0x60072F5")]
    [Address(RVA = "0x37B800", Offset = "0x37A600", VA = "0x1037B800")]
    public static bool IsMakeHaveJobLists() => new bool();

    [Token(Token = "0x60072F6")]
    [Address(RVA = "0x37B890", Offset = "0x37A690", VA = "0x1037B890")]
    public static void MakeHaveJobLists()
    {
    }

    [Token(Token = "0x60072F7")]
    [Address(RVA = "0x37B180", Offset = "0x379F80", VA = "0x1037B180")]
    public static void AddHaveJob(string skill_iname, JobParam job_param)
    {
    }

    [Token(Token = "0x60072F8")]
    [Address(RVA = "0x37B910", Offset = "0x37A710", VA = "0x1037B910")]
    public MapEffectParam()
    {
    }
  }
}
