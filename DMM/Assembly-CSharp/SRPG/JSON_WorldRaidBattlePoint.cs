// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_WorldRaidBattlePoint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D59")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_WorldRaidBattlePoint
  {
    [Token(Token = "0x400E225")]
    [FieldOffset(Offset = "0x8")]
    public int num;
    [Token(Token = "0x400E226")]
    [FieldOffset(Offset = "0xC")]
    public int start_time;
    [Token(Token = "0x400E227")]
    [FieldOffset(Offset = "0x10")]
    public int heal_num;

    [Token(Token = "0x600D33E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_WorldRaidBattlePoint()
    {
    }
  }
}
