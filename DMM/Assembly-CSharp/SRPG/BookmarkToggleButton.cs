// Decompiled with JetBrains decompiler
// Type: SRPG.BookmarkToggleButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020EB")]
  [AddComponentMenu("UI/BookmarkToggleButton")]
  public class BookmarkToggleButton : MonoBehaviour
  {
    [Token(Token = "0x4008E45")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    public Text Text;
    [Token(Token = "0x4008E46")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject OnImage;
    [Token(Token = "0x4008E47")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject OffImage;
    [Token(Token = "0x4008E48")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject Shadow;

    [Token(Token = "0x6008977")]
    [Address(RVA = "0x4A3C20", Offset = "0x4A2A20", VA = "0x104A3C20")]
    public void Activate(bool doActivate)
    {
    }

    [Token(Token = "0x6008978")]
    [Address(RVA = "0x4A3C70", Offset = "0x4A2A70", VA = "0x104A3C70")]
    public void EnableShadow(bool enabled)
    {
    }

    [Token(Token = "0x6008979")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BookmarkToggleButton()
    {
    }
  }
}
