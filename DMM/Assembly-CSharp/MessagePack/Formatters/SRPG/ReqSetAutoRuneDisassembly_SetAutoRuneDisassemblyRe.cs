// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqSetAutoRuneDisassembly_SetAutoRuneDisassemblyResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009A4")]
  public sealed class ReqSetAutoRuneDisassembly_SetAutoRuneDisassemblyResponseFormatter : 
    IMessagePackFormatter<ReqSetAutoRuneDisassembly.SetAutoRuneDisassemblyResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017D8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017D9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600263A")]
    [Address(RVA = "0xE4B500", Offset = "0xE4A300", VA = "0x10E4B500")]
    public ReqSetAutoRuneDisassembly_SetAutoRuneDisassemblyResponseFormatter()
    {
    }

    [Token(Token = "0x600263B")]
    [Address(RVA = "0xE4B210", Offset = "0xE4A010", VA = "0x10E4B210", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqSetAutoRuneDisassembly.SetAutoRuneDisassemblyResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600263C")]
    [Address(RVA = "0xE4ADE0", Offset = "0xE49BE0", VA = "0x10E4ADE0", Slot = "5")]
    public ReqSetAutoRuneDisassembly.SetAutoRuneDisassemblyResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqSetAutoRuneDisassembly.SetAutoRuneDisassemblyResponse) null;
    }
  }
}
