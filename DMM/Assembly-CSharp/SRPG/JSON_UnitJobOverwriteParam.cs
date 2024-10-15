// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_UnitJobOverwriteParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E86")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_UnitJobOverwriteParam
  {
    [Token(Token = "0x4007EA0")]
    [FieldOffset(Offset = "0x8")]
    public string unit_iname;
    [Token(Token = "0x4007EA1")]
    [FieldOffset(Offset = "0xC")]
    public string job_iname;
    [Token(Token = "0x4007EA2")]
    [FieldOffset(Offset = "0x10")]
    public int hp;
    [Token(Token = "0x4007EA3")]
    [FieldOffset(Offset = "0x14")]
    public int mp;
    [Token(Token = "0x4007EA4")]
    [FieldOffset(Offset = "0x18")]
    public int atk;
    [Token(Token = "0x4007EA5")]
    [FieldOffset(Offset = "0x1C")]
    public int def;
    [Token(Token = "0x4007EA6")]
    [FieldOffset(Offset = "0x20")]
    public int mag;
    [Token(Token = "0x4007EA7")]
    [FieldOffset(Offset = "0x24")]
    public int mnd;
    [Token(Token = "0x4007EA8")]
    [FieldOffset(Offset = "0x28")]
    public int dex;
    [Token(Token = "0x4007EA9")]
    [FieldOffset(Offset = "0x2C")]
    public int spd;
    [Token(Token = "0x4007EAA")]
    [FieldOffset(Offset = "0x30")]
    public int cri;
    [Token(Token = "0x4007EAB")]
    [FieldOffset(Offset = "0x34")]
    public int luk;
    [Token(Token = "0x4007EAC")]
    [FieldOffset(Offset = "0x38")]
    public int avoid;
    [Token(Token = "0x4007EAD")]
    [FieldOffset(Offset = "0x3C")]
    public int inimp;

    [Token(Token = "0x6007D2D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_UnitJobOverwriteParam()
    {
    }
  }
}
