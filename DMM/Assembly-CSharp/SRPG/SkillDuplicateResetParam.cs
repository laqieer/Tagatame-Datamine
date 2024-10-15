// Decompiled with JetBrains decompiler
// Type: SRPG.SkillDuplicateResetParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E3F")]
  [MessagePackObject(true)]
  public class SkillDuplicateResetParam
  {
    [Token(Token = "0x4007B21")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4007B22")]
    [FieldOffset(Offset = "0xC")]
    private List<SkillDuplicateResetData> mResets;

    [Token(Token = "0x17001130")]
    public string Iname
    {
      [Token(Token = "0x6007C11"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001131")]
    public List<SkillDuplicateResetData> Resets
    {
      [Token(Token = "0x6007C12"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<SkillDuplicateResetData>) null;
      }
    }

    [Token(Token = "0x6007C13")]
    [Address(RVA = "0x3E6E40", Offset = "0x3E5C40", VA = "0x103E6E40")]
    public bool Deserialize(JSON_SkillDuplicateResetParam json) => new bool();

    [Token(Token = "0x6007C14")]
    [Address(RVA = "0x3E6FE0", Offset = "0x3E5DE0", VA = "0x103E6FE0")]
    public static void Deserialize(
      ref List<SkillDuplicateResetParam> list,
      JSON_SkillDuplicateResetParam[] json)
    {
    }

    [Token(Token = "0x6007C15")]
    [Address(RVA = "0x3E7120", Offset = "0x3E5F20", VA = "0x103E7120")]
    public static SkillDuplicateResetParam GetSkillDuplicateRestParam(string iname)
    {
      return (SkillDuplicateResetParam) null;
    }

    [Token(Token = "0x6007C16")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkillDuplicateResetParam()
    {
    }
  }
}
