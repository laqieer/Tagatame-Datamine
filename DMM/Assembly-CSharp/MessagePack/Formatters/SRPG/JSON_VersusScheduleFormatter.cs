// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusScheduleFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000863")]
  public sealed class JSON_VersusScheduleFormatter : 
    IMessagePackFormatter<JSON_VersusSchedule>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001556")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001557")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002277")]
    [Address(RVA = "0xD92290", Offset = "0xD91090", VA = "0x10D92290")]
    public JSON_VersusScheduleFormatter()
    {
    }

    [Token(Token = "0x6002278")]
    [Address(RVA = "0xD91FD0", Offset = "0xD90DD0", VA = "0x10D91FD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusSchedule value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002279")]
    [Address(RVA = "0xD91B50", Offset = "0xD90950", VA = "0x10D91B50", Slot = "5")]
    public JSON_VersusSchedule Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusSchedule) null;
    }
  }
}
