// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt32Double
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003E4")]
  internal sealed class UInt32Double : IDoubleDecoder
  {
    [Token(Token = "0x4000E3F")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IDoubleDecoder Instance;

    [Token(Token = "0x60013F9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt32Double()
    {
    }

    [Token(Token = "0x60013FA")]
    [Address(RVA = "0x5CBD70", Offset = "0x5CAB70", VA = "0x105CBD70", Slot = "4")]
    public double Read(byte[] bytes, int offset, out int readSize) => new double();

    [Token(Token = "0x60013FB")]
    [Address(RVA = "0x5CBE00", Offset = "0x5CAC00", VA = "0x105CBE00")]
    static UInt32Double()
    {
    }
  }
}
