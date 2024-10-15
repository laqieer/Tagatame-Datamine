// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.DeletionResponseParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B38")]
  public sealed class DeletionResponseParamFormatter : 
    IMessagePackFormatter<DeletionResponseParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001B00")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001B01")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AF6")]
    [Address(RVA = "0xF5C330", Offset = "0xF5B130", VA = "0x10F5C330")]
    public DeletionResponseParamFormatter()
    {
    }

    [Token(Token = "0x6002AF7")]
    [Address(RVA = "0xF5C230", Offset = "0xF5B030", VA = "0x10F5C230", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      DeletionResponseParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AF8")]
    [Address(RVA = "0xF5BF60", Offset = "0xF5AD60", VA = "0x10F5BF60", Slot = "5")]
    public DeletionResponseParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (DeletionResponseParam) null;
    }
  }
}
