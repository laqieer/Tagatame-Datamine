// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqAdventure_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B1E")]
  public sealed class ReqAdventure_ResponseFormatter : 
    IMessagePackFormatter<ReqAdventure.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001ACC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001ACD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AA8")]
    [Address(RVA = "0xF41400", Offset = "0xF40200", VA = "0x10F41400")]
    public ReqAdventure_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002AA9")]
    [Address(RVA = "0xF41220", Offset = "0xF40020", VA = "0x10F41220", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqAdventure.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AAA")]
    [Address(RVA = "0xF40ED0", Offset = "0xF3FCD0", VA = "0x10F40ED0", Slot = "5")]
    public ReqAdventure.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqAdventure.Response) null;
    }
  }
}
