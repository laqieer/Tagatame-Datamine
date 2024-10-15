// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt8UInt32
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200040E")]
  internal sealed class UInt8UInt32 : IUInt32Decoder
  {
    [Token(Token = "0x4000E64")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IUInt32Decoder Instance;

    [Token(Token = "0x600146D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt8UInt32()
    {
    }

    [Token(Token = "0x600146E")]
    [Address(RVA = "0x5CC880", Offset = "0x5CB680", VA = "0x105CC880", Slot = "4")]
    public uint Read(byte[] bytes, int offset, out int readSize) => new uint();

    [Token(Token = "0x600146F")]
    [Address(RVA = "0x5CCB40", Offset = "0x5CB940", VA = "0x105CCB40")]
    static UInt8UInt32()
    {
    }
  }
}
