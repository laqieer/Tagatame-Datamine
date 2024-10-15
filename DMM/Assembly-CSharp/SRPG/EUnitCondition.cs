// Decompiled with JetBrains decompiler
// Type: SRPG.EUnitCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D8E")]
  public enum EUnitCondition : long
  {
    [Token(Token = "0x400E393")] Poison = 1,
    [Token(Token = "0x400E394")] Paralysed = 2,
    [Token(Token = "0x400E395")] Stun = 4,
    [Token(Token = "0x400E396")] Sleep = 8,
    [Token(Token = "0x400E397")] Charm = 16, // 0x0000000000000010
    [Token(Token = "0x400E398")] Stone = 32, // 0x0000000000000020
    [Token(Token = "0x400E399")] Blindness = 64, // 0x0000000000000040
    [Token(Token = "0x400E39A")] DisableSkill = 128, // 0x0000000000000080
    [Token(Token = "0x400E39B")] DisableMove = 256, // 0x0000000000000100
    [Token(Token = "0x400E39C")] DisableAttack = 512, // 0x0000000000000200
    [Token(Token = "0x400E39D")] Zombie = 1024, // 0x0000000000000400
    [Token(Token = "0x400E39E")] DeathSentence = 2048, // 0x0000000000000800
    [Token(Token = "0x400E39F")] Berserk = 4096, // 0x0000000000001000
    [Token(Token = "0x400E3A0")] DisableKnockback = 8192, // 0x0000000000002000
    [Token(Token = "0x400E3A1")] DisableBuff = 16384, // 0x0000000000004000
    [Token(Token = "0x400E3A2")] DisableDebuff = 32768, // 0x0000000000008000
    [Token(Token = "0x400E3A3")] Stop = 65536, // 0x0000000000010000
    [Token(Token = "0x400E3A4")] Fast = 131072, // 0x0000000000020000
    [Token(Token = "0x400E3A5")] Slow = 262144, // 0x0000000000040000
    [Token(Token = "0x400E3A6")] AutoHeal = 524288, // 0x0000000000080000
    [Token(Token = "0x400E3A7")] Donsoku = 1048576, // 0x0000000000100000
    [Token(Token = "0x400E3A8")] Rage = 2097152, // 0x0000000000200000
    [Token(Token = "0x400E3A9")] GoodSleep = 4194304, // 0x0000000000400000
    [Token(Token = "0x400E3AA")] AutoJewel = 8388608, // 0x0000000000800000
    [Token(Token = "0x400E3AB")] DisableHeal = 16777216, // 0x0000000001000000
    [Token(Token = "0x400E3AC")] DisableSingleAttack = 33554432, // 0x0000000002000000
    [Token(Token = "0x400E3AD")] DisableAreaAttack = 67108864, // 0x0000000004000000
    [Token(Token = "0x400E3AE")] DisableDecCT = 134217728, // 0x0000000008000000
    [Token(Token = "0x400E3AF")] DisableIncCT = 268435456, // 0x0000000010000000
    [Token(Token = "0x400E3B0")] DisableEsaFire = 536870912, // 0x0000000020000000
    [Token(Token = "0x400E3B1")] DisableEsaWater = 1073741824, // 0x0000000040000000
    [Token(Token = "0x400E3B2")] DisableEsaWind = 2147483648, // 0x0000000080000000
    [Token(Token = "0x400E3B3")] DisableEsaThunder = 4294967296, // 0x0000000100000000
    [Token(Token = "0x400E3B4")] DisableEsaShine = 8589934592, // 0x0000000200000000
    [Token(Token = "0x400E3B5")] DisableEsaDark = 17179869184, // 0x0000000400000000
    [Token(Token = "0x400E3B6")] DisableMaxDamageHp = 34359738368, // 0x0000000800000000
    [Token(Token = "0x400E3B7")] DisableMaxDamageMp = 68719476736, // 0x0000001000000000
    [Token(Token = "0x400E3B8")] DisableSideAttack = 137438953472, // 0x0000002000000000
    [Token(Token = "0x400E3B9")] DisableBackAttack = 274877906944, // 0x0000004000000000
    [Token(Token = "0x400E3BA")] DisableObstReaction = 549755813888, // 0x0000008000000000
    [Token(Token = "0x400E3BB")] DisableForcedTargeting = 1099511627776, // 0x0000010000000000
    [Token(Token = "0x400E3BC")] DisableSupport = 2199023255552, // 0x0000020000000000
    [Token(Token = "0x400E3BD")] Bomb = 4398046511104, // 0x0000040000000000
    [Token(Token = "0x400E3BE")] Slip = 8796093022208, // 0x0000080000000000
    [Token(Token = "0x400E3BF")] Freeze = 17592186044416, // 0x0000100000000000
    [Token(Token = "0x400E3C0")] Down = 35184372088832, // 0x0000200000000000
  }
}
