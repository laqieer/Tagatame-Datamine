// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_FriendsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200071F")]
  public sealed class Json_FriendsFormatter : 
    IMessagePackFormatter<Json_Friends>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012D6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012D7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EAB")]
    [Address(RVA = "0xC5FB10", Offset = "0xC5E910", VA = "0x10C5FB10")]
    public Json_FriendsFormatter()
    {
    }

    [Token(Token = "0x6001EAC")]
    [Address(RVA = "0xC5F9E0", Offset = "0xC5E7E0", VA = "0x10C5F9E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Friends value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EAD")]
    [Address(RVA = "0xC5F6D0", Offset = "0xC5E4D0", VA = "0x10C5F6D0", Slot = "5")]
    public Json_Friends Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Friends) null;
    }
  }
}
