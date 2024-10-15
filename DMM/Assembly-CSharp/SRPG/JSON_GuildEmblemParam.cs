// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildEmblemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B3A")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildEmblemParam
  {
    [Token(Token = "0x40067B4")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40067B5")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x40067B6")]
    [FieldOffset(Offset = "0x10")]
    public int cnds_type;
    [Token(Token = "0x40067B7")]
    [FieldOffset(Offset = "0x14")]
    public int cnds_val;
    [Token(Token = "0x40067B8")]
    [FieldOffset(Offset = "0x18")]
    public string image;
    [Token(Token = "0x40067B9")]
    [FieldOffset(Offset = "0x1C")]
    public string start_at;
    [Token(Token = "0x40067BA")]
    [FieldOffset(Offset = "0x20")]
    public string end_at;

    [Token(Token = "0x6007036")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildEmblemParam()
    {
    }
  }
}
