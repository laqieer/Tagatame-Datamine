// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ChapterParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A46")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ChapterParam
  {
    [Token(Token = "0x40060C5")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40060C6")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x40060C7")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x40060C8")]
    [FieldOffset(Offset = "0x14")]
    public string world;
    [Token(Token = "0x40060C9")]
    [FieldOffset(Offset = "0x18")]
    public long start;
    [Token(Token = "0x40060CA")]
    [FieldOffset(Offset = "0x20")]
    public long end;
    [Token(Token = "0x40060CB")]
    [FieldOffset(Offset = "0x28")]
    public string parent;
    [Token(Token = "0x40060CC")]
    [FieldOffset(Offset = "0x2C")]
    public int hide;
    [Token(Token = "0x40060CD")]
    [FieldOffset(Offset = "0x30")]
    public string chap;
    [Token(Token = "0x40060CE")]
    [FieldOffset(Offset = "0x34")]
    public string banr;
    [Token(Token = "0x40060CF")]
    [FieldOffset(Offset = "0x38")]
    public string item;
    [Token(Token = "0x40060D0")]
    [FieldOffset(Offset = "0x3C")]
    public string keyitem1;
    [Token(Token = "0x40060D1")]
    [FieldOffset(Offset = "0x40")]
    public int keynum1;
    [Token(Token = "0x40060D2")]
    [FieldOffset(Offset = "0x44")]
    public string keyitem2;
    [Token(Token = "0x40060D3")]
    [FieldOffset(Offset = "0x48")]
    public int keynum2;
    [Token(Token = "0x40060D4")]
    [FieldOffset(Offset = "0x4C")]
    public string keyitem3;
    [Token(Token = "0x40060D5")]
    [FieldOffset(Offset = "0x50")]
    public int keynum3;
    [Token(Token = "0x40060D6")]
    [FieldOffset(Offset = "0x58")]
    public long keytime;
    [Token(Token = "0x40060D7")]
    [FieldOffset(Offset = "0x60")]
    public string hurl;
    [Token(Token = "0x40060D8")]
    [FieldOffset(Offset = "0x64")]
    public int limit;

    [Token(Token = "0x6006C03")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ChapterParam()
    {
    }
  }
}
