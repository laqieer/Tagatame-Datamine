// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BaseStatusFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200076D")]
  public sealed class BaseStatusFormatter : IMessagePackFormatter<BaseStatus>, IMessagePackFormatter
  {
    [Token(Token = "0x4001372")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001373")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F95")]
    [Address(RVA = "0xCAAD70", Offset = "0xCA9B70", VA = "0x10CAAD70")]
    public BaseStatusFormatter()
    {
    }

    [Token(Token = "0x6001F96")]
    [Address(RVA = "0xCAA920", Offset = "0xCA9720", VA = "0x10CAA920", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BaseStatus value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F97")]
    [Address(RVA = "0xCAA3B0", Offset = "0xCA91B0", VA = "0x10CAA3B0", Slot = "5")]
    public BaseStatus Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BaseStatus) null;
    }
  }
}
