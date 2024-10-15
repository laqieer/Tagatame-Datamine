// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_Notify_MonthlyFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200086E")]
  public sealed class Json_Notify_MonthlyFormatter : 
    IMessagePackFormatter<Json_Notify_Monthly>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400156C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400156D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002298")]
    [Address(RVA = "0xDA6EE0", Offset = "0xDA5CE0", VA = "0x10DA6EE0")]
    public Json_Notify_MonthlyFormatter()
    {
    }

    [Token(Token = "0x6002299")]
    [Address(RVA = "0xDA6D70", Offset = "0xDA5B70", VA = "0x10DA6D70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Notify_Monthly value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600229A")]
    [Address(RVA = "0xDA6AA0", Offset = "0xDA58A0", VA = "0x10DA6AA0", Slot = "5")]
    public Json_Notify_Monthly Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Notify_Monthly) null;
    }
  }
}
