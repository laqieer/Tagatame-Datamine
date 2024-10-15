// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TobiraRecipeParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200060F")]
  public sealed class JSON_TobiraRecipeParamFormatter : 
    IMessagePackFormatter<JSON_TobiraRecipeParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010B6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010B7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B7B")]
    [Address(RVA = "0xBAE0F0", Offset = "0xBACEF0", VA = "0x10BAE0F0")]
    public JSON_TobiraRecipeParamFormatter()
    {
    }

    [Token(Token = "0x6001B7C")]
    [Address(RVA = "0xBADDC0", Offset = "0xBACBC0", VA = "0x10BADDC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TobiraRecipeParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B7D")]
    [Address(RVA = "0xBAD930", Offset = "0xBAC730", VA = "0x10BAD930", Slot = "5")]
    public JSON_TobiraRecipeParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TobiraRecipeParam) null;
    }
  }
}
