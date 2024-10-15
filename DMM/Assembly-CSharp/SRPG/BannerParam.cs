// Decompiled with JetBrains decompiler
// Type: SRPG.BannerParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019A8")]
  public class BannerParam
  {
    [Token(Token = "0x4005E25")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4005E26")]
    [FieldOffset(Offset = "0xC")]
    public BannerType type;
    [Token(Token = "0x4005E27")]
    [FieldOffset(Offset = "0x10")]
    public string sval;
    [Token(Token = "0x4005E28")]
    [FieldOffset(Offset = "0x14")]
    public string banner;
    [Token(Token = "0x4005E29")]
    [FieldOffset(Offset = "0x18")]
    public string banr_sprite;
    [Token(Token = "0x4005E2A")]
    [FieldOffset(Offset = "0x1C")]
    public string begin_at;
    [Token(Token = "0x4005E2B")]
    [FieldOffset(Offset = "0x20")]
    public string end_at;
    [Token(Token = "0x4005E2C")]
    [FieldOffset(Offset = "0x24")]
    public int priority;
    [Token(Token = "0x4005E2D")]
    [FieldOffset(Offset = "0x28")]
    public string message;
    [Token(Token = "0x4005E2E")]
    [FieldOffset(Offset = "0x2C")]
    private bool is_not_home;
    [Token(Token = "0x4005E2F")]
    [FieldOffset(Offset = "0x2D")]
    private BannerTabType tab_type;

    [Token(Token = "0x17000AF7")]
    public bool IsHomeBanner
    {
      [Token(Token = "0x6006888"), Address(RVA = "0x34B860", Offset = "0x34A660", VA = "0x1034B860")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000AF8")]
    public BannerTabType TabType
    {
      [Token(Token = "0x6006889"), Address(RVA = "0x34B870", Offset = "0x34A670", VA = "0x1034B870")] get
      {
        return new BannerTabType();
      }
    }

    [Token(Token = "0x600688A")]
    [Address(RVA = "0x34B480", Offset = "0x34A280", VA = "0x1034B480")]
    public bool Deserialize(JSON_BannerParam json) => new bool();

    [Token(Token = "0x600688B")]
    [Address(RVA = "0x34B6B0", Offset = "0x34A4B0", VA = "0x1034B6B0")]
    public bool IsAvailablePeriod(DateTime now) => new bool();

    [Token(Token = "0x600688C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BannerParam()
    {
    }
  }
}
