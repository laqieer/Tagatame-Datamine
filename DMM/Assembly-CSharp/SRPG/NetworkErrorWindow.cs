// Decompiled with JetBrains decompiler
// Type: SRPG.NetworkErrorWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027B6")]
  [AddComponentMenu("UI/NetworkErrorWindow")]
  public class NetworkErrorWindow : MonoBehaviour
  {
    [Token(Token = "0x400BC0D")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text Title;
    [Token(Token = "0x400BC0E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text StatusCode;
    [Token(Token = "0x400BC0F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text Message;
    [Token(Token = "0x400BC10")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button m_Button;

    [Token(Token = "0x600B25B")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B25C")]
    [Address(RVA = "0x7A7650", Offset = "0x7A6450", VA = "0x107A7650")]
    private void Start()
    {
    }

    [Token(Token = "0x600B25D")]
    [Address(RVA = "0x7A74D0", Offset = "0x7A62D0", VA = "0x107A74D0")]
    private void OnClick()
    {
    }

    [Token(Token = "0x600B25E")]
    [Address(RVA = "0x7A7540", Offset = "0x7A6340", VA = "0x107A7540")]
    public void OpenMaintenanceSite()
    {
    }

    [Token(Token = "0x600B25F")]
    [Address(RVA = "0x7A7590", Offset = "0x7A6390", VA = "0x107A7590")]
    public void OpenVersionUpSite()
    {
    }

    [Token(Token = "0x600B260")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void OpenStore()
    {
    }

    [Token(Token = "0x600B261")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public NetworkErrorWindow()
    {
    }
  }
}
