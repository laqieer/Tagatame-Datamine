// Decompiled with JetBrains decompiler
// Type: SRPG.GuerrillaShopScheduleParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B1C")]
  public class GuerrillaShopScheduleParam
  {
    [Token(Token = "0x4006753")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4006754")]
    [FieldOffset(Offset = "0xC")]
    public string begin_at;
    [Token(Token = "0x4006755")]
    [FieldOffset(Offset = "0x10")]
    public string end_at;
    [Token(Token = "0x4006756")]
    [FieldOffset(Offset = "0x14")]
    public int accum_ap;
    [Token(Token = "0x4006757")]
    [FieldOffset(Offset = "0x18")]
    public string open_time;
    [Token(Token = "0x4006758")]
    [FieldOffset(Offset = "0x1C")]
    public string cool_time;
    [Token(Token = "0x4006759")]
    [FieldOffset(Offset = "0x20")]
    public GuerrillaShopScheduleAdvent[] advent;

    [Token(Token = "0x6006FD9")]
    [Address(RVA = "0x36E210", Offset = "0x36D010", VA = "0x1036E210")]
    public bool Deserialize(JSON_GuerrillaShopScheduleParam json) => new bool();

    [Token(Token = "0x6006FDA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuerrillaShopScheduleParam()
    {
    }
  }
}
