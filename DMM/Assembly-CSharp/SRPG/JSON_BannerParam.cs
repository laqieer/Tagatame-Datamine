// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_BannerParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019A5")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_BannerParam
  {
    [Token(Token = "0x4005E01")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4005E02")]
    [FieldOffset(Offset = "0xC")]
    public string type;
    [Token(Token = "0x4005E03")]
    [FieldOffset(Offset = "0x10")]
    public string sval;
    [Token(Token = "0x4005E04")]
    [FieldOffset(Offset = "0x14")]
    public string banr;
    [Token(Token = "0x4005E05")]
    [FieldOffset(Offset = "0x18")]
    public string banr_sprite;
    [Token(Token = "0x4005E06")]
    [FieldOffset(Offset = "0x1C")]
    public string begin_at;
    [Token(Token = "0x4005E07")]
    [FieldOffset(Offset = "0x20")]
    public string end_at;
    [Token(Token = "0x4005E08")]
    [FieldOffset(Offset = "0x24")]
    public int priority;
    [Token(Token = "0x4005E09")]
    [FieldOffset(Offset = "0x28")]
    public string message;
    [Token(Token = "0x4005E0A")]
    [FieldOffset(Offset = "0x2C")]
    public int is_not_home;
    [Token(Token = "0x4005E0B")]
    [FieldOffset(Offset = "0x30")]
    public int tab_type;

    [Token(Token = "0x6006887")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_BannerParam()
    {
    }
  }
}
