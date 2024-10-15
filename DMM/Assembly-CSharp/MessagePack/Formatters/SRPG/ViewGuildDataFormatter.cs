// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ViewGuildDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A04")]
  public sealed class ViewGuildDataFormatter : 
    IMessagePackFormatter<ViewGuildData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001898")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001899")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600275A")]
    [Address(RVA = "0xEA8310", Offset = "0xEA7110", VA = "0x10EA8310")]
    public ViewGuildDataFormatter()
    {
    }

    [Token(Token = "0x600275B")]
    [Address(RVA = "0xEA8010", Offset = "0xEA6E10", VA = "0x10EA8010", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ViewGuildData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600275C")]
    [Address(RVA = "0xEA7B50", Offset = "0xEA6950", VA = "0x10EA7B50", Slot = "5")]
    public ViewGuildData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ViewGuildData) null;
    }
  }
}
