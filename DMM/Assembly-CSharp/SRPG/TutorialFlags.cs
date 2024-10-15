// Decompiled with JetBrains decompiler
// Type: SRPG.TutorialFlags
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001055")]
  [Flags]
  public enum TutorialFlags
  {
    [Token(Token = "0x4003A5C")] GamePlay = 1,
    [Token(Token = "0x4003A5D")] Magic = 2,
    [Token(Token = "0x4003A5E")] Attack_1 = 4,
    [Token(Token = "0x4003A5F")] Updown = 8,
    [Token(Token = "0x4003A60")] Evolution = 16, // 0x00000010
    [Token(Token = "0x4003A61")] Equip = 32, // 0x00000020
    [Token(Token = "0x4003A62")] UnitShard = 64, // 0x00000040
    [Token(Token = "0x4003A63")] Ability = 128, // 0x00000080
    [Token(Token = "0x4003A64")] Attack_2 = 256, // 0x00000100
    [Token(Token = "0x4003A65")] Move = 512, // 0x00000200
    [Token(Token = "0x4003A66")] Organize = 1024, // 0x00000400
    [Token(Token = "0x4003A67")] AutoBattle = 2048, // 0x00000800
    [Token(Token = "0x4003A68")] Mission = 4096, // 0x00001000
    [Token(Token = "0x4003A69")] ConceptCard_1 = 8192, // 0x00002000
    [Token(Token = "0x4003A6A")] ConceptCard_2 = 16384, // 0x00004000
    [Token(Token = "0x4003A6B")] ConceptCard_3 = 32768, // 0x00008000
    [Token(Token = "0x4003A6C")] Tobira_1 = 65536, // 0x00010000
    [Token(Token = "0x4003A6D")] Tobira_2 = 131072, // 0x00020000
  }
}
