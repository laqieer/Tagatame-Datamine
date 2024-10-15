// Decompiled with JetBrains decompiler
// Type: SRPG.SkillAntiShieldParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E2C")]
  [MessagePackObject(true)]
  public class SkillAntiShieldParam
  {
    [Token(Token = "0x4007ADF")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4007AE0")]
    [FieldOffset(Offset = "0xC")]
    private bool mIsIgnore;
    [Token(Token = "0x4007AE1")]
    [FieldOffset(Offset = "0x10")]
    private SkillRankUpValueShort mIgnoreRate;
    [Token(Token = "0x4007AE2")]
    [FieldOffset(Offset = "0x14")]
    private bool mIsDestroy;
    [Token(Token = "0x4007AE3")]
    [FieldOffset(Offset = "0x18")]
    private SkillRankUpValueShort mDestroyRate;

    [Token(Token = "0x17001115")]
    public string Iname
    {
      [Token(Token = "0x6007BD4"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001116")]
    public bool IsIgnore
    {
      [Token(Token = "0x6007BD5"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001117")]
    public SkillRankUpValueShort IgnoreRate
    {
      [Token(Token = "0x6007BD6"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (SkillRankUpValueShort) null;
      }
    }

    [Token(Token = "0x17001118")]
    public bool IsDestroy
    {
      [Token(Token = "0x6007BD7"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001119")]
    public SkillRankUpValueShort DestroyRate
    {
      [Token(Token = "0x6007BD8"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (SkillRankUpValueShort) null;
      }
    }

    [Token(Token = "0x6007BD9")]
    [Address(RVA = "0x3E58D0", Offset = "0x3E46D0", VA = "0x103E58D0")]
    public void Deserialize(JSON_SkillAntiShieldParam json)
    {
    }

    [Token(Token = "0x6007BDA")]
    [Address(RVA = "0x3E59D0", Offset = "0x3E47D0", VA = "0x103E59D0")]
    public static void Deserialize(
      ref List<SkillAntiShieldParam> list,
      JSON_SkillAntiShieldParam[] json)
    {
    }

    [Token(Token = "0x6007BDB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkillAntiShieldParam()
    {
    }
  }
}
