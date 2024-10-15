// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RunePrideResetDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006ED")]
  public sealed class JSON_RunePrideResetDataFormatter : 
    IMessagePackFormatter<JSON_RunePrideResetData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001272")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001273")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E15")]
    [Address(RVA = "0xC35460", Offset = "0xC34260", VA = "0x10C35460")]
    public JSON_RunePrideResetDataFormatter()
    {
    }

    [Token(Token = "0x6001E16")]
    [Address(RVA = "0xC35300", Offset = "0xC34100", VA = "0x10C35300", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RunePrideResetData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E17")]
    [Address(RVA = "0xC34FB0", Offset = "0xC33DB0", VA = "0x10C34FB0", Slot = "5")]
    public JSON_RunePrideResetData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RunePrideResetData) null;
    }
  }
}
