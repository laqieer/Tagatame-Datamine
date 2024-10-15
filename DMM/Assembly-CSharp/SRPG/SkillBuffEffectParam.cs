// Decompiled with JetBrains decompiler
// Type: SRPG.SkillBuffEffectParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D26")]
  [MessagePackObject(true)]
  public class SkillBuffEffectParam
  {
    [Token(Token = "0x400724B")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x400724C")]
    [FieldOffset(Offset = "0xC")]
    private List<string> mTargetEffList;
    [Token(Token = "0x400724D")]
    [FieldOffset(Offset = "0x10")]
    private string mTargetEffSE;
    [Token(Token = "0x400724E")]
    [FieldOffset(Offset = "0x14")]
    private List<string> mSelfEffList;
    [Token(Token = "0x400724F")]
    [FieldOffset(Offset = "0x18")]
    private string mSelfEffSE;

    [Token(Token = "0x17000FC8")]
    public string Iname
    {
      [Token(Token = "0x6007789"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FC9")]
    public List<string> TargetEffList
    {
      [Token(Token = "0x600778A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x17000FCA")]
    public string TargetEffSE
    {
      [Token(Token = "0x600778B"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FCB")]
    public List<string> SelfEffList
    {
      [Token(Token = "0x600778C"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x17000FCC")]
    public string SelfEffSE
    {
      [Token(Token = "0x600778D"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600778E")]
    [Address(RVA = "0x39FAB0", Offset = "0x39E8B0", VA = "0x1039FAB0")]
    public bool Deserialize(JSON_SkillBuffEffectParam json) => new bool();

    [Token(Token = "0x600778F")]
    [Address(RVA = "0x39F9B0", Offset = "0x39E7B0", VA = "0x1039F9B0")]
    public static void Deserialize(
      ref List<SkillBuffEffectParam> param,
      JSON_SkillBuffEffectParam[] json)
    {
    }

    [Token(Token = "0x6007790")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkillBuffEffectParam()
    {
    }
  }
}
