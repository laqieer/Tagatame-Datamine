// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RecipeParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200076F")]
  public sealed class RecipeParamFormatter : 
    IMessagePackFormatter<RecipeParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001376")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001377")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F9B")]
    [Address(RVA = "0xCB6C60", Offset = "0xCB5A60", VA = "0x10CB6C60")]
    public RecipeParamFormatter()
    {
    }

    [Token(Token = "0x6001F9C")]
    [Address(RVA = "0xCB6A40", Offset = "0xCB5840", VA = "0x10CB6A40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RecipeParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F9D")]
    [Address(RVA = "0xCB66C0", Offset = "0xCB54C0", VA = "0x10CB66C0", Slot = "5")]
    public RecipeParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RecipeParam) null;
    }
  }
}
