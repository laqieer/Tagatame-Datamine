// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MultiPlayResumeUnitDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200074E")]
  public sealed class MultiPlayResumeUnitDataFormatter : 
    IMessagePackFormatter<MultiPlayResumeUnitData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001334")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001335")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F38")]
    [Address(RVA = "0xC91F00", Offset = "0xC90D00", VA = "0x10C91F00")]
    public MultiPlayResumeUnitDataFormatter()
    {
    }

    [Token(Token = "0x6001F39")]
    [Address(RVA = "0xC90650", Offset = "0xC8F450", VA = "0x10C90650", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MultiPlayResumeUnitData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F3A")]
    [Address(RVA = "0xC8F070", Offset = "0xC8DE70", VA = "0x10C8F070", Slot = "5")]
    public MultiPlayResumeUnitData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MultiPlayResumeUnitData) null;
    }
  }
}
