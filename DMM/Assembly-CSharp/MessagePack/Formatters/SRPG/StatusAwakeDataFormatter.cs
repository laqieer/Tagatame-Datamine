// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.StatusAwakeDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200079C")]
  public sealed class StatusAwakeDataFormatter : 
    IMessagePackFormatter<StatusAwakeData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013D0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013D1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002022")]
    [Address(RVA = "0xCE1B60", Offset = "0xCE0960", VA = "0x10CE1B60")]
    public StatusAwakeDataFormatter()
    {
    }

    [Token(Token = "0x6002023")]
    [Address(RVA = "0xCE1A30", Offset = "0xCE0830", VA = "0x10CE1A30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      StatusAwakeData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002024")]
    [Address(RVA = "0xCE1750", Offset = "0xCE0550", VA = "0x10CE1750", Slot = "5")]
    public StatusAwakeData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (StatusAwakeData) null;
    }
  }
}
