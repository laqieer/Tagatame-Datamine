// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_TobiraFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005B3")]
  public sealed class Json_TobiraFormatter : 
    IMessagePackFormatter<Json_Tobira>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FFE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FFF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A67")]
    [Address(RVA = "0x7A0A30", Offset = "0x79F830", VA = "0x107A0A30")]
    public Json_TobiraFormatter()
    {
    }

    [Token(Token = "0x6001A68")]
    [Address(RVA = "0x7A0930", Offset = "0x79F730", VA = "0x107A0930", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Tobira value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A69")]
    [Address(RVA = "0x7A0650", Offset = "0x79F450", VA = "0x107A0650", Slot = "5")]
    public Json_Tobira Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Tobira) null;
    }
  }
}
