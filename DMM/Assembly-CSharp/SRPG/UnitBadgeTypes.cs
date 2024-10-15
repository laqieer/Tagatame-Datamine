// Decompiled with JetBrains decompiler
// Type: SRPG.UnitBadgeTypes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002DCE")]
  [Flags]
  public enum UnitBadgeTypes
  {
    [Token(Token = "0x400E4F1")] EnableEquipment = 1,
    [Token(Token = "0x400E4F2")] EnableAwaking = 2,
    [Token(Token = "0x400E4F3")] EnableRarityUp = 4,
    [Token(Token = "0x400E4F4")] EnableJobRankUp = 8,
    [Token(Token = "0x400E4F5")] EnableClassChange = 16, // 0x00000010
  }
}
