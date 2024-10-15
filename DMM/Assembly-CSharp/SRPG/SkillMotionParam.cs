// Decompiled with JetBrains decompiler
// Type: SRPG.SkillMotionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E4C")]
  public class SkillMotionParam
  {
    [Token(Token = "0x4007B5A")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4007B5B")]
    [FieldOffset(Offset = "0xC")]
    private List<SkillMotionDataParam> mDataList;

    [Token(Token = "0x17001147")]
    public string Iname
    {
      [Token(Token = "0x6007C4C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007C4D")]
    [Address(RVA = "0x3E8170", Offset = "0x3E6F70", VA = "0x103E8170")]
    public void Deserialize(JSON_SkillMotionParam json)
    {
    }

    [Token(Token = "0x6007C4E")]
    [Address(RVA = "0x3E85F0", Offset = "0x3E73F0", VA = "0x103E85F0")]
    public SkillMotion GetSkillMotion(string unit_id) => (SkillMotion) null;

    [Token(Token = "0x6007C4F")]
    [Address(RVA = "0x3E8470", Offset = "0x3E7270", VA = "0x103E8470")]
    public SkillMotion GetSkillMotion(string unit_id, string jobset_id) => (SkillMotion) null;

    [Token(Token = "0x6007C50")]
    [Address(RVA = "0x3E8390", Offset = "0x3E7190", VA = "0x103E8390")]
    public List<string> GetMotionList() => (List<string>) null;

    [Token(Token = "0x6007C51")]
    [Address(RVA = "0x3E82B0", Offset = "0x3E70B0", VA = "0x103E82B0")]
    public List<string> GetEffectList() => (List<string>) null;

    [Token(Token = "0x6007C52")]
    [Address(RVA = "0x3E8120", Offset = "0x3E6F20", VA = "0x103E8120")]
    public bool CheckPassCondition(UnitData self) => new bool();

    [Token(Token = "0x6007C53")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkillMotionParam()
    {
    }
  }
}
