// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_DuelPlayerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002311")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_DuelPlayerData
  {
    [Token(Token = "0x4009C6D")]
    [FieldOffset(Offset = "0x8")]
    public string fuid;
    [Token(Token = "0x4009C6E")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4009C6F")]
    [FieldOffset(Offset = "0x10")]
    public int lv;
    [Token(Token = "0x4009C70")]
    [FieldOffset(Offset = "0x14")]
    public Json_Unit[] units;
    [Token(Token = "0x4009C71")]
    [FieldOffset(Offset = "0x18")]
    public string award;
    [Token(Token = "0x4009C72")]
    [FieldOffset(Offset = "0x1C")]
    public JSON_ViewGuild guild;
    [Token(Token = "0x4009C73")]
    [FieldOffset(Offset = "0x20")]
    public int rank;
    [Token(Token = "0x4009C74")]
    [FieldOffset(Offset = "0x24")]
    public string rank_point;
    [Token(Token = "0x4009C75")]
    [FieldOffset(Offset = "0x28")]
    public long btl_at;
    [Token(Token = "0x4009C76")]
    [FieldOffset(Offset = "0x30")]
    public JSON_PlayerBuff player_buff;

    [Token(Token = "0x60096D3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_DuelPlayerData()
    {
    }
  }
}
