// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GenesisRewardDataParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B0F")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GenesisRewardDataParam
  {
    [Token(Token = "0x400672F")]
    [FieldOffset(Offset = "0x8")]
    public int item_type;
    [Token(Token = "0x4006730")]
    [FieldOffset(Offset = "0xC")]
    public string item_iname;
    [Token(Token = "0x4006731")]
    [FieldOffset(Offset = "0x10")]
    public int item_num;

    [Token(Token = "0x6006FC1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GenesisRewardDataParam()
    {
    }
  }
}
