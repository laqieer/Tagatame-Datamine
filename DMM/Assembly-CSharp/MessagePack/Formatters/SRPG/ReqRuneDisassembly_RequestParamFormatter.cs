// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneDisassembly_RequestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000994")]
  public sealed class ReqRuneDisassembly_RequestParamFormatter : 
    IMessagePackFormatter<ReqRuneDisassembly.RequestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017B8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017B9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600260A")]
    [Address(RVA = "0xE424C0", Offset = "0xE412C0", VA = "0x10E424C0")]
    public ReqRuneDisassembly_RequestParamFormatter()
    {
    }

    [Token(Token = "0x600260B")]
    [Address(RVA = "0xE423C0", Offset = "0xE411C0", VA = "0x10E423C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneDisassembly.RequestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600260C")]
    [Address(RVA = "0xE420F0", Offset = "0xE40EF0", VA = "0x10E420F0", Slot = "5")]
    public ReqRuneDisassembly.RequestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneDisassembly.RequestParam) null;
    }
  }
}
