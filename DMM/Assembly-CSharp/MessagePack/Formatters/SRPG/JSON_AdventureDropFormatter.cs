// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdventureDropFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008DB")]
  public sealed class JSON_AdventureDropFormatter : 
    IMessagePackFormatter<JSON_AdventureDrop>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001646")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001647")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023DF")]
    [Address(RVA = "0xDCC890", Offset = "0xDCB690", VA = "0x10DCC890")]
    public JSON_AdventureDropFormatter()
    {
    }

    [Token(Token = "0x60023E0")]
    [Address(RVA = "0xDCC730", Offset = "0xDCB530", VA = "0x10DCC730", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdventureDrop value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023E1")]
    [Address(RVA = "0xDCC3E0", Offset = "0xDCB1E0", VA = "0x10DCC3E0", Slot = "5")]
    public JSON_AdventureDrop Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdventureDrop) null;
    }
  }
}
