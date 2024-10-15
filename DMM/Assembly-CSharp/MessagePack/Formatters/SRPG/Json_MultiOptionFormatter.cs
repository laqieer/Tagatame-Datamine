// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_MultiOptionFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000720")]
  public sealed class Json_MultiOptionFormatter : 
    IMessagePackFormatter<Json_MultiOption>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012D8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012D9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EAE")]
    [Address(RVA = "0xC60D90", Offset = "0xC5FB90", VA = "0x10C60D90")]
    public Json_MultiOptionFormatter()
    {
    }

    [Token(Token = "0x6001EAF")]
    [Address(RVA = "0xC60C60", Offset = "0xC5FA60", VA = "0x10C60C60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_MultiOption value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EB0")]
    [Address(RVA = "0xC60950", Offset = "0xC5F750", VA = "0x10C60950", Slot = "5")]
    public Json_MultiOption Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_MultiOption) null;
    }
  }
}
