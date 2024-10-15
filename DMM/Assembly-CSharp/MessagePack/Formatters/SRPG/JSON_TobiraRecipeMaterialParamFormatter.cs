// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TobiraRecipeMaterialParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200060E")]
  public sealed class JSON_TobiraRecipeMaterialParamFormatter : 
    IMessagePackFormatter<JSON_TobiraRecipeMaterialParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010B4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010B5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B78")]
    [Address(RVA = "0xBAD7B0", Offset = "0xBAC5B0", VA = "0x10BAD7B0")]
    public JSON_TobiraRecipeMaterialParamFormatter()
    {
    }

    [Token(Token = "0x6001B79")]
    [Address(RVA = "0xBAD680", Offset = "0xBAC480", VA = "0x10BAD680", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TobiraRecipeMaterialParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B7A")]
    [Address(RVA = "0xBAD370", Offset = "0xBAC170", VA = "0x10BAD370", Slot = "5")]
    public JSON_TobiraRecipeMaterialParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TobiraRecipeMaterialParam) null;
    }
  }
}
