// Decompiled with JetBrains decompiler
// Type: SRPG.PlayerCoinBuyUseBonusRewardState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A54")]
  public class PlayerCoinBuyUseBonusRewardState
  {
    [Token(Token = "0x400611F")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006120")]
    [FieldOffset(Offset = "0xC")]
    public int num;
    [Token(Token = "0x4006121")]
    [FieldOffset(Offset = "0x10")]
    public DateTime rewarded_at;

    [Token(Token = "0x17000BC5")]
    public bool IsReceived
    {
      [Token(Token = "0x6006C39"), Address(RVA = "0x359EA0", Offset = "0x358CA0", VA = "0x10359EA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6006C3A")]
    [Address(RVA = "0x359DE0", Offset = "0x358BE0", VA = "0x10359DE0")]
    public void Deserialize(JSON_PlayerCoinBuyUseBonusRewardState json)
    {
    }

    [Token(Token = "0x6006C3B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PlayerCoinBuyUseBonusRewardState()
    {
    }
  }
}
