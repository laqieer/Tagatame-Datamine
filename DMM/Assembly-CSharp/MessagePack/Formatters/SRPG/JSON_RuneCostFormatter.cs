// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RuneCostFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200067E")]
  public sealed class JSON_RuneCostFormatter : 
    IMessagePackFormatter<JSON_RuneCost>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001194")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001195")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CC8")]
    [Address(RVA = "0xBE7D90", Offset = "0xBE6B90", VA = "0x10BE7D90")]
    public JSON_RuneCostFormatter()
    {
    }

    [Token(Token = "0x6001CC9")]
    [Address(RVA = "0xBE7B90", Offset = "0xBE6990", VA = "0x10BE7B90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RuneCost value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CCA")]
    [Address(RVA = "0xBE77C0", Offset = "0xBE65C0", VA = "0x10BE77C0", Slot = "5")]
    public JSON_RuneCost Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RuneCost) null;
    }
  }
}
