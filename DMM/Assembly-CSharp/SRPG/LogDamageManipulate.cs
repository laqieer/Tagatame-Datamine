// Decompiled with JetBrains decompiler
// Type: SRPG.LogDamageManipulate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BEC")]
  public class LogDamageManipulate : BattleLog
  {
    [Token(Token = "0x4001E70")]
    [FieldOffset(Offset = "0x8")]
    public Unit reflectSelf;
    [Token(Token = "0x4001E71")]
    [FieldOffset(Offset = "0xC")]
    public List<Unit> reflectTargets;
    [Token(Token = "0x4001E72")]
    [FieldOffset(Offset = "0x10")]
    public int reflectDamage;
    [Token(Token = "0x4001E73")]
    [FieldOffset(Offset = "0x14")]
    public List<LogDamageManipulate.Data> list;
    [Token(Token = "0x4001E74")]
    [FieldOffset(Offset = "0x18")]
    public bool reflectGuts;
    [Token(Token = "0x4001E75")]
    [FieldOffset(Offset = "0x1C")]
    public Grid reflectDeadGrid;

    [Token(Token = "0x6002FE2")]
    [Address(RVA = "0xFE5970", Offset = "0xFE4770", VA = "0x10FE5970")]
    public void AddManipulate(
      Unit self,
      Unit target,
      ManipulateTypes type,
      int damage,
      string effect,
      bool isBreak,
      Grid dead_grid,
      ManipulateTypes effType = ManipulateTypes.None)
    {
    }

    [Token(Token = "0x6002FE3")]
    [Address(RVA = "0xFE5AA0", Offset = "0xFE48A0", VA = "0x10FE5AA0")]
    public void SetReflectDamage(
      Unit self,
      List<Unit> targets,
      int damage,
      bool isGuts,
      Grid dead_grid)
    {
    }

    [Token(Token = "0x6002FE4")]
    [Address(RVA = "0xFE5AF0", Offset = "0xFE48F0", VA = "0x10FE5AF0")]
    public LogDamageManipulate()
    {
    }

    [Token(Token = "0x2000BED")]
    public struct Data
    {
      [Token(Token = "0x4001E76")]
      [FieldOffset(Offset = "0x0")]
      public Unit mSelf;
      [Token(Token = "0x4001E77")]
      [FieldOffset(Offset = "0x4")]
      public Unit mTarget;
      [Token(Token = "0x4001E78")]
      [FieldOffset(Offset = "0x8")]
      public int mDamage;
      [Token(Token = "0x4001E79")]
      [FieldOffset(Offset = "0xC")]
      public Grid mDeadGrid;
      [Token(Token = "0x4001E7A")]
      [FieldOffset(Offset = "0x10")]
      public ManipulateTypes mType;
      [Token(Token = "0x4001E7B")]
      [FieldOffset(Offset = "0x14")]
      public string mEffect;
      [Token(Token = "0x4001E7C")]
      [FieldOffset(Offset = "0x18")]
      public bool isBreak;
      [Token(Token = "0x4001E7D")]
      [FieldOffset(Offset = "0x19")]
      public ManipulateTypes mEffectType;
    }
  }
}
