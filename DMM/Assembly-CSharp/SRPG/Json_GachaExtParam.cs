// Decompiled with JetBrains decompiler
// Type: SRPG.Json_GachaExtParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018C1")]
  public class Json_GachaExtParam
  {
    [Token(Token = "0x4005940")]
    [FieldOffset(Offset = "0x8")]
    public Json_GachaStepParam step;
    [Token(Token = "0x4005941")]
    [FieldOffset(Offset = "0xC")]
    public Json_GachaLimitParam limit;
    [Token(Token = "0x4005942")]
    [FieldOffset(Offset = "0x10")]
    public Json_GachaLimitCntParam limit_cnt;
    [Token(Token = "0x4005943")]
    [FieldOffset(Offset = "0x18")]
    public long next_reset_time;
    [Token(Token = "0x4005944")]
    [FieldOffset(Offset = "0x20")]
    public Json_GachaRedrawParam redraw;

    [Token(Token = "0x6006371")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_GachaExtParam()
    {
    }
  }
}
