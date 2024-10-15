// Decompiled with JetBrains decompiler
// Type: SRPG.MasteryRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BED")]
  [MessagePackObject(true)]
  [Serializable]
  public class MasteryRewardParam
  {
    [Token(Token = "0x4006BF8")]
    [FieldOffset(Offset = "0x8")]
    public string Iname;
    [Token(Token = "0x4006BF9")]
    [FieldOffset(Offset = "0xC")]
    public int AchieveNum;
    [Token(Token = "0x4006BFA")]
    [FieldOffset(Offset = "0x10")]
    public int Rank;
    [Token(Token = "0x4006BFB")]
    [FieldOffset(Offset = "0x14")]
    public string EmblemPath;
    [Token(Token = "0x4006BFC")]
    [FieldOffset(Offset = "0x18")]
    public List<MasteryRewardItemParam> rewards;

    [Token(Token = "0x6007324")]
    [Address(RVA = "0x37BC90", Offset = "0x37AA90", VA = "0x1037BC90")]
    public bool Deserialize(JSON_MasteryRewardParam json) => new bool();

    [Token(Token = "0x6007325")]
    [Address(RVA = "0x37BE00", Offset = "0x37AC00", VA = "0x1037BE00")]
    public static void Deserialize(
      ref List<MasteryRewardParam> param,
      JSON_MasteryRewardParam[] json)
    {
    }

    [Token(Token = "0x6007326")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MasteryRewardParam()
    {
    }
  }
}
