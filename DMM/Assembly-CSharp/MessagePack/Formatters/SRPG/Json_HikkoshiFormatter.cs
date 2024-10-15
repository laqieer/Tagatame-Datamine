// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_HikkoshiFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000715")]
  public sealed class Json_HikkoshiFormatter : 
    IMessagePackFormatter<Json_Hikkoshi>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012C2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012C3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E8D")]
    [Address(RVA = "0xC607D0", Offset = "0xC5F5D0", VA = "0x10C607D0")]
    public Json_HikkoshiFormatter()
    {
    }

    [Token(Token = "0x6001E8E")]
    [Address(RVA = "0xC606A0", Offset = "0xC5F4A0", VA = "0x10C606A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Hikkoshi value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E8F")]
    [Address(RVA = "0xC60370", Offset = "0xC5F170", VA = "0x10C60370", Slot = "5")]
    public Json_Hikkoshi Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Hikkoshi) null;
    }
  }
}
