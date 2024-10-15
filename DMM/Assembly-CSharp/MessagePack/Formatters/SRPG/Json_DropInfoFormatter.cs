// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_DropInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000884")]
  public sealed class Json_DropInfoFormatter : 
    IMessagePackFormatter<Json_DropInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001598")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001599")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022DA")]
    [Address(RVA = "0xDA35C0", Offset = "0xDA23C0", VA = "0x10DA35C0")]
    public Json_DropInfoFormatter()
    {
    }

    [Token(Token = "0x60022DB")]
    [Address(RVA = "0xDA31D0", Offset = "0xDA1FD0", VA = "0x10DA31D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_DropInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022DC")]
    [Address(RVA = "0xDA2BF0", Offset = "0xDA19F0", VA = "0x10DA2BF0", Slot = "5")]
    public Json_DropInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_DropInfo) null;
    }
  }
}
