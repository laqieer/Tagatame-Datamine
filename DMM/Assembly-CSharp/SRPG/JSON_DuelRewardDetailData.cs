﻿// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_DuelRewardDetailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200230C")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_DuelRewardDetailData
  {
    [Token(Token = "0x4009C62")]
    [FieldOffset(Offset = "0x8")]
    public JSON_DuelRewardData[] win;
    [Token(Token = "0x4009C63")]
    [FieldOffset(Offset = "0xC")]
    public JSON_DuelRewardData[] lose;
    [Token(Token = "0x4009C64")]
    [FieldOffset(Offset = "0x10")]
    public JSON_DuelRewardData[] win_streak;
    [Token(Token = "0x4009C65")]
    [FieldOffset(Offset = "0x14")]
    public JSON_DuelRewardData[] win_total;

    [Token(Token = "0x60096CE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_DuelRewardDetailData()
    {
    }
  }
}