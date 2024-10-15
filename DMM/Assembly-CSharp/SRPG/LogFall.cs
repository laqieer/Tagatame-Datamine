// Decompiled with JetBrains decompiler
// Type: SRPG.LogFall
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BF4")]
  public class LogFall : BattleLog
  {
    [Token(Token = "0x4001E8B")]
    [FieldOffset(Offset = "0x8")]
    public List<LogFall.Param> mLists;
    [Token(Token = "0x4001E8C")]
    [FieldOffset(Offset = "0xC")]
    public bool mIsPlayDamageMotion;
    [Token(Token = "0x4001E8D")]
    [FieldOffset(Offset = "0xD")]
    public bool mIsPlayIdolLoopMotion;

    [Token(Token = "0x6002FEA")]
    [Address(RVA = "0xFE5C90", Offset = "0xFE4A90", VA = "0x10FE5C90")]
    public void Add(Unit self, Grid landing = null)
    {
    }

    [Token(Token = "0x6002FEB")]
    [Address(RVA = "0xFE5D60", Offset = "0xFE4B60", VA = "0x10FE5D60")]
    public LogFall()
    {
    }

    [Token(Token = "0x2000BF5")]
    public struct Param
    {
      [Token(Token = "0x4001E8E")]
      [FieldOffset(Offset = "0x0")]
      public Unit mSelf;
      [Token(Token = "0x4001E8F")]
      [FieldOffset(Offset = "0x4")]
      public Grid mLanding;
    }
  }
}
