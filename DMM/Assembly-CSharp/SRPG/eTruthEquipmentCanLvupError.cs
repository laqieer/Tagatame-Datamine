// Decompiled with JetBrains decompiler
// Type: SRPG.eTruthEquipmentCanLvupError
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001177")]
  [Flags]
  public enum eTruthEquipmentCanLvupError
  {
    [Token(Token = "0x4003F47")] NoError = 0,
    [Token(Token = "0x4003F48")] AlreadyLvMax = 1,
    [Token(Token = "0x4003F49")] CommingSoon = 2,
    [Token(Token = "0x4003F4A")] NotEnoughZenny = 4,
    [Token(Token = "0x4003F4B")] NotEnoughItem = 8,
  }
}
