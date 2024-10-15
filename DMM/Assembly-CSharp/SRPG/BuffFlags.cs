// Decompiled with JetBrains decompiler
// Type: SRPG.BuffFlags
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DDC")]
  public enum BuffFlags
  {
    [Token(Token = "0x400780D")] UpReplenish = 1,
    [Token(Token = "0x400780E")] NoDisabled = 2,
    [Token(Token = "0x400780F")] NoBuffTurn = 4,
    [Token(Token = "0x4007810")] AvoidPerfect = 8,
    [Token(Token = "0x4007811")] AvoidMiss = 16, // 0x00000010
    [Token(Token = "0x4007812")] UpReplenishUseSkillCtr = 32, // 0x00000020
    [Token(Token = "0x4007813")] IsDependIgnore = 64, // 0x00000040
  }
}
