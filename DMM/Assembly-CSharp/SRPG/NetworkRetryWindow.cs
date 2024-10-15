// Decompiled with JetBrains decompiler
// Type: SRPG.NetworkRetryWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027B8")]
  [AddComponentMenu("UI/NetworkRetryWindow")]
  public class NetworkRetryWindow : MonoBehaviour
  {
    [Token(Token = "0x400BC13")]
    [FieldOffset(Offset = "0xC")]
    public NetworkRetryWindow.RetryWindowEvent Delegate;
    [Token(Token = "0x400BC14")]
    [FieldOffset(Offset = "0x10")]
    public Text Title;
    [Token(Token = "0x400BC15")]
    [FieldOffset(Offset = "0x14")]
    public Text Message;
    [Token(Token = "0x400BC16")]
    [FieldOffset(Offset = "0x18")]
    public Button ButtonOk;
    [Token(Token = "0x400BC17")]
    [FieldOffset(Offset = "0x1C")]
    public Button ButtonCancel;

    [Token(Token = "0x600B268")]
    [Address(RVA = "0x7A7AB0", Offset = "0x7A68B0", VA = "0x107A7AB0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B269")]
    [Address(RVA = "0x7A7C30", Offset = "0x7A6A30", VA = "0x107A7C30")]
    private void Start()
    {
    }

    [Token(Token = "0x17001892")]
    public string Body
    {
      [Token(Token = "0x600B26A"), Address(RVA = "0x7A7D10", Offset = "0x7A6B10", VA = "0x107A7D10")] set
      {
      }
      [Token(Token = "0x600B26B"), Address(RVA = "0x7A7CE0", Offset = "0x7A6AE0", VA = "0x107A7CE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600B26C")]
    [Address(RVA = "0x5A9FB0", Offset = "0x5A8DB0", VA = "0x105A9FB0")]
    private void OnOk()
    {
    }

    [Token(Token = "0x600B26D")]
    [Address(RVA = "0x5AA470", Offset = "0x5A9270", VA = "0x105AA470")]
    private void OnCancel()
    {
    }

    [Token(Token = "0x600B26E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public NetworkRetryWindow()
    {
    }

    [Token(Token = "0x20027B9")]
    public delegate void RetryWindowEvent(bool retry);
  }
}
