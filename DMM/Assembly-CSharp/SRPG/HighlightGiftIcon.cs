// Decompiled with JetBrains decompiler
// Type: SRPG.HighlightGiftIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200261B")]
  [AddComponentMenu("UI/HighlightGiftIcon")]
  public class HighlightGiftIcon : MonoBehaviour
  {
    [Token(Token = "0x400B179")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject AnimationStamp;
    [Token(Token = "0x400B17A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject Stamp;

    [Token(Token = "0x600A9ED")]
    [Address(RVA = "0x6D3020", Offset = "0x6D1E20", VA = "0x106D3020")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600A9EE")]
    [Address(RVA = "0x6D30D0", Offset = "0x6D1ED0", VA = "0x106D30D0")]
    public void SetStamp(bool playAnimation)
    {
    }

    [Token(Token = "0x600A9EF")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public HighlightGiftIcon()
    {
    }
  }
}
