// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_SkinFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200089D")]
  public sealed class Json_SkinFormatter : IMessagePackFormatter<Json_Skin>, IMessagePackFormatter
  {
    [Token(Token = "0x40015CA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015CB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002325")]
    [Address(RVA = "0xDC1800", Offset = "0xDC0600", VA = "0x10DC1800")]
    public Json_SkinFormatter()
    {
    }

    [Token(Token = "0x6002326")]
    [Address(RVA = "0xDC16D0", Offset = "0xDC04D0", VA = "0x10DC16D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Skin value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002327")]
    [Address(RVA = "0xDC13A0", Offset = "0xDC01A0", VA = "0x10DC13A0", Slot = "5")]
    public Json_Skin Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Skin) null;
    }
  }
}
