// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.Utils.xxHash
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace CodeStage.AntiCheat.Utils
{
  [Token(Token = "0x2003688")]
  internal class xxHash
  {
    [Token(Token = "0x400FFCC")]
    private const uint PRIME32_1 = 2654435761;
    [Token(Token = "0x400FFCD")]
    private const uint PRIME32_2 = 2246822519;
    [Token(Token = "0x400FFCE")]
    private const uint PRIME32_3 = 3266489917;
    [Token(Token = "0x400FFCF")]
    private const uint PRIME32_4 = 668265263;
    [Token(Token = "0x400FFD0")]
    private const uint PRIME32_5 = 374761393;

    [Token(Token = "0x600F428")]
    [Address(RVA = "0xB34C20", Offset = "0xB33A20", VA = "0x10B34C20")]
    public static uint CalculateHash(byte[] buf, int len, uint seed) => new uint();

    [Token(Token = "0x600F429")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public xxHash()
    {
    }
  }
}
