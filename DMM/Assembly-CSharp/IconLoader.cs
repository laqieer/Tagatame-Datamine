// Decompiled with JetBrains decompiler
// Type: IconLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000104")]
[AddComponentMenu("Common/IconLoader")]
public class IconLoader : MonoBehaviour
{
  [Token(Token = "0x40004D4")]
  [FieldOffset(Offset = "0xC")]
  private string mPath;
  [Token(Token = "0x40004D5")]
  [FieldOffset(Offset = "0x10")]
  private LoadRequest mResourceReq;
  [Token(Token = "0x40004D6")]
  [FieldOffset(Offset = "0x14")]
  private Texture mIcon;

  [Token(Token = "0x1700010B")]
  public string ResourcePath
  {
    [Token(Token = "0x60006B2"), Address(RVA = "0xD5A330", Offset = "0xD59130", VA = "0x10D5A330")] set
    {
    }
  }

  [Token(Token = "0x60006B3")]
  [Address(RVA = "0xD5A100", Offset = "0xD58F00", VA = "0x10D5A100")]
  private void Update()
  {
  }

  [Token(Token = "0x1700010C")]
  private Texture IconTexture
  {
    [Token(Token = "0x60006B4"), Address(RVA = "0xD5A2A0", Offset = "0xD590A0", VA = "0x10D5A2A0")] set
    {
    }
    [Token(Token = "0x60006B5"), Address(RVA = "0xD5A220", Offset = "0xD59020", VA = "0x10D5A220")] get
    {
      return (Texture) null;
    }
  }

  [Token(Token = "0x60006B6")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public IconLoader()
  {
  }
}
