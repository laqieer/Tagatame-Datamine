﻿// Decompiled with JetBrains decompiler
// Type: SRPG.Json_GuildTrainingReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002531")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_GuildTrainingReward
  {
    [Token(Token = "0x400AA45")]
    [FieldOffset(Offset = "0x8")]
    public int itype;
    [Token(Token = "0x400AA46")]
    [FieldOffset(Offset = "0xC")]
    public string iname;
    [Token(Token = "0x400AA47")]
    [FieldOffset(Offset = "0x10")]
    public int num;

    [Token(Token = "0x600A3BD")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_GuildTrainingReward()
    {
    }
  }
}