// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalUnitSetReqFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008CE")]
  public sealed class JSON_CrystalUnitSetReqFormatter : 
    IMessagePackFormatter<JSON_CrystalUnitSetReq>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400162C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400162D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023B8")]
    [Address(RVA = "0xDCD820", Offset = "0xDCC620", VA = "0x10DCD820")]
    public JSON_CrystalUnitSetReqFormatter()
    {
    }

    [Token(Token = "0x60023B9")]
    [Address(RVA = "0xDCD720", Offset = "0xDCC520", VA = "0x10DCD720", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalUnitSetReq value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023BA")]
    [Address(RVA = "0xDCD420", Offset = "0xDCC220", VA = "0x10DCD420", Slot = "5")]
    public JSON_CrystalUnitSetReq Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalUnitSetReq) null;
    }
  }
}
