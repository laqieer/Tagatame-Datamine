// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.DeletionStartResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B39")]
  public sealed class DeletionStartResponseFormatter : 
    IMessagePackFormatter<DeletionStartResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001B02")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001B03")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AF9")]
    [Address(RVA = "0xF5CB70", Offset = "0xF5B970", VA = "0x10F5CB70")]
    public DeletionStartResponseFormatter()
    {
    }

    [Token(Token = "0x6002AFA")]
    [Address(RVA = "0xF5C880", Offset = "0xF5B680", VA = "0x10F5C880", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      DeletionStartResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AFB")]
    [Address(RVA = "0xF5C450", Offset = "0xF5B250", VA = "0x10F5C450", Slot = "5")]
    public DeletionStartResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (DeletionStartResponse) null;
    }
  }
}
