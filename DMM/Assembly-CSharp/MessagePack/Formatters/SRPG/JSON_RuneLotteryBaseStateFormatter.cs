// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RuneLotteryBaseStateFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000678")]
  public sealed class JSON_RuneLotteryBaseStateFormatter : 
    IMessagePackFormatter<JSON_RuneLotteryBaseState>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001188")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001189")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CB6")]
    [Address(RVA = "0xBE90C0", Offset = "0xBE7EC0", VA = "0x10BE90C0")]
    public JSON_RuneLotteryBaseStateFormatter()
    {
    }

    [Token(Token = "0x6001CB7")]
    [Address(RVA = "0xBE8E40", Offset = "0xBE7C40", VA = "0x10BE8E40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RuneLotteryBaseState value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CB8")]
    [Address(RVA = "0xBE8A00", Offset = "0xBE7800", VA = "0x10BE8A00", Slot = "5")]
    public JSON_RuneLotteryBaseState Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RuneLotteryBaseState) null;
    }
  }
}
