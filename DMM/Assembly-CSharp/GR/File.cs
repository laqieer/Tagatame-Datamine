// Decompiled with JetBrains decompiler
// Type: GR.File
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GR
{
  [Token(Token = "0x200032C")]
  public class File
  {
    [Token(Token = "0x6001104")]
    [Address(RVA = "0x12A11F0", Offset = "0x129FFF0", VA = "0x112A11F0")]
    public static void Write(string path, string data)
    {
    }

    [Token(Token = "0x6001105")]
    [Address(RVA = "0x12A1150", Offset = "0x129FF50", VA = "0x112A1150")]
    public static string Read(string path) => (string) null;

    [Token(Token = "0x6001106")]
    [Address(RVA = "0x12A11E0", Offset = "0x129FFE0", VA = "0x112A11E0")]
    public static void WriteAllBytes(string path, byte[] bytes)
    {
    }

    [Token(Token = "0x6001107")]
    [Address(RVA = "0x12A1140", Offset = "0x129FF40", VA = "0x112A1140")]
    public static byte[] ReadAllBytes(string path) => (byte[]) null;

    [Token(Token = "0x6001108")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public File()
    {
    }
  }
}
