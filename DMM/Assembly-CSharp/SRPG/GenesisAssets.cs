// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisAssets
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20024DB")]
  public class GenesisAssets : ScriptableObject
  {
    [Token(Token = "0x400A843")]
    [FieldOffset(Offset = "0xC")]
    [StringIsResourcePath(typeof (GameObject))]
    public string[] ChapterBG;
    [Token(Token = "0x400A844")]
    [FieldOffset(Offset = "0x10")]
    [StringIsResourcePath(typeof (GameObject))]
    public string[] StageBG;
    [Token(Token = "0x400A845")]
    [FieldOffset(Offset = "0x14")]
    [StringIsResourcePath(typeof (GameObject))]
    public string[] StagePreview;
    [Token(Token = "0x400A846")]
    [FieldOffset(Offset = "0x18")]
    [StringIsResourcePath(typeof (GameObject))]
    public string[] BossBG;
    [Token(Token = "0x400A847")]
    [FieldOffset(Offset = "0x1C")]
    [StringIsResourcePath(typeof (GameObject))]
    public string[] GachaTopImage;

    [Token(Token = "0x600A1B6")]
    [Address(RVA = "0x2CE1D0", Offset = "0x2CCFD0", VA = "0x102CE1D0")]
    public GenesisAssets()
    {
    }
  }
}
