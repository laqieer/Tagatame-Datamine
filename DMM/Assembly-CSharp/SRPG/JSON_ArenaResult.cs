// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ArenaResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BE1")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ArenaResult
  {
    [Token(Token = "0x4006BCC")]
    [FieldOffset(Offset = "0x8")]
    public int rank;
    [Token(Token = "0x4006BCD")]
    [FieldOffset(Offset = "0xC")]
    public int coin;
    [Token(Token = "0x4006BCE")]
    [FieldOffset(Offset = "0x10")]
    public int gold;
    [Token(Token = "0x4006BCF")]
    [FieldOffset(Offset = "0x14")]
    public int ac;
    [Token(Token = "0x4006BD0")]
    [FieldOffset(Offset = "0x18")]
    public string item1;
    [Token(Token = "0x4006BD1")]
    [FieldOffset(Offset = "0x1C")]
    public string item2;
    [Token(Token = "0x4006BD2")]
    [FieldOffset(Offset = "0x20")]
    public string item3;
    [Token(Token = "0x4006BD3")]
    [FieldOffset(Offset = "0x24")]
    public string item4;
    [Token(Token = "0x4006BD4")]
    [FieldOffset(Offset = "0x28")]
    public string item5;
    [Token(Token = "0x4006BD5")]
    [FieldOffset(Offset = "0x2C")]
    public int num1;
    [Token(Token = "0x4006BD6")]
    [FieldOffset(Offset = "0x30")]
    public int num2;
    [Token(Token = "0x4006BD7")]
    [FieldOffset(Offset = "0x34")]
    public int num3;
    [Token(Token = "0x4006BD8")]
    [FieldOffset(Offset = "0x38")]
    public int num4;
    [Token(Token = "0x4006BD9")]
    [FieldOffset(Offset = "0x3C")]
    public int num5;
    [Token(Token = "0x4006BDA")]
    [FieldOffset(Offset = "0x40")]
    public string begin_at;
    [Token(Token = "0x4006BDB")]
    [FieldOffset(Offset = "0x44")]
    public string end_at;

    [Token(Token = "0x6007308")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ArenaResult()
    {
    }
  }
}
