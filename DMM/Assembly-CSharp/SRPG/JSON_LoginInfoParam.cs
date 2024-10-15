// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LoginInfoParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BCF")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_LoginInfoParam
  {
    [Token(Token = "0x4006A97")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006A98")]
    [FieldOffset(Offset = "0xC")]
    public string path;
    [Token(Token = "0x4006A99")]
    [FieldOffset(Offset = "0x10")]
    public int scene;
    [Token(Token = "0x4006A9A")]
    [FieldOffset(Offset = "0x14")]
    public string begin_at;
    [Token(Token = "0x4006A9B")]
    [FieldOffset(Offset = "0x18")]
    public string end_at;
    [Token(Token = "0x4006A9C")]
    [FieldOffset(Offset = "0x1C")]
    public int conditions;
    [Token(Token = "0x4006A9D")]
    [FieldOffset(Offset = "0x20")]
    public int conditions_value;
    [Token(Token = "0x4006A9E")]
    [FieldOffset(Offset = "0x24")]
    public int priority;
    [Token(Token = "0x4006A9F")]
    [FieldOffset(Offset = "0x28")]
    public int draw_count;
    [Token(Token = "0x4006AA0")]
    [FieldOffset(Offset = "0x2C")]
    public int movie_compel;
    [Token(Token = "0x4006AA1")]
    [FieldOffset(Offset = "0x30")]
    public string movie;
    [Token(Token = "0x4006AA2")]
    [FieldOffset(Offset = "0x34")]
    public string url;

    [Token(Token = "0x60072E3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LoginInfoParam()
    {
    }
  }
}
