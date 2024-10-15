// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_WorldRaidLogData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D58")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_WorldRaidLogData
  {
    [Token(Token = "0x400E221")]
    [FieldOffset(Offset = "0x8")]
    public int log_id;
    [Token(Token = "0x400E222")]
    [FieldOffset(Offset = "0xC")]
    public string boss_iname;
    [Token(Token = "0x400E223")]
    [FieldOffset(Offset = "0x10")]
    public string player_name;
    [Token(Token = "0x400E224")]
    [FieldOffset(Offset = "0x18")]
    public long damage;

    [Token(Token = "0x600D33D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_WorldRaidLogData()
    {
    }
  }
}
