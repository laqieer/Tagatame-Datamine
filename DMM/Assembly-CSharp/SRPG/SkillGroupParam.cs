// Decompiled with JetBrains decompiler
// Type: SRPG.SkillGroupParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E42")]
  public class SkillGroupParam
  {
    [Token(Token = "0x4007B26")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4007B27")]
    [FieldOffset(Offset = "0xC")]
    private List<string> mSkillInames;

    [Token(Token = "0x17001132")]
    public string Iname
    {
      [Token(Token = "0x6007C1A"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001133")]
    public List<string> SkillInames
    {
      [Token(Token = "0x6007C1B"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x6007C1C")]
    [Address(RVA = "0x3E7260", Offset = "0x3E6060", VA = "0x103E7260")]
    public bool Deserialize(JSON_SkillGroupParam json) => new bool();

    [Token(Token = "0x6007C1D")]
    [Address(RVA = "0x3E7340", Offset = "0x3E6140", VA = "0x103E7340")]
    public static void Deserialize(ref List<SkillGroupParam> list, JSON_SkillGroupParam[] json)
    {
    }

    [Token(Token = "0x6007C1E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkillGroupParam()
    {
    }
  }
}
