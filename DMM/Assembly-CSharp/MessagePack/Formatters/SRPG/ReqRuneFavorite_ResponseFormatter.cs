// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneFavorite_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200099D")]
  public sealed class ReqRuneFavorite_ResponseFormatter : 
    IMessagePackFormatter<ReqRuneFavorite.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017CA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017CB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002625")]
    [Address(RVA = "0xE46D20", Offset = "0xE45B20", VA = "0x10E46D20")]
    public ReqRuneFavorite_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002626")]
    [Address(RVA = "0xE46BB0", Offset = "0xE459B0", VA = "0x10E46BB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneFavorite.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002627")]
    [Address(RVA = "0xE468E0", Offset = "0xE456E0", VA = "0x10E468E0", Slot = "5")]
    public ReqRuneFavorite.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneFavorite.Response) null;
    }
  }
}
