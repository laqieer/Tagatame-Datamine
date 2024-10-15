// Decompiled with JetBrains decompiler
// Type: SRPG.Json_Friend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001017")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_Friend
  {
    [Token(Token = "0x4003936")]
    [FieldOffset(Offset = "0x8")]
    public string uid;
    [Token(Token = "0x4003937")]
    [FieldOffset(Offset = "0xC")]
    public string fuid;
    [Token(Token = "0x4003938")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x4003939")]
    [FieldOffset(Offset = "0x14")]
    public string type;
    [Token(Token = "0x400393A")]
    [FieldOffset(Offset = "0x18")]
    public int lv;
    [Token(Token = "0x400393B")]
    [FieldOffset(Offset = "0x20")]
    public long lastlogin;
    [Token(Token = "0x400393C")]
    [FieldOffset(Offset = "0x28")]
    public int is_multi_push;
    [Token(Token = "0x400393D")]
    [FieldOffset(Offset = "0x2C")]
    public string multi_comment;
    [Token(Token = "0x400393E")]
    [FieldOffset(Offset = "0x30")]
    public Json_Unit unit;
    [Token(Token = "0x400393F")]
    [FieldOffset(Offset = "0x34")]
    public JSON_PlayerBuff player_buff;
    [Token(Token = "0x4003940")]
    [FieldOffset(Offset = "0x38")]
    public string created_at;
    [Token(Token = "0x4003941")]
    [FieldOffset(Offset = "0x3C")]
    public int is_favorite;
    [Token(Token = "0x4003942")]
    [FieldOffset(Offset = "0x40")]
    public string award;
    [Token(Token = "0x4003943")]
    [FieldOffset(Offset = "0x44")]
    public string wish;
    [Token(Token = "0x4003944")]
    [FieldOffset(Offset = "0x48")]
    public string status;
    [Token(Token = "0x4003945")]
    [FieldOffset(Offset = "0x4C")]
    public JSON_ViewGuild guild;
    [Token(Token = "0x4003946")]
    [FieldOffset(Offset = "0x50")]
    public int npc_id;

    [Token(Token = "0x600427B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_Friend()
    {
    }
  }
}
