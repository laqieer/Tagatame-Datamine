// Decompiled with JetBrains decompiler
// Type: SRPG.SkillLockCondition
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
  [Token(Token = "0x2000C2E")]
  [MessagePackObject(true)]
  [Serializable]
  public class SkillLockCondition
  {
    [Token(Token = "0x4001FE2")]
    [FieldOffset(Offset = "0x8")]
    public int type;
    [Token(Token = "0x4001FE3")]
    [FieldOffset(Offset = "0xC")]
    public int value;
    [Token(Token = "0x4001FE4")]
    [FieldOffset(Offset = "0x10")]
    public List<int> x;
    [Token(Token = "0x4001FE5")]
    [FieldOffset(Offset = "0x14")]
    public List<int> y;
    [Token(Token = "0x4001FE6")]
    [FieldOffset(Offset = "0x18")]
    [NonSerialized]
    public bool unlock;

    [Token(Token = "0x6003047")]
    [Address(RVA = "0xFEAF00", Offset = "0xFE9D00", VA = "0x10FEAF00")]
    public void Clear()
    {
    }

    [Token(Token = "0x6003048")]
    [Address(RVA = "0xFEAFF0", Offset = "0xFE9DF0", VA = "0x10FEAFF0")]
    public void CopyTo(SkillLockCondition dsc)
    {
    }

    [Token(Token = "0x6003049")]
    [Address(RVA = "0xFEAF60", Offset = "0xFE9D60", VA = "0x10FEAF60")]
    public void CopyTo(JSON_SkillLockCondition dsc)
    {
    }

    [Token(Token = "0x600304A")]
    [Address(RVA = "0xFEB040", Offset = "0xFE9E40", VA = "0x10FEB040")]
    public SkillLockCondition()
    {
    }
  }
}
