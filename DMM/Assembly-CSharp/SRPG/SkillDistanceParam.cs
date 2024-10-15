// Decompiled with JetBrains decompiler
// Type: SRPG.SkillDistanceParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E3A")]
  [MessagePackObject(true)]
  [Serializable]
  public class SkillDistanceParam
  {
    [Token(Token = "0x4007B0C")]
    public const int MAX_DISTANCE = 99;
    [Token(Token = "0x4007B0D")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4007B0E")]
    [FieldOffset(Offset = "0xC")]
    private int mTurn;
    [Token(Token = "0x4007B0F")]
    [FieldOffset(Offset = "0x10")]
    private bool mIsSelf;
    [Token(Token = "0x4007B10")]
    [FieldOffset(Offset = "0x11")]
    private bool mIsTarget;
    [Token(Token = "0x4007B11")]
    [FieldOffset(Offset = "0x14")]
    private ESkillDistanceKind mKind;
    [Token(Token = "0x4007B12")]
    [FieldOffset(Offset = "0x18")]
    private List<SkillDistanceDataParam> mEffects;

    [Token(Token = "0x17001120")]
    public string Iname
    {
      [Token(Token = "0x6007BF9"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001121")]
    public int Turn
    {
      [Token(Token = "0x6007BFA"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001122")]
    public bool IsSelf
    {
      [Token(Token = "0x6007BFB"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001123")]
    public bool IsTarget
    {
      [Token(Token = "0x6007BFC"), Address(RVA = "0x3E6E30", Offset = "0x3E5C30", VA = "0x103E6E30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001124")]
    public ESkillDistanceKind Kind
    {
      [Token(Token = "0x6007BFD"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new ESkillDistanceKind();
      }
    }

    [Token(Token = "0x17001125")]
    public List<SkillDistanceDataParam> Effects
    {
      [Token(Token = "0x6007BFE"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<SkillDistanceDataParam>) null;
      }
    }

    [Token(Token = "0x17001126")]
    public bool IsEternal
    {
      [Token(Token = "0x6007BFF"), Address(RVA = "0x2B0B60", Offset = "0x2AF960", VA = "0x102B0B60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007C00")]
    [Address(RVA = "0x3E6CD0", Offset = "0x3E5AD0", VA = "0x103E6CD0")]
    public bool Deserialize(JSON_SkillDistanceParam json) => new bool();

    [Token(Token = "0x6007C01")]
    [Address(RVA = "0x3E6A40", Offset = "0x3E5840", VA = "0x103E6A40")]
    public static void Deserialize(
      ref List<SkillDistanceParam> list,
      JSON_SkillDistanceParam[] json)
    {
    }

    [Token(Token = "0x6007C02")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkillDistanceParam()
    {
    }
  }
}
