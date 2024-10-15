// Decompiled with JetBrains decompiler
// Type: SRPG.Json_PendingGachaParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014FE")]
  public class Json_PendingGachaParam
  {
    [Token(Token = "0x4004CE1")]
    [FieldOffset(Offset = "0x8")]
    public string gname;
    [Token(Token = "0x4004CE2")]
    [FieldOffset(Offset = "0x10")]
    public long time_begin;
    [Token(Token = "0x4004CE3")]
    [FieldOffset(Offset = "0x18")]
    public long time_end;

    [Token(Token = "0x6005747")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_PendingGachaParam()
    {
    }
  }
}
