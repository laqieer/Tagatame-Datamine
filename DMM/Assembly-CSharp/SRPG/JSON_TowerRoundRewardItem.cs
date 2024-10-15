// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_TowerRoundRewardItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D77")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_TowerRoundRewardItem : JSON_TowerRewardItem
  {
    [Token(Token = "0x4007464")]
    [FieldOffset(Offset = "0x14")]
    public byte round_num;

    [Token(Token = "0x600789A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_TowerRoundRewardItem()
    {
    }
  }
}
