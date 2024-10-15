// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReplaceSpriteFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AEB")]
  public sealed class ReplaceSpriteFormatter : 
    IMessagePackFormatter<ReplaceSprite>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A66")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A67")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A0F")]
    [Address(RVA = "0xF25C90", Offset = "0xF24A90", VA = "0x10F25C90")]
    public ReplaceSpriteFormatter()
    {
    }

    [Token(Token = "0x6002A10")]
    [Address(RVA = "0xF25AB0", Offset = "0xF248B0", VA = "0x10F25AB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReplaceSprite value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A11")]
    [Address(RVA = "0xF25770", Offset = "0xF24570", VA = "0x10F25770", Slot = "5")]
    public ReplaceSprite Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReplaceSprite) null;
    }
  }
}
