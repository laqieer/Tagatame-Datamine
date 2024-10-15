// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt16Int64
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003FF")]
  internal sealed class UInt16Int64 : IInt64Decoder
  {
    [Token(Token = "0x4000E57")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt64Decoder Instance;

    [Token(Token = "0x6001444")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt16Int64()
    {
    }

    [Token(Token = "0x6001445")]
    [Address(RVA = "0x5CBAB0", Offset = "0x5CA8B0", VA = "0x105CBAB0", Slot = "4")]
    public long Read(byte[] bytes, int offset, out int readSize) => new long();

    [Token(Token = "0x6001446")]
    [Address(RVA = "0x5CBB10", Offset = "0x5CA910", VA = "0x105CBB10")]
    static UInt16Int64()
    {
    }
  }
}
