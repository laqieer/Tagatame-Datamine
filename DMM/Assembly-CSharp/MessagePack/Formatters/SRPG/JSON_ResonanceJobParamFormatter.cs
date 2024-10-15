// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ResonanceJobParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006C6")]
  public sealed class JSON_ResonanceJobParamFormatter : 
    IMessagePackFormatter<JSON_ResonanceJobParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001224")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001225")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DA0")]
    [Address(RVA = "0xC18590", Offset = "0xC17390", VA = "0x10C18590")]
    public JSON_ResonanceJobParamFormatter()
    {
    }

    [Token(Token = "0x6001DA1")]
    [Address(RVA = "0xC18490", Offset = "0xC17290", VA = "0x10C18490", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ResonanceJobParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DA2")]
    [Address(RVA = "0xC181C0", Offset = "0xC16FC0", VA = "0x10C181C0", Slot = "5")]
    public JSON_ResonanceJobParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ResonanceJobParam) null;
    }
  }
}
