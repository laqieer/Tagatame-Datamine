// Decompiled with JetBrains decompiler
// Type: SRPG.ChallengeCountResetCompleteWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200211C")]
  [AddComponentMenu("UI/ChallengeCountResetCompleteWindow")]
  public class ChallengeCountResetCompleteWindow : MonoBehaviour
  {
    [Token(Token = "0x4008F97")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text ChallengeCountResetNum;
    [Token(Token = "0x4008F98")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text ChallengeCountResetMax;
    [Token(Token = "0x4008F99")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button DecideButton;
    [Token(Token = "0x4008F9A")]
    [FieldOffset(Offset = "0x18")]
    public ChallengeCountResetCompleteWindow.DecideButtonEvent DecideEvent;

    [Token(Token = "0x6008AB6")]
    [Address(RVA = "0x4E51F0", Offset = "0x4E3FF0", VA = "0x104E51F0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008AB7")]
    [Address(RVA = "0x4E52A0", Offset = "0x4E40A0", VA = "0x104E52A0")]
    private void OnClickEvent()
    {
    }

    [Token(Token = "0x6008AB8")]
    [Address(RVA = "0x4E52D0", Offset = "0x4E40D0", VA = "0x104E52D0")]
    public void Setup(
      int reset_num,
      int reset_max,
      ChallengeCountResetCompleteWindow.DecideButtonEvent okEvnet)
    {
    }

    [Token(Token = "0x6008AB9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ChallengeCountResetCompleteWindow()
    {
    }

    [Token(Token = "0x200211D")]
    public delegate void DecideButtonEvent(GameObject dialog);
  }
}
