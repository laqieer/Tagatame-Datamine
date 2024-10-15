// Decompiled with JetBrains decompiler
// Type: ImageSpriteSheet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002B6")]
[AddComponentMenu("UI/ImageSpriteSheet (透明)")]
public class ImageSpriteSheet : Image
{
  [Token(Token = "0x4000B41")]
  [FieldOffset(Offset = "0xB0")]
  [StringIsResourcePath(typeof (SpriteSheet))]
  [SerializeField]
  [HeaderBar("▼スプライトシートのパス")]
  private string m_SpriteSheetPath;
  [Token(Token = "0x4000B42")]
  [FieldOffset(Offset = "0xB4")]
  [SerializeField]
  private string m_DefaultKey;
  [Token(Token = "0x4000B43")]
  [FieldOffset(Offset = "0xB8")]
  private SpriteSheet m_SpriteSheet;
  [Token(Token = "0x4000B44")]
  [FieldOffset(Offset = "0xBC")]
  private bool m_IsInitialized;
  [Token(Token = "0x4000B45")]
  [FieldOffset(Offset = "0xC0")]
  private string m_BeforeInitializationSetKey;

  [Token(Token = "0x6000E47")]
  [Address(RVA = "0x11D2AE0", Offset = "0x11D18E0", VA = "0x111D2AE0", Slot = "6")]
  protected override void Start()
  {
  }

  [Token(Token = "0x6000E48")]
  [Address(RVA = "0x11D2870", Offset = "0x11D1670", VA = "0x111D2870")]
  public void ForceLoad()
  {
  }

  [Token(Token = "0x170001B7")]
  public string DefaultKey
  {
    [Token(Token = "0x6000E49"), Address(RVA = "0x305C10", Offset = "0x304A10", VA = "0x10305C10")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x6000E4A")]
  [Address(RVA = "0x11D2A40", Offset = "0x11D1840", VA = "0x111D2A40")]
  public void SetSprite(string key)
  {
  }

  [Token(Token = "0x6000E4B")]
  [Address(RVA = "0x11D2940", Offset = "0x11D1740", VA = "0x111D2940")]
  public Sprite GetSprite(string key) => (Sprite) null;

  [Token(Token = "0x6000E4C")]
  [Address(RVA = "0x11D29C0", Offset = "0x11D17C0", VA = "0x111D29C0", Slot = "44")]
  protected override void OnPopulateMesh(VertexHelper toFill)
  {
  }

  [Token(Token = "0x6000E4D")]
  [Address(RVA = "0x11D2BF0", Offset = "0x11D19F0", VA = "0x111D2BF0")]
  public ImageSpriteSheet()
  {
  }
}
