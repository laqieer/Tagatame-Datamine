// Decompiled with JetBrains decompiler
// Type: SRPG.HomeGalleryIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002620")]
  [AddComponentMenu("UI/HomeGalleryIcon")]
  public class HomeGalleryIcon : MonoBehaviour
  {
    [Token(Token = "0x400B199")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Banner;
    [Token(Token = "0x400B19A")]
    [FieldOffset(Offset = "0x10")]
    private float mRefreshInterval;
    [Token(Token = "0x400B19B")]
    [FieldOffset(Offset = "0x14")]
    private HighlightParam[] mHilights;

    [Token(Token = "0x600AA10")]
    [Address(RVA = "0x6D3220", Offset = "0x6D2020", VA = "0x106D3220")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AA11")]
    [Address(RVA = "0x6D33A0", Offset = "0x6D21A0", VA = "0x106D33A0")]
    private void Update()
    {
    }

    [Token(Token = "0x600AA12")]
    [Address(RVA = "0x6D3320", Offset = "0x6D2120", VA = "0x106D3320")]
    private void CheckAvailable()
    {
    }

    [Token(Token = "0x600AA13")]
    [Address(RVA = "0x6D33F0", Offset = "0x6D21F0", VA = "0x106D33F0")]
    public HomeGalleryIcon()
    {
    }
  }
}
