// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_VersusRankParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001ED3")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_VersusRankParam
  {
    [Token(Token = "0x400819A")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x400819B")]
    [FieldOffset(Offset = "0xC")]
    public int btl_mode;
    [Token(Token = "0x400819C")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x400819D")]
    [FieldOffset(Offset = "0x14")]
    public int limit;
    [Token(Token = "0x400819E")]
    [FieldOffset(Offset = "0x18")]
    public string begin_at;
    [Token(Token = "0x400819F")]
    [FieldOffset(Offset = "0x1C")]
    public string end_at;
    [Token(Token = "0x40081A0")]
    [FieldOffset(Offset = "0x20")]
    public string[] disabledate;
    [Token(Token = "0x40081A1")]
    [FieldOffset(Offset = "0x24")]
    public string hurl;

    [Token(Token = "0x6007E22")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_VersusRankParam()
    {
    }
  }
}
