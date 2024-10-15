// Decompiled with JetBrains decompiler
// Type: SRPG.GiftRecieveItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200251A")]
  [AddComponentMenu("UI/GiftRecieveItem")]
  public class GiftRecieveItem : MonoBehaviour
  {
    [Token(Token = "0x400A997")]
    [FieldOffset(Offset = "0xC")]
    public RawImage Icon;
    [Token(Token = "0x400A998")]
    [FieldOffset(Offset = "0x10")]
    public Image Frame;
    [Token(Token = "0x400A999")]
    [FieldOffset(Offset = "0x14")]
    public Text NameText;
    [Token(Token = "0x400A99A")]
    [FieldOffset(Offset = "0x18")]
    public Text AddText;
    [Token(Token = "0x400A99B")]
    [FieldOffset(Offset = "0x1C")]
    public Text NumText;
    [Token(Token = "0x400A99C")]
    [FieldOffset(Offset = "0x20")]
    public CrystalIcon CrystalIcon;
    [Token(Token = "0x400A99D")]
    [FieldOffset(Offset = "0x24")]
    [HeaderBar("▼IconとFrameの描画順自動入れかえを行うか？")]
    public bool EnableSwapIconFramePriority;

    [Token(Token = "0x170016C0")]
    private bool HideNumText
    {
      [Token(Token = "0x600A309"), Address(RVA = "0x650AB0", Offset = "0x64F8B0", VA = "0x10650AB0")] set
      {
      }
    }

    [Token(Token = "0x600A30A")]
    [Address(RVA = "0x650100", Offset = "0x64EF00", VA = "0x10650100")]
    private void Start()
    {
    }

    [Token(Token = "0x600A30B")]
    [Address(RVA = "0x650020", Offset = "0x64EE20", VA = "0x10650020")]
    private string GetIconPath(ArtifactParam param) => (string) null;

    [Token(Token = "0x600A30C")]
    [Address(RVA = "0x650070", Offset = "0x64EE70", VA = "0x10650070")]
    private string GetIconPath(ItemParam param) => (string) null;

    [Token(Token = "0x600A30D")]
    [Address(RVA = "0x64FFD0", Offset = "0x64EDD0", VA = "0x1064FFD0")]
    private string GetIconPath(ConceptCardParam param) => (string) null;

    [Token(Token = "0x600A30E")]
    [Address(RVA = "0x64FF80", Offset = "0x64ED80", VA = "0x1064FF80")]
    private Sprite GetFrameSprite(ArtifactParam param, int rarity) => (Sprite) null;

    [Token(Token = "0x600A30F")]
    [Address(RVA = "0x64FF00", Offset = "0x64ED00", VA = "0x1064FF00")]
    private Sprite GetFrameSprite(ItemParam param, int rarity) => (Sprite) null;

    [Token(Token = "0x600A310")]
    [Address(RVA = "0x64FF40", Offset = "0x64ED40", VA = "0x1064FF40")]
    private Sprite GetFrameSprite(ConceptCardParam param, int rarity) => (Sprite) null;

    [Token(Token = "0x600A311")]
    [Address(RVA = "0x6500C0", Offset = "0x64EEC0", VA = "0x106500C0")]
    private string GetName(ArtifactParam param) => (string) null;

    [Token(Token = "0x600A312")]
    [Address(RVA = "0x6500E0", Offset = "0x64EEE0", VA = "0x106500E0")]
    private string GetName(ItemParam param) => (string) null;

    [Token(Token = "0x600A313")]
    [Address(RVA = "0x6500C0", Offset = "0x64EEC0", VA = "0x106500C0")]
    private string GetName(ConceptCardParam param) => (string) null;

    [Token(Token = "0x600A314")]
    [Address(RVA = "0x650290", Offset = "0x64F090", VA = "0x10650290")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x600A315")]
    [Address(RVA = "0x650110", Offset = "0x64EF10", VA = "0x10650110")]
    private void SwapIconFramePriority(bool iconIsTop)
    {
    }

    [Token(Token = "0x600A316")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GiftRecieveItem()
    {
    }
  }
}
