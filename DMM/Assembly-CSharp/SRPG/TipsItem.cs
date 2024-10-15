// Decompiled with JetBrains decompiler
// Type: SRPG.TipsItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B29")]
  [AddComponentMenu("UI/TipsItem")]
  public class TipsItem : MonoBehaviour
  {
    [Token(Token = "0x400D2A9")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject BadgeObj;
    [Token(Token = "0x400D2AA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject CompleteObj;
    [Token(Token = "0x400D2AB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text TitleObj;
    [Token(Token = "0x400D2AC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject OverayImageObj;
    [Token(Token = "0x400D2AD")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button SelfButton;
    [Token(Token = "0x400D2AE")]
    [FieldOffset(Offset = "0x20")]
    public string Title;
    [Token(Token = "0x400D2AF")]
    [FieldOffset(Offset = "0x24")]
    public bool IsCompleted;
    [Token(Token = "0x400D2B0")]
    [FieldOffset(Offset = "0x25")]
    public bool IsHidden;

    [Token(Token = "0x600C585")]
    [Address(RVA = "0x8E0DA0", Offset = "0x8DFBA0", VA = "0x108E0DA0")]
    public void UpdateContent()
    {
    }

    [Token(Token = "0x600C586")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TipsItem()
    {
    }
  }
}
