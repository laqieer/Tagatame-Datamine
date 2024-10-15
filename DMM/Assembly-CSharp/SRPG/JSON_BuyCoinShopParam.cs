// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_BuyCoinShopParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A3F")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_BuyCoinShopParam
  {
    [Token(Token = "0x40060A5")]
    [FieldOffset(Offset = "0x8")]
    public string shop_id;
    [Token(Token = "0x40060A6")]
    [FieldOffset(Offset = "0xC")]
    public int shop_type;
    [Token(Token = "0x40060A7")]
    [FieldOffset(Offset = "0x10")]
    public string display_name;
    [Token(Token = "0x40060A8")]
    [FieldOffset(Offset = "0x14")]
    public string begin_at;
    [Token(Token = "0x40060A9")]
    [FieldOffset(Offset = "0x18")]
    public string end_at;
    [Token(Token = "0x40060AA")]
    [FieldOffset(Offset = "0x1C")]
    public string url;

    [Token(Token = "0x6006BED")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_BuyCoinShopParam()
    {
    }
  }
}
