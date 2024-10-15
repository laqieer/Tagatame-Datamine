// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.GridFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007CE")]
  public sealed class GridFormatter : IMessagePackFormatter<Grid>, IMessagePackFormatter
  {
    [Token(Token = "0x400142C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400142D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020B8")]
    [Address(RVA = "0xD16E50", Offset = "0xD15C50", VA = "0x10D16E50")]
    public GridFormatter()
    {
    }

    [Token(Token = "0x60020B9")]
    [Address(RVA = "0xD16A70", Offset = "0xD15870", VA = "0x10D16A70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Grid value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020BA")]
    [Address(RVA = "0xD165E0", Offset = "0xD153E0", VA = "0x10D165E0", Slot = "5")]
    public Grid Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Grid) null;
    }
  }
}
