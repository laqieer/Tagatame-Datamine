﻿// Decompiled with JetBrains decompiler
// Type: SRPG.MultiPlayTrickParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000DA1")]
  [MessagePackObject(true)]
  [Serializable]
  public class MultiPlayTrickParam
  {
    [Token(Token = "0x4002721")]
    [FieldOffset(Offset = "0x8")]
    public string tid;
    [Token(Token = "0x4002722")]
    [FieldOffset(Offset = "0xC")]
    public bool val;
    [Token(Token = "0x4002723")]
    [FieldOffset(Offset = "0x10")]
    public int cun;
    [Token(Token = "0x4002724")]
    [FieldOffset(Offset = "0x14")]
    public int rnk;
    [Token(Token = "0x4002725")]
    [FieldOffset(Offset = "0x18")]
    public int rcp;
    [Token(Token = "0x4002726")]
    [FieldOffset(Offset = "0x1C")]
    public int grx;
    [Token(Token = "0x4002727")]
    [FieldOffset(Offset = "0x20")]
    public int gry;
    [Token(Token = "0x4002728")]
    [FieldOffset(Offset = "0x24")]
    public int rac;
    [Token(Token = "0x4002729")]
    [FieldOffset(Offset = "0x28")]
    public int ccl;
    [Token(Token = "0x400272A")]
    [FieldOffset(Offset = "0x2C")]
    public string tag;

    [Token(Token = "0x600373E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MultiPlayTrickParam()
    {
    }
  }
}