// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_PremiumParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C1A")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_PremiumParam
  {
    [Token(Token = "0x4006CD8")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006CD9")]
    [FieldOffset(Offset = "0xC")]
    public string image;
    [Token(Token = "0x4006CDA")]
    [FieldOffset(Offset = "0x10")]
    public string begin_at;
    [Token(Token = "0x4006CDB")]
    [FieldOffset(Offset = "0x14")]
    public string end_at;
    [Token(Token = "0x4006CDC")]
    [FieldOffset(Offset = "0x18")]
    public int span;
    [Token(Token = "0x4006CDD")]
    [FieldOffset(Offset = "0x1C")]
    public string premium_product;
    [Token(Token = "0x4006CDE")]
    [FieldOffset(Offset = "0x20")]
    public string table_id;
    [Token(Token = "0x4006CDF")]
    [FieldOffset(Offset = "0x24")]
    public int premium_type;

    [Token(Token = "0x60073C9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_PremiumParam()
    {
    }
  }
}
