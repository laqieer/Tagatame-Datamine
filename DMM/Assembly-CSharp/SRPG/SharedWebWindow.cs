// Decompiled with JetBrains decompiler
// Type: SRPG.SharedWebWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A81")]
  [AddComponentMenu("UI/SharedWebWindow")]
  public class SharedWebWindow : MonoBehaviour
  {
    [Token(Token = "0x400CEDF")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private WebView Target;
    [Token(Token = "0x400CEE0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject Caution;
    [Token(Token = "0x400CEE1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private bool usegAuth;

    [Token(Token = "0x600C211")]
    [Address(RVA = "0x8A6B60", Offset = "0x8A5960", VA = "0x108A6B60")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C212")]
    [Address(RVA = "0x8A6F50", Offset = "0x8A5D50", VA = "0x108A6F50")]
    public void SetClose(UIUtility.DialogResultEvent onClose, Button button)
    {
    }

    [Token(Token = "0x600C213")]
    [Address(RVA = "0x8A6FE0", Offset = "0x8A5DE0", VA = "0x108A6FE0")]
    private IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x600C214")]
    [Address(RVA = "0x8A7050", Offset = "0x8A5E50", VA = "0x108A7050")]
    public void UpdateWebView(bool reopen = false)
    {
    }

    [Token(Token = "0x600C215")]
    [Address(RVA = "0x5AAC10", Offset = "0x5A9A10", VA = "0x105AAC10")]
    public SharedWebWindow()
    {
    }
  }
}
