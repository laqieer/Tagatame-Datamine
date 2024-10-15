// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactCompareExtention
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200201D")]
  public static class ArtifactCompareExtention
  {
    [Token(Token = "0x60084DB")]
    [Address(RVA = "0x45ACB0", Offset = "0x459AB0", VA = "0x1045ACB0")]
    public static int CompareByID(this ArtifactParam x, ArtifactParam y) => new int();

    [Token(Token = "0x60084DC")]
    [Address(RVA = "0x45ACE0", Offset = "0x459AE0", VA = "0x1045ACE0")]
    public static int CompareByID(this ArtifactData x, ArtifactData y) => new int();

    [Token(Token = "0x60084DD")]
    [Address(RVA = "0x45ADF0", Offset = "0x459BF0", VA = "0x1045ADF0")]
    public static int CompareByType(this ArtifactParam x, ArtifactParam y) => new int();

    [Token(Token = "0x60084DE")]
    [Address(RVA = "0x45ADB0", Offset = "0x459BB0", VA = "0x1045ADB0")]
    public static int CompareByType(this ArtifactData x, ArtifactData y) => new int();

    [Token(Token = "0x60084DF")]
    [Address(RVA = "0x45AD20", Offset = "0x459B20", VA = "0x1045AD20")]
    public static int CompareByTypeAndID(this ArtifactParam x, ArtifactParam y) => new int();

    [Token(Token = "0x60084E0")]
    [Address(RVA = "0x45AD60", Offset = "0x459B60", VA = "0x1045AD60")]
    public static int CompareByTypeAndID(this ArtifactData x, ArtifactData y) => new int();
  }
}
