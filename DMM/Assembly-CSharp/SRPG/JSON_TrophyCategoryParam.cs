// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_TrophyCategoryParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D8F")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_TrophyCategoryParam
  {
    [Token(Token = "0x40074F1")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40074F2")]
    [FieldOffset(Offset = "0xC")]
    public int hash_code;
    [Token(Token = "0x40074F3")]
    [FieldOffset(Offset = "0x10")]
    public int category;
    [Token(Token = "0x40074F4")]
    [FieldOffset(Offset = "0x14")]
    public int is_not_pull;
    [Token(Token = "0x40074F5")]
    [FieldOffset(Offset = "0x18")]
    public int day_reset;
    [Token(Token = "0x40074F6")]
    [FieldOffset(Offset = "0x1C")]
    public int bgnr;
    [Token(Token = "0x40074F7")]
    [FieldOffset(Offset = "0x20")]
    public string begin_at;
    [Token(Token = "0x40074F8")]
    [FieldOffset(Offset = "0x24")]
    public string end_at;
    [Token(Token = "0x40074F9")]
    [FieldOffset(Offset = "0x28")]
    public string linked_quest;
    [Token(Token = "0x40074FA")]
    [FieldOffset(Offset = "0x2C")]
    public string banner;

    [Token(Token = "0x60078F9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_TrophyCategoryParam()
    {
    }
  }
}
