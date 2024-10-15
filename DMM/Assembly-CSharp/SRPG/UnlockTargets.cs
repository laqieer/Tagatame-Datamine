// Decompiled with JetBrains decompiler
// Type: SRPG.UnlockTargets
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EAC")]
  [Flags]
  public enum UnlockTargets : long
  {
    [Token(Token = "0x4008052")] Shop = 1,
    [Token(Token = "0x4008053")] Cave = 2,
    [Token(Token = "0x4008054")] Tour = 4,
    [Token(Token = "0x4008055")] Tower = 8,
    [Token(Token = "0x4008056")] Arena = 16, // 0x0000000000000010
    [Token(Token = "0x4008057")] ShopTabi = 32, // 0x0000000000000020
    [Token(Token = "0x4008058")] ShopKimagure = 64, // 0x0000000000000040
    [Token(Token = "0x4008059")] ShopMonozuki = 128, // 0x0000000000000080
    [Token(Token = "0x400805A")] MultiPlay = 256, // 0x0000000000000100
    [Token(Token = "0x400805B")] UnitAwaking = 512, // 0x0000000000000200
    [Token(Token = "0x400805C")] UnitEvolution = 1024, // 0x0000000000000400
    [Token(Token = "0x400805D")] EnhanceEquip = 2048, // 0x0000000000000800
    [Token(Token = "0x400805E")] EnhanceAbility = 4096, // 0x0000000000001000
    [Token(Token = "0x400805F")] Artifact = 8192, // 0x0000000000002000
    [Token(Token = "0x4008060")] ShopAwakePiece = 16384, // 0x0000000000004000
    [Token(Token = "0x4008061")] LimitedShop = 32768, // 0x0000000000008000
    [Token(Token = "0x4008062")] MultiVS = 65536, // 0x0000000000010000
    [Token(Token = "0x4008063")] Ordeal = 131072, // 0x0000000000020000
    [Token(Token = "0x4008064")] Gallery = 262144, // 0x0000000000040000
    [Token(Token = "0x4008065")] ConceptCard = 524288, // 0x0000000000080000
    [Token(Token = "0x4008066")] KeyQuest = 1048576, // 0x0000000000100000
    [Token(Token = "0x4008067")] EventShop = 2097152, // 0x0000000000200000
    [Token(Token = "0x4008068")] TowerQuest = 4194304, // 0x0000000000400000
    [Token(Token = "0x4008069")] RankMatch = 8388608, // 0x0000000000800000
    [Token(Token = "0x400806A")] Guild = 16777216, // 0x0000000001000000
    [Token(Token = "0x400806B")] Archive = 33554432, // 0x0000000002000000
    [Token(Token = "0x400806C")] Raid = 67108864, // 0x0000000004000000
    [Token(Token = "0x400806D")] EventQuest = 134217728, // 0x0000000008000000
    [Token(Token = "0x400806E")] SeisekiQuest = 268435456, // 0x0000000010000000
    [Token(Token = "0x400806F")] BabelQuest = 536870912, // 0x0000000020000000
    [Token(Token = "0x4008070")] ChallengeQuest = 1073741824, // 0x0000000040000000
    [Token(Token = "0x4008071")] CharacterQuest = 2147483648, // 0x0000000080000000
    [Token(Token = "0x4008072")] GuildRaid = 4294967296, // 0x0000000100000000
    [Token(Token = "0x4008073")] AutoRepeatQuest = 8589934592, // 0x0000000200000000
    [Token(Token = "0x4008074")] Rune = 17179869184, // 0x0000000400000000
    [Token(Token = "0x4008075")] WorldRaid = 34359738368, // 0x0000000800000000
    [Token(Token = "0x4008076")] CombatPowerQuest = 68719476736, // 0x0000001000000000
    [Token(Token = "0x4008077")] Adventure = 137438953472, // 0x0000002000000000
    [Token(Token = "0x4008078")] DragonGod = 274877906944, // 0x0000004000000000
    [Token(Token = "0x4008079")] PointEvent = 549755813888, // 0x0000008000000000
    [Token(Token = "0x400807A")] LeagueMatch = 1099511627776, // 0x0000010000000000
  }
}
