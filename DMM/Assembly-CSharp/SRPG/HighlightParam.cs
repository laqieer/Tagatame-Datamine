// Decompiled with JetBrains decompiler
// Type: SRPG.HighlightParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B95")]
  public class HighlightParam
  {
    [Token(Token = "0x4006931")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006932")]
    [FieldOffset(Offset = "0x10")]
    public DateTime begin_at;
    [Token(Token = "0x4006933")]
    [FieldOffset(Offset = "0x18")]
    public DateTime end_at;
    [Token(Token = "0x4006934")]
    [FieldOffset(Offset = "0x20")]
    public DateTime data_end_at;
    [Token(Token = "0x4006935")]
    [FieldOffset(Offset = "0x28")]
    public HighlightResource[] resources;
    [Token(Token = "0x4006936")]
    [FieldOffset(Offset = "0x2C")]
    public HighlightGift gift;

    [Token(Token = "0x6007208")]
    [Address(RVA = "0x375930", Offset = "0x374730", VA = "0x10375930")]
    public void Deserialze(JSON_HighlightParam json)
    {
    }

    [Token(Token = "0x6007209")]
    [Address(RVA = "0x375B90", Offset = "0x374990", VA = "0x10375B90")]
    public bool IsAvailable() => new bool();

    [Token(Token = "0x600720A")]
    [Address(RVA = "0x375B00", Offset = "0x374900", VA = "0x10375B00")]
    public bool IsAvailable(DateTime time) => new bool();

    [Token(Token = "0x600720B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public HighlightParam()
    {
    }
  }
}
