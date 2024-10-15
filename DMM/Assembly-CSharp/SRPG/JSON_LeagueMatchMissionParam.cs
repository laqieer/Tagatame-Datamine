// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LeagueMatchMissionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BB9")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_LeagueMatchMissionParam
  {
    [Token(Token = "0x4006A0F")]
    [FieldOffset(Offset = "0x8")]
    public int season_id;
    [Token(Token = "0x4006A10")]
    [FieldOffset(Offset = "0xC")]
    public string iname;
    [Token(Token = "0x4006A11")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x4006A12")]
    [FieldOffset(Offset = "0x14")]
    public string expr;
    [Token(Token = "0x4006A13")]
    [FieldOffset(Offset = "0x18")]
    public int type;
    [Token(Token = "0x4006A14")]
    [FieldOffset(Offset = "0x1C")]
    public int ival;
    [Token(Token = "0x4006A15")]
    [FieldOffset(Offset = "0x20")]
    public string reward_id;

    [Token(Token = "0x6007270")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LeagueMatchMissionParam()
    {
    }
  }
}
