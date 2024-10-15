// Decompiled with JetBrains decompiler
// Type: SRPG.EUnitFlag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D8B")]
  public enum EUnitFlag : long
  {
    [Token(Token = "0x400E36A")] Entried = 1,
    [Token(Token = "0x400E36B")] Moved = 2,
    [Token(Token = "0x400E36C")] Action = 4,
    [Token(Token = "0x400E36D")] Searched = 8,
    [Token(Token = "0x400E36E")] Defended = 16, // 0x0000000000000010
    [Token(Token = "0x400E36F")] SideAttack = 32, // 0x0000000000000020
    [Token(Token = "0x400E370")] BackAttack = 64, // 0x0000000000000040
    [Token(Token = "0x400E371")] Escaped = 128, // 0x0000000000000080
    [Token(Token = "0x400E372")] Sneaking = 256, // 0x0000000000000100
    [Token(Token = "0x400E373")] Paralysed = 512, // 0x0000000000000200
    [Token(Token = "0x400E374")] ForceMoved = 1024, // 0x0000000000000400
    [Token(Token = "0x400E375")] ForceEntried = 2048, // 0x0000000000000800
    [Token(Token = "0x400E376")] ForceAuto = 4096, // 0x0000000000001000
    [Token(Token = "0x400E377")] EntryDead = 8192, // 0x0000000000002000
    [Token(Token = "0x400E378")] FirstAction = 16384, // 0x0000000000004000
    [Token(Token = "0x400E379")] DisableFirstVoice = 32768, // 0x0000000000008000
    [Token(Token = "0x400E37A")] DamagedActionStart = 65536, // 0x0000000000010000
    [Token(Token = "0x400E37B")] TriggeredAutoSkills = 131072, // 0x0000000000020000
    [Token(Token = "0x400E37C")] DisableUnitChange = 262144, // 0x0000000000040000
    [Token(Token = "0x400E37D")] UnitChanged = 524288, // 0x0000000000080000
    [Token(Token = "0x400E37E")] UnitWithdraw = 1048576, // 0x0000000000100000
    [Token(Token = "0x400E37F")] CreatedBreakObj = 2097152, // 0x0000000000200000
    [Token(Token = "0x400E380")] Reinforcement = 4194304, // 0x0000000000400000
    [Token(Token = "0x400E381")] ToDying = 8388608, // 0x0000000000800000
    [Token(Token = "0x400E382")] OtherTeam = 16777216, // 0x0000000001000000
    [Token(Token = "0x400E383")] IsHelp = 33554432, // 0x0000000002000000
    [Token(Token = "0x400E384")] IsDynamicTransform = 67108864, // 0x0000000004000000
    [Token(Token = "0x400E385")] InfinitySpawn = 134217728, // 0x0000000008000000
    [Token(Token = "0x400E386")] UnitTransformed = 268435456, // 0x0000000010000000
    [Token(Token = "0x400E387")] IsDtuExec = 536870912, // 0x0000000020000000
    [Token(Token = "0x400E388")] IsDtuUscInitialized = 1073741824, // 0x0000000040000000
    [Token(Token = "0x400E389")] IsSaveCommandMove = 2147483648, // 0x0000000080000000
    [Token(Token = "0x400E38A")] IsTurnNoChange = 4294967296, // 0x0000000100000000
    [Token(Token = "0x400E38B")] isOnceAgain = 8589934592, // 0x0000000200000000
  }
}
