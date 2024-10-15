// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.UnitParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000769")]
  public sealed class UnitParamFormatter : IMessagePackFormatter<UnitParam>, IMessagePackFormatter
  {
    [Token(Token = "0x400136A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400136B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F89")]
    [Address(RVA = "0xCBBE70", Offset = "0xCBAC70", VA = "0x10CBBE70")]
    public UnitParamFormatter()
    {
    }

    [Token(Token = "0x6001F8A")]
    [Address(RVA = "0xCBACF0", Offset = "0xCB9AF0", VA = "0x10CBACF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      UnitParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F8B")]
    [Address(RVA = "0xCB9DC0", Offset = "0xCB8BC0", VA = "0x10CB9DC0", Slot = "5")]
    public UnitParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (UnitParam) null;
    }
  }
}
