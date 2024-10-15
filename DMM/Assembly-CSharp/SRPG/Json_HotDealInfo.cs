// Decompiled with JetBrains decompiler
// Type: SRPG.Json_HotDealInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019CB")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_HotDealInfo
  {
    [Token(Token = "0x4005ED4")]
    [FieldOffset(Offset = "0x8")]
    public string buy_coin_product_id;
    [Token(Token = "0x4005ED5")]
    [FieldOffset(Offset = "0x10")]
    public long start_time;
    [Token(Token = "0x4005ED6")]
    [FieldOffset(Offset = "0x18")]
    public long end_time;
    [Token(Token = "0x4005ED7")]
    [FieldOffset(Offset = "0x20")]
    public int is_confirm;

    [Token(Token = "0x6006929")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_HotDealInfo()
    {
    }
  }
}
