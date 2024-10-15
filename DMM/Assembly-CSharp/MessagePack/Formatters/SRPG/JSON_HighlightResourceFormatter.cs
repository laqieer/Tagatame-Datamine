// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_HighlightResourceFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200064F")]
  public sealed class JSON_HighlightResourceFormatter : 
    IMessagePackFormatter<JSON_HighlightResource>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001136")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001137")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C3B")]
    [Address(RVA = "0xBDA360", Offset = "0xBD9160", VA = "0x10BDA360")]
    public JSON_HighlightResourceFormatter()
    {
    }

    [Token(Token = "0x6001C3C")]
    [Address(RVA = "0xBDA1D0", Offset = "0xBD8FD0", VA = "0x10BDA1D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_HighlightResource value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C3D")]
    [Address(RVA = "0xBD9E60", Offset = "0xBD8C60", VA = "0x10BD9E60", Slot = "5")]
    public JSON_HighlightResource Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_HighlightResource) null;
    }
  }
}
