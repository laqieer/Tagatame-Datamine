// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_MasteryRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BEB")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_MasteryRewardParam
  {
    [Token(Token = "0x4006BF0")]
    [FieldOffset(Offset = "0x8")]
    public string reward_id;
    [Token(Token = "0x4006BF1")]
    [FieldOffset(Offset = "0xC")]
    public int achieve_num;
    [Token(Token = "0x4006BF2")]
    [FieldOffset(Offset = "0x10")]
    public int rank;
    [Token(Token = "0x4006BF3")]
    [FieldOffset(Offset = "0x14")]
    public string emblem_path;
    [Token(Token = "0x4006BF4")]
    [FieldOffset(Offset = "0x18")]
    public JSON_MasteryRewardItemParam[] rewards;

    [Token(Token = "0x6007321")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_MasteryRewardParam()
    {
    }
  }
}
