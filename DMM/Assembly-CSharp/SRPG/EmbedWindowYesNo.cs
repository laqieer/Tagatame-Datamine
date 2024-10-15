// Decompiled with JetBrains decompiler
// Type: SRPG.EmbedWindowYesNo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002344")]
  [AddComponentMenu("UI/EmbedWindowYesNo")]
  public class EmbedWindowYesNo : MonoBehaviour
  {
    [Token(Token = "0x4009DE5")]
    public const string PrefabPath = "e/UI/EmbedWindowYesNo";
    [Token(Token = "0x4009DE6")]
    [FieldOffset(Offset = "0xC")]
    public EmbedWindowYesNo.YesNoWindowEvent Delegate;
    [Token(Token = "0x4009DE7")]
    [FieldOffset(Offset = "0x10")]
    public Text Message;
    [Token(Token = "0x4009DE8")]
    [FieldOffset(Offset = "0x14")]
    public Button ButtonOk;
    [Token(Token = "0x4009DE9")]
    [FieldOffset(Offset = "0x18")]
    public Button ButtonCancel;
    [Token(Token = "0x4009DEA")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject DLCheck;
    [Token(Token = "0x4009DEB")]
    [FieldOffset(Offset = "0x20")]
    public Toggle DLCToggle;

    [Token(Token = "0x60097F5")]
    [Address(RVA = "0x5AA3B0", Offset = "0x5A91B0", VA = "0x105AA3B0")]
    public static EmbedWindowYesNo Create(string msg, EmbedWindowYesNo.YesNoWindowEvent callback)
    {
      return (EmbedWindowYesNo) null;
    }

    [Token(Token = "0x60097F6")]
    [Address(RVA = "0x5AA240", Offset = "0x5A9040", VA = "0x105AA240")]
    private void Awake()
    {
    }

    [Token(Token = "0x17001543")]
    public string Body
    {
      [Token(Token = "0x60097F7"), Address(RVA = "0x5AA210", Offset = "0x5A9010", VA = "0x105AA210")] set
      {
      }
      [Token(Token = "0x60097F8"), Address(RVA = "0x5A9FE0", Offset = "0x5A8DE0", VA = "0x105A9FE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60097F9")]
    [Address(RVA = "0x5A9FB0", Offset = "0x5A8DB0", VA = "0x105A9FB0")]
    private void OnOk()
    {
    }

    [Token(Token = "0x60097FA")]
    [Address(RVA = "0x5AA470", Offset = "0x5A9270", VA = "0x105AA470")]
    private void OnCancel()
    {
    }

    [Token(Token = "0x60097FB")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void ShowDLCToggle()
    {
    }

    [Token(Token = "0x60097FC")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public EmbedWindowYesNo()
    {
    }

    [Token(Token = "0x2002345")]
    public delegate void YesNoWindowEvent(bool yes);
  }
}
