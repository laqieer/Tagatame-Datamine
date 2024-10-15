// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_JobFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005B0")]
  public sealed class Json_JobFormatter : IMessagePackFormatter<Json_Job>, IMessagePackFormatter
  {
    [Token(Token = "0x4000FF8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FF9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A5E")]
    [Address(RVA = "0x79CC20", Offset = "0x79BA20", VA = "0x1079CC20")]
    public Json_JobFormatter()
    {
    }

    [Token(Token = "0x6001A5F")]
    [Address(RVA = "0x79C740", Offset = "0x79B540", VA = "0x1079C740", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Job value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A60")]
    [Address(RVA = "0x79C190", Offset = "0x79AF90", VA = "0x1079C190", Slot = "5")]
    public Json_Job Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Job) null;
    }
  }
}
