// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PointQuestBestPointDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200070D")]
  public sealed class JSON_PointQuestBestPointDataFormatter : 
    IMessagePackFormatter<JSON_PointQuestBestPointData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012B2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012B3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E75")]
    [Address(RVA = "0xC54C00", Offset = "0xC53A00", VA = "0x10C54C00")]
    public JSON_PointQuestBestPointDataFormatter()
    {
    }

    [Token(Token = "0x6001E76")]
    [Address(RVA = "0xC54AD0", Offset = "0xC538D0", VA = "0x10C54AD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PointQuestBestPointData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E77")]
    [Address(RVA = "0xC547C0", Offset = "0xC535C0", VA = "0x10C547C0", Slot = "5")]
    public JSON_PointQuestBestPointData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PointQuestBestPointData) null;
    }
  }
}
