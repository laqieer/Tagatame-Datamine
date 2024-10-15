// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RecipeItemFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200076E")]
  public sealed class RecipeItemFormatter : IMessagePackFormatter<RecipeItem>, IMessagePackFormatter
  {
    [Token(Token = "0x4001374")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001375")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F98")]
    [Address(RVA = "0xCB6540", Offset = "0xCB5340", VA = "0x10CB6540")]
    public RecipeItemFormatter()
    {
    }

    [Token(Token = "0x6001F99")]
    [Address(RVA = "0xCB6410", Offset = "0xCB5210", VA = "0x10CB6410", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RecipeItem value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F9A")]
    [Address(RVA = "0xCB6100", Offset = "0xCB4F00", VA = "0x10CB6100", Slot = "5")]
    public RecipeItem Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RecipeItem) null;
    }
  }
}
