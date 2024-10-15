// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_BondGroupBuffParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006B3")]
  public sealed class Json_BondGroupBuffParamFormatter : 
    IMessagePackFormatter<Json_BondGroupBuffParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011FE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011FF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D67")]
    [Address(RVA = "0xC1F3A0", Offset = "0xC1E1A0", VA = "0x10C1F3A0")]
    public Json_BondGroupBuffParamFormatter()
    {
    }

    [Token(Token = "0x6001D68")]
    [Address(RVA = "0xC1F1C0", Offset = "0xC1DFC0", VA = "0x10C1F1C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_BondGroupBuffParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D69")]
    [Address(RVA = "0xC1EE80", Offset = "0xC1DC80", VA = "0x10C1EE80", Slot = "5")]
    public Json_BondGroupBuffParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_BondGroupBuffParam) null;
    }
  }
}
