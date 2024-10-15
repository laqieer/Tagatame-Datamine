// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LeagueMatchDefenseEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011A6")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_LeagueMatchDefenseEntry
  {
    [Token(Token = "0x4004018")]
    [FieldOffset(Offset = "0x8")]
    public int party_no;
    [Token(Token = "0x4004019")]
    [FieldOffset(Offset = "0xC")]
    public long[] units;
    [Token(Token = "0x400401A")]
    [FieldOffset(Offset = "0x10")]
    public string map;
    [Token(Token = "0x400401B")]
    [FieldOffset(Offset = "0x14")]
    public JSON_LeagueMatchSet[] placement;
    [Token(Token = "0x400401C")]
    [FieldOffset(Offset = "0x18")]
    public string[] buffs;

    [Token(Token = "0x6004B20")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LeagueMatchDefenseEntry()
    {
    }
  }
}
