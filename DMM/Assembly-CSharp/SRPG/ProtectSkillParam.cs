// Decompiled with JetBrains decompiler
// Type: SRPG.ProtectSkillParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E15")]
  [MessagePackObject(true)]
  public class ProtectSkillParam
  {
    [Token(Token = "0x4007A41")]
    [FieldOffset(Offset = "0x8")]
    public string mIname;
    [Token(Token = "0x4007A42")]
    [FieldOffset(Offset = "0xC")]
    public ProtectTypes mType;
    [Token(Token = "0x4007A43")]
    [FieldOffset(Offset = "0xD")]
    public DamageTypes mDamageType;
    [Token(Token = "0x4007A44")]
    [FieldOffset(Offset = "0x10")]
    public SkillRankUpValue mValue;
    [Token(Token = "0x4007A45")]
    [FieldOffset(Offset = "0x14")]
    public int mRange;
    [Token(Token = "0x4007A46")]
    [FieldOffset(Offset = "0x18")]
    public int mHeight;
    [Token(Token = "0x4007A47")]
    [FieldOffset(Offset = "0x1C")]
    public int mInit;
    [Token(Token = "0x4007A48")]
    [FieldOffset(Offset = "0x20")]
    public int mMax;
    [Token(Token = "0x4007A49")]
    public const int ETERNAL_PROTECT_TURN = 99;

    [Token(Token = "0x170010F7")]
    public string Iname
    {
      [Token(Token = "0x6007B7C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010F8")]
    public ProtectTypes Type
    {
      [Token(Token = "0x6007B7D"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new ProtectTypes();
      }
    }

    [Token(Token = "0x170010F9")]
    public DamageTypes DamageType
    {
      [Token(Token = "0x6007B7E"), Address(RVA = "0x3DA450", Offset = "0x3D9250", VA = "0x103DA450")] get
      {
        return new DamageTypes();
      }
    }

    [Token(Token = "0x170010FA")]
    public SkillRankUpValue Value
    {
      [Token(Token = "0x6007B7F"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (SkillRankUpValue) null;
      }
    }

    [Token(Token = "0x170010FB")]
    public int Range
    {
      [Token(Token = "0x6007B80"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170010FC")]
    public int Height
    {
      [Token(Token = "0x6007B81"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007B82")]
    [Address(RVA = "0x3E2130", Offset = "0x3E0F30", VA = "0x103E2130")]
    public static void Deserialize(
      ref List<ProtectSkillParam> ref_params,
      JSON_ProtectSkillParam[] json)
    {
    }

    [Token(Token = "0x6007B83")]
    [Address(RVA = "0x3E2330", Offset = "0x3E1130", VA = "0x103E2330")]
    public void Deserialize(JSON_ProtectSkillParam json)
    {
    }

    [Token(Token = "0x6007B84")]
    [Address(RVA = "0x3E2400", Offset = "0x3E1200", VA = "0x103E2400")]
    public bool IsProtectEternal(int value) => new bool();

    [Token(Token = "0x6007B85")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ProtectSkillParam()
    {
    }
  }
}
