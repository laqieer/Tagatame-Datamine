// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ReplaceSpriteFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200069B")]
  public sealed class JSON_ReplaceSpriteFormatter : 
    IMessagePackFormatter<JSON_ReplaceSprite>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011CE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011CF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D1F")]
    [Address(RVA = "0xC017B0", Offset = "0xC005B0", VA = "0x10C017B0")]
    public JSON_ReplaceSpriteFormatter()
    {
    }

    [Token(Token = "0x6001D20")]
    [Address(RVA = "0xC015D0", Offset = "0xC003D0", VA = "0x10C015D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ReplaceSprite value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D21")]
    [Address(RVA = "0xC01290", Offset = "0xC00090", VA = "0x10C01290", Slot = "5")]
    public JSON_ReplaceSprite Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ReplaceSprite) null;
    }
  }
}
