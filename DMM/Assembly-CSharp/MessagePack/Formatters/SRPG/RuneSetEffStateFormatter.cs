// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RuneSetEffStateFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008F2")]
  public sealed class RuneSetEffStateFormatter : 
    IMessagePackFormatter<RuneSetEffState>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001674")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001675")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002424")]
    [Address(RVA = "0xDF3200", Offset = "0xDF2000", VA = "0x10DF3200")]
    public RuneSetEffStateFormatter()
    {
    }

    [Token(Token = "0x6002425")]
    [Address(RVA = "0xDF3050", Offset = "0xDF1E50", VA = "0x10DF3050", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RuneSetEffState value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002426")]
    [Address(RVA = "0xDF2CE0", Offset = "0xDF1AE0", VA = "0x10DF2CE0", Slot = "5")]
    public RuneSetEffState Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RuneSetEffState) null;
    }
  }
}
