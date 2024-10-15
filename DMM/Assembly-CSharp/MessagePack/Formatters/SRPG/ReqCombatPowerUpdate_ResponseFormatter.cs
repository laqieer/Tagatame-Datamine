// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqCombatPowerUpdate_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008B9")]
  public sealed class ReqCombatPowerUpdate_ResponseFormatter : 
    IMessagePackFormatter<ReqCombatPowerUpdate.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001602")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001603")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002379")]
    [Address(RVA = "0xDC41B0", Offset = "0xDC2FB0", VA = "0x10DC41B0")]
    public ReqCombatPowerUpdate_ResponseFormatter()
    {
    }

    [Token(Token = "0x600237A")]
    [Address(RVA = "0xDC40B0", Offset = "0xDC2EB0", VA = "0x10DC40B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqCombatPowerUpdate.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600237B")]
    [Address(RVA = "0xDC3DE0", Offset = "0xDC2BE0", VA = "0x10DC3DE0", Slot = "5")]
    public ReqCombatPowerUpdate.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqCombatPowerUpdate.Response) null;
    }
  }
}
