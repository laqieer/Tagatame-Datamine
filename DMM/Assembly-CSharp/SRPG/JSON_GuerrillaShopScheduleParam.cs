// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuerrillaShopScheduleParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B1E")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuerrillaShopScheduleParam
  {
    [Token(Token = "0x400675C")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x400675D")]
    [FieldOffset(Offset = "0xC")]
    public string begin_at;
    [Token(Token = "0x400675E")]
    [FieldOffset(Offset = "0x10")]
    public string end_at;
    [Token(Token = "0x400675F")]
    [FieldOffset(Offset = "0x14")]
    public int accum_ap;
    [Token(Token = "0x4006760")]
    [FieldOffset(Offset = "0x18")]
    public string open_time;
    [Token(Token = "0x4006761")]
    [FieldOffset(Offset = "0x1C")]
    public string cool_time;
    [Token(Token = "0x4006762")]
    [FieldOffset(Offset = "0x20")]
    public JSON_GuerrillaShopScheduleAdventParam[] advent;

    [Token(Token = "0x6006FDC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuerrillaShopScheduleParam()
    {
    }
  }
}
