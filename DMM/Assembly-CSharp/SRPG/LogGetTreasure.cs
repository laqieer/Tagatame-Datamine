﻿// Decompiled with JetBrains decompiler
// Type: SRPG.LogGetTreasure
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BE7")]
  public class LogGetTreasure : BattleLog
  {
    [Token(Token = "0x4001E60")]
    [FieldOffset(Offset = "0x8")]
    public Unit self;
    [Token(Token = "0x4001E61")]
    [FieldOffset(Offset = "0xC")]
    public bool is_camera_move;

    [Token(Token = "0x6002FD7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LogGetTreasure()
    {
    }
  }
}