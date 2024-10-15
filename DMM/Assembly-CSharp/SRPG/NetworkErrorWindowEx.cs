// Decompiled with JetBrains decompiler
// Type: SRPG.NetworkErrorWindowEx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027B7")]
  [AddComponentMenu("UI/NetworkErrorWindowEx")]
  public class NetworkErrorWindowEx : MonoBehaviour
  {
    [Token(Token = "0x400BC11")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text Message;
    [Token(Token = "0x400BC12")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button ButtonOk;

    [Token(Token = "0x600B262")]
    [Address(RVA = "0x7A7420", Offset = "0x7A6220", VA = "0x107A7420")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B263")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x17001891")]
    public string Body
    {
      [Token(Token = "0x600B264"), Address(RVA = "0x5A9D10", Offset = "0x5A8B10", VA = "0x105A9D10")] set
      {
      }
      [Token(Token = "0x600B265"), Address(RVA = "0x5A9CE0", Offset = "0x5A8AE0", VA = "0x105A9CE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600B266")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnOk()
    {
    }

    [Token(Token = "0x600B267")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public NetworkErrorWindowEx()
    {
    }
  }
}
