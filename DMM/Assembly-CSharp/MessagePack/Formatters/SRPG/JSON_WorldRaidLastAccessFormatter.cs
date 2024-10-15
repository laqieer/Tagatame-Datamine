// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidLastAccessFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200088E")]
  public sealed class JSON_WorldRaidLastAccessFormatter : 
    IMessagePackFormatter<JSON_WorldRaidLastAccess>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015AC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015AD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022F8")]
    [Address(RVA = "0xDA1670", Offset = "0xDA0470", VA = "0x10DA1670")]
    public JSON_WorldRaidLastAccessFormatter()
    {
    }

    [Token(Token = "0x60022F9")]
    [Address(RVA = "0xDA1540", Offset = "0xDA0340", VA = "0x10DA1540", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidLastAccess value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022FA")]
    [Address(RVA = "0xDA1230", Offset = "0xDA0030", VA = "0x10DA1230", Slot = "5")]
    public JSON_WorldRaidLastAccess Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidLastAccess) null;
    }
  }
}
