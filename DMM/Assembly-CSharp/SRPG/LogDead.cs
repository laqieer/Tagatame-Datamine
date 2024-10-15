// Decompiled with JetBrains decompiler
// Type: SRPG.LogDead
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BE5")]
  public class LogDead : BattleLog
  {
    [Token(Token = "0x4001E5B")]
    [FieldOffset(Offset = "0x8")]
    public List<LogDead.Param> list_normal;
    [Token(Token = "0x4001E5C")]
    [FieldOffset(Offset = "0xC")]
    public List<LogDead.Param> list_sentence;

    [Token(Token = "0x6002FD5")]
    [Address(RVA = "0xFE5B60", Offset = "0xFE4960", VA = "0x10FE5B60")]
    public void Add(Unit unit, DeadTypes type, bool isRevival)
    {
    }

    [Token(Token = "0x6002FD6")]
    [Address(RVA = "0xFE5BF0", Offset = "0xFE49F0", VA = "0x10FE5BF0")]
    public LogDead()
    {
    }

    [Token(Token = "0x2000BE6")]
    public struct Param
    {
      [Token(Token = "0x4001E5D")]
      [FieldOffset(Offset = "0x0")]
      public Unit self;
      [Token(Token = "0x4001E5E")]
      [FieldOffset(Offset = "0x4")]
      public DeadTypes type;
      [Token(Token = "0x4001E5F")]
      [FieldOffset(Offset = "0x8")]
      public bool isRevival;
    }
  }
}
