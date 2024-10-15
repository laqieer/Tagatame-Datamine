// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_DifferenceUpdatePlayerFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200085A")]
  public sealed class Json_DifferenceUpdatePlayerFormatter : 
    IMessagePackFormatter<Json_DifferenceUpdatePlayer>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001544")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001545")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600225C")]
    [Address(RVA = "0xD93160", Offset = "0xD91F60", VA = "0x10D93160")]
    public Json_DifferenceUpdatePlayerFormatter()
    {
    }

    [Token(Token = "0x600225D")]
    [Address(RVA = "0xD92B30", Offset = "0xD91930", VA = "0x10D92B30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_DifferenceUpdatePlayer value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600225E")]
    [Address(RVA = "0xD925C0", Offset = "0xD913C0", VA = "0x10D925C0", Slot = "5")]
    public Json_DifferenceUpdatePlayer Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_DifferenceUpdatePlayer) null;
    }
  }
}
