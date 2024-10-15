// Decompiled with JetBrains decompiler
// Type: SRPG.SkillAdditionalParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E28")]
  [MessagePackObject(true)]
  public class SkillAdditionalParam
  {
    [Token(Token = "0x4007ACB")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4007ACC")]
    [FieldOffset(Offset = "0xC")]
    private SkillAdditionalParam.eAdditionalCond mCond;
    [Token(Token = "0x4007ACD")]
    [FieldOffset(Offset = "0x10")]
    private string mSkillId;
    [Token(Token = "0x4007ACE")]
    [FieldOffset(Offset = "0x14")]
    private BitArray mFlags;
    [Token(Token = "0x4007ACF")]
    [FieldOffset(Offset = "0x18")]
    private SkillParam mSkill;

    [Token(Token = "0x1700110F")]
    public string Iname
    {
      [Token(Token = "0x6007BCA"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001110")]
    public SkillAdditionalParam.eAdditionalCond Cond
    {
      [Token(Token = "0x6007BCB"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new SkillAdditionalParam.eAdditionalCond();
      }
    }

    [Token(Token = "0x17001111")]
    public string SkillId
    {
      [Token(Token = "0x6007BCC"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001112")]
    public SkillParam Skill
    {
      [Token(Token = "0x6007BCD"), Address(RVA = "0x3E5830", Offset = "0x3E4630", VA = "0x103E5830")] get
      {
        return (SkillParam) null;
      }
    }

    [Token(Token = "0x17001113")]
    public bool IsTargetSelf
    {
      [Token(Token = "0x6007BCE"), Address(RVA = "0x3E5800", Offset = "0x3E4600", VA = "0x103E5800")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001114")]
    public bool IsHide
    {
      [Token(Token = "0x6007BCF"), Address(RVA = "0x3E57D0", Offset = "0x3E45D0", VA = "0x103E57D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007BD0")]
    [Address(RVA = "0x3E54A0", Offset = "0x3E42A0", VA = "0x103E54A0")]
    public void Deserialize(JSON_SkillAdditionalParam json)
    {
    }

    [Token(Token = "0x6007BD1")]
    [Address(RVA = "0x3E5540", Offset = "0x3E4340", VA = "0x103E5540")]
    public static void Deserialize(
      ref List<SkillAdditionalParam> list,
      JSON_SkillAdditionalParam[] json)
    {
    }

    [Token(Token = "0x6007BD2")]
    [Address(RVA = "0x3E5760", Offset = "0x3E4560", VA = "0x103E5760")]
    public SkillAdditionalParam()
    {
    }

    [Token(Token = "0x2001E29")]
    public enum eAdditionalCond : byte
    {
      [Token(Token = "0x4007AD1")] None,
      [Token(Token = "0x4007AD2")] TargetDefeat,
      [Token(Token = "0x4007AD3")] CriticalHit,
    }

    [Token(Token = "0x2001E2A")]
    public enum eAdditionalFlag : byte
    {
      [Token(Token = "0x4007AD5")] IsTargetSelf,
      [Token(Token = "0x4007AD6")] IsHide,
      [Token(Token = "0x4007AD7")] MAX,
    }
  }
}
