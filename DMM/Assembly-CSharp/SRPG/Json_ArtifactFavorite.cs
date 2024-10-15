// Decompiled with JetBrains decompiler
// Type: SRPG.Json_ArtifactFavorite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200102E")]
  public class Json_ArtifactFavorite
  {
    [Token(Token = "0x400398F")]
    [FieldOffset(Offset = "0x8")]
    public Json_PlayerData player;
    [Token(Token = "0x4003990")]
    [FieldOffset(Offset = "0xC")]
    public Json_Artifact[] artifacts;

    [Token(Token = "0x6004294")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_ArtifactFavorite()
    {
    }
  }
}
