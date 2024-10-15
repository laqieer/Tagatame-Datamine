// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_FriendFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200089C")]
  public sealed class Json_FriendFormatter : 
    IMessagePackFormatter<Json_Friend>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015C8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015C9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002322")]
    [Address(RVA = "0xDBAC60", Offset = "0xDB9A60", VA = "0x10DBAC60")]
    public Json_FriendFormatter()
    {
    }

    [Token(Token = "0x6002323")]
    [Address(RVA = "0xDBA570", Offset = "0xDB9370", VA = "0x10DBA570", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Friend value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002324")]
    [Address(RVA = "0xDB9DD0", Offset = "0xDB8BD0", VA = "0x10DB9DD0", Slot = "5")]
    public Json_Friend Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Friend) null;
    }
  }
}
