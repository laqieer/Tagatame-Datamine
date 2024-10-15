// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GvGLeagueParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B6B")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GvGLeagueParam : JSON_GvGMasterParam
  {
    [Token(Token = "0x4006883")]
    [FieldOffset(Offset = "0x8")]
    public string id;
    [Token(Token = "0x4006884")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4006885")]
    [FieldOffset(Offset = "0x10")]
    public int min_rate;
    [Token(Token = "0x4006886")]
    [FieldOffset(Offset = "0x14")]
    public int max_rate;
    [Token(Token = "0x4006887")]
    [FieldOffset(Offset = "0x18")]
    public string begin_at;
    [Token(Token = "0x4006888")]
    [FieldOffset(Offset = "0x1C")]
    public string end_at;
    [Token(Token = "0x4006889")]
    [FieldOffset(Offset = "0x20")]
    public string ranking_reward;
    [Token(Token = "0x400688A")]
    [FieldOffset(Offset = "0x24")]
    public int sprite_key;

    [Token(Token = "0x6007128")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GvGLeagueParam()
    {
    }
  }
}
