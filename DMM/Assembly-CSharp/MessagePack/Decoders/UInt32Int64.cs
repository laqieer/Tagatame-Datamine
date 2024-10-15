// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt32Int64
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000400")]
  internal sealed class UInt32Int64 : IInt64Decoder
  {
    [Token(Token = "0x4000E58")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt64Decoder Instance;

    [Token(Token = "0x6001447")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt32Int64()
    {
    }

    [Token(Token = "0x6001448")]
    [Address(RVA = "0x5CBF90", Offset = "0x5CAD90", VA = "0x105CBF90", Slot = "4")]
    public long Read(byte[] bytes, int offset, out int readSize) => new long();

    [Token(Token = "0x6001449")]
    [Address(RVA = "0x5CC030", Offset = "0x5CAE30", VA = "0x105CC030")]
    static UInt32Int64()
    {
    }
  }
}
