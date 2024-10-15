// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SkillLockCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C2D")]
  [Serializable]
  public class JSON_SkillLockCondition
  {
    [Token(Token = "0x4001FDE")]
    [FieldOffset(Offset = "0x8")]
    public int type;
    [Token(Token = "0x4001FDF")]
    [FieldOffset(Offset = "0xC")]
    public int value;
    [Token(Token = "0x4001FE0")]
    [FieldOffset(Offset = "0x10")]
    public int[] x;
    [Token(Token = "0x4001FE1")]
    [FieldOffset(Offset = "0x14")]
    public int[] y;

    [Token(Token = "0x6003044")]
    [Address(RVA = "0xFE5530", Offset = "0xFE4330", VA = "0x10FE5530")]
    public void CopyTo(SkillLockCondition dsc)
    {
    }

    [Token(Token = "0x6003045")]
    [Address(RVA = "0xFE54E0", Offset = "0xFE42E0", VA = "0x10FE54E0")]
    public void CopyTo(JSON_SkillLockCondition dsc)
    {
    }

    [Token(Token = "0x6003046")]
    [Address(RVA = "0xFE55F0", Offset = "0xFE43F0", VA = "0x10FE55F0")]
    public JSON_SkillLockCondition()
    {
    }
  }
}
