// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneEquip_OverWrite_RequestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200098C")]
  public sealed class ReqRuneEquip_OverWrite_RequestParamFormatter : 
    IMessagePackFormatter<ReqRuneEquip_OverWrite.RequestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017A8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017A9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025F2")]
    [Address(RVA = "0xE44BC0", Offset = "0xE439C0", VA = "0x10E44BC0")]
    public ReqRuneEquip_OverWrite_RequestParamFormatter()
    {
    }

    [Token(Token = "0x60025F3")]
    [Address(RVA = "0xE44A20", Offset = "0xE43820", VA = "0x10E44A20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneEquip_OverWrite.RequestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025F4")]
    [Address(RVA = "0xE44680", Offset = "0xE43480", VA = "0x10E44680", Slot = "5")]
    public ReqRuneEquip_OverWrite.RequestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneEquip_OverWrite.RequestParam) null;
    }
  }
}
