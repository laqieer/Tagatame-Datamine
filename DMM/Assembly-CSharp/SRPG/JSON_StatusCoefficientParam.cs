// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_StatusCoefficientParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D51")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_StatusCoefficientParam
  {
    [Token(Token = "0x400735B")]
    [FieldOffset(Offset = "0x8")]
    public float hp;
    [Token(Token = "0x400735C")]
    [FieldOffset(Offset = "0xC")]
    public float atk;
    [Token(Token = "0x400735D")]
    [FieldOffset(Offset = "0x10")]
    public float def;
    [Token(Token = "0x400735E")]
    [FieldOffset(Offset = "0x14")]
    public float matk;
    [Token(Token = "0x400735F")]
    [FieldOffset(Offset = "0x18")]
    public float mdef;
    [Token(Token = "0x4007360")]
    [FieldOffset(Offset = "0x1C")]
    public float dex;
    [Token(Token = "0x4007361")]
    [FieldOffset(Offset = "0x20")]
    public float spd;
    [Token(Token = "0x4007362")]
    [FieldOffset(Offset = "0x24")]
    public float cri;
    [Token(Token = "0x4007363")]
    [FieldOffset(Offset = "0x28")]
    public float luck;
    [Token(Token = "0x4007364")]
    [FieldOffset(Offset = "0x2C")]
    public float cmb;
    [Token(Token = "0x4007365")]
    [FieldOffset(Offset = "0x30")]
    public float move;
    [Token(Token = "0x4007366")]
    [FieldOffset(Offset = "0x34")]
    public float jmp;

    [Token(Token = "0x6007816")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_StatusCoefficientParam()
    {
    }
  }
}
