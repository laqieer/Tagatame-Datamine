// Decompiled with JetBrains decompiler
// Type: SRPG.AIFlags
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DCF")]
  public enum AIFlags
  {
    [Token(Token = "0x4007708")] Positioning = 1,
    [Token(Token = "0x4007709")] Sneaking = 2,
    [Token(Token = "0x400770A")] DisableMove = 4,
    [Token(Token = "0x400770B")] DisableAction = 8,
    [Token(Token = "0x400770C")] DisableSkill = 16, // 0x00000010
    [Token(Token = "0x400770D")] DisableAvoid = 32, // 0x00000020
    [Token(Token = "0x400770E")] CastSkillFriendlyFire = 64, // 0x00000040
    [Token(Token = "0x400770F")] DisableJewelAttack = 128, // 0x00000080
    [Token(Token = "0x4007710")] SelfBuffOnly = 256, // 0x00000100
    [Token(Token = "0x4007711")] DisableTargetPriority = 512, // 0x00000200
    [Token(Token = "0x4007712")] UseOldSort = 1024, // 0x00000400
  }
}
