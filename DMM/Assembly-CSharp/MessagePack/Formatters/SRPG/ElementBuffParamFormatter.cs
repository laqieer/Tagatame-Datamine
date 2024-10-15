// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ElementBuffParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AF4")]
  public sealed class ElementBuffParamFormatter : 
    IMessagePackFormatter<ElementBuffParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A78")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A79")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A2A")]
    [Address(RVA = "0xF19D00", Offset = "0xF18B00", VA = "0x10F19D00")]
    public ElementBuffParamFormatter()
    {
    }

    [Token(Token = "0x6002A2B")]
    [Address(RVA = "0xF19AA0", Offset = "0xF188A0", VA = "0x10F19AA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ElementBuffParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A2C")]
    [Address(RVA = "0xF19760", Offset = "0xF18560", VA = "0x10F19760", Slot = "5")]
    public ElementBuffParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ElementBuffParam) null;
    }
  }
}
