// Decompiled with JetBrains decompiler
// Type: SRPG.SkillReactionCondParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E75")]
  [MessagePackObject(true)]
  public class SkillReactionCondParam
  {
    [Token(Token = "0x4007E5A")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4007E5B")]
    [FieldOffset(Offset = "0xC")]
    private List<string> mSkillIds;
    [Token(Token = "0x4007E5C")]
    [FieldOffset(Offset = "0x10")]
    private List<EUnitTargetDirection> mVecs;
    [Token(Token = "0x4007E5D")]
    [FieldOffset(Offset = "0x14")]
    private List<EElement> mSkillElems;
    [Token(Token = "0x4007E5E")]
    [FieldOffset(Offset = "0x18")]
    private List<EElement> mUnitElems;
    [Token(Token = "0x4007E5F")]
    [FieldOffset(Offset = "0x1C")]
    private SkillReactionCondParam.EBaseDir mBaseDir;

    [Token(Token = "0x1700115D")]
    public string Iname
    {
      [Token(Token = "0x6007CBF"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700115E")]
    public List<string> SkillIds
    {
      [Token(Token = "0x6007CC0"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x1700115F")]
    public List<EUnitTargetDirection> Vecs
    {
      [Token(Token = "0x6007CC1"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<EUnitTargetDirection>) null;
      }
    }

    [Token(Token = "0x17001160")]
    public List<EElement> SkillElems
    {
      [Token(Token = "0x6007CC2"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<EElement>) null;
      }
    }

    [Token(Token = "0x17001161")]
    public List<EElement> UnitElems
    {
      [Token(Token = "0x6007CC3"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<EElement>) null;
      }
    }

    [Token(Token = "0x17001162")]
    public SkillReactionCondParam.EBaseDir BaseDir
    {
      [Token(Token = "0x6007CC4"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new SkillReactionCondParam.EBaseDir();
      }
    }

    [Token(Token = "0x6007CC5")]
    [Address(RVA = "0x3EC550", Offset = "0x3EB350", VA = "0x103EC550")]
    public bool Deserialize(JSON_SkillReactionCondParam json) => new bool();

    [Token(Token = "0x6007CC6")]
    [Address(RVA = "0x3EC980", Offset = "0x3EB780", VA = "0x103EC980")]
    public static bool Deserialize(
      ref List<SkillReactionCondParam> paramList,
      JSON_SkillReactionCondParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x6007CC7")]
    [Address(RVA = "0x3ECAD0", Offset = "0x3EB8D0", VA = "0x103ECAD0")]
    public bool IsInMatchDirection(EUnitTargetDirection checkDir) => new bool();

    [Token(Token = "0x6007CC8")]
    [Address(RVA = "0x3ECC40", Offset = "0x3EBA40", VA = "0x103ECC40")]
    private bool IsMatchDirection(EUnitTargetDirection vec, EUnitTargetDirection checkDir)
    {
      return new bool();
    }

    [Token(Token = "0x6007CC9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkillReactionCondParam()
    {
    }

    [Token(Token = "0x2001E76")]
    public enum EBaseDir
    {
      [Token(Token = "0x4007E61")] AttackerAndTarget,
      [Token(Token = "0x4007E62")] GridAndTarget,
    }
  }
}
