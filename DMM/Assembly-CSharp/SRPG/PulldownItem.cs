// Decompiled with JetBrains decompiler
// Type: SRPG.PulldownItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002860")]
  [AddComponentMenu("UI/PulldownItem")]
  public class PulldownItem : MonoBehaviour
  {
    [Token(Token = "0x400C0C9")]
    [FieldOffset(Offset = "0xC")]
    public Text Text;
    [Token(Token = "0x400C0CA")]
    [FieldOffset(Offset = "0x10")]
    public Graphic Graphic;
    [Token(Token = "0x400C0CB")]
    [FieldOffset(Offset = "0x14")]
    public int Value;
    [Token(Token = "0x400C0CC")]
    [FieldOffset(Offset = "0x18")]
    public Image Overray;
    [Token(Token = "0x400C0CD")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject LockObject;
    [Token(Token = "0x400C0CE")]
    [FieldOffset(Offset = "0x20")]
    public bool IsLock;

    [Token(Token = "0x600B66E")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public virtual void OnStatusChanged(bool enabled)
    {
    }

    [Token(Token = "0x600B66F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PulldownItem()
    {
    }
  }
}
