// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ResonanceJobParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009AC")]
  public sealed class ResonanceJobParamFormatter : 
    IMessagePackFormatter<ResonanceJobParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017E8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017E9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002652")]
    [Address(RVA = "0xE4CBA0", Offset = "0xE4B9A0", VA = "0x10E4CBA0")]
    public ResonanceJobParamFormatter()
    {
    }

    [Token(Token = "0x6002653")]
    [Address(RVA = "0xE4CAA0", Offset = "0xE4B8A0", VA = "0x10E4CAA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ResonanceJobParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002654")]
    [Address(RVA = "0xE4C7D0", Offset = "0xE4B5D0", VA = "0x10E4C7D0", Slot = "5")]
    public ResonanceJobParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ResonanceJobParam) null;
    }
  }
}
