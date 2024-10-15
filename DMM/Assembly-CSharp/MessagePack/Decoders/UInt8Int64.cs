// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt8Int64
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003FE")]
  internal sealed class UInt8Int64 : IInt64Decoder
  {
    [Token(Token = "0x4000E56")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt64Decoder Instance;

    [Token(Token = "0x6001441")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt8Int64()
    {
    }

    [Token(Token = "0x6001442")]
    [Address(RVA = "0x5CC970", Offset = "0x5CB770", VA = "0x105CC970", Slot = "4")]
    public long Read(byte[] bytes, int offset, out int readSize) => new long();

    [Token(Token = "0x6001443")]
    [Address(RVA = "0x5CC9A0", Offset = "0x5CB7A0", VA = "0x105CC9A0")]
    static UInt8Int64()
    {
    }
  }
}
