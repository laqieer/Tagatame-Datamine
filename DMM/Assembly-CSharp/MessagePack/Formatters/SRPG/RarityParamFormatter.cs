// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RarityParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000774")]
  public sealed class RarityParamFormatter : 
    IMessagePackFormatter<RarityParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001380")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001381")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FAA")]
    [Address(RVA = "0xCB55E0", Offset = "0xCB43E0", VA = "0x10CB55E0")]
    public RarityParamFormatter()
    {
    }

    [Token(Token = "0x6001FAB")]
    [Address(RVA = "0xCB49C0", Offset = "0xCB37C0", VA = "0x10CB49C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RarityParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FAC")]
    [Address(RVA = "0xCB3CA0", Offset = "0xCB2AA0", VA = "0x10CB3CA0", Slot = "5")]
    public RarityParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RarityParam) null;
    }
  }
}
