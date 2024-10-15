// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RuneLotteryEvoStatePack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CEA")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RuneLotteryEvoStatePack
  {
    [Token(Token = "0x4007154")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007155")]
    [FieldOffset(Offset = "0xC")]
    public JSON_RuneLotteryStatePack[] lottery_state;

    [Token(Token = "0x60076C8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RuneLotteryEvoStatePack()
    {
    }
  }
}
