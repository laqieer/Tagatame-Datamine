// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MultiPlayResumeProtectFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000748")]
  public sealed class MultiPlayResumeProtectFormatter : 
    IMessagePackFormatter<MultiPlayResumeProtect>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001328")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001329")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F26")]
    [Address(RVA = "0xC8D7D0", Offset = "0xC8C5D0", VA = "0x10C8D7D0")]
    public MultiPlayResumeProtectFormatter()
    {
    }

    [Token(Token = "0x6001F27")]
    [Address(RVA = "0xC8D670", Offset = "0xC8C470", VA = "0x10C8D670", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MultiPlayResumeProtect value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F28")]
    [Address(RVA = "0xC8D320", Offset = "0xC8C120", VA = "0x10C8D320", Slot = "5")]
    public MultiPlayResumeProtect Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MultiPlayResumeProtect) null;
    }
  }
}
