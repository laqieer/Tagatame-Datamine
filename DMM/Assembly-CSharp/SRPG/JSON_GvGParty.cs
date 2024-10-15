// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GvGParty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025A5")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GvGParty
  {
    [Token(Token = "0x400AED0")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x400AED1")]
    [FieldOffset(Offset = "0xC")]
    public int win_num;
    [Token(Token = "0x400AED2")]
    [FieldOffset(Offset = "0x10")]
    public int beat_num;
    [Token(Token = "0x400AED3")]
    [FieldOffset(Offset = "0x14")]
    public int is_npc;
    [Token(Token = "0x400AED4")]
    [FieldOffset(Offset = "0x18")]
    public int role;
    [Token(Token = "0x400AED5")]
    [FieldOffset(Offset = "0x1C")]
    public string name;
    [Token(Token = "0x400AED6")]
    [FieldOffset(Offset = "0x20")]
    public JSON_GvGPartyUnit[] units;
    [Token(Token = "0x400AED7")]
    [FieldOffset(Offset = "0x24")]
    public JSON_GvGPartyNPC[] npc_units;
    [Token(Token = "0x400AED8")]
    [FieldOffset(Offset = "0x28")]
    public JSON_PlayerBuff player_buff;

    [Token(Token = "0x600A74E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GvGParty()
    {
    }
  }
}
