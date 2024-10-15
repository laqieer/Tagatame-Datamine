// Decompiled with JetBrains decompiler
// Type: SRPG.SkillMotionDataParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E4A")]
  public class SkillMotionDataParam
  {
    [Token(Token = "0x4007B53")]
    [FieldOffset(Offset = "0x8")]
    private List<string> mUnitList;
    [Token(Token = "0x4007B54")]
    [FieldOffset(Offset = "0xC")]
    private List<string> mJobList;
    [Token(Token = "0x4007B55")]
    [FieldOffset(Offset = "0x10")]
    private string mMotionId;
    [Token(Token = "0x4007B56")]
    [FieldOffset(Offset = "0x14")]
    public string mEffectId;
    [Token(Token = "0x4007B57")]
    [FieldOffset(Offset = "0x18")]
    private SkillMotionDataParam.Flags mFlags;

    [Token(Token = "0x17001142")]
    public List<string> UnitList
    {
      [Token(Token = "0x6007C45"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x17001143")]
    public List<string> JobList
    {
      [Token(Token = "0x6007C46"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x17001144")]
    public string MotionId
    {
      [Token(Token = "0x6007C47"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001145")]
    public string EffectId
    {
      [Token(Token = "0x6007C48"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001146")]
    public bool IsBattleScene
    {
      [Token(Token = "0x6007C49"), Address(RVA = "0x3E8110", Offset = "0x3E6F10", VA = "0x103E8110")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007C4A")]
    [Address(RVA = "0x3E7F70", Offset = "0x3E6D70", VA = "0x103E7F70")]
    public void Deserialize(JSON_SkillMotionDataParam json)
    {
    }

    [Token(Token = "0x6007C4B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkillMotionDataParam()
    {
    }

    [Token(Token = "0x2001E4B")]
    public enum Flags
    {
      [Token(Token = "0x4007B59")] IsBattleScene = 1,
    }
  }
}
