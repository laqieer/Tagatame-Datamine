// Decompiled with JetBrains decompiler
// Type: SRPG.MasteryRewardItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BEC")]
  [MessagePackObject(true)]
  [Serializable]
  public class MasteryRewardItemParam
  {
    [Token(Token = "0x4006BF5")]
    [FieldOffset(Offset = "0x8")]
    public RaidRewardType Type;
    [Token(Token = "0x4006BF6")]
    [FieldOffset(Offset = "0xC")]
    public string Iname;
    [Token(Token = "0x4006BF7")]
    [FieldOffset(Offset = "0x10")]
    public int Num;

    [Token(Token = "0x6007322")]
    [Address(RVA = "0x34D780", Offset = "0x34C580", VA = "0x1034D780")]
    public bool Deserialize(JSON_MasteryRewardItemParam json) => new bool();

    [Token(Token = "0x6007323")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MasteryRewardItemParam()
    {
    }
  }
}
