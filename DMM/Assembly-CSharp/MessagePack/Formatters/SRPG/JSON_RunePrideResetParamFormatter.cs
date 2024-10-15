// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RunePrideResetParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006EE")]
  public sealed class JSON_RunePrideResetParamFormatter : 
    IMessagePackFormatter<JSON_RunePrideResetParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001274")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001275")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E18")]
    [Address(RVA = "0xC35C30", Offset = "0xC34A30", VA = "0x10C35C30")]
    public JSON_RunePrideResetParamFormatter()
    {
    }

    [Token(Token = "0x6001E19")]
    [Address(RVA = "0xC359F0", Offset = "0xC347F0", VA = "0x10C359F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RunePrideResetParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E1A")]
    [Address(RVA = "0xC35650", Offset = "0xC34450", VA = "0x10C35650", Slot = "5")]
    public JSON_RunePrideResetParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RunePrideResetParam) null;
    }
  }
}
