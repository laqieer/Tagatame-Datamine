// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.FarmHash
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Runtime.CompilerServices;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x200046A")]
  public static class FarmHash
  {
    [Token(Token = "0x4000EFE")]
    private const uint c1 = 3432918353;
    [Token(Token = "0x4000EFF")]
    private const uint c2 = 461845907;
    [Token(Token = "0x4000F00")]
    private const ulong k0 = 14097894508562428199;
    [Token(Token = "0x4000F01")]
    private const ulong k1 = 13011662864482103923;
    [Token(Token = "0x4000F02")]
    private const ulong k2 = 11160318154034397263;

    [Token(Token = "0x60015BE")]
    [Address(RVA = "0x5BE9A0", Offset = "0x5BD7A0", VA = "0x105BE9A0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint Hash32(byte[] bytes, int offset, int count) => new uint();

    [Token(Token = "0x60015BF")]
    [Address(RVA = "0x294060", Offset = "0x292E60", VA = "0x10294060")]
    private static unsafe uint Fetch32(byte* p) => new uint();

    [Token(Token = "0x60015C0")]
    [Address(RVA = "0x5BEAB0", Offset = "0x5BD8B0", VA = "0x105BEAB0")]
    private static uint Rotate32(uint val, int shift) => new uint();

    [Token(Token = "0x60015C1")]
    [Address(RVA = "0x5BEB90", Offset = "0x5BD990", VA = "0x105BEB90")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint fmix(uint h) => new uint();

    [Token(Token = "0x60015C2")]
    [Address(RVA = "0x5BEA80", Offset = "0x5BD880", VA = "0x105BEA80")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint Mur(uint a, uint h) => new uint();

    [Token(Token = "0x60015C3")]
    [Address(RVA = "0x5B9400", Offset = "0x5B8200", VA = "0x105B9400")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint Hash32Len0to4(byte[] s, int offset, uint len) => new uint();

    [Token(Token = "0x60015C4")]
    [Address(RVA = "0x5B95C0", Offset = "0x5B83C0", VA = "0x105B95C0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe uint Hash32Len5to12(byte* s, uint len) => new uint();

    [Token(Token = "0x60015C5")]
    [Address(RVA = "0x5B94E0", Offset = "0x5B82E0", VA = "0x105B94E0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe uint Hash32Len13to24(byte* s, uint len) => new uint();

    [Token(Token = "0x60015C6")]
    [Address(RVA = "0x5B9660", Offset = "0x5B8460", VA = "0x105B9660")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe uint Hash32(byte* s, uint len) => new uint();

    [Token(Token = "0x60015C7")]
    [Address(RVA = "0x5BE9F0", Offset = "0x5BD7F0", VA = "0x105BE9F0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong Hash64(byte[] bytes, int offset, int count) => new ulong();

    [Token(Token = "0x60015C8")]
    [Address(RVA = "0x5BEBC0", Offset = "0x5BD9C0", VA = "0x105BEBC0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FarmHash.pair make_pair(ulong first, ulong second) => new FarmHash.pair();

    [Token(Token = "0x60015C9")]
    [Address(RVA = "0x5BEBE0", Offset = "0x5BD9E0", VA = "0x105BEBE0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void swap(ref ulong x, ref ulong z)
    {
    }

    [Token(Token = "0x60015CA")]
    [Address(RVA = "0x5BE900", Offset = "0x5BD700", VA = "0x105BE900")]
    private static unsafe ulong Fetch64(byte* p) => new ulong();

    [Token(Token = "0x60015CB")]
    [Address(RVA = "0x5BEAE0", Offset = "0x5BD8E0", VA = "0x105BEAE0")]
    private static ulong Rotate64(ulong val, int shift) => new ulong();

    [Token(Token = "0x60015CC")]
    [Address(RVA = "0x5BEB20", Offset = "0x5BD920", VA = "0x105BEB20")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ulong ShiftMix(ulong val) => new ulong();

    [Token(Token = "0x60015CD")]
    [Address(RVA = "0x5BEA20", Offset = "0x5BD820", VA = "0x105BEA20")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ulong HashLen16(ulong u, ulong v, ulong mul) => new ulong();

    [Token(Token = "0x60015CE")]
    [Address(RVA = "0x5BA440", Offset = "0x5B9240", VA = "0x105BA440")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe ulong Hash64(byte* s, uint len) => new ulong();

    [Token(Token = "0x60015CF")]
    [Address(RVA = "0x5BA4D0", Offset = "0x5B92D0", VA = "0x105BA4D0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe ulong HashLen0to16(byte* s, uint len) => new ulong();

    [Token(Token = "0x60015D0")]
    [Address(RVA = "0x5BA6C0", Offset = "0x5B94C0", VA = "0x105BA6C0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe ulong HashLen17to32(byte* s, uint len) => new ulong();

    [Token(Token = "0x60015D1")]
    [Address(RVA = "0x5B92D0", Offset = "0x5B80D0", VA = "0x105B92D0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe ulong H32(byte* s, uint len, ulong mul, ulong seed0 = 0, ulong seed1 = 0)
    {
      return new ulong();
    }

    [Token(Token = "0x60015D2")]
    [Address(RVA = "0x5BA800", Offset = "0x5B9600", VA = "0x105BA800")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe ulong HashLen33to64(byte* s, uint len) => new ulong();

    [Token(Token = "0x60015D3")]
    [Address(RVA = "0x5BA890", Offset = "0x5B9690", VA = "0x105BA890")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe ulong HashLen65to96(byte* s, uint len) => new ulong();

    [Token(Token = "0x60015D4")]
    [Address(RVA = "0x5BA960", Offset = "0x5B9760", VA = "0x105BA960")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FarmHash.pair WeakHashLen32WithSeeds(
      ulong w,
      ulong x,
      ulong y,
      ulong z,
      ulong a,
      ulong b)
    {
      return new FarmHash.pair();
    }

    [Token(Token = "0x60015D5")]
    [Address(RVA = "0x5BEB40", Offset = "0x5BD940", VA = "0x105BEB40")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe FarmHash.pair WeakHashLen32WithSeeds(byte* s, ulong a, ulong b)
    {
      return new FarmHash.pair();
    }

    [Token(Token = "0x60015D6")]
    [Address(RVA = "0x5B9860", Offset = "0x5B8660", VA = "0x105B9860")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe ulong Hash64NA(byte* s, uint len) => new ulong();

    [Token(Token = "0x60015D7")]
    [Address(RVA = "0x5BE910", Offset = "0x5BD710", VA = "0x105BE910")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ulong H(ulong x, ulong y, ulong mul, int r) => new ulong();

    [Token(Token = "0x60015D8")]
    [Address(RVA = "0x5B9DA0", Offset = "0x5B8BA0", VA = "0x105B9DA0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe ulong Hash64UO(byte* s, uint len) => new ulong();

    [Token(Token = "0x200046B")]
    private struct pair
    {
      [Token(Token = "0x4000F03")]
      [FieldOffset(Offset = "0x0")]
      public ulong first;
      [Token(Token = "0x4000F04")]
      [FieldOffset(Offset = "0x8")]
      public ulong second;

      [Token(Token = "0x60015D9")]
      [Address(RVA = "0x5CDF20", Offset = "0x5CCD20", VA = "0x105CDF20")]
      public pair(ulong first, ulong second)
      {
      }
    }
  }
}
