// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_EvaluationParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001ACD")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_EvaluationParam
  {
    [Token(Token = "0x4006364")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006365")]
    [FieldOffset(Offset = "0xC")]
    public int val;
    [Token(Token = "0x4006366")]
    [FieldOffset(Offset = "0x10")]
    public int hp;
    [Token(Token = "0x4006367")]
    [FieldOffset(Offset = "0x14")]
    public int mp;
    [Token(Token = "0x4006368")]
    [FieldOffset(Offset = "0x18")]
    public int atk;
    [Token(Token = "0x4006369")]
    [FieldOffset(Offset = "0x1C")]
    public int def;
    [Token(Token = "0x400636A")]
    [FieldOffset(Offset = "0x20")]
    public int mag;
    [Token(Token = "0x400636B")]
    [FieldOffset(Offset = "0x24")]
    public int mnd;
    [Token(Token = "0x400636C")]
    [FieldOffset(Offset = "0x28")]
    public int dex;
    [Token(Token = "0x400636D")]
    [FieldOffset(Offset = "0x2C")]
    public int spd;
    [Token(Token = "0x400636E")]
    [FieldOffset(Offset = "0x30")]
    public int cri;
    [Token(Token = "0x400636F")]
    [FieldOffset(Offset = "0x34")]
    public int luk;

    [Token(Token = "0x6006E75")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_EvaluationParam()
    {
    }
  }
}
