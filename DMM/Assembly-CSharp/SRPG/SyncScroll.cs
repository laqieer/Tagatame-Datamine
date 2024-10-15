// Decompiled with JetBrains decompiler
// Type: SRPG.SyncScroll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B1F")]
  [AddComponentMenu("UI/SyncScroll")]
  public class SyncScroll : MonoBehaviour
  {
    [Token(Token = "0x400D278")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ScrollRect m_ScrollRect;
    [Token(Token = "0x400D279")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SyncScroll.ScrollMode m_ScrollMode;
    [Token(Token = "0x400D27A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RectTransform parent;
    [Token(Token = "0x400D27B")]
    [FieldOffset(Offset = "0x18")]
    private RectTransform rectTransform;

    [Token(Token = "0x17001A37")]
    public bool isNormal
    {
      [Token(Token = "0x600C553"), Address(RVA = "0x37AD10", Offset = "0x379B10", VA = "0x1037AD10")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C554"), Address(RVA = "0x8DEBD0", Offset = "0x8DD9D0", VA = "0x108DEBD0")] set
      {
      }
    }

    [Token(Token = "0x17001A38")]
    public bool isReverse
    {
      [Token(Token = "0x600C555"), Address(RVA = "0x61CA00", Offset = "0x61B800", VA = "0x1061CA00")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C556"), Address(RVA = "0x8DEBF0", Offset = "0x8DD9F0", VA = "0x108DEBF0")] set
      {
      }
    }

    [Token(Token = "0x17001A39")]
    public SyncScroll.ScrollMode scrollMode
    {
      [Token(Token = "0x600C557"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new SyncScroll.ScrollMode();
      }
      [Token(Token = "0x600C558"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] set
      {
      }
    }

    [Token(Token = "0x600C559")]
    [Address(RVA = "0x8DE7A0", Offset = "0x8DD5A0", VA = "0x108DE7A0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C55A")]
    [Address(RVA = "0x8DE890", Offset = "0x8DD690", VA = "0x108DE890")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x600C55B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public SyncScroll()
    {
    }

    [Token(Token = "0x2002B20")]
    public enum ScrollMode
    {
      [Token(Token = "0x400D27D")] Normal,
      [Token(Token = "0x400D27E")] Reverse,
    }
  }
}
