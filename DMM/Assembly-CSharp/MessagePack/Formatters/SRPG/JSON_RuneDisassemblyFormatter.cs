// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RuneDisassemblyFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200067C")]
  public sealed class JSON_RuneDisassemblyFormatter : 
    IMessagePackFormatter<JSON_RuneDisassembly>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001190")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001191")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CC2")]
    [Address(RVA = "0xBE86D0", Offset = "0xBE74D0", VA = "0x10BE86D0")]
    public JSON_RuneDisassemblyFormatter()
    {
    }

    [Token(Token = "0x6001CC3")]
    [Address(RVA = "0xBE8480", Offset = "0xBE7280", VA = "0x10BE8480", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RuneDisassembly value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CC4")]
    [Address(RVA = "0xBE8060", Offset = "0xBE6E60", VA = "0x10BE8060", Slot = "5")]
    public JSON_RuneDisassembly Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RuneDisassembly) null;
    }
  }
}
