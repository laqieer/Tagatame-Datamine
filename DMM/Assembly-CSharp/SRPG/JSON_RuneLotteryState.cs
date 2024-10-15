// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RuneLotteryState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CD7")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RuneLotteryState
  {
    [Token(Token = "0x4007107")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007108")]
    [FieldOffset(Offset = "0xC")]
    public int type;
    [Token(Token = "0x4007109")]
    [FieldOffset(Offset = "0x10")]
    public int calc;
    [Token(Token = "0x400710A")]
    [FieldOffset(Offset = "0x14")]
    public JSON_RuneLottery[] lottery;

    [Token(Token = "0x6007697")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RuneLotteryState()
    {
    }
  }
}
