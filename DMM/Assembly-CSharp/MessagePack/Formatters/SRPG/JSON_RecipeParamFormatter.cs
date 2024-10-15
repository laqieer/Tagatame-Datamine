// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RecipeParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005E1")]
  public sealed class JSON_RecipeParamFormatter : 
    IMessagePackFormatter<JSON_RecipeParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400105A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400105B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AF1")]
    [Address(RVA = "0xB45850", Offset = "0xB44650", VA = "0x10B45850")]
    public JSON_RecipeParamFormatter()
    {
    }

    [Token(Token = "0x6001AF2")]
    [Address(RVA = "0xB45450", Offset = "0xB44250", VA = "0x10B45450", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RecipeParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AF3")]
    [Address(RVA = "0xB44E90", Offset = "0xB43C90", VA = "0x10B44E90", Slot = "5")]
    public JSON_RecipeParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RecipeParam) null;
    }
  }
}
