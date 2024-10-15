// Decompiled with JetBrains decompiler
// Type: SRPG.CharacterComposer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E7D")]
  public struct CharacterComposer
  {
    [Token(Token = "0x4002C6D")]
    [FieldOffset(Offset = "0x0")]
    public GameObject Body;
    [Token(Token = "0x4002C6E")]
    [FieldOffset(Offset = "0x4")]
    public GameObject BodyAttachment;
    [Token(Token = "0x4002C6F")]
    [FieldOffset(Offset = "0x8")]
    public Texture2D BodyTexture;
    [Token(Token = "0x4002C70")]
    [FieldOffset(Offset = "0xC")]
    public GameObject Head;
    [Token(Token = "0x4002C71")]
    [FieldOffset(Offset = "0x10")]
    public GameObject HeadAttachment;
    [Token(Token = "0x4002C72")]
    [FieldOffset(Offset = "0x14")]
    public GameObject Hair;
    [Token(Token = "0x4002C73")]
    [FieldOffset(Offset = "0x18")]
    public Color32 HairColor0;
    [Token(Token = "0x4002C74")]
    [FieldOffset(Offset = "0x1C")]
    public Color32 HairColor1;

    [Token(Token = "0x17000483")]
    public bool IsValid
    {
      [Token(Token = "0x6003C1C"), Address(RVA = "0x10E8840", Offset = "0x10E7640", VA = "0x110E8840")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003C1D")]
    [Address(RVA = "0x10E8250", Offset = "0x10E7050", VA = "0x110E8250")]
    public void LoadImmediately(string characterID, ESex sex, string jobID)
    {
    }

    [Token(Token = "0x6003C1E")]
    [Address(RVA = "0x10E7A70", Offset = "0x10E6870", VA = "0x110E7A70")]
    public GameObject Compose(Vector3 position, Quaternion rotation) => (GameObject) null;
  }
}
