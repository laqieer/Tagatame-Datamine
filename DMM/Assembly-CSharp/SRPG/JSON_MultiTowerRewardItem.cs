// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_MultiTowerRewardItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BF4")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_MultiTowerRewardItem
  {
    [Token(Token = "0x4006C32")]
    [FieldOffset(Offset = "0x8")]
    public int round_st;
    [Token(Token = "0x4006C33")]
    [FieldOffset(Offset = "0xC")]
    public int round_ed;
    [Token(Token = "0x4006C34")]
    [FieldOffset(Offset = "0x10")]
    public int type;
    [Token(Token = "0x4006C35")]
    [FieldOffset(Offset = "0x14")]
    public string itemname;
    [Token(Token = "0x4006C36")]
    [FieldOffset(Offset = "0x18")]
    public int num;

    [Token(Token = "0x6007330")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_MultiTowerRewardItem()
    {
    }
  }
}
