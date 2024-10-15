// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ChallengeCategoryParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005EF")]
  public sealed class JSON_ChallengeCategoryParamFormatter : 
    IMessagePackFormatter<JSON_ChallengeCategoryParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001076")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001077")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B1B")]
    [Address(RVA = "0xB90FD0", Offset = "0xB8FDD0", VA = "0x10B90FD0")]
    public JSON_ChallengeCategoryParamFormatter()
    {
    }

    [Token(Token = "0x6001B1C")]
    [Address(RVA = "0xB90D90", Offset = "0xB8FB90", VA = "0x10B90D90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ChallengeCategoryParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B1D")]
    [Address(RVA = "0xB90990", Offset = "0xB8F790", VA = "0x10B90990", Slot = "5")]
    public JSON_ChallengeCategoryParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ChallengeCategoryParam) null;
    }
  }
}
