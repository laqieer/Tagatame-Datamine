// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RuneCostFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008F9")]
  public sealed class RuneCostFormatter : IMessagePackFormatter<RuneCost>, IMessagePackFormatter
  {
    [Token(Token = "0x4001682")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001683")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002439")]
    [Address(RVA = "0xDED580", Offset = "0xDEC380", VA = "0x10DED580")]
    public RuneCostFormatter()
    {
    }

    [Token(Token = "0x600243A")]
    [Address(RVA = "0xDED380", Offset = "0xDEC180", VA = "0x10DED380", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RuneCost value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600243B")]
    [Address(RVA = "0xDECFB0", Offset = "0xDEBDB0", VA = "0x10DECFB0", Slot = "5")]
    public RuneCost Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RuneCost) null;
    }
  }
}
