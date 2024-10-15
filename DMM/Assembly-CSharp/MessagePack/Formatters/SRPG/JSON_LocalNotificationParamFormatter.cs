// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LocalNotificationParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005ED")]
  public sealed class JSON_LocalNotificationParamFormatter : 
    IMessagePackFormatter<JSON_LocalNotificationParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001072")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001073")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B15")]
    [Address(RVA = "0xB98840", Offset = "0xB97640", VA = "0x10B98840")]
    public JSON_LocalNotificationParamFormatter()
    {
    }

    [Token(Token = "0x6001B16")]
    [Address(RVA = "0xB986B0", Offset = "0xB974B0", VA = "0x10B986B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LocalNotificationParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B17")]
    [Address(RVA = "0xB98340", Offset = "0xB97140", VA = "0x10B98340", Slot = "5")]
    public JSON_LocalNotificationParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LocalNotificationParam) null;
    }
  }
}
