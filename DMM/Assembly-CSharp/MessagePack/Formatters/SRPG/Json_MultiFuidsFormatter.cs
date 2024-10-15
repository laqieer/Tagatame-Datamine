// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_MultiFuidsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200089F")]
  public sealed class Json_MultiFuidsFormatter : 
    IMessagePackFormatter<Json_MultiFuids>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015CE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015CF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600232B")]
    [Address(RVA = "0xDBBF50", Offset = "0xDBAD50", VA = "0x10DBBF50")]
    public Json_MultiFuidsFormatter()
    {
    }

    [Token(Token = "0x600232C")]
    [Address(RVA = "0xDBBE00", Offset = "0xDBAC00", VA = "0x10DBBE00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_MultiFuids value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600232D")]
    [Address(RVA = "0xDBBAD0", Offset = "0xDBA8D0", VA = "0x10DBBAD0", Slot = "5")]
    public Json_MultiFuids Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_MultiFuids) null;
    }
  }
}
