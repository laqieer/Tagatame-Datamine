// Decompiled with JetBrains decompiler
// Type: SRPG.SkillRevivalParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E7A")]
  [MessagePackObject(true)]
  public class SkillRevivalParam
  {
    [Token(Token = "0x4007E6C")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4007E6D")]
    [FieldOffset(Offset = "0xC")]
    private string mSkillId;
    [Token(Token = "0x4007E6E")]
    [FieldOffset(Offset = "0x10")]
    private int mCT;
    [Token(Token = "0x4007E6F")]
    [FieldOffset(Offset = "0x14")]
    private bool mIsCT;
    [Token(Token = "0x4007E70")]
    [FieldOffset(Offset = "0x18")]
    private List<SkillRevivalBuffList> mBuffs;

    [Token(Token = "0x17001163")]
    public string Iname
    {
      [Token(Token = "0x6007CCD"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001164")]
    public string SkillId
    {
      [Token(Token = "0x6007CCE"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001165")]
    public int CT
    {
      [Token(Token = "0x6007CCF"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001166")]
    public bool IsCT
    {
      [Token(Token = "0x6007CD0"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001167")]
    public List<SkillRevivalBuffList> Buffs
    {
      [Token(Token = "0x6007CD1"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<SkillRevivalBuffList>) null;
      }
    }

    [Token(Token = "0x6007CD2")]
    [Address(RVA = "0x3ECF40", Offset = "0x3EBD40", VA = "0x103ECF40")]
    public SkillParam GetAddSkillParam() => (SkillParam) null;

    [Token(Token = "0x6007CD3")]
    [Address(RVA = "0x3ECD90", Offset = "0x3EBB90", VA = "0x103ECD90")]
    public bool Deserialize(JSON_SkillRevivalParam json) => new bool();

    [Token(Token = "0x6007CD4")]
    [Address(RVA = "0x3ECC50", Offset = "0x3EBA50", VA = "0x103ECC50")]
    public static void Deserialize(ref List<SkillRevivalParam> list, JSON_SkillRevivalParam[] json)
    {
    }

    [Token(Token = "0x6007CD5")]
    [Address(RVA = "0x3ED0E0", Offset = "0x3EBEE0", VA = "0x103ED0E0")]
    public static SkillRevivalParam GetSkillRevivalParam(string iname) => (SkillRevivalParam) null;

    [Token(Token = "0x6007CD6")]
    [Address(RVA = "0x3ED000", Offset = "0x3EBE00", VA = "0x103ED000")]
    public string GetAttackDetailTypesBuff(AttackDetailTypes type) => (string) null;

    [Token(Token = "0x6007CD7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkillRevivalParam()
    {
    }
  }
}
